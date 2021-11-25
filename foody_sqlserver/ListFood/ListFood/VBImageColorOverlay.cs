using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListFood
{
    public class VBImageColorOverlay : Panel
    {
        private int _opacityOverlay;
        private int af;
        private Color _backgroundColorOverlay;
        private int _borderRadius;
        private bool _overlayColorDefault;

        public VBImageColorOverlay()
        {
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
           // this.BackgroundImage = (Image)Resources.background;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.TabStop = false;
            this.Size = new Size(250, 250);
            this.OpacityOverlay = 50;
            this._backgroundColorOverlay = Color.MediumSlateBlue;
        }

        [Category("Custom Props")]
        public bool OverlayColorDefault
        {
            get => this._overlayColorDefault;
            set => this._overlayColorDefault = value;
        }

        [Category("Custom Props")]
        public int OpacityOverlay
        {
            get => this._opacityOverlay;
            set
            {
                if (value < 0 || value > 100)
                    return;
                this._opacityOverlay = value;
                this.af = Convert.ToInt32((double)this._opacityOverlay / 100.0 * (double)byte.MaxValue);
                if (!this.DesignMode)
                    return;
                this.Invalidate(false);
            }
        }

        [Category("Custom Props")]
        public Color BackgroundColorOverlay
        {
            get => this._backgroundColorOverlay;
            set
            {
                this._backgroundColorOverlay = value;
                if (!this.DesignMode)
                    return;
                this.Invalidate(false);
            }
        }

        [Category("Custom Props")]
        public Image VBBackgroundImage
        {
            get => this.BackgroundImage;
            set => this.BackgroundImage = value;
        }

        [Category("Custom Props")]
        public ImageLayout ImageLayout
        {
            get => this.BackgroundImageLayout;
            set => this.BackgroundImageLayout = value;
        }

        [Category("Custom Props")]
        public int BorderRadius
        {
            get => this._borderRadius;
            set
            {
                this._borderRadius = value;
                this.Invalidate();
            }
        }

        private void hgsgh()
        {
            if (this._overlayColorDefault)
                return;
            this._backgroundColorOverlay = Color.FromArgb(83, 97, 212);
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.hgsgh();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graphics = e.Graphics;
            using (SolidBrush solidBrush = new SolidBrush(Color.FromArgb(this.af, this._backgroundColorOverlay)))
            {
                graphics.FillRectangle((Brush)solidBrush, this.ClientRectangle);
                ppwag.dsadsa((Control)this, this._borderRadius, graphics);
            }
        }
    }

    public static class ppwag
    {
        private static GraphicsPath gfhfg(Rectangle daas, float hghg)
        {
            GraphicsPath graphicsPath = new GraphicsPath();
            float num = hghg * 2f;
            graphicsPath.StartFigure();
            graphicsPath.AddArc((float)daas.X, (float)daas.Y, num, num, 180f, 90f);
            graphicsPath.AddArc((float)daas.Right - num, (float)daas.Y, num, num, 270f, 90f);
            graphicsPath.AddArc((float)daas.Right - num, (float)daas.Bottom - num, num, num, 0.0f, 90f);
            graphicsPath.AddArc((float)daas.X, (float)daas.Bottom - num, num, num, 90f, 90f);
            graphicsPath.CloseFigure();
            return graphicsPath;
        }

        public static void dasfff(Control gdfgd, int hhfghfg)
        {
            if (hhfghfg >= 1)
            {
                using (GraphicsPath path = ppwag.gfhfg(gdfgd.ClientRectangle, (float)hhfghfg))
                    gdfgd.Region = new Region(path);
                gdfgd.Resize += (EventHandler)((s, e) =>
                {
                    using (GraphicsPath path = ppwag.gfhfg(gdfgd.ClientRectangle, (float)hhfghfg))
                        gdfgd.Region = new Region(path);
                });
            }
            else
            {
                gdfgd.Region = new Region(gdfgd.ClientRectangle);
                gdfgd.Resize += (EventHandler)((s, e) => gdfgd.Region = new Region(gdfgd.ClientRectangle));
            }
        }

        public static void dsadsa(Control hhgfh, int gjh, Graphics gr)
        {
            if (gjh > 1)
            {
                using (GraphicsPath path = ppwag.gfhfg(hhgfh.ClientRectangle, (float)gjh))
                {
                    using (Pen pen = new Pen(hhgfh.Parent.BackColor, 1f))
                    {
                        gr.SmoothingMode = SmoothingMode.AntiAlias;
                        hhgfh.Region = new Region(path);
                        gr.DrawPath(pen, path);
                    }
                }
            }
            else
                hhgfh.Region = new Region(hhgfh.ClientRectangle);
        }

        public static void dadasf(
          Control gdgdfg,
          int hgfhfgh,
          Graphics hgjgh,
          Color hfghfg,
          float wqdf)
        {
            if (hgfhfgh > 1)
            {
                using (GraphicsPath path = ppwag.gfhfg(gdgdfg.ClientRectangle, (float)hgfhfgh))
                {
                    using (Pen pen1 = new Pen(gdgdfg.Parent.BackColor, wqdf + 1f))
                    {
                        using (Pen pen2 = new Pen(hfghfg, wqdf))
                        {
                            using (Matrix matrix = new Matrix())
                            {
                                hgjgh.SmoothingMode = SmoothingMode.AntiAlias;
                                gdgdfg.Region = new Region(path);
                                hgjgh.DrawPath(pen1, path);
                                if ((double)wqdf < 1.0)
                                    return;
                                Rectangle clientRectangle = gdgdfg.ClientRectangle;
                                float scaleX = (float)(1.0 - ((double)wqdf + 1.0) / (double)clientRectangle.Width);
                                float scaleY = (float)(1.0 - ((double)wqdf + 1.0) / (double)clientRectangle.Height);
                                matrix.Scale(scaleX, scaleY);
                                matrix.Translate(wqdf / 1.6f, wqdf / 1.6f);
                                hgjgh.Transform = matrix;
                                hgjgh.DrawPath(pen2, path);
                            }
                        }
                    }
                }
            }
            else
            {
                gdgdfg.Region = new Region(gdgdfg.ClientRectangle);
                if ((double)wqdf >= 1.0)
                {
                    using (Pen pen = new Pen(hfghfg, wqdf))
                    {
                        pen.Alignment = PenAlignment.Inset;
                        hgjgh.DrawRectangle(pen, 0.0f, 0.0f, (float)gdgdfg.Width - 0.5f, (float)gdgdfg.Height - 0.5f);
                    }
                }
            }
        }
    }
}
