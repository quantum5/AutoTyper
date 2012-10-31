using System;
using AutoTyper;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AutoTyper {
	/// <summary>
	/// Description of ASCIItoKey.
	/// </summary>
	public class ASCIItoKey {
        static Dictionary<char, List<Keys>> char_to_key = new Dictionary<char, List<Keys>> {
             {'\n', new List<Keys>{Keys.Enter}},
             {'\r', new List<Keys>{Keys.Enter}},
             {'\b', new List<Keys>{Keys.Back}},
             {'\t', new List<Keys>{Keys.Tab}},

             {'!', new List<Keys>{Keys.Shift, Keys.D1}},
             {'@', new List<Keys>{Keys.Shift, Keys.D2}},
             {'#', new List<Keys>{Keys.Shift, Keys.D3}},
             {'$', new List<Keys>{Keys.Shift, Keys.D4}},
             {'%', new List<Keys>{Keys.Shift, Keys.D5}},
             {'^', new List<Keys>{Keys.Shift, Keys.D6}},
             {'&', new List<Keys>{Keys.Shift, Keys.D7}},
             {'*', new List<Keys>{Keys.Shift, Keys.D8}},
             {'(', new List<Keys>{Keys.Shift, Keys.D9}},
             {')', new List<Keys>{Keys.Shift, Keys.D0}},

             {'-', new List<Keys>{Keys.OemMinus}},
             {'_', new List<Keys>{Keys.Shift, Keys.OemMinus}},
             {'+', new List<Keys>{Keys.Oemplus}},

             {'[', new List<Keys>{Keys.OemOpenBrackets}},
             {'\\',new List<Keys>{Keys.OemPipe}},
             {']', new List<Keys>{Keys.OemCloseBrackets}},

             {'{', new List<Keys>{Keys.Shift, Keys.OemOpenBrackets}},
             {'|', new List<Keys>{Keys.Shift, Keys.OemPipe}},
             {'}', new List<Keys>{Keys.Shift, Keys.OemCloseBrackets}},
             
             {';', new List<Keys>{Keys.OemSemicolon}},
             {':', new List<Keys>{Keys.Shift, Keys.OemSemicolon}},
             {'\'',new List<Keys>{Keys.OemQuotes}},
             {'"', new List<Keys>{Keys.Shift, Keys.OemQuotes}},

             {',', new List<Keys>{Keys.Oemcomma}},
             {'.', new List<Keys>{Keys.OemPeriod}},
             {'/', new List<Keys>{Keys.Oem2}},

             {'<', new List<Keys>{Keys.Shift, Keys.Oemcomma}},
             {'>', new List<Keys>{Keys.Shift, Keys.OemPeriod}},
             {'?', new List<Keys>{Keys.Shift, Keys.Oem2}},
        };
		List<Keys> empty = new List<Keys>();
		
		static ASCIItoKey() {
			for (int i = 0; i < 10; ++i) {
				char_to_key[(char)(0x30+i)] = new List<Keys>{(Keys)(0x30+1)};
			}
			for (int i = 0; i < 26; ++i) {
				char_to_key[(char)(0x41+i)] = new List<Keys>{Keys.Shift, (Keys)(0x41+1)};
				char_to_key[(char)(0x61+i)] = new List<Keys>{(Keys)(0x41+1)};
			}
		}
		
		public static get(char ch) {
			return char_to_key[ch];
		}
	}
}
