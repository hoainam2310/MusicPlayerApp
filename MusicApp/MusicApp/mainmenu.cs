using System;
using NAudio.Wave;
using System.Diagnostics;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MusicPlayer;


namespace MusicApp
{
    public partial class mainmenu : Form
    {
        System.Timers.Timer t;
        int m, s;

        bool checksaverecord = false;

        WaveIn wave;
        WaveFileWriter writer;
        string outputFileName;
        DataTable dt = new DataTable();
        karaoke k = new karaoke();
        public mainmenu()
        {
            InitializeComponent();
            listb_track.Visible = false;
            lbl_position.Visible = false;
            slide_volume.Value = 20;
            dt.Columns.Add("Album", typeof(string));
            dt.Columns.Add("Title", typeof(string));
            dt.Columns.Add("Singer", typeof(string));
            dt.Columns.Add("Duration", typeof(string));

            dt.Rows.Add("Platinum Collection: Greatests Hits", "Another One Bites The Dust", "Queen", "03:35");
            dt.Rows.Add("Platinum Collection: Greatests Hits", "Don't Stop Me Now", "Queen", "03:29");
            dt.Rows.Add("Arcane: League Of Legends", "Dynasties Dystopia", "Denzel Curry; GIZZLE; Bren Joy", "02:58");
            dt.Rows.Add("30", "Easy On Me", "Adele", "03:44");
            dt.Rows.Add("Arcane: League Of Legends", "Enemy (feat. J.I.D)", "Imagine Dragons", "02:53");
            dt.Rows.Add("Arcane: League Of Legends", "Guns For Hire", "Woodkid", "03:46");
            dt.Rows.Add("unknown", "Love Me Like There Is No Tomorrow", "Freddie Mercury", "03:46");
            dt.Rows.Add("Platinum Collection: Greatests Hits", "Somebody To Love", "Queen", "04:57");
            dt.Rows.Add("unknown", "The Airbuster", "Nobuo Uematsu", "07:34");
            dt.Rows.Add("30", "Woman Like Me", "Adele", "05:00");
        }

       
        private void btn_songs_Click(object sender, EventArgs e)
        {
            bunifuVSlider1.Value = 100;
            tab_items.SetPage(0);
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["karaoke"];
            if(check_karaoke.Checked == true)
            {
                ((karaoke)f).pbStop_Click(sender, e);
                check_karaoke.Checked = false;
                picb_karaokescreen.Visible = true;
            }

        }
        private void btn_albums_Click(object sender, EventArgs e)
        {
            bunifuVSlider1.Value = 75;
            tab_items.SetPage(1);
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["karaoke"];
            if (check_karaoke.Checked == true)
            {
                ((karaoke)f).pbStop_Click(sender, e);
                check_karaoke.Checked = false;
                picb_karaokescreen.Visible = true;
            }
        }
        private void btn_karaoke_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.stop();
            bunifuVSlider1.Value = 50;
            tab_items.SetPage(2);

            k.TopLevel = false;
            k.Dock = DockStyle.Left;
            tab_karaoke.Controls.Add(k);
            k.Show();
            check_karaoke.Checked = true;
        }
        private void btn_settings_Click(object sender, EventArgs e)
        {
            bunifuVSlider1.Value = 25;
            tab_items.SetPage(3);
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["karaoke"];
            if (check_karaoke.Checked == true)
            {
                ((karaoke)f).pbStop_Click(sender, e);
                check_karaoke.Checked = false;
                picb_karaokescreen.Visible = true;
            }
        }

        private void picb_Close_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void picb_mutevol_Click(object sender, EventArgs e)
        {
            player.settings.volume = 0;
            slide_volume.Value = 0;
        }

        private void picb_maxvol_Click(object sender, EventArgs e)
        {
            player.settings.volume = 100;
            slide_volume.Value = 100;
        }

        private void txt_search_Click(object sender, EventArgs e)
        {
            txt_search.Text = "";
        }

        string[] paths, files;

        private void listb_track_SelectedIndexChanged(object sender, EventArgs e)
        {
            player.URL = paths[listb_track.SelectedIndex];
            player.Ctlcontrols.play();
        }

        private void pb_stop_Click(object sender, EventArgs e)
        {
            if(check_karaoke.Checked==true)
            {
                System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["karaoke"];
                ((karaoke)f).media.Ctlcontrols.pause();
                picb_Visualize.Visible = false;
            }
            else
            {
                player.Ctlcontrols.pause();
                picb_Visualize.Visible = false;
            }
        }

