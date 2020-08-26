using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using System.Runtime.InteropServices;

namespace MissionPlanner.Joystick
{
    public class TcpEventArgs: EventArgs
    {
        Socket socket;

        public TcpEventArgs(Socket socket)
        {
            this.socket = socket;
        }
    }

    public class TcpExceptionEventArgs: EventArgs
    {
        SocketException se;
        Socket socket;

        public SocketException Error
        {
            get { return se; }
        }

        public IPEndPoint TcpEndPoint
        {
            get { return (IPEndPoint)(socket.RemoteEndPoint); }
        }


        public TcpExceptionEventArgs(Socket socket, SocketException se)
        {
            this.socket = socket;
            this.se = se;
        }
    }

    public class TcpTransmissionEventArgs: EventArgs
    {
        Socket socket;
        //IPEndPoint endPoint;
        byte[] data;

        public TcpTransmissionEventArgs(Socket socket, byte[] data)
        {
            this.socket = socket;
            this.data = data;
        }

        public IPEndPoint TcpEndPoint
        {
            get { return (IPEndPoint)(socket.RemoteEndPoint); }
        }

        public byte[] Data
        {
            get { return data; }
        }
    }

    public class TcpEx
    {
        #region 变量

        /// <summary>
        /// 本地主动关闭标识符。
        /// </summary>
        private bool localDisconnectSignal = false;

        /// <summary>
        /// 断开连接的线程信息量。
        /// </summary>
        AutoResetEvent disconnectDone = new AutoResetEvent(false);

        /// <summary>
        /// 线程同步信息量。
        /// </summary>
        ManualResetEvent mre = new ManualResetEvent(false);

        // 作为服务器端，是否需要在断开连接后自动打开侦听的标识符。
        private bool autoListen = false;

        /// <summary>
        /// 委托事件模型。
        /// </summary>
        public delegate void TcpHandler(object sender, EventArgs e);
        public delegate void TcpEventHandler(object sender, TcpEventArgs e);
        public delegate void TcpExceptionEventHandler(object sender, TcpExceptionEventArgs e);
        public delegate void TcpTransmissionEventHandler(object sender, TcpTransmissionEventArgs e);

        /// <summary>
        /// 消息到来时发生。
        /// </summary>
        public event TcpTransmissionEventHandler DataArrived;

        /// <summary>
        /// TcpEx成功连接到远程主机后发生。
        /// </summary>
        public event TcpEventHandler Connected;

        /// <summary>
        /// TcpEx成功与远程主机断开后发生。
        /// </summary>
        public event TcpEventHandler Disconnected;

        /// <summary>
        /// TcpEx开始监听远程主机时发生。
        /// </summary>
        public event TcpHandler Listening;

        /// <summary>
        /// TcpEx接受远程主机的连接后发生。
        /// </summary>
        public event TcpEventHandler Accepted;

        /// <summary>
        /// TcpEx连接发生错误时发生。
        /// </summary>
        public event TcpExceptionEventHandler ExceptionOccurred;

        /// <summary>
        /// 侦听专用套接字。
        /// </summary>
        Socket client;

        /// <summary>
        /// 接收发送专用套接字。
        /// </summary>
        Socket socket;

        /// <summary>
        /// 当前端口。
        /// </summary>
        int port;

        /// <summary>
        /// 当前IP。
        /// </summary>
        IPAddress address;

        Queue<byte[]> bufferQueue = new Queue<byte[]>();

        /// <summary>
        /// 缓冲区。
        /// </summary>
        byte[] buffer;

        /// <summary>
        /// 有效数据。
        /// </summary>
        byte[] data;

        #endregion

        #region 构造函数

        /// <summary>
        /// 实现 Berkeley 套接字接口。
        /// </summary>
        /// <param name="port">本地端口号。</param>
        public TcpEx(int port)
        {
            this.address = Dns.GetHostAddresses(Dns.GetHostName())[0];
            this.port = port;
            buffer = new byte[8192];
        }

        /// <summary>
        /// 实现 Berkeley 套接字接口。
        /// </summary>
        /// <param name="address">本地IP地址。</param>
        /// <param name="port">本地端口号。</param>
        public TcpEx(IPAddress address, int port)
        {
            this.address = address;
            this.port = port;
            buffer = new byte[8192];
        }

