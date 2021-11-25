using Guna.UI2.WinForms.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ListFood.Food;

namespace ListFood
{
    
    public partial class Form1 : Form
    {
        public int total = 0;
        public int totalNumOrder = 0;
        public List<ItemFood> itemFoods;
        public List<ItemFood> itemFoodsFilter;
        public Form1()
        {
            InitializeComponent();
            guna2ShadowForm1.SetShadowForm(this);
            this.DoubleBuffered = true;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
        Nudge nudgeLabelOrder;
        private void Form1_Load(object sender, EventArgs e)
        {
            nudgeLabelOrder = new Nudge(lbl_numorder);
            // PanelScrollHelper vScrollHelper = new PanelScrollHelper(myFlowLayoutPanel1, guna2VScrollBar1, true);
            var data = Food.GetFoods();
            var list = new ItemFood[data.Count];
            int i = 0;
            itemFoods = new List<ItemFood>();
            itemFoodsFilter = new List<ItemFood>();
            foreach (var item in data)
            {
                list[i] = new ItemFood();
                list[i].itemValueChanged += Form1_itemValueChanged;
                list[i].uri_monan = @"monan\" + item.url;
                list[i].name = item.name;
                list[i].price = item.price;
                list[i].LoadImageAsync();
                itemFoods.Add(list[i]);
                itemFoodsFilter.Add(list[i]);
                
                i++;
            }
            myFlowLayoutPanel1.Controls.AddRange(list);

           // vScrollHelper.UpdateScrollBar();
        }
        private void Form1_itemValueChanged(object sender, ItemFood.ItemValueChangedEventArgs e)
        {
             
            if (e.IsAdd)
            {
                total += e.Value;
                totalNumOrder += 1;
                nudgeLabelOrder.NudgeMe();
                
                
            }
            else
            {
                total -= e.Value;
                totalNumOrder -= 1;
                nudgeLabelOrder.NudgeMe();
            }
            if(total == 0)
            {
                lbl_Tongtien.Text = "₫0";
                lbl_numorder.Text = "0";
            }
            else
            {
                // lbl_Tongtien.Text = "₫" + total.ToString("#,#");
                if (e.IsAdd)
                {
                    AddTotalLabelEffect(e.Value, true, e.Value);
                }
                else
                {
                    AddTotalLabelEffect(e.Value, false, e.Value);
                }
                lbl_numorder.Text = totalNumOrder.ToString();
            }
           

        }

             
        private void AddTotalLabelEffect(int add, bool isAdd, int val)
        {
            int value = 0;
            if (isAdd)
            {
                 value = total - val;
            }
            else
            {
                 value = total + val;
            }
           
            var d = add / 50;
            Task.Run(() =>
            {
                for (int i = 0; i < 50; i++)
                {
                    if (isAdd)
                    {
                        value += d;
                    }
                    else
                    {
                        value -= d;
                    }
                   
                    this.BeginInvoke(new Action(() => { lbl_Tongtien.Text = "₫" + value.ToString("#,#"); }));
                    Thread.Sleep(5);
                }
                Thread.Sleep(5);
                this.BeginInvoke(new Action(() => { lbl_Tongtien.Text = "₫" + total.ToString("#,#"); }));
            });

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var keyword = RemoveUnicode(txtSearch.Text.ToLower());
            myFlowLayoutPanel1.Controls.Clear();
            if (string.IsNullOrEmpty(keyword))
            {
                myFlowLayoutPanel1.Controls.AddRange(itemFoods.ToArray());
            }
            else
            {
                var dataFilter = itemFoodsFilter.Where(x => RemoveUnicode(x.name.ToLower()).Contains(keyword)).ToArray();
                myFlowLayoutPanel1.Controls.AddRange(dataFilter);
            }
        }

        public static string RemoveUnicode(string text)
        {
            string[] arr1 = new string[] { "á", "à", "ả", "ã", "ạ", "â", "ấ", "ầ", "ẩ", "ẫ", "ậ", "ă", "ắ", "ằ", "ẳ", "ẵ", "ặ",
    "đ",
    "é","è","ẻ","ẽ","ẹ","ê","ế","ề","ể","ễ","ệ",
    "í","ì","ỉ","ĩ","ị",
    "ó","ò","ỏ","õ","ọ","ô","ố","ồ","ổ","ỗ","ộ","ơ","ớ","ờ","ở","ỡ","ợ",
    "ú","ù","ủ","ũ","ụ","ư","ứ","ừ","ử","ữ","ự",
    "ý","ỳ","ỷ","ỹ","ỵ",};
            string[] arr2 = new string[] { "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a",
    "d",
    "e","e","e","e","e","e","e","e","e","e","e",
    "i","i","i","i","i",
    "o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o",
    "u","u","u","u","u","u","u","u","u","u","u",
    "y","y","y","y","y",};
            for (int i = 0; i < arr1.Length; i++)
            {
                text = text.Replace(arr1[i], arr2[i]);
                text = text.Replace(arr1[i].ToUpper(), arr2[i].ToUpper());
            }
            return text;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lbl_numorder.Text) > 0)
            {
                var list_order = new List<Food>();
                int i = 1;
                foreach (ItemFood item in myFlowLayoutPanel1.Controls)
                {
                    if (item.count > 0)
                    {
                        var name = item.name;
                        var quantity = item.count;
                        var price = item.price;
                        var url = item.uri_monan;
                        list_order.Add(new Food() { id = i, name = name, price = price, url = url, num_order = item.count }); 
                        i++;
                    }
                }

                var frm = new FrmOrder(list_order);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn món ăn.");
            }
        }
    }
}
