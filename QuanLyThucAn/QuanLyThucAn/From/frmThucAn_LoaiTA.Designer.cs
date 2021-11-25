namespace QuanLyThucAn.From
{
    partial class frmThucAn_LoaiTA
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThucAn_LoaiTA));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcThucAn = new DevExpress.XtraGrid.GridControl();
            this.gvThucAn = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcLoaiThucAn = new DevExpress.XtraGrid.GridControl();
            this.gvLoaiThucAn = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtTenLoai = new DevExpress.XtraEditors.TextEdit();
            this.txtMaLoai = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnLamMoi = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.txtGiaTA = new DevExpress.XtraEditors.TextEdit();
            this.txtTenTA = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaTA = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.lukLoaiTA = new DevExpress.XtraEditors.LookUpEdit();
            this.txtURL = new DevExpress.XtraEditors.ButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcThucAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvThucAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLoaiThucAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLoaiThucAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLoai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLoai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaTA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaTA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lukLoaiTA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtURL.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.gcThucAn;
            this.gridView3.Name = "gridView3";
            // 
            // gcThucAn
            // 
            this.tablePanel1.SetColumn(this.gcThucAn, 1);
            this.gcThucAn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcThucAn.Location = new System.Drawing.Point(397, 223);
            this.gcThucAn.MainView = this.gvThucAn;
            this.gcThucAn.Name = "gcThucAn";
            this.tablePanel1.SetRow(this.gcThucAn, 1);
            this.gcThucAn.Size = new System.Drawing.Size(701, 228);
            this.gcThucAn.TabIndex = 0;
            this.gcThucAn.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvThucAn,
            this.gridView4,
            this.gridView3});
            // 
            // gvThucAn
            // 
            this.gvThucAn.GridControl = this.gcThucAn;
            this.gvThucAn.Name = "gvThucAn";
            this.gvThucAn.OptionsView.ShowGroupPanel = false;
            // 
            // gridView4
            // 
            this.gridView4.GridControl = this.gcThucAn;
            this.gridView4.Name = "gridView4";
            // 
            // gcLoaiThucAn
            // 
            this.tablePanel1.SetColumn(this.gcLoaiThucAn, 0);
            this.gcLoaiThucAn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcLoaiThucAn.Location = new System.Drawing.Point(3, 223);
            this.gcLoaiThucAn.MainView = this.gvLoaiThucAn;
            this.gcLoaiThucAn.Name = "gcLoaiThucAn";
            this.tablePanel1.SetRow(this.gcLoaiThucAn, 1);
            this.gcLoaiThucAn.Size = new System.Drawing.Size(388, 228);
            this.gcLoaiThucAn.TabIndex = 0;
            this.gcLoaiThucAn.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLoaiThucAn});
            // 
            // gvLoaiThucAn
            // 
            this.gvLoaiThucAn.GridControl = this.gcLoaiThucAn;
            this.gvLoaiThucAn.Name = "gvLoaiThucAn";
            this.gvLoaiThucAn.OptionsView.ShowGroupPanel = false;
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 21.48F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 38.52F)});
            this.tablePanel1.Controls.Add(this.groupControl1);
            this.tablePanel1.Controls.Add(this.gcThucAn);
            this.tablePanel1.Controls.Add(this.gcLoaiThucAn);
            this.tablePanel1.Controls.Add(this.groupControl2);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 220F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(1101, 454);
            this.tablePanel1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.tablePanel1.SetColumn(this.groupControl1, 0);
            this.groupControl1.Controls.Add(this.txtTenLoai);
            this.groupControl1.Controls.Add(this.txtMaLoai);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.btnLamMoi);
            this.groupControl1.Controls.Add(this.btnXoa);
            this.groupControl1.Controls.Add(this.btnSua);
            this.groupControl1.Controls.Add(this.btnThem);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.tablePanel1.SetRow(this.groupControl1, 0);
            this.groupControl1.Size = new System.Drawing.Size(388, 214);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Loại thức ăn";
            // 
            // txtTenLoai
            // 
            this.txtTenLoai.Location = new System.Drawing.Point(105, 89);
            this.txtTenLoai.Name = "txtTenLoai";
            this.txtTenLoai.Size = new System.Drawing.Size(237, 24);
            this.txtTenLoai.TabIndex = 3;
            // 
            // txtMaLoai
            // 
            this.txtMaLoai.Location = new System.Drawing.Point(105, 51);
            this.txtMaLoai.Name = "txtMaLoai";
            this.txtMaLoai.Size = new System.Drawing.Size(237, 24);
            this.txtMaLoai.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(24, 92);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(51, 17);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tên loại";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(24, 49);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(45, 17);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Mã loại";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(267, 137);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 30);
            this.btnLamMoi.TabIndex = 0;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(186, 137);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 30);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(105, 137);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 30);
            this.btnSua.TabIndex = 0;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(24, 137);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 30);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupControl2
            // 
            this.tablePanel1.SetColumn(this.groupControl2, 1);
            this.groupControl2.Controls.Add(this.txtGiaTA);
            this.groupControl2.Controls.Add(this.txtTenTA);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.txtMaTA);
            this.groupControl2.Controls.Add(this.simpleButton1);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Controls.Add(this.labelControl7);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.simpleButton2);
            this.groupControl2.Controls.Add(this.simpleButton3);
            this.groupControl2.Controls.Add(this.simpleButton4);
            this.groupControl2.Controls.Add(this.lukLoaiTA);
            this.groupControl2.Controls.Add(this.txtURL);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(397, 3);
            this.groupControl2.Name = "groupControl2";
            this.tablePanel1.SetRow(this.groupControl2, 0);
            this.groupControl2.Size = new System.Drawing.Size(701, 214);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Thức Ăn";
            // 
            // txtGiaTA
            // 
            this.txtGiaTA.Location = new System.Drawing.Point(129, 172);
            this.txtGiaTA.Name = "txtGiaTA";
            this.txtGiaTA.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtGiaTA.Size = new System.Drawing.Size(237, 24);
            this.txtGiaTA.TabIndex = 3;
            // 
            // txtTenTA
            // 
            this.txtTenTA.Location = new System.Drawing.Point(129, 89);
            this.txtTenTA.Name = "txtTenTA";
            this.txtTenTA.Size = new System.Drawing.Size(237, 24);
            this.txtTenTA.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(37, 49);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(73, 17);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Mã thức ăn";
            // 
            // txtMaTA
            // 
            this.txtMaTA.Location = new System.Drawing.Point(129, 51);
            this.txtMaTA.Name = "txtMaTA";
            this.txtMaTA.Size = new System.Drawing.Size(237, 24);
            this.txtMaTA.TabIndex = 3;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(484, 124);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 30);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Thêm";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(37, 137);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(81, 17);
            this.labelControl6.TabIndex = 1;
            this.labelControl6.Text = "Loại thức ăn";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(387, 54);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(29, 17);
            this.labelControl7.TabIndex = 1;
            this.labelControl7.Text = "URL";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(37, 175);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(22, 17);
            this.labelControl5.TabIndex = 1;
            this.labelControl5.Text = "Giá";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(37, 92);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(79, 17);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "Tên thức ăn";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(565, 124);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 30);
            this.simpleButton2.TabIndex = 0;
            this.simpleButton2.Text = "Sửa";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(484, 171);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(75, 30);
            this.simpleButton3.TabIndex = 0;
            this.simpleButton3.Text = "Xoá";
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(565, 171);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(75, 30);
            this.simpleButton4.TabIndex = 0;
            this.simpleButton4.Text = "Làm mới";
            // 
            // lukLoaiTA
            // 
            this.lukLoaiTA.Location = new System.Drawing.Point(129, 134);
            this.lukLoaiTA.Name = "lukLoaiTA";
            this.lukLoaiTA.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lukLoaiTA.Properties.NullText = "";
            this.lukLoaiTA.Size = new System.Drawing.Size(237, 24);
            this.lukLoaiTA.TabIndex = 3;
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(427, 51);
            this.txtURL.Name = "txtURL";
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.txtURL.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.txtURL.Size = new System.Drawing.Size(237, 24);
            this.txtURL.TabIndex = 3;
            // 
            // frmThucAn_LoaiTA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 454);
            this.Controls.Add(this.tablePanel1);
            this.Name = "frmThucAn_LoaiTA";
            this.Text = "Món ăn";
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcThucAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvThucAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLoaiThucAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLoaiThucAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLoai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLoai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaTA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaTA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lukLoaiTA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtURL.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraGrid.GridControl gcLoaiThucAn;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLoaiThucAn;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.GridControl gcThucAn;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gvThucAn;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnLamMoi;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.TextEdit txtTenLoai;
        private DevExpress.XtraEditors.TextEdit txtMaLoai;
        private DevExpress.XtraEditors.TextEdit txtGiaTA;
        private DevExpress.XtraEditors.TextEdit txtTenTA;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtMaTA;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.LookUpEdit lukLoaiTA;
        private DevExpress.XtraEditors.ButtonEdit txtURL;
    }
}