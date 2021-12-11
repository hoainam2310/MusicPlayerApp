using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Collections;
using System.Drawing.Drawing2D;
using System.IO;
using MusicApp;


namespace MusicPlayer
{

    public partial class karaoke : Form
    {
        public karaoke()
        {
            InitializeComponent();
        }
        float percent = 0;
        int i = 0;
        double Time = 0;
        int ViTriCau = -1;
        string strDuongDanXml = "";
        string[] arrCauHat;
        string[] arrThoiGianCauHat;
        string[][] BaiHat;
        string[][] ThoiGian;
        string TenBH = "";
        bool DuocVeChu = false;
        int ViTriBH = 0;
        private void pbPlaylist_MouseLeave(object sender, EventArgs e)
        {
            pbPlaylist.Image = Image.FromFile("../../Image\\playlist.jpg");
        }
        bool MoPlaylist = true;
        string[] arrHinhNen;
       
        private void frmMain_Load(object sender, EventArgs e)
        {
            tmChinh.Interval = 20;
            tmPhu.Interval = 200;
            media.Visible = false;  
            arrHinhNen = System.IO.Directory.GetFiles(@"../../Wallpaper\", "*.jpg");
            this.BackgroundImage = Image.FromFile("../../Image\\bg.jpg");
            pbStatus1.Location = new Point(6, 630);
            pbStatus2.Location = new Point(6, 630);
            this.Width = 812;
            pbStatus1.Height = 3;
            pbStatus2.Height = 3;
            pbStatus2.BringToFront();
            this.AllowDrop = true;
            lbTimKiem.Visible = false;
            pbManHinh.Image = Image.FromFile(arrHinhNen[0]);
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.pbPlaylist, "Playlist");
            ToolTip1.SetToolTip(this.pbPlay, "Play/Pause");
            ToolTip1.SetToolTip(this.pbStop, "Stop");
            ToolTip1.SetToolTip(this.pbNext, "Next");
            ToolTip1.SetToolTip(this.pbPrevious, "Previous");
            ToolTip1.SetToolTip(this.pbClose, "Close");
            ToolTip1.SetToolTip(this.pbSetting, "Settings");
            ToolTip1.SetToolTip(this.pbOpenFiles, "Open Files");
            ToolTip1.SetToolTip(this.pbThem, "Add Song");
            ToolTip1.SetToolTip(this.pbUp, "Move Up");
            ToolTip1.SetToolTip(this.pbDown, "Move Down");
            ToolTip1.SetToolTip(this.pbAdd, "Add");
            ToolTip1.SetToolTip(this.pbRemove, "Delete");
            ToolTip1.SetToolTip(this.pbMute, "Mute");
            ToolTip1.SetToolTip(this.pbQuickImport, "Quick Imports");
        }

        public string TraVeSoGiay(string str)
        {
            string[] tam = str.Split(':');
            double s = double.Parse(tam[0]) * 60 + double.Parse(tam[1]) + double.Parse(tam[2]) / 1000;
            return s.ToString();
        }

        public void XuLyXML(string DuongDanXml, ref string strLoi, ref string strThoiGian)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(DuongDanXml); // suppose that myXmlString contains "<Names>...</Names>"
            XmlNodeList xnList = xml.SelectNodes("data/param/i");
            XmlNodeList xnListSoCau = xml.SelectNodes("data/param");
            int dem = 0;
            //int DemCau = 1;
            foreach (XmlNode xn in xnListSoCau)
            {
                strLoi += xn.InnerText.Trim();
                foreach (XmlNode i in xn.ChildNodes)
                {
                    if (dem < xn.ChildNodes.Count - 1)
                        strThoiGian += TraVeSoGiay(i.Attributes["va"].Value) + ",";
                    else
                    {          
                        strThoiGian += (TraVeSoGiay(i.Attributes["va"].Value) + "/");
                        strLoi += "/";
                        dem = 0;
                        break;
                    }
                    dem++;
                }
            }
            strThoiGian = strThoiGian.Substring(0, strThoiGian.Length - 1);
            strLoi = strLoi.Substring(0, strLoi.Length - 1);
        }

        private void tmPlaylist_Tick(object sender, EventArgs e)
        {
            if (MoPlaylist == false)
            {
                if (this.Width < 1131)
                    this.Width += 40;
                else
                {
                    tmPlaylist.Stop();
                    this.Width = 1131;
                }
            }
            else
            {
                if (this.Width > 812)
                    this.Width -= 40;
                else
                {
                    tmPlaylist.Stop();
                    this.Width = 812;
                }
                    
            }
        }

        public void pbPlaylist_Click(object sender, EventArgs e)
        {
            IsOpenPlaylist = true;
            if (MoPlaylist == false)
                MoPlaylist = true;
            else
                MoPlaylist = false;
            tmPlaylist.Start();
            
        }

        private void pbClose_MouseMove(object sender, MouseEventArgs e)
        {
            pbClose.Image = Image.FromFile("../../Image\\close_move.jpg");
        }

        private void pbClose_MouseLeave(object sender, EventArgs e)
        {
            pbClose.Image = Image.FromFile("../../Image\\close.jpg");
        }

        private void pbSetting_MouseMove(object sender, MouseEventArgs e)
        {
            pbSetting.Image = Image.FromFile("../../Image\\setting_move.jpg");
        }

        private void pbSetting_MouseLeave(object sender, EventArgs e)
        {
            pbSetting.Image = Image.FromFile("../../Image\\setting.jpg");
        }


        //private void pbPrevious_MouseMove(object sender, MouseEventArgs e)
        //{
        //    pbPrevious.Image = Image.FromFile("../../Image\\previous_move.jpg");
        //}

