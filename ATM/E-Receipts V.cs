using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class E_Receipts_V : Form
    {
        public E_Receipts_V()
        {
            InitializeComponent();
        }

        private void pbclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
            EReceipts1 eReceipts1 = new EReceipts1();
            eReceipts1.Show();
        }

        private void btnproceed_Click(object sender, EventArgs e)
        {
            if (Settings.randomcode2 == txtvcode.Text) 
            {
                string connectionString;
                SqlConnection cnn;

                connectionString = @"Data Source = SENITHUMESHA\SQLEXPRESS;Initial catalog = ZEMO_Bank;User ID=admin;Password=admin";

                cnn = new SqlConnection(connectionString);
                cnn.Open();
                string sql2 = "Update EReceipt set Status='" + "Yes" + "' where AccNo = '" + Dash1.AccNo + "' ";
                SqlCommand cmd2 = new SqlCommand(sql2, cnn);
                cmd2.ExecuteNonQuery();

                cnn.Close();

                cnn = new SqlConnection(connectionString);
                cnn.Open();
                string sql = "Update EReceipt set Email='" + Settings.Email + "' where AccNo = '" + Dash1.AccNo + "' ";
                SqlCommand cmd = new SqlCommand(sql, cnn);
                cmd.ExecuteNonQuery();

                cnn.Close();

                if (MessageBox.Show("You've successfully enabled our E-Receipt service", "E-Receipt", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK) 
                {
                    this.Close();
                    Settings settings = new Settings();
                    settings.Show();
                }
            }
            else
            {
                MessageBox.Show("Please Enter the Valid Code", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
