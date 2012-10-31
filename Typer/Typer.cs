using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AutoTyper {
	public interface Typer {
		void down(Keys key);
		void up(Keys key);
	}
}
