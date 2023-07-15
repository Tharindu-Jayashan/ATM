using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class EReceipts1 : Form
    {
        public EReceipts1()
        {
            InitializeComponent();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtcpin.Clear();
            txtemail.Clear();
        }

        private void btnproceed_Click(object sender, EventArgs e)
        {
            if (txtcpin.Text == "" || txtemail.Text == "")
            {
                MessageBox.Show("Above 2 fields can't be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtcpin.Text == Home.signinPin)
                {
                    try
                    {
                        Random random = new Random();
                        Settings.randomcode2 = (random.Next(999999)).ToString();

                        MailMessage mail = new MailMessage();
                        SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                        mail.From = new MailAddress("senithumeshac@gmail.com");
                        mail.To.Add(txtemail.Text);
                        mail.Subject = "E-Receipt Email Confirmation";
                        mail.Body = "Here is your code : " + Settings.randomcode2;

                        SmtpServer.Port = 587;
                        SmtpServer.Credentials = new System.Net.NetworkCredential("senithumeshac@gmail.com", "senithumeshac#");
                        SmtpServer.EnableSsl = true;

                        SmtpServer.Send(mail);

                        Settings.Email = txtemail.Text;

                        this.Close();
                        E_Receipts_V e_Receipts_V = new E_Receipts_V();
                        e_Receipts_V.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Your current PIN number is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
            Settings se = new Settings();
            se.Show();
        }

        private void pbclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
