using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using System.Windows.Forms;

namespace QuanLyThucAn.Report
{
    public partial class RpHoaDon : DevExpress.XtraReports.UI.XtraReport
    {
        public RpHoaDon()
        {
            InitializeComponent();
        }
        connect conn = new connect();
        public void cre_hoadon(string id_hoadon)
        {
            DataTable dt = new DataTable();
            dt = conn.ex_data(string.Format(
                "SELECT doan.TenThucAn , ttpb.SoLuong , pb.ThanhTien , pb.NgayLapPhieu , kh.TenKhachHang , tk.hovaten  "+
                " FROM phieuban pb , ttpb , doan , khachhang kh , taikhoan tk WHERE pb.id_PhieuBan = ttpb.id_TTPB and "+
                "doan.id_ThucAn = ttpb.id_DoAn and pb.id_KhachHang = kh.id_KhachHang and pb.id_TaiKhoan = tk.id_taikhoan "+
                "and pb.id_PhieuBan = '{0}'",id_hoadon));
            
            BeginInit();
            int i = 0;
            lb_ma.Text += id_hoadon;
            XRTableCell cellTenSp;
            XRTableCell cellSoluong;

            foreach (DataRow dr in dt.Rows)
            {
                if (i == 0)
                {
                    xrCell_MaHoaDon = new XRTableCell();
                    cellTenSp = new XRTableCell();
                    cellTenSp.WidthF = float.Parse("200");
                    cellSoluong = new XRTableCell();
                    cellSoluong.WidthF = float.Parse("200");
                    xrRow_HoaDon = new XRTableRow();
                    xrCell_MaHoaDon.Text = "Số lượng";
                    cellTenSp.Text = string.Format("        {0}      ", "Tên món ăn");
                    cellSoluong.Text = string.Format("        {0}      ", "Số lượng");
                    xrCell_MaHoaDon.Text = i.ToString();
                    xrRow_HoaDon.Cells.Add(xrCell_MaHoaDon);
                    xrRow_HoaDon.Cells.Add(cellTenSp);
                    xrRow_HoaDon.Cells.Add(cellSoluong);
                    xrHoaDon.Rows.Add(xrRow_HoaDon);
                    lb_kh.Text += dr["TenKhachHang"].ToString();
                    lb_tien.Text += dr["ThanhTien"].ToString();

                }
                i++;
                xrCell_MaHoaDon = new XRTableCell();
                cellTenSp = new XRTableCell();
                cellTenSp.WidthF = float.Parse("200");
                cellSoluong = new XRTableCell();
                cellSoluong.WidthF = float.Parse("200");
                xrRow_HoaDon = new XRTableRow();
                xrCell_MaHoaDon.Text = i.ToString();
                cellTenSp.Text = string.Format("        {0}      ", dr["TenThucAn"].ToString());
                cellSoluong.Text = string.Format("        {0}      ", dr["SoLuong"].ToString());
                xrCell_MaHoaDon.Text = i.ToString();
                xrRow_HoaDon.Cells.Add(xrCell_MaHoaDon);
                xrRow_HoaDon.Cells.Add(cellTenSp);
                xrRow_HoaDon.Cells.Add(cellSoluong);
                xrHoaDon.Rows.Add(xrRow_HoaDon);
                
               
            }
            lb_ngayban.Text += DateTime.Now.ToShortDateString();
            EndInit();
        }
    }
}
