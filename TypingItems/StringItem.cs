using System;
using AutoTyper;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AutoTyper {
	/// <summary>
	/// Description of StringItem.
	/// </summary>
	public class StringItem : TypeItem {
		private string text;
		private Typer typer;
		
		public StringItem(string input, Typer typer) {
			this.text = input;
			this.typer = typer;
		}
		
		public void type() {
			foreach (char c in text) {
				List<Keys> keys = new List<Keys>(ASCIItoKey.get(c));
				foreach (Keys k in keys) {
					typer.down(k);
                    System.Diagnostics.Debug.WriteLine(k);
				}
				keys.Reverse();
				
				foreach (Keys k in keys) {
					typer.up(k);
                    System.Diagnostics.Debug.WriteLine(k);
				}
			}
		}
	}
}
