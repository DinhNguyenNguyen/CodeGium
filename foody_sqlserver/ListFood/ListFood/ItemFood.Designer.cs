
namespace ListFood
{
    partial class ItemFood
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.pic_food = new ListFood.VBImageColorOverlay();
            this.lblSelected = new System.Windows.Forms.Label();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.btnMinus = new FontAwesome.Sharp.IconButton();
            this.pic_food.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.Black;
            this.lbl_name.Location = new System.Drawing.Point(3, 150);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(128, 16);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "Bánh mỳ tuấn mập";
            this.lbl_name.MouseEnter += new System.EventHandler(this.ItemFood_MouseHover);
            this.lbl_name.MouseLeave += new System.EventHandler(this.ItemFood_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(3, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Write description...";
            this.label2.MouseEnter += new System.EventHandler(this.ItemFood_MouseHover);
            this.label2.MouseLeave += new System.EventHandler(this.ItemFood_MouseLeave);
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_price.Location = new System.Drawing.Point(4, 238);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(60, 16);
            this.lbl_price.TabIndex = 3;
            this.lbl_price.Text = "₫15,000";
            this.lbl_price.MouseEnter += new System.EventHandler(this.ItemFood_MouseHover);
            this.lbl_price.MouseLeave += new System.EventHandler(this.ItemFood_MouseLeave);
            // 
            // pic_food
            // 
            this.pic_food.BackgroundColorOverlay = System.Drawing.Color.Goldenrod;
            this.pic_food.BackgroundImage = global::ListFood.Properties.Resources.top_15_hinh_anh_mon_an_ngon_viet_nam_khien_ban_khong_the_roi_mat_1;
            this.pic_food.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_food.BorderRadius = 0;
            this.pic_food.Controls.Add(this.lblSelected);
            this.pic_food.ImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_food.Location = new System.Drawing.Point(-12, -10);
            this.pic_food.Name = "pic_food";
            this.pic_food.OpacityOverlay = 0;
            this.pic_food.OverlayColorDefault = true;
            this.pic_food.Size = new System.Drawing.Size(188, 145);
            this.pic_food.TabIndex = 0;
            this.pic_food.VBBackgroundImage = global::ListFood.Properties.Resources.top_15_hinh_anh_mon_an_ngon_viet_nam_khien_ban_khong_the_roi_mat_1;
            this.pic_food.MouseEnter += new System.EventHandler(this.ItemFood_MouseHover);
            this.pic_food.MouseLeave += new System.EventHandler(this.ItemFood_MouseLeave);
            // 
            // lblSelected
            // 
            this.lblSelected.BackColor = System.Drawing.Color.Gray;
            this.lblSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelected.ForeColor = System.Drawing.Color.White;
            this.lblSelected.Location = new System.Drawing.Point(156, 10);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(32, 23);
            this.lblSelected.TabIndex = 4;
            this.lblSelected.Text = "0";
            this.lblSelected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAdd.IconColor = System.Drawing.Color.Goldenrod;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdd.IconSize = 24;
            this.btnAdd.Location = new System.Drawing.Point(138, 234);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(37, 31);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.MouseEnter += new System.EventHandler(this.ItemFood_MouseHover);
            this.btnAdd.MouseLeave += new System.EventHandler(this.ItemFood_MouseLeave);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.Color.Gainsboro;
            this.btnMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinus.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMinus.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnMinus.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMinus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinus.IconSize = 24;
            this.btnMinus.Location = new System.Drawing.Point(91, 234);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(37, 31);
            this.btnMinus.TabIndex = 5;
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Visible = false;
            this.btnMinus.Click += new System.EventHandler(this.iconButton1_Click);
            this.btnMinus.MouseEnter += new System.EventHandler(this.ItemFood_MouseHover);
            this.btnMinus.MouseLeave += new System.EventHandler(this.ItemFood_MouseLeave);
            // 
            // ItemFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.pic_food);
            this.Name = "ItemFood";
            this.Size = new System.Drawing.Size(176, 278);
            this.MouseEnter += new System.EventHandler(this.ItemFood_MouseHover);
            this.MouseLeave += new System.EventHandler(this.ItemFood_MouseLeave);
            this.MouseHover += new System.EventHandler(this.ItemFood_MouseHover);
            this.pic_food.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VBImageColorOverlay pic_food;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lblSelected;
        private FontAwesome.Sharp.IconButton btnAdd;
        private FontAwesome.Sharp.IconButton btnMinus;
    }
}
