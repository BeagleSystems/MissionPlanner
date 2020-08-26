using Renci.SshNet;
using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using SharpDX.XInput;
using System.Net.Sockets;
using System.Net;
using System.Runtime.Remoting.Channels;
using Microsoft.Win32;

namespace RemoteCommandForm
{
    public partial class RemoteCmdForm : Form
    {
        private SshClient client;

        //JoyStick2TcpClient JoyClient;

        Controller joystick;

        State last_state;

        IPAddress tcp_ip;
        int tcp_port;
        // TcpEx tcp;

        int sendCount = 0;
        int ackCount = 0;

        private bool isTcpConnected = false;

        private static System.Timers.Timer sendTcpTimer;

        public RemoteCmdForm()
        {
            InitializeComponent();

            last_state = new State();

            tcp_port = 5000;

            sendTcpTimer = new System.Timers.Timer();
            sendTcpTimer.Interval = 500;
            sendTcpTimer.AutoReset = true;
            sendTcpTimer.Elapsed += new System.Timers.ElapsedEventHandler(SendTcpRegular);

        }

        private void SendTcpRegular(object sender, EventArgs e)
        {
            try
            {
                var control_msg = translate2control(ref last_state);

                byte[] msg = control_msg.getBytes();

                var tcp = TcpConnect();
                SendContent(tcp, msg);
                updateLabel(ref control_msg);

                tcp.Disconnect();
            }
            catch
            {

            }
        }

        delegate void setLabel(Label label, string content);

        private void SetLabelText(Label label, string content)
        {
            if(label.InvokeRequired)
            {
                setLabel setThis = new setLabel(SetLabelText);
                label.Invoke(setThis, label, content);
            }
            else
            {
                label.Text = content;
            }
        }

        delegate void setRichTextBox(RichTextBox box, string content);

