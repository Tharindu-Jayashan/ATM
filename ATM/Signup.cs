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
    public partial class Signup : Form
    {
        public Signup()
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
            Home home = new Home();
            home.Show();
        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (txtcn.Text.Length != 10)
                {
                    MessageBox.Show("Enter a valid contact number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    String name = txtname.Text;
                    String accno = txtaccno.Text;
                    String address = txtaddress.Text;
                    String password = txtpass.Text;
                    String phonenum = txtcn.Text;
                    String pin = txtpin.Text;
                    String dob = dateTimePicker1.Value.ToString();
                    double balance = 0;

                    string connectionString;
                    SqlConnection cnn;

                    connectionString = @"Data Source = SENITHUMESHA\SQLEXPRESS;Initial catalog = ZEMO_Bank;User ID=admin;Password=admin";

                    cnn = new SqlConnection(connectionString);
                    cnn.Open();
                    string sql1 = "Select AccNo from AccountDetails where AccNo = '" + accno + "'";
                    SqlCommand cmd1 = new SqlCommand(sql1, cnn);
                    SqlDataReader reader1 = cmd1.ExecuteReader();

                    if (reader1.HasRows)
                    {
                        MessageBox.Show("This account number has already been registered", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        cnn = new SqlConnection(connectionString);
                        cnn.Open();
                        string sql2 = "Select Pin from AccountDetails where Pin = '" + pin + "'";
                        SqlCommand cmd2 = new SqlCommand(sql2, cnn);
                        SqlDataReader reader2 = cmd2.ExecuteReader();

                        if (reader2.HasRows)
                        {
                            MessageBox.Show("This PIN has already been registered", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            cnn = new SqlConnection(connectionString);
                            cnn.Open();

                            string sql3 = "INSERT INTO AccountDetails(Name,AccNo,Password,Address,Contact_number,Birth_of_date,Pin,Balance) VALUES('" + name + "','" + accno + "','" + password + "','" + address + "','" + phonenum + "','" + dob + "','" + pin + "','" + balance + "')";
                            SqlCommand cmd3 = new SqlCommand(sql3, cnn);
                            cmd3.ExecuteNonQuery();

                            cnn.Close();

                            cnn = new SqlConnection(connectionString);
                            cnn.Open();

                            string sql4 = "INSERT INTO EReceipt(AccNo,Status,Email) VALUES('" + accno + "','" + "No" + "','" + "null" + "')";
                            SqlCommand cmd4 = new SqlCommand(sql4, cnn);
                            cmd4.ExecuteNonQuery();

                            cnn.Close();

                            MessageBox.Show("Your account has been successfully created", "Registation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.Hide();
                            Home home = new Home();
                            home.ShowDialog();
                        }
                        cnn.Close();
                    }
                    cnn.Close();
                }
            }
        }

        private void txtname_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtname.Text))
            {
                e.Cancel = true;
                txtname.Focus();
                errorProvider1.SetError(txtname, "Please Enter Your Name");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtname, null);
            }
        }

        private void txtaddress_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtaddress.Text))
            {
                e.Cancel = true;
                txtaddress.Focus();
                errorProvider1.SetError(txtaddress, "Please Enter Your Address");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtaddress, null);
            }
        }

        private void txtcn_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtcn.Text))
            {
                e.Cancel = true;
                txtcn.Focus();
                errorProvider1.SetError(txtcn, "Please Enter Your Contact Number");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtcn, null);
            }
        }

        private void txtpin_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtpin.Text))
            {
                e.Cancel = true;
                txtpin.Focus();
                errorProvider1.SetError(txtpin, "Please Enter Your PIN Number");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtpin, null);
            }
        }

        private void txtpass_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtpass.Text))
            {
                e.Cancel = true;
                txtpass.Focus();
                errorProvider1.SetError(txtpass, "Please Enter Your Password");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtpass, null);
            }
        }

        private void txtcn_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!char.IsDigit(chr) && chr != 8 )
            {
                e.Handled = true;
                MessageBox.Show("Please Enter A Valid Value", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtpin_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!char.IsDigit(chr) && chr != 8 )
            {
                e.Handled = true;
                MessageBox.Show("Please Enter A Valid Value", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtaccno_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtaccno.Text))
            {
                e.Cancel = true;
                txtaccno.Focus();
                errorProvider1.SetError(txtaccno, "Please Enter Your Acc No");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtaccno, null);
            }
        }

        private void txtaccno_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please Enter A Valid Value", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtname_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!char.IsLetter(chr) && chr != 8 && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please Enter A Valid Value", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
