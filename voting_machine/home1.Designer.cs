namespace voting_machine
{
    partial class home1
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.voting_meter = new Guna.UI2.WinForms.Guna2RadialGauge();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.guna2Panel1.BorderColor = System.Drawing.Color.White;
            this.guna2Panel1.BorderRadius = 100;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Location = new System.Drawing.Point(500, 482);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(201, 66);
            this.guna2Panel1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(69, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(504, 436);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 36);
            this.label2.TabIndex = 8;
            this.label2.Text = "Voting Meter";
            // 
            // voting_meter
            // 
            this.voting_meter.ArrowThickness = 5;
            this.voting_meter.Font = new System.Drawing.Font("Verdana", 8.2F);
            this.voting_meter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.voting_meter.Location = new System.Drawing.Point(415, 100);
            this.voting_meter.MinimumSize = new System.Drawing.Size(30, 30);
            this.voting_meter.Name = "voting_meter";
            this.voting_meter.ProgressColor = System.Drawing.Color.DarkBlue;
            this.voting_meter.ProgressColor2 = System.Drawing.Color.DarkBlue;
            this.voting_meter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.voting_meter.ShowPercentage = false;
            this.voting_meter.Size = new System.Drawing.Size(371, 371);
            this.voting_meter.TabIndex = 7;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.Silver;
            this.guna2Separator1.Location = new System.Drawing.Point(415, 55);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(409, 10);
            this.guna2Separator1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(405, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "Welcome in HF Voting System";
            // 
            // home1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.voting_meter);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.label1);
            this.Name = "home1";
            this.Size = new System.Drawing.Size(1239, 564);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2RadialGauge voting_meter;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}
