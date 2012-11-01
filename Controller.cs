using System;
using System.Windows.Forms;
using System.Threading;
using System.Collections.Generic;
using ICSharpCode.TextEditor;
using System.Drawing;
using System.ComponentModel;

namespace AutoTyper {
    struct TypeTask {
        public List<TypeItem> todo;
        public int delay;
        public int interval;
        public int repeats;
    }

    public partial class Controller : Form {
        public static bool CanUseClipboard = true;
        Thread worker;
        Typer typer;

        public Controller() {
            InitializeComponent();
            typer = new KeyBDEventTyper();

            this.Icon = Icon.ExtractAssociatedIcon(System.Reflection.Assembly.GetEntryAssembly().Location);
        }

        private void Execute(object sender, System.EventArgs e) {
            ExecuteButton.Enabled = false;
            List<TypeItem> todo;
            try {
                todo = KeyParser.parse(InputText.Text, typer);
            } catch (SyntaxError err) {
                MessageBox.Show(this, err.Message, "Syntax Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ExecuteButton.Enabled = true;
                return;
            }
            worker = new Thread(DoType);
            TypeTask task = new TypeTask();
            task.todo = todo;
            task.delay = (int)DelayTime.Value;
            task.interval = (int)IntervalTime.Value;
            task.repeats = (int)RepeatCount.Value;
            worker.Start(task);
        }

        void DoType(object obj) {
            try {
                TypeTask task = (TypeTask)obj;
                Thread.Sleep(task.delay);
                if (task.repeats > 0) {
                    for (int i = 0; i < task.repeats; ++i) {
                        Work(task.todo);
                        Thread.Sleep(task.interval);
                    }
                } else {
                    while (true) {
                        Work(task.todo);
                        Thread.Sleep(task.interval);
                    }
                }
            } catch (ThreadAbortException) {
                this.typer.releaseall();
            } finally {
                this.ExecuteButton.Invoke((Action) delegate {
                    this.ExecuteButton.Enabled = true;
                });
            }
        }

        void Work(List<TypeItem> todo) {
            foreach (TypeItem item in todo)
                item.type();
        }

        private void Terminate(object sender, EventArgs e) {
            worker.Abort();
        }

        private void ExecuteEnabled(object sender, EventArgs e) {
            TerminateButton.Enabled = !ExecuteButton.Enabled;
        }

        private void FormLoad(object sender, EventArgs e) {
            IntervalTime.Maximum = decimal.MaxValue;
            RepeatCount.Maximum = decimal.MaxValue;
        }

        private void Reset(object sender, EventArgs e) {
            this.Size = new Size(500, 400);
            this.DelayTime.Value = 1000;
            this.IntervalTime.Value = 0;
            this.RepeatCount.Value = 10;
            this.InputText.Text = "";
        }
    }
}