        private void SetRichTextBox(RichTextBox box, string content)
        {
            if(box.InvokeRequired)
            {
                setRichTextBox setThis = new setRichTextBox(SetRichTextBox);
                box.Invoke(setThis, box, content);
            }
            else
            {
                box.AppendText(content + Environment.NewLine);
                box.ScrollToCaret();
            }
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            string dest = addressTextBox.Text;
            string user = usernameTextBox.Text;
            string pw = passwordTextBox.Text;

            if(pw == string.Empty)
            {
                richTextBox1.AppendText("Please provide a password!\n");
                return;
            }

            client = new SshClient(dest, user, pw);
            
            try
            {
                client.Connect();
                //change enable states
                connectButton.Text = "Connected";
                addressTextBox.Enabled = false;
                usernameTextBox.Enabled = false;
                passwordTextBox.Enabled = false;
                connectButton.Enabled = false;
                disconnectButton.Enabled = true;

                //enable grp controls
                videoControlGrp.Enabled = true;
                communicationControlGrp.Enabled = true;
                mavControlGrp.Enabled = true;
                tcpGrpBox.Enabled = true;
            }
            catch (Exception ex)
            {
                richTextBox1.AppendText("SSH connect failed: " + ex.ToString() + Environment.NewLine);
                return;
            }

            pw = pw.Trim();
            var line = client.CreateCommand("sshpass -p \"" + pw + "\" sudo systemctl status gstnvarguscamera.service");
            try
            {
                line.Execute();
                if (line.ExitStatus == 0)
                {
                    //richTextBox1.AppendText(line.Result.ToString() + Environment.NewLine);
                    if(line.Result.ToString().Contains("start"))
                    {
                        videoControlGrp.BackColor = Color.LightGreen;
                    }
                    richTextBox1.AppendText("[gstnvarguscamera.service] status success" + Environment.NewLine);
                }
                else
                {
                    richTextBox1.AppendText(line.Error.ToString() + Environment.NewLine);
                    videoControlGrp.BackColor = Color.LightYellow;
                    richTextBox1.AppendText("[gstnvarguscamera.service] status failed" + Environment.NewLine);
                }
            }
            catch (Exception ex)
            {
                richTextBox1.AppendText("[gstnvarguscamera.service] status timeout: " + ex.ToString() + Environment.NewLine);
            }

            pw = pw.Trim();
            line = client.CreateCommand("sshpass -p \"" + pw + "\" sudo systemctl status mavproxy.service");
            try
            {
                line.Execute();
                if (line.ExitStatus == 0)
                {
                    //richTextBox1.AppendText(line.Result.ToString() + Environment.NewLine);
                    if (line.Result.ToString().Contains("running"))
                    {
                        mavControlGrp.BackColor = Color.LightGreen;
                    }
                    richTextBox1.AppendText("[mavproxy.service] status success" + Environment.NewLine);
                }
                else
                {
                    richTextBox1.AppendText(line.Error.ToString() + Environment.NewLine);
                    mavControlGrp.BackColor = Color.Red;
                    richTextBox1.AppendText("[mavproxy.service] status failed" + Environment.NewLine);
                }
            }
            catch (Exception ex)
            {
                richTextBox1.AppendText("[mavproxy.service] status timeout: " + ex.ToString() + Environment.NewLine);
            }

            pw = pw.Trim();
            line = client.CreateCommand("sshpass -p \"" + pw + "\" sudo systemctl status openvpn@client.service");
            try
            {
                line.Execute();
                if (line.ExitStatus == 0)
                {
                    //richTextBox1.AppendText(line.Result.ToString() + Environment.NewLine);
                    if (line.Result.ToString().Contains("running"))
                    {
                        communicationControlGrp.BackColor = Color.LightGreen;
                    }
                    richTextBox1.AppendText("[vpn.service] status success" + Environment.NewLine);
                }
                else
                {
                    richTextBox1.AppendText(line.Error.ToString() + Environment.NewLine);
                    communicationControlGrp.BackColor = Color.Red;
                    richTextBox1.AppendText("[vpn.service] status failed" + Environment.NewLine);
                }
            }
            catch (Exception ex)
            {
                richTextBox1.AppendText("[vpn.service] status timeout: " + ex.ToString() + Environment.NewLine);
            }

            pw = pw.Trim();
            line = client.CreateCommand("sshpass -p \"" + pw + "\" sudo systemctl status tcp2serial.service");
            try
            {
                line.Execute();
                if (line.ExitStatus == 0)
                {
                    //richTextBox1.AppendText(line.Result.ToString() + Environment.NewLine);
                    if (line.Result.ToString().Contains("running"))
                    {
                        tcpGrpBox.BackColor = Color.LightGreen;
                    }
                    richTextBox1.AppendText("[tcp2serial.service] status success" + Environment.NewLine);
                }
                else
                {
                    richTextBox1.AppendText(line.Error.ToString() + Environment.NewLine);
                    tcpGrpBox.BackColor = Color.Red;
                    richTextBox1.AppendText("[tcp2serial.service] status failed" + Environment.NewLine);
                }
            }
            catch (Exception ex)
            {
                richTextBox1.AppendText("[tcp2serial.service] status timeout: " + ex.ToString() + Environment.NewLine);
            }
        }

        private void disconnectButton_Click(object sender, EventArgs e)
        {
            client.Disconnect();
            connectButton.Text = "Connect";
            addressTextBox.Enabled = true;
            usernameTextBox.Enabled = true;
            passwordTextBox.Enabled = true;
            connectButton.Enabled = true;
            disconnectButton.Enabled = false;

            //enable grp controls
            videoControlGrp.Enabled = false;
            communicationControlGrp.Enabled = false;
            mavControlGrp.Enabled = false;
            tcpGrpBox.Enabled = false;
        }

