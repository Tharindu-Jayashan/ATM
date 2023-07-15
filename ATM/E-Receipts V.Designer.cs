namespace ATM
{
    partial class E_Receipts_V
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(E_Receipts_V));
            this.lblvcode = new System.Windows.Forms.Label();
            this.btnback = new System.Windows.Forms.Button();
            this.lblinfo = new System.Windows.Forms.Label();
            this.txtvcode = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnproceed = new System.Windows.Forms.Button();
            this.pbclose = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbclose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblvcode
            // 
            this.lblvcode.AutoSize = true;
            this.lblvcode.BackColor = System.Drawing.Color.White;
            this.lblvcode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblvcode.Font = new System.Drawing.Font("Corbel", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvcode.ForeColor = System.Drawing.Color.DimGray;
            this.lblvcode.Location = new System.Drawing.Point(62, 429);
            this.lblvcode.Name = "lblvcode";
            this.lblvcode.Size = new System.Drawing.Size(303, 46);
            this.lblvcode.TabIndex = 125;
            this.lblvcode.Text = "Verification code :";
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.DimGray;
            this.btnback.FlatAppearance.BorderSize = 0;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnback.Location = new System.Drawing.Point(292, 649);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(191, 55);
            this.btnback.TabIndex = 124;
            this.btnback.Text = "Go Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // lblinfo
            // 
            this.lblinfo.AutoSize = true;
            this.lblinfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblinfo.Font = new System.Drawing.Font("Corbel", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblinfo.Location = new System.Drawing.Point(95, 331);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(578, 49);
            this.lblinfo.TabIndex = 123;
            this.lblinfo.Text = "We\'ve sent you a verification code";
            // 
            // txtvcode
            // 
            this.txtvcode.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvcode.ForeColor = System.Drawing.Color.Gray;
            this.txtvcode.Location = new System.Drawing.Point(394, 435);
            this.txtvcode.Name = "txtvcode";
            this.txtvcode.Size = new System.Drawing.Size(295, 40);
            this.txtvcode.TabIndex = 122;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 750);
            this.panel2.TabIndex = 121;
            // 
            // btnproceed
            // 
            this.btnproceed.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnproceed.FlatAppearance.BorderSize = 0;
            this.btnproceed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnproceed.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnproceed.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnproceed.Location = new System.Drawing.Point(292, 565);
            this.btnproceed.Name = "btnproceed";
            this.btnproceed.Size = new System.Drawing.Size(191, 55);
            this.btnproceed.TabIndex = 120;
            this.btnproceed.Text = "Proceed";
            this.btnproceed.UseVisualStyleBackColor = false;
            this.btnproceed.Click += new System.EventHandler(this.btnproceed_Click);
            // 
            // pbclose
            // 
            this.pbclose.Image = ((System.Drawing.Image)(resources.GetObject("pbclose.Image")));
            this.pbclose.Location = new System.Drawing.Point(710, 12);
            this.pbclose.Name = "pbclose";
            this.pbclose.Size = new System.Drawing.Size(28, 29);
            this.pbclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbclose.TabIndex = 119;
            this.pbclose.TabStop = false;
            this.pbclose.Click += new System.EventHandler(this.pbclose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(263, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 118;
            this.pictureBox1.TabStop = false;
            // 
            // E_Receipts_V
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(750, 750);
            this.Controls.Add(this.lblvcode);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.lblinfo);
            this.Controls.Add(this.txtvcode);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnproceed);
            this.Controls.Add(this.pbclose);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "E_Receipts_V";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZEMO Bank";
            ((System.ComponentModel.ISupportInitialize)(this.pbclose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblvcode;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Label lblinfo;
        private System.Windows.Forms.TextBox txtvcode;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnproceed;
        private System.Windows.Forms.PictureBox pbclose;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}