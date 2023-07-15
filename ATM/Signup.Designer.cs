namespace ATM
{
    partial class Signup
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbclose = new System.Windows.Forms.PictureBox();
            this.lblreg = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtpin = new System.Windows.Forms.TextBox();
            this.txtcn = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtaccno = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblpass = new System.Windows.Forms.Label();
            this.lblbod = new System.Windows.Forms.Label();
            this.lblpin = new System.Windows.Forms.Label();
            this.lblcn = new System.Windows.Forms.Label();
            this.lbladdress = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.btnsignup = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbclose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 750);
            this.panel2.TabIndex = 48;
            // 
            // pbclose
            // 
            this.pbclose.Image = ((System.Drawing.Image)(resources.GetObject("pbclose.Image")));
            this.pbclose.Location = new System.Drawing.Point(710, 12);
            this.pbclose.Name = "pbclose";
            this.pbclose.Size = new System.Drawing.Size(28, 29);
            this.pbclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbclose.TabIndex = 47;
            this.pbclose.TabStop = false;
            this.pbclose.Click += new System.EventHandler(this.pbclose_Click);
            // 
            // lblreg
            // 
            this.lblreg.AutoSize = true;
            this.lblreg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblreg.Font = new System.Drawing.Font("Corbel", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblreg.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblreg.Location = new System.Drawing.Point(61, 50);
            this.lblreg.Name = "lblreg";
            this.lblreg.Size = new System.Drawing.Size(242, 49);
            this.lblreg.TabIndex = 109;
            this.lblreg.Text = "Registration :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dateTimePicker1.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(277, 484);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(400, 34);
            this.dateTimePicker1.TabIndex = 123;
            // 
            // txtpass
            // 
            this.txtpass.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.Location = new System.Drawing.Point(277, 548);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(400, 40);
            this.txtpass.TabIndex = 122;
            this.txtpass.Validating += new System.ComponentModel.CancelEventHandler(this.txtpass_Validating);
            // 
            // txtpin
            // 
            this.txtpin.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpin.Location = new System.Drawing.Point(277, 416);
            this.txtpin.Name = "txtpin";
            this.txtpin.Size = new System.Drawing.Size(400, 40);
            this.txtpin.TabIndex = 121;
            this.txtpin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpin_KeyPress);
            this.txtpin.Validating += new System.ComponentModel.CancelEventHandler(this.txtpin_Validating);
            // 
            // txtcn
            // 
            this.txtcn.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcn.Location = new System.Drawing.Point(277, 350);
            this.txtcn.Name = "txtcn";
            this.txtcn.Size = new System.Drawing.Size(400, 40);
            this.txtcn.TabIndex = 120;
            this.txtcn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcn_KeyPress);
            this.txtcn.Validating += new System.ComponentModel.CancelEventHandler(this.txtcn_Validating);
            // 
            // txtaddress
            // 
            this.txtaddress.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddress.Location = new System.Drawing.Point(277, 284);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(400, 40);
            this.txtaddress.TabIndex = 119;
            this.txtaddress.Validating += new System.ComponentModel.CancelEventHandler(this.txtaddress_Validating);
            // 
            // txtaccno
            // 
            this.txtaccno.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaccno.Location = new System.Drawing.Point(277, 218);
            this.txtaccno.Name = "txtaccno";
            this.txtaccno.Size = new System.Drawing.Size(400, 40);
            this.txtaccno.TabIndex = 118;
            this.txtaccno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtaccno_KeyPress);
            this.txtaccno.Validating += new System.ComponentModel.CancelEventHandler(this.txtaccno_Validating);
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(277, 152);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(400, 40);
            this.txtname.TabIndex = 117;
            this.txtname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtname_KeyPress);
            this.txtname.Validating += new System.ComponentModel.CancelEventHandler(this.txtname_Validating);
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblpass.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblpass.Location = new System.Drawing.Point(99, 551);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(139, 35);
            this.lblpass.TabIndex = 116;
            this.lblpass.Text = "Password :";
            // 
            // lblbod
            // 
            this.lblbod.AutoSize = true;
            this.lblbod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblbod.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblbod.Location = new System.Drawing.Point(63, 485);
            this.lblbod.Name = "lblbod";
            this.lblbod.Size = new System.Drawing.Size(175, 35);
            this.lblbod.TabIndex = 115;
            this.lblbod.Text = "Birth of date :";
            // 
            // lblpin
            // 
            this.lblpin.AutoSize = true;
            this.lblpin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblpin.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblpin.Location = new System.Drawing.Point(167, 419);
            this.lblpin.Name = "lblpin";
            this.lblpin.Size = new System.Drawing.Size(71, 35);
            this.lblpin.TabIndex = 114;
            this.lblpin.Text = "PIN :";
            // 
            // lblcn
            // 
            this.lblcn.AutoSize = true;
            this.lblcn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblcn.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblcn.Location = new System.Drawing.Point(91, 353);
            this.lblcn.Name = "lblcn";
            this.lblcn.Size = new System.Drawing.Size(147, 35);
            this.lblcn.TabIndex = 113;
            this.lblcn.Text = "Contact N :";
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbladdress.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbladdress.Location = new System.Drawing.Point(117, 287);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(121, 35);
            this.lbladdress.TabIndex = 112;
            this.lbladdress.Text = "Address :";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblid.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblid.Location = new System.Drawing.Point(77, 221);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(161, 35);
            this.lblid.TabIndex = 111;
            this.lblid.Text = "Account no :";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblname.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblname.Location = new System.Drawing.Point(139, 155);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(99, 35);
            this.lblname.TabIndex = 110;
            this.lblname.Text = "Name :";
            // 
            // btnsignup
            // 
            this.btnsignup.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnsignup.FlatAppearance.BorderSize = 0;
            this.btnsignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsignup.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsignup.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnsignup.Location = new System.Drawing.Point(486, 650);
            this.btnsignup.Name = "btnsignup";
            this.btnsignup.Size = new System.Drawing.Size(191, 55);
            this.btnsignup.TabIndex = 124;
            this.btnsignup.Text = "Sign Up";
            this.btnsignup.UseVisualStyleBackColor = false;
            this.btnsignup.Click += new System.EventHandler(this.btnsignup_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.DimGray;
            this.btnback.FlatAppearance.BorderSize = 0;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnback.Location = new System.Drawing.Point(277, 650);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(191, 55);
            this.btnback.TabIndex = 125;
            this.btnback.Text = "Go Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(750, 750);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnsignup);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtpin);
            this.Controls.Add(this.txtcn);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtaccno);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblpass);
            this.Controls.Add(this.lblbod);
            this.Controls.Add(this.lblpin);
            this.Controls.Add(this.lblcn);
            this.Controls.Add(this.lbladdress);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lblreg);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pbclose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Signup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZEMO Bank";
            ((System.ComponentModel.ISupportInitialize)(this.pbclose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbclose;
        private System.Windows.Forms.Label lblreg;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtpin;
        private System.Windows.Forms.TextBox txtcn;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtaccno;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.Label lblbod;
        private System.Windows.Forms.Label lblpin;
        private System.Windows.Forms.Label lblcn;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Button btnsignup;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}