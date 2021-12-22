using DevExpress.XtraBars;
using DevExpress.XtraCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyThucAn.From
{
    public partial class ThongKe : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public ThongKe()
        {
            InitializeComponent();
        }
        connect conn = new connect();
        void load_thongke()
        {
            pnThongKe.Controls.Clear();
            ChartControl chartControl1 = new ChartControl();
           
                Series Series1 = new Series("Thức ăn", ViewType.Line);
                Series Series2 = new Series("Phiếu bán", ViewType.Line);
                Series Series3 = new Series("Tiền", ViewType.Line);
            int count_sl = 0,count_money = 0,count_phieu = 0,i =0;
            string cmd1 = count_sl.ToString();
            string cmd2 = count_phieu.ToString();
            string cmd3 = count_money.ToString();
            Series1.Points.Add(new SeriesPoint(i, int.Parse(cmd1)));
            Series2.Points.Add(new SeriesPoint(i, int.Parse(cmd2)));
            Series3.Points.Add(new SeriesPoint(i, int.Parse(cmd3)));
            foreach (DataRow dr in conn.ex_data(string.Format("SELECT * FROM ttpb , phieuban pb where pb.id_PhieuBan = ttpb.id_TTPB and pb.NgayLapPhieu = '{0}'",DateTime.Now.ToString("yyyy-MM-dd"))).Rows)
            {
                i++;
                count_sl += int.Parse(dr["soluong"].ToString());
                count_phieu++;
                count_money += int.Parse(dr["thanhtien"].ToString());
            }
             cmd1 = count_sl.ToString();
             cmd2 = count_phieu.ToString();
             cmd3 = count_money.ToString();
            Series1.Points.Add(new SeriesPoint(i, int.Parse(cmd1)));
            Series2.Points.Add(new SeriesPoint(i, int.Parse(cmd2)));
            Series3.Points.Add(new SeriesPoint(i, int.Parse(cmd3)));

            chartControl1.Series.Add(Series1);
                chartControl1.Series.Add(Series2);
                chartControl1.Series.Add(Series3);
                Series1.ArgumentScaleType = ScaleType.Numerical;
                // Access the view-type-specific options of the series.
                ((LineSeriesView)Series1.View).MarkerVisibility = DevExpress.Utils.DefaultBoolean.True;
                ((LineSeriesView)Series1.View).LineMarkerOptions.Kind = MarkerKind.Triangle;
                ((LineSeriesView)Series1.View).LineStyle.DashStyle = DashStyle.Dash;
                ((LineSeriesView)Series2.View).MarkerVisibility = DevExpress.Utils.DefaultBoolean.True;
                ((LineSeriesView)Series2.View).LineMarkerOptions.Kind = MarkerKind.Triangle;
                ((LineSeriesView)Series2.View).LineStyle.DashStyle = DashStyle.Dash;
                ((LineSeriesView)Series3.View).MarkerVisibility = DevExpress.Utils.DefaultBoolean.True;
                ((LineSeriesView)Series3.View).LineMarkerOptions.Kind = MarkerKind.Triangle;
                ((LineSeriesView)Series3.View).LineStyle.DashStyle = DashStyle.Dash;
            
            // Access the type-specific options of the diagram.
            ((XYDiagram)chartControl1.Diagram).EnableAxisXZooming = true;
            ((XYDiagram)chartControl1.Diagram).AxisX.Label.TextPattern = "Hôm nay : {A:#}";
            // Hide the legend (if necessary).
            chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
            // Add the chart to the form.
            chartControl1.Dock = DockStyle.Fill;
            pnThongKe.Controls.Add(chartControl1);
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            load_thongke();
        }
    }
}