        private void enableVideoButton_Click(object sender, EventArgs e)
        {
            string pw = passwordTextBox.Text.Trim();
            var line = client.CreateCommand("sshpass -p \"" + pw + "\" sudo systemctl enable gstnvarguscamera.service");
            try
            {
                line.Execute();
                if (line.ExitStatus == 0)
                {
                    richTextBox1.AppendText(line.Result.ToString() + Environment.NewLine);
                    richTextBox1.AppendText("[gstnvarguscamera.service] Enable success" + Environment.NewLine);
                }
                else
                {
                    richTextBox1.AppendText(line.Error.ToString() + Environment.NewLine);
                    richTextBox1.AppendText("[gstnvarguscamera.service] Enable failed" + Environment.NewLine);
                }
            }
            catch (Exception ex)
            {
                richTextBox1.AppendText("[gstnvarguscamera.service] Enable timeout: " + ex.ToString() + Environment.NewLine);
            }
        }

        private void restartTcpButton_Click(object sender, EventArgs e)
        {
            string pw = passwordTextBox.Text.Trim();
            var line = client.CreateCommand("sshpass -p \"" + pw + "\" sudo systemctl restart tcp2serial.service");
            try
            {
                line.Execute();
                if (line.ExitStatus == 0)
                {
                    richTextBox1.AppendText(line.Result.ToString() + Environment.NewLine);
                    richTextBox1.AppendText("[tcp2serial.service] restart success" + Environment.NewLine);
                }
                else
                {
                    richTextBox1.AppendText(line.Error.ToString() + Environment.NewLine);
                    richTextBox1.AppendText("[tcp2serial.service] restart failed" + Environment.NewLine);
                }
            }
            catch (Exception ex)
            {
                richTextBox1.AppendText("[tcp2serial.service] restart timeout: " + ex.ToString() + Environment.NewLine);
            }
        }

        private void diableVideoButton_Click(object sender, EventArgs e)
        {
            string pw = passwordTextBox.Text.Trim();
            var line = client.CreateCommand("sshpass -p \"" + pw + "\" sudo systemctl disable gstnvarguscamera.service");
            try
            {
                line.Execute();
                if (line.ExitStatus == 0)
                {
                    richTextBox1.AppendText(line.Result.ToString() + Environment.NewLine);
                    richTextBox1.AppendText("[gstnvarguscamera.service] Disable success" + Environment.NewLine);
                }
                else
                {
                    richTextBox1.AppendText(line.Error.ToString() + Environment.NewLine);
                    richTextBox1.AppendText("[gstnvarguscamera.service] Disable failed" + Environment.NewLine);
                }
            }
            catch (Exception ex)
            {
                richTextBox1.AppendText("[gstnvarguscamera.service] Disable timeout: " + ex.ToString() + Environment.NewLine);
            }
}

        private void startVideoButton_Click(object sender, EventArgs e)
        {
            string pw = passwordTextBox.Text.Trim();
            var line = client.CreateCommand("sshpass -p \"" + pw + "\" sudo systemctl restart gstnvarguscamera.service &");
            line.CommandTimeout = new TimeSpan(0,0,10);
            try
            {
                line.Execute();
                if (line.ExitStatus == 0)
                {
                    richTextBox1.AppendText(line.Result.ToString() + Environment.NewLine);
                    richTextBox1.AppendText("[gstnvarguscamera.service] Start success" + Environment.NewLine);
                }
                else
                {
                    richTextBox1.AppendText(line.Error.ToString() + Environment.NewLine);
                    richTextBox1.AppendText("[gstnvarguscamera.service] Start failed" + Environment.NewLine);
                }
            }
            catch(Exception ex)
            {
                richTextBox1.AppendText("[gstnvarguscamera.service] Start timeout: " + ex.ToString() + Environment.NewLine);
            }
        }

        private void stopVideoButton_Click(object sender, EventArgs e)
        {
            string pw = passwordTextBox.Text.Trim();
            var line = client.CreateCommand("sshpass -p \"" + pw + "\" sudo systemctl stop gstnvarguscamera.service");
            try
            {
                line.Execute();
                if (line.ExitStatus == 0)
                {
                    richTextBox1.AppendText(line.Result.ToString() + Environment.NewLine);
                    richTextBox1.AppendText("[gstnvarguscamera.service] Stop success" + Environment.NewLine);
                }
                else
                {
                    richTextBox1.AppendText(line.Error.ToString() + Environment.NewLine);
                    richTextBox1.AppendText("[gstnvarguscamera.service] Stop failed" + Environment.NewLine);
                }
            }
            catch (Exception ex)
            {
                richTextBox1.AppendText("[gstnvarguscamera.service] Stop timeout: " + ex.ToString() + Environment.NewLine);
            }
        }

