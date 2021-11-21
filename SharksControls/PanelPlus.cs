using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SharksControls
{
    public partial class PanelPlus : Panel
    {
        [Description("Radius of border roundness"), Category("Data")]
        public int BorderRadius { get; set; }

        public PanelPlus()
        {
            InitializeComponent();

            SetStyle(ControlStyles.ResizeRedraw, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Declare and instantiate a new pen.  
            using (System.Drawing.Pen myPen = new System.Drawing.Pen(Color.Aqua))
            {
                myPen.Width = 50;
                // Draw an aqua rectangle in the rectangle represented by the control.  
                e.Graphics.DrawRectangle(myPen, new Rectangle(
                    this.Location.X, this.Location.Y - BorderRadius / 2,
                    this.Size.Width, this.Size.Height - BorderRadius/2));

                e.Graphics.DrawRectangle(myPen, new Rectangle(
                    this.Location.X - BorderRadius / 2, this.Location.Y,
                    this.Size.Width - BorderRadius / 2, this.Size.Height));

                //e.Graphics.DrawArc();
            }
        }
    }
}
