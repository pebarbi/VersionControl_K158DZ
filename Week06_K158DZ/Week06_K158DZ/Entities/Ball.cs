using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week06_K158DZ.Abstractions;
using System.Windows.Forms;

namespace Week06_K158DZ.Entities
{
    public class Ball : Toy
    {
        protected override void DrawImage(Graphics g)
        {
            g.FillEllipse(new SolidBrush(Color.Blue), 0, 0, Width, Height);
        }
    }




    //public class Ball : Label
    //{
    //    public Ball()
    //    {
    //        Width = 50;
    //        Height = Width;
    //        Paint += Ball_Paint;
    //        AutoSize = false;
    //    }

    //    private void Ball_Paint(object sender, PaintEventArgs e)
    //    {
    //        DrawImage(e.Graphics);
    //    }

    //    protected void DrawImage(Graphics g)
    //    {
    //        //var brush = new SolidBrush(Color.Blue);
    //        //g.FillEllipse(brush, 0, 0, Width, Height);
    //        g.FillEllipse(new SolidBrush(Color.Blue), 0, 0, Width, Height);
    //    }

    //    public void MoveBall()
    //    {
    //        Left += 1;
    //    }
}
}
