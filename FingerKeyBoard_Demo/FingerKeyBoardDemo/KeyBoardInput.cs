using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Threading;


namespace FingerKeyBoardDemo
{
    class KeyBoardInput
    {
        [DllImport("user32.dll")]
        public static extern void keybd_event(byte vk, byte scan, int flags, uint extinfo);

        // flag for keyboard condition

        const int KEYDOWN = 0x00;
        const int KEYUP = 0x02;

        public static void KeyDown(int keycode, int shiftcode)
        {
            if (shiftcode == 0)
            {
                keybd_event((byte)keycode, 0, KEYDOWN, 0);

            }
            else
            {
                keybd_event((byte)0x10, 0, KEYDOWN, 0);
                keybd_event((byte)keycode, 0, KEYDOWN, 0);
            }
        }

        public static void KeyUp(int keycode, int shiftcode)
        {
            if (shiftcode == 0)
            {
                keybd_event((byte)keycode, 0, KEYUP, 0);

            }
            else
            {
                keybd_event((byte)keycode, 0, KEYUP, 0);
                keybd_event((byte)0x10, 0, KEYUP, 0);
            }
        }

        public static void KeyClick(int keycode, int shiftcode)
        {
            KeyDown(keycode,shiftcode);
            Thread.Sleep(10);
            KeyUp(keycode,shiftcode);
        }
    }
}