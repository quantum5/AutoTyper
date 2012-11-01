namespace AutoTyper {
    partial class Controller {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            this.DelayLabel = new System.Windows.Forms.Label();
            this.DelayTime = new System.Windows.Forms.NumericUpDown();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.msDelayLabel = new System.Windows.Forms.Label();
            this.IntervalTime = new System.Windows.Forms.NumericUpDown();
            this.IntervalLabel = new System.Windows.Forms.Label();
            this.msLabelInterval = new System.Windows.Forms.Label();
            this.ExecuteButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.RepeatLabel = new System.Windows.Forms.Label();
            this.RepeatCount = new System.Windows.Forms.NumericUpDown();
            this.TerminateButton = new System.Windows.Forms.Button();
            this.InputText = new System.Windows.Forms.RichTextBox();
            this.LoadScriptLabel = new System.Windows.Forms.Label();
            this.ScriptLocation = new System.Windows.Forms.TextBox();
            this.BrowseScript = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DelayTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntervalTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepeatCount)).BeginInit();
            this.SuspendLayout();
            // 
            // DelayLabel
            // 
            this.DelayLabel.AutoSize = true;
            this.DelayLabel.Location = new System.Drawing.Point(12, 9);
            this.DelayLabel.Name = "DelayLabel";
            this.DelayLabel.Size = new System.Drawing.Size(41, 12);
            this.DelayLabel.TabIndex = 0;
            this.DelayLabel.Text = "Delay:";
            // 
            // DelayTime
            // 
            this.DelayTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DelayTime.Location = new System.Drawing.Point(77, 7);
            this.DelayTime.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.DelayTime.Name = "DelayTime";
            this.DelayTime.Size = new System.Drawing.Size(372, 21);
            this.DelayTime.TabIndex = 1;
            this.DelayTime.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Location = new System.Drawing.Point(12, 91);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(53, 12);
            this.MessageLabel.TabIndex = 2;
            this.MessageLabel.Text = "Message:";
            // 
            // msDelayLabel
            // 
            this.msDelayLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.msDelayLabel.AutoSize = true;
            this.msDelayLabel.Location = new System.Drawing.Point(455, 9);
            this.msDelayLabel.Name = "msDelayLabel";
            this.msDelayLabel.Size = new System.Drawing.Size(17, 12);
            this.msDelayLabel.TabIndex = 3;
            this.msDelayLabel.Text = "ms";
            // 
            // IntervalTime
            // 
            this.IntervalTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IntervalTime.Location = new System.Drawing.Point(77, 34);
            this.IntervalTime.Name = "IntervalTime";
            this.IntervalTime.Size = new System.Drawing.Size(372, 21);
            this.IntervalTime.TabIndex = 5;
            // 
            // IntervalLabel
            // 
            this.IntervalLabel.AutoSize = true;
            this.IntervalLabel.Location = new System.Drawing.Point(12, 36);
            this.IntervalLabel.Name = "IntervalLabel";
            this.IntervalLabel.Size = new System.Drawing.Size(59, 12);
            this.IntervalLabel.TabIndex = 6;
            this.IntervalLabel.Text = "Interval:";
            // 
            // msLabelInterval
            // 
            this.msLabelInterval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.msLabelInterval.AutoSize = true;
            this.msLabelInterval.Location = new System.Drawing.Point(455, 36);
            this.msLabelInterval.Name = "msLabelInterval";
            this.msLabelInterval.Size = new System.Drawing.Size(17, 12);
            this.msLabelInterval.TabIndex = 3;
            this.msLabelInterval.Text = "ms";
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ExecuteButton.Location = new System.Drawing.Point(12, 327);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.Size = new System.Drawing.Size(75, 23);
            this.ExecuteButton.TabIndex = 8;
            this.ExecuteButton.Text = "&Execute";
            this.ExecuteButton.UseVisualStyleBackColor = true;
            this.ExecuteButton.EnabledChanged += new System.EventHandler(this.ExecuteEnabled);
            this.ExecuteButton.Click += new System.EventHandler(this.Execute);
            // 
            // ResetButton
            // 
            this.ResetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetButton.Location = new System.Drawing.Point(397, 327);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 9;
            this.ResetButton.Text = "&Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.Reset);
            // 
            // RepeatLabel
            // 
            this.RepeatLabel.AutoSize = true;
            this.RepeatLabel.Location = new System.Drawing.Point(12, 63);
            this.RepeatLabel.Name = "RepeatLabel";
            this.RepeatLabel.Size = new System.Drawing.Size(47, 12);
            this.RepeatLabel.TabIndex = 10;
            this.RepeatLabel.Text = "Repeat:";
            // 
            // RepeatCount
            // 
            this.RepeatCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RepeatCount.Location = new System.Drawing.Point(77, 61);
            this.RepeatCount.Name = "RepeatCount";
            this.RepeatCount.Size = new System.Drawing.Size(372, 21);
            this.RepeatCount.TabIndex = 11;
            this.RepeatCount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // TerminateButton
            // 
            this.TerminateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TerminateButton.Enabled = false;
            this.TerminateButton.Location = new System.Drawing.Point(93, 327);
            this.TerminateButton.Name = "TerminateButton";
            this.TerminateButton.Size = new System.Drawing.Size(75, 23);
            this.TerminateButton.TabIndex = 13;
            this.TerminateButton.Text = "&Terminate";
            this.TerminateButton.UseVisualStyleBackColor = true;
            this.TerminateButton.Click += new System.EventHandler(this.Terminate);
            // 
            // InputText
            // 
            this.InputText.AcceptsTab = true;
            this.InputText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputText.Location = new System.Drawing.Point(14, 106);
            this.InputText.Name = "InputText";
            this.InputText.Size = new System.Drawing.Size(458, 188);
            this.InputText.TabIndex = 14;
            this.InputText.Text = "";
            // 
            // LoadScriptLabel
            // 
            this.LoadScriptLabel.AutoSize = true;
            this.LoadScriptLabel.Location = new System.Drawing.Point(12, 303);
            this.LoadScriptLabel.Name = "LoadScriptLabel";
            this.LoadScriptLabel.Size = new System.Drawing.Size(77, 12);
            this.LoadScriptLabel.TabIndex = 15;
            this.LoadScriptLabel.Text = "Load Script:";
            // 
            // ScriptLocation
            // 
            this.ScriptLocation.Location = new System.Drawing.Point(95, 300);
            this.ScriptLocation.Name = "ScriptLocation";
            this.ScriptLocation.Size = new System.Drawing.Size(296, 21);
            this.ScriptLocation.TabIndex = 16;
            // 
            // BrowseScript
            // 
            this.BrowseScript.Location = new System.Drawing.Point(397, 300);
            this.BrowseScript.Name = "BrowseScript";
            this.BrowseScript.Size = new System.Drawing.Size(75, 23);
            this.BrowseScript.TabIndex = 17;
            this.BrowseScript.Text = "&Browse...";
            this.BrowseScript.UseVisualStyleBackColor = true;
            this.BrowseScript.Click += new System.EventHandler(this.BrowseForScript);
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(174, 327);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(75, 23);
            this.LoadButton.TabIndex = 18;
            this.LoadButton.Text = "&Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadScript);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(255, 327);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 19;
            this.SaveButton.Text = "&Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveScript);
            // 
            // Controller
            // 
            this.AcceptButton = this.ExecuteButton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(484, 362);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.BrowseScript);
            this.Controls.Add(this.ScriptLocation);
            this.Controls.Add(this.LoadScriptLabel);
            this.Controls.Add(this.InputText);
            this.Controls.Add(this.TerminateButton);
            this.Controls.Add(this.RepeatCount);
            this.Controls.Add(this.RepeatLabel);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.ExecuteButton);
            this.Controls.Add(this.IntervalLabel);
            this.Controls.Add(this.IntervalTime);
            this.Controls.Add(this.msLabelInterval);
            this.Controls.Add(this.msDelayLabel);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.DelayTime);
            this.Controls.Add(this.DelayLabel);
            this.Name = "Controller";
            this.Text = "AutoTyper";
            this.Load += new System.EventHandler(this.FormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.DelayTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntervalTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepeatCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DelayLabel;
        private System.Windows.Forms.NumericUpDown DelayTime;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.Label msDelayLabel;
        private System.Windows.Forms.NumericUpDown IntervalTime;
        private System.Windows.Forms.Label IntervalLabel;
        private System.Windows.Forms.Label msLabelInterval;
        private System.Windows.Forms.Button ExecuteButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label RepeatLabel;
        private System.Windows.Forms.NumericUpDown RepeatCount;
        private System.Windows.Forms.Button TerminateButton;
        private System.Windows.Forms.RichTextBox InputText;
        private System.Windows.Forms.Label LoadScriptLabel;
        private System.Windows.Forms.TextBox ScriptLocation;
        private System.Windows.Forms.Button BrowseScript;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button SaveButton;
    }
}

