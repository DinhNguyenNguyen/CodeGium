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
        void load_PhieuBan()
        {
            gc_phieuban.DataSource = conn.ex_data("SELECT p.id_PhieuBan , k.TenKhachHang , p.ThanhTien , p.NgayLapPhieu , t.id_taikhoan as 'NguoiLapPhieu' FROM phieuban p , khachhang k , taikhoan t where k.id_KhachHang = p.id_KhachHang and t.id_taikhoan = p.id_TaiKhoan");
        }
        DataTable dt;
        void load_TTPhieuBan(string id_pb)
        {
            
            dt = conn.ex_data(string.Format("select d.TenThucAn , d.gia , d.URL , tt.SoLuong from ttpb tt , phieuban p , doan d where d.id_ThucAn = tt.id_DoAn and p.id_PhieuBan = tt.id_TTPB and tt.id_TTPB = '{0}' ",id_pb));
            dt.Columns.Add("Anh", typeof(byte[]));
            foreach (DataRow dr in dt.Rows)
            {
                dr["Anh"] = cover_img(Image.FromFile(string.Format(@"{0}\SRC\Img\{1}",Application.StartupPath,dr["URL"])));
                dt.AcceptChanges();
                dr.SetModified();
            }
            gc_ttphieuban.DataSource = dt;
        }
        byte[] cover_img(Image img)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }
        private void frmDatMon_Load(object sender, EventArgs e)
        {
            loadLKKH();
            createDTOT();
            load_PhieuBan();
            dt = new DataTable();
            
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
                string id = conn.creatId("TM", "select * from ttpb");
                foreach (DataRow dr in dtOrther.Rows)
                {
                   // conn.creatId();

                    string madaoAn = dr["MaMonAn"].ToString(),
                           soluong = dr["SoLuong"].ToString(),
                           thanhtien = dr["ThanhTien"].ToString();
                    try
                    {
                        conn.ex_cmd(string.Format("insert into ttpb values('{0}','{1}',{2})", id, madaoAn, soluong));
                        //textEdit1.Text += string.Format("insert into ttpb values('{0}','{1}',{2})", id, madaoAn, soluong);


                    }
                    catch(Exception) { }
                }
              //  XtraMessageBox.Show(lkkh.EditValue.ToString());
                conn.ex_cmd(string.Format("insert into phieuban values('{0}','{1}','{2}',{3},'{4}')", id, lkkh.EditValue, frmLogin.mataikhoan, lb_thanhtien.Text, DateTime.Now.ToString("yyyy/MM/dd")));
                
                if(XtraMessageBox.Show("Lập phiêu thành công\nBạn có muốn in phiếu không ?","Hệ thống",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    set_sys.mess("In cc có lm cái report đâu in , in vô cl à =)");
                }
                load_PhieuBan();
                loadLKKH();
                gc_ttphieuban.DataSource = null;
            }
        }

        private void gv_phieuban_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            load_TTPhieuBan(gv_phieuban.GetRowCellDisplayText(e.RowHandle, "id_PhieuBan"));
        }
      
    }
    
}