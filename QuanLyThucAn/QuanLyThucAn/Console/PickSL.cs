using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThucAn.Console
{
    public partial class PickSL : DevExpress.XtraEditors.XtraForm
    {
        public PickSL()
        {
            InitializeComponent();
        }

        private void btn_down_Click(object sender, EventArgs e)
        {

        }
        public int count = 1;
        public bool count_done;
        private void btn_up_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_choose_Click(object sender, EventArgs e)
        {
            count_done = true;
            this.Close();
        }

        private void btn_up_Click(object sender, EventArgs e)
        {
            count++;
            txt_soluong.Text = count.ToString();
        }

        private void btn_down_Click_1(object sender, EventArgs e)
        {
            if(count > 1)
            {
                count--;
                txt_soluong.Text = count.ToString();
            }
            else
            {
                set_sys.mess("Không thể giảm số lượng về 0");
            }
        }
    }
}