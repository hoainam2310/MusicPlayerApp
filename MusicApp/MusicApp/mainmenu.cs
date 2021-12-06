using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicApp
{
    public partial class mainmenu : Form
    {
        DataTable dt = new DataTable();
        public mainmenu()
        {
            InitializeComponent();
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
        }
        private void btn_albums_Click(object sender, EventArgs e)
        {
            bunifuVSlider1.Value = 68;
            tab_items.SetPage(1);
        }
        private void btn_karaoke_Click(object sender, EventArgs e)
        {
            bunifuVSlider1.Value = 32;
            tab_items.SetPage(2);
        }
        private void btn_settings_Click(object sender, EventArgs e)
        {
            bunifuVSlider1.Value = 0;
            tab_items.SetPage(3);
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
            player.Ctlcontrols.pause();
        }

        private void pb_play_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.play();
        }

        private void pb_next_Click(object sender, EventArgs e)
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
        }

        private void pb_back_Click(object sender, EventArgs e)
        {
            if(lbl_position.Text == "2")
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
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(player.playState==WMPLib.WMPPlayState.wmppsPlaying)
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

        private void slide_volume_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {
            player.settings.volume = slide_volume.Value;
        }

        private void slider_timeplaymusic_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {
            player.Ctlcontrols.currentPosition = slider_timeplaymusic.Value;
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
            player.URL = @"Tracks\Another One Bites The Dust.flac";
            player.Ctlcontrols.play();
            lbl_position.Text = "1";
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

        private void picb_addsong1_Click(object sender, EventArgs e)
        {
            player.URL = listb_track.Items[0].ToString();
            player.Ctlcontrols.play();
        }

        private void picb_addsong2_Click(object sender, EventArgs e)
        {
            player.URL = listb_track.Items[1].ToString();
            player.Ctlcontrols.play();
        }

        private void picb_addsong3_Click(object sender, EventArgs e)
        {
            player.URL = listb_track.Items[2].ToString();
            player.Ctlcontrols.play();
        }

        private void picb_play2_Click(object sender, EventArgs e)
        {
            picb_currentsong.Image = picb_song2.Image;
            player.URL = @"Tracks\Don't Stop Me Now.flac";
            player.Ctlcontrols.play();
            lbl_position.Text = "2";
        }

        private void picb_play3_Click(object sender, EventArgs e)
        {
            picb_currentsong.Image = picb_song3.Image;
            player.URL = @"Tracks\Dynasties Dystopia.flac";
            player.Ctlcontrols.play();
            lbl_position.Text = "3";
        }

        private void picb_play4_Click(object sender, EventArgs e)
        {
            picb_currentsong.Image = picb_song4.Image;
            player.URL = @"Tracks\Easy On Me.flac";
            player.Ctlcontrols.play();
            lbl_position.Text = "4";
        }

        private void picb_play5_Click(object sender, EventArgs e)
        {
            picb_currentsong.Image = picb_song5.Image;
            player.URL = @"Tracks\Enemy (feat. J.I.D).flac";
            player.Ctlcontrols.play();
            lbl_position.Text = "5";
        }

        private void picb_play6_Click(object sender, EventArgs e)
        {
            picb_currentsong.Image = picb_song6.Image;
            player.URL = @"Tracks\Guns for Hire.flac";
            player.Ctlcontrols.play();
            lbl_position.Text = "6";
        }

        private void picb_play7_Click(object sender, EventArgs e)
        {
            picb_currentsong.Image = picb_song7.Image;
            player.URL = @"Tracks\Love Me Like There Is No Tomorrow.flac";
            player.Ctlcontrols.play();
            lbl_position.Text = "7";
        }

        private void picb_play8_Click(object sender, EventArgs e)
        {
            picb_currentsong.Image = picb_song8.Image;
            player.URL = @"Tracks\Somebody To Love.flac";
            player.Ctlcontrols.play();
            lbl_position.Text = "8";
        }

        private void picb_play9_Click(object sender, EventArgs e)
        {
            picb_currentsong.Image = picb_song9.Image;
            player.URL = @"Tracks\The Airbuster.flac";
            player.Ctlcontrols.play();
            lbl_position.Text = "9";
        }

        private void picb_play10_Click(object sender, EventArgs e)
        {
            picb_currentsong.Image = picb_song10.Image;
            player.URL = @"Tracks\Woman Like Me.flac";
            player.Ctlcontrols.play();
            lbl_position.Text = "10";
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
                picb_addsong1.Visible = true;
                picb_addsong2.Visible = true;
                picb_addsong3.Visible = true;
            }
        }

    }
}
