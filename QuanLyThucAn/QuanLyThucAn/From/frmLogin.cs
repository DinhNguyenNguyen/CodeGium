using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QuanLyThucAn.From
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        connect con = new connect();
        //gán biến mặc định trc cho tiện
        private const string MATK = "id_taikhoan";
        private const string HOVATEN = "hovaten";
        //private const string TENNV = "TENNV";
        private const string TENTK = "username";
        private const string MATKHAU = "password";
        private const string MACV = "id_chucvu";
        private const string TENCV = "tenchucvu";


        //biến liên thông
        public static string username;
        public static string password;
        public static string fullname;
        public static string mataikhoan;
        public static string macv;
        public static string tencv;
        public static string manv;


        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtPass.Text = null;
            txtUsername.Text = null;
            txtUsername.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtUsername.EditValue == null)
            {
                XtraMessageBox.Show("Bạn chưa nhập tên đăng nhập \r\nVui lòng nhập!", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsername.Focus();
                return;
            }
            if (txtPass.EditValue == null)
            {
                XtraMessageBox.Show("Bạn chưa nhập mật khẩu \r\nVui lòng nhập!", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPass.Focus();
                return;
            }

            try
            {
                mataikhoan = getInfo(MATK);
                if (mataikhoan != "")
                {
                    username = getInfo(TENTK);
                    password = getInfo(MATKHAU);
                    fullname = getInfo(HOVATEN);
                    mataikhoan = getInfo(MATK);
                    macv = getInfo(MACV);
                    tencv = getInfo(TENCV);
                  
                    frmMain frm = new frmMain();
                    this.Hide();
                    frm.ShowDialog();
                    this.Dispose();
                }
                else
                {
                    XtraMessageBox.Show("Thông tin tài khoản hoặc mật khẩu không đúng \r\nVui lòng đăng nhập lại!", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi!" + ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void txtPass_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (txtPass.Properties.UseSystemPasswordChar)
            {
                txtPass.Properties.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.Properties.UseSystemPasswordChar = true;
            }
        }

        public string getInfo(string info)
        {
            string tentk = txtUsername.EditValue.ToString();
            string pass = txtPass.EditValue.ToString();

            string id = "";
            try
            {
                //
                string sqlR = string.Format("select * from TAIKHOAN as tk, chucvu as cv where user_name='{0}' and password= '{1}' and  tk.id_chucvu= cv.id_chucvu", tentk,con.CreateMD5(pass).ToUpper());
                DataTable dt = new DataTable();
                
                dt = con.ex_data(sqlR);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        id = dr[info].ToString();
                    }
                }
            }
            catch (Exception)
            {
                
                id = "";
            }
            return id;
        }
    }
}