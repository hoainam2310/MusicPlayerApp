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
            slide_volume.Value = 20;
        }

        private void btn_songs_Click(object sender, EventArgs e)
        {
            bunifuVSlider1.Value = 100;
            bunifuPages1.SetPage(0);
        }
        private void btn_albums_Click(object sender, EventArgs e)
        {
            bunifuVSlider1.Value = 68;
            bunifuPages1.SetPage(1);
        }
        private void btn_karaoke_Click(object sender, EventArgs e)
        {
            bunifuVSlider1.Value = 32;
            bunifuPages1.SetPage(2);
        }
        private void btn_settings_Click(object sender, EventArgs e)
        {
            bunifuVSlider1.Value = 0;
            bunifuPages1.SetPage(3);
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
