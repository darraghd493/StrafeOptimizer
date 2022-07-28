namespace StrafeOptimizer
{
    partial class Window
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.wStrafe = new System.Windows.Forms.Button();
            this.enable = new System.Windows.Forms.Button();
            this.aStrafe = new System.Windows.Forms.Button();
            this.sStrafe = new System.Windows.Forms.Button();
            this.dStrafe = new System.Windows.Forms.Button();
            this.speed = new System.Windows.Forms.NumericUpDown();
            this.githubLink = new System.Windows.Forms.LinkLabel();
            this.credits = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.speed)).BeginInit();
            this.SuspendLayout();
            // 
            // wStrafe
            // 
            this.wStrafe.Location = new System.Drawing.Point(12, 13);
            this.wStrafe.Name = "wStrafe";
            this.wStrafe.Size = new System.Drawing.Size(50, 50);
            this.wStrafe.TabIndex = 4;
            this.wStrafe.Text = "W";
            this.wStrafe.UseVisualStyleBackColor = true;
            this.wStrafe.Click += new System.EventHandler(this.wStrafe_Click);
            // 
            // enable
            // 
            this.enable.Location = new System.Drawing.Point(10, 69);
            this.enable.Name = "enable";
            this.enable.Size = new System.Drawing.Size(218, 40);
            this.enable.TabIndex = 4;
            this.enable.Text = "Enable";
            this.enable.UseVisualStyleBackColor = true;
            this.enable.Click += new System.EventHandler(this.enable_Click);
            // 
            // aStrafe
            // 
            this.aStrafe.Location = new System.Drawing.Point(68, 13);
            this.aStrafe.Name = "aStrafe";
            this.aStrafe.Size = new System.Drawing.Size(50, 50);
            this.aStrafe.TabIndex = 5;
            this.aStrafe.Text = "A";
            this.aStrafe.UseVisualStyleBackColor = true;
            this.aStrafe.Click += new System.EventHandler(this.aStrafe_Click);
            // 
            // sStrafe
            // 
            this.sStrafe.Location = new System.Drawing.Point(124, 13);
            this.sStrafe.Name = "sStrafe";
            this.sStrafe.Size = new System.Drawing.Size(50, 50);
            this.sStrafe.TabIndex = 6;
            this.sStrafe.Text = "S";
            this.sStrafe.UseVisualStyleBackColor = true;
            this.sStrafe.Click += new System.EventHandler(this.sStrafe_Click);
            // 
            // dStrafe
            // 
            this.dStrafe.Location = new System.Drawing.Point(180, 13);
            this.dStrafe.Name = "dStrafe";
            this.dStrafe.Size = new System.Drawing.Size(50, 50);
            this.dStrafe.TabIndex = 7;
            this.dStrafe.Text = "D";
            this.dStrafe.UseVisualStyleBackColor = true;
            this.dStrafe.Click += new System.EventHandler(this.dStrafe_Click);
            // 
            // speed
            // 
            this.speed.DecimalPlaces = 1;
            this.speed.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.speed.Location = new System.Drawing.Point(12, 117);
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(216, 20);
            this.speed.TabIndex = 8;
            this.speed.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // githubLink
            // 
            this.githubLink.AutoSize = true;
            this.githubLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.githubLink.Location = new System.Drawing.Point(192, 150);
            this.githubLink.Name = "githubLink";
            this.githubLink.Size = new System.Drawing.Size(38, 13);
            this.githubLink.TabIndex = 9;
            this.githubLink.TabStop = true;
            this.githubLink.Text = "Github";
            this.githubLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.githubLink_LinkClicked);
            // 
            // credits
            // 
            this.credits.AutoSize = true;
            this.credits.Location = new System.Drawing.Point(12, 150);
            this.credits.Name = "credits";
            this.credits.Size = new System.Drawing.Size(111, 13);
            this.credits.TabIndex = 10;
            this.credits.Text = "Made by darraghd493";
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 172);
            this.Controls.Add(this.credits);
            this.Controls.Add(this.githubLink);
            this.Controls.Add(this.speed);
            this.Controls.Add(this.dStrafe);
            this.Controls.Add(this.sStrafe);
            this.Controls.Add(this.aStrafe);
            this.Controls.Add(this.enable);
            this.Controls.Add(this.wStrafe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Window";
            this.Text = "Strafe Optimizer";
            this.Load += new System.EventHandler(this.Window_Load);
            ((System.ComponentModel.ISupportInitialize)(this.speed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button wStrafe;
        private System.Windows.Forms.Button enable;
        private System.Windows.Forms.Button aStrafe;
        private System.Windows.Forms.Button sStrafe;
        private System.Windows.Forms.Button dStrafe;
        private System.Windows.Forms.NumericUpDown speed;
        private System.Windows.Forms.LinkLabel githubLink;
        private System.Windows.Forms.Label credits;
    }
}

