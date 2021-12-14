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
    public partial class FrmDoAn : DevExpress.XtraEditors.XtraForm
    {
        public FrmDoAn()
        {
            InitializeComponent();
        }
        DataTable dt_da;
       void cre_da()
        {
            dt_da.Columns.Add("url", typeof(byte[]));
            dt_da.Columns.Add("gia", typeof(String));
            dt_da.Columns.Add("tenthucan", typeof(String));
        }
        void load_da()
        {
            string cmd = "";
           // gc_DA.DataSource = 
        }
        byte[] cover_img(Image img)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }
        private void FrmDoAn_Load(object sender, EventArgs e)
        {

        }
    }
}