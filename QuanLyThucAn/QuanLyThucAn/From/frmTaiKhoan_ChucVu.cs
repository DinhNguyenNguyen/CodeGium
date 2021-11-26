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
    public partial class frmTaiKhoan_ChucVu : DevExpress.XtraEditors.XtraForm
    {
        public frmTaiKhoan_ChucVu()
        {
            InitializeComponent();
        }

        connect conn = new connect();
        string taikhoan = "select * from taikhoan";
        string chucvu = "select * from chucvu";


        private void loadTK()
        {
            DataTable dt = conn.ex_data(taikhoan);
            if(dt!= null)
            {
                gcTaiKhoan.DataSource = dt;
            }
        }

        private void loadCV()
        {
            DataTable dt = conn.ex_data(chucvu);
            if (dt != null)
            {
                gcChucVu.DataSource = dt;
            }
        }

        private void frmTaiKhoan_ChucVu_Load(object sender, EventArgs e)
        {
            loadTK();
            loadCV();
            loadCVonTK();

        }

        private void loadCVonTK()
        {
            DataTable dt = conn.ex_data(chucvu);
            if (dt != null)
            {
                lkChucVU.Properties.DataSource = dt;
                lkChucVU.Properties.DisplayMember = "tenchucvu";
                lkChucVU.Properties.ValueMember = "id_chucvu";
            }
        }
        
        #region Chức vụ
        private void btnThemCV_Click(object sender, EventArgs e)
        {
            if (txtTenCV.EditValue.ToString() == null || txtTenCV.EditValue.ToString().Equals(""))
            {
                XtraMessageBox.Show("Bạn chưa nhập chức vụ\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenCV.Focus();
                return;
            }
            string sqlICV = string.Format("insert into chucvu values('{0}','{1}')", conn.creatId("CV", chucvu), txtTenCV.EditValue.ToString());
            if (conn.E_DaTa(sqlICV))
            {
               
                conn.ThongBaoTC("Thêm chức vụ ", txtTenCV);
                loadCV();
                btnLamMoiCV.PerformClick();
            }
            else
            {
                conn.ThongBaoTB("Thêm chức vụ ", txtTenCV);
            }

        }

        private void btnSuaCV_Click(object sender, EventArgs e)
        {
            if (txtTenCV.EditValue.ToString() == null || txtTenCV.EditValue.ToString().Equals(""))
            {
                XtraMessageBox.Show("Bạn chưa chọn chức vụ\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenCV.Focus();
                return;
            }
            string sqlUCV = string.Format("update chucvu set tenchucvu= '{0}' where id_chucvu='{1}' ", txtTenCV.EditValue.ToString(), txtMaCV.EditValue.ToString());
            if (conn.E_DaTa(sqlUCV))
            {
                XtraMessageBox.Show("Sửa chức vụ " + txtTenCV.EditValue.ToString() + " thành công", "Thông báo");
                loadCV(); btnLamMoiCV.PerformClick();
            }
            else
            {
                XtraMessageBox.Show("Sửa chức vụ" + txtTenCV.EditValue.ToString() + " thất bại", "Thông báo");
            }
        }

        private void btnXoaCV_Click(object sender, EventArgs e)
        {
            if (txtTenCV.EditValue.ToString() == null || txtTenCV.EditValue.ToString().Equals(""))
            {
                XtraMessageBox.Show("Bạn chưa chọn chức vụ\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenCV.Focus();
                return;
            }
            string sqlDCV = string.Format("delete from chucvu where id_chucvu='{0}'",txtMaCV.EditValue.ToString());
            if (conn.E_DaTa(sqlDCV))
            {
                XtraMessageBox.Show("Xoá chức vụ " + txtTenCV.EditValue.ToString() + " thành công", "Thông báo");
                loadCV(); btnLamMoiCV.PerformClick();
            }
            else
            {
                XtraMessageBox.Show("Xoá chức vụ " + txtTenCV.EditValue.ToString() + " thất bại", "Thông báo");
            }
        }

        private void btnLamMoiCV_Click(object sender, EventArgs e)
        {
            txtMaCV.Text = "";
            txtTenCV.Text = "";
            txtTenCV.Focus();
        }

        private void gvChucVu_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            txtMaCV.EditValue = gvChucVu.GetRowCellValue(e.RowHandle, "id_chucvu").ToString();
            txtTenCV.EditValue = gvChucVu.GetRowCellValue(e.RowHandle, "tenchucvu").ToString();
        }

        #endregion


        #region Tài khoản
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenTK.EditValue== null || txtTenTK.EditValue.ToString().Equals(""))
            {
                XtraMessageBox.Show("Bạn chưa nhập tên tài khoản\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenTK.Focus();
                return;
            }
            if (txtMatKhau.EditValue == null || txtMatKhau.EditValue.ToString().Equals(""))
            {
                XtraMessageBox.Show("Bạn chưa nhập mật khẩu\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMatKhau.Focus();
                return;
            }
            if (lkChucVU.EditValue == null || lkChucVU.EditValue.ToString().Equals(""))
            {
                XtraMessageBox.Show("Bạn chưa chọn chức vụ\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                return;
            }
            if (txtHoTen.EditValue == null || txtHoTen.EditValue.ToString().Equals(""))
            {
                XtraMessageBox.Show("Bạn nhập họ tên\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHoTen.Focus();
                return;
            }
            if (txtTenTK.EditValue == null || txtTenTK.EditValue.ToString().Equals(""))
            {
                XtraMessageBox.Show("Bạn chưa tên tài khoản vụ\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenTK.Focus();
                return;
            }
            if (txtSDT.EditValue == null || txtSDT.EditValue.ToString().Equals(""))
            {
                XtraMessageBox.Show("Bạn nhập số điện thoại\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSDT.Focus();
                return;
            }
            if (txtNgaySinh.EditValue == null || txtNgaySinh.EditValue.ToString().Equals(""))
            {
                XtraMessageBox.Show("Bạn chọn ngày sinh\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);               
                return;
            }
            if (txtEmail.EditValue == null || txtEmail.EditValue.ToString().Equals(""))
            {
                XtraMessageBox.Show("Bạn nhập email\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.Focus();
                return;
            }
            

            string sqlU = string.Format("insert taikhoan values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')",conn.creatId("TK",taikhoan),lkChucVU.EditValue.ToString() , txtTenTK.EditValue.ToString(),conn.CreateMD5(txtMatKhau.EditValue.ToString()), txtHoTen.EditValue.ToString(),txtSDT.EditValue.ToString(), txtEmail.EditValue.ToString(), Convert.ToDateTime(txtNgaySinh.EditValue.ToString()).ToString("yyyy-MM-dd"));
            
            if (conn.E_DaTa(sqlU))
            {
                conn.ThongBaoTC("Thêm thức ăn ", txtHoTen);
                loadTK();
                btnLamMoi.PerformClick();
            }
            else
            {
                conn.ThongBaoTB("Thêm thức ăn ", txtHoTen);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sqlU = string.Format("delete from taikhoan where id_taikhoan= '{0}' ", txtMaTk.EditValue.ToString());
            
            if (conn.E_DaTa(sqlU))
            {
                conn.ThongBaoTC("Xoá tài khoản cho ", txtHoTen);
                loadTK();
                btnLamMoi.PerformClick();
            }
            else
            {
                conn.ThongBaoTB("Xoá tài khoản cho ", txtHoTen);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sqlU = string.Format("update taikhoan set id_chucvu='{0}', password= '{1}', hovaten= '{2}' sdt= '{3}',email= '{4}',ngaysinh= '{5}' where id_taikhoan='{6}')", lkChucVU.EditValue.ToString(), conn.CreateMD5(txtMatKhau.EditValue.ToString()), txtHoTen.EditValue.ToString(), txtSDT.EditValue.ToString(), txtEmail.EditValue.ToString(), Convert.ToDateTime(txtNgaySinh.EditValue.ToString()).ToString("yyyy-MM-dd"), txtMaTk.EditValue.ToString());

            if (conn.E_DaTa(sqlU))
            {
                conn.ThongBaoTC("Sửa tài khoản cho ", txtHoTen);
                loadTK();
                btnLamMoi.PerformClick();
            }
            else
            {
                conn.ThongBaoTB("Sửa tài khoản cho ", txtHoTen);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaTk.EditValue = "";
            txtTenTK.EditValue = "";
            txtEmail.EditValue = "";
            txtHoTen.EditValue = "";
            txtMatKhau.EditValue = "";
            txtNgaySinh.EditValue = "";
            txtSDT.EditValue = "";
            lkChucVU.Text = "";
        }

        private void gvTaiKhoan_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            txtMaTk.EditValue = gvTaiKhoan.GetRowCellValue(e.RowHandle, "id_taikhoan").ToString();
            txtTenTK.EditValue = gvTaiKhoan.GetRowCellValue(e.RowHandle, "user_name").ToString();
            txtMatKhau.EditValue = gvTaiKhoan.GetRowCellValue(e.RowHandle, "password").ToString();
            txtHoTen.EditValue = gvTaiKhoan.GetRowCellValue(e.RowHandle, "hovaten").ToString();
            txtSDT.EditValue = gvTaiKhoan.GetRowCellValue(e.RowHandle, "sdt").ToString();
            lkChucVU.EditValue = gvTaiKhoan.GetRowCellValue(e.RowHandle, "id_chucvu").ToString();
            txtNgaySinh.EditValue = gvTaiKhoan.GetRowCellValue(e.RowHandle, "ngaysinh").ToString();
            txtEmail.EditValue = gvTaiKhoan.GetRowCellValue(e.RowHandle, "email").ToString();
        }

        #endregion
    }
}