
namespace QuanLyThucAn
{
    partial class PickMonAn
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PickMonAn));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gcThucAn = new DevExpress.XtraGrid.GridControl();
            this.gvThucAn = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAdd = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSub = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.PickMonAnlayoutControl1ConvertedLayout = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.gcThucAnitem = new DevExpress.XtraLayout.LayoutControlItem();
            this.fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gcThucAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvThucAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PickMonAnlayoutControl1ConvertedLayout)).BeginInit();
            this.PickMonAnlayoutControl1ConvertedLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcThucAnitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // gcThucAn
            // 
            this.gcThucAn.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5);
            this.gcThucAn.Location = new System.Drawing.Point(12, 12);
            this.gcThucAn.MainView = this.gvThucAn;
            this.gcThucAn.Margin = new System.Windows.Forms.Padding(5);
            this.gcThucAn.Name = "gcThucAn";
            this.gcThucAn.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnAdd,
            this.btnSub});
            this.gcThucAn.Size = new System.Drawing.Size(956, 397);
            this.gcThucAn.TabIndex = 1;
            this.gcThucAn.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvThucAn});
            // 
            // gvThucAn
            // 
            this.gvThucAn.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn7,
            this.gridColumn5,
            this.gridColumn8});
            this.gvThucAn.DetailHeight = 535;
            this.gvThucAn.FixedLineWidth = 3;
            this.gvThucAn.GridControl = this.gcThucAn;
            this.gvThucAn.Name = "gvThucAn";
            this.gvThucAn.OptionsFind.AlwaysVisible = true;
            this.gvThucAn.OptionsFind.FindNullPrompt = "Nhập món ăn cần thêm..";
            this.gvThucAn.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã món ăn";
            this.gridColumn1.FieldName = "id_ThucAn";
            this.gridColumn1.MinWidth = 32;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 154;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên món ăn";
            this.gridColumn2.FieldName = "TenThucAn";
            this.gridColumn2.MinWidth = 32;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 336;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Loại thức ăn";
            this.gridColumn3.FieldName = "TenLoaiThucAn";
            this.gridColumn3.MinWidth = 32;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 330;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Giá tiền";
            this.gridColumn4.FieldName = "gia";
            this.gridColumn4.MinWidth = 32;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.OptionsColumn.ReadOnly = true;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 133;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Ảnh";
            this.gridColumn7.FieldName = "URL";
            this.gridColumn7.MinWidth = 32;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.OptionsColumn.ReadOnly = true;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 4;
            this.gridColumn7.Width = 156;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Thêm";
            this.gridColumn5.ColumnEdit = this.btnAdd;
            this.gridColumn5.MinWidth = 32;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 5;
            this.gridColumn5.Width = 120;
            // 
            // btnAdd
            // 
            this.btnAdd.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnAdd.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnAdd.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnAdd_ButtonClick_1);
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Số lượng";
            this.gridColumn8.MinWidth = 32;
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.AllowEdit = false;
            this.gridColumn8.OptionsColumn.ReadOnly = true;
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 6;
            this.gridColumn8.Width = 135;
            // 
            // btnSub
            // 
            this.btnSub.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.btnSub.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnSub.Name = "btnSub";
            this.btnSub.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // PickMonAnlayoutControl1ConvertedLayout
            // 
            this.PickMonAnlayoutControl1ConvertedLayout.Controls.Add(this.gcThucAn);
            this.PickMonAnlayoutControl1ConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PickMonAnlayoutControl1ConvertedLayout.Location = new System.Drawing.Point(0, 42);
            this.PickMonAnlayoutControl1ConvertedLayout.Name = "PickMonAnlayoutControl1ConvertedLayout";
            this.PickMonAnlayoutControl1ConvertedLayout.Root = this.layoutControlGroup1;
            this.PickMonAnlayoutControl1ConvertedLayout.Size = new System.Drawing.Size(980, 421);
            this.PickMonAnlayoutControl1ConvertedLayout.TabIndex = 2;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.gcThucAnitem});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(980, 421);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // gcThucAnitem
            // 
            this.gcThucAnitem.Control = this.gcThucAn;
            this.gcThucAnitem.Location = new System.Drawing.Point(0, 0);
            this.gcThucAnitem.Name = "gcThucAnitem";
            this.gcThucAnitem.Size = new System.Drawing.Size(960, 401);
            this.gcThucAnitem.TextSize = new System.Drawing.Size(0, 0);
            this.gcThucAnitem.TextVisible = false;
            // 
            // fluentDesignFormContainer1
            // 
            this.fluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer1.Location = new System.Drawing.Point(0, 42);
            this.fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            this.fluentDesignFormContainer1.Size = new System.Drawing.Size(980, 421);
            this.fluentDesignFormContainer1.TabIndex = 3;
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(980, 42);
            this.fluentDesignFormControl1.TabIndex = 5;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PickMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 463);
            this.ControlContainer = this.fluentDesignFormContainer1;
            this.Controls.Add(this.PickMonAnlayoutControl1ConvertedLayout);
            this.Controls.Add(this.fluentDesignFormContainer1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Name = "PickMonAn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PickMonAn";
            this.Load += new System.EventHandler(this.PickMonAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcThucAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvThucAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PickMonAnlayoutControl1ConvertedLayout)).EndInit();
            this.PickMonAnlayoutControl1ConvertedLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcThucAnitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcThucAn;
        private DevExpress.XtraGrid.Views.Grid.GridView gvThucAn;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnAdd;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnSub;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraLayout.LayoutControl PickMonAnlayoutControl1ConvertedLayout;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem gcThucAnitem;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private System.Windows.Forms.Timer timer1;
    }
}