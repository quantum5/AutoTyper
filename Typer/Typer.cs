using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AutoTyper {
    public abstract class Typer {
        /// <summary>
        /// Make a key go down.
        /// </summary>
        /// <param name="key">Virtual Key Code</param>
        public abstract void down(Keys key);

        /// <summary>
        /// Make a key go up.
        /// </summary>
        /// <param name="key">Virtual Key Code</param>
        public abstract void up(Keys key);

        /// <summary>
        /// Release all keys pressed by this typer, used for emergency abortion.
        /// </summary>
        public abstract void releaseall();

        /// <summary>
        /// Flushes the key buffer if there is one.
        /// </summary>
        public virtual void flush() {}

        /// <summary>
        /// Types the string.
        /// </summary>
        /// <param name="text">The string to type</param>
        public abstract void text(string text);

        /// <summary>
        /// Presses and releases a key.
        /// </summary>
        /// <param name="key">The key to press</param>
        public virtual void press(Keys key) {
            down(key);
            up(key);
        }
    }
}
