using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MissionPlanner.Joystick
{
    public class CameraControlMessage
    {
        public byte Pitch { get; set; }
        public byte Roll { get; set; }
        public byte Yaw { get; set; }
        public byte Focus { get; set; }
        public byte Zoom { get; set; }
        public byte Switch { get; set; }
        public byte Record { get; set; }
        public byte QuickCommand { get; set; }

        public enum QuickCmdEnum : byte
        {
            None = 0,
            ReturnHead = 1,
            LookDown = 2,
            CenterYaw = 3,
            MotorOn = 4,
            MotorOff = 5,
            FollowYawDisable = 6,
            FollowYawEnable = 7,
        }

        public enum SwitchOpEnum : byte
        {
            None = 0x00,
            PhotoMode = 0x11,
            VideoMode = 0x44,
        }

        public enum RecordOpEnum : byte
        {
            None = 0x00,
            TakePhoto = 0x33,
            StartRecord = 0x55,
            StopRecord = 0xff,
        }

        public CameraControlMessage()
        {
            this.Pitch = 0x7F;
            this.Roll = 0x7F;
            this.Yaw = 0x7F;
            this.Focus = 0x7F;
            this.Zoom = 0x7F;
            this.Switch = (byte)SwitchOpEnum.None;
            this.Record = (byte)RecordOpEnum.None;
            this.QuickCommand = (byte)QuickCmdEnum.None;
        }

        public CameraControlMessage(short p, short r, short y)
        {

        }

        public CameraControlMessage(QuickCmdEnum quick)
        {
            this.Pitch = 0x7F;
            this.Roll = 0x7F;
            this.Yaw = 0x7F;
            this.Focus = 0x7F;
            this.Zoom = 0x7F;
            this.Switch = (byte)SwitchOpEnum.None;
            this.Record = (byte)RecordOpEnum.None;
            this.QuickCommand = (byte)quick;
        }

        public byte[] getBytes()
        {
            byte[] content = new byte[11];

            content[0] = 0xEB;
            content[1] = 0x90;
            content[2] = this.Pitch;
            content[3] = this.Roll;
            content[4] = this.Yaw;
            content[5] = this.Focus;
            content[6] = this.Zoom;
            content[7] = this.Switch;
            content[8] = this.Record;
            content[9] = this.QuickCommand;
            content[10] = getCRC();

            return content;
        }

        private byte getCRC()
        {
            byte crc = (byte)(Pitch + Roll + Yaw + Focus + Zoom + Switch + Record + QuickCommand);
            return crc;
        }

    }
}