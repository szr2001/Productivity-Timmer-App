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
            this.AlarmTarget_T = new System.Windows.Forms.TextBox();
            this.OpenAppsAtStartup_Check = new System.Windows.Forms.CheckBox();
            this.Settings_FlowP = new System.Windows.Forms.FlowLayoutPanel();
            this.StartAlarm_Check = new System.Windows.Forms.CheckBox();
            this.AlarmTime_L = new System.Windows.Forms.Label();
            this.TimeElapsed_FlowP.SuspendLayout();
            this.Settings_FlowP.SuspendLayout();
            this.SuspendLayout();
            // 
            // TimerNumbr_L
            // 
            this.TimerNumbr_L.AutoSize = true;
            this.TimerNumbr_L.Font = new System.Drawing.Font("Segoe UI", 37F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TimerNumbr_L.Location = new System.Drawing.Point(15, 10);
            this.TimerNumbr_L.Margin = new System.Windows.Forms.Padding(0);
            this.TimerNumbr_L.Name = "TimerNumbr_L";
            this.TimerNumbr_L.Size = new System.Drawing.Size(186, 67);
            this.TimerNumbr_L.TabIndex = 0;
            this.TimerNumbr_L.Text = "0:00:00";
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
            this.TimeElapsed_FlowP.Padding = new System.Windows.Forms.Padding(15, 10, 0, 0);
            this.TimeElapsed_FlowP.Size = new System.Drawing.Size(218, 78);
            this.TimeElapsed_FlowP.TabIndex = 2;
            // 
            // ToggleTimmer_B
            // 
            this.ToggleTimmer_B.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(188)))), ((int)(((byte)(216)))));
            this.ToggleTimmer_B.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ToggleTimmer_B.Location = new System.Drawing.Point(138, 96);
            this.ToggleTimmer_B.Name = "ToggleTimmer_B";
            this.ToggleTimmer_B.Size = new System.Drawing.Size(98, 55);
            this.ToggleTimmer_B.TabIndex = 3;
            this.ToggleTimmer_B.Text = "Start";
            this.ToggleTimmer_B.UseVisualStyleBackColor = false;
            this.ToggleTimmer_B.Click += new System.EventHandler(this.ToggleTimmer);
            // 
            // AlarmTarget_T
            // 
            this.AlarmTarget_T.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AlarmTarget_T.Location = new System.Drawing.Point(10, 122);
            this.AlarmTarget_T.MaxLength = 7;
            this.AlarmTarget_T.Name = "AlarmTarget_T";
            this.AlarmTarget_T.Size = new System.Drawing.Size(122, 25);
            this.AlarmTarget_T.TabIndex = 4;
            this.AlarmTarget_T.Text = "0:00:00";
            this.AlarmTarget_T.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OpenAppsAtStartup_Check
            // 
            this.OpenAppsAtStartup_Check.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OpenAppsAtStartup_Check.Location = new System.Drawing.Point(17, 3);
            this.OpenAppsAtStartup_Check.Name = "OpenAppsAtStartup_Check";
            this.OpenAppsAtStartup_Check.Size = new System.Drawing.Size(206, 30);
            this.OpenAppsAtStartup_Check.TabIndex = 7;
            this.OpenAppsAtStartup_Check.Text = "Open Apps At Start";
            this.OpenAppsAtStartup_Check.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OpenAppsAtStartup_Check.UseVisualStyleBackColor = true;
            // 
            // Settings_FlowP
            // 
            this.Settings_FlowP.Controls.Add(this.OpenAppsAtStartup_Check);
            this.Settings_FlowP.Controls.Add(this.StartAlarm_Check);
            this.Settings_FlowP.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.Settings_FlowP.Location = new System.Drawing.Point(9, 157);
            this.Settings_FlowP.Name = "Settings_FlowP";
            this.Settings_FlowP.Size = new System.Drawing.Size(226, 100);
            this.Settings_FlowP.TabIndex = 8;
            // 
            // StartAlarm_Check
            // 
            this.StartAlarm_Check.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StartAlarm_Check.Location = new System.Drawing.Point(17, 39);
            this.StartAlarm_Check.Name = "StartAlarm_Check";
            this.StartAlarm_Check.Size = new System.Drawing.Size(206, 30);
            this.StartAlarm_Check.TabIndex = 8;
            this.StartAlarm_Check.Text = "Start Alarm";
            this.StartAlarm_Check.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.StartAlarm_Check.UseVisualStyleBackColor = true;
            // 
            // AlarmTime_L
            // 
            this.AlarmTime_L.AutoSize = true;
            this.AlarmTime_L.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AlarmTime_L.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AlarmTime_L.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AlarmTime_L.Location = new System.Drawing.Point(25, 100);
            this.AlarmTime_L.Name = "AlarmTime_L";
            this.AlarmTime_L.Size = new System.Drawing.Size(92, 23);
            this.AlarmTime_L.TabIndex = 9;
            this.AlarmTime_L.Text = "Alarm Time";
            this.AlarmTime_L.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(242, 263);
            this.Controls.Add(this.AlarmTime_L);
            this.Controls.Add(this.Settings_FlowP);
            this.Controls.Add(this.AlarmTarget_T);
            this.Controls.Add(this.ToggleTimmer_B);
            this.Controls.Add(this.TimeElapsed_FlowP);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "TimmerApp";
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
        private TextBox AlarmTarget_T;
        private CheckBox OpenAppsAtStartup_Check;
        private FlowLayoutPanel Settings_FlowP;
        private CheckBox StartAlarm_Check;
        private Label AlarmTime_L;
    }
}