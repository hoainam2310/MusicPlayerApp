using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Threading.Tasks;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace MusicPlayerApp
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbConnection rcon = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void picb_exitregister_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picb_register_Click(object sender, EventArgs e)
        {
            if(txt_rusername.Text==""&&txt_rpassword.Text==""&&txt_rrepassword.Text=="")
            {
                MessageBox.Show("Username and Password fields are empty !", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_rpassword.Text==txt_rrepassword.Text)
            {
                con.Open();
                string check = "SELECT * FROM tbl_users WHERE username= '" + txt_rusername.Text + "'";
                cmd = new OleDbCommand(check, con);
                OleDbDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read() == true)
                {
                    MessageBox.Show("This username has already been used, Please try another one !", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_rusername.Text = "";
                    txt_rpassword.Text = "";
                    txt_rrepassword.Text = "";

                }
                else
                {
                    rcon.Open();
                    string register = "INSERT INTO tbl_users VALUES ('" + txt_rusername.Text + "','" + txt_rpassword.Text + "')";
                    cmd = new OleDbCommand(register, rcon);
                    cmd.ExecuteNonQuery();
                    rcon.Close();

                    txt_rusername.Text = "";
                    txt_rpassword.Text = "";
                    txt_rrepassword.Text = "";

                    MessageBox.Show("Your Account has been successfully created !", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Password doesn't match, Please Re-Enter !", "Registion Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_rpassword.Text = "";
                txt_rrepassword.Text = "";
                txt_rpassword.Focus();
            }
        }

        private void tx_backsignin_Click(object sender, EventArgs e)
        {
            new sign_in().Show();
            this.Hide();
        }

        private void chB_showpass_Click(object sender, EventArgs e)
        {
            if(chB_showpass.Checked==true)
            {
                txt_rpassword.UseSystemPasswordChar = false;
                txt_rrepassword.UseSystemPasswordChar = false;
            }
            else
            {
                txt_rpassword.UseSystemPasswordChar = true;
                txt_rrepassword.UseSystemPasswordChar = true;
            }
        }

        private void txt_rusername_Enter(object sender, EventArgs e)
        {
            if (txt_rusername.Text == "Enter Your Username")
            {
                txt_rusername.Text = "";
                txt_rusername.ForeColor = Color.Black;
            }
        }

        private void txt_rusername_Leave(object sender, EventArgs e)
        {
            if (txt_rusername.Text == "")
            {
                txt_rusername.Text = "Enter Your Username";
                txt_rusername.ForeColor = Color.Silver;
            }
        }

        private void txt_rpassword_Enter(object sender, EventArgs e)
        {
            if (txt_rpassword.Text == "Enter Your Password")
            {
                txt_rpassword.Text = "";
                txt_rpassword.ForeColor = Color.Black;
                txt_rpassword.UseSystemPasswordChar = true;
            }
        }

        private void txt_rpassword_Leave(object sender, EventArgs e)
        {
            if (txt_rpassword.Text == "")
            {
                txt_rpassword.Text = "Enter Your Password";
                txt_rpassword.ForeColor = Color.Silver;
                txt_rpassword.UseSystemPasswordChar = false;
            }
        }

        private void txt_rrepassword_Enter(object sender, EventArgs e)
        {
            if (txt_rrepassword.Text == "Re-Enter Your Password")
            {
                txt_rrepassword.Text = "";
                txt_rrepassword.ForeColor = Color.Black;
                txt_rrepassword.UseSystemPasswordChar = true;
            }
        }

        private void txt_rrepassword_Leave(object sender, EventArgs e)
        {
            if (txt_rrepassword.Text == "")
            {
                txt_rrepassword.Text = "Re-Enter Your Password";
                txt_rrepassword.ForeColor = Color.Silver;
                txt_rrepassword.UseSystemPasswordChar = false;
            }
        }
    }
}
