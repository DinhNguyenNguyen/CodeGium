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
        string sqlMonAn = "select id_ThucAn , TenThucAn ,l.TenLoaiThucAn, gia, url from doan a, loaidoan l where l.id_loaithucan = a.id_loaithucan";
        string sqlKH = "SELECT * FROM khachhang";

        DataTable dtOrther;


        private void loadLKKH()
        {
            DataTable dt = conn.ex_data(sqlKH);
            if (dt != null)
            {
                lkKhachHang.Properties.DataSource = dt;
                lkKhachHang.Properties.DisplayMember = "TenKhachHang";
                lkKhachHang.Properties.ValueMember = "id_KhachHang";
            }
        }

        private void createDTOT()
        {
            dtOrther = new DataTable();
            dtOrther.Columns.Add("id_ThucAn");
            dtOrther.Columns.Add("TenThucAn");
            dtOrther.Columns.Add("gia");
            //dtOrther.Columns["gia"].DataType = typeof(Int32);
            dtOrther.Columns.Add("soluong");
            //dtOrther.Columns["soluong"].DataType = typeof(Int32);
            dtOrther.Columns.Add("thanhtien");
            //dtOrther.Columns["thanhtien"].DataType = typeof(Int32);
        }
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
            loadLKKH();
            createDTOT();
        }

        private void btnSub_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        private void btnAdd_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int row_index = gvThucAn.FocusedRowHandle;
            if ((lkKhachHang.EditValue == null) || (lkKhachHang.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Bạn chưa chọn khách hàng\r\nVui lòng chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DataRow dr = dtOrther.NewRow();
            dr["id_ThucAn"] = gvThucAn.GetRowCellValue(row_index, "id_ThucAn").ToString(); 
            dr["TenThucAn"] = gvThucAn.GetRowCellValue(row_index, "TenThucAn").ToString(); 
            dr["gia"] = gvThucAn.GetRowCellValue(row_index, "gia").ToString();
            foreach(DataRow dtr in dtOrther.Rows)
            {
                if(dtr["id_ThucAn"].Equals(gvThucAn.GetRowCellValue(row_index, "id_ThucAn").ToString()))
                {
                    dr["soluong"] = Int32.Parse(dr["SoLuong"].ToString());
                    //dr["Soluong"]= Int32.Parse(dr["soLuong"].ToString())+1;
                }
            }
            dr["thanhtien"] = 0;
            dtOrther.Rows.Add(dr);

            gridControl1.DataSource = dtOrther;
            
        }
    }
}