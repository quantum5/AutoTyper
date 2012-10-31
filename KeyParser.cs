using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace AutoTyper {
    class KeyParser {
        public static List<TypeItem> parse(string input, Typer typer) {
            List<TypeItem> output = new List<TypeItem>();
            StringBuilder buffer = new StringBuilder();
            int index = 0;

            while (index < input.Length) {
                char ch = input[index];
                switch (ch) {
                    case '\\':
                        System.Diagnostics.Debug.Write("Saw escaped: " + input[index + 1]);
                        buffer.Append(input[++index]);
                        break;
                    case '<': {
                            if (buffer.Length > 0) {
                                output.Add(new StringItem(buffer.ToString(), typer));
                                buffer.Clear();
                            }
                            while (input[++index] != '>')
                                buffer.Append(input[index]);
                            System.Diagnostics.Debug.Write("Saw Combo: " + buffer.ToString());
                            output.Add(new KeyComboItem(buffer.ToString(), typer));
                            buffer.Clear();
                            break;
                        }
                    default:
                        System.Diagnostics.Debug.Write("Saw Text: " + input[index]);
                        buffer.Append(input[index]);
                        break;
                }
                ++index;
            }
            if (buffer.Length > 0)
                output.Add(new StringItem(buffer.ToString(), typer));
            return output;
        }
    }
}
