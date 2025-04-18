using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class frm_Main_Form : Form
    {
        public frm_Main_Form()
        {
            InitializeComponent();

          //  this.Width = 900;
           // this.Height = 700;
            bm = new Bitmap(pic.Width , pic.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            pic.Image = bm;


        }

        Bitmap bm;
        Graphics g;
        bool paint = false;
        Point px, py;
        Pen p = new Pen(Color.Black ,1);
        Pen eraser = new Pen(Color.White, 50);
        int index;
        int x, y, sX, sY, cX, cY;


        ColorDialog cd = new ColorDialog();
        Color New_color;
        

        

        private void pic_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            if (paint)
            {

                if (index == 3)
                {
                    g.DrawEllipse(p, cX, cY, sX, sY);

                }
                if (index == 4)
                {
                    g.DrawRectangle(p, cX, cY, sX, sY);
                }
                if (index == 5)
                {
                    g.DrawLine(p, cX, cY, sX, sY);
                }

            }
        }

        

        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            py = e.Location;

            cX = e.X;
            cY = e.Y;
        }

        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                if (index == 1)
                {
                    px = e.Location;
                    g.DrawLine(p , px , py);
                    py = px;
                }

                if (index == 2)
                {
                    px = e.Location;
                    g.DrawLine(eraser, px, py);
                    py = px;
                }
            }
            pic.Refresh();

            x = e.X;
            y = e.Y;
            sX = e.X - cX;
            sY = e.Y - cY;


        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            pic.Image = bm;
            index = 0;
        }

        private void Btn_Color_Click(object sender, EventArgs e)
        {
            cd.ShowDialog();
            New_color = cd.Color;
            pic_color.BackColor = cd.Color;
            p.Color = cd.Color;
        }

        static Point set_point(PictureBox pb, Point pt)
        {

            float pX = 1f * pb.Width / pb.Width;
            float pY = 1f * pb.Height / pb.Height;
            return new Point((int)(pt.X*pX),(int)(pt.Y*pY));

        }

        private void btn_Pencil_Click(object sender, EventArgs e)
        {
            index = 1;

        }

        private void btn_Eraser_Click(object sender, EventArgs e)
        {
            index = 2;
        }

        private void btn_line_Click(object sender, EventArgs e)
        {
            index = 5;
        }
        private void btn_Ellipse_Click(object sender, EventArgs e)
        {
            index = 3;
        }
        private void btn_Rect_Click(object sender, EventArgs e)
        {
            index = 4;
        }

        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;

            sX = x - cX;
            sY = y - cY;

            if (index == 3)
            {
                g.DrawEllipse(p , cX , cY , sX , sY);

            }
            if (index == 4)
            {
                g.DrawRectangle(p, cX, cY, sX, sY);
            }
            if (index == 5)
            {
                g.DrawLine(p, cX, cY, sX, sY);
            }


        }

        


    }
}
