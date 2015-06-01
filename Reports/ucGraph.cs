using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reports
{
public partial class ucGraph : UserControl
{
    public int[] Data { get; set; }

    public ucGraph()
    {
        InitializeComponent();
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        //base.OnPaint(e);
        Graphics g = e.Graphics;
        int offset = 2; // border offset
        int offset2 = 15; // axis offset
        int offset3 = 5; // data offset x
        int offset4 = 2; // data offset y
        int max = 30;
        DrawFrame(g, offset);
        DrawAxis(g, offset, offset2);
        DrawData(g, offset, offset2, offset3, offset4, max);

    }

    private void DrawData(Graphics g, int offset, int offset2, int offset3, int offset4, int max)
    {

        if (Data != null)
        {
            for (int i = 0; i < 100; i++)
            {
                g.DrawLine(new Pen(Brushes.Blue, 3), new Point(4 * i + offset2 + offset3, this.Height - offset2 - offset - offset4), new Point(i * 4 + offset2 + offset3, (this.Height - offset2 - offset) - (Data[i] / max)));
            }
        }
    }

    private void DrawAxis(Graphics g, int offset, int offset2)
    {
        g.DrawLine(new Pen(Brushes.Green, 2), new Point(offset + offset2, this.Height - offset - offset2), new Point(offset + offset2, offset + offset2));
        g.DrawLine(new Pen(Brushes.Green, 2), new Point(offset + offset2, this.Height - offset - offset2), new Point(this.Width - offset - offset2, this.Height - offset - offset2));
    }

    private void DrawFrame(Graphics g, int offset)
    {
        g.DrawLine(new Pen(Brushes.Gray), new Point(offset, offset), new Point(this.Width - offset, offset));
        g.DrawLine(new Pen(Brushes.Gray), new Point(offset, this.Height - offset), new Point(this.Width - offset, this.Height - offset));
        g.DrawLine(new Pen(Brushes.Gray), new Point(offset, offset), new Point(offset, this.Height - offset));
        g.DrawLine(new Pen(Brushes.Gray), new Point(this.Width - offset, offset), new Point(this.Width - offset, this.Height - offset));
    }
}
}
