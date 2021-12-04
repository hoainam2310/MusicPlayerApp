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
        public mainmenu()
        {
            InitializeComponent();
            slide_volume.Value = 50;
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
            this.Close();
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
            if(listb_track.SelectedIndex < listb_track.Items.Count-1)
            {
                listb_track.SelectedIndex = listb_track.SelectedIndex + 1;
            }
        }

        private void pb_back_Click(object sender, EventArgs e)
        {
            if (listb_track.SelectedIndex>0)
            {
                listb_track.SelectedIndex = listb_track.SelectedIndex - 1;
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

        private void btn_savesettings_Click(object sender, EventArgs e)
        {
            if(cbb_language.Text=="Vietnamese")
            {
                lb_bmusic.Text = "Nhạc nền";
                lb_startwindow.Text = "Khởi động cùng Window";
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
                lb_startwindow.Text = "Start with Windows";
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
            if(cbb_colortheme.Text == "Dark")
            {
                panel_SideBar.BackColor = Color.SlateGray;
                tab_album.BackColor = Color.SlateGray;
                pic_settings.BackColor = Color.SlateGray;
                panel_allsongs.BackColor = Color.SlateGray;
                pic_settings.BackColor = Color.SlateGray;
                picb_search.BackColor = Color.SlateGray;
                tab_song.BackColor = Color.SlateGray;
                tab_karaoke.BackColor = Color.SlateGray;
                tab_settings.BackColor = Color.SlateGray;
                btn_songs.BackColor = Color.SlateGray;
                btn_albums.BackColor = Color.SlateGray;
                btn_karaoke.BackColor = Color.SlateGray;
                btn_settings.BackColor = Color.SlateGray;
                lb_color.BackColor=Color.SlateGray;
                lb_language.BackColor = Color.SlateGray;
                lb_font.BackColor = Color.SlateGray;
                lb_bmusic.BackColor = Color.SlateGray;
                lb_startwindow.BackColor = Color.SlateGray;
            }
            else if(cbb_colortheme.Text == "Light")
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
                lb_startwindow.BackColor = Color.WhiteSmoke;
            }
            else
            {
                MessageBox.Show("Error/ Lỗi");
            }
        }

        private void btn_font_Click(object sender, EventArgs e)
        {
            if(fontDialog1.ShowDialog() == DialogResult.OK)
            {
                lb_bmusic.Font = fontDialog1.Font;
                lb_startwindow.Font = fontDialog1.Font;
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
            player.URL = listb_track.Items[0].ToString();
            player.Ctlcontrols.play();
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
            }
        }

    }
}