        /// <summary>
        /// 实现 Berkeley 套接字接口。
        /// </summary>
        /// <param name="address">本地IP地址。</param>
        /// <param name="port">本地端口号。</param>
        /// <param name="buffersize">缓冲区大小。</param>
        public TcpEx(IPAddress address, int port, int buffersize)
        {
            this.address = address;
            this.port = port;
            buffer = new byte[buffersize];
        }

        #endregion

        #region 事件实现

        protected virtual void OnListening()
        {
            if (Listening != null)
            {
                Listening(this, null);
            }
        }

        protected virtual void OnDataArrived(TcpTransmissionEventArgs e)
        {
            if (DataArrived != null)
            {
                DataArrived(this, e);
            }
        }

        protected virtual void OnConnected(TcpEventArgs e)
        {
            if (Connected != null)
            {
                Connected(this, e);
            }
        }

        protected virtual void OnDisconnected(TcpEventArgs e)
        {
            if (Disconnected != null)
            {
                Disconnected(this, e);
            }
        }

        protected virtual void OnAccepted(TcpEventArgs e)
        {
            if (Accepted != null)
            {
                Accepted(this, e);
            }
        }

        protected virtual void OnExceptionOccured(TcpExceptionEventArgs e)
        {
            if (ExceptionOccurred != null)
            {
                ExceptionOccurred(this, e);
            }
        }

        #endregion

        #region 客户端代码

        /// <summary>
        /// 建立与远程主机的连接。
        /// </summary>
        /// <param name="address">远程主机的 IP 地址。</param>
        /// <param name="port">远程主机的端口号。</param>
        public void Connect(IPAddress address, int port)
        {
            mre.Reset();
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.BeginConnect(address, port, new AsyncCallback(SocketConnectCallBack), socket);
            mre.WaitOne();
        }

        /// <summary>
        /// 异步完成与服务器的连接。
        /// </summary>
        /// <param name="iar">异步操作状态。</param>
        private void SocketConnectCallBack(IAsyncResult iar)
        {
            socket = (Socket)iar.AsyncState;
            try
            {
                socket.EndConnect(iar);
                OnConnected(new TcpEventArgs(socket));
                socket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(SocketReceiveCallBack), socket);
            }
            catch (SocketException se)
            {
                ShowError(se);
            }
            finally
            {
                mre.Set();
            }
        }

        #endregion

        #region 服务端代码

        /// <summary>
        /// 将套接字置于侦听状态。
        /// </summary>
        /// <param name="backlog">挂起连接队列的最大长度。</param>
        public void Listen(int backlog)
        {
            try
            {
                client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                client.Bind(new IPEndPoint(this.address, this.port));
                client.Listen(backlog);
                client.BeginAccept(new AsyncCallback(SocketAccpetCallBack), client);
                OnListening();

            }
            catch (SocketException se)
            {
                ShowError(se);
            }
        }

