namespace QLKHOVATLIEU
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ghhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tssanpham = new System.Windows.Forms.ToolStripMenuItem();
            this.tsloaisanpham = new System.Windows.Forms.ToolStripMenuItem();
            this.tskhachhang = new System.Windows.Forms.ToolStripMenuItem();
            this.tsnhanvien = new System.Windows.Forms.ToolStripMenuItem();
            this.tsphieunhap = new System.Windows.Forms.ToolStripMenuItem();
            this.tskhohang = new System.Windows.Forms.ToolStripMenuItem();
            this.hhToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ttHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.traCứuThôngKếToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tstracuu = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.name_login = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ghhToolStripMenuItem,
            this.hhToolStripMenuItem1,
            this.traCứuThôngKếToolStripMenuItem,
            this.helloToolStripMenuItem,
            this.name_login,
            this.đăngXuấtToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1237, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // ghhToolStripMenuItem
            // 
            this.ghhToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssanpham,
            this.tsloaisanpham,
            this.tskhachhang,
            this.tsnhanvien,
            this.tsphieunhap,
            this.tskhohang});
            this.ghhToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ghhToolStripMenuItem.Image")));
            this.ghhToolStripMenuItem.Name = "ghhToolStripMenuItem";
            this.ghhToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
            this.ghhToolStripMenuItem.Text = "Quản Lý Thông Tin";
            this.ghhToolStripMenuItem.Click += new System.EventHandler(this.ghhToolStripMenuItem_Click);
            // 
            // tssanpham
            // 
            this.tssanpham.Name = "tssanpham";
            this.tssanpham.Size = new System.Drawing.Size(255, 26);
            this.tssanpham.Text = "Thông Tin Sản Phẩm ";
            this.tssanpham.Click += new System.EventHandler(this.tssanpham_Click);
            // 
            // tsloaisanpham
            // 
            this.tsloaisanpham.Name = "tsloaisanpham";
            this.tsloaisanpham.Size = new System.Drawing.Size(255, 26);
            this.tsloaisanpham.Text = "Thông Tin Loại Sản Phẩm ";
            this.tsloaisanpham.Click += new System.EventHandler(this.tsloaisanpham_Click);
            // 
            // tskhachhang
            // 
            this.tskhachhang.Name = "tskhachhang";
            this.tskhachhang.Size = new System.Drawing.Size(255, 26);
            this.tskhachhang.Text = "Thông Tin Khách Hàng";
            this.tskhachhang.Click += new System.EventHandler(this.tskhachhang_Click);
            // 
            // tsnhanvien
            // 
            this.tsnhanvien.Name = "tsnhanvien";
            this.tsnhanvien.Size = new System.Drawing.Size(255, 26);
            this.tsnhanvien.Text = "Thông Tin Nhân Viên";
            this.tsnhanvien.Click += new System.EventHandler(this.tsnhanvien_Click);
            // 
            // tsphieunhap
            // 
            this.tsphieunhap.Name = "tsphieunhap";
            this.tsphieunhap.Size = new System.Drawing.Size(255, 26);
            this.tsphieunhap.Text = "Thông Tin Phiếu Nhập";
            this.tsphieunhap.Click += new System.EventHandler(this.tsphieunhap_Click);
            // 
            // tskhohang
            // 
            this.tskhohang.Name = "tskhohang";
            this.tskhohang.Size = new System.Drawing.Size(255, 26);
            this.tskhohang.Text = "Thông Tin Kho Hàng";
            this.tskhohang.Click += new System.EventHandler(this.tskhohang_Click);
            // 
            // hhToolStripMenuItem1
            // 
            this.hhToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ttHoaDon});
            this.hhToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("hhToolStripMenuItem1.Image")));
            this.hhToolStripMenuItem1.Name = "hhToolStripMenuItem1";
            this.hhToolStripMenuItem1.Size = new System.Drawing.Size(157, 24);
            this.hhToolStripMenuItem1.Text = "Quản Lý Hóa Đơn";
            this.hhToolStripMenuItem1.Click += new System.EventHandler(this.hhToolStripMenuItem1_Click);
            // 
            // ttHoaDon
            // 
            this.ttHoaDon.Name = "ttHoaDon";
            this.ttHoaDon.Size = new System.Drawing.Size(214, 26);
            this.ttHoaDon.Text = "Thông Tin Hóa Đơn";
            this.ttHoaDon.Click += new System.EventHandler(this.tsHoaDon_Click);
            // 
            // traCứuThôngKếToolStripMenuItem
            // 
            this.traCứuThôngKếToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstracuu});
            this.traCứuThôngKếToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("traCứuThôngKếToolStripMenuItem.Image")));
            this.traCứuThôngKếToolStripMenuItem.Name = "traCứuThôngKếToolStripMenuItem";
            this.traCứuThôngKếToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.traCứuThôngKếToolStripMenuItem.Text = "Tra Cứu _ Thông Kế";
            // 
            // tstracuu
            // 
            this.tstracuu.Name = "tstracuu";
            this.tstracuu.Size = new System.Drawing.Size(204, 26);
            this.tstracuu.Text = "Tra Cứu Thông Tin";
            this.tstracuu.Click += new System.EventHandler(this.tstracuu_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("đăngXuấtToolStripMenuItem.Image")));
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // ddToolStripMenuItem
            // 
            this.ddToolStripMenuItem.Name = "ddToolStripMenuItem";
            this.ddToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // ffToolStripMenuItem
            // 
            this.ffToolStripMenuItem.Name = "ffToolStripMenuItem";
            this.ffToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // helloToolStripMenuItem
            // 
            this.helloToolStripMenuItem.Name = "helloToolStripMenuItem";
            this.helloToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.helloToolStripMenuItem.Text = "Xin chào :";
            // 
            // name_login
            // 
            this.name_login.Name = "name_login";
            this.name_login.Size = new System.Drawing.Size(45, 24);
            this.name_login.Text = "null";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1237, 611);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Phần Mềm Quản Lý Kho";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ghhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tssanpham;
        private System.Windows.Forms.ToolStripMenuItem hhToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsloaisanpham;
        private System.Windows.Forms.ToolStripMenuItem tskhachhang;
        private System.Windows.Forms.ToolStripMenuItem tsnhanvien;
        private System.Windows.Forms.ToolStripMenuItem traCứuThôngKếToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsphieunhap;
        private System.Windows.Forms.ToolStripMenuItem ddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ttHoaDon;
        private System.Windows.Forms.ToolStripMenuItem tskhohang;
        private System.Windows.Forms.ToolStripMenuItem tstracuu;
        private System.Windows.Forms.ToolStripMenuItem helloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem name_login;
        private System.Windows.Forms.Timer timer1;
    }
}

