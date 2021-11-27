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
using QuanLyThucAn.From;
using System.Threading;

namespace QuanLyThucAn
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public frmMain()
        {
            InitializeComponent();
        }
        void act_frm(XtraForm frm, string text_frm, string name_frm)
        {
            if (check_exit(frm) == false)
            {
                frm.MdiParent = this;
                frm.Text = text_frm;
                frm.Show();
            }

        }
        bool check_exit(XtraForm form)
        {
            foreach (var child in MdiChildren)
            {
                if (form.Name == child.Name)
                {
                    child.Activate();
                    return true;
                }
            }
            return false;
        }

        private void aceMonAn_Click(object sender, EventArgs e)
        {
           
        }
        private void vc_Load(object sender, EventArgs e)
        {
            var f = new frmDatMon();
            act_frm(f, f.Text, f.Name);
        }



        private void aceMonAn_Click_1(object sender, EventArgs e)
        {
            var f = new frmLoaiTA_ThucAn();
            act_frm(f, f.Text, f.Name);
        }

        private void aceKhachHang_Click(object sender, EventArgs e)
        {
            var f = new frmKhachHang();
            act_frm(f, f.Text, f.Name);
        }

        private void aecDatMon_Click(object sender, EventArgs e)
        {
            var f = new frmDatMon();
            act_frm(f, f.Text, f.Name);
        }

        private void aceDangXuat_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(openLoginForm));
            t.SetApartmentState(ApartmentState.STA);
            this.FormClosing -= frmMain_FormClosing;
            if (XtraMessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                t.Start();
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
        public static void openLoginForm()
        {
            Application.Run(new frmLogin());
        }
    }
}