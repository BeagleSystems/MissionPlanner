using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using SharpDX.XInput;
using System.Runtime.CompilerServices;
using SharpDX.DirectInput;

public class JoyStickDataProcess
{
    // min max input axis values
    private static int minInput = -32768;
    private static int maxInput = 32767;

    private static int minOutput = 0;
    private static int maxOutput = 255;

    // deadzone of joystick axis in the middle
    private static float DeadZone = 0.1f; //percentage
    private static float Center = 0.5f;

    private static byte TriggerThreshold = 128;

    private static GamepadButtonFlags[] priority =
    {
        GamepadButtonFlags.RightThumb,
        GamepadButtonFlags.Y,
        GamepadButtonFlags.LeftThumb,
        GamepadButtonFlags.A,
        GamepadButtonFlags.X,
        GamepadButtonFlags.B,
        GamepadButtonFlags.DPadLeft,
        GamepadButtonFlags.DPadRight,
    };

    public static int ScaleValue(short val)
    {
        // calc percentage
        float f = (((float)val - minInput) / (maxInput - minInput));

        // remove deadzone
        if(((Center - DeadZone)< f) && (f<(Center + DeadZone)))
        {
            f = Center;
        }

        // clac ouput
        int o = (int)((maxOutput - minOutput) * f);
        return o;
    }

    public static bool isPressed(ref State state, GamepadButtonFlags buttonFlg)
    {
        return state.Gamepad.Buttons.HasFlag(buttonFlg) ? true : false;
    }

    public static bool isLeftTriggered(ref State state)
    {
        return state.Gamepad.LeftTrigger > TriggerThreshold ? true : false;
    }

    public static bool isRightTriggered(ref State state)
    {
        return state.Gamepad.RightTrigger > TriggerThreshold ? true : false;
    }

    public static GamepadButtonFlags sortButtons(State state)
    {
        for (int i = 0; i < priority.Length; i++)
        {
            GamepadButtonFlags flg = priority[i];
            if(isPressed(ref state, flg))
            {
                return flg;
            }
        }

        return GamepadButtonFlags.Start;//return start button as default not in the list
    }

}
