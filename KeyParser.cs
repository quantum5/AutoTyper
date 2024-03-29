﻿using System;
using System.Collections.Generic;
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
                    case '<':
                        if (buffer.Length > 0) {
                            output.Add(new StringItem(buffer.ToString(), typer));
                            //buffer.clear();
                            buffer = new StringBuilder();
                        }
                        while (input[++index] != '>')
                            buffer.Append(input[index]);
                        string buf = buffer.ToString();
                        System.Diagnostics.Debug.Write("Saw Combo: " + buf);
                        if (buf.Contains(" ") || buf == "guid") {
                            output.Add(new ControlItem(buf, typer));
                        } else {
                            output.Add(new KeyComboItem(buf, typer));
                        }
                        buffer = new StringBuilder();
                        //buffer.clear();
                        break;
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
