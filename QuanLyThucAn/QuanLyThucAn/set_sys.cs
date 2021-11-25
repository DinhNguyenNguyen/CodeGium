using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThucAn
{
   public static class set_sys
    {
        public static void mess(string text)
        {
            XtraMessageBox.Show(text, "Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