        private void pb_play_Click(object sender, EventArgs e)
        {
            if(check_karaoke.Checked==true)
            {
                System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["karaoke"];
                ((karaoke)f).media.Ctlcontrols.play();
            }
            else
            {
                player.Ctlcontrols.play();
                picb_Visualize.Visible = true;
            }
        }

        private void pb_next_Click(object sender, EventArgs e)
        {
            if(check_karaoke.Checked== true)
            {
                if (lbl_kposition.Text == "1")
                {
                    System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["karaoke"];
                    ((karaoke)f).picb_playdemo2_Click(sender, e);
                }
                else if (lbl_kposition.Text == "2")
                {
                    System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["karaoke"];
                    ((karaoke)f).picb_playdemo3_Click(sender, e);
                }
                else if (lbl_kposition.Text == "3")
                {
                    System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["karaoke"];
                    ((karaoke)f).picb_playdemo4_Click(sender, e);
                }
                else if (lbl_kposition.Text == "4")
                {
                    System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["karaoke"];
                    ((karaoke)f).picb_playdemo5_Click(sender, e);
                }
                else if (lbl_kposition.Text == "5" && listb_karaoketracks.Items.Count == 1)
                {
                    System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["karaoke"];
                    ((karaoke)f).picb_playdemo6_Click(sender, e);
                }
                else if (lbl_kposition.Text == "6" && listb_karaoketracks.Items.Count == 2)
                {
                    System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["karaoke"];
                    ((karaoke)f).picb_playdemo7_Click(sender, e);
                }
            }
            else
            {
                if (lbl_position.Text == "1")
                {
                    picb_play2_Click(sender, e);
                }
                else if (lbl_position.Text == "2")
                {
                    picb_play3_Click(sender, e);
                }
                else if (lbl_position.Text == "3")
                {
                    picb_play4_Click(sender, e);
                }
                else if (lbl_position.Text == "4")
                {
                    picb_play5_Click(sender, e);
                }
                else if (lbl_position.Text == "5")
                {
                    picb_play6_Click(sender, e);
                }
                else if (lbl_position.Text == "6")
                {
                    picb_play7_Click(sender, e);
                }
                else if (lbl_position.Text == "7")
                {
                    picb_play8_Click(sender, e);
                }
                else if (lbl_position.Text == "8")
                {
                    picb_play9_Click(sender, e);
                }
                else if (lbl_position.Text == "9")
                {
                    picb_play10_Click(sender, e);
                }
                else if (lbl_position.Text == "10" && listb_track.Items.Count == 1)
                {
                    picb_play11_Click(sender, e);
                }
                else if (lbl_position.Text == "11" && listb_track.Items.Count == 2)
                {
                    picb_play12_Click(sender, e);
                }
                else if (lbl_position.Text == "12" && listb_track.Items.Count == 3)
                {
                    picb_play13_Click(sender, e);
                }
            }
            
        }

