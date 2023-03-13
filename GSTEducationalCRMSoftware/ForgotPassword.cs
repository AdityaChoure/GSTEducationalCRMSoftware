using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using clsLibrary.Admin;
using System.Data.SqlClient;

namespace GSTEducationalCRMSoftware
{
    public partial class ForgotPassword : Form
    {
        string OTPCode;
        public static string to;
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {

        }

        private void btnSendOTP_Click(object sender, EventArgs e)
        {
            string StaffEmail = txtbxEnterYourEmail.Text;
            clsAdmin obj = new clsAdmin(StaffEmail);
            SqlDataReader dr;
            dr = obj.Forgot();
            if (dr.HasRows == true)
            {
                dr.Read();
                string StaffPassword = dr["StaffPassword"].ToString();
                String from, pass, messagebody;
                MailMessage message = new MailMessage();
                to = (txtbxEnterYourEmail.Text).ToString();
                from = "gsteducationalcrmsoft@gmail.com";
                pass = "nwlwweawibxgvppo";
                messagebody = "YOUR PASSWORD IS"+StaffPassword;
                message.To.Add(to);
                message.From = new MailAddress(from);
                message.Body = messagebody;
                message.Subject = "GET PASSWORD";


                SmtpClient smtp = new SmtpClient("smtp.gmail.com",587);
                smtp.EnableSsl = true;

                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from, pass);
                

                try
                {
                    smtp.Send(message);
                    MessageBox.Show("Send Password Successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    this.Close();
                }

            }
        }

        private void btnVerifyOTP_Click(object sender, EventArgs e)
        {
           











































        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
        }
    }
}