        /// <summary>
        /// 异步连接客户端，并开始收数据。
        /// </summary>
        /// <param name="iar">异步信号。</param>
        private void SocketAccpetCallBack(IAsyncResult iar)
        {
            try
            {
                Socket socketListener = (Socket)iar.AsyncState;
                socket = socketListener.EndAccept(iar);
                client.Close();
                client = null;
                OnAccepted(new TcpEventArgs(socket));
                socket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(SocketReceiveCallBack), socket);
            }
            catch (SocketException se)
            {
                ShowError(se);
            }
        }

        /// <summary>
        /// 异步递归接受消息。
        /// </summary>
        /// <param name="iar">异步信号。</param>
        private void SocketReceiveCallBack(IAsyncResult iar)
        {
            Socket socket = (Socket)iar.AsyncState;
            try
            {
                int count = socket.EndReceive(iar);
                data = new byte[count];
                Buffer.BlockCopy(buffer, 0, data, 0, count);
                bufferQueue.Enqueue(data);
                if (count > 0)
                {
                    OnDataArrived(new TcpTransmissionEventArgs(socket, GetBytes()));
                    if (socket.Connected)
                    {
                        socket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(SocketReceiveCallBack), socket);
                    }
                }
                else
                {
                    //远端计算机发出disconnect指令
                    if (localDisconnectSignal == false)
                    {
                        Disconnect();
                        localDisconnectSignal = false;
                    }
                    //本地计算机发出disconnect指令，继而收到对方的disconnect指令。
                    else
                    {
                        localDisconnectSignal = false;
                    }
                }
            }
            catch (SocketException se)
            {
                ShowError(se);
            }
        }

        #endregion

        #region 公用函数

        /// <summary>
        /// 发送文件。
        /// </summary>
        /// <param name="fileName">文件名。</param>
        public void SendFile(string fileName)
        {
            socket.SendFile(fileName);
        }

        /// <summary>
        /// 调用显示错误事件。
        /// </summary>
        /// <param name="error">错误。</param>
        private void ShowError(SocketException error)
        {
            OnExceptionOccured(new TcpExceptionEventArgs(socket, error));
        }

        /// <summary>
        /// 关闭套接字连接。
        /// </summary>
        public void Disconnect()
        {
            mre.Reset();
            if (socket != null)
            {
                localDisconnectSignal = true;
                socket.Shutdown(SocketShutdown.Both);
                socket.BeginDisconnect(true, new AsyncCallback(SocketDisconnectCallBack), socket);
                disconnectDone.WaitOne();
                socket.Close();
                socket = null;
            }
            if (autoListen == true)
            {
                Listen(0);
            }
            mre.WaitOne();
        }

        private void SocketDisconnectCallBack(IAsyncResult iar)
        {
            Socket socket = (Socket)iar.AsyncState;
            try
            {
                string remoteEndPoint = ((IPEndPoint)socket.RemoteEndPoint).ToString();
                socket.EndDisconnect(iar);
                OnDisconnected(new TcpEventArgs(socket));
                disconnectDone.Set();
            }
            catch (SocketException se)
            {
                ShowError(se);
            }
            finally
            {
                mre.Set();
            }
        }

        /// <summary>
        /// 获取对应套接字缓冲区中的数据。
        /// </summary>
        /// <returns>缓冲区中的数据。</returns>
        private byte[] GetBytes()
        {
            List<byte> list = new List<byte>();
            while (bufferQueue.Count > 0)
            {
                list.AddRange(bufferQueue.Dequeue());
            }
            return list.ToArray();
        }

        /// <summary>
        /// 发送字节数组。
        /// </summary>
        /// <param name="buffer">字节数组。</param>
        public void Send(byte[] buffer)
        {
            try
            {
                mre.Reset();
                socket.BeginSend(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(SocketSendCallBack), socket);
            }
            catch (SocketException se)
            {
                ShowError(se);
            }
            //finally
            //{
            //    mre.WaitOne();
            //}
        }

        private void SocketSendCallBack(IAsyncResult iar)
        {
            Socket socket = (Socket)iar.AsyncState;
            try
            {
                socket.EndSend(iar);
            }
            catch (SocketException se)
            {
                ShowError(se);
            }
            finally
            {
                mre.Set();
            }
        }

        /// <summary>
        /// 套接字属性。
        /// </summary>
        public Socket Socket
        {
            get { return socket; }
        }

        #endregion

        #region 属性

        /// <summary>
        /// 当前端口。
        /// </summary>
        public int Port
        {
            get { return port; }
        }

        /// <summary>
        /// 当前IP。
        /// </summary>
        public IPAddress Ip
        {
            get { return address; }
        }

        /// <summary>
        /// 设置作为服务器端，是否需要在断开连接后自动打开侦听。
        /// </summary>
        public bool AutoListen
        {
            set { autoListen = value; }
        }

        /// <summary>
        /// 获取远程终结点。
        /// </summary>
        public IPEndPoint RemoteEndPoint
        {
            get
            {
                if ((socket != null) && (socket.Connected == true))
                {
                    return (IPEndPoint)socket.RemoteEndPoint;
                }
                else
                {
                    return null;
                }
            }
        }
        #endregion

        public static bool isIPAddressStringValid(string ipaddress)
        {
            string[] parts = ipaddress.Split('.');
            if (parts.Length != 4)
            {
                return false;
            }
            byte[] baddr = new byte[4];
            for (int i = 0; i < parts.Length; i++)
            {
                UInt16 val = Convert.ToUInt16(parts[i]);
                if ((val >= 0) && (val <= 255))
                {
                    baddr[i] = (byte)val;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        public static byte[] getAddressBytes(string ipaddress)
        {
            string[] parts = ipaddress.Split('.');
            byte[] baddr = new byte[4];
            for (int i = 0; i < parts.Length; i++)
            {
                UInt16 val = Convert.ToUInt16(parts[i]);
                baddr[i] = (byte)val;
            }
            return baddr;
        }
    }
}
