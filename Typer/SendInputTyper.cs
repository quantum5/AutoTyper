using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AutoTyper {
    class SendInputTyper : Typer {
        List<WinInput.INPUT> inputs = new List<WinInput.INPUT>();
        //public Set<Keys> pressed = new Set<Keys>();
        public Dictionary<Keys, object> pressed = new Dictionary<Keys, object>();

        private void add(Keys key, short scan, WinInput.KEYEVENTF flag) {
            inputs.Add(new WinInput.INPUT() {
                type = WinInput.InputType.Keyboard,
                U = new WinInput.InputUnion() {
                    ki = new WinInput.KEYBDINPUT() {
                        wScan = scan,
                        wVk = (short)key,
                        dwFlags = flag,
                        dwExtraInfo = UIntPtr.Zero,
                        time = 0,
                    }
                },
            });
        }

        public override void down(Keys key) {
            add(key, 0, 0);
            pressed[key] = null;
            //presses.Add(key);
        }

        public override void up(Keys key) {
            add(key, 0, WinInput.KEYEVENTF.KEYUP);
            pressed.Remove(key);
        }

        public override void releaseall() {
            foreach (Keys key in pressed.Keys) {
                up(key);
            }
            flush();
        }

        public override void text(string text) {
            foreach (char c in text) {
                switch (c) {
                    case '\n':
                        press(Keys.Enter);
                        break;
                    case '\t':
                        press(Keys.Tab);
                        break;
                    default:
                        add(0, (short)c, WinInput.KEYEVENTF.UNICODE);
                        add(0, (short)c, WinInput.KEYEVENTF.UNICODE | WinInput.KEYEVENTF.KEYUP);
                        break;
                }
            }
            flush();
        }

        public override void flush() {
            if (inputs.Count > 0) {
                WinInput.SendInput((uint)inputs.Count, inputs.ToArray(), WinInput.INPUT.Size);
                inputs.Clear();
            }
        }
    }
}
