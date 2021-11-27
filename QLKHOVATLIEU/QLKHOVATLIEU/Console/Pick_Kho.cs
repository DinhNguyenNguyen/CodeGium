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
    public partial class Pick_Kho : Form
    {
        public Pick_Kho()
        {
            InitializeComponent();
        }

        private void Pick_Kho_Load(object sender, EventArgs e)
        {
            comboBox1.ValueMember = "makhohang";
            comboBox1.DisplayMember = "tenkhohang";
            comboBox1.DataSource = Class.Csdl_sys.ex_data("select makhohang , tenkhohang from khohang");
        }

        private void comboBox1_DropDownClosed(object sender, EventArgs e)
        {
            QLKHOVATLIEU.frmsanpham.makho = comboBox1.SelectedValue.ToString().Trim();
            QLKHOVATLIEU.frmsanpham.tenkho = comboBox1.Text;
            this.Close();
        }
    }
}
