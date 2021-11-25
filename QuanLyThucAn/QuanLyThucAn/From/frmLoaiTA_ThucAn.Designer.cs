namespace QuanLyThucAn.From
{
    partial class frmLoaiTA_ThucAn
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
            this.sss = new DevExpress.Utils.Layout.TablePanel();
            this.gcLoaiTA = new DevExpress.XtraGrid.GridControl();
            this.gvLoaiTA = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcThucAn = new DevExpress.XtraGrid.GridControl();
            this.gvThucAn = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.txtMaLoai = new DevExpress.XtraEditors.TextEdit();
            this.txtTenLoai = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnLamMoiL = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaL = new DevExpress.XtraEditors.SimpleButton();
            this.btnSuaL = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemL = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.sss)).BeginInit();
            this.sss.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcLoaiTA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLoaiTA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcThucAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvThucAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLoai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLoai.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sss
            // 
            this.sss.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 26.36F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 33.64F)});
            this.sss.Controls.Add(this.groupControl1);
            this.sss.Controls.Add(this.gcLoaiTA);
            this.sss.Controls.Add(this.gcThucAn);
            this.sss.Controls.Add(this.groupControl2);
            this.sss.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sss.Location = new System.Drawing.Point(0, 0);
            this.sss.Name = "sss";
            this.sss.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 207F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.sss.Size = new System.Drawing.Size(1048, 422);
            this.sss.TabIndex = 0;
            // 
            // gcLoaiTA
            // 
            this.sss.SetColumn(this.gcLoaiTA, 0);
            this.gcLoaiTA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcLoaiTA.Location = new System.Drawing.Point(3, 210);
            this.gcLoaiTA.MainView = this.gvLoaiTA;
            this.gcLoaiTA.Name = "gcLoaiTA";
            this.sss.SetRow(this.gcLoaiTA, 1);
            this.gcLoaiTA.Size = new System.Drawing.Size(454, 209);
            this.gcLoaiTA.TabIndex = 0;
            this.gcLoaiTA.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLoaiTA});
            // 
            // gvLoaiTA
            // 
            this.gvLoaiTA.GridControl = this.gcLoaiTA;
            this.gvLoaiTA.Name = "gvLoaiTA";
            this.gvLoaiTA.OptionsView.ShowGroupPanel = false;
            // 
            // gcThucAn
            // 
            this.sss.SetColumn(this.gcThucAn, 1);
            this.gcThucAn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcThucAn.Location = new System.Drawing.Point(463, 210);
            this.gcThucAn.MainView = this.gvThucAn;
            this.gcThucAn.Name = "gcThucAn";
            this.sss.SetRow(this.gcThucAn, 1);
            this.gcThucAn.Size = new System.Drawing.Size(582, 209);
            this.gcThucAn.TabIndex = 0;
            this.gcThucAn.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvThucAn});
            // 
            // gvThucAn
            // 
            this.gvThucAn.GridControl = this.gcThucAn;
            this.gvThucAn.Name = "gvThucAn";
            this.gvThucAn.OptionsView.ShowGroupPanel = false;
            // 
            // groupControl1
            // 
            this.sss.SetColumn(this.groupControl1, 0);
            this.groupControl1.Controls.Add(this.btnLamMoiL);
            this.groupControl1.Controls.Add(this.btnXoaL);
            this.groupControl1.Controls.Add(this.btnSuaL);
            this.groupControl1.Controls.Add(this.btnThemL);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtTenLoai);
            this.groupControl1.Controls.Add(this.txtMaLoai);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.sss.SetRow(this.groupControl1, 0);
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(454, 201);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "groupControl1";
            // 
            // groupControl2
            // 
            this.sss.SetColumn(this.groupControl2, 1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(463, 3);
            this.groupControl2.Name = "groupControl2";
            this.sss.SetRow(this.groupControl2, 0);
            this.groupControl2.ShowCaption = false;
            this.groupControl2.Size = new System.Drawing.Size(582, 201);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "groupControl1";
            // 
            // txtMaLoai
            // 
            this.txtMaLoai.Location = new System.Drawing.Point(97, 40);
            this.txtMaLoai.Name = "txtMaLoai";
            this.txtMaLoai.Size = new System.Drawing.Size(237, 24);
            this.txtMaLoai.TabIndex = 0;
            // 
            // txtTenLoai
            // 
            this.txtTenLoai.Location = new System.Drawing.Point(97, 80);
            this.txtTenLoai.Name = "txtTenLoai";
            this.txtTenLoai.Size = new System.Drawing.Size(237, 24);
            this.txtTenLoai.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(28, 83);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(51, 17);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Tên loại";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(28, 43);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(45, 17);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Mã loại";
            // 
            // btnLamMoiL
            // 
            this.btnLamMoiL.Location = new System.Drawing.Point(333, 140);
            this.btnLamMoiL.Name = "btnLamMoiL";
            this.btnLamMoiL.Size = new System.Drawing.Size(85, 38);
            this.btnLamMoiL.TabIndex = 2;
            this.btnLamMoiL.Text = "Làm mới";
            // 
            // btnXoaL
            // 
            this.btnXoaL.Location = new System.Drawing.Point(231, 140);
            this.btnXoaL.Name = "btnXoaL";
            this.btnXoaL.Size = new System.Drawing.Size(85, 38);
            this.btnXoaL.TabIndex = 3;
            this.btnXoaL.Text = "Xoá";
            // 
            // btnSuaL
            // 
            this.btnSuaL.Location = new System.Drawing.Point(126, 140);
            this.btnSuaL.Name = "btnSuaL";
            this.btnSuaL.Size = new System.Drawing.Size(85, 38);
            this.btnSuaL.TabIndex = 4;
            this.btnSuaL.Text = "Sửa";
            // 
            // btnThemL
            // 
            this.btnThemL.Location = new System.Drawing.Point(35, 140);
            this.btnThemL.Name = "btnThemL";
            this.btnThemL.Size = new System.Drawing.Size(85, 38);
            this.btnThemL.TabIndex = 5;
            this.btnThemL.Text = "Thêm";
            this.btnThemL.Click += new System.EventHandler(this.btnThemL_Click);
            // 
            // frmLoaiTA_ThucAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 422);
            this.Controls.Add(this.sss);
            this.Name = "frmLoaiTA_ThucAn";
            this.Text = "Thức Ăn";
            this.Load += new System.EventHandler(this.frmLoaiTA_ThucAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sss)).EndInit();
            this.sss.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcLoaiTA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLoaiTA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcThucAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvThucAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLoai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLoai.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel sss;
        private DevExpress.XtraGrid.GridControl gcLoaiTA;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLoaiTA;
        private DevExpress.XtraGrid.GridControl gcThucAn;
        private DevExpress.XtraGrid.Views.Grid.GridView gvThucAn;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtTenLoai;
        private DevExpress.XtraEditors.TextEdit txtMaLoai;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnLamMoiL;
        private DevExpress.XtraEditors.SimpleButton btnXoaL;
        private DevExpress.XtraEditors.SimpleButton btnSuaL;
        private DevExpress.XtraEditors.SimpleButton btnThemL;
    }
}