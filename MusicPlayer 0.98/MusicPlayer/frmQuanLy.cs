using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace MusicPlayer
{
    public partial class frmQuanLy : Form
    {
        public frmQuanLy()
        {
            InitializeComponent();
        }

        private void cmdThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        DataTable dt = new DataTable();
       
    Cl_LayDuLieu data = new Cl_LayDuLieu();
            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();
            DataTable dt3 = new DataTable();
        private void frmQuanLy_Load(object sender, EventArgs e)
        {
            
            dt1 = data.LayDuLieu("Select * From CA_SY");
            cbbCaSyThem.DataSource = dt1;
            cbbCaSyThem.DisplayMember = "TenCS";
            cbbCaSyThem.ValueMember = "MaCS";

            cbbCaSySua.DataSource = dt1;
            cbbCaSySua.DisplayMember = "TenCS";
            cbbCaSySua.ValueMember = "MaCS";

            dt2 = data.LayDuLieu("Select * From THE_LOAI");
            cbbTheLoaiThem.DataSource = dt2;
            cbbTheLoaiThem.DisplayMember = "TenTL";
            cbbTheLoaiThem.ValueMember = "MaTL";

            cbbTheLoaiSua.DataSource = dt2;
            cbbTheLoaiSua.DisplayMember = "TenTL";
            cbbTheLoaiSua.ValueMember = "MaTL";

            dt3 = data.LayDuLieu("Select * From BAI_HAT");
            cbbTenBHXoa.DataSource = dt3;     
            cbbTenBHXoa.DisplayMember = "TenBH";
            cbbTenBHXoa.ValueMember = "MaBH";

            cbbTenBHSua.DataSource = dt3;
            cbbTenBHSua.DisplayMember = "TenBH";
            cbbTenBHSua.ValueMember = "MaBH";
        }

   

        private void cmdThem_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtTenBHThem.Text.ToString() == "" || txtUrlThem.Text.ToString() == "" || cbbTheLoaiThem.Text.ToString() == "" || cbbCaSyThem.Text.ToString() == "")
                    MessageBox.Show("Chưa nhập đủ thông tin","Music Player");        
                else
                {  
                
                    string str = "[Sp_ThemBaiHat] N'" + txtTenBHThem.Text + "'," + cbbTheLoaiThem.SelectedValue + "," + cbbCaSyThem.SelectedValue+ ",N'" + txtUrlThem.Text + "'";
                    dt = data.LayDuLieu(str);
                    if (int.Parse(dt.Rows[0]["ErrCode"].ToString()) == 0)
                        MessageBox.Show(dt.Rows[0]["ErrMsg"].ToString(), "Music Player");
                    else
                        MessageBox.Show(dt.Rows[0]["ErrMsg"].ToString(), "Music Player");
                    frmQuanLy_Load(sender, e);

                }
             }
            catch { MessageBox.Show("Lỗi, tên ca sỹ hoặc tên thể loại không có trong CSDL", "Music Player");}
           
        }

        private void cmdXoa_Click(object sender, EventArgs e)
        {
            if (cbbTenBHXoa.Text.ToString() == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin", "Music Player");

            }
            else
            {
                string str = "[Sp_XoaBaiHat] N'" + cbbTenBHXoa.Text+"'";
                dt = data.LayDuLieu(str);
                if (int.Parse(dt.Rows[0]["ErrCode"].ToString()) == 0)
                    MessageBox.Show(dt.Rows[0]["ErrMsg"].ToString(), "Music Player");
                else
                    MessageBox.Show(dt.Rows[0]["ErrMsg"].ToString(), "Music Player");
                frmQuanLy_Load(sender, e);
            }
        }

        private void cbbCaSyThem_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cbbCaSyThem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbbCaSyThem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems; 
        }

        private void cbbTheLoaiThem_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cbbTheLoaiThem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbbTheLoaiThem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
        }

        private void cbbTenBHXoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cbbTenBHXoa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbbTenBHXoa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
        }

        private void cmdDuyetThem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdl = new OpenFileDialog();
            ofdl.InitialDirectory = Application.StartupPath;
            ofdl.Filter = "*mp3 | *.mp3";
            if (ofdl.ShowDialog(this) == DialogResult.OK)
                txtUrlThem.Text = ofdl.FileName;
        }

        private void cmdDuyetSua_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdl = new OpenFileDialog();
            ofdl.InitialDirectory = Application.StartupPath;
            ofdl.Filter = "*mp3 | *.mp3";
            if (ofdl.ShowDialog(this) == DialogResult.OK)
                txtUrlSua.Text = ofdl.FileName;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbbTenBHSua_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cbbTenBHSua.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbbTenBHSua.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
        }

        private void cbbCaSySua_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cbbCaSySua.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbbCaSySua.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
        }

        private void cmdCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenBHSua.Text == "" || txtUrlSua.Text == "" || cbbTheLoaiSua.Text == "" || cbbCaSySua.Text == "")
                    MessageBox.Show("Chưa nhập đủ thông tin","Music Player");        
                else
                {      
                    string str = "Sp_SuaBaiHat " + cbbTenBHSua.SelectedValue+",N'" +txtTenBHSua.Text +"'," + cbbTheLoaiSua.SelectedValue+"," +cbbCaSySua.SelectedValue+",N'"+txtUrlSua.Text +"'";
                    dt = data.LayDuLieu(str);
                    if (int.Parse(dt.Rows[0]["ErrCode"].ToString()) == 0)
                        MessageBox.Show(dt.Rows[0]["ErrMsg"].ToString(), "Music Player");
                    else
                        MessageBox.Show(dt.Rows[0]["ErrMsg"].ToString(), "Music Player");
                    frmQuanLy_Load(sender, e);

                }
             }
            catch 
            { 
                MessageBox.Show("Lỗi, tên ca sỹ hoặc tên thể loại không có trong CSDL", "Music Player");

            }
           
        }

        private void cbbTheLoaiSua_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cbbTheLoaiSua.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbbTheLoaiSua.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
        }
       
    }
}