        private void checkVPNButton_Click(object sender, EventArgs e)
        {
            string pw = passwordTextBox.Text.Trim();
            var line = client.CreateCommand("sshpass -p \"" + pw + "\" sudo systemctl status openvpn@client.service");
            try
            {
                line.Execute();
                if (line.ExitStatus == 0)
                {
                    richTextBox1.AppendText(line.Result.ToString() + Environment.NewLine);
                    richTextBox1.AppendText("[vpn.service] statue success" + Environment.NewLine);
                }
                else
                {
                    richTextBox1.AppendText(line.Error.ToString() + Environment.NewLine);
                    richTextBox1.AppendText("[vpn.service] status failed" + Environment.NewLine);
                }
            }
            catch (Exception ex)
            {
                richTextBox1.AppendText("[vpn.service] status timeout: " + ex.ToString() + Environment.NewLine);
            }
        }

        private void checkMavButton_Click(object sender, EventArgs e)
        {
            string pw = passwordTextBox.Text.Trim();
            var line = client.CreateCommand("sshpass -p \"" + pw + "\" sudo systemctl status mavproxy.service");
            try
            {
                line.Execute();
                if (line.ExitStatus == 0)
                {
                    richTextBox1.AppendText(line.Result.ToString() + Environment.NewLine);
                    richTextBox1.AppendText("[mavproxy.service] statue success" + Environment.NewLine);
                }
                else
                {
                    richTextBox1.AppendText(line.Error.ToString() + Environment.NewLine);
                    richTextBox1.AppendText("[mavproxy.service] status failed" + Environment.NewLine);
                }
            }
            catch (Exception ex)
            {
                richTextBox1.AppendText("[mavproxy.service] status timeout: " + ex.ToString() + Environment.NewLine);
            }
        }

        private void restartMavButton_Click(object sender, EventArgs e)
        {
            string pw = passwordTextBox.Text.Trim();
            var line = client.CreateCommand("sshpass -p \"" + pw + "\" sudo systemctl restart mavproxy.service");
            try
            {
                line.Execute();
                if (line.ExitStatus == 0)
                {
                    richTextBox1.AppendText(line.Result.ToString() + Environment.NewLine);
                    richTextBox1.AppendText("[mavproxy.service] restart success" + Environment.NewLine);
                }
                else
                {
                    richTextBox1.AppendText(line.Error.ToString() + Environment.NewLine);
                    richTextBox1.AppendText("[mavproxy.service] restart failed" + Environment.NewLine);
                }
            }
            catch (Exception ex)
            {
                richTextBox1.AppendText("[mavproxy.service] restart timeout: " + ex.ToString() + Environment.NewLine);
            }
        }

        private void reconnectJoystickButton_Click(object sender, EventArgs e)
        {
            try
            {
                joystick = new Controller(UserIndex.One);

                last_state = joystick.GetState();

                this.getJoyStateTimer.Enabled = true;
            }
            catch(Exception ex)
            {
                SetRichTextBox(richTextBox1, ex.ToString());
                this.getJoyStateTimer.Enabled = false;
            }

            
        }

        private void RemoteCmdForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (client == null)
                return;

            if(client.IsConnected)
            {
                client.Disconnect();
            }

            getJoyStateTimer.Enabled = false;
            Thread.Sleep(110);  //wait the timer to stop
        }

        //private void SendTcpMsg(object sender, EventArgs e)
        //{
        //    var control_msg = translate2control(ref last_state);

        //    byte[] msg = control_msg.getBytes();

        //    SendContent(msg);
        //    updateLabel(ref control_msg);
        //}

