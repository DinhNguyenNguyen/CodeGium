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
    public partial class frmnhanvien : Form
    {
        public frmnhanvien()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txt_pass.PasswordChar == '*')
            {
                button6.Text = "ẩn";
                txt_pass.PasswordChar = '\0';
            }
            else
            {
                button6.Text = "hiện";
                txt_pass.PasswordChar = '*';
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
          txt_id.Text =    Class.Csdl_sys.Creater_id("taikhoan", "matk", "TK");
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string cmd = string.Format("insert into taikhoan values('{0}',N'{1}',{2},N'{3}',{4},'{5}','{6}','{7}','{8}',null)",
                txt_id.Text,txt_name.Text,1,gioitinh,txt_sdt.Text,txt_email.Text,txt_diachi.Text,txt_user.Text,txt_pass.Text);
         //   txt_sdt.Text = cmd;
            try
            {
                Class.Csdl_sys.ex_data(cmd);
                Class.Setting_sys.mess("Thêm nhân thành công !");

            }
            catch (Exception)
            {
                Class.Setting_sys.mess("Thêm nhân viên thất bại !");
            }
            txt_sdt.Text = cmd;

        }

        private void frmnhanvien_Load(object sender, EventArgs e)
        {
            DataTable dt = Class.Csdl_sys.ex_data(string.Format("select matk as 'Mã Nhân Viên' ,  tentk as 'Tên Nhân viên', gioitinh as 'Giới tính' , sdt as 'Sđt' , email , diachi as 'Địa chỉ' , taikhoan as 'Tên đăng nhập' , matkhau as 'Mật khẩu' from taikhoan "));
            gv_nhanvien.DataSource = dt;
            for (int i = 0; i < gv_nhanvien.Columns.Count; i++)
            {
                gv_nhanvien.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        string gioitinh;
        private void gv_nhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow gv = gv_nhanvien.Rows[e.RowIndex];
            txt_id.Text = gv.Cells[0].Value.ToString();
            txt_name.Text = gv.Cells[1].Value.ToString();
            txt_diachi.Text = gv.Cells[0].Value.ToString();
            txt_email.Text = gv.Cells[0].Value.ToString();
            txt_name.Text = gv.Cells[0].Value.ToString();
            txt_pass.Text = gv.Cells[0].Value.ToString();
             gioitinh = (gv.Cells[2].Value.ToString() == "Nam") ? "Nam" : "Nữ";
            rbtn_nam.Checked = (gioitinh == "Nam") ? true : false;
            rbtn_nu.Checked = (gioitinh == "Nữ") ? true : false;         
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            string cmd = string.Format("update taikhoan set  = '{0}', = {1}, = {2}, = {3}, = {4}, = {5})");
            try
            {
                Class.Csdl_sys.ex_data(cmd);
                Class.Setting_sys.mess("Sửa nhân thành công !");

            }
            catch (Exception)
            {
                Class.Setting_sys.mess("Sửa nhân viên thất bại !");
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            string cmd = string.Format("delete taikhoan  where = '{0}' ",txt_id.Text);
            try
            {
                Class.Csdl_sys.ex_data(cmd);
                Class.Setting_sys.mess("Xoá nhân thành công !");

            }
            catch (Exception)
            {
                Class.Setting_sys.mess("Xoá nhân viên thất bại !");
            }
        }

        private void rbtn_nam_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            gioitinh = rb.Text;
        }
    }
}
