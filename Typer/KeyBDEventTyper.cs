using System;
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
        
		public void down(Keys key) {
        	keybd_event(key, 0x45, 1, UIntPtr.Zero);
		}
        
		public void up(Keys key) {
        	keybd_event(key, 0x45, 3, UIntPtr.Zero);
		}
	}
}