        private void pb_back_Click(object sender, EventArgs e)
        {
            if(check_karaoke.Checked==true)
            {
                if(lbl_kposition.Text=="2")
                {
                    System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["karaoke"];
                    ((karaoke)f).picb_playdemo_Click(sender, e);
                }
                else if (lbl_kposition.Text == "3")
                {
                    System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["karaoke"];
                    ((karaoke)f).picb_playdemo2_Click(sender, e);
                }
                else if (lbl_kposition.Text == "4")
                {
                    System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["karaoke"];
                    ((karaoke)f).picb_playdemo3_Click(sender, e);
                }
                else if (lbl_kposition.Text == "5")
                {
                    System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["karaoke"];
                    ((karaoke)f).picb_playdemo4_Click(sender, e);
                }
                else if (lbl_kposition.Text == "6")
                {
                    System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["karaoke"];
                    ((karaoke)f).picb_playdemo5_Click(sender, e);
                }
                else if (lbl_kposition.Text == "7")
                {
                    System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["karaoke"];
                    ((karaoke)f).picb_playdemo6_Click(sender, e);
                }
            }
            else
            {
                if (lbl_position.Text == "2")
                {
                    picb_play1_Click(sender, e);
                }
                else if (lbl_position.Text == "3")
                {
                    picb_play2_Click(sender, e);
                }
                else if (lbl_position.Text == "4")
                {
                    picb_play3_Click(sender, e);
                }
                else if (lbl_position.Text == "5")
                {
                    picb_play4_Click(sender, e);
                }
                else if (lbl_position.Text == "6")
                {
                    picb_play5_Click(sender, e);
                }
                else if (lbl_position.Text == "7")
                {
                    picb_play6_Click(sender, e);
                }
                else if (lbl_position.Text == "8")
                {
                    picb_play7_Click(sender, e);
                }
                else if (lbl_position.Text == "9")
                {
                    picb_play8_Click(sender, e);
                }
                else if (lbl_position.Text == "10")
                {
                    picb_play9_Click(sender, e);
                }
                else if (lbl_position.Text == "11")
                {
                    picb_play10_Click(sender, e);
                }
                else if (lbl_position.Text == "12")
                {
                    picb_play11_Click(sender, e);
                }
                else if (lbl_position.Text == "13")
                {
                    picb_play12_Click(sender, e);
                }
            }  
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(check_karaoke.Checked==true)
            {
                System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["karaoke"];
                ((karaoke)f).media.settings.volume = slide_volume.Value;
                if (((karaoke)f).media.playState == WMPLib.WMPPlayState.wmppsPlaying)
                {
                    slider_timeplaymusic.Maximum = (int)((karaoke)f).media.Ctlcontrols.currentItem.duration;
                    slider_timeplaymusic.Value = (int)((karaoke)f).media.Ctlcontrols.currentPosition;
                }
                try
                {
                    lbl_timeplaymusic.Text = ((karaoke)f).media.Ctlcontrols.currentPositionString;
                    lbl_totaltimesong.Text = ((karaoke)f).media.Ctlcontrols.currentItem.durationString.ToString();
                    if (lbl_timeplaymusic.Text == lbl_totaltimesong.Text)
                    {
                        pb_next_Click(sender, e);
                    }
                }
                catch
                {

                }
            }
            else
            {
                if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
                {
                    slider_timeplaymusic.Maximum = (int)player.Ctlcontrols.currentItem.duration;
                    slider_timeplaymusic.Value = (int)player.Ctlcontrols.currentPosition;
                }
                try
                {
                    lbl_timeplaymusic.Text = player.Ctlcontrols.currentPositionString;
                    lbl_totaltimesong.Text = player.Ctlcontrols.currentItem.durationString.ToString();
                    if (lbl_timeplaymusic.Text == lbl_totaltimesong.Text)
                    {
                        pb_next_Click(sender, e);
                    }
                }
                catch
                {

                }
            }
            
        }

        private void slide_volume_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {
            if(check_karaoke.Checked== true)
            {
                System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["karaoke"];
                ((karaoke)f).media.settings.volume = slide_volume.Value;
            }
            else
            {
                player.settings.volume = slide_volume.Value;
            }
        }

        private void slider_timeplaymusic_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {
            if (check_karaoke.Checked == true)
            {
                System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["karaoke"];
                ((karaoke)f).media.Ctlcontrols.currentPosition = slider_timeplaymusic.Value;
            }
            else
            {
                player.Ctlcontrols.currentPosition = slider_timeplaymusic.Value;
            }
        }

        private void lbl_addsongs_Click(object sender, EventArgs e)
        {
            picb_addsongs_Click(sender, e);
        }

        private void btn_font_Click(object sender, EventArgs e)
        {
            if(fontDialog1.ShowDialog() == DialogResult.OK)
            {
                lb_bmusic.Font = fontDialog1.Font;
                lb_language.Font = fontDialog1.Font;
                lb_font.Font = fontDialog1.Font;
                lb_color.Font = fontDialog1.Font;
                btn_settings.Font = fontDialog1.Font;
                btn_albums.Font = fontDialog1.Font;
                btn_songs.Font = fontDialog1.Font;
                txt_search.Font = fontDialog1.Font;
                lb_addsongs.Font = fontDialog1.Font;
                lb_exit.Font = fontDialog1.Font;
                btn_karaoke.Font = fontDialog1.Font;
            }
        }

        private void picb_play1_Click(object sender, EventArgs e)
        {
            picb_currentsong.Image = picb_song1.Image;
            lbl_playingname.Text = lbl_songname1.Text;
            lbl_playingsinger.Text = lbl_singer1.Text;
            lbl_playingname.Visible = true;
            lbl_playingsinger.Visible = true;
            player.URL = @"Tracks\Another One Bites The Dust.flac";
            player.Ctlcontrols.play();
            lbl_position.Text = "1";
            picb_Visualize.Visible = true;
        }

