﻿namespace AutoTyper {
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
            this.label2 = new System.Windows.Forms.Label();
            this.msDelayLabel = new System.Windows.Forms.Label();
            this.IntervalTime = new System.Windows.Forms.NumericUpDown();
            this.IntervalLabel = new System.Windows.Forms.Label();
            this.msLabelInterval = new System.Windows.Forms.Label();
            this.MessageToType = new System.Windows.Forms.TextBox();
            this.ExecuteButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DelayTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntervalTime)).BeginInit();
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
            this.DelayTime.Name = "DelayTime";
            this.DelayTime.Size = new System.Drawing.Size(272, 21);
            this.DelayTime.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Message:";
            // 
            // msDelayLabel
            // 
            this.msDelayLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.msDelayLabel.AutoSize = true;
            this.msDelayLabel.Location = new System.Drawing.Point(355, 9);
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
            this.IntervalTime.Size = new System.Drawing.Size(272, 21);
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
            this.msLabelInterval.Location = new System.Drawing.Point(355, 36);
            this.msLabelInterval.Name = "msLabelInterval";
            this.msLabelInterval.Size = new System.Drawing.Size(17, 12);
            this.msLabelInterval.TabIndex = 3;
            this.msLabelInterval.Text = "ms";
            // 
            // MessageToType
            // 
            this.MessageToType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MessageToType.Location = new System.Drawing.Point(14, 79);
            this.MessageToType.Multiline = true;
            this.MessageToType.Name = "MessageToType";
            this.MessageToType.Size = new System.Drawing.Size(358, 142);
            this.MessageToType.TabIndex = 7;
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ExecuteButton.Location = new System.Drawing.Point(12, 227);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.Size = new System.Drawing.Size(75, 23);
            this.ExecuteButton.TabIndex = 8;
            this.ExecuteButton.Text = "&Execute";
            this.ExecuteButton.UseVisualStyleBackColor = true;
            // 
            // ResetButton
            // 
            this.ResetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetButton.Location = new System.Drawing.Point(297, 227);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 9;
            this.ResetButton.Text = "&Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            // 
            // Controller
            // 
            this.AcceptButton = this.ExecuteButton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(384, 262);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.ExecuteButton);
            this.Controls.Add(this.MessageToType);
            this.Controls.Add(this.IntervalLabel);
            this.Controls.Add(this.IntervalTime);
            this.Controls.Add(this.msLabelInterval);
            this.Controls.Add(this.msDelayLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DelayTime);
            this.Controls.Add(this.DelayLabel);
            this.Name = "Controller";
            this.Text = "AutoTyper";
            ((System.ComponentModel.ISupportInitialize)(this.DelayTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntervalTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DelayLabel;
        private System.Windows.Forms.NumericUpDown DelayTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label msDelayLabel;
        private System.Windows.Forms.NumericUpDown IntervalTime;
        private System.Windows.Forms.Label IntervalLabel;
        private System.Windows.Forms.Label msLabelInterval;
        private System.Windows.Forms.TextBox MessageToType;
        private System.Windows.Forms.Button ExecuteButton;
        private System.Windows.Forms.Button ResetButton;
    }
}

