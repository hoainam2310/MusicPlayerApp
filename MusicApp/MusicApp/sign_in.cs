using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using MusicApp;
using System.Data.OleDb;

namespace MusicPlayerApp
{
    public partial class sign_in : Form
    {
        SoundPlayer _soundPlayer = new SoundPlayer(soundLocation: @"C:\Users\danie\Documents\GitHub\MusicPlayerApp\sounds\4.wav");
        public sign_in()
        {
            InitializeComponent();
            //_soundPlayer.Play();

        }


        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter(); 


        private void txt_username_Enter(object sender, EventArgs e)
        {
            if(txt_username.Text== "Enter Your Username")
            {
                txt_username.Text = "";
                txt_username.ForeColor = Color.Black;
            }
        }

        private void txt_username_Leave(object sender, EventArgs e)
        {
            if (txt_username.Text=="")
            {
                txt_username.Text = "Enter Your Username";
                txt_username.ForeColor = Color.Silver;
            }
        }

        private void txt_password_Enter(object sender, EventArgs e)
        {
            if (txt_password.Text == "Enter Your Password")
            {
                txt_password.Text = "";
                txt_password.ForeColor = Color.Black;
                txt_password.UseSystemPasswordChar = true;
            }
        }

        private void txt_password_Leave(object sender, EventArgs e)
        {
            if (txt_password.Text == "")
            {
                txt_password.Text = "Enter Your Password";
                txt_password.ForeColor = Color.Silver;
                txt_password.UseSystemPasswordChar = false;
            }
        }

        private void picb_exitlogin_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void tx_register_Click(object sender, EventArgs e)
        {
            this.Hide();
            register r = new register();
            r.Show();
        }
        private void picb_login_Click(object sender, EventArgs e)
        {
            con.Open();
            string login = "SELECT * FROM tbl_users WHERE username= '" + txt_username.Text + "' and password= '" + txt_password.Text + "'";
            cmd = new OleDbCommand(login, con);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read() == true)
            {
                this.Hide();
                new mainmenu().Show();
                
            }
            else
            {
                MessageBox.Show("Invalid Username or Password, Please try again !", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_username.Text = "";
                txt_password.Text = "";
                txt_username.Focus();
                con.Close();
            }
        }

        private void chB_showpass_CheckedChanged(object sender, EventArgs e)
        {
            if(chB_showpass.Checked == true)
            {
                txt_password.UseSystemPasswordChar = false;
            }    
            else
            {
                txt_password.UseSystemPasswordChar = true;
            }    
        }

        private void txb_forgotpw_Click(object sender, EventArgs e)
        {
            this.Hide();
            forgotpw f = new forgotpw();
            f.Show();
        }
    }
}
