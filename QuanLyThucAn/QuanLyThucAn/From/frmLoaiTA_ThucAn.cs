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
    public partial class frmLoaiTA_ThucAn : DevExpress.XtraEditors.XtraForm
    {
        public frmLoaiTA_ThucAn()
        {
            InitializeComponent();
        }

        connect conn = new connect();
        string sqlLoaiTA = "select * from loaidoan";
        string sqlDoAn = "select * from DoAn";

        public void LoadLoaiTA()
        {
            DataTable dt = conn.ex_data(sqlLoaiTA);
            if (dt != null)
            {
                gcLoaiTA.DataSource = dt;
            }
        }

        public void LoadThucAn()
        {
            DataTable dt = conn.ex_data(sqlDoAn);
            if (dt != null)
            {
                gcThucAn.DataSource = dt;
            }
        }

        private void frmLoaiTA_ThucAn_Load(object sender, EventArgs e)
        {
            LoadLoaiTA();
            LoadThucAn();
        }

        #region Loại thức ăn
        private void btnThemL_Click(object sender, EventArgs e)
        {
            if(txtTenLoai.EditValue.ToString()==null|| txtTenLoai.EditValue.ToString().Equals(""))
            {
                XtraMessageBox.Show("Bạn chưa nhập loại thức ăn\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenLoai.Focus();
                return;
            }
            string sqlILoaiTA = string.Format("insert into loaidoan values('{0}','{1}')", conn.creatId("TF",sqlLoaiTA), txtTenLoai.EditValue.ToString());
            if (conn.E_DaTa(sqlILoaiTA))
            {
                
                XtraMessageBox.Show("Thêm loại thức ăn " + txtTenLoai.EditValue.ToString() + " thành công", "Thông báo");
                LoadLoaiTA();
            }
            else
            {
                XtraMessageBox.Show("Thêm loại thức ăn " + txtTenLoai.EditValue.ToString() + " thất bại", "Thông báo");
            }
        }

        private void btnSuaL_Click(object sender, EventArgs e)
        {
            if (txtTenLoai.EditValue.ToString() == null || txtTenLoai.EditValue.ToString().Equals(""))
            {
                XtraMessageBox.Show("Bạn chọn loại thức ăn\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string sqlD = string.Format("update  loaidoan set tenloaithucan='{0}' where id_loaithucan='{1}'",txtTenLoai.EditValue.ToString(), txtMaLoai.EditValue.ToString());
            if (conn.E_DaTa(sqlD))
            {
                XtraMessageBox.Show("Cập nhật loại thức ăn " + txtTenLoai.EditValue.ToString() + " thành công", "Thông báo");
                LoadLoaiTA();
                btnLamMoiL.PerformClick();
            }
            else
            {
                XtraMessageBox.Show("Cập nhật loại thức ăn " + txtTenLoai.EditValue.ToString() + " thất bại", "Thông báo");
            }
        }

        private void btnXoaL_Click(object sender, EventArgs e)
        {
            if (txtMaLoai.EditValue.ToString() == null || txtMaLoai.EditValue.ToString().Equals(""))
            {
                XtraMessageBox.Show("Bạn chọn loại thức ăn\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);               
                return;
            }
            string sqlD = string.Format("delete from loaidoan where id_loaithucan='{0}'", txtMaLoai.EditValue.ToString());
            if (conn.E_DaTa(sqlD))
            {
                XtraMessageBox.Show("Xoá loại thức ăn " + txtTenLoai.EditValue.ToString() + " thành công", "Thông báo");
                LoadLoaiTA();
            }
            else
            {
                XtraMessageBox.Show("Xoá loại thức ăn " + txtTenLoai.EditValue.ToString() + " thất bại", "Thông báo");
            }
        }

        private void btnLamMoiL_Click(object sender, EventArgs e)
        {
            txtMaLoai.Text = "";
            txtTenLoai.Text = "";
            txtMaLoai.Focus();
        }

        private void gvLoaiTA_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {            
            txtMaLoai.EditValue = gvLoaiTA.GetRowCellValue(e.RowHandle, "id_LoaiThucAn").ToString();
            txtTenLoai.EditValue = gvLoaiTA.GetRowCellValue(e.RowHandle, "TenLoaiThucAn").ToString();
        }
        #endregion
         



    }
}