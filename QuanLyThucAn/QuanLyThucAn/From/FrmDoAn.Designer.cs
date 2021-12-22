namespace QuanLyThucAn.From
{
    partial class FrmDoAn
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
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition4 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition5 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition6 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement4 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement5 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement6 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            this.tileViewColumn1 = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.tileViewColumn3 = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.tileViewColumn2 = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.btn_lm = new DevExpress.XtraEditors.SimpleButton();
            this.gc_DA = new DevExpress.XtraGrid.GridControl();
            this.tileView1 = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.gc_loadDA = new DevExpress.XtraGrid.GridControl();
            this.gv_loaiDA = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_DA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_loadDA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_loaiDA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tileViewColumn1
            // 
            this.tileViewColumn1.FieldName = "gia";
            this.tileViewColumn1.MinWidth = 18;
            this.tileViewColumn1.Name = "tileViewColumn1";
            this.tileViewColumn1.Visible = true;
            this.tileViewColumn1.VisibleIndex = 0;
            this.tileViewColumn1.Width = 69;
            // 
            // tileViewColumn3
            // 
            this.tileViewColumn3.FieldName = "tenthucan";
            this.tileViewColumn3.MinWidth = 18;
            this.tileViewColumn3.Name = "tileViewColumn3";
            this.tileViewColumn3.Visible = true;
            this.tileViewColumn3.VisibleIndex = 2;
            this.tileViewColumn3.Width = 69;
            // 
            // tileViewColumn2
            // 
            this.tileViewColumn2.FieldName = "url";
            this.tileViewColumn2.MinWidth = 18;
            this.tileViewColumn2.Name = "tileViewColumn2";
            this.tileViewColumn2.Visible = true;
            this.tileViewColumn2.VisibleIndex = 1;
            this.tileViewColumn2.Width = 69;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.CustomHeight = 200;
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            this.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.repositoryItemPictureEdit1.SvgImageSize = new System.Drawing.Size(200, 200);
            // 
            // btn_lm
            // 
            this.btn_lm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablePanel1.SetColumn(this.btn_lm, 1);
            this.btn_lm.Location = new System.Drawing.Point(987, 83);
            this.btn_lm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_lm.Name = "btn_lm";
            this.tablePanel1.SetRow(this.btn_lm, 0);
            this.btn_lm.Size = new System.Drawing.Size(111, 30);
            this.btn_lm.TabIndex = 4;
            this.btn_lm.Text = "Làm mới";
            this.btn_lm.Click += new System.EventHandler(this.btn_lm_Click);
            // 
            // gc_DA
            // 
            this.gc_DA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablePanel1.SetColumn(this.gc_DA, 0);
            this.gc_DA.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gc_DA.Location = new System.Drawing.Point(2, 203);
            this.gc_DA.MainView = this.tileView1;
            this.gc_DA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gc_DA.Name = "gc_DA";
            this.tablePanel1.SetRow(this.gc_DA, 1);
            this.gc_DA.Size = new System.Drawing.Size(981, 244);
            this.gc_DA.TabIndex = 1;
            this.gc_DA.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tileView1});
            // 
            // tileView1
            // 
            this.tileView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.tileViewColumn1,
            this.tileViewColumn2,
            this.tileViewColumn3});
            this.tileView1.DetailHeight = 229;
            this.tileView1.GridControl = this.gc_DA;
            this.tileView1.Name = "tileView1";
            this.tileView1.OptionsTiles.ItemSize = new System.Drawing.Size(416, 254);
            this.tileView1.OptionsTiles.RowCount = 0;
            tableRowDefinition4.Length.Value = 161D;
            tableRowDefinition5.Length.Value = 39D;
            tableRowDefinition6.Length.Value = 38D;
            this.tileView1.TileRows.Add(tableRowDefinition4);
            this.tileView1.TileRows.Add(tableRowDefinition5);
            this.tileView1.TileRows.Add(tableRowDefinition6);
            tileViewItemElement4.Column = this.tileViewColumn1;
            tileViewItemElement4.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement4.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement4.RowIndex = 2;
            tileViewItemElement4.Text = "tileViewColumn1";
            tileViewItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement5.Column = this.tileViewColumn3;
            tileViewItemElement5.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement5.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement5.RowIndex = 1;
            tileViewItemElement5.Text = "tileViewColumn3";
            tileViewItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement6.Column = this.tileViewColumn2;
            tileViewItemElement6.Height = 300;
            tileViewItemElement6.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement6.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement6.Text = "tileViewColumn2";
            tileViewItemElement6.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileView1.TileTemplate.Add(tileViewItemElement4);
            this.tileView1.TileTemplate.Add(tileViewItemElement5);
            this.tileView1.TileTemplate.Add(tileViewItemElement6);
            // 
            // gc_loadDA
            // 
            this.tablePanel1.SetColumn(this.gc_loadDA, 0);
            this.gc_loadDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_loadDA.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gc_loadDA.Location = new System.Drawing.Point(2, 2);
            this.gc_loadDA.MainView = this.gv_loaiDA;
            this.gc_loadDA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gc_loadDA.Name = "gc_loadDA";
            this.tablePanel1.SetRow(this.gc_loadDA, 0);
            this.gc_loadDA.Size = new System.Drawing.Size(981, 192);
            this.gc_loadDA.TabIndex = 0;
            this.gc_loadDA.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_loaiDA});
            // 
            // gv_loaiDA
            // 
            this.gv_loaiDA.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gv_loaiDA.DetailHeight = 229;
            this.gv_loaiDA.FixedLineWidth = 1;
            this.gv_loaiDA.GridControl = this.gc_loadDA;
            this.gv_loaiDA.Name = "gv_loaiDA";
            this.gv_loaiDA.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gv_loaiDA.OptionsBehavior.Editable = false;
            this.gv_loaiDA.OptionsSelection.MultiSelect = true;
            this.gv_loaiDA.OptionsView.ShowGroupPanel = false;
            this.gv_loaiDA.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gv_loaiDA_RowCellClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Số thứ tự";
            this.gridColumn1.FieldName = "stt";
            this.gridColumn1.MinWidth = 18;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 69;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Loại Thức Ăn";
            this.gridColumn2.FieldName = "TenTL";
            this.gridColumn2.MinWidth = 18;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 69;
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 53.71F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 6.29F)});
            this.tablePanel1.Controls.Add(this.gc_loadDA);
            this.tablePanel1.Controls.Add(this.gc_DA);
            this.tablePanel1.Controls.Add(this.btn_lm);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 196F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(1100, 454);
            this.tablePanel1.TabIndex = 5;
            // 
            // FrmDoAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 454);
            this.Controls.Add(this.tablePanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmDoAn";
            this.Text = "FrmDoAn";
            this.Load += new System.EventHandler(this.FrmDoAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_DA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_loadDA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_loaiDA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gc_loadDA;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_loaiDA;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraGrid.GridControl gc_DA;
        private DevExpress.XtraGrid.Views.Tile.TileView tileView1;
        private DevExpress.XtraGrid.Columns.TileViewColumn tileViewColumn1;
        private DevExpress.XtraGrid.Columns.TileViewColumn tileViewColumn2;
        private DevExpress.XtraGrid.Columns.TileViewColumn tileViewColumn3;
        private DevExpress.XtraEditors.SimpleButton btn_lm;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
    }
}