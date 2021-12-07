using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MusicPlayerApp;
using System.Net;
using System.Net.Mail;
using System.Data.OleDb;

namespace MusicApp
{
    public partial class forgotpw : Form
    {
        public forgotpw()
        {
            InitializeComponent();

        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbConnection rcon = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        public void sendMail(string yourMail, string toMail, string Text)
        {
            MailMessage mail = new MailMessage();
            SmtpClient server = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress(yourMail);
            mail.To.Add(toMail);
            mail.Subject = "Your password number code";
            mail.Body = Text;

            server.Port = 587;
            server.Credentials = new NetworkCredential(yourMail, "1845656170");
            server.EnableSsl = true;

            server.Send(mail);
            MessageBox.Show("Check your new password in your email!", "Message", MessageBoxButtons.OK);
        }


        private void picb_sendemail_Click_1(object sender, EventArgs e)
        {
            Random generator = new Random();
            String password = generator.Next(0, 1000000).ToString("D6");

            sendMail("18521126@gm.uit.edu.vn", txb_email.Text, password);
            rcon.Open();
            string register = "INSERT INTO tbl_users VALUES ('" + txb_email.Text + "','" + password + "')";
            cmd = new OleDbCommand(register, rcon);
            cmd.ExecuteNonQuery();
            rcon.Close();
        }

        private void picb_exitlogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            sign_in f = new sign_in();
            f.Show();
        }

        private void txb_email_Click(object sender, EventArgs e)
        {
            txb_email.Text = "";
            txb_email.ForeColor = Color.Black;
        }

        private void txb_email_TextChanged(object sender, EventArgs e)
        {
            txb_email.ForeColor = Color.Black;
        }
    }
}
