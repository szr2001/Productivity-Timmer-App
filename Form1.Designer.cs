namespace TimmerApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TimerNumbr_L = new System.Windows.Forms.Label();
            this.TimeElapsed_FlowP = new System.Windows.Forms.FlowLayoutPanel();
            this.ToggleTimmer_B = new System.Windows.Forms.Button();
            this.AlarmTargetH_T = new System.Windows.Forms.TextBox();
            this.OpenAppsAtStartup_Check = new System.Windows.Forms.CheckBox();
            this.Settings_FlowP = new System.Windows.Forms.FlowLayoutPanel();
            this.AutoStartTimmer_Check = new System.Windows.Forms.CheckBox();
            this.StartAlarm_Check = new System.Windows.Forms.CheckBox();
            this.ResumeTime_Check = new System.Windows.Forms.CheckBox();
            this.AlarmTime_L = new System.Windows.Forms.Label();
            this.AlarmTargetM_T = new System.Windows.Forms.TextBox();
            this.AlarmTargetS_T = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TimeElapsed_FlowP.SuspendLayout();
            this.Settings_FlowP.SuspendLayout();
            this.SuspendLayout();
            // 
            // TimerNumbr_L
            // 
            this.TimerNumbr_L.AutoSize = true;
            this.TimerNumbr_L.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TimerNumbr_L.Location = new System.Drawing.Point(10, 0);
            this.TimerNumbr_L.Margin = new System.Windows.Forms.Padding(0);
            this.TimerNumbr_L.Name = "TimerNumbr_L";
            this.TimerNumbr_L.Size = new System.Drawing.Size(197, 62);
            this.TimerNumbr_L.TabIndex = 0;
            this.TimerNumbr_L.Text = "00:00:00";
            // 
            // TimeElapsed_FlowP
            // 
            this.TimeElapsed_FlowP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeElapsed_FlowP.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TimeElapsed_FlowP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TimeElapsed_FlowP.Controls.Add(this.TimerNumbr_L);
            this.TimeElapsed_FlowP.Location = new System.Drawing.Point(12, 12);
            this.TimeElapsed_FlowP.Name = "TimeElapsed_FlowP";
            this.TimeElapsed_FlowP.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.TimeElapsed_FlowP.Size = new System.Drawing.Size(218, 64);
            this.TimeElapsed_FlowP.TabIndex = 2;
            // 
            // ToggleTimmer_B
            // 
            this.ToggleTimmer_B.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(188)))), ((int)(((byte)(216)))));
            this.ToggleTimmer_B.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ToggleTimmer_B.Location = new System.Drawing.Point(132, 82);
            this.ToggleTimmer_B.Name = "ToggleTimmer_B";
            this.ToggleTimmer_B.Size = new System.Drawing.Size(98, 55);
            this.ToggleTimmer_B.TabIndex = 3;
            this.ToggleTimmer_B.Text = "Start";
            this.ToggleTimmer_B.UseVisualStyleBackColor = false;
            this.ToggleTimmer_B.Click += new System.EventHandler(this.ToggleTimmer);
            // 
            // AlarmTargetH_T
            // 
            this.AlarmTargetH_T.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AlarmTargetH_T.Location = new System.Drawing.Point(25, 107);
            this.AlarmTargetH_T.MaxLength = 2;
            this.AlarmTargetH_T.Name = "AlarmTargetH_T";
            this.AlarmTargetH_T.Size = new System.Drawing.Size(22, 25);
            this.AlarmTargetH_T.TabIndex = 4;
            this.AlarmTargetH_T.Text = "00";
            this.AlarmTargetH_T.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AlarmTargetH_T.TextChanged += new System.EventHandler(this.UpdateTimeSettings);
            // 
            // OpenAppsAtStartup_Check
            // 
            this.OpenAppsAtStartup_Check.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.OpenAppsAtStartup_Check.Checked = true;
            this.OpenAppsAtStartup_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.OpenAppsAtStartup_Check.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OpenAppsAtStartup_Check.Location = new System.Drawing.Point(6, 37);
            this.OpenAppsAtStartup_Check.Name = "OpenAppsAtStartup_Check";
            this.OpenAppsAtStartup_Check.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.OpenAppsAtStartup_Check.Size = new System.Drawing.Size(199, 25);
            this.OpenAppsAtStartup_Check.TabIndex = 7;
            this.OpenAppsAtStartup_Check.Text = "Open Apps At Start";
            this.OpenAppsAtStartup_Check.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OpenAppsAtStartup_Check.UseVisualStyleBackColor = false;
            this.OpenAppsAtStartup_Check.CheckedChanged += new System.EventHandler(this.UpdateCheckBoxsesSettings);
            // 
            // Settings_FlowP
            // 
            this.Settings_FlowP.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Settings_FlowP.Controls.Add(this.AutoStartTimmer_Check);
            this.Settings_FlowP.Controls.Add(this.OpenAppsAtStartup_Check);
            this.Settings_FlowP.Controls.Add(this.StartAlarm_Check);
            this.Settings_FlowP.Controls.Add(this.ResumeTime_Check);
            this.Settings_FlowP.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.Settings_FlowP.Location = new System.Drawing.Point(17, 140);
            this.Settings_FlowP.Name = "Settings_FlowP";
            this.Settings_FlowP.Padding = new System.Windows.Forms.Padding(0, 3, 2, 0);
            this.Settings_FlowP.Size = new System.Drawing.Size(210, 130);
            this.Settings_FlowP.TabIndex = 8;
            // 
            // AutoStartTimmer_Check
            // 
            this.AutoStartTimmer_Check.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.AutoStartTimmer_Check.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AutoStartTimmer_Check.Location = new System.Drawing.Point(6, 6);
            this.AutoStartTimmer_Check.Name = "AutoStartTimmer_Check";
            this.AutoStartTimmer_Check.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.AutoStartTimmer_Check.Size = new System.Drawing.Size(199, 25);
            this.AutoStartTimmer_Check.TabIndex = 9;
            this.AutoStartTimmer_Check.Text = "Auto Start Timmer";
            this.AutoStartTimmer_Check.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AutoStartTimmer_Check.UseVisualStyleBackColor = false;
            this.AutoStartTimmer_Check.CheckedChanged += new System.EventHandler(this.UpdateCheckBoxsesSettings);
            // 
            // StartAlarm_Check
            // 
            this.StartAlarm_Check.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.StartAlarm_Check.Checked = true;
            this.StartAlarm_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.StartAlarm_Check.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StartAlarm_Check.Location = new System.Drawing.Point(6, 68);
            this.StartAlarm_Check.Name = "StartAlarm_Check";
            this.StartAlarm_Check.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.StartAlarm_Check.Size = new System.Drawing.Size(199, 25);
            this.StartAlarm_Check.TabIndex = 8;
            this.StartAlarm_Check.Text = "Use Alarm Sound";
            this.StartAlarm_Check.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.StartAlarm_Check.UseVisualStyleBackColor = false;
            this.StartAlarm_Check.CheckedChanged += new System.EventHandler(this.UpdateCheckBoxsesSettings);
            // 
            // ResumeTime_Check
            // 
            this.ResumeTime_Check.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ResumeTime_Check.Checked = true;
            this.ResumeTime_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ResumeTime_Check.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResumeTime_Check.Location = new System.Drawing.Point(6, 99);
            this.ResumeTime_Check.Name = "ResumeTime_Check";
            this.ResumeTime_Check.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.ResumeTime_Check.Size = new System.Drawing.Size(199, 25);
            this.ResumeTime_Check.TabIndex = 10;
            this.ResumeTime_Check.Text = "Resume timer on startup";
            this.ResumeTime_Check.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ResumeTime_Check.UseVisualStyleBackColor = false;
            this.ResumeTime_Check.CheckedChanged += new System.EventHandler(this.UpdateCheckBoxsesSettings);
            // 
            // AlarmTime_L
            // 
            this.AlarmTime_L.AutoSize = true;
            this.AlarmTime_L.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.AlarmTime_L.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AlarmTime_L.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AlarmTime_L.Location = new System.Drawing.Point(25, 85);
            this.AlarmTime_L.Name = "AlarmTime_L";
            this.AlarmTime_L.Size = new System.Drawing.Size(92, 23);
            this.AlarmTime_L.TabIndex = 9;
            this.AlarmTime_L.Text = "Alarm Time";
            this.AlarmTime_L.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AlarmTargetM_T
            // 
            this.AlarmTargetM_T.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AlarmTargetM_T.Location = new System.Drawing.Point(59, 107);
            this.AlarmTargetM_T.MaxLength = 2;
            this.AlarmTargetM_T.Name = "AlarmTargetM_T";
            this.AlarmTargetM_T.Size = new System.Drawing.Size(22, 25);
            this.AlarmTargetM_T.TabIndex = 10;
            this.AlarmTargetM_T.Text = "00";
            this.AlarmTargetM_T.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AlarmTargetM_T.TextChanged += new System.EventHandler(this.UpdateTimeSettings);
            // 
            // AlarmTargetS_T
            // 
            this.AlarmTargetS_T.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AlarmTargetS_T.Location = new System.Drawing.Point(95, 107);
            this.AlarmTargetS_T.MaxLength = 2;
            this.AlarmTargetS_T.Name = "AlarmTargetS_T";
            this.AlarmTargetS_T.Size = new System.Drawing.Size(22, 25);
            this.AlarmTargetS_T.TabIndex = 11;
            this.AlarmTargetS_T.Text = "00";
            this.AlarmTargetS_T.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AlarmTargetS_T.TextChanged += new System.EventHandler(this.UpdateTimeSettings);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(48, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = ":";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(84, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = ":";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(242, 282);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AlarmTargetS_T);
            this.Controls.Add(this.AlarmTargetM_T);
            this.Controls.Add(this.AlarmTime_L);
            this.Controls.Add(this.Settings_FlowP);
            this.Controls.Add(this.AlarmTargetH_T);
            this.Controls.Add(this.ToggleTimmer_B);
            this.Controls.Add(this.TimeElapsed_FlowP);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "TimmerApp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CloseForm);
            this.TimeElapsed_FlowP.ResumeLayout(false);
            this.TimeElapsed_FlowP.PerformLayout();
            this.Settings_FlowP.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label TimerNumbr_L;
        private FlowLayoutPanel TimeElapsed_FlowP;
        private Button ToggleTimmer_B;
        private TextBox AlarmTargetH_T;
        private CheckBox OpenAppsAtStartup_Check;
        private FlowLayoutPanel Settings_FlowP;
        private Label AlarmTime_L;
        private TextBox AlarmTargetM_T;
        private TextBox AlarmTargetS_T;
        private Label label1;
        private Label label2;
        private CheckBox AutoStartTimmer_Check;
        private CheckBox StartAlarm_Check;
        private CheckBox ResumeTime_Check;
    }
}