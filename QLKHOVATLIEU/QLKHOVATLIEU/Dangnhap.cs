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
    public partial class Dangnhap : Form
    {
        public Dangnhap()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user_name = txttaikhoan.Text, pass = txtmatkhau.Text,
              cmd = string.Format("select taikhoan from taikhoan where taikhoan = '{0}' and matkhau = '{1}'", user_name, pass),
              log = string.Format("{0},{1},", user_name, pass);

            if (Csdl_sys.check_val(cmd) == true)
            {
                
                if (check_log.Checked == true)
                {
                    Setting_sys.log_save_file("log_login.txt", log);
                }
                else
                {
                    Setting_sys.log_save_file("log_login.txt", "");
                    
                }
                Setting_sys.mess("Đăng nhập thành công !");
                QLKHOVATLIEU.frmMain.id_user_name = Class.Csdl_sys.ex_data_tring(string.Format(
                        "select matk  from taikhoan where tentk = '{0}'", txttaikhoan.Text));
                QLKHOVATLIEU.frmMain.log_login = true;
                this.Hide();
            }
            else
            {
                Setting_sys.mess("Tên đăng nhập hoặc mật khẩu không chính xác !");
            }
        }

        private void Dangnhap_Load(object sender, EventArgs e)
        {
            string str = "";
            int count = 0;
            if (Setting_sys.check_log_file("log_login.txt") == true)
            {
                foreach (char i in Setting_sys.get_val_log_file("log_login.txt"))
                {
                    if (i == ',')
                    {
                        if (count == 0)
                        {
                            txttaikhoan.Text = str;
                        }
                        else
                        {
                            txtmatkhau.Text = str;
                        }
                        count++;
                        str = "";
                    }
                    else
                    {
                        str += i.ToString();
                    }
                }
            }
        }

        private void Dangnhap_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Dangnhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
