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

namespace QuanLyThucAn.From
{
    public partial class frmMainn : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public frmMainn()
        {
            InitializeComponent();
        }

        private void frmMainn_Load(object sender, EventArgs e)
        {
            
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
            var f = new frmLoaiTA_ThucAn();
            act_frm(f, f.Text, f.Name);
        }

        private void aceKhachHang_Click(object sender, EventArgs e)
        {
            var f = new cc();
            act_frm(f, f.Text, f.Name);
        }
    }
}
