using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace MusicPlayer
{
    class Cl_LayDuLieu
    {
        public SqlConnection KetNoi = new SqlConnection();
        public void NgatKN()
        {
            KetNoi.Close();
        }
        public void TaoKN()
        {
            try
            {
                if (KetNoi.State == ConnectionState.Open)
                    NgatKN();
                KetNoi.ConnectionString = ConfigurationManager.ConnectionStrings["AppChuoiKN"].ConnectionString;
                KetNoi.Open();
                //MessageBox.Show("OK");
            }
            catch
            {
                MessageBox.Show("Không kết nối được CSDL");
            }
        }

        public DataTable LayDuLieu(string CauLenhSQL)
        {
            TaoKN();
            SqlDataAdapter da = new SqlDataAdapter(CauLenhSQL,KetNoi);
            DataTable dt = new DataTable();
            da.Fill(dt);
            NgatKN();
            return dt;
        }
        public string CatChuoi(string ChuoiCanCat, string Khoa, int ViTriLay)
        {   
            string [] tam=ChuoiCanCat.Split(new[] { Khoa }, StringSplitOptions.None);
            return tam[ViTriLay]; 
        }
        public int LaChuCoDau(string str)
        {
            string tam = "ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệếìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵýĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ";
            for(int i=0;i<str.Length;i++)
                for (int j = 0; j < tam.Length; j++)      
                    if (str[i] == tam[j])
                        return 1;
            return 0;  
        }
    }
}
