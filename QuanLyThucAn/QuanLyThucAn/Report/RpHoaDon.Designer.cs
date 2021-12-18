namespace QuanLyThucAn.Report
{
    partial class RpHoaDon
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrHoaDon = new DevExpress.XtraReports.UI.XRTable();
            this.xrRow_HoaDon = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrCell_MaHoaDon = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.lb_ma = new DevExpress.XtraReports.UI.XRLabel();
            this.lb_kh = new DevExpress.XtraReports.UI.XRLabel();
            this.lb_tien = new DevExpress.XtraReports.UI.XRLabel();
            this.lb_ngayban = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.xrHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.Dpi = 96F;
            this.TopMargin.HeightF = 96F;
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel7});
            this.BottomMargin.Dpi = 96F;
            this.BottomMargin.HeightF = 96F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lb_ngayban,
            this.lb_tien,
            this.lb_kh,
            this.lb_ma,
            this.xrLabel1,
            this.xrHoaDon});
            this.Detail.Dpi = 96F;
            this.Detail.HeightF = 331.6667F;
            this.Detail.Name = "Detail";
            // 
            // xrHoaDon
            // 
            this.xrHoaDon.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrHoaDon.Dpi = 96F;
            this.xrHoaDon.LocationFloat = new DevExpress.Utils.PointFloat(174F, 173F);
            this.xrHoaDon.Name = "xrHoaDon";
            this.xrHoaDon.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrHoaDon.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrRow_HoaDon});
            this.xrHoaDon.SizeF = new System.Drawing.SizeF(324.2222F, 22.08002F);
            this.xrHoaDon.StylePriority.UseBorders = false;
            // 
            // xrRow_HoaDon
            // 
            this.xrRow_HoaDon.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrRow_HoaDon.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrCell_MaHoaDon});
            this.xrRow_HoaDon.Dpi = 96F;
            this.xrRow_HoaDon.Name = "xrRow_HoaDon";
            this.xrRow_HoaDon.StylePriority.UseBorders = false;
            this.xrRow_HoaDon.Weight = 1D;
            // 
            // xrCell_MaHoaDon
            // 
            this.xrCell_MaHoaDon.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrCell_MaHoaDon.Dpi = 96F;
            this.xrCell_MaHoaDon.Multiline = true;
            this.xrCell_MaHoaDon.Name = "xrCell_MaHoaDon";
            this.xrCell_MaHoaDon.StylePriority.UseBorders = false;
            this.xrCell_MaHoaDon.Weight = 1D;
            // 
            // xrLabel1
            // 
            this.xrLabel1.Dpi = 96F;
            this.xrLabel1.Font = new System.Drawing.Font("Arial", 15.75F);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(247.2222F, 47.18224F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(156.9333F, 22.08F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.Text = "HOÁ ĐƠN";
            // 
            // lb_ma
            // 
            this.lb_ma.Dpi = 96F;
            this.lb_ma.LocationFloat = new DevExpress.Utils.PointFloat(10F, 10F);
            this.lb_ma.Multiline = true;
            this.lb_ma.Name = "lb_ma";
            this.lb_ma.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.lb_ma.SizeF = new System.Drawing.SizeF(200.4444F, 22.08F);
            this.lb_ma.Text = "Mã hoá đơn : ";
            // 
            // lb_kh
            // 
            this.lb_kh.Dpi = 96F;
            this.lb_kh.LocationFloat = new DevExpress.Utils.PointFloat(40.26666F, 93.6F);
            this.lb_kh.Multiline = true;
            this.lb_kh.Name = "lb_kh";
            this.lb_kh.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.lb_kh.SizeF = new System.Drawing.SizeF(245.7333F, 22.08F);
            this.lb_kh.Text = "Tên khách hàng : ";
            // 
            // lb_tien
            // 
            this.lb_tien.Dpi = 96F;
            this.lb_tien.LocationFloat = new DevExpress.Utils.PointFloat(40.26666F, 134.6667F);
            this.lb_tien.Multiline = true;
            this.lb_tien.Name = "lb_tien";
            this.lb_tien.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.lb_tien.SizeF = new System.Drawing.SizeF(245.7333F, 22.08F);
            this.lb_tien.Text = "Thành tiền : ";
            // 
            // lb_ngayban
            // 
            this.lb_ngayban.Dpi = 96F;
            this.lb_ngayban.LocationFloat = new DevExpress.Utils.PointFloat(40.26666F, 299.5867F);
            this.lb_ngayban.Multiline = true;
            this.lb_ngayban.Name = "lb_ngayban";
            this.lb_ngayban.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.lb_ngayban.SizeF = new System.Drawing.SizeF(206F, 22.08F);
            this.lb_ngayban.Text = "Ngày bán : ";
            // 
            // xrLabel7
            // 
            this.xrLabel7.Dpi = 96F;
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(19.6F, 63.92F);
            this.xrLabel7.Multiline = true;
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(96F, 22.08F);
            this.xrLabel7.Text = "xrLabel1";
            // 
            // RpHoaDon
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail});
            this.Dpi = 96F;
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(96, 96, 96, 96);
            this.PageHeight = 1056;
            this.PageWidth = 816;
            this.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.Pixels;
            this.SnapGridSize = 12.5F;
            this.Version = "19.2";
            ((System.ComponentModel.ISupportInitialize)(this.xrHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRTable xrHoaDon;
        private DevExpress.XtraReports.UI.XRTableRow xrRow_HoaDon;
        private DevExpress.XtraReports.UI.XRTableCell xrCell_MaHoaDon;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.XRLabel lb_ngayban;
        private DevExpress.XtraReports.UI.XRLabel lb_tien;
        private DevExpress.XtraReports.UI.XRLabel lb_kh;
        private DevExpress.XtraReports.UI.XRLabel lb_ma;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
    }
}
