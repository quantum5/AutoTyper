using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AutoTyper
{
    /// <summary>
    /// Description of KeyBDEventTyper.
    /// </summary>
    public class KeyBDEventTyper : Typer {
        [DllImport("user32.dll")]
        static extern void keybd_event(Keys key, byte scan, uint flags, UIntPtr extra);

        //public Set<Keys> pressed = new Set<Keys>();
        public Dictionary<Keys, object> pressed = new Dictionary<Keys, object>();

        public override void down(Keys key) {
            keybd_event(key, 0, 0, UIntPtr.Zero);
            pressed[key] = null;
            //presses.Add(key);
        }

        public override void up(Keys key) {
            keybd_event(key, 0, 2, UIntPtr.Zero);
            pressed.Remove(key);
        }

        public override void releaseall() {
            foreach (Keys key in pressed.Keys) {
                up(key);
            }
        }

        public override void text(string text) {
            foreach (char c in text) {
                List<Keys> keys = new List<Keys>(ASCIItoKey.get(c));
                foreach (Keys k in keys) {
                    down(k);
                }
                keys.Reverse();

                foreach (Keys k in keys) {
                    up(k);
                }
            }
        }
    }
}
