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
            typer.text(this.text);
        }
    }
}
