
namespace MusicPlayerApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gb_login = new System.Windows.Forms.GroupBox();
            this.btn_signin = new System.Windows.Forms.Button();
            this.btn_signup = new System.Windows.Forms.Button();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gb_userinfo = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gb_mainmenu = new System.Windows.Forms.GroupBox();
            this.pb_user = new System.Windows.Forms.PictureBox();
            this.gb_login.SuspendLayout();
            this.gb_userinfo.SuspendLayout();
            this.gb_mainmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_user)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_login
            // 
            this.gb_login.Controls.Add(this.btn_signin);
            this.gb_login.Controls.Add(this.btn_signup);
            this.gb_login.Controls.Add(this.txt_password);
            this.gb_login.Controls.Add(this.label3);
            this.gb_login.Controls.Add(this.txt_username);
            this.gb_login.Controls.Add(this.label2);
            this.gb_login.Location = new System.Drawing.Point(410, 12);
            this.gb_login.Name = "gb_login";
            this.gb_login.Size = new System.Drawing.Size(514, 333);
            this.gb_login.TabIndex = 0;
            this.gb_login.TabStop = false;
            this.gb_login.Text = "Log-in Screen";
            // 
            // btn_signin
            // 
            this.btn_signin.Location = new System.Drawing.Point(300, 244);
            this.btn_signin.Name = "btn_signin";
            this.btn_signin.Size = new System.Drawing.Size(94, 29);
            this.btn_signin.TabIndex = 6;
            this.btn_signin.Text = "sign up";
            this.btn_signin.UseVisualStyleBackColor = true;
            // 
            // btn_signup
            // 
            this.btn_signup.Location = new System.Drawing.Point(178, 244);
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.Size = new System.Drawing.Size(94, 29);
            this.btn_signup.TabIndex = 5;
            this.btn_signup.Text = "sign in";
            this.btn_signup.UseVisualStyleBackColor = true;
            this.btn_signup.Click += new System.EventHandler(this.btn_signup_Click);
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(242, 178);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(213, 27);
            this.txt_password.TabIndex = 4;
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "password";
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(242, 128);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(213, 27);
            this.txt_username.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "username";
            // 
            // gb_userinfo
            // 
            this.gb_userinfo.Controls.Add(this.label5);
            this.gb_userinfo.Controls.Add(this.label4);
            this.gb_userinfo.Controls.Add(this.label1);
            this.gb_userinfo.Controls.Add(this.textBox3);
            this.gb_userinfo.Controls.Add(this.textBox2);
            this.gb_userinfo.Controls.Add(this.textBox1);
            this.gb_userinfo.Location = new System.Drawing.Point(1, 2);
            this.gb_userinfo.Name = "gb_userinfo";
            this.gb_userinfo.Size = new System.Drawing.Size(403, 343);
            this.gb_userinfo.TabIndex = 1;
            this.gb_userinfo.TabStop = false;
            this.gb_userinfo.Text = "User Information";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "full name";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(141, 184);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(213, 27);
            this.textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(141, 144);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(213, 27);
            this.textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(141, 105);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(213, 27);
            this.textBox1.TabIndex = 3;
            // 
            // gb_mainmenu
            // 
            this.gb_mainmenu.Controls.Add(this.pb_user);
            this.gb_mainmenu.Location = new System.Drawing.Point(1, 351);
            this.gb_mainmenu.Name = "gb_mainmenu";
            this.gb_mainmenu.Size = new System.Drawing.Size(923, 304);
            this.gb_mainmenu.TabIndex = 9;
            this.gb_mainmenu.TabStop = false;
            this.gb_mainmenu.Text = "Main Menu";
            // 
            // pb_user
            // 
            this.pb_user.Image = ((System.Drawing.Image)(resources.GetObject("pb_user.Image")));
            this.pb_user.Location = new System.Drawing.Point(11, 26);
            this.pb_user.Name = "pb_user";
            this.pb_user.Size = new System.Drawing.Size(62, 64);
            this.pb_user.TabIndex = 0;
            this.pb_user.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 654);
            this.Controls.Add(this.gb_mainmenu);
            this.Controls.Add(this.gb_userinfo);
            this.Controls.Add(this.gb_login);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gb_login.ResumeLayout(false);
            this.gb_login.PerformLayout();
            this.gb_userinfo.ResumeLayout(false);
            this.gb_userinfo.PerformLayout();
            this.gb_mainmenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_user)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_login;
        private System.Windows.Forms.Button btn_signin;
        private System.Windows.Forms.Button btn_signup;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gb_userinfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox gb_mainmenu;
        private System.Windows.Forms.PictureBox pb_user;
    }
}

