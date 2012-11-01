using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Text;

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
                SetControlPropertyThreadSafe(this.ExecuteButton, "Enabled", true);
            }
        }

        private delegate void SetControlPropertyThreadSafeDelegate(Control control, string propertyName, object propertyValue);

        public static void SetControlPropertyThreadSafe(Control control, string propertyName, object propertyValue) {
            if (control.InvokeRequired) {
                control.Invoke(new SetControlPropertyThreadSafeDelegate(SetControlPropertyThreadSafe), new object[] { control, propertyName, propertyValue });
            } else {
                control.GetType().InvokeMember(propertyName, System.Reflection.BindingFlags.SetProperty, null, control, new object[] { propertyValue });
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

        private void BrowseForScript(object sender, EventArgs e) {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.FileName = ScriptLocation.Text;
            dialog.Filter = "Type Script File (*.tps)|*.tps|All Files (*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK) {
                ScriptLocation.Text = dialog.FileName;
            }
        }

        private void LoadScript(object sender, EventArgs e) {
            try {
                InputText.Text = File.ReadAllText(ScriptLocation.Text, Encoding.UTF8);
            } catch (IOException err) {
                MessageBox.Show(err.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveScript(object sender, EventArgs e) {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.FileName = ScriptLocation.Text;
            dialog.Filter = "Type Script File (*.tps)|*.tps|All Files (*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK) {
                ScriptLocation.Text = dialog.FileName;
            }
            try {
                File.WriteAllText(ScriptLocation.Text, InputText.Text, Encoding.UTF8);
            } catch (IOException err) {
                MessageBox.Show(err.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
