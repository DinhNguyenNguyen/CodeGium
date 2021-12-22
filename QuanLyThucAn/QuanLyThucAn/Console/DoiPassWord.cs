using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyThucAn.Console
{
    public partial class DoiPassWord : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public DoiPassWord()
        {
            InitializeComponent();
        }

        private void DoiPassWord_Load(object sender, EventArgs e)
        {

        }
        string passmoi, passmoi1;

        private void pasMoi1_TextChanged(object sender, EventArgs e)
        {
            TextEdit txt = sender as TextEdit;
         
                if(txt.Name == pasMoi.Name)
            {
                passmoi = pasMoi.Text;
            }
            else
            {
                passmoi1 = pasMoi1.Text;
            }
                if(passmoi != passmoi1)
            {
                lab_status.Text = ("Mật khẩu mới không khớp !");
            }
            else
            {
                lab_status.Text = "";
            }
        }
        connect conn = new connect();

        private void btn_changer_Click(object sender, EventArgs e)
        {
            string passc = conn.CreateMD5(pasCu.Text);
           
          if(conn.ex_data_string(string.Format("select count(*) from taikhoan where id_taikhoan = '{0}' and password = '{1}'",QuanLyThucAn.From.frmLogin.mataikhoan,passc)) != "0")
            {
                try
                {
                 
                    conn.ex_cmd(string.Format("update taikhoan set password = '{0}' where id_taikhoan = '{1}'",conn.CreateMD5(passmoi),QuanLyThucAn.From.frmLogin.mataikhoan));
                    set_sys.mess("Đổi mật khẩu thành công !");
                    this.Close();
                }
                catch (Exception)
                {
                    set_sys.mess("Đổi mật khẩu thất bại !");
                }
            }
            else
            {
                set_sys.mess("Mật khẫu cũ không chính xác !");
            }
        }
    }
}
