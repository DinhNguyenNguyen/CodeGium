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
    public partial class frmThucAn_LoaiTA : DevExpress.XtraEditors.XtraForm
    {
        public frmThucAn_LoaiTA()
        {
            InitializeComponent();
        }

        connect con = new connect();
        string sqlLoaiDA = "select * from loaidoan";
        #region loại thức ăn
        private void btnThem_Click(object sender, EventArgs e)
        {
            if ((txtTenLoai.EditValue == null) || (txtTenLoai.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Bạn chưa nhập tên thức ăn\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenLoai.Focus();
                return;
            }

            string tenloaiTA = txtTenLoai.EditValue.ToString();
            string insertLTA = string.Format("insert into loaidoan values('{0}', '{1}') ", con.creatId("LF",sqlLoaiDA), tenloaiTA);
            con.ex_cmd(insertLTA);

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {

        }
        #endregion

    }
}