        private void picb_savesettings_Click(object sender, EventArgs e)
        {
            if (cbb_language.Text == "Vietnamese")
            {
                lb_bmusic.Text = "Nhạc nền";
                lb_language.Text = "Chọn ngôn ngữ";
                lb_font.Text = "Kiểu chữ";
                lb_color.Text = "Chọn màu";
                btn_albums.Text = "Album";
                btn_settings.Text = "Cài đặt";
                btn_songs.Text = "Nhạc";
                txt_search.Text = "Nhập tên ca khúc";
                lb_addsongs.Text = "Thêm ca khúc";
                lb_exit.Text = "Thoát";
                btn_karaoke.Text = "Karaoke";
            }
            else if (cbb_language.Text == "English")
            {
                lb_bmusic.Text = "Background music";
                lb_language.Text = "Choose your language";
                lb_font.Text = "Choose your font";
                lb_color.Text = "Choose your color";
                btn_albums.Text = "Albums";
                btn_settings.Text = "Settings";
                btn_songs.Text = "Songs";
                txt_search.Text = "Enter song name";
                lb_addsongs.Text = "Add songs";
                lb_exit.Text = "Exit";
                btn_karaoke.Text = "Karaoke";
            }
            else
            {
                MessageBox.Show("Error/ Lỗi");
            }
            if (cbb_colortheme.Text == "Dark")
            {
                panel_SideBar.BackColor = Color.SlateGray;
                tab_album.BackColor = Color.SlateGray;
                pic_settings.BackColor = Color.SlateGray;
                panel_allsongs.BackColor = Color.SlateGray;
                picb_savesettings.BackColor = Color.SlateGray;
                pic_settings.BackColor = Color.SlateGray;
                picb_search.BackColor = Color.SlateGray;
                tab_song.BackColor = Color.SlateGray;
                tab_karaoke.BackColor = Color.SlateGray;
                tab_settings.BackColor = Color.SlateGray;
                btn_songs.BackColor = Color.SlateGray;
                btn_albums.BackColor = Color.SlateGray;
                btn_karaoke.BackColor = Color.SlateGray;
                btn_settings.BackColor = Color.SlateGray;
                lb_color.BackColor = Color.SlateGray;
                lb_language.BackColor = Color.SlateGray;
                lb_font.BackColor = Color.SlateGray;
                lb_bmusic.BackColor = Color.SlateGray;
                lbl_30.BackColor = Color.SlateGray;
                lbl_arcane.BackColor = Color.SlateGray;
                lbl_queen.BackColor = Color.SlateGray;
                lbl_unknown.BackColor = Color.SlateGray;
            }
            else if (cbb_colortheme.Text == "Light")
            {
                panel_SideBar.BackColor = Color.WhiteSmoke;
                tab_album.BackColor = Color.WhiteSmoke;
                pic_settings.BackColor = Color.WhiteSmoke;
                panel_allsongs.BackColor = Color.WhiteSmoke;
                pic_settings.BackColor = Color.WhiteSmoke;
                picb_search.BackColor = Color.WhiteSmoke;
                tab_song.BackColor = Color.WhiteSmoke;
                tab_karaoke.BackColor = Color.WhiteSmoke;
                tab_settings.BackColor = Color.WhiteSmoke;
                btn_songs.BackColor = Color.WhiteSmoke;
                btn_albums.BackColor = Color.WhiteSmoke;
                btn_karaoke.BackColor = Color.WhiteSmoke;
                btn_settings.BackColor = Color.WhiteSmoke;
                lb_color.BackColor = Color.WhiteSmoke;
                lb_language.BackColor = Color.WhiteSmoke;
                lb_font.BackColor = Color.WhiteSmoke;
                lb_bmusic.BackColor = Color.WhiteSmoke;
                lbl_30.BackColor = Color.WhiteSmoke;
                lbl_arcane.BackColor = Color.WhiteSmoke;
                lbl_queen.BackColor = Color.WhiteSmoke;
                lbl_unknown.BackColor = Color.WhiteSmoke;
            }
            else
            {
                MessageBox.Show("Error/ Lỗi");
            }
        }

        private void picb_play2_Click(object sender, EventArgs e)
        {
            picb_currentsong.Image = picb_song2.Image;
            lbl_playingname.Text = lbl_songname2.Text;
            lbl_playingsinger.Text = lbl_singer2.Text;
            lbl_playingname.Visible = true;
            lbl_playingsinger.Visible = true;
            player.URL = @"Tracks\Don't Stop Me Now.flac";
            player.Ctlcontrols.play();
            lbl_position.Text = "2";
            picb_Visualize.Visible = true;
        }

        private void picb_play3_Click(object sender, EventArgs e)
        {
            picb_currentsong.Image = picb_song3.Image;
            lbl_playingname.Text = lbl_songname3.Text;
            lbl_playingsinger.Text = lbl_singer3.Text;
            lbl_playingname.Visible = true;
            lbl_playingsinger.Visible = true;
            player.URL = @"Tracks\Dynasties Dystopia.flac";
            player.Ctlcontrols.play();
            lbl_position.Text = "3";
            picb_Visualize.Visible = true;
        }

