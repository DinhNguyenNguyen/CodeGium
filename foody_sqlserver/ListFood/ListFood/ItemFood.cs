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
    public partial class ItemFood : UserControl
    {
        public ItemFood()      {
            InitializeComponent();
            btnAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
        }
        public int count = 0;
        public event ItemValueChangedEventHandler itemValueChanged;
        public int CountAdded
        {
            get
            {
                return this.count;
            }
            set
            {
                this.count = value;
                if(this.count > 0)
                {
                    lblSelected.BackColor = ColorTranslator.FromHtml("#F68080");
                    btnMinus.Visible = true;
                }
                else
                {
                    lblSelected.BackColor = Color.Gray;
                    btnMinus.Visible = false;
                }
                lblSelected.Text = value.ToString();
            }
        }

        public Task<Image> LoadImageFromFileAsync(string uri)
        {
            return Task.Run(() => {
                return Image.FromFile(uri);
            });
        }

        public string _urimonan;
        public string uri_monan {
            set {
                this._urimonan = value;
            }
            get { return _urimonan; }
        }

        public async void LoadImageAsync()
        {
            var image = await LoadImageFromFileAsync(this.uri_monan);
            pic_food.BackgroundImage = image;

        }
        public string _name;
        public string name
        {
            set
            {
                _name = value;
                lbl_name.Text = value;
            }
            get { return this._name; }
        }

        public int _price;
        public int price
        {
            set
            {
                _price = value;
                lbl_price.Text = "₫" + value.ToString("#,#");
            }
            get { return this._price; }
        }
        private void ItemFood_MouseHover(object sender, EventArgs e)
        {
            pic_food.OpacityOverlay = 50;
            pic_food.Refresh();
        }

        private void ItemFood_MouseLeave(object sender, EventArgs e)
        {
            pic_food.OpacityOverlay = 0;
            pic_food.Refresh();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.CountAdded += 1;
            ItemValueChangedEventArgs myArgs = new ItemValueChangedEventArgs(this.price, true, this.CountAdded);
            this.itemValueChanged(sender, myArgs);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if(this.CountAdded > 0)
            {
                ItemValueChangedEventArgs myArgs = new ItemValueChangedEventArgs(this.price, false, this.CountAdded);
                this.itemValueChanged(sender, myArgs);
                this.CountAdded -= 1;
            }
            
        }

        public delegate void ItemValueChangedEventHandler(object sender, ItemValueChangedEventArgs e);
        public class ItemValueChangedEventArgs : EventArgs
        {
            private int value;
            private int numOrder;
            private bool isAdd;

            public ItemValueChangedEventArgs(int _value, bool _isAdd, int _numOrder)
            {
                this.value = _value;
                this.isAdd = _isAdd;
                this.numOrder = _numOrder;
            }

            public int Value { get { return this.value; } }
            public int NumOrder { get { return this.numOrder; } }
            public bool IsAdd { get { return this.isAdd; } }

        }
    }
}
