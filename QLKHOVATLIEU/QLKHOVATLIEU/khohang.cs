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
    public partial class frmkhohang : Form
    {
        public frmkhohang()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmkhohang_Load(object sender, EventArgs e)
        {
            gv_khohang.DataSource =  Class.Csdl_sys.ex_data("select k.MaKhoHang as 'Mã kho hàng' , k.MaNV as 'Mã nhân viên' , t.TenTK as 'Tên nhân viên' , k.TenKhoHang as 'Tên kho hàng' ,  k.SDT as 'Số điện thoại' , k.DiaChiKhoHang as 'Địa chỉ kho hàng' , k.GhiChu as 'Ghi chú' from KhoHang k , TaiKhoan t where k.MaNV = t.MaTK");
            gv_khohang.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gv_khohang.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gv_khohang.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gv_khohang.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gv_khohang.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gv_khohang.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gv_khohang.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            btn_creater_id_Click(sender, e);
            txt_id.Enabled = false;
        }

        private void btn_creater_id_Click(object sender, EventArgs e)
        {
            txt_id.Text = Class.Csdl_sys.Creater_id("khohang", "makhohang", "KHO");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void gv_khohang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = gv_khohang.Rows[e.RowIndex];
            txt_id.Text = row.Cells[0].Value.ToString();
            txt_name.Text = row.Cells[3].Value.ToString();
            txt_sdt.Text = row.Cells[4].Value.ToString(); 
            txt_addres.Text = row.Cells[5].Value.ToString();
            txt_note.Text = row.Cells[6].Value.ToString();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string cmd = string.Format("insert into khohang(makhohang,tenkhohang,manv,sdt,diachikhohang,ghichu)  values ('{0}',N'{1}','{2}',{3},N'{4}',N'{5}')", 
                txt_id.Text, txt_name.Text, QLKHOVATLIEU.frmMain.id_user_name.Trim(),txt_sdt.Text,txt_addres.Text,txt_note.Text);
            try
            {
                Class.Csdl_sys.ex_cmd(cmd);
                //  txt_id.Text = cmd;
                Class.Setting_sys.mess("Tạo Kho thành công !");
                frmkhohang_Load(sender, e);
            }
            catch (Exception ex)
            {
                Class.Setting_sys.mess("Tạo  kho thất bại !");
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            string cmd = string.Format("update khohang set tenkhohang =  N'{0}', sdt =  {1} ,diachikhohang =  N'{2}', ghichu = N'{3}' where makhohang = '{4}'",
              txt_name.Text,txt_sdt.Text,txt_addres.Text,txt_note.Text,txt_id.Text.Trim());
            txt_name.Text = cmd;
            try
            {
                Class.Csdl_sys.ex_cmd(cmd);
                //  txt_id.Text = cmd;
                Class.Setting_sys.mess("Sửa Kho thành công !");
                frmkhohang_Load(sender, e);
            }
            catch (Exception ex)
            {
                Class.Setting_sys.mess("Sửa  kho thất bại !");
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            string cmd = string.Format("delete khohang where makhohang = '{0}'", txt_id.Text);
            try
            {
                if (MessageBox.Show("Bạn có chắc chấn muốn xoá kho này ?", "Hệ thống", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Class.Csdl_sys.ex_cmd(cmd);
                    //  txt_id.Text = cmd;
                    Class.Setting_sys.mess("Xoá Kho thành công !");
                    frmkhohang_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                Class.Setting_sys.mess("Xoá  kho thất bại !");
            }
        }
    }
}
