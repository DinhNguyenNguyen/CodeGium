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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        void check_login()
        {

        }
        public static string  id_user_name ;  // mã người đăng nhập
        private void Form1_Load(object sender, EventArgs e)
        {
            if (Class.Setting_sys.check_log_file("log_login.txt") == false) {
                var frm = new Dangnhap();
                this.Hide();
                frm.Show();
                timer1.Start();

            }
            else
            {
                foreach(char i in Class.Setting_sys.get_val_log_file("log_login.txt"))
                {
                    if( i == ',')
                    {
                        id_user_name = Class.Csdl_sys.ex_data_tring(string.Format("select matk from taikhoan where taikhoan = '{0}'", id_user_name));
                        break;
                    }
                    id_user_name += i.ToString().Trim();
                }
            }
            name_login.Text = Class.Csdl_sys.ex_data_tring(string.Format("select tentk from taikhoan where matk = '{0}'", id_user_name));
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frm = new Dangnhap();
            frm.Show();
            timer1.Start();
        }

        private void tssanpham_Click(object sender, EventArgs e)
        {
            frmsanpham frm = new frmsanpham();
            if (check_mdi(frm) == false)
            {
                frm.MdiParent = this;
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
          
        }
        public bool check_mdi(Form form)
        {
            foreach (var child in MdiChildren)
            {
                if (form.Name == child.Name)
                {
                    child.Activate();
                    return true;
                }
            } return false;
        }
       

        private void tsloaisanpham_Click(object sender, EventArgs e)
        {
            LoaiSanPham frm = new LoaiSanPham();

            if (check_mdi(frm) == false)
            {
                frm.MdiParent = this;
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
        }

        private void tskhachhang_Click(object sender, EventArgs e)
        {
            frmkhachhang frm = new frmkhachhang();
           
            if (check_mdi(frm) == false)
            {
                frm.MdiParent = this;
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
        }

        private void tsnhanvien_Click(object sender, EventArgs e)
        {
            frmnhanvien frm = new frmnhanvien();
         
            if (check_mdi(frm) == false)
            {
                if (Class.Csdl_sys.check_admin(id_user_name) == true)
                {
                    frm.MdiParent = this;
                    frm.Dock = DockStyle.Fill;
                    frm.Show();
                }
                else
                {
                    Class.Setting_sys.mess("Bạn không có quyền try cập vào form này !");
                }
            }



        }

        private void hhToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void ghhToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tsphieunhap_Click(object sender, EventArgs e)
        {
            frmphieunhap frm = new frmphieunhap();
          
            if (check_mdi(frm) == false)
            {
                frm.MdiParent = this;
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
        }
        private void tshoadon_Click(object sender, EventArgs e)
        {
            frmhoadon frm = new frmhoadon();
            frm.MdiParent = this;
            frm.Show();
        }
       

        private void tsHoaDon_Click(object sender, EventArgs e)
        {
            frmhoadon frm = new frmhoadon();
           
            if (check_mdi(frm) == false)
            {
                frm.MdiParent = this;
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
        }

        private void tskhohang_Click(object sender, EventArgs e)
        {
            frmkhohang frm = new frmkhohang();
           
            if (check_mdi(frm) == false)
            {
                frm.MdiParent = this;
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
        }

        private void tstracuu_Click(object sender, EventArgs e)
        {
            frmtracuu frm = new frmtracuu();
           
            if (check_mdi(frm) == false)
            {
                frm.MdiParent = this;
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
        }
        public static bool log_login ;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (log_login == true)
            {
                log_login = false;
                this.Show();
                timer1.Stop();
            }
        }
        

       
       
    }
}
