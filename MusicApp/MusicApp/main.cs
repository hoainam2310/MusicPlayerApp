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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
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
            slide_volume.Value = 0;
        }

        private void picb_maxvol_Click(object sender, EventArgs e)
        {
            slide_volume.Value = 100;
        }

        private void txt_search_Click(object sender, EventArgs e)
        {
            txt_search.Text = "";
        }
    }
}
