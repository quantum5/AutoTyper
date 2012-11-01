using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AutoTyper {
	public interface Typer {
		/// <summary>
		/// Make a key go down.
		/// </summary>
		/// <param name="key">Virtual Key Code</param>
		void down(Keys key);
		/// <summary>
		/// Make a key go up.
		/// </summary>
		/// <param name="key">Virtual Key Code</param>
		void up(Keys key);
		/// <summary>
		/// Release all keys pressed by this typer, used for emergency abortion.
		/// </summary>
        void releaseall();
        /// <summary>
        /// Flushes the key buffer if there is one.
        /// </summary>
        void flush();
	}
}
