namespace QuanLyThucAn
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.aceHeThong = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceKhachHang = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceMonAn = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceDangXuat = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceChucNang = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aecDatMon = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceXemMon = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acePhieuGoiMon = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // aceHeThong
            // 
            this.aceHeThong.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.aceKhachHang,
            this.aceMonAn,
            this.aceDangXuat});
            this.aceHeThong.Expanded = true;
            this.aceHeThong.Name = "aceHeThong";
            this.aceHeThong.Text = "Hệ thống";
            // 
            // aceKhachHang
            // 
            this.aceKhachHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("aceKhachHang.ImageOptions.Image")));
            this.aceKhachHang.Name = "aceKhachHang";
            this.aceKhachHang.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceKhachHang.Text = "Khách hàng";
            this.aceKhachHang.Click += new System.EventHandler(this.aceKhachHang_Click);
            // 
            // aceMonAn
            // 
            this.aceMonAn.ImageOptions.Image = global::QuanLyThucAn.Properties.Resources.food;
            this.aceMonAn.Name = "aceMonAn";
            this.aceMonAn.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceMonAn.Text = "Món ăn";
            this.aceMonAn.Click += new System.EventHandler(this.aceMonAn_Click_1);
            // 
            // aceDangXuat
            // 
            this.aceDangXuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement2.ImageOptions.Image")));
            this.aceDangXuat.Name = "aceDangXuat";
            this.aceDangXuat.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceDangXuat.Text = "Đăng xuất";
            this.aceDangXuat.Click += new System.EventHandler(this.aceDangXuat_Click);
            // 
            // aceChucNang
            // 
            this.aceChucNang.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.aecDatMon,
            this.aceXemMon,
            this.acePhieuGoiMon});
            this.aceChucNang.Expanded = true;
            this.aceChucNang.Name = "aceChucNang";
            this.aceChucNang.Text = "Chức năng";
            // 
            // aecDatMon
            // 
            this.aecDatMon.ImageOptions.Image = global::QuanLyThucAn.Properties.Resources.menu;
            this.aecDatMon.Name = "aecDatMon";
            this.aecDatMon.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aecDatMon.Text = "Đặt món";
            this.aecDatMon.Click += new System.EventHandler(this.aecDatMon_Click);
            // 
            // aceXemMon
            // 
            this.aceXemMon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("aceXemMon.ImageOptions.Image")));
            this.aceXemMon.Name = "aceXemMon";
            this.aceXemMon.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceXemMon.Text = "Xem món";
            // 
            // acePhieuGoiMon
            // 
            this.acePhieuGoiMon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("acePhieuGoiMon.ImageOptions.Image")));
            this.acePhieuGoiMon.Name = "acePhieuGoiMon";
            this.acePhieuGoiMon.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acePhieuGoiMon.Text = "Phiếu gọi món";
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.aceChucNang,
            this.aceHeThong,
            this.accordionControlElement1});
            this.accordionControl1.Location = new System.Drawing.Point(0, 0);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(260, 483);
            this.accordionControl1.TabIndex = 5;
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Text = "Element1";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            this.xtraTabbedMdiManager1.PreviewPageZoomRatio = 1F;
            // 
            // frmMain
            // 
            this.Appearance.ForeColor = System.Drawing.Color.White;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 483);
            this.Controls.Add(this.accordionControl1);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("frmMain.IconOptions.LargeImage")));
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "OTHER FOOD";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.vc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceChucNang;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aecDatMon;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceXemMon;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acePhieuGoiMon;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceHeThong;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceKhachHang;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceMonAn;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceDangXuat;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
    }
}