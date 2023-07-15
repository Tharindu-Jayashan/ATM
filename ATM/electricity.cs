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
using DGVPrinterHelper;
using System.Net.Mail;

namespace ATM
{
    public partial class electricity : UserControl
    {
        public static string type1 = "Electricity Bill Payment";
        public static string type2 = "Ceylon Electricity Board";
        public static double Balance, NewBalance;
        public static string status , Email;

        public electricity()
        {
            InitializeComponent();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtbillno.Clear();
            txtamount.Clear();
            txtcpin.Clear();
        }

        private void btnproceed_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            string format = "yyyy-MM-dd HH:mm:ss";

            if (txtbillno.Text == "" || txtamount.Text == "" || txtcpin.Text == "")
            {
                MessageBox.Show("Fields can't be empty", "Bill Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                double amount = Convert.ToDouble( txtamount.Text );

                if (amount <= 0)
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

                    if (Balance < amount)
                    {
                        MessageBox.Show("Insufficient balance", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (txtcpin.Text == Home.signinPin)
                        {
                            NewBalance = Balance - amount;

                            cnn = new SqlConnection(connectionString);
                            cnn.Open();

                            string sql2 = "Update AccountDetails set Balance='" + NewBalance + "' where Pin = '" + Home.signinPin + "' ";
                            SqlCommand cmd2 = new SqlCommand(sql2, cnn);
                            cmd2.ExecuteNonQuery();

                            cnn.Close();

                            cnn = new SqlConnection(connectionString);
                            cnn.Open();

                            string sql3 = "INSERT INTO RecentT(AccNo,Type,Date,Amount) VALUES('" + Dash1.AccNo + "','" + type1 + "','" + time.ToString(format) + "','" + amount + "')";
                            SqlCommand cmd3 = new SqlCommand(sql3, cnn);
                            cmd3.ExecuteNonQuery();

                            cnn.Close();

                            cnn = new SqlConnection(connectionString);
                            cnn.Open();

                            string sql4 = "INSERT INTO BillPayment(AccNo,BillNo,Type,Date,Amount) VALUES('" + Dash1.AccNo + "','" + txtbillno.Text + "','" + type2 + "','" + time.ToString(format) + "','" + amount + "')";
                            SqlCommand cmd4 = new SqlCommand(sql4, cnn);
                            cmd4.ExecuteNonQuery();

                            cnn.Close();

                            cnn = new SqlConnection(connectionString);
                            cnn.Open();
                            String sql = "Select*from BillPayment where BillNo = '" + txtbillno.Text + "' and Type = '" + type2 + "'";
                            SqlCommand cmd = new SqlCommand(sql, cnn);

                            SqlDataAdapter ada = new SqlDataAdapter(cmd);
                            DataTable dataTable = new DataTable();
                            ada.Fill(dataTable);
                            dgv.DataSource = dataTable;
                            cnn.Close();

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
                                DGVPrinter printer = new DGVPrinter();
                                printer.Title = "\r\n\r\n\r\n ZEMO Bank \r\n\r\n";
                                printer.SubTitle = "Payments - Ceylon Electricity Board \r\n\r\n";
                                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                                printer.PageNumbers = false;
                                printer.PageNumberInHeader = false;
                                printer.PorportionalColumns = true;
                                printer.HeaderCellAlignment = StringAlignment.Near;
                                printer.Footer = "Thank you - ZEMO Bank";
                                printer.FooterSpacing = 15;
                                printer.PrintDataGridView(dgv);

                                MessageBox.Show("Payment completed", "Bill Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else 
                            {
                                try
                                {
                                    cnn = new SqlConnection(connectionString);
                                    cnn.Open();
                                    string sql6 = "Select Email from EReceipt where AccNo = '" + Dash1.AccNo + "'";
                                    SqlCommand cmd6 = new SqlCommand(sql6, cnn);

                                    using (SqlDataReader reader2 = cmd6.ExecuteReader())
                                    {
                                        while (reader2.Read())
                                        {
                                            Email = Convert.ToString(reader2["Email"]);
                                        }
                                    }
                                    cnn.Close();

                                    MailMessage mail = new MailMessage();
                                    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                                    mail.From = new MailAddress("senithumeshac@gmail.com");
                                    mail.To.Add(Email);
                                    mail.Subject = "Electricity bill payment receipt - ZEMO Bank";
                                    mail.Body = "Your bank account number : " + Dash1.AccNo + "\nElectricity bill number : " + txtbillno.Text + "\nDate and time : " + time.ToString(format) + "\nPaid amount($) : " + amount;

                                    SmtpServer.Port = 587;
                                    SmtpServer.Credentials = new System.Net.NetworkCredential("senithumeshac@gmail.com", "senithumeshac#");
                                    SmtpServer.EnableSsl = true;

                                    SmtpServer.Send(mail);

                                    MessageBox.Show("Payment completed", "Bill Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                            }

                            this.Hide();
                        }
                        else 
                        {
                            MessageBox.Show("Incorrect PIN number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void txtbillno_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!char.IsDigit(chr) && chr != 8 )
            {
                e.Handled = true;
                MessageBox.Show("Please Enter A Valid Value", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtamount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!char.IsDigit(chr) && chr != 8 && chr != '.')
            {
                e.Handled = true;
                MessageBox.Show("Please Enter A Valid Value", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtcpin_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!char.IsDigit(chr) && chr != 8 )
            {
                e.Handled = true;
                MessageBox.Show("Please Enter A Valid Value", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void electricity_Load(object sender, EventArgs e)
        {
            dgv.Hide();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
