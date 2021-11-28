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
    public partial class frmKhachHang : DevExpress.XtraEditors.XtraForm
    {
        public frmKhachHang()
        {
            InitializeComponent(); 
        }
        connect conn = new connect();
        string sqlKH = "select * from khachhang";

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            conn.LoadDT(gcKhachHang, sqlKH);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenKH.EditValue == null || txtTenKH.EditValue.ToString().Equals(""))
            {
                XtraMessageBox.Show("Bạn chưa nhập tên khách hàng\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenKH.Focus();
                return;
            }
            if (txtNgaySinh.EditValue == null || txtNgaySinh.EditValue.ToString().Equals(""))
            {
                XtraMessageBox.Show("Bạn chưa nhập ngày sinh\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                return;
            }
            if (txtSDT.EditValue == null || txtSDT.EditValue.ToString().Equals(""))
            {
                XtraMessageBox.Show("Bạn chưa nhập số điện thoại\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSDT.Focus();
                return;
            }
            if (txtEmail.EditValue == null || txtEmail.EditValue.ToString().Equals(""))
            {
                XtraMessageBox.Show("Bạn chưa nhập email\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.Focus();
                return;
            }
            if (txtDiaChi.EditValue == null || txtDiaChi.EditValue.ToString().Equals(""))
            {
                XtraMessageBox.Show("Bạn chưa nhập ngày sinh\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiaChi.Focus();
                return;
            }

            string sqlI = string.Format("INSERT INTO khachhang(id_KhachHang,id_TaiKhoan, TenKhachHang, NgaySinh, SDT, Email, DiaChi)  VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", conn.creatId("KH", sqlKH), frmLogin.mataikhoan, txtTenKH.EditValue.ToString(), Convert.ToDateTime(txtNgaySinh.EditValue.ToString()).ToString("yyyy-MM-dd"), txtSDT.EditValue.ToString(),txtEmail.EditValue.ToString(), txtDiaChi.EditValue.ToString());
            if (conn.E_DaTa(sqlI))
            {
                conn.ThongBaoTC("Thêm khách hàng ", txtTenKH);
                conn.LoadDT(gcKhachHang, sqlKH);
                btnLamMoi.PerformClick();
            }
            else
            {
                conn.ThongBaoTB("Thêm khách hàng ", txtTenKH);
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtKH.EditValue == null || txtKH.EditValue.ToString().Equals(""))
            {
                XtraMessageBox.Show("Bạn chọn khách hàng\r\nVui lòng chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                return;
            }
            string sqlU = string.Format("UPDATE khachhang SET id_TaiKhoan= '{0}' ,TenKhachHang= '{1}', NgaySinh='{2}', SDT= '{3}', Email='{4}', DiaChi='{5}'  WHERE id_KhachHang='{6}'", frmLogin.mataikhoan, txtTenKH.EditValue.ToString(), Convert.ToDateTime(txtNgaySinh.EditValue.ToString()).ToString("yyyy-MM-dd"), txtSDT.EditValue.ToString(), txtEmail.EditValue.ToString(), txtDiaChi.EditValue.ToString(), txtKH.EditValue.ToString());
            if (conn.E_DaTa(sqlU))
            {
                conn.ThongBaoTC("Sửa khách hàng thành công", txtTenKH);
                conn.LoadDT(gcKhachHang, sqlKH);
                btnLamMoi.PerformClick();
            }
            else
            {
                conn.ThongBaoTC("Sửa khách hàng thất bại", txtTenKH);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtKH.EditValue == null || txtKH.EditValue.ToString().Equals(""))
            {
                XtraMessageBox.Show("Bạn chọn khách hàng\r\nVui lòng chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }
            string sqlU = string.Format("DELETE FROM khachhang WHERE id_KhachHang='{0}'", txtKH.EditValue.ToString());
            if (conn.E_DaTa(sqlU))
            {
                conn.ThongBaoTC("Xoá khách hàng thành công", txtTenKH);
                conn.LoadDT(gcKhachHang, sqlKH);
            }
            else
            {
                conn.ThongBaoTC("xoá khách hàng thất bại", txtTenKH);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTenKH.EditValue = "";
            txtSDT.EditValue = "";
            txtDiaChi.EditValue = "";
            txtEmail.EditValue = "";
            txtNgaySinh.EditValue = "";
            txtKH.EditValue = "";
            txtTenKH.Focus();
        }

        private void gvKhachHang_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            txtTenKH.EditValue = gvKhachHang.GetRowCellValue(e.RowHandle, "TenKhachHang");
            txtEmail.EditValue = gvKhachHang.GetRowCellValue(e.RowHandle, "Email");
            txtDiaChi.EditValue = gvKhachHang.GetRowCellValue(e.RowHandle, "DiaChi");
            txtSDT.EditValue = gvKhachHang.GetRowCellValue(e.RowHandle, "SDT");
            txtNgaySinh.EditValue = gvKhachHang.GetRowCellValue(e.RowHandle, "NgaySinh");
            txtKH.EditValue = gvKhachHang.GetRowCellValue(e.RowHandle, "id_KhachHang");
            
        }
    }
}