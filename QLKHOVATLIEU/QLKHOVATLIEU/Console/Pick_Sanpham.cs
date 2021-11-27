using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKHOVATLIEU.Console
{
    public partial class Pick_Sanpham : Form
    {
        public Pick_Sanpham()
        {
            InitializeComponent();
        }

        private void Pick_Sanpham_Load(object sender, EventArgs e)
        {
            comboBox1.ValueMember = "masp";
            comboBox1.DisplayMember = "tensp";
            comboBox1.DataSource = Class.Csdl_sys.ex_data("select MaSP , TenSP from sanpham");

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
          QLKHOVATLIEU.frmhoadon.id_sp = comboBox1.SelectedValue.ToString();
            this.Close();
        }
    }
}