        //private void pbPrevious_MouseLeave(object sender, EventArgs e)
        //{
        //    pbPrevious.Image = Image.FromFile("../../Image\\previous.jpg");
        //}

        //private void pbPlay_MouseMove(object sender, MouseEventArgs e)
        //{
        //    if (LaPlay == true)
        //        pbPlay.Image = Image.FromFile("../../Image\\play_move.jpg");
        //    else
        //        pbPlay.Image = Image.FromFile("../../Image\\pause_move.jpg");

        //}

        //private void pbPlay_MouseLeave(object sender, EventArgs e)
        //{
        //    if(LaPlay==true)
        //        pbPlay.Image = Image.FromFile("../../Image\\play.jpg");
        //    else
        //        pbPlay.Image = Image.FromFile("../../Image\\pause.jpg");
        //}

        private void pbNext_MouseMove(object sender, MouseEventArgs e)
        {
            pbNext.Image = Image.FromFile("../../Image\\next_move.jpg");
        }

        private void pbNext_MouseLeave(object sender, EventArgs e)
        {
            pbNext.Image = Image.FromFile("../../Image\\next.jpg");
        }

        private void pbStop_MouseMove(object sender, MouseEventArgs e)
        {
            pbStop.Image = Image.FromFile("../../Image\\stop_move.jpg");
        }

        private void pbStop_MouseLeave(object sender, EventArgs e)
        {
            pbStop.Image = Image.FromFile("../../Image\\stop.jpg");
        }

        private void pbMute_MouseMove(object sender, MouseEventArgs e)
        {
            if(LaTatTieng==true)
                pbMute.Image = Image.FromFile("../../Image\\mute_on_move.jpg");
            else
                pbMute.Image = Image.FromFile("../../Image\\mute_off.jpg");
            
        }

        private void pbMute_MouseLeave(object sender, EventArgs e)
        {
            if (LaTatTieng == true)
                pbMute.Image = Image.FromFile("../../Image\\mute_on.jpg");
            else
                pbMute.Image = Image.FromFile("../../Image\\mute_off.jpg");
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbClosePlalist_MouseMove(object sender, MouseEventArgs e)
        {
            pbClosePlalist.Image = Image.FromFile("../../Image\\close_move.jpg");
        }

        private void pbClosePlalist_MouseLeave(object sender, EventArgs e)
        {
            pbClosePlalist.Image = Image.FromFile("../../Image\\close.jpg");
        }

        private void pbClosePlalist_Click(object sender, EventArgs e)
        {
            pbPlaylist_Click(sender, e);
        }

        private void pbSetting_Click(object sender, EventArgs e)
        {
            //frmQuanLy f = new frmQuanLy();
            //f.ShowDialog();
        }

        private void pbPlaylist_MouseMove(object sender, MouseEventArgs e)
        {
            pbPlaylist.Image = Image.FromFile("../../Image\\playlist_move.jpg");
           
        }
        Point pp = new Point();
        bool DuocDiChuyen = false;
     
        private void frmMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                DuocDiChuyen=true;
            {
                if (e.Y < 28)
                    pp = new Point(e.X, e.Y);
                else
                    DuocDiChuyen = false;
            }
        }

