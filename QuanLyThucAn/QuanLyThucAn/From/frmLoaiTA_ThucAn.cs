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
using System.IO;
using DevExpress.XtraEditors.Repository;

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
            dt.Columns.Add("URLL",typeof(byte[]));
            if (dt != null)
            {
                gcThucAn.DataSource = dt;
            }
            foreach (DataRow dr in dt.Rows)
            {
                dr["URL"] = string.Format(@"{0}\SRC\Img\{1}", Application.StartupPath,dr["URL"]);
                Image img = Image.FromFile(dr["URL"].ToString());
                dr["URLL"] = imageToByteArray(img);
                dt.AcceptChanges();
                dr.SetModified();
            }

           
            
        }
        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }
        public void LoadLoaiTAonTA()
        {
            DataTable dt = conn.ex_data(sqlLoaiTA);
            if (dt != null)
            {
                lukLoaiTA.Properties.DataSource = dt;
                lukLoaiTA.Properties.DisplayMember = "TenLoaiThucAn";
                lukLoaiTA.Properties.ValueMember = "id_LoaiThucAn";
            }
        }

        private void frmLoaiTA_ThucAn_Load(object sender, EventArgs e)
        {
            LoadLoaiTA();
            LoadThucAn();
            LoadLoaiTAonTA();
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

        private void btnLamMoiF_Click(object sender, EventArgs e)
        {
            txtGia.EditValue = "";
            txtMaTA.EditValue = "";
            txtTenTA.EditValue = "";
            txtURL.EditValue = "";
            lukLoaiTA.EditValue = "";
            txtTenTA.Focus();
            LoadLoaiTAonTA();
        }

        private void btnSuaF_Click(object sender, EventArgs e)
        {
            if (txtMaTA.EditValue == null || txtMaTA.EditValue.ToString().Equals(""))
            {
                XtraMessageBox.Show("Bạn chưa nhập thức ăn\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaTA.Focus();
                return;
            }
            string sqlU = string.Format("update doan set id_taikhoan= '{0}',tenthucan= '{1}',gia={2},url='{3}', id_loaithucan='{4}' where id_thucan='{5}'", frmLogin.mataikhoan,  txtTenTA.EditValue.ToString(), Convert.ToInt32(txtGia.EditValue.ToString()), txtURL.EditValue.ToString(), lukLoaiTA.EditValue,txtMaTA.EditValue.ToString());

            if (conn.E_DaTa(sqlU))
            {
                conn.ThongBaoTC("Sửa thức ăn ", txtTenTA);
                LoadThucAn();
                btnLamMoiF.PerformClick();
            }
            else
            {
                conn.ThongBaoTB("Sửa thức ăn ", txtTenTA);
            }
        }

        private void btnXoaF_Click(object sender, EventArgs e)
        {
            if (txtMaTA.EditValue.ToString() == null || txtMaTA.EditValue.ToString().Equals(""))
            {
                XtraMessageBox.Show("Bạn chưa chọn thức ăn\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaTA.Focus();
                return;
            }
            string sqlD = string.Format("delete from doan where id_ThucAn='{0}'", txtMaTA.EditValue.ToString());
            if (conn.E_DaTa(sqlD))
            {
                XtraMessageBox.Show("Xoá  thức ăn " + txtMaTA.EditValue.ToString() + " thành công", "Thông báo");
                LoadLoaiTA();
            }
            else
            {
                XtraMessageBox.Show("Xoá loại thức ăn " + txtMaTA.EditValue.ToString() + " thất bại", "Thông báo");
            }
        }

        private void btnThemF_Click(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo(dlg.FileName);
            string name_file = txtURL.Text;
            fi.CopyTo(path, true);
            if (txtTenTA.EditValue == null || txtTenTA.EditValue.ToString().Equals(""))
            {
                XtraMessageBox.Show("Bạn chưa nhập tên thức ăn\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenTA.Focus();
                return;
            }
            if (lukLoaiTA.EditValue == null || lukLoaiTA.EditValue.ToString().Equals(""))
            {
                XtraMessageBox.Show("Bạn chưa nhập loại thức ăn\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lukLoaiTA.Focus();
                return;
            }
            if (txtGia.EditValue == null || txtGia.EditValue.ToString().Equals(""))
            {
                XtraMessageBox.Show("Bạn chưa nhập giá thức ăn\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGia.Focus();
                return;
            }
            if (txtURL.EditValue == null || txtURL.EditValue.ToString().Equals(""))
            {
                XtraMessageBox.Show("Bạn chưa chọn đường dẫn ảnh thức ăn\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtURL.Focus();
                return;
            }

            string sqlU = string.Format("insert doan values('{0}','{1}','{2}','{3}',{4},'{5}')", conn.creatId("TA", sqlDoAn),frmLogin.mataikhoan , lukLoaiTA.EditValue, txtTenTA.EditValue.ToString(), Convert.ToInt32(txtGia.EditValue.ToString()),name_file);

            if (conn.E_DaTa(sqlU))
            {
                conn.ThongBaoTC("Thêm thức ăn ", txtTenTA);
                LoadThucAn();
                btnLamMoiF.PerformClick();
            }
            else
            {
                conn.ThongBaoTB("Thêm thức ăn ", txtTenTA);
            }
        }

        private void gvThucAn_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            txtGia.EditValue = gvThucAn.GetRowCellValue(e.RowHandle,"gia");
            txtMaTA.EditValue = gvThucAn.GetRowCellValue(e.RowHandle, "id_ThucAn");
            txtTenTA.EditValue = gvThucAn.GetRowCellValue(e.RowHandle, "TenThucAn");
            txtURL.EditValue = gvThucAn.GetRowCellValue(e.RowHandle, "URL");
            lukLoaiTA.Text = gvThucAn.GetRowCellValue(e.RowHandle, "id_LoaiThucAn").ToString();
        }
        string path;
        OpenFileDialog dlg;
        private void txtURL_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            dlg = new OpenFileDialog();
            dlg.Title = "Chọn một hình ảnh thức ăn";
            dlg.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtURL.Text = dlg.SafeFileName;
                string name_file = dlg.SafeFileName;
               
                 path =string.Format(@"{0}\SRC\Img\", Application.StartupPath);
                 if (!Directory.Exists(path))
                 {
                     Directory.CreateDirectory(path);
                 }
                path = path+name_file;
            }
        }
    }
}