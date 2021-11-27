using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKHOVATLIEU
{
    public partial class frmsanpham : Form
    {
        public frmsanpham()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
       public static string id_sp, name_sp;
        private void frmsanpham_Load(object sender, EventArgs e)
        {
            button2_Click(sender,e);
            DataTable dt = Class.Csdl_sys.ex_data("select s.MaSP , s.TenSP , k.TenKhoHang,  l.TenloaiSanPham, s.TenNhaCungCap  , s.DonGia  , s.SoLuong , l.MaLoaiSanPham , k.MaKhoHang from sanpham s   , KhoHang k , LoaiSanPham l where k.MaKhoHang = s.MaKhoHang and l.MaLoaiSanPham = s.MaLoaiSanPham");
            gv_sanpham.DataSource = dt;
            for (int i = 0  ; i < dt.Columns.Count - 1 ; i++)
            {
                gv_sanpham.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
           
        }

        private void gv_sanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = gv_sanpham.Rows[e.RowIndex];
            txt_id.Text = row.Cells[0].Value.ToString();
            txt_name.Text = row.Cells[1].Value.ToString();
            txt_kho.Text = null;
            txt_loaisanpham.Text = null;
            txt_nhacungcap.Text = row.Cells[4].Value.ToString();
            txt_money.Text = row.Cells[5].Value.ToString();
            txt_soluong.Text = row.Cells[6].Value.ToString();
            masp = null;
            tenkho = null;
            makho = null;
            tensp = null;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string cmd = string.Format("insert into sanpham  values ('{0}','{1}',N'{2}','{3}',N'{4}',{5},{6})", txt_id.Text,makho, txt_name.Text,
                masp,txt_nhacungcap.Text,txt_money.Text,txt_soluong.Text);
            try
            {
                Class.Csdl_sys.ex_cmd(cmd);
                //  txt_id.Text = cmd;
                Class.Setting_sys.mess("Tạo sản phẩm thành công !");
                frmsanpham_Load(sender, e);
            }
            catch (Exception ex)
            {
                Class.Setting_sys.mess("Tạo sản phẩm thất bại !");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_id.Text = Class.Csdl_sys.Creater_id("sanpham", "masp", "SP");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var frm = new Console.Pick_loaisanpham();
            frm.Show();
            timer1.Start();
        }
        public static  string tensp, masp,makho,tenkho;

        private void btn_del_Click(object sender, EventArgs e)
        {

            string cmd = string.Format("delete sanpham where masp = '{0}'", txt_id.Text, makho, txt_name.Text,
                masp, txt_nhacungcap.Text, txt_money.Text, txt_soluong.Text);
            try
            {
                if (MessageBox.Show("Bạn có chắc chấn muốn xoá sản phẩm này ?", "Hệ thống", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Class.Csdl_sys.ex_cmd(cmd);
                    //  txt_id.Text = cmd;
                    Class.Setting_sys.mess("Xoá sản phẩm thành công !");
                }
                frmsanpham_Load(sender, e);
            }
            catch (Exception ex)
            {
                Class.Setting_sys.mess("Xoá sản phẩm thất bại !");
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            string cmd = "";
            if (masp != null && makho != null) {
                 cmd = string.Format(
               "update sanpham  set tensp = N'{0}', makhohang = '{1}' , maloaisanpham = '{2}' , tennhacungcap = N'{3}' , dongia = {4} , soluong = {5} where masp = '{6}'",
                txt_name.Text , makho,masp,txt_nhacungcap.Text,txt_money.Text,txt_soluong.Text,txt_id.Text );
            }
            else
            {
                Class.Setting_sys.mess("Vui lòng chọn lại Loại sản phẩm và kho hàng mới ");
            }
           
          //  txt_money.Text = cmd;
            try
            {
                Class.Csdl_sys.ex_cmd(cmd);
               
                Class.Setting_sys.mess("Sửa sản phẩm thành công !");
                frmsanpham_Load(sender, e);
            }
            catch (Exception ex)
            {
                Class.Setting_sys.mess("Sửa sản phẩm thất bại !");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var frm = new Console.Pick_Kho();
            frm.Show();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           if(masp != null)
            {
                txt_loaisanpham.Text = Class.Csdl_sys.ex_data_tring(string.Format("select tenloaisanpham from loaisanpham where maloaisanpham = '{0}'", masp));
                timer1.Stop();
            } 
           if(makho != null)
            {
                txt_kho.Text = Class.Csdl_sys.ex_data_tring(string.Format("select tenkhohang from khohang where makhohang = '{0}'",makho));
                timer1.Stop();
            }
        }
    }
}
