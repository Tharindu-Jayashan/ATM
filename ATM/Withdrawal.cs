﻿using System;
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
    public partial class Withdrawal : Form
    {
        public static double Balance , NewBalance;
        public static string type = "Withdrawal";

        public Withdrawal()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
            Dash1 dash = new Dash1();
            dash.Show();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtwamount.Clear();
        }

        private void pbclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtwamount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!char.IsDigit(chr) && chr != 8 && chr != '.')
            {
                e.Handled = true;
                MessageBox.Show("Please Enter A Valid Value", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnproceed_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            string format = "yyyy-MM-dd HH:mm:ss";

            try
            {
                if (txtwamount.Text == "")
                {
                    MessageBox.Show("Please enter a valid value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else 
                {
                    double wamount = Convert.ToDouble(txtwamount.Text);

                    if (wamount <= 0)
                    {
                        MessageBox.Show("Amount can't be 0", "Bill Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        string connectionString;
                        SqlConnection cnn;

                        connectionString = @"Data Source = SENITHUMESHA\SQLEXPRESS;Initial catalog = ZEMO_Bank;User ID=admin;Password=admin";

                        cnn = new SqlConnection(connectionString);
                        cnn.Open();
                        string sql1 = "Select Balance from AccountDetails where Pin = '" + Home.signinPin + "'";
                        SqlCommand cmd1 = new SqlCommand(sql1, cnn);

                        using (SqlDataReader reader1 = cmd1.ExecuteReader())
                        {
                            while (reader1.Read())
                            {
                                Balance = Convert.ToDouble(reader1["Balance"]);
                            }
                        }
                        cnn.Close();

                        if (wamount <= Balance)
                        {
                            NewBalance = Balance - wamount;

                            cnn = new SqlConnection(connectionString);
                            cnn.Open();

                            string sql2 = "Update AccountDetails set Balance='" + NewBalance + "' where Pin = '" + Home.signinPin + "' ";
                            SqlCommand cmd2 = new SqlCommand(sql2, cnn);
                            cmd2.ExecuteNonQuery();

                            cnn.Close();

                            MessageBox.Show("Withdrawal completed", "Withdrawal", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            cnn = new SqlConnection(connectionString);
                            cnn.Open();

                            string sql3 = "INSERT INTO RecentT(AccNo,Type,Date,Amount) VALUES('" + Dash1.AccNo + "','" + type + "','" + time.ToString(format) + "','" + wamount + "')";
                            SqlCommand cmd3 = new SqlCommand(sql3, cnn);
                            cmd3.ExecuteNonQuery();

                            cnn.Close();

                            this.Hide();
                            Dash1 dash = new Dash1();
                            dash.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Insufficient balance", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(""+ex); }
        }
    }
}