        private void frmMain_MouseUp(object sender, MouseEventArgs e)
        {
            DuocDiChuyen = false;
        }
        Point ppp;
        private void frmMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (DuocDiChuyen == true)
            {
                ppp = new Point();
                ppp = this.PointToScreen(new Point(e.X, e.Y));
                ppp.Offset(-pp.X, -pp.Y);
                this.Location = ppp;
            } 
        }
        bool LaPlay = true;
        String strLoi = "";
        string strThoiGian = "";
        ArrayList arlTimingTungCau = new ArrayList();
        private void Reset()
        {
          
            media.Ctlcontrols.currentPosition = 0;
            media.Ctlcontrols.stop();
            tmChinh.Stop();
            tmPhu.Stop();
            DuocVeChu = false;
            NhacDaChoi = false;
            strLoi = "";
            strThoiGian = "";
            TocDo=0;
            Time = 0;
            percent = 0;
            t = 0;
            tt = 0;
            DuocVeTieuDe = true;
            k = false;     
        }
     
        private static bool FileExists(string sPathName)   // Ham kiem tra file co ton tai ko
        {
            try
            {
                return (System.IO.File.Exists(sPathName)); //Exception for folder
            }
            catch (Exception)
            {
                return (false); //Error occured, return False
            }
        }

        bool NhacDaChoi = false;
        bool IsOpenPlaylist = false;
        private void pbPlay_Click(object sender, EventArgs e)
        {
            if (lbPlaylist.Items.Count == 0)
            {
                MessageBox.Show("Chưa có bài hát trong Playlist","Music Player");
                if (IsOpenPlaylist==false)
                {
                    pbPlaylist_Click(sender, e);
                    IsOpenPlaylist = true;
                }               
            }
            else// Playlist da co bai hat
            {

                if (LaPlay == true)
                {
                    LaPlay = false;
                    if (NhacDaChoi)
                    {
                        media.Ctlcontrols.play();
                        tmChinh.Start();
                        tmThoiGian.Start();


                    }
                    else
                    {
                        if (lbPlaylist.SelectedIndex == -1)
                            ViTriBH = lbPlaylist.SelectedIndex = 0;
                        TenBH = data.CatChuoi(lbPlaylist.SelectedItem.ToString(), ".  ", 1);
                        strDuongDanMp3 = (string)ht[TenBH];//Lay duong dan file cua selected item playlist
                        //MessageBox.Show(strDuongDan);  
                        //MessageBox.Show(strDuongDanMp3);
                        //MessageBox.Show(FileExists(strDuongDanMp3).ToString());
                        if (FileExists(strDuongDanMp3))
                        {
                            strDuongDanXml = strDuongDanMp3.Substring(0, strDuongDanMp3.Length - 4) + ".xml";
                            if (FileExists(strDuongDanXml))
                            {
                                XuLyXML(strDuongDanXml, ref strLoi, ref strThoiGian);
                                arrCauHat = strLoi.Split('/');
                                BaiHat = new string[arrCauHat.Length][];
                                for (int i = 0; i < arrCauHat.Length; i++)
                                    BaiHat[i] = arrCauHat[i].Split(' ');

                                arrThoiGianCauHat = strThoiGian.Split('/');
                                ThoiGian = new string[arrThoiGianCauHat.Length][];
                                for (int i = 0; i < arrThoiGianCauHat.Length; i++)
                                    ThoiGian[i] = arrThoiGianCauHat[i].Split(',');
                                DuocVeChu = true;
                                //MessageBox.Show(strDuongDanXml);
                            }
                            else // Neu ko co *.xml
                            {
                                //MessageBox.Show("ko co xml");
                                DuocVeChu = false;
                            }
                            NhacDaChoi = true;
                            media.URL = @strDuongDanMp3;
                           

                            media.Ctlcontrols.play();
                            k = true;
                            //VeTieuDe = true;
                            pbManHinh.Invalidate();
                            tmChinh.Start();
                            tmThoiGian.Start();


                        }
                        else //ko tim thay *.mp3
                        {
                            MessageBox.Show("Không tìm thấy file","Music Player");
                        }
                    }
                }

                else //Dang o trang thai pause
                {
                    tmChinh.Stop();
                    media.Ctlcontrols.pause();
                    tmPhu.Stop();
                    tmThoiGian.Stop();
                    LaPlay = true;
                }
            }
        }
        bool LaTatTieng = true;
        int Vol = 60;
        private void pbMute_Click(object sender, EventArgs e)
        {
            if (LaTatTieng == false)
            {
                LaTatTieng = true;

                media.settings.mute = false;
                pbNode.Location = new Point(Convert.ToInt32((61 * Vol) / 100) + 729, 650);
                pbVolume.Width = Convert.ToInt32((61 / (float)100) * Vol);
            }

            else
            {
                LaTatTieng = false;
                media.settings.mute = true;
                pbVolume.Width = 0;
                pbNode.Location = new Point(729, 650);
            }                   
        }

        private void txtThemBH_MouseClick(object sender, MouseEventArgs e)
        {
            if(txtThemBH.Text=="Nhập tên bài hát / kéo thả file *.mp3 vào")
                txtThemBH.Text = "";
        }
        DataTable dt= new DataTable();
        Cl_LayDuLieu data = new Cl_LayDuLieu();
        private void txtThemBH_TextChanged(object sender, EventArgs e)
        {
            lbTimKiem.Items.Clear();
            dt.Clear();
            if (txtThemBH.Text == "")
                lbTimKiem.Visible = false;
            else
            {
                dt = data.LayDuLieu("[Sp_TimKiem] N'" + txtThemBH.Text + "'," + data.LaChuCoDau(txtThemBH.Text));
                //MessageBox.Show(dt.Rows.Count.ToString());
                if (dt.Rows.Count>0)
                    for (int i=0;i<dt.Rows.Count;i++)
                       lbTimKiem.Items.Add(dt.Rows[i]["TenBH"].ToString());
                //MessageBox.Show(lbTimKiem.Items.Count.ToString());
                if (lbTimKiem.Items.Count==0)
                    lbTimKiem.Visible=false;
                else
                {                  
                    lbTimKiem.Height = (5 + lbTimKiem.Items.Count) * 5;                  
                    lbTimKiem.Visible=true;
                }
            }
        }
        private void SapXepPlaylist()
        {
            ViTriDangChoi = lbPlaylist.SelectedIndex;
            ArrayList arlSapXep= new ArrayList();
            for (int i = 0; i < lbPlaylist.Items.Count; i++)
                arlSapXep.Add(data.CatChuoi(lbPlaylist.Items[i].ToString(),".  ",1));
            lbPlaylist.Items.Clear();
            for (int i = 0; i < arlSapXep.Count; i++)               
                lbPlaylist.Items.Add(i+1 +".  "+arlSapXep[i]);
            lbPlaylist.SelectedIndex = ViTriDangChoi;
        }
        Hashtable ht = new Hashtable();
        private void frmMain_DragDrop(object sender, DragEventArgs e)
        {

            // Extract the data from the DataObject-Container into a string list
        string[] FileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);
 
        // Do something with the data...
             // For example add all files into a simple label control:
        string str="";
        foreach (string File in FileList)
             if (File.Substring(File.Length - 4, 4) == ".mp3")
             {   
                str=File.Substring(File.LastIndexOf('\\') + 1);
                if (ht.ContainsKey(str) == false)
                {
                    ht.Add(str, File);
                    this.lbPlaylist.Items.Add("0.  " + str);
                }
            //MessageBox.Show("Bài hát đã có trong list nhạc");
             }
             else
                Loi = true;
            if (Loi)
                MessageBox.Show("Chương trình chỉ chơi file *.mp3","Music Player");
            SapXepPlaylist();
            this.pbPlay.Image = Image.FromFile("../../Image\\play_move.jpg");
        }
        bool Loi = false;
        private void frmMain_DragEnter(object sender, DragEventArgs e)
        {
             if (e.Data.GetDataPresent(DataFormats.FileDrop))
        e.Effect = DragDropEffects.Copy; // Okay
    else
        e.Effect = DragDropEffects.None; // Unknown data, ignore it
        }

        private void tmChinh_Tick(object sender, EventArgs e)
        {
            Time = Convert.ToDouble((media.Ctlcontrols.currentPosition));
            if (Time < 30 && k==true)
            {
                DuocVeTieuDe = true; //Ve ten bai hat
            }
           
            if (media.currentMedia.duration == 0)
                pbStatus2.Width = 0;
            else
            {
                pbStatus2.Width = Convert.ToInt32((Time / media.currentMedia.duration) * 800); // 800 la chieu dai cua processbar
                if (pbStatus2.Width >= 800)
                {
                    pbNext_Click(sender, e);
                    pbNext_MouseLeave(sender, e);
                }
                if (DuocVeChu)
                {
                    ViTriCau = TraVeViTriCau();
                    int i = ViTriCau;
                    if (i == -1)
                        i = 0;
                    if (Time >= Convert.ToDouble(ThoiGian[i][0]) + TocDo)
                        tmPhu.Start();
                    else
                        tmPhu.Stop();
                }
            }
               
        }
        private int TraVeViTriCau()
        {
            
            int vt = -1;
            for ( i = 0; i < BaiHat.Length; i++)
            {
                if (Time <= Convert.ToDouble(ThoiGian[i][0]) + TocDo)
                    return vt;
                vt++;
            }
            return vt;
        }

        public int TraVeSoKyTu()
        {
            //ViTriCau = TraVeViTriCau();
            int vt = -1;
            if (ViTriCau != -1)
            {
                double s = double.Parse(ThoiGian[ViTriCau][0]) - 0.3;
                double a, b;

                for (int i = 0; i < BaiHat[ViTriCau].Length; i++)
                {
                    for (int j = 0; j < BaiHat[ViTriCau][i].Length; j++)
                    {
                        vt++;
                        if (j == BaiHat[ViTriCau][i].Length - 1)
                            vt++;
                        if (i == 0)
                            a = 0.3;
                        else
                            a = double.Parse(ThoiGian[ViTriCau][i]) - double.Parse(ThoiGian[ViTriCau][i-1]);
                        b = (double)BaiHat[ViTriCau][i].Length;        
                        s += a / b;
                        if (s >= (Time -TocDo))////////////Chinh toc do
                            return vt;
                    }
                }
            }

            return vt;
        }
        private void tmPhu_Tick(object sender, EventArgs e)
        {
            
            if (DuocVeChu == true)
            {
            int vtkt = TraVeSoKyTu();
            if (vtkt == -1)
                percent = 0;
            else
                percent = (vtkt / (float)(arrCauHat[ViTriCau].Length) )* 100;
            pbManHinh.Invalidate();
            }
           
        }
        private void VeChu(Graphics g, string ChuoiCauHat,int x, int y, int CaoDo2)//x,y la toa do ve chu
        {
            var path = new GraphicsPath();
            path.AddString(ChuoiCauHat, new FontFamily("Times New Roman"), (int)FontStyle.Regular, 25, new Point(x, y), StringFormat.GenericDefault);
            g.FillPath(new SolidBrush(Color.WhiteSmoke), path);// Hien loi hat
        
            Region r = new Region(path);
            RectangleF rect = r.GetBounds(g);
            if (i % 2 == 0)
                CaoDo2 = 230;
            else
                CaoDo2 = 300;
            RectangleF intersectRect = new RectangleF(rect.X, CaoDo2, rect.Width * percent / 100, rect.Height + 20); //
            r.Intersect(intersectRect);
            g.FillRegion(Brushes.Blue, r); //To mau
            g.DrawPath(new Pen(Color.DarkGray), path); //vien trang
        }
        bool DuocVeTieuDe = true;
        bool k = false;
        private void pbManHinh_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            if (k)
            {
                if (DuocVeTieuDe)
                     VeChu(g, TenBH.Substring(0,TenBH.Length-4), 20, 100, 230);
                else
                     VeChu(g, "\t\t\t\t\t\t\t\t\t\t", 20, 100, 230);
                k = false;
            }
            
            if (DuocVeChu == true)
            {      
                i = TraVeViTriCau();
                if (i == -1)
                    i = 0;
                if (i % 2 == 0)
                {
                    VeChu(g, (arrCauHat[i]),20, 230, 230);

                    if (i < arrCauHat.Length - 1)
                        VeChu(g, (arrCauHat[i + 1]),20, 300, 230);
                }
                else
                {
                    VeChu(g, (arrCauHat[i]),20, 300, 230);
                    if (i < arrCauHat.Length - 1)
                        VeChu(g, (arrCauHat[i + 1]),20, 230, 230);
                }
            }
            else
            {
                VeChu(g, "\t\t\t\t\t\t\t\t\t\t",20, 300, 230);
                VeChu(g, "\t\t\t\t\t\t\t\t\t\t",20, 230, 230);
            }
        }
        string strDuongDanMp3 = "";
        public void pbStop_Click(object sender, EventArgs e)
        {
            Reset();
            if (LaPlay == false)
            {
                pbPlay_Click(sender, e);
                //pbPlay_MouseLeave(sender, e);
            }
            pbManHinh.Invalidate();
        }
        double TocDo = 0;
        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            ttt = 0;
            if (e.KeyCode == Keys.N && e.Modifiers == Keys.Alt)
            {
                TocDo += 0.1;
                lbChinhTocDo.Visible = true;
                timer1.Start();
                
            }
            if (e.KeyCode == Keys.P && e.Modifiers == Keys.Alt)
            {
                TocDo -= 0.1;
                lbChinhTocDo.Visible = true;
                timer1.Start();
            }
            lbChinhTocDo.Text = TocDo.ToString();
           
        }
    
        private void txtThemBH_KeyDown(object sender, KeyEventArgs e)
        {
            //ViTriDangChoi = lbPlaylist.SelectedIndex;
            if (e.KeyCode == Keys.Enter)
            {                
                for (int i = 0; i < lbTimKiem.Items.Count;i++ )
                    if (ht.ContainsKey(lbTimKiem.Items[i] + ".mp3") == false)
                    {
                        ht.Add(lbTimKiem.Items[i] + ".mp3", dt.Rows[i]["URL"]);
                        //MessageBox.Show(dt.Rows[i]["URL"].ToString());
                        this.lbPlaylist.Items.Add("0.  " + lbTimKiem.Items[i] + ".mp3");
                       
                    }
            txtThemBH.Text = "";
            lbTimKiem.Visible = false;
            SapXepPlaylist();
            //lbPlaylist.SelectedIndex = ViTriDangChoi;
            }      
        }
        private void lbTimKiem_MouseClick(object sender, MouseEventArgs e)
        {
            txtThemBH.Text = lbTimKiem.SelectedItem.ToString();
            lbTimKiem.Visible = false;
        }
  
        int x = 0;
        int y = 0;
        int x1=0;
        
        private void pbNode_MouseDown(object sender, MouseEventArgs e)
        {
            
            if (e.Button == MouseButtons.Left)
            {
                x = Cursor.Position.X;              
                x1 = pbNode.Location.X;
                y = pbNode.Location.Y;
                pbNode.Image = Image.FromFile("../../Image\\node_click.jpg");
            }    
            
            
        }
        int x2 = 0;
        private void pbNode_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                x2 = x1 + Cursor.Position.X - x;
                if (x2 > 728 && x2 < 795)
                {
                    pbNode.Location = new Point(x2, y);
                    Vol = Convert.ToInt32((pbNode.Location.X - 728) / (float)67 * 100);
                    pbVolume.Width = Convert.ToInt32((67 / (float)100) * Vol);
                    media.settings.volume = Vol;
                    if (Vol > 0)
                        LaTatTieng = true;
                    pbMute_MouseMove(sender, e);
                    pbMute_MouseLeave(sender, e);
                }           
            }
        }

        private void pbNode_MouseUp(object sender, MouseEventArgs e)
        {
            pbNode.Image = Image.FromFile("../../Image\\node.jpg");        
        }

        private void pbMute_MouseDown(object sender, MouseEventArgs e)
        {
            if(LaTatTieng)
                pbMute.Image = Image.FromFile("../../Image\\mute_off.jpg");
            else
                pbMute.Image = Image.FromFile("../../Image\\mute_on.jpg");
        }
   
        
        private void pbStatus2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pbStatus2.Width = e.X;             
            }        
        }
        double CurrentTime = 0;
        private void pbStatus2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.X>=0 && e.X<=800)
            {
                pbStatus2.Width = e.X;
                if (NhacDaChoi)
                {
                    tmThoiGian.Stop();
                    CurrentTime = (pbStatus2.Width * media.currentMedia.duration) / 800;
                    lbTGConLai.Text = string.Format("{0:00}:{1:00}", (media.currentMedia.duration - CurrentTime) / 60, (media.currentMedia.duration - CurrentTime) % 60);
                    lbHienTai.Text = string.Format("{0:00}:{1:00}", CurrentTime / 60, CurrentTime % 60);
                }
   
                //if (NhacDaChoi)
                //    media.Ctlcontrols.currentPosition = (media.currentMedia.duration / 800) * e.X;
            }
        }

        private void pbStatus1_MouseDown(object sender, MouseEventArgs e)
        {
            pbStatus2_MouseDown(sender, e);
        }


        private void pbStatus1_MouseMove(object sender, MouseEventArgs e)
        {
            pbStatus2_MouseMove(sender, e);
        }
        int ViTriDangChoi = -1;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //ViTriDangChoi = lbPlaylist.SelectedIndex;
            OpenFileDialog dlg = new OpenFileDialog();
          
            dlg.Filter = "*mp3 | *.mp3";
            dlg.Multiselect = true; //Chỗ này nè
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                string str = "";
                foreach (string File in dlg.FileNames)
                    if (File.Substring(File.Length - 4, 4) == ".mp3" || File.Substring(File.Length - 4, 4) == ".MP3")
                    {
                        str = File.Substring(File.LastIndexOf('\\') + 1);
                        if (ht.ContainsKey(str) == false)
                        {
                            ht.Add(str, File);
                            this.lbPlaylist.Items.Add("0.  " + str);
                        }
                        //MessageBox.Show("Bài hát đã có trong list nhạc");
                    }
                    else
                        Loi = true;
                if (Loi)
                    MessageBox.Show("Chương trình chỉ chơi file *.mp3","Music Player");
                SapXepPlaylist();
                //lbPlaylist.SelectedIndex = ViTriDangChoi;
            }
        }
        int t = 0;
        int tt = 0;
        private void tmThoiGian_Tick(object sender, EventArgs e)
        {
            t++;
            if (t % 20 == 0)
            {
                tt++;
                if (tt == arrHinhNen.Length)
                    tt = 0;
                pbManHinh.Image = Image.FromFile(arrHinhNen[tt]);
            }
            lbTGConLai.Text = string.Format("{0:00}:{1:00}", (int)(media.currentMedia.duration - Time) / 60, (int)(media.currentMedia.duration - Time) % 60);
            lbHienTai.Text = string.Format("{0:00}:{1:00}", (int)Time / 60, (int)Time % 60);
        }

        private void pbOpenFiles_MouseMove(object sender, MouseEventArgs e)
        {
            pbOpenFiles.Image = Image.FromFile("../../Image\\open_files_move.jpg");
        }

        private void pbOpenFiles_MouseLeave(object sender, EventArgs e)
        {
            pbOpenFiles.Image = Image.FromFile("../../Image\\open_files.jpg");
        }

        private void pbThem_MouseMove(object sender, MouseEventArgs e)
        {
            pbThem.Image = Image.FromFile("../../Image\\them_move.jpg");
        }

        private void pbThem_MouseLeave(object sender, EventArgs e)
        {
            pbThem.Image = Image.FromFile("../../Image\\them.jpg");
        }

        private void pbAdd_MouseMove(object sender, MouseEventArgs e)
        {
            pbAdd.Image = Image.FromFile("../../Image\\add_move.jpg");
        }

        private void pbAdd_MouseLeave(object sender, EventArgs e)
        {
            pbAdd.Image = Image.FromFile("../../Image\\add.jpg");
        }

        private void pbRemove_MouseMove(object sender, MouseEventArgs e)
        {
            pbRemove.Image = Image.FromFile("../../Image\\remove_move.jpg");
        }

        private void pbRemove_MouseLeave(object sender, EventArgs e)
        {
            pbRemove.Image = Image.FromFile("../../Image\\remove.jpg");
        }

        private void pbUp_MouseMove(object sender, MouseEventArgs e)
        {
            pbUp.Image = Image.FromFile("../../Image\\up_move.jpg");
        }

        private void pbUp_MouseLeave(object sender, EventArgs e)
        {
            pbUp.Image = Image.FromFile("../../Image\\up.jpg");
        }

        private void pbDown_MouseMove(object sender, MouseEventArgs e)
        {
            pbDown.Image = Image.FromFile("../../Image\\down_move.jpg");
        }

        private void pbDown_MouseLeave(object sender, EventArgs e)
        {
            pbDown.Image = Image.FromFile("../../Image\\down.jpg");
        }

        private void pbThem_Click(object sender, EventArgs e)
        {
            //ViTriDangChoi = lbPlaylist.SelectedIndex;
            if (txtThemBH.Text == "Nhập tên bài hát / kéo thả file *.mp3 vào")
                txtThemBH.Text = "";
       
            if (ht.ContainsKey(txtThemBH.Text + ".mp3") == false &&txtThemBH.Text!="" )
            {
                dt=data.LayDuLieu("Sp_SelectBaiHat N'" + txtThemBH.Text + "'");
                if (dt.Rows.Count > 0)
                {
                    ht.Add(txtThemBH.Text + ".mp3", dt.Rows[0]["URL"]);
                    //MessageBox.Show(dt.Rows[0]["URL"].ToString());
                    this.lbPlaylist.Items.Add("0.  " + txtThemBH.Text + ".mp3");
                }
                else
                    MessageBox.Show("Không tìm thấy bài hát trong CSDL","Music Player");

            }
            txtThemBH.Text = "";
            lbTimKiem.Visible = false;
            SapXepPlaylist();
            //lbPlaylist.SelectedIndex = ViTriDangChoi;
        }

        private void pbAdd_Click(object sender, EventArgs e)
        {
            pictureBox1_Click(sender, e);
        }

        private void pbRemove_Click(object sender, EventArgs e)
        {
            //Phai co item dang dc chon
            if (lbPlaylist.SelectedItems.Count > 0)
            {
                object Selected = lbPlaylist.SelectedItem;
                int index = lbPlaylist.Items.IndexOf(Selected);
                int total = lbPlaylist.Items.Count;
                if (index == 0)//neu item do o vi tri dau tien thi add xuong duoi
                {
                    ht.Remove(data.CatChuoi(Selected.ToString(), ".  ", 1));
                    lbPlaylist.Items.Remove(Selected);

                    SapXepPlaylist();
                    if (lbPlaylist.Items.Count > 0)
                        lbPlaylist.SelectedIndex = 0;
                }
                else
                {
                    ht.Remove(data.CatChuoi(Selected.ToString(), ".  ", 1));
                    lbPlaylist.Items.Remove(Selected);
                    SapXepPlaylist();
                    lbPlaylist.SetSelected(index - 1, true);
                }
            }         
        }

        private void lbPlaylist_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            pbStop_Click(sender, e);
            pbPlay_Click(sender, e);
            //pbPlay_MouseLeave(sender, e);
        }

        private void pbUp_Click(object sender, EventArgs e)
        {
            //Phai co item dang dc chon
            if (lbPlaylist.SelectedItems.Count > 0)
            {
                object Selected = lbPlaylist.SelectedItem;
                int index = lbPlaylist.Items.IndexOf(Selected);
                int total = lbPlaylist.Items.Count;
                if (index == 0)//neu item do o vi tri dau tien thi add xuong duoi
                {
                    lbPlaylist.Items.Remove(Selected);
                    lbPlaylist.Items.Insert(total - 1, Selected);
                    SapXepPlaylist();
                    lbPlaylist.SetSelected(total - 1, true);
                }
                else
                {
                    lbPlaylist.Items.Remove(Selected);
                    lbPlaylist.Items.Insert(index - 1, Selected);
                    SapXepPlaylist();
                    lbPlaylist.SetSelected(index - 1, true);
                }
            }     
        }

        private void pbDown_Click(object sender, EventArgs e)
        {
            if (lbPlaylist.SelectedItems.Count > 0)
            {
                object Selected = lbPlaylist.SelectedItem;
                int index = lbPlaylist.Items.IndexOf(Selected);
                int total = lbPlaylist.Items.Count;
                if (index == total - 1)//neu item do o vi tri dau tien thi add xuong duoi
                {
                    lbPlaylist.Items.Remove(Selected);
                    lbPlaylist.Items.Insert(0, Selected);
                    SapXepPlaylist();
                    lbPlaylist.SetSelected(0, true);
                }
                else
                {
                    lbPlaylist.Items.Remove(Selected);
                    lbPlaylist.Items.Insert(index + 1, Selected);
                    SapXepPlaylist();
                    lbPlaylist.SetSelected(index + 1, true);
                }
            }
        }

        private void pbNext_Click(object sender, EventArgs e)
        {
            pbStop_Click(sender, e);
            if (lbPlaylist.Items.Count > 1)
            {
                if (lbPlaylist.SelectedIndex != lbPlaylist.Items.Count - 1)
                    lbPlaylist.SelectedIndex += 1;
                else
                    lbPlaylist.SelectedIndex = 0;
                pbPlay_Click(sender, e);
                //pbPlay_MouseLeave(sender, e);
            }
        }

        private void pbPrevious_Click(object sender, EventArgs e)
        {
            pbStop_Click(sender, e);
            if (lbPlaylist.Items.Count > 1)
            {
                if (lbPlaylist.SelectedIndex != 0)
                    lbPlaylist.SelectedIndex -= 1;
                else
                    lbPlaylist.SelectedIndex = lbPlaylist.Items.Count - 1;
                pbPlay_Click(sender, e);
                //pbPlay_MouseLeave(sender, e);
            }
        }

 

        private void pbStatus2_MouseUp(object sender, MouseEventArgs e)
        {
            if (NhacDaChoi)
            {
                media.Ctlcontrols.currentPosition = (media.currentMedia.duration / 800) * pbStatus2.Width;
                tmThoiGian.Start();
            }
                
        }



        private void pbStatus1_MouseUp(object sender, MouseEventArgs e)
        {
            pbStatus2_MouseUp(sender, e);
        }

        private void pbQuickImport_Click(object sender, EventArgs e)
        {
            int dem = 0;
            for (int i = 0; i < lbPlaylist.Items.Count; i++)
            {
                string tbh = data.CatChuoi(lbPlaylist.Items[i].ToString(), ".  ", 1);
                //tbh = tbh.Substring(0, tbh.Length - 4);

                string str = "Sp_ThemBaiHat N'" + tbh.Substring(0, tbh.Length - 4) + "',999,999, N'" + (string)ht[tbh] + "'";
                //MessageBox.Show((string)ht[tbh]);
                dt = data.LayDuLieu(str);
                dem += int.Parse(dt.Rows[0]["ErrCode"].ToString());

            }
            MessageBox.Show("Đã thêm " + (lbPlaylist.Items.Count - dem).ToString() + " bài hát vào CSDL","Music Player");
        }

        private void pbQuickImport_MouseMove(object sender, MouseEventArgs e)
        {
            pbQuickImport.Image = Image.FromFile("../../Image\\quick_import_move.jpg");
        }

        private void pbQuickImport_MouseLeave(object sender, EventArgs e)
        {
            pbQuickImport.Image = Image.FromFile("../../Image\\quick_import.jpg");
        }
        int ttt = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            ttt++;
            if (ttt == 6)
            {
                lbChinhTocDo.Visible = false;
                timer1.Stop();
            }
        }

        public void picb_playdemo_Click(object sender, EventArgs e)
        {
            strDuongDanMp3 = (string)@"Demo karaoke\Another One Bites The Dust.mp3";
            strDuongDanXml = (string)@"Demo karaoke\Another One Bites The Dust.xml";
            XuLyXML(strDuongDanXml, ref strLoi, ref strThoiGian);
            arrCauHat = strLoi.Split('/');
            BaiHat = new string[arrCauHat.Length][];
            for (int i = 0; i < arrCauHat.Length; i++)
                BaiHat[i] = arrCauHat[i].Split(' ');

            arrThoiGianCauHat = strThoiGian.Split('/');
            ThoiGian = new string[arrThoiGianCauHat.Length][];
            for (int i = 0; i < arrThoiGianCauHat.Length; i++)
                ThoiGian[i] = arrThoiGianCauHat[i].Split(',');
            DuocVeChu = true;
            NhacDaChoi = true;
            media.URL = @strDuongDanMp3;
            media.Ctlcontrols.play();
            pbManHinh.Invalidate();
            tmChinh.Start();
            tmThoiGian.Start();
        }

        public void picb_playdemo2_Click(object sender, EventArgs e)
        {
            strDuongDanMp3 = (string)@"Demo karaoke\chua bao gio.mp3";
            strDuongDanXml = (string)@"Demo karaoke\chua bao gio.xml";
            XuLyXML(strDuongDanXml, ref strLoi, ref strThoiGian);
            arrCauHat = strLoi.Split('/');
            BaiHat = new string[arrCauHat.Length][];
            for (int i = 0; i < arrCauHat.Length; i++)
                BaiHat[i] = arrCauHat[i].Split(' ');

            arrThoiGianCauHat = strThoiGian.Split('/');
            ThoiGian = new string[arrThoiGianCauHat.Length][];
            for (int i = 0; i < arrThoiGianCauHat.Length; i++)
                ThoiGian[i] = arrThoiGianCauHat[i].Split(',');
            DuocVeChu = true;
            NhacDaChoi = true;
            media.URL = @strDuongDanMp3;
            media.Ctlcontrols.play();
            pbManHinh.Invalidate();
            tmChinh.Start();
            tmThoiGian.Start();
        }

        public void picb_playdemo3_Click(object sender, EventArgs e)
        {
            strDuongDanMp3 = (string)@"Demo karaoke\Through the fire.mp3";
            strDuongDanXml = (string)@"Demo karaoke\Through the fire.xml";
            XuLyXML(strDuongDanXml, ref strLoi, ref strThoiGian);
            arrCauHat = strLoi.Split('/');
            BaiHat = new string[arrCauHat.Length][];
            for (int i = 0; i < arrCauHat.Length; i++)
                BaiHat[i] = arrCauHat[i].Split(' ');

            arrThoiGianCauHat = strThoiGian.Split('/');
            ThoiGian = new string[arrThoiGianCauHat.Length][];
            for (int i = 0; i < arrThoiGianCauHat.Length; i++)
                ThoiGian[i] = arrThoiGianCauHat[i].Split(',');
            DuocVeChu = true;
            NhacDaChoi = true;
            media.URL = @strDuongDanMp3;
            media.Ctlcontrols.play();
            pbManHinh.Invalidate();
            tmChinh.Start();
            tmThoiGian.Start();
        }

        public void picb_playdemo4_Click(object sender, EventArgs e)
        {
            strDuongDanMp3 = (string)@"Demo karaoke\Lau dai tinh ai.mp3";
            strDuongDanXml = (string)@"Demo karaoke\Lau dai tinh ai.xml";
            XuLyXML(strDuongDanXml, ref strLoi, ref strThoiGian);
            arrCauHat = strLoi.Split('/');
            BaiHat = new string[arrCauHat.Length][];
            for (int i = 0; i < arrCauHat.Length; i++)
                BaiHat[i] = arrCauHat[i].Split(' ');

            arrThoiGianCauHat = strThoiGian.Split('/');
            ThoiGian = new string[arrThoiGianCauHat.Length][];
            for (int i = 0; i < arrThoiGianCauHat.Length; i++)
                ThoiGian[i] = arrThoiGianCauHat[i].Split(',');
            DuocVeChu = true;
            NhacDaChoi = true;
            media.URL = @strDuongDanMp3;
            media.Ctlcontrols.play();
            pbManHinh.Invalidate();
            tmChinh.Start();
            tmThoiGian.Start();
        }

        public void picb_playdemo5_Click(object sender, EventArgs e)
        {
            strDuongDanMp3 = (string)@"Demo karaoke\La lung.mp3";
            strDuongDanXml = (string)@"Demo karaoke\La lung.xml";
            XuLyXML(strDuongDanXml, ref strLoi, ref strThoiGian);
            arrCauHat = strLoi.Split('/');
            BaiHat = new string[arrCauHat.Length][];
            for (int i = 0; i < arrCauHat.Length; i++)
                BaiHat[i] = arrCauHat[i].Split(' ');

            arrThoiGianCauHat = strThoiGian.Split('/');
            ThoiGian = new string[arrThoiGianCauHat.Length][];
            for (int i = 0; i < arrThoiGianCauHat.Length; i++)
                ThoiGian[i] = arrThoiGianCauHat[i].Split(',');
            DuocVeChu = true;
            NhacDaChoi = true;
            media.URL = @strDuongDanMp3;
            media.Ctlcontrols.play();
            pbManHinh.Invalidate();
            tmChinh.Start();
            tmThoiGian.Start();
        }

        public void picb_playdemo6_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["mainmenu"];
            strDuongDanMp3 = ((mainmenu)f).listb_karaoketracks.Items[0].ToString();
            strDuongDanXml = strDuongDanMp3.Substring(0, strDuongDanMp3.Length - 4) + ".xml";
            XuLyXML(strDuongDanXml, ref strLoi, ref strThoiGian);
            arrCauHat = strLoi.Split('/');
            BaiHat = new string[arrCauHat.Length][];
            for (int i = 0; i < arrCauHat.Length; i++)
                BaiHat[i] = arrCauHat[i].Split(' ');

            arrThoiGianCauHat = strThoiGian.Split('/');
            ThoiGian = new string[arrThoiGianCauHat.Length][];
            for (int i = 0; i < arrThoiGianCauHat.Length; i++)
                ThoiGian[i] = arrThoiGianCauHat[i].Split(',');
            DuocVeChu = true;
            NhacDaChoi = true;
            media.URL = @strDuongDanMp3;
            media.Ctlcontrols.play();
            pbManHinh.Invalidate();
            tmChinh.Start();
            tmThoiGian.Start();
        }

        public void picb_playdemo7_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["mainmenu"];
            strDuongDanMp3 = ((mainmenu)f).listb_karaoketracks.Items[1].ToString();
            strDuongDanXml = strDuongDanMp3.Substring(0, strDuongDanMp3.Length - 4) + ".xml";
            XuLyXML(strDuongDanXml, ref strLoi, ref strThoiGian);
            arrCauHat = strLoi.Split('/');
            BaiHat = new string[arrCauHat.Length][];
            for (int i = 0; i < arrCauHat.Length; i++)
                BaiHat[i] = arrCauHat[i].Split(' ');

            arrThoiGianCauHat = strThoiGian.Split('/');
            ThoiGian = new string[arrThoiGianCauHat.Length][];
            for (int i = 0; i < arrThoiGianCauHat.Length; i++)
                ThoiGian[i] = arrThoiGianCauHat[i].Split(',');
            DuocVeChu = true;
            NhacDaChoi = true;
            media.URL = @strDuongDanMp3;
            media.Ctlcontrols.play();
            pbManHinh.Invalidate();
            tmChinh.Start();
            tmThoiGian.Start();
        }
    }
}
