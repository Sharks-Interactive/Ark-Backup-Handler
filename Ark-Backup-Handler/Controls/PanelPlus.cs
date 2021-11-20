using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace ABH.Controls
{
    public partial class PanelPlus : Panel
    {
        public enum PanelShape
        {
            Rect,
            RoundRect,
            Circle
        }

        private Color m_hoverColor  = Color.Black;
        private Color m_normalColor = Color.Gray;
        private Color m_gradientColor;
        private Color m_borderColor = Color.Transparent;
        private int m_borderWidth   = 0;
        private int m_gradientAngle = 0;
        private PanelShape m_shape;

        public PanelShape Shape
        {
            get => m_shape;
            set  { m_shape = value; Invalidate(); }
        }
        public int BorderWidth
        {
            get => m_borderWidth;
            set  { m_borderWidth = value; Invalidate(); }
        }

        public Color BorderColor
        {
            get => m_borderColor;
            set  { m_borderColor = value; }
        }
        public Color NormalColor
        {
            get => m_normalColor;
            set  { m_normalColor = value; Invalidate(); }
        }
        public Color HoverColor
        {
            get => m_hoverColor;
            set  { m_hoverColor = value; Invalidate(); }
        }
        public Color GradientColor
        {
            get => m_gradientColor;
            set  { m_gradientColor = value; Invalidate(); }
        }

        public int GradientAngle
        {
            get => m_gradientAngle;
            set  { m_gradientAngle = value; Invalidate(); }
        }

        public PanelPlus()
        {
            this.Size = new Size(100, 40);
            this.BackColor = Color.Transparent;
        }

        #region Mouse Events
        protected override void OnMouseEnter(EventArgs Event)
        {
            base.OnMouseEnter(Event);
            this.BackColor = m_hoverColor;
        }
        
        protected override void OnMouseLeave(EventArgs Event)
        {
            base.OnMouseLeave(Event);
            this.BackColor = m_normalColor;
        }
        #endregion

        #region Rendering
        /*private void DrawPanelCircle(Graphics Graphics)
        {
            Color c1 = Color.FromArgb(color1Transparent, color1);
            Color c2 = Color.FromArgb(color2Transparent, color2);


            Brush b = new System.Drawing.Drawing2D.LinearGradientBrush(ClientRectangle, c1, c2, angle);
            g.FillEllipse(b, 5, 5, this.Width - 10, this.Height - 10);


            for (int i = 0; i < borderWidth; i++)
            {
                g.DrawArc(new Pen(new SolidBrush(buttonborder_1)), 5 + i, 5, this.Width - 10, this.Height - 10, 120, 180);
                g.DrawArc(new Pen(new SolidBrush(buttonborder_2)), 5, 5, this.Width - (10 + i), this.Height - 10, 300, 180);
            }




            if (showButtonText)
            {
                Point p = new Point(textX, textY);
                SolidBrush frcolor = new SolidBrush(this.ForeColor);
                g.DrawString(text, this.Font, frcolor, p);
            }

            b.Dispose();
        }*/

        /*private void DrawPanelRectangular(Graphics Graphics)
        {
            Color c1 = Color.FromArgb(color1Transparent, color1);
            Color c2 = Color.FromArgb(color2Transparent, color2);


            Brush b = new System.Drawing.Drawing2D.LinearGradientBrush(ClientRectangle, c1, c2, angle);
            g.FillRectangle(b, 0, 0, this.Width, this.Height);


            for (int i = 0; i < borderWidth; i++)
            {
                g.DrawLine(new Pen(new SolidBrush(buttonborder_1)), this.Width - i, 0, this.Width - i, this.Height);
                g.DrawLine(new Pen(new SolidBrush(buttonborder_1)), 0, this.Height - i, this.Width, this.Height - i);

                g.DrawLine(new Pen(new SolidBrush(buttonborder_2)), 0 + i, 0, 0 + i, this.Height);
                g.DrawLine(new Pen(new SolidBrush(buttonborder_2)), 0, 0 + i, this.Width, i);
            }



            if (showButtonText)
            {
                Point p = new Point(textX, textY);
                SolidBrush frcolor = new SolidBrush(this.ForeColor);
                g.DrawString(text, this.Font, frcolor, p);
            }

            b.Dispose();
        }*/

        private void DrawPanelRoundedRectangle(Graphics Graphics)
        {
            Brush _brush = new LinearGradientBrush(
                ClientRectangle, 
                m_normalColor, 
                m_gradientColor, 
                m_gradientAngle
                );
            Region _region = new Region(new Rectangle(5, 5, this.Width, this.Height));

            GraphicsPath _path = new GraphicsPath();
            _path.AddArc(5, 5, 40, 40, 180, 90);
            _path.AddLine(25, 5, this.Width - 25, 5);
            _path.AddArc(this.Width - 45, 5, 40, 40, 270, 90);
            _path.AddLine(this.Width - 5, 25, this.Width - 5, this.Height - 25);
            _path.AddArc(this.Width - 45, this.Height - 45, 40, 40, 0, 90);
            _path.AddLine(25, this.Height - 5, this.Width - 25, this.Height - 5);
            _path.AddArc(5, this.Height - 45, 40, 40, 90, 90);
            _path.AddLine(5, 25, 5, this.Height - 25);

            _region.Intersect(_path);

            Graphics.FillRegion(_brush, _region);

            for (int i = 0; i < m_borderWidth; i++)
            {
                Graphics.DrawArc(new Pen(m_borderColor), 5 + i, 5 + i, 40, 40, 180, 90);
                Graphics.DrawLine(new Pen(m_borderColor), 25, 5 + i, this.Width - 25, 5 + i);
                Graphics.DrawArc(new Pen(m_borderColor), this.Width - 45 - i, 5 + i, 40, 40, 270, 90);
                Graphics.DrawLine(new Pen(m_borderColor), 5 + i, 25, 5 + i, this.Height - 25);


                Graphics.DrawLine(new Pen(m_borderColor), this.Width - 5 - i, 25, this.Width - 5 - i, this.Height - 25);
                Graphics.DrawArc(new Pen(m_borderColor), this.Width - 45 - i, this.Height - 45 - i, 40, 40, 0, 90);
                Graphics.DrawLine(new Pen(m_borderColor), 25, this.Height - 5 - i, this.Width - 25, this.Height - 5 - i);
                Graphics.DrawArc(new Pen(m_borderColor), 5 + i, this.Height - 45 - i, 40, 40, 90, 90);

            }

            _brush.Dispose();
        }


        protected override void OnPaint(PaintEventArgs Event)
        {
            base.OnPaint(Event);

            switch (m_shape)
            {
                case PanelShape.Circle:
                    //this.DrawPanelCircle(Event.Graphics);
                    break;

                case PanelShape.Rect:
                    //this.DrawPanelRectangular(Event.Graphics);
                    break;

                case PanelShape.RoundRect:
                    this.DrawPanelRoundedRectangle(Event.Graphics);
                    break;
            }
        }
        #endregion
    }
}
