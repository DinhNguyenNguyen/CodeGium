using QLKHOVATLIEU.Class;
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
    public partial class LoaiSanPham : Form
    {
        public LoaiSanPham()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmloaisanpham_Load(object sender, EventArgs e)
        {
            string cmd = string.Format("select l.MaLoaiSanPham as 'Mã loại sản phẩm' , l.TenloaiSanPham as 'Tên loại sản phẩm' , t.TenTK as 'Tên nhân viên' , t.MaTK as 'Mã nhân viên'   from loaisanpham l ,  TaiKhoan t where t.MaTK  = l.MaNV");
            gv_loaisp.DataSource = Csdl_sys.ex_data(cmd);
            this.gv_loaisp.Columns[0].Width = 200;
            this.gv_loaisp.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.gv_loaisp.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.gv_loaisp.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            txt_id.Enabled = false;
            btn_creater_id_Click(sender, e);
        }

        private void btn_creater_id_Click(object sender, EventArgs e)
        {
           txt_id.Text =  Class.Csdl_sys.Creater_id("loaisanpham", "maloaisanpham", "LS");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cmd = string.Format("insert into loaisanpham  values ('{0}',N'{1}','{2}')", txt_id.Text, txt_name.Text, QLKHOVATLIEU.frmMain.id_user_name.Trim());
            try
            {
                Class.Csdl_sys.ex_cmd(cmd);
              //  txt_id.Text = cmd;
                Class.Setting_sys.mess("Tạo Loại sản phẩm thành công !");
                frmloaisanpham_Load(sender, e);
            }
            catch(Exception ex)
            {
                Class.Setting_sys.mess("Tạo Loại sản phẩm thất bại !");
            }
        }

        private void gv_loaisp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = gv_loaisp.Rows[e.RowIndex];
            txt_id.Text = row.Cells[0].Value.ToString();
            txt_name.Text = row.Cells[1].Value.ToString();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            string cmd = string.Format("update loaisanpham set tenloaisanpham = N'{0}' where maloaisanpham = '{1}'", txt_name.Text,txt_id.Text);
         //   txt_name.Text = cmd;
            try
            {
                Class.Csdl_sys.ex_cmd(cmd);
               // txt_id.Text = cmd;
                Class.Setting_sys.mess("Sửa Loại sản phẩm thành công !");
                frmloaisanpham_Load(sender, e);
            }
            catch (Exception ex)
            {
                Class.Setting_sys.mess("Sửa Loại sản phẩm thất bại !");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string cmd = string.Format("delete loaisanpham where maloaisanpham = '{0}'",txt_id.Text);

            try
            {
                Class.Csdl_sys.ex_cmd(cmd);
              //  txt_id.Text = cmd;
                if (MessageBox.Show("Bạn có chắc chấn muốn xoá loại sản phẩm này ?", "Hệ thống", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Class.Setting_sys.mess("Xoá Loại sản phẩm thành công !");
                    frmloaisanpham_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                Class.Setting_sys.mess("Xoá Loại sản phẩm thất bại !");
            }
        }
    }
}