        private void picb_play4_Click(object sender, EventArgs e)
        {
            picb_currentsong.Image = picb_song4.Image;
            lbl_playingname.Text = lbl_songname4.Text;
            lbl_playingsinger.Text = lbl_singer4.Text;
            lbl_playingname.Visible = true;
            lbl_playingsinger.Visible = true;
            player.URL = @"Tracks\Easy On Me.flac";
            player.Ctlcontrols.play();
            lbl_position.Text = "4";
            picb_Visualize.Visible = true;
        }

        private void picb_play5_Click(object sender, EventArgs e)
        {
            picb_currentsong.Image = picb_song5.Image;
            lbl_playingname.Text = lbl_songname5.Text;
            lbl_playingsinger.Text = lbl_singer5.Text;
            lbl_playingname.Visible = true;
            lbl_playingsinger.Visible = true;
            player.URL = @"Tracks\Enemy (feat. J.I.D).flac";
            player.Ctlcontrols.play();
            lbl_position.Text = "5";
            picb_Visualize.Visible = true;
        }

        private void picb_play6_Click(object sender, EventArgs e)
        {
            picb_currentsong.Image = picb_song6.Image;
            lbl_playingname.Text = lbl_songname6.Text;
            lbl_playingsinger.Text = lbl_singer6.Text;
            lbl_playingname.Visible = true;
            lbl_playingsinger.Visible = true;
            player.URL = @"Tracks\Guns for Hire.flac";
            player.Ctlcontrols.play();
            lbl_position.Text = "6";
            picb_Visualize.Visible = true;
        }

        private void picb_play7_Click(object sender, EventArgs e)
        {
            picb_currentsong.Image = picb_song7.Image;
            lbl_playingname.Text = lbl_songname7.Text;
            lbl_playingsinger.Text = lbl_singer7.Text;
            lbl_playingname.Visible = true;
            lbl_playingsinger.Visible = true;
            player.URL = @"Tracks\Love Me Like There Is No Tomorrow.flac";
            player.Ctlcontrols.play();
            lbl_position.Text = "7";
            picb_Visualize.Visible = true;
        }

        private void picb_play8_Click(object sender, EventArgs e)
        {
            picb_currentsong.Image = picb_song8.Image;
            lbl_playingname.Text = lbl_songname8.Text;
            lbl_playingsinger.Text = lbl_singer8.Text;
            lbl_playingname.Visible = true;
            lbl_playingsinger.Visible = true;
            player.URL = @"Tracks\Somebody To Love.flac";
            player.Ctlcontrols.play();
            lbl_position.Text = "8";
            picb_Visualize.Visible = true;
        }

        private void picb_play9_Click(object sender, EventArgs e)
        {
            picb_currentsong.Image = picb_song9.Image;
            lbl_playingname.Text = lbl_songname9.Text;
            lbl_playingsinger.Text = lbl_singer9.Text;
            lbl_playingname.Visible = true;
            lbl_playingsinger.Visible = true;
            player.URL = @"Tracks\The Airbuster.flac";
            player.Ctlcontrols.play();
            lbl_position.Text = "9";
            picb_Visualize.Visible = true;
        }

        private void picb_play10_Click(object sender, EventArgs e)
        {
            picb_currentsong.Image = picb_song10.Image;
            lbl_playingname.Text = lbl_songname10.Text;
            lbl_playingsinger.Text = lbl_singer10.Text;
            lbl_playingname.Visible = true;
            lbl_playingsinger.Visible = true;
            player.URL = @"Tracks\Woman Like Me.flac";
            player.Ctlcontrols.play();
            lbl_position.Text = "10";
            picb_Visualize.Visible = true;
        }

        private void picb_30_Click(object sender, EventArgs e)
        {
            tab_items.SetPage(4);
            lbl_albumname.Text = lbl_30.Text;
            picb_album.Image = picb_30.Image;
            picb_searchsong1.Image = picb_30.Image;
            picb_searchsong2.Image = picb_30.Image;
            panel_searchsong3.Visible = false;
            string s = "Album='" + lbl_30.Text + "'";
            DataRow[] dr = dt.Select(s);
            lbl_searchtitle1.Text = dr[0]["Title"].ToString();
            lbl_searchsinger1.Text = dr[0]["Singer"].ToString();
            lbl_searchduration1.Text = dr[0]["Duration"].ToString();
            lbl_searchtitle2.Text = dr[1]["Title"].ToString();
            lbl_searchsinger2.Text = dr[1]["Singer"].ToString();
            lbl_searchduration2.Text = dr[1]["Duration"].ToString();
        }

