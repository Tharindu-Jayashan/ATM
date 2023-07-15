using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ATM
{
    public partial class ChangePIN : UserControl
    {
        public static string AccNo;

        public ChangePIN()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtcnewpin.Clear();
            txtcpin.Clear();
            txtnewpin.Clear();
        }

        private void btnproceed_Click(object sender, EventArgs e)
        {
            if (txtcnewpin.Text == "" || txtcpin.Text == "" || txtnewpin.Text == "")
            {
                MessageBox.Show("Fields can't be empty", "Bill Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (txtcpin.Text == Home.signinPin)
                {
                    if (txtnewpin.Text != txtcnewpin.Text || txtcpin.Text == txtnewpin.Text)
                    {
                        MessageBox.Show("Please enter a valid PIN number", "Settings and Services", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        string connectionString;
                        SqlConnection cnn;

                        connectionString = @"Data Source = SENITHUMESHA\SQLEXPRESS;Initial catalog = ZEMO_Bank;User ID=admin;Password=admin";

                        cnn = new SqlConnection(connectionString);
                        cnn.Open();
                        string sql1 = "Select AccNo from AccountDetails where Pin = '" + Home.signinPin + "'";
                        SqlCommand cmd1 = new SqlCommand(sql1, cnn);

                        using (SqlDataReader reader1 = cmd1.ExecuteReader())
                        {
                            while (reader1.Read())
                            {
                                AccNo = Convert.ToString(reader1["AccNo"]);
                            }
                        }
                        cnn.Close();

                        cnn = new SqlConnection(connectionString);
                        cnn.Open();

                        string sql2 = "Update AccountDetails set Pin='" + txtnewpin.Text + "' where AccNo = '" + AccNo + "' ";
                        SqlCommand cmd2 = new SqlCommand(sql2, cnn);
                        cmd2.ExecuteNonQuery();

                        cnn.Close();

                        Home.signinPin = txtnewpin.Text;

                        MessageBox.Show("PIN number changed", "Settings and Services", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Hide();
                    }
                }
                else 
                {
                    MessageBox.Show("Your current PIN number is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txtcpin_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!char.IsDigit(chr) && chr != 8 && chr != '.')
            {
                e.Handled = true;
                MessageBox.Show("Please Enter A Valid Value", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtnewpin_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!char.IsDigit(chr) && chr != 8 && chr != '.')
            {
                e.Handled = true;
                MessageBox.Show("Please Enter A Valid Value", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtcnewpin_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!char.IsDigit(chr) && chr != 8 && chr != '.')
            {
                e.Handled = true;
                MessageBox.Show("Please Enter A Valid Value", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
