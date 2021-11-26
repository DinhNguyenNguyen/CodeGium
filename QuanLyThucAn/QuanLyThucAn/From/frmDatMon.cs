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
    public partial class frmDatMon : DevExpress.XtraEditors.XtraForm
    {
        public frmDatMon()
        {
            InitializeComponent();
        }
        connect conn = new connect();
        string sqlMonAn = "select id_ThucAn , TenThucAn ,l.tenloaithucan, gia, url from doan a, loaidoan l where l.id_loaithucan = a.id_loaithucan";

       private void loadTA()
        {
            DataTable dt = conn.ex_data(sqlMonAn);
            if(dt!= null)
            {
                gcThucAn.DataSource = dt;
            }
        }
        private void frmDatMon_Load(object sender, EventArgs e)
        {
            loadTA();
        }
    }
}