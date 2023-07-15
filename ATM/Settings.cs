using DGVPrinterHelper;
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
    public partial class Settings : Form
    {
        public static string randomcode2 , Email , status;
        
        public Settings()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dash1 dash = new Dash1();
            dash.ShowDialog();
        }

        private void btncpin_Click(object sender, EventArgs e)
        {
            nearbyATM1.Hide();
            changePIN1.Show();
        }

        private void pbclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnnatms_Click(object sender, EventArgs e)
        {
            changePIN1.Hide();
            nearbyATM1.Show();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            nearbyATM1.Hide();
            changePIN1.Hide();
        }

        private void btnereceipts_Click(object sender, EventArgs e)
        {
            nearbyATM1.Hide();
            changePIN1.Hide();

            string connectionString;
            SqlConnection cnn;

            connectionString = @"Data Source = SENITHUMESHA\SQLEXPRESS;Initial catalog = ZEMO_Bank;User ID=admin;Password=admin";

            cnn = new SqlConnection(connectionString);
            cnn.Open();
            string sql5 = "Select Status from EReceipt where AccNo = '" + Dash1.AccNo + "'";
            SqlCommand cmd5 = new SqlCommand(sql5, cnn);

            using (SqlDataReader reader = cmd5.ExecuteReader())
            {
                while (reader.Read())
                {
                    status = Convert.ToString(reader["Status"]);
                }
            }

            cnn.Close();

            if (status == "No")
            {

                if (MessageBox.Show("After enabling this feature you won't be getting anymore PAPER RECEIPTS!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {

                    this.Close();
                    EReceipts1 eReceipts1 = new EReceipts1();
                    eReceipts1.Show();

                }
            }
            else 
            {
                MessageBox.Show("You've already enabled this feature!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
