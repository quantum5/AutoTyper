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
            //typer = new KeyBDEventTyper();
            typer = new SendInputTyper();

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
            FocusControl.FocusWindowUnder();
            worker.Start(task);
        }

        void DoType(object obj) {
#if DEBUG
            System.Diagnostics.Stopwatch stopWatch = new System.Diagnostics.Stopwatch();
            stopWatch.Start();
#endif
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
#if DEBUG
                stopWatch.Stop();
                System.Diagnostics.Debug.WriteLine("Task Completed in: " + stopWatch.ElapsedMilliseconds);
#endif
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


            Font monospace;
            try {
                monospace = new Font(new FontFamily("Consolas"), 12);
            } catch (ArgumentException) {
                monospace = new Font(FontFamily.GenericMonospace, 12);
            }
            InputText.Font = monospace;

            ContextMenu menu = new ContextMenu();
            menu.MenuItems.Add("&Undo", new EventHandler((o, ea) => {
                InputText.Undo();
                menu.MenuItems[1].Enabled = InputText.CanRedo;
            }));
            menu.MenuItems.Add("&Redo", new EventHandler((o, ea) => {
                InputText.Redo();
                menu.MenuItems[1].Enabled = InputText.CanRedo;
            }));
            menu.MenuItems[1].Enabled = false;
            menu.MenuItems.Add("-");
            menu.MenuItems.Add("C&ut", new EventHandler((o, ea) => InputText.Cut()));
            menu.MenuItems.Add("&Copy", new EventHandler((o, ea) => InputText.Copy()));
            menu.MenuItems.Add("&Paste", new EventHandler((o, ea) => InputText.Paste()));
            menu.MenuItems.Add("&Delete", new EventHandler((o, ea) => InputText.SelectedText = String.Empty));
            menu.MenuItems.Add("-");
            menu.MenuItems.Add("&Select All", new EventHandler((o, ea) => InputText.SelectAll()));
            menu.MenuItems.Add("-");
            menu.MenuItems.Add("Insert &GUID", new EventHandler((o, ea) => InputText.SelectedText = "<guid>"));
            menu.MenuItems.Add("Insert &Random String", new EventHandler((o, ea) => {
                InputText.SelectedText = "<random 10>";
                InputText.SelectionStart -= 3;
                InputText.SelectionLength = 2;
            }));
            menu.MenuItems.Add("Insert &Sleep (ms)", new EventHandler((o, ea) => {
                InputText.SelectedText = "<sleep 1000>";
                InputText.SelectionStart -= 5;
                InputText.SelectionLength = 4;
            }));
            InputText.ContextMenu = menu;
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
