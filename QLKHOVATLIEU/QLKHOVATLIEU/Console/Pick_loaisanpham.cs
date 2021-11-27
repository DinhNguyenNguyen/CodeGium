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
    public partial class Pick_loaisanpham : Form
    {
        public Pick_loaisanpham()
        {
            InitializeComponent();
        }

        private void Pick_loaisanpham_Load(object sender, EventArgs e)
        {
            comboBox1.DisplayMember = "tenloaisanpham";
            comboBox1.ValueMember = "maloaisanpham";
            comboBox1.DataSource = Class.Csdl_sys.ex_data("select maloaisanpham , tenloaisanpham from loaisanpham");
        }

        private void comboBox1_DropDownClosed(object sender, EventArgs e)
        {
            QLKHOVATLIEU.frmsanpham.masp = comboBox1.SelectedValue.ToString().Trim();
            QLKHOVATLIEU.frmsanpham.tensp = comboBox1.SelectedText;
            this.Close();
        }
    }
}
