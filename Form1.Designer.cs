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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ToggleTimmer_B = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Controls.Add(this.TimerNumbr_L);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(15, 10, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(210, 87);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // ToggleTimmer_B
            // 
            this.ToggleTimmer_B.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(188)))), ((int)(((byte)(216)))));
            this.ToggleTimmer_B.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ToggleTimmer_B.Location = new System.Drawing.Point(56, 116);
            this.ToggleTimmer_B.Name = "ToggleTimmer_B";
            this.ToggleTimmer_B.Size = new System.Drawing.Size(110, 55);
            this.ToggleTimmer_B.TabIndex = 3;
            this.ToggleTimmer_B.Text = "Start";
            this.ToggleTimmer_B.UseVisualStyleBackColor = false;
            this.ToggleTimmer_B.Click += new System.EventHandler(this.ToggleTimmer);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(234, 183);
            this.Controls.Add(this.ToggleTimmer_B);
            this.Controls.Add(this.flowLayoutPanel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "TimmerApp";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label TimerNumbr_L;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button ToggleTimmer_B;
    }
}