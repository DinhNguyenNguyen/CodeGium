using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyThucAn.From
{
    public partial class frmMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public frmMain()
        {
            InitializeComponent();
        }
        connect conn = new connect();
        private void frmMain_Load(object sender, EventArgs e)
        {
            conn.connect_db();
        }


        private Form formCheck(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == ftype)
                {
                    return f;
                }
            }
            return null;
        }

        private void aceKhachHang_Click(object sender, EventArgs e)
        {
            //Form frm = formCheck(typeof(frmKhachHang));
            //if (frm == null)
            //{
                frmKhachHang f = new frmKhachHang();
                f.MdiParent = this;
                f.Show();
            //}
            //else
            //{
            //    frm.Activate();
            //}
        }
    }
}