        private void updateLabel(ref CameraControlMessage msg)
        {
            if(msg.Switch == (byte)CameraControlMessage.SwitchOpEnum.PhotoMode)
            {
                SetLabelText(switchLabel, "Photo");
            }
            else if(msg.Switch == (byte)CameraControlMessage.SwitchOpEnum.VideoMode)
            {
                SetLabelText(switchLabel, "Video");
            }

            if(msg.Record == (byte)CameraControlMessage.RecordOpEnum.StartRecord)
            {
                SetLabelText(recordStateLabel, "Recording");
            }
            else if (msg.Record == (byte)CameraControlMessage.RecordOpEnum.StopRecord)
            {
                SetLabelText(recordStateLabel, "Stopped");
            }
        }

        private CameraControlMessage translate2control(ref State state)
        {
            CameraControlMessage msg = new CameraControlMessage();

            try
            {
                msg.Pitch = Convert.ToByte(pitchBox.Text);
                msg.Yaw = Convert.ToByte(yawBox.Text);
                msg.Zoom = Convert.ToByte(zoomBox.Text);
                msg.Focus = Convert.ToByte(focusBox.Text);
                msg.Switch = (byte)getSwitchOp(ref state);
                msg.Record = (byte)getRecordOp(ref state);
                msg.QuickCommand = (byte)button2Cmd(JoyStickDataProcess.sortButtons(state));
            }
            catch
            {

            }

            return msg;
        }

        private CameraControlMessage.SwitchOpEnum getSwitchOp(ref State state)
        {
            CameraControlMessage.SwitchOpEnum s = CameraControlMessage.SwitchOpEnum.None;
            if(JoyStickDataProcess.isPressed(ref state, GamepadButtonFlags.RightShoulder))
            {
                s = CameraControlMessage.SwitchOpEnum.VideoMode;
                return s;
            }
            else if(JoyStickDataProcess.isPressed(ref state,GamepadButtonFlags.LeftShoulder))
            {
                s = CameraControlMessage.SwitchOpEnum.PhotoMode;
                return s;
            }
            return s;
        }

        private CameraControlMessage.RecordOpEnum getRecordOp(ref State state)
        {
            CameraControlMessage.RecordOpEnum s = CameraControlMessage.RecordOpEnum.None;
            if (JoyStickDataProcess.isLeftTriggered(ref state))
            {
                if (this.switchLabel.Text.Contains("Photo"))
                {
                    s = CameraControlMessage.RecordOpEnum.TakePhoto;
                    return s;
                }
                else if(this.switchLabel.Text.Contains("Video"))
                {
                    s = CameraControlMessage.RecordOpEnum.StartRecord;
                    return s;
                }
            }
            else if (JoyStickDataProcess.isRightTriggered(ref state))
            {
                s = CameraControlMessage.RecordOpEnum.StopRecord;
                return s;
            }
            return s;
        }

        private CameraControlMessage.QuickCmdEnum button2Cmd(GamepadButtonFlags button)
        {
            CameraControlMessage.QuickCmdEnum cmd = CameraControlMessage.QuickCmdEnum.None;
            switch(button)
            {
                case GamepadButtonFlags.A:
                    cmd = CameraControlMessage.QuickCmdEnum.LookDown;
                    break;
                case GamepadButtonFlags.Y:
                    cmd = CameraControlMessage.QuickCmdEnum.CenterYaw;
                    break;
                case GamepadButtonFlags.RightThumb:
                    cmd = CameraControlMessage.QuickCmdEnum.ReturnHead;
                    break;

                case GamepadButtonFlags.DPadLeft:
                    cmd = CameraControlMessage.QuickCmdEnum.MotorOn;
                    break;
                case GamepadButtonFlags.DPadRight:
                    cmd = CameraControlMessage.QuickCmdEnum.MotorOff;
                    break;
                case GamepadButtonFlags.X:
                    cmd = CameraControlMessage.QuickCmdEnum.FollowYawDisable;
                    break;
                case GamepadButtonFlags.B:
                    cmd = CameraControlMessage.QuickCmdEnum.FollowYawEnable;
                    break;
                default:
                    break;
            }
            return cmd;
        }

