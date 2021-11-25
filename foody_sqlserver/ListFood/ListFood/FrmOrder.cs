using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListFood
{
    public partial class FrmOrder : Form
    {
        List<Food> _list_orders;
        public FrmOrder(List<Food> list_orders)
        {
            InitializeComponent();
            this._list_orders = list_orders;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            foreach (var food in _list_orders)
            {
                var listviewItem = new ListViewItem(new string[] { food.id.ToString() + ".", food.name, food.num_order.ToString(), food.price.ToString("n0"), food.total.ToString("n0") });
                listView1.Items.Add(listviewItem);
            }
            txt_total.Text = _list_orders.Sum(x => x.total).ToString("n0");
        }
    }
}
