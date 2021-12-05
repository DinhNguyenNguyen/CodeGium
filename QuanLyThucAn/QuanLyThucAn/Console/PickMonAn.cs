using DevExpress.XtraEditors;
using QuanLyThucAn.Console;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThucAn
{
    public partial class PickMonAn : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public PickMonAn()
        {
            InitializeComponent();
        }
        connect conn = new connect();
        string sqlMonAn = "select id_ThucAn , TenThucAn ,l.TenLoaiThucAn, gia, url as 'cc' from doan a, loaidoan l where l.id_loaithucan = a.id_loaithucan";
       
        private void loadTA()
        {
            DataTable dt = conn.ex_data(sqlMonAn);
            if (dt != null)
            {
                gcThucAn.DataSource = dt;

            }
            dt.Columns.Add("url", typeof(byte[]));
            foreach (DataRow dr in dt.Rows)
            {
                Image img = Image.FromFile(string.Format(@"{0}\SRC\Img\{1}", Application.StartupPath, dr["cc"]));
                dr["url"] = chuyenanh(img);
                dt.AcceptChanges();
                dr.SetModified();
            }
        }
        Byte[] chuyenanh(System.Drawing.Image img)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            img.Save(ms,System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }
        private void btnAdd_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            

        }
        public string mada , tenda, soluong;
        private void PickMonAn_Load(object sender, EventArgs e)
        {
            gridColumn1.Visible = false;
            loadTA();

        }
        PickSL fm_picksl;
       

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            bool check = fm_picksl.count_done;
            if(check == true)
            {
                soluong = fm_picksl.count.ToString();
                mada  = gvThucAn.GetRowCellValue(gvThucAn.FocusedRowHandle, gridColumn1.FieldName).ToString();
                timer1.Stop();
                this.Close();
            }
        }

        private void btnAdd_ButtonClick_1(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string ma_term = gvThucAn.GetRowCellValue(gvThucAn.FocusedRowHandle, gridColumn1.FieldName).ToString();
            if (QuanLyThucAn.From.frmDatMon.list_doAn.IndexOf(ma_term) < 0)
            {
                fm_picksl = new PickSL();
                fm_picksl.ShowDialog();
                timer1.Start();  
                
            }
            else
            {
                set_sys.mess("Thức ăn đã chọn rồi !");
            }
        }
    }
}