        private void getJoyStateTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                if (joystick != null)
                {
                    last_state = joystick.GetState();
                }
            }
            catch
            {
                return;
            }

            //update UI
            // save scale value to text boxes
            this.pitchBar.Value = JoyStickDataProcess.ScaleValue(last_state.Gamepad.RightThumbY);

            this.yawBar.Value = JoyStickDataProcess.ScaleValue(last_state.Gamepad.RightThumbX);

            this.pitchBox.Text = this.pitchBar.Value.ToString();

            this.yawBox.Text = this.yawBar.Value.ToString();

            this.zoomBox.Text = JoyStickDataProcess.ScaleValue(last_state.Gamepad.LeftThumbY).ToString();

            this.focusBox.Text = JoyStickDataProcess.ScaleValue(last_state.Gamepad.LeftThumbX).ToString();

            // only UI
            this.motorOnButton.BackColor = JoyStickDataProcess.isPressed(ref last_state, GamepadButtonFlags.DPadLeft) ? Color.Green : Color.Yellow;

            this.motorOffButton.BackColor = JoyStickDataProcess.isPressed(ref last_state, GamepadButtonFlags.DPadRight) ? Color.Green : Color.Yellow;

            this.recenterButton.BackColor = JoyStickDataProcess.isPressed(ref last_state, GamepadButtonFlags.Y) ? Color.Green : Color.Yellow;

            this.lookdownButton.BackColor = JoyStickDataProcess.isPressed(ref last_state, GamepadButtonFlags.A) ? Color.Green : Color.Yellow;

            this.followYawOffButton.BackColor = JoyStickDataProcess.isPressed(ref last_state, GamepadButtonFlags.X) ? Color.Green : Color.Yellow;

            this.followYawOnButton.BackColor = JoyStickDataProcess.isPressed(ref last_state, GamepadButtonFlags.B) ? Color.Green : Color.Yellow;
        }


        public TcpEx TcpConnect()
        {            
            TcpEx tcp = new TcpEx(tcp_ip, tcp_port);
            tcp.Connected += new TcpEx.TcpEventHandler(TCP_connected);
            tcp.Disconnected += new TcpEx.TcpEventHandler(TCP_disconnected);
            tcp.DataArrived += new TcpEx.TcpTransmissionEventHandler(TcpDataProcess);
            tcp.ExceptionOccurred += new TcpEx.TcpExceptionEventHandler(TcpExceptionProcess);
            tcp.Connect(tcp_ip, tcp_port);
            return tcp;
        }

        private void TCP_connected(object sender, TcpEventArgs e)
        {
            isTcpConnected = true;
        }

        private void TCP_disconnected(object sender, TcpEventArgs e)
        {
            isTcpConnected = false;
        }

        private void TcpExceptionProcess(object sender, TcpExceptionEventArgs e)
        {
            isTcpConnected = false;
            SetRichTextBox(richTextBox1, "TCP connection lost!");
            SetRichTextBox(richTextBox1, e.ToString());
        }

        private void TcpDataProcess(Object sender, TcpTransmissionEventArgs e)
        {
            byte[] data = e.Data;
            string resp = Encoding.Default.GetString(data);
            if (resp.Contains("ACK"))
            {
                ackCount++;
                SetLabelText(ackCountLabel, ackCount.ToString());
            }
        }

        public void SendContent(TcpEx tcp, byte[] content)
        {
            tcp.Send(content);
            sendCount++;
            SetLabelText(sentCountLabel, sendCount.ToString());
        }

        private void tcpSendButton_Click(object sender, EventArgs e)
        {
            if(tcpSendButton.Text.Contains("Connect"))
            {
                sendTcpTimer.Start();
                tcpSendButton.Text = "Disconnect";
            }
            else
            {
                sendTcpTimer.Stop();
                if (TcpEx.isIPAddressStringValid(addressTextBox.Text) == false)
                {
                    return;
                }

                byte[] baddr = TcpEx.getAddressBytes(addressTextBox.Text);
                this.tcp_ip = new IPAddress(baddr);
                this.tcp_port = 5000;
                tcpSendButton.Text = "Connect";
            }            
        }        
    }
}
