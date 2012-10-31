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
             {' ', new List<Keys>{Keys.Space}},

             {'!', new List<Keys>{Keys.ShiftKey, Keys.D1}},
             {'@', new List<Keys>{Keys.ShiftKey, Keys.D2}},
             {'#', new List<Keys>{Keys.ShiftKey, Keys.D3}},
             {'$', new List<Keys>{Keys.ShiftKey, Keys.D4}},
             {'%', new List<Keys>{Keys.ShiftKey, Keys.D5}},
             {'^', new List<Keys>{Keys.ShiftKey, Keys.D6}},
             {'&', new List<Keys>{Keys.ShiftKey, Keys.D7}},
             {'*', new List<Keys>{Keys.ShiftKey, Keys.D8}},
             {'(', new List<Keys>{Keys.ShiftKey, Keys.D9}},
             {')', new List<Keys>{Keys.ShiftKey, Keys.D0}},

             {'-', new List<Keys>{Keys.OemMinus}},
             {'_', new List<Keys>{Keys.ShiftKey, Keys.OemMinus}},
             {'+', new List<Keys>{Keys.Oemplus}},

             {'[', new List<Keys>{Keys.OemOpenBrackets}},
             {'\\',new List<Keys>{Keys.OemPipe}},
             {']', new List<Keys>{Keys.OemCloseBrackets}},

             {'{', new List<Keys>{Keys.ShiftKey, Keys.OemOpenBrackets}},
             {'|', new List<Keys>{Keys.ShiftKey, Keys.OemPipe}},
             {'}', new List<Keys>{Keys.ShiftKey, Keys.OemCloseBrackets}},
             
             {';', new List<Keys>{Keys.OemSemicolon}},
             {':', new List<Keys>{Keys.ShiftKey, Keys.OemSemicolon}},
             {'\'',new List<Keys>{Keys.OemQuotes}},
             {'"', new List<Keys>{Keys.ShiftKey, Keys.OemQuotes}},

             {',', new List<Keys>{Keys.Oemcomma}},
             {'.', new List<Keys>{Keys.OemPeriod}},
             {'/', new List<Keys>{Keys.Oem2}},

             {'<', new List<Keys>{Keys.ShiftKey, Keys.Oemcomma}},
             {'>', new List<Keys>{Keys.ShiftKey, Keys.OemPeriod}},
             {'?', new List<Keys>{Keys.ShiftKey, Keys.Oem2}},
        };
        static List<Keys> empty = new List<Keys>();

        static ASCIItoKey() {
            for (int i = 0; i < 10; ++i) {
                char_to_key[(char)(0x30 + i)] = new List<Keys> { (Keys)(0x30 + 1) };
            }
            for (int i = 0; i < 26; ++i) {
                char_to_key[(char)(0x41 + i)] = new List<Keys> { Keys.ShiftKey, (Keys)(0x41 + i) };
                char_to_key[(char)(0x61 + i)] = new List<Keys> { (Keys)(0x41 + i) };
            }
#if DEBUG
            foreach (var key in char_to_key.Keys)
                System.Diagnostics.Debug.WriteLine("    {'" + key + "': " + String.Join(", ", char_to_key[key]) + "},");
#endif
        }

        public static List<Keys> get(char ch) {
            try {
                return char_to_key[ch];
            } catch (KeyNotFoundException) {
                return empty;
            }
        }
    }
}
