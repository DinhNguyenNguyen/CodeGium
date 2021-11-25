namespace QuanLyThucAn.From
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
            this.fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.aceChucNang = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aecDatMon = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceXemMon = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acePhieuGoiMon = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceHeThong = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceKhachHang = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceMonAn = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // fluentDesignFormContainer1
            // 
            this.fluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer1.Location = new System.Drawing.Point(260, 51);
            this.fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            this.fluentDesignFormContainer1.Size = new System.Drawing.Size(745, 408);
            this.fluentDesignFormContainer1.TabIndex = 0;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.aceChucNang,
            this.aceHeThong});
            this.accordionControl1.Location = new System.Drawing.Point(0, 51);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(260, 408);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
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
            // aceHeThong
            // 
            this.aceHeThong.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.aceKhachHang,
            this.aceMonAn});
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
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1005, 51);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 459);
            this.ControlContainer = this.fluentDesignFormContainer1;
            this.Controls.Add(this.fluentDesignFormContainer1);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Name = "frmMain";
            this.NavigationControl = this.accordionControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Other Food";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceChucNang;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aecDatMon;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceXemMon;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acePhieuGoiMon;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceHeThong;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceKhachHang;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceMonAn;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
    }
}