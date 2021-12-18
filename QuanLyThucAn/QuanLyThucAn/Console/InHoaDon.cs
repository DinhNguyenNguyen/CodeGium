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

namespace QuanLyThucAn.Console
{
    public partial class InHoaDon : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public InHoaDon()
        {
            InitializeComponent();
        }
        public void cre_print(string id)
        {
            var inReprot = new QuanLyThucAn.Report.RpHoaDon();
            inReprot.cre_hoadon(id);
            documentViewer1.DocumentSource = inReprot;
            inReprot.CreateDocument();
        }
        private void InHoaDon_Load(object sender, EventArgs e)
        {
        }
    }
}