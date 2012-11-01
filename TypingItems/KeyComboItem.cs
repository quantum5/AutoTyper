using System;
using AutoTyper;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AutoTyper {
    /// <summary>
    /// Description of KeyComboTyper.
    /// </summary>
    public class KeyComboItem : TypeItem {
        private List<Keys> keys;
        private Typer typer;
        private static Dictionary<string, Keys> text_to_key = new Dictionary<string, Keys> {
            {"CTRL", Keys.ControlKey},
            {"CONTROL", Keys.ControlKey},
            {"SHIFT", Keys.ShiftKey},
            {"ALT", Keys.Menu},
            {"META", Keys.Menu},
            {"MENU", Keys.Menu},
            {"WIN", Keys.LWin},
            {"WINDOWS", Keys.LWin},
            {"LWIN", Keys.LWin},
            {"RWIN", Keys.RWin},
            {"PGDN", Keys.PageDown},
            {"PAGEDOWN", Keys.PageDown},
            {"PAGEDN", Keys.PageDown},
            {"PGUP", Keys.PageUp},
            {"PAGEUP", Keys.PageUp},
        };

        public KeyComboItem(string input, Typer typer) {
            this.keys = ParseKeyCombo(input);
            this.typer = typer;
        }

        public static List<Keys> ParseKeyCombo(string combo) {
            string[] parts = combo.Split('-', '+');
            List<Keys> keys = new List<Keys>();
            foreach (string part in parts) {
                string upper = part.ToUpper();
                if (part.Length == 1) {
                    int ascii = (int)upper[0];
                    if (ascii < 0x41 || ascii > 0x5A)
                        throw new SyntaxError("Invalid Character");
                    keys.Add((Keys)ascii);
                    continue;
                }
                try {
                    keys.Add(text_to_key[upper]);
                } catch (KeyNotFoundException) {
                    throw new SyntaxError("Invalid key name: " + part);
                }
            }
            return keys;
        }

        public void type() {
            foreach (Keys k in keys) {
                typer.down(k);
            }
            for (int i = keys.Count; i > 0;) {
                typer.up(keys[--i]);
            }
        }
    }
}
