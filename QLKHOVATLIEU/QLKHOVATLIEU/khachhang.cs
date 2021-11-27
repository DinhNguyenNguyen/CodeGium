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
    public partial class frmkhachhang : Form
    {
        public frmkhachhang()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmkhachhang_Load(object sender, EventArgs e)
        {
            DataTable dt = Class.Csdl_sys.ex_data("select  k.MaKH as 'Mã khách hàng' , k.TenKH as 'Tên khách hàng' , k.NgaySinh as 'Ngày sinh' , k.SDT as 'Số điện thoại', k.DiaChi as 'Địa chỉ' , k.Email from KhachHang k ");
            gv_kh.DataSource = dt;
            for(int i = 0; i < gv_kh.Columns.Count; i++)
            {
                gv_kh.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void gv_kh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            txt_id.Text = Class.Csdl_sys.Creater_id("khachhang","makh","KH");
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
         
            string cmd = string.Format("insert into khachhang  values ('{0}',N'{1}','{2}',{3},N'{4}','{5}')",
                txt_id.Text,txt_name.Text,dt_ngaysinh.Value.ToShortDateString(),txt_sdt.Text,txt_diachi.Text,txt_email.Text);
            try
            {
                Class.Csdl_sys.ex_cmd(cmd);
                //  txt_id.Text = cmd;
                Class.Setting_sys.mess("Tạo khách hàng thành công !");
                frmkhachhang_Load(sender, e);
            }
            catch (Exception ex)
            {
                Class.Setting_sys.mess("Tạo Khách hàng thất bại !");
            }
        }
    }
}
