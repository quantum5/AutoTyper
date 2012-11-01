using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace AutoTyper {
    class ControlItem : TypeItem {
        string function;
        List<string> arguments;
        Typer typer;

        public ControlItem(string input, Typer typer) {
            string[] args = input.Split(' ');
            this.function = args[0];
            this.arguments = new List<string>();
            for (int i = 1; i < args.Length; ++i)
                if (!string.IsNullOrEmpty(args[i]))
                    this.arguments.Add(args[i]);
            this.typer = typer;
        }

        private static Random random = new Random();

        private string RandomString(int size) {
            StringBuilder builder = new StringBuilder(size);
            for (int i = 0; i < size; i++)
                builder.Append((char)random.Next(0x21, 0x7F));
            return builder.ToString();
        }

        public void type() {
            switch (function.ToLower()) {
                case "sleep":
                    try {
                        Thread.Sleep(int.Parse(arguments[0]));
                    } catch (Exception e) {
                        System.Diagnostics.Debug.WriteLine(e.ToString());
                        Thread.Sleep(1000);
                    }
                    break;
                case "random":
                    try {
                        typer.text(RandomString(int.Parse(arguments[0])));
                    } catch (Exception e) {
                        System.Diagnostics.Debug.WriteLine(e.ToString());
                        typer.text(RandomString(int.Parse(arguments[0])));
                    }
                    break;
                case "guid":
                    typer.text(Guid.NewGuid().ToString());
                    break;
            }
            typer.flush();
        }
    }
}
