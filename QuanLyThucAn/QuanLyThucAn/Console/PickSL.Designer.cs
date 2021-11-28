
namespace QuanLyThucAn.Console
{
    partial class PickSL
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_choose = new DevExpress.XtraEditors.SimpleButton();
            this.btn_down = new DevExpress.XtraEditors.SimpleButton();
            this.btn_up = new DevExpress.XtraEditors.SimpleButton();
            this.txt_soluong = new DevExpress.XtraEditors.TextEdit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_soluong.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 196F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.Controls.Add(this.btn_choose, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_down, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_up, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_soluong, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(336, 41);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btn_choose
            // 
            this.btn_choose.ImageOptions.Image = global::QuanLyThucAn.Properties.Resources.checkbox2_32x32;
            this.btn_choose.Location = new System.Drawing.Point(292, 3);
            this.btn_choose.Name = "btn_choose";
            this.btn_choose.Size = new System.Drawing.Size(39, 34);
            this.btn_choose.TabIndex = 10;
            this.btn_choose.Click += new System.EventHandler(this.btn_choose_Click);
            // 
            // btn_down
            // 
            this.btn_down.ImageOptions.Image = global::QuanLyThucAn.Properties.Resources.remove_32x321;
            this.btn_down.Location = new System.Drawing.Point(49, 3);
            this.btn_down.Name = "btn_down";
            this.btn_down.Size = new System.Drawing.Size(39, 34);
            this.btn_down.TabIndex = 9;
            this.btn_down.Click += new System.EventHandler(this.btn_down_Click_1);
            // 
            // btn_up
            // 
            this.btn_up.ImageOptions.Image = global::QuanLyThucAn.Properties.Resources.add_32x321;
            this.btn_up.Location = new System.Drawing.Point(3, 3);
            this.btn_up.Name = "btn_up";
            this.btn_up.Size = new System.Drawing.Size(38, 34);
            this.btn_up.TabIndex = 4;
            this.btn_up.Click += new System.EventHandler(this.btn_up_Click);
            // 
            // txt_soluong
            // 
            this.txt_soluong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_soluong.EditValue = "1";
            this.txt_soluong.Location = new System.Drawing.Point(96, 3);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(190, 34);
            this.txt_soluong.TabIndex = 8;
            // 
            // PickSL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 41);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PickSL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PickL";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_soluong.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton btn_choose;
        private DevExpress.XtraEditors.SimpleButton btn_down;
        private DevExpress.XtraEditors.SimpleButton btn_up;
        private DevExpress.XtraEditors.TextEdit txt_soluong;
    }
}