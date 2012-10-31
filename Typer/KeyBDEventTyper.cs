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

        public HashSet<Keys> pressed = new HashSet<Keys>();

		public void down(Keys key) {
        	keybd_event(key, 0, 0, UIntPtr.Zero);
            pressed.Add(key);
		}
        
		public void up(Keys key) {
        	keybd_event(key, 0, 2, UIntPtr.Zero);
            pressed.Remove(key);
		}

        public void releaseall() {
            foreach (Keys key in pressed) {
                up(key);
            }
        }
	}
}
