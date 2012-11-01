using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AutoTyper {
    class WinInput {
        [Flags]
        public enum MouseEventDataXButtons : uint {
            Nothing = 0x00000000,
            XBUTTON1 = 0x00000001,
            XBUTTON2 = 0x00000002
        }

        [Flags]
        public enum MOUSEEVENTF : uint {
            ABSOLUTE = 0x8000,
            HWHEEL = 0x01000,
            MOVE = 0x0001,
            MOVE_NOCOALESCE = 0x2000,
            LEFTDOWN = 0x0002,
            LEFTUP = 0x0004,
            RIGHTDOWN = 0x0008,
            RIGHTUP = 0x0010,
            MIDDLEDOWN = 0x0020,
            MIDDLEUP = 0x0040,
            VIRTUALDESK = 0x4000,
            WHEEL = 0x0800,
            XDOWN = 0x0080,
            XUP = 0x0100
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct MOUSEINPUT {
            public int dx;
            public int dy;
            public MouseEventDataXButtons mouseData;
            public MOUSEEVENTF dwFlags;
            public uint time;
            public UIntPtr dwExtraInfo;
        }

        [Flags]
        public enum KEYEVENTF : uint {
            EXTENDEDKEY = 0x0001,
            KEYUP = 0x0002,
            SCANCODE = 0x0008,
            UNICODE = 0x0004
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct KEYBDINPUT {
            public short wVk;
            public short wScan;
            public KEYEVENTF dwFlags;
            public int time;
            public UIntPtr dwExtraInfo;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct HARDWAREINPUT {
            public int uMsg;
            public short wParamL;
            public short wParamH;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct INPUT {
            public InputType type;
            public InputUnion U;
            public static int Size {
                get {
                    return Marshal.SizeOf(typeof(INPUT));
                }
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct InputUnion {
            [FieldOffset(0)]
            public MOUSEINPUT mi;
            [FieldOffset(0)]
            public KEYBDINPUT ki;
            [FieldOffset(0)]
            public HARDWAREINPUT hi;
        }

        public enum InputType : uint {
            /// <summary>
            /// Mouse input.
            /// </summary>
            Mouse = 0,
            /// <summary>
            /// Keyboard input.
            /// </summary>
            Keyboard = 1,
            /// <summary>
            /// Another device that is not the keyboard or the mouse.
            /// </summary>
            HID = 2
        }

        [DllImport("user32.dll")]
        public static extern uint SendInput(
            uint nInputs,
            [MarshalAs(UnmanagedType.LPArray), In] INPUT[] pInputs,
            int cbSize
        );
    }
}