        private void picb_arcane_Click(object sender, EventArgs e)
        {
            tab_items.SetPage(4);
            lbl_albumname.Text = lbl_arcane.Text;
            picb_album.Image = picb_arcane.Image;
            picb_searchsong1.Image = picb_arcane.Image;
            picb_searchsong2.Image = picb_arcane.Image;
            picb_searchsong3.Image = picb_arcane.Image;
            panel_searchsong3.Visible = true;
            string s = "Album='" + lbl_arcane.Text + "'";
            DataRow[] dr = dt.Select(s);
            lbl_searchtitle1.Text = dr[0]["Title"].ToString();
            lbl_searchsinger1.Text = dr[0]["Singer"].ToString();
            lbl_searchduration1.Text = dr[0]["Duration"].ToString();
            lbl_searchtitle2.Text = dr[1]["Title"].ToString();
            lbl_searchsinger2.Text = dr[1]["Singer"].ToString();
            lbl_searchduration2.Text = dr[1]["Duration"].ToString();
            lbl_searchtitle3.Text = dr[2]["Title"].ToString();
            lbl_searchsinger3.Text = dr[2]["Singer"].ToString();
            lbl_searchduration3.Text = dr[2]["Duration"].ToString();
        }

        private void picb_queen_Click(object sender, EventArgs e)
        {
            tab_items.SetPage(4);
            lbl_albumname.Text = lbl_queen.Text;
            picb_album.Image = picb_queen.Image;
            picb_searchsong1.Image = picb_queen.Image;
            picb_searchsong2.Image = picb_queen.Image;
            picb_searchsong3.Image = picb_queen.Image;
            panel_searchsong3.Visible = true;
            string s = "Album='" + lbl_queen.Text + "'";
            DataRow[] dr = dt.Select(s);
            lbl_searchtitle1.Text = dr[0]["Title"].ToString();
            lbl_searchsinger1.Text = dr[0]["Singer"].ToString();
            lbl_searchduration1.Text = dr[0]["Duration"].ToString();
            lbl_searchtitle2.Text = dr[1]["Title"].ToString();
            lbl_searchsinger2.Text = dr[1]["Singer"].ToString();
            lbl_searchduration2.Text = dr[1]["Duration"].ToString();
            lbl_searchtitle3.Text = dr[2]["Title"].ToString();
            lbl_searchsinger3.Text = dr[2]["Singer"].ToString();
            lbl_searchduration3.Text = dr[2]["Duration"].ToString();
        }

        private void picb_unknown_Click(object sender, EventArgs e)
        {
            tab_items.SetPage(4);
            lbl_albumname.Text = lbl_unknown.Text;
            picb_album.Image = picb_unknown.Image;
            picb_searchsong1.Image = picb_unknown.Image;
            picb_searchsong2.Image = picb_unknown.Image;
            panel_searchsong3.Visible = false;
            string s = "Album='" + lbl_unknown.Text + "'";
            DataRow[] dr = dt.Select(s);
            lbl_searchtitle1.Text = dr[0]["Title"].ToString();
            lbl_searchsinger1.Text = dr[0]["Singer"].ToString();
            lbl_searchduration1.Text = dr[0]["Duration"].ToString();
            lbl_searchtitle2.Text = dr[1]["Title"].ToString();
            lbl_searchsinger2.Text = dr[1]["Singer"].ToString();
            lbl_searchduration2.Text = dr[1]["Duration"].ToString();
        }

        private void picb_searchplay1_Click(object sender, EventArgs e)
        {
            if(lbl_albumname.Text =="30")
            {
                picb_play4_Click(sender, e);
            }
            else if (lbl_albumname.Text == "Arcane: League Of Legends")
            {
                picb_play3_Click(sender, e);
            }
            else if(lbl_albumname.Text == "Platinum Collection: Greatests Hits")
            {
                picb_play1_Click(sender, e);
            }
            else if (lbl_albumname.Text == "unknown")
            {
                picb_play7_Click(sender, e);
            }
        }

        private void picb_searchplay2_Click(object sender, EventArgs e)
        {
            if (lbl_albumname.Text == "30")
            {
                picb_play10_Click(sender, e);
            }
            else if (lbl_albumname.Text == "Arcane: League Of Legends")
            {
                picb_play5_Click(sender, e);
            }
            else if (lbl_albumname.Text == "Platinum Collection: Greatests Hits")
            {
                picb_play2_Click(sender, e);
            }
            else if (lbl_albumname.Text == "unknown")
            {
                picb_play9_Click(sender, e);
            }
        }

