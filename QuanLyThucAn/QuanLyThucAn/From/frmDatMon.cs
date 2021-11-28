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
        string sqlKH = "SELECT * FROM khachhang";

        DataTable dtOrther;


        private void loadLKKH()
        {
            DataTable dt = conn.ex_data(sqlKH);
            if (dt != null)
            {
                lkkh.Properties.DataSource = dt;
                lkkh.Properties.DisplayMember = "TenKhachHang";
                lkkh.Properties.ValueMember = "id_KhachHang";
            }
        }

        private void createDTOT()
        {
            dtOrther = new DataTable();
            dtOrther.Columns.Add("MaMonAn",typeof(String));
            dtOrther.Columns.Add("TenMonAn", typeof(String));
            dtOrther.Columns.Add("SoLuong", typeof(String));
            dtOrther.Columns.Add("Gia", typeof(String));
            dtOrther.Columns.Add("ThanhTien", typeof(String));
        }
        DataTable add_val(string ma , string ten , string soluong , string gia , string thanhtien)
        {
            DataRow dr = dtOrther.NewRow();
            dr["MaMonAn"] = ma;
            dr["TenMonAn"] = ten;
            dr["SoLuong"] = soluong;
            dr["Gia"] = gia;
            dr["ThanhTien"] = thanhtien;
            dtOrther.Rows.Add(dr);
            return dtOrther;
        }
       
        private void frmDatMon_Load(object sender, EventArgs e)
        {
            loadLKKH();
            createDTOT();

        }

        private void btnSub_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        private void btn_DatMon_Click(object sender, EventArgs e)
        {
            
        }
        PickMonAn frm_pickMonAn;
       public static List<string> list_doAn = new List<string>();
        private void btn_chondoan_Click(object sender, EventArgs e)
        {
            frm_pickMonAn = new PickMonAn();
            frm_pickMonAn.ShowDialog();
            timer1.Start();
        }
        int thanhtien;
        private void timer1_Tick(object sender, EventArgs e)
        {
            string maDoAn = frm_pickMonAn.mada;
            if (maDoAn != null)
            {
                if(list_doAn.IndexOf(maDoAn) < 0)
                {
                    list_doAn.Add(maDoAn);
                    string tendoAn = conn.ex_data_string(string.Format("select tenthucan from doan where id_thucan = '{0}'", maDoAn));
                    int gia = int.Parse(conn.ex_data_string(string.Format("select gia from doan where id_thucan = '{0}'", maDoAn)));
                    int thanhthien_t = gia   * int.Parse(frm_pickMonAn.soluong);
                    thanhtien += thanhthien_t;
                    string soluong = frm_pickMonAn.soluong;
                    lb_thanhtien.Text = thanhtien.ToString();
                    gc_bill_thucan.DataSource = add_val(maDoAn,tendoAn,soluong,gia.ToString(),thanhthien_t.ToString());
                    timer1.Stop();
                }
            }

        }

    

        private void btn_thanhtoan_Click_2(object sender, EventArgs e)
        {
            if ((lkkh.EditValue == null) || (lkkh.EditValue.ToString().Equals("")))
            {
                set_sys.mess("Bạn chưa chọn khách hàng\r\nVui lòng chọn!");
            }
            else
            {

            }
        }
      
    }
    
}