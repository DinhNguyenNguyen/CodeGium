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
        connect conn = new connect();
        DataTable dt_da , dt_loaiDa;
       
       void cre_da()
        {
            dt_loaiDa = new DataTable();
            dt_da = new DataTable();
            dt_loaiDa.Columns.Add("TenTL");
            dt_da.Columns.Add("src", typeof(String));
            dt_da.Columns.Add("gia", typeof(String));
            dt_da.Columns.Add("tenthucan", typeof(String));
        }
        void load_loaiDa()
        {
            string cmd = "SELECT ld.id_LoaiThucAn , ld.TenLoaiThucAn as 'TenTL'  from loaidoan ld";
            dt_loaiDa = conn.ex_data(cmd);
            int i = 0;
            dt_loaiDa.Columns.Add("stt",typeof(String));
            foreach(DataRow dr in dt_loaiDa.Rows)
            {
                i++;
                dr["stt"] = i.ToString();
                dt_loaiDa.AcceptChanges();
                dr.AcceptChanges();
            }
            gc_loadDA.DataSource = dt_loaiDa;


        }
        void load_da(string id_loaiDA)
        {
            string more_query = (id_loaiDA != "null") ? "and ld.id_LoaiThucAn = '" + id_loaiDA+"'" : "";
            string cmd = string.Format("SELECT doan.id_ThucAn , doan.TenThucAn as 'tenthucan', doan.gia , doan.URL as 'src'  from doan , loaidoan ld where ld.id_LoaiThucAn = doan.id_LoaiThucAn {0}",more_query);
            dt_da = conn.ex_data(cmd);
            dt_da.Columns.Add("url", typeof(byte[]));
            foreach (DataRow dr in dt_da.Rows)
            {
                Image img = Image.FromFile(string.Format(@"{0}\SRC\Img\{1}", Application.StartupPath, dr["src"].ToString()));
                dr["url"] =  cover_img(img);
                dt_da.AcceptChanges();
                dr.AcceptChanges();
            }
            gc_DA.DataSource = dt_da;
        }
        byte[] cover_img(Image img)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        private void gv_loaiDA_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            string id_loadi_ta = dt_loaiDa.Rows[gv_loaiDA.FocusedRowHandle][0].ToString();
            load_da(id_loadi_ta);
        }

        private void btn_lm_Click(object sender, EventArgs e)
        {
            FrmDoAn_Load(sender,e);
        }

        private void FrmDoAn_Load(object sender, EventArgs e)
        {
            cre_da();
            load_loaiDa();
            load_da("null");
        }
    }
}