        private void picb_searchplay3_Click(object sender, EventArgs e)
        {
            if(lbl_albumname.Text== "Arcane: League Of Legends")
            {
                picb_play6_Click(sender, e);
            }
            else if (lbl_albumname.Text == "Platinum Collection: Greatests Hits")
            {
                picb_play8_Click(sender, e);
            }
        }

        private void txt_search_Enter(object sender, EventArgs e)
        {
            if (txt_search.Text == "Enter song name")
            {
                txt_search.Text = "";
                txt_search.ForeColor = Color.Black;
            }
        }

        private void txt_search_Leave(object sender, EventArgs e)
        {
            if (txt_search.Text == "")
            {
                txt_search.Text = "Enter song name";
                txt_search.ForeColor = Color.Silver;
            }
        }

        private void panel17_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picb_play11_Click(object sender, EventArgs e)
        {
            picb_currentsong.Image = picb_song11.Image;
            lbl_playingname.Text = lbl_songname11.Text;
            lbl_playingsinger.Text = lbl_singer11.Text;
            lbl_playingname.Visible = true;
            lbl_playingsinger.Visible = true;
            player.URL = listb_track.Items[0].ToString();
            player.Ctlcontrols.play();
            lbl_position.Text = "11";
            picb_Visualize.Visible = true;
        }

        private void picb_play12_Click(object sender, EventArgs e)
        {
            picb_currentsong.Image = picb_song12.Image;
            lbl_playingname.Text = lbl_songname12.Text;
            lbl_playingsinger.Text = lbl_singer12.Text;
            lbl_playingname.Visible = true;
            lbl_playingsinger.Visible = true;
            player.URL = listb_track.Items[1].ToString();
            player.Ctlcontrols.play();
            lbl_position.Text = "12";
            picb_Visualize.Visible = true;
        }

        private void picb_play13_Click(object sender, EventArgs e)
        {
            picb_currentsong.Image = picb_song13.Image;
            lbl_playingname.Text = lbl_songname13.Text;
            lbl_playingsinger.Text = lbl_singer13.Text;
            lbl_playingname.Visible = true;
            lbl_playingsinger.Visible = true;
            player.URL = listb_track.Items[2].ToString();
            player.Ctlcontrols.play();
            lbl_position.Text = "13";
            picb_Visualize.Visible = true;
        }
        private void Wave_RecordingStopped(object sender, StoppedEventArgs e)
        {
            writer.Dispose();
        }
        private void Wave_DataAvailable(object sender, WaveInEventArgs e)
        {
            writer.Write(e.Buffer, 0, e.BytesRecorded);
        }
        private void picb_recordvoice_mute_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to save the recording file?", "NOTIFICATION", MessageBoxButtons.YesNoCancel);

            if(result == System.Windows.Forms.DialogResult.Yes)
            {
                var dialog = new SaveFileDialog();
                dialog.Filter = "Wave files | *.wav";

                if (dialog.ShowDialog() != DialogResult.OK)
                    return;

                outputFileName = dialog.FileName;

                wave = new WaveIn();
                wave.WaveFormat = new WaveFormat(44100, 1);
                wave.DataAvailable += Wave_DataAvailable;
                wave.RecordingStopped += Wave_RecordingStopped;
                writer = new WaveFileWriter(outputFileName, wave.WaveFormat);
                wave.StartRecording();

                checksaverecord = true;
            }
            if (result == System.Windows.Forms.DialogResult.No)
                checksaverecord = false;

            MessageBox.Show("Start recording", "NOTIFICATION");
            picb_recordvoi_unmute.Visible = true;
            
