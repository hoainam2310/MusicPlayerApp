namespace MusicPlayer
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.txtThemBH = new System.Windows.Forms.TextBox();
            this.lbPlaylist = new System.Windows.Forms.ListBox();
            this.pbPlaylist = new System.Windows.Forms.PictureBox();
            this.tmPlaylist = new System.Windows.Forms.Timer(this.components);
            this.pbStatus1 = new System.Windows.Forms.PictureBox();
            this.pbStatus2 = new System.Windows.Forms.PictureBox();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.pbSetting = new System.Windows.Forms.PictureBox();
            this.pbPlay = new System.Windows.Forms.PictureBox();
            this.pbNext = new System.Windows.Forms.PictureBox();
            this.pbStop = new System.Windows.Forms.PictureBox();
            this.pbPrevious = new System.Windows.Forms.PictureBox();
            this.pbMute = new System.Windows.Forms.PictureBox();
            this.pbClosePlalist = new System.Windows.Forms.PictureBox();
            this.pbVolume = new System.Windows.Forms.PictureBox();
            this.pbNode = new System.Windows.Forms.PictureBox();
            this.lbHienTai = new System.Windows.Forms.Label();
            this.lbTGConLai = new System.Windows.Forms.Label();
            this.pbManHinh = new System.Windows.Forms.PictureBox();
            this.media = new AxWMPLib.AxWindowsMediaPlayer();
            this.lbTimKiem = new System.Windows.Forms.ListBox();
            this.tmChinh = new System.Windows.Forms.Timer(this.components);
            this.tmPhu = new System.Windows.Forms.Timer(this.components);
            this.lbChinhTocDo = new System.Windows.Forms.Label();
            this.pbOpenFiles = new System.Windows.Forms.PictureBox();
            this.tmThoiGian = new System.Windows.Forms.Timer(this.components);
            this.pbThem = new System.Windows.Forms.PictureBox();
            this.pbAdd = new System.Windows.Forms.PictureBox();
            this.pbRemove = new System.Windows.Forms.PictureBox();
            this.pbDown = new System.Windows.Forms.PictureBox();
            this.pbUp = new System.Windows.Forms.PictureBox();
            this.pbQuickImport = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picb_playdemo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlaylist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatus1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatus2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSetting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrevious)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClosePlalist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbManHinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.media)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOpenFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbThem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuickImport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_playdemo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtThemBH
            // 
            this.txtThemBH.Location = new System.Drawing.Point(825, 33);
            this.txtThemBH.Name = "txtThemBH";
            this.txtThemBH.Size = new System.Drawing.Size(231, 20);
            this.txtThemBH.TabIndex = 0;
            this.txtThemBH.Text = "Nhập tên bài hát / kéo thả file *.mp3 vào";
            this.txtThemBH.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtThemBH_MouseClick);
            this.txtThemBH.TextChanged += new System.EventHandler(this.txtThemBH_TextChanged);
            this.txtThemBH.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtThemBH_KeyDown);
            // 
            // lbPlaylist
            // 
            this.lbPlaylist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lbPlaylist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbPlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlaylist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(151)))), ((int)(((byte)(187)))));
            this.lbPlaylist.FormattingEnabled = true;
            this.lbPlaylist.ItemHeight = 16;
            this.lbPlaylist.Location = new System.Drawing.Point(823, 71);
            this.lbPlaylist.Name = "lbPlaylist";
            this.lbPlaylist.Size = new System.Drawing.Size(300, 544);
            this.lbPlaylist.TabIndex = 1;
            this.lbPlaylist.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pbStatus1_MouseUp);
            // 
            // pbPlaylist
            // 
            this.pbPlaylist.Location = new System.Drawing.Point(45, 648);
            this.pbPlaylist.Name = "pbPlaylist";
            this.pbPlaylist.Size = new System.Drawing.Size(10, 12);
            this.pbPlaylist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbPlaylist.TabIndex = 2;
            this.pbPlaylist.TabStop = false;
            this.pbPlaylist.Click += new System.EventHandler(this.pbPlaylist_Click);
            this.pbPlaylist.MouseLeave += new System.EventHandler(this.pbPlaylist_MouseLeave);
            this.pbPlaylist.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbPlaylist_MouseMove);
            // 
            // tmPlaylist
            // 
            this.tmPlaylist.Interval = 10;
            this.tmPlaylist.Tick += new System.EventHandler(this.tmPlaylist_Tick);
            // 
            // pbStatus1
            // 
            this.pbStatus1.BackColor = System.Drawing.Color.Transparent;
            this.pbStatus1.Location = new System.Drawing.Point(7, 630);
            this.pbStatus1.Name = "pbStatus1";
            this.pbStatus1.Size = new System.Drawing.Size(800, 5);
            this.pbStatus1.TabIndex = 3;
            this.pbStatus1.TabStop = false;
            this.pbStatus1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbStatus1_MouseDown);
            this.pbStatus1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbStatus1_MouseMove);
            this.pbStatus1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbStatus1_MouseUp);
            // 
            // pbStatus2
            // 
            this.pbStatus2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(151)))), ((int)(((byte)(187)))));
            this.pbStatus2.Location = new System.Drawing.Point(7, 625);
            this.pbStatus2.Name = "pbStatus2";
            this.pbStatus2.Size = new System.Drawing.Size(800, 5);
            this.pbStatus2.TabIndex = 4;
            this.pbStatus2.TabStop = false;
            this.pbStatus2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbStatus2_MouseDown);
            this.pbStatus2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbStatus2_MouseMove);
            this.pbStatus2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbStatus2_MouseUp);
            // 
            // pbClose
            // 
            this.pbClose.Image = ((System.Drawing.Image)(resources.GetObject("pbClose.Image")));
            this.pbClose.Location = new System.Drawing.Point(784, 5);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(23, 15);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbClose.TabIndex = 5;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            this.pbClose.MouseLeave += new System.EventHandler(this.pbClose_MouseLeave);
            this.pbClose.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbClose_MouseMove);
            // 
            // pbSetting
            // 
            this.pbSetting.Image = ((System.Drawing.Image)(resources.GetObject("pbSetting.Image")));
            this.pbSetting.Location = new System.Drawing.Point(60, 644);
            this.pbSetting.Name = "pbSetting";
            this.pbSetting.Size = new System.Drawing.Size(20, 20);
            this.pbSetting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbSetting.TabIndex = 6;
            this.pbSetting.TabStop = false;
            this.pbSetting.Click += new System.EventHandler(this.pbSetting_Click);
            this.pbSetting.MouseLeave += new System.EventHandler(this.pbSetting_MouseLeave);
            this.pbSetting.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbSetting_MouseMove);
            // 
            // pbPlay
            // 
            this.pbPlay.Image = global::MusicApp.Properties.Resources.play;
            this.pbPlay.Location = new System.Drawing.Point(393, 639);
            this.pbPlay.Name = "pbPlay";
            this.pbPlay.Size = new System.Drawing.Size(19, 23);
            this.pbPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlay.TabIndex = 7;
            this.pbPlay.TabStop = false;
            this.pbPlay.Click += new System.EventHandler(this.pbPlay_Click);
            // 
            // pbNext
            // 
            this.pbNext.Image = global::MusicApp.Properties.Resources.right_arrow;
            this.pbNext.Location = new System.Drawing.Point(427, 639);
            this.pbNext.Name = "pbNext";
            this.pbNext.Size = new System.Drawing.Size(19, 23);
            this.pbNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNext.TabIndex = 8;
            this.pbNext.TabStop = false;
            this.pbNext.Click += new System.EventHandler(this.pbNext_Click);
            this.pbNext.MouseLeave += new System.EventHandler(this.pbNext_MouseLeave);
            this.pbNext.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbNext_MouseMove);
            // 
            // pbStop
            // 
            this.pbStop.Image = ((System.Drawing.Image)(resources.GetObject("pbStop.Image")));
            this.pbStop.Location = new System.Drawing.Point(459, 639);
            this.pbStop.Name = "pbStop";
            this.pbStop.Size = new System.Drawing.Size(25, 28);
            this.pbStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbStop.TabIndex = 9;
            this.pbStop.TabStop = false;
            this.pbStop.Click += new System.EventHandler(this.pbStop_Click);
            this.pbStop.MouseLeave += new System.EventHandler(this.pbStop_MouseLeave);
            this.pbStop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbStop_MouseMove);
            // 
            // pbPrevious
            // 
            this.pbPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbPrevious.Image = global::MusicApp.Properties.Resources.arrow_left;
            this.pbPrevious.Location = new System.Drawing.Point(359, 639);
            this.pbPrevious.Name = "pbPrevious";
            this.pbPrevious.Size = new System.Drawing.Size(19, 23);
            this.pbPrevious.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPrevious.TabIndex = 10;
            this.pbPrevious.TabStop = false;
            this.pbPrevious.Click += new System.EventHandler(this.pbPrevious_Click);
            // 
            // pbMute
            // 
            this.pbMute.Image = ((System.Drawing.Image)(resources.GetObject("pbMute.Image")));
            this.pbMute.Location = new System.Drawing.Point(705, 639);
            this.pbMute.Name = "pbMute";
            this.pbMute.Size = new System.Drawing.Size(21, 28);
            this.pbMute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbMute.TabIndex = 11;
            this.pbMute.TabStop = false;
            this.pbMute.Click += new System.EventHandler(this.pbMute_Click);
            this.pbMute.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbMute_MouseDown);
            this.pbMute.MouseLeave += new System.EventHandler(this.pbMute_MouseLeave);
            this.pbMute.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbMute_MouseMove);
            // 
            // pbClosePlalist
            // 
            this.pbClosePlalist.Image = ((System.Drawing.Image)(resources.GetObject("pbClosePlalist.Image")));
            this.pbClosePlalist.Location = new System.Drawing.Point(1103, 5);
            this.pbClosePlalist.Name = "pbClosePlalist";
            this.pbClosePlalist.Size = new System.Drawing.Size(23, 15);
            this.pbClosePlalist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbClosePlalist.TabIndex = 12;
            this.pbClosePlalist.TabStop = false;
            this.pbClosePlalist.Click += new System.EventHandler(this.pbClosePlalist_Click);
            this.pbClosePlalist.MouseLeave += new System.EventHandler(this.pbClosePlalist_MouseLeave);
            this.pbClosePlalist.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbClosePlalist_MouseMove);
            // 
            // pbVolume
            // 
            this.pbVolume.Image = ((System.Drawing.Image)(resources.GetObject("pbVolume.Image")));
            this.pbVolume.Location = new System.Drawing.Point(730, 653);
            this.pbVolume.Name = "pbVolume";
            this.pbVolume.Size = new System.Drawing.Size(42, 4);
            this.pbVolume.TabIndex = 13;
            this.pbVolume.TabStop = false;
            // 
            // pbNode
            // 
            this.pbNode.Image = ((System.Drawing.Image)(resources.GetObject("pbNode.Image")));
            this.pbNode.Location = new System.Drawing.Point(772, 650);
            this.pbNode.Name = "pbNode";
            this.pbNode.Size = new System.Drawing.Size(10, 10);
            this.pbNode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbNode.TabIndex = 14;
            this.pbNode.TabStop = false;
            this.pbNode.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbNode_MouseDown);
            this.pbNode.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbNode_MouseMove);
            this.pbNode.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbNode_MouseUp);
            // 
            // lbHienTai
            // 
            this.lbHienTai.AutoSize = true;
            this.lbHienTai.BackColor = System.Drawing.Color.Transparent;
            this.lbHienTai.Location = new System.Drawing.Point(134, 648);
            this.lbHienTai.Name = "lbHienTai";
            this.lbHienTai.Size = new System.Drawing.Size(34, 13);
            this.lbHienTai.TabIndex = 15;
            this.lbHienTai.Text = "00:00";
            // 
            // lbTGConLai
            // 
            this.lbTGConLai.AutoSize = true;
            this.lbTGConLai.BackColor = System.Drawing.Color.Transparent;
            this.lbTGConLai.Location = new System.Drawing.Point(93, 648);
            this.lbTGConLai.Name = "lbTGConLai";
            this.lbTGConLai.Size = new System.Drawing.Size(34, 13);
            this.lbTGConLai.TabIndex = 16;
            this.lbTGConLai.Text = "00:00";
            // 
            // pbManHinh
            // 
            this.pbManHinh.Location = new System.Drawing.Point(7, 24);
            this.pbManHinh.Name = "pbManHinh";
            this.pbManHinh.Size = new System.Drawing.Size(798, 595);
            this.pbManHinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbManHinh.TabIndex = 17;
            this.pbManHinh.TabStop = false;
            this.pbManHinh.Paint += new System.Windows.Forms.PaintEventHandler(this.pbManHinh_Paint);
            // 
            // media
            // 
            this.media.Enabled = true;
            this.media.Location = new System.Drawing.Point(321, 195);
            this.media.Name = "media";
            this.media.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("media.OcxState")));
            this.media.Size = new System.Drawing.Size(184, 48);
            this.media.TabIndex = 18;
            // 
            // lbTimKiem
            // 
            this.lbTimKiem.FormattingEnabled = true;
            this.lbTimKiem.Location = new System.Drawing.Point(825, 59);
            this.lbTimKiem.Name = "lbTimKiem";
            this.lbTimKiem.Size = new System.Drawing.Size(231, 17);
            this.lbTimKiem.TabIndex = 20;
            this.lbTimKiem.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbTimKiem_MouseClick);
            // 
            // tmChinh
            // 
            this.tmChinh.Interval = 10;
            this.tmChinh.Tick += new System.EventHandler(this.tmChinh_Tick);
            // 
            // tmPhu
            // 
            this.tmPhu.Interval = 40;
            this.tmPhu.Tick += new System.EventHandler(this.tmPhu_Tick);
            // 
            // lbChinhTocDo
            // 
            this.lbChinhTocDo.AutoSize = true;
            this.lbChinhTocDo.BackColor = System.Drawing.Color.Transparent;
            this.lbChinhTocDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChinhTocDo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(151)))), ((int)(((byte)(187)))));
            this.lbChinhTocDo.Location = new System.Drawing.Point(459, 71);
            this.lbChinhTocDo.Name = "lbChinhTocDo";
            this.lbChinhTocDo.Size = new System.Drawing.Size(0, 13);
            this.lbChinhTocDo.TabIndex = 21;
            this.lbChinhTocDo.Visible = false;
            // 
            // pbOpenFiles
            // 
            this.pbOpenFiles.Image = ((System.Drawing.Image)(resources.GetObject("pbOpenFiles.Image")));
            this.pbOpenFiles.Location = new System.Drawing.Point(328, 639);
            this.pbOpenFiles.Name = "pbOpenFiles";
            this.pbOpenFiles.Size = new System.Drawing.Size(25, 28);
            this.pbOpenFiles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbOpenFiles.TabIndex = 23;
            this.pbOpenFiles.TabStop = false;
            this.pbOpenFiles.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pbOpenFiles.MouseLeave += new System.EventHandler(this.pbOpenFiles_MouseLeave);
            this.pbOpenFiles.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbOpenFiles_MouseMove);
            // 
            // tmThoiGian
            // 
            this.tmThoiGian.Interval = 1000;
            this.tmThoiGian.Tick += new System.EventHandler(this.tmThoiGian_Tick);
            // 
            // pbThem
            // 
            this.pbThem.Image = ((System.Drawing.Image)(resources.GetObject("pbThem.Image")));
            this.pbThem.Location = new System.Drawing.Point(1067, 32);
            this.pbThem.Name = "pbThem";
            this.pbThem.Size = new System.Drawing.Size(19, 21);
            this.pbThem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbThem.TabIndex = 25;
            this.pbThem.TabStop = false;
            this.pbThem.Click += new System.EventHandler(this.pbThem_Click);
            this.pbThem.MouseLeave += new System.EventHandler(this.pbThem_MouseLeave);
            this.pbThem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbThem_MouseMove);
            // 
            // pbAdd
            // 
            this.pbAdd.Image = ((System.Drawing.Image)(resources.GetObject("pbAdd.Image")));
            this.pbAdd.Location = new System.Drawing.Point(825, 641);
            this.pbAdd.Name = "pbAdd";
            this.pbAdd.Size = new System.Drawing.Size(21, 29);
            this.pbAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbAdd.TabIndex = 26;
            this.pbAdd.TabStop = false;
            this.pbAdd.Click += new System.EventHandler(this.pbAdd_Click);
            this.pbAdd.MouseLeave += new System.EventHandler(this.pbAdd_MouseLeave);
            this.pbAdd.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbAdd_MouseMove);
            // 
            // pbRemove
            // 
            this.pbRemove.Image = ((System.Drawing.Image)(resources.GetObject("pbRemove.Image")));
            this.pbRemove.Location = new System.Drawing.Point(855, 641);
            this.pbRemove.Name = "pbRemove";
            this.pbRemove.Size = new System.Drawing.Size(21, 29);
            this.pbRemove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbRemove.TabIndex = 27;
            this.pbRemove.TabStop = false;
            this.pbRemove.Click += new System.EventHandler(this.pbRemove_Click);
            this.pbRemove.MouseLeave += new System.EventHandler(this.pbRemove_MouseLeave);
            this.pbRemove.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbRemove_MouseMove);
            // 
            // pbDown
            // 
            this.pbDown.Image = ((System.Drawing.Image)(resources.GetObject("pbDown.Image")));
            this.pbDown.Location = new System.Drawing.Point(1094, 641);
            this.pbDown.Name = "pbDown";
            this.pbDown.Size = new System.Drawing.Size(21, 29);
            this.pbDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbDown.TabIndex = 28;
            this.pbDown.TabStop = false;
            this.pbDown.Click += new System.EventHandler(this.pbDown_Click);
            this.pbDown.MouseLeave += new System.EventHandler(this.pbDown_MouseLeave);
            this.pbDown.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbDown_MouseMove);
            // 
            // pbUp
            // 
            this.pbUp.Image = ((System.Drawing.Image)(resources.GetObject("pbUp.Image")));
            this.pbUp.Location = new System.Drawing.Point(1064, 641);
            this.pbUp.Name = "pbUp";
            this.pbUp.Size = new System.Drawing.Size(21, 29);
            this.pbUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbUp.TabIndex = 29;
            this.pbUp.TabStop = false;
            this.pbUp.Click += new System.EventHandler(this.pbUp_Click);
            this.pbUp.MouseLeave += new System.EventHandler(this.pbUp_MouseLeave);
            this.pbUp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbUp_MouseMove);
            // 
            // pbQuickImport
            // 
            this.pbQuickImport.Image = ((System.Drawing.Image)(resources.GetObject("pbQuickImport.Image")));
            this.pbQuickImport.Location = new System.Drawing.Point(1098, 34);
            this.pbQuickImport.Name = "pbQuickImport";
            this.pbQuickImport.Size = new System.Drawing.Size(21, 21);
            this.pbQuickImport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbQuickImport.TabIndex = 30;
            this.pbQuickImport.TabStop = false;
            this.pbQuickImport.Click += new System.EventHandler(this.pbQuickImport_Click);
            this.pbQuickImport.MouseLeave += new System.EventHandler(this.pbQuickImport_MouseLeave);
            this.pbQuickImport.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbQuickImport_MouseMove);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picb_playdemo
            // 
            this.picb_playdemo.Image = global::MusicApp.Properties.Resources.play;
            this.picb_playdemo.Location = new System.Drawing.Point(550, 644);
            this.picb_playdemo.Name = "picb_playdemo";
            this.picb_playdemo.Size = new System.Drawing.Size(19, 23);
            this.picb_playdemo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picb_playdemo.TabIndex = 31;
            this.picb_playdemo.TabStop = false;
            this.picb_playdemo.Click += new System.EventHandler(this.picb_playdemo_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1133, 673);
            this.Controls.Add(this.picb_playdemo);
            this.Controls.Add(this.pbQuickImport);
            this.Controls.Add(this.pbUp);
            this.Controls.Add(this.pbDown);
            this.Controls.Add(this.pbRemove);
            this.Controls.Add(this.pbAdd);
            this.Controls.Add(this.pbThem);
            this.Controls.Add(this.pbOpenFiles);
            this.Controls.Add(this.lbChinhTocDo);
            this.Controls.Add(this.lbTimKiem);
            this.Controls.Add(this.media);
            this.Controls.Add(this.pbManHinh);
            this.Controls.Add(this.lbTGConLai);
            this.Controls.Add(this.lbHienTai);
            this.Controls.Add(this.pbNode);
            this.Controls.Add(this.pbVolume);
            this.Controls.Add(this.pbClosePlalist);
            this.Controls.Add(this.pbMute);
            this.Controls.Add(this.pbPrevious);
            this.Controls.Add(this.pbStop);
            this.Controls.Add(this.pbNext);
            this.Controls.Add(this.pbPlay);
            this.Controls.Add(this.pbSetting);
            this.Controls.Add(this.pbClose);
            this.Controls.Add(this.pbStatus2);
            this.Controls.Add(this.pbStatus1);
            this.Controls.Add(this.pbPlaylist);
            this.Controls.Add(this.lbPlaylist);
            this.Controls.Add(this.txtThemBH);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.frmMain_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.frmMain_DragEnter);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlaylist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatus1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatus2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSetting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrevious)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClosePlalist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbManHinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.media)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOpenFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbThem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuickImport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_playdemo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtThemBH;
        private System.Windows.Forms.ListBox lbPlaylist;
        private System.Windows.Forms.PictureBox pbPlaylist;
        private System.Windows.Forms.Timer tmPlaylist;
        private System.Windows.Forms.PictureBox pbStatus1;
        private System.Windows.Forms.PictureBox pbStatus2;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.PictureBox pbSetting;
        private System.Windows.Forms.PictureBox pbPlay;
        private System.Windows.Forms.PictureBox pbNext;
        private System.Windows.Forms.PictureBox pbStop;
        private System.Windows.Forms.PictureBox pbPrevious;
        private System.Windows.Forms.PictureBox pbMute;
        private System.Windows.Forms.PictureBox pbClosePlalist;
        private System.Windows.Forms.PictureBox pbVolume;
        private System.Windows.Forms.PictureBox pbNode;
        private System.Windows.Forms.Label lbHienTai;
        private System.Windows.Forms.Label lbTGConLai;
        private System.Windows.Forms.PictureBox pbManHinh;
        private AxWMPLib.AxWindowsMediaPlayer media;
        private System.Windows.Forms.ListBox lbTimKiem;
        private System.Windows.Forms.Timer tmChinh;
        private System.Windows.Forms.Timer tmPhu;
        private System.Windows.Forms.Label lbChinhTocDo;
        private System.Windows.Forms.PictureBox pbOpenFiles;
        private System.Windows.Forms.Timer tmThoiGian;
        private System.Windows.Forms.PictureBox pbThem;
        private System.Windows.Forms.PictureBox pbAdd;
        private System.Windows.Forms.PictureBox pbRemove;
        private System.Windows.Forms.PictureBox pbDown;
        private System.Windows.Forms.PictureBox pbUp;
        private System.Windows.Forms.PictureBox pbQuickImport;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picb_playdemo;
    }
}

