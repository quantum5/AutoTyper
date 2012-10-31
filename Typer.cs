using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AutoTyper {
    class Typer {
        [DllImport("user32.dll")]
        static extern void keybd_event(Keys key, byte scan, uint flags, UIntPtr extra);

        Dictionary<char, List<Keys>> char_to_key = new Dictionary<char, List<Keys>> {
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
    }
}