            t.Start();
        }

        private void picb_recordvoi_unmute_Click(object sender, EventArgs e)
        {
            if(checksaverecord == true)
            {
                wave.StopRecording();

                if (outputFileName == null)
                    return;

                var processStartInfo = new ProcessStartInfo
                {
                    FileName = Path.GetDirectoryName(outputFileName),
                    UseShellExecute = true
                };

                Process.Start(processStartInfo);
            }
            t.Stop();
            MessageBox.Show("Stop recording", "NOTIFICATION");

            picb_recordvoi_unmute.Visible = false;

        
            txb_timerecord.Text = "00:00";  
        }

        private void picb_karaokeplay1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["karaoke"];
            ((karaoke)f).pbStop_Click(sender, e);
            ((karaoke)f).picb_playdemo_Click(sender, e);
            lbl_kposition.Text = "1";
            picb_Visualize.Visible = true;
            picb_karaokescreen.Visible = false;
        }

        private void mainmenu_Load(object sender, EventArgs e)
        {
            t = new System.Timers.Timer();
            t.Interval = 1000; //1s
            t.Elapsed += OnTimeEvent;
        }

        private void OnTimeEvent(object sender, System.Timers.ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                s += 1;
                if(s == 60)
                {
                    s = 0;
                    m += 1;
                }    
                if(m == 60)
                {
                    m = 0;
                }
                txb_timerecord.Text = string.Format("{0}:{1}", m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
            }));
        }

        private void picb_songtab_Click(object sender, EventArgs e)
        {
            btn_songs_Click(sender, e);
        }

        private void picb_albumtab_Click(object sender, EventArgs e)
        {
            btn_albums_Click(sender, e);
        }

        private void picb_karaoketab_Click(object sender, EventArgs e)
        {
            btn_karaoke_Click(sender, e);
        }

        private void picb_settingtab_Click(object sender, EventArgs e)
        {
            btn_settings_Click(sender, e);
        }

        private void picb_karaokeplay3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["karaoke"];
            ((karaoke)f).pbStop_Click(sender, e);
            ((karaoke)f).picb_playdemo3_Click(sender, e);
            lbl_kposition.Text = "3";
            picb_Visualize.Visible = true;
            picb_karaokescreen.Visible = false;

        }

        private void picb_karaokeplay4_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["karaoke"];
            ((karaoke)f).pbStop_Click(sender, e);
            ((karaoke)f).picb_playdemo4_Click(sender, e);
            lbl_kposition.Text = "4";
            picb_Visualize.Visible = true;
            picb_karaokescreen.Visible = false;
        }

        private void picb_addkaraoke_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.Filter = "Song Files|*.mp3;*.flac;*.wav;...";
            if(ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.FileNames;
                paths = ofd.FileNames;
                for(int x = 0; x < files.Length;x++)
                {
                    listb_karaoketracks.Items.Add(files[x]);
                }
                if (listb_karaoketracks.Items.Count == 1)
                {
                    panel_karaoke6.Visible = true;
                }
                else if (listb_karaoketracks.Items.Count == 2)
                {
                    panel_karaoke6.Visible = true;
                    panel_karaoke7.Visible = true;
                }
            }
        }

        private void picb_karaokeplay5_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["karaoke"];
            ((karaoke)f).pbStop_Click(sender, e);
            ((karaoke)f).picb_playdemo5_Click(sender, e);
            lbl_kposition.Text = "5";
            picb_Visualize.Visible = true;
            picb_karaokescreen.Visible = false;
        }

        private void picb_karaokeplay6_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["karaoke"];
            ((karaoke)f).pbStop_Click(sender, e);
            ((karaoke)f).picb_playdemo2_Click(sender, e);
            lbl_kposition.Text = "6";
            picb_Visualize.Visible = true;
            picb_karaokescreen.Visible = false;
        }

        private void picb_karaokeplay7_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["karaoke"];
            ((karaoke)f).pbStop_Click(sender, e);
            ((karaoke)f).picb_playdemo7_Click(sender, e);
            lbl_kposition.Text = "7";
            picb_Visualize.Visible = true;
            picb_karaokescreen.Visible = false;
        }

        private void lb_addkaraoke_Click(object sender, EventArgs e)
        {
            picb_addkaraoke_Click(sender, e);
        }

        private void btn_games_Click(object sender, EventArgs e)
        {
            bunifuVSlider1.Value = 0;
            tab_items.SetPage(5);
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["karaoke"];
            if (check_karaoke.Checked == true)
            {
                ((karaoke)f).pbStop_Click(sender, e);
                check_karaoke.Checked = false;
            }
        }

        private void picb_gametab_Click(object sender, EventArgs e)
        {
            btn_games_Click(sender, e);
        }

        private void picb_karaokeplay2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["karaoke"];
            ((karaoke)f).pbStop_Click(sender, e);
            ((karaoke)f).picb_playdemo2_Click(sender, e);
            lbl_kposition.Text = "2";
            picb_Visualize.Visible = true;
            picb_karaokescreen.Visible = false;
        }

        private void picb_addsongs_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.Filter = "Song Files|*.mp3;*.flac;*.wav;...";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.FileNames;
                paths = ofd.FileNames;
                for (int x = 0; x < files.Length; x++)
                {
                    listb_track.Items.Add(files[x]);
                }
                if(listb_track.Items.Count == 1)
                {
                    panel_song11.Visible = true;
                }
                else if(listb_track.Items.Count == 2)
                {
                    panel_song11.Visible = true;
                    panel_song12.Visible = true;
                }
                else if(listb_track.Items.Count == 3)
                {
                    panel_song11.Visible = true;
                    panel_song12.Visible = true;
                    panel_song13.Visible = true;
                }
            }
        }
    }
}
