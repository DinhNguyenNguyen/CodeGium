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
    public partial class frmhoadon : Form
    {
        public frmhoadon()
        {
            InitializeComponent();
        }
        DataTable dt;
        DataTable hoadon(string id , string name)
        {          
            DataRow dr = dt.NewRow();
            dt.Columns.Add("Mã sản phẩm", typeof(String));
            dt.Columns.Add("Tên sản phẩm", typeof(String));
            dr["Mã sản phẩm"] = id;
            dr["Tên sản phẩm"] = name;
            dt.Rows.Add(dr);
            return dt;
        }
        private void frmhoadon_Load(object sender, EventArgs e)
        {
           
        }
        public static string id_sp , ma_sp;
        private void btn_sanpham_Click(object sender, EventArgs e)
        {
            timer1.Start();
            //var frm = new ;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(id_sp != null)
            {
                gv_hoadon.DataSource = hoadon(id_sp, Class.Csdl_sys.ex_data_tring(string.Format("select tensp from sanpham where masp = '{0}'", id_sp)));
            }
        }
    }
}
