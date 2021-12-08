using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Equalizer
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private AxVCProX.AxvcproEqualizerX equalizer;
		private AxVCProX.AxvcproWaveInDeviceX waveIn;
		private AxVCProX.AxvcproWaveOutDeviceX waveOut;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.TrackBar tb01;
		private System.Windows.Forms.TrackBar tb02;
		private System.Windows.Forms.TrackBar tb03;
		private System.Windows.Forms.TrackBar tb04;
		private System.Windows.Forms.TrackBar tb05;
		private System.Windows.Forms.TrackBar tb10;
		private System.Windows.Forms.TrackBar tb09;
		private System.Windows.Forms.TrackBar tb08;
		private System.Windows.Forms.TrackBar tb07;
		private System.Windows.Forms.TrackBar tb06;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.ComponentModel.IContainer components;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.equalizer = new AxVCProX.AxvcproEqualizerX();
			this.waveIn = new AxVCProX.AxvcproWaveInDeviceX();
			this.waveOut = new AxVCProX.AxvcproWaveOutDeviceX();
			this.tb01 = new System.Windows.Forms.TrackBar();
			this.tb02 = new System.Windows.Forms.TrackBar();
			this.tb03 = new System.Windows.Forms.TrackBar();
			this.tb04 = new System.Windows.Forms.TrackBar();
			this.tb05 = new System.Windows.Forms.TrackBar();
			this.tb10 = new System.Windows.Forms.TrackBar();
			this.tb09 = new System.Windows.Forms.TrackBar();
			this.tb08 = new System.Windows.Forms.TrackBar();
			this.tb07 = new System.Windows.Forms.TrackBar();
			this.tb06 = new System.Windows.Forms.TrackBar();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.button3 = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.equalizer)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.waveIn)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.waveOut)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tb01)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tb02)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tb03)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tb04)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tb05)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tb10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tb09)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tb08)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tb07)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tb06)).BeginInit();
			this.SuspendLayout();
			// 
			// equalizer
			// 
			this.equalizer.Enabled = true;
			this.equalizer.Location = new System.Drawing.Point(96, 8);
			this.equalizer.Name = "equalizer";
			this.equalizer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("equalizer.OcxState")));
			this.equalizer.Size = new System.Drawing.Size(75, 32);
			this.equalizer.TabIndex = 0;
			// 
			// waveIn
			// 
			this.waveIn.Enabled = true;
			this.waveIn.Location = new System.Drawing.Point(8, 8);
			this.waveIn.Name = "waveIn";
			this.waveIn.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("waveIn.OcxState")));
			this.waveIn.Size = new System.Drawing.Size(75, 32);
			this.waveIn.TabIndex = 1;
			// 
			// waveOut
			// 
			this.waveOut.Enabled = true;
			this.waveOut.Location = new System.Drawing.Point(184, 8);
			this.waveOut.Name = "waveOut";
			this.waveOut.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("waveOut.OcxState")));
			this.waveOut.Size = new System.Drawing.Size(75, 32);
			this.waveOut.TabIndex = 2;
			// 
			// tb01
			// 
			this.tb01.Location = new System.Drawing.Point(8, 128);
			this.tb01.Minimum = -10;
			this.tb01.Name = "tb01";
			this.tb01.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.tb01.Size = new System.Drawing.Size(42, 168);
			this.tb01.TabIndex = 3;
			this.tb01.ValueChanged += new System.EventHandler(this.tb01_ValueChanged);
			// 
			// tb02
			// 
			this.tb02.Location = new System.Drawing.Point(48, 128);
			this.tb02.Minimum = -10;
			this.tb02.Name = "tb02";
			this.tb02.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.tb02.Size = new System.Drawing.Size(42, 168);
			this.tb02.TabIndex = 4;
			this.tb02.ValueChanged += new System.EventHandler(this.tb01_ValueChanged);
			// 
			// tb03
			// 
			this.tb03.Location = new System.Drawing.Point(88, 128);
			this.tb03.Minimum = -10;
			this.tb03.Name = "tb03";
			this.tb03.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.tb03.Size = new System.Drawing.Size(42, 168);
			this.tb03.TabIndex = 5;
			this.tb03.ValueChanged += new System.EventHandler(this.tb01_ValueChanged);
			// 
			// tb04
			// 
			this.tb04.Location = new System.Drawing.Point(128, 128);
			this.tb04.Minimum = -10;
			this.tb04.Name = "tb04";
			this.tb04.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.tb04.Size = new System.Drawing.Size(42, 168);
			this.tb04.TabIndex = 6;
			this.tb04.ValueChanged += new System.EventHandler(this.tb01_ValueChanged);
			// 
			// tb05
			// 
			this.tb05.Location = new System.Drawing.Point(168, 128);
			this.tb05.Minimum = -10;
			this.tb05.Name = "tb05";
			this.tb05.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.tb05.Size = new System.Drawing.Size(42, 168);
			this.tb05.TabIndex = 7;
			this.tb05.ValueChanged += new System.EventHandler(this.tb01_ValueChanged);
			// 
			// tb10
			// 
			this.tb10.Location = new System.Drawing.Point(368, 128);
			this.tb10.Minimum = -10;
			this.tb10.Name = "tb10";
			this.tb10.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.tb10.Size = new System.Drawing.Size(42, 168);
			this.tb10.TabIndex = 12;
			this.tb10.ValueChanged += new System.EventHandler(this.tb01_ValueChanged);
			// 
			// tb09
			// 
			this.tb09.Location = new System.Drawing.Point(328, 128);
			this.tb09.Minimum = -10;
			this.tb09.Name = "tb09";
			this.tb09.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.tb09.Size = new System.Drawing.Size(42, 168);
			this.tb09.TabIndex = 11;
			this.tb09.ValueChanged += new System.EventHandler(this.tb01_ValueChanged);
			// 
			// tb08
			// 
			this.tb08.Location = new System.Drawing.Point(288, 128);
			this.tb08.Minimum = -10;
			this.tb08.Name = "tb08";
			this.tb08.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.tb08.Size = new System.Drawing.Size(42, 168);
			this.tb08.TabIndex = 10;
			this.tb08.ValueChanged += new System.EventHandler(this.tb01_ValueChanged);
			// 
			// tb07
			// 
			this.tb07.Location = new System.Drawing.Point(248, 128);
			this.tb07.Minimum = -10;
			this.tb07.Name = "tb07";
			this.tb07.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.tb07.Size = new System.Drawing.Size(42, 168);
			this.tb07.TabIndex = 9;
			this.tb07.ValueChanged += new System.EventHandler(this.tb01_ValueChanged);
			// 
			// tb06
			// 
			this.tb06.Location = new System.Drawing.Point(208, 128);
			this.tb06.Minimum = -10;
			this.tb06.Name = "tb06";
			this.tb06.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.tb06.Size = new System.Drawing.Size(42, 168);
			this.tb06.TabIndex = 8;
			this.tb06.ValueChanged += new System.EventHandler(this.tb01_ValueChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(400, 136);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 16);
			this.label1.TabIndex = 13;
			this.label1.Text = "+10 db";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(400, 272);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(36, 16);
			this.label2.TabIndex = 14;
			this.label2.Text = "-10 db";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(408, 205);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(26, 16);
			this.label3.TabIndex = 15;
			this.label3.Text = "0 db";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(8, 56);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(39, 16);
			this.label4.TabIndex = 17;
			this.label4.Text = "Device";
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Location = new System.Drawing.Point(64, 56);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(200, 21);
			this.comboBox1.TabIndex = 16;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(8, 88);
			this.button1.Name = "button1";
			this.button1.TabIndex = 18;
			this.button1.Text = "Start";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(96, 88);
			this.button2.Name = "button2";
			this.button2.TabIndex = 19;
			this.button2.Text = "Stop";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// timer1
			// 
			this.timer1.Interval = 500;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(8, 328);
			this.button3.Name = "button3";
			this.button3.TabIndex = 20;
			this.button3.Text = "Reset";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(8, 296);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(34, 16);
			this.label5.TabIndex = 21;
			this.label5.Text = "31 Hz";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(48, 296);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(34, 16);
			this.label6.TabIndex = 22;
			this.label6.Text = "63 Hz";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(88, 296);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(40, 16);
			this.label7.TabIndex = 23;
			this.label7.Text = "125 Hz";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(128, 296);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(40, 16);
			this.label8.TabIndex = 24;
			this.label8.Text = "250 Hz";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(168, 296);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(40, 16);
			this.label9.TabIndex = 25;
			this.label9.Text = "500 Hz";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(208, 296);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(33, 16);
			this.label10.TabIndex = 26;
			this.label10.Text = "1 kHz";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(248, 296);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(33, 16);
			this.label11.TabIndex = 27;
			this.label11.Text = "2 kHz";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(288, 296);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(33, 16);
			this.label12.TabIndex = 28;
			this.label12.Text = "4 kHz";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(328, 296);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(33, 16);
			this.label13.TabIndex = 29;
			this.label13.Text = "8 kHz";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(368, 296);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(39, 16);
			this.label14.TabIndex = 30;
			this.label14.Text = "16 kHz";
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(272, 56);
			this.button4.Name = "button4";
			this.button4.TabIndex = 31;
			this.button4.Text = "Recording...";
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(360, 56);
			this.button5.Name = "button5";
			this.button5.TabIndex = 32;
			this.button5.Text = "Playback...";
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(450, 365);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.tb10);
			this.Controls.Add(this.tb09);
			this.Controls.Add(this.tb08);
			this.Controls.Add(this.tb07);
			this.Controls.Add(this.tb06);
			this.Controls.Add(this.tb05);
			this.Controls.Add(this.tb04);
			this.Controls.Add(this.tb03);
			this.Controls.Add(this.tb02);
			this.Controls.Add(this.tb01);
			this.Controls.Add(this.waveOut);
			this.Controls.Add(this.waveIn);
			this.Controls.Add(this.equalizer);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "Equalizer :: (C) Lake of Soft";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.Form1_Closing);
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.equalizer)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.waveIn)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.waveOut)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tb01)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tb02)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tb03)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tb04)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tb05)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tb10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tb09)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tb08)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tb07)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tb06)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void SetLink(VCProX.IvcproProvider provider, VCProX.IvcproConsumer consumer)
		{
			provider.AddConsumer(consumer);
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			for (int i = 0; i < waveIn.GetDeviceCount(); i++)
				comboBox1.Items.Add(waveIn.GetDeviceName(i));
			comboBox1.SelectedIndex = 0;

			SetLink((VCProX.IvcproProvider)waveIn.GetOcx(), (VCProX.IvcproConsumer)equalizer.GetOcx());
			SetLink((VCProX.IvcproProvider)equalizer.GetOcx(), (VCProX.IvcproConsumer)waveOut.GetOcx());

			timer1.Enabled = true;
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			Start();
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			Stop();
		}

		private void Start()
		{
			waveIn.DeviceId = comboBox1.SelectedIndex;
			waveOut.DeviceId = comboBox1.SelectedIndex;

			waveIn.Active = true;
		}

		private void Stop()
		{
			waveIn.Active = false;
		}

		private void timer1_Tick(object sender, System.EventArgs e)
		{
			button2.Enabled = waveIn.Active;
			button1.Enabled = !button2.Enabled;
		}

		private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			timer1.Enabled = false;
			Stop();
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			Reset();
		}

		private void Reset()
		{
			tb01.Value = 0;
			tb02.Value = 0;
			tb03.Value = 0;
			tb04.Value = 0;
			tb05.Value = 0;
			tb06.Value = 0;
			tb07.Value = 0;
			tb08.Value = 0;
			tb09.Value = 0;
			tb10.Value = 0;
		}

		private void ChangeGain()
		{
			equalizer.SetGain(00, tb01.Value);
			equalizer.SetGain(01, tb02.Value);
			equalizer.SetGain(02, tb03.Value);
			equalizer.SetGain(03, tb04.Value);
			equalizer.SetGain(04, tb05.Value);
			equalizer.SetGain(05, tb06.Value);
			equalizer.SetGain(06, tb07.Value);
			equalizer.SetGain(07, tb08.Value);
			equalizer.SetGain(08, tb09.Value);
			equalizer.SetGain(09, tb10.Value);
		}

		private void tb01_ValueChanged(object sender, System.EventArgs e)
		{
			ChangeGain();
		}

		private void button4_Click(object sender, System.EventArgs e)
		{
			System.Diagnostics.Process.Start("sndvol32", "/r /d" +
				Convert.ToString(waveIn.GetMixerId(comboBox1.SelectedIndex, true)));
		}

		private void button5_Click(object sender, System.EventArgs e)
		{
			System.Diagnostics.Process.Start("sndvol32", "/p /d" +
				Convert.ToString(waveIn.GetMixerId(comboBox1.SelectedIndex, false)));
		}
	}
}
