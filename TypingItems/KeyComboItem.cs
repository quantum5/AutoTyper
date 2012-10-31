using System;
using AutoTyper;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AutoTyper {
	/// <summary>
	/// Description of KeyComboTyper.
	/// </summary>
	public class KeyComboTyper : TypeItem {
		private List<Keys> keys;
		private Typer typer;
		
		public KeyComboTyper(string input, Typer typer) {
			this.keys = ParseKeyCombo(input);
			this.typer = typer;
		}
		
		public static List<Keys> ParseKeyCombo(string combo) {
			List<String> parts = combo.Split('-', '+');
		}
		
		public void type() {
			foreach (char c in text) {
				List<Keys> keys = new List<Keys>(ASCIItoKey.get(c));
				foreach (Keys k in keys) {
					typer.down(k);
				}
				keys.Reverse();
				
				foreach (Keys k in keys) {
					typer.up(k);
				}
			}
		}
	}
}
