using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class AngleControlMessage
{
    public short Pitch { get; set; }
    public short Roll { get; set; }
    public short Yaw { get; set; }
    public byte ControlMode { get; set; }
    public byte QuickCommand { get; set; }
    
    public enum QuickCmdEnum: byte
    {
        None        = 0,
        ReturnHead  = 1,
        LookDown    = 2,
        CenterYaw   = 3,
        MotorOn     = 4,
        MotorOff    = 5,
        FollowYawDisable    = 6,
        FollowYawEnable     = 7,

        // adding special byte for angle control
        AngleControl        = 0xff,
    }

    public enum ControlModeEnum : byte
    {
        MODE_NO_CONTROL     = 0,
        MODE_SPEED          = 1,
        MODE_ANGLE          = 2,
        MODE_SPEED_ANGLE    = 3,
        MODE_RC             = 4,
        MODE_RC_HIGH_RES    = 6,
        MODE_ANGLE_REL_FRAME = 5,
    }

    public AngleControlMessage(short p, short r, short y, AngleControlMessage.ControlModeEnum mode)
    {
        this.Roll = r;
        this.Pitch = p;
        this.Yaw = y;
        this.ControlMode = (byte)mode;
        this.QuickCommand = (byte)QuickCmdEnum.AngleControl;
    }

    public byte[] getBytes()
    {
        byte[] content = new byte[11];

        content[0] = 0xEB;
        content[1] = 0x90;
        //content[2] = this.Pitch;
        //content[3] = this.Roll;
        //content[4] = this.Yaw;
        //content[5] = this.Focus;
        //content[6] = this.Zoom;
        //content[7] = this.Switch;
        //content[8] = this.Record;
        byte[] rollBytes = BitConverter.GetBytes(Roll);
        byte[] pitchBytes = BitConverter.GetBytes(Pitch);
        byte[] yawBytes = BitConverter.GetBytes(Yaw);
        content[2] = rollBytes[0];
        content[3] = rollBytes[1];
        content[4] = pitchBytes[0];
        content[5] = pitchBytes[1];
        content[6] = yawBytes[0];
        content[7] = yawBytes[1];
        content[8] = ControlMode;
        content[9] = QuickCommand;

        byte crc = 0;
        for(int i=2;i<10;i++)
        {
            crc += content[i];
        }

        content[10] = crc;

        return content;
    }
}
