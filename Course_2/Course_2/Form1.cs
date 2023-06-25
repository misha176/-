using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
namespace Course_2
{
    public partial class Form1 : Form
    {
        private class AddPoints
        {
            private int index;
            private Point[] points;

            public AddPoints(int size)
            {
                if (size <= 0) size = 2;
                points = new Point[size];
            }
            public void SetPoint(int x, int y)
            {
                if (index >= points.Length)
                {
                    index = 0;
                }
                points[index] = new Point(x, y);
                index++;
            }
            public void ClearPoint()
            {
                index = 0;
            }
            public int GetCountPoits()
            {
                return index;
            }
            public Point[] GetPoints()
            {
                return points;
            }

        }
        public Form1()
        {
            InitializeComponent();
            start_job();
        }
        int name_Figures=0;// 1- замальовка, 2- пензлик;
        List<Pixel> pixels=new List<Pixel>(1280*1960);
        List<Pixel> pixels_start = new List<Pixel>(1280 * 1960);
        Color color_start;
        Color c_pixel_start;
        Bitmap bitmap;
        Bitmap bitmap_start;
        bool isMouse = false;
        private AddPoints addPoints = new AddPoints(2);
        Graphics graphics;
        Pen pen = new Pen(Color.Black);
        private void all_Color_Click(object sender, EventArgs e)
        {
            color_start = ((Button)sender).BackColor;
            pen.Color = ((Button)sender).BackColor;
        }
        private void start_job()
        {
            pictureBox1.Image = bitmap;
            pictureBox1.BackColor = Color.Gray;
            pen.StartCap = LineCap.Round;
            pen.EndCap = LineCap.Round;
        }
        private void b_open_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = null;
                bitmap_start = new Bitmap(openFileDialog1.FileName);
                bitmap = new Bitmap((int)(bitmap_start.Width), (int)(bitmap_start.Height));

                transformpicturs();
                foreach (Pixel aPixel in pixels_start)
                {
                    bitmap.SetPixel(aPixel.point.X, aPixel.point.Y, Color.Black);
                }
                pixels_start.Clear();
                graphics = Graphics.FromImage(bitmap);
                pictureBox1.Image = bitmap;
            }
        }

        private void transformpicturs()
        {
            Color col_pixel1, col_pixel2;
            int start_x=0, start_y=0;
            for (int i = 0; i < bitmap_start.Width; i++)
            {
                for (int j = 0; j < bitmap_start.Height; j++)
                {
                    bitmap.SetPixel(i, j, Color.White);
                }
            }
            do
            {
                col_pixel1 = bitmap_start.GetPixel(start_x, start_y);
                start_x++;
                col_pixel2 = bitmap_start.GetPixel(start_x+1, start_y);
                if ( start_x + 3 > bitmap_start.Width)
                {
                    start_y++;
                    start_x = 0;
                }
                bool Color_ind = ColorsAreClose(col_pixel1, col_pixel2);

                if (!Color_ind)
                {
                    pixels_start.Add(new Pixel() { point = new Point() { X = start_x, Y = start_y } });
                    if (start_x + 1 < bitmap_start.Width)
                        pixels_start.Add(new Pixel() { point = new Point() { X = start_x + 1, Y = start_y } });
                    if (start_x - 1 > 0)
                        pixels_start.Add(new Pixel() { point = new Point() { X = start_x - 1, Y = start_y } });
                }
            } while (bitmap_start.Height > start_y);
            start_x = 0;
            start_y = 0;
            do
            {
                col_pixel1 = bitmap_start.GetPixel(start_x, start_y);
                start_y++;
                col_pixel2 = bitmap_start.GetPixel(start_x , start_y+1);
                if (start_y + 3 > bitmap_start.Height)
                {
                    start_x++;
                    start_y = 0;
                }
                bool Color_ind = ColorsAreClose(col_pixel1, col_pixel2);
                
                if (!Color_ind)
                {
                    pixels_start.Add(new Pixel() { point = new Point() { X = start_x, Y = start_y } });
                    if (start_y + 1 < bitmap_start.Height)
                        pixels_start.Add(new Pixel() { point = new Point() { X = start_x, Y = start_y + 1 } });
                    if (start_y - 1 > 0)
                        pixels_start.Add(new Pixel() { point = new Point() { X = start_x, Y = start_y - 1 } });
                }
            } while (bitmap_start.Width > start_x);
        }

        bool ColorsAreClose(Color a, Color c)
        {
            int r = (int)a.R - c.R,
                g = (int)a.G - c.G,
                b = (int)a.B - c.B;
            return (r * r + g * g + b * b) <= 50 * 50;
        }

        private void x_minus_1(int start_x, int start_y)
        {
            Color col_pixel;
            bool run_x_m = true;
            do
            {
                start_x--;
                col_pixel = bitmap.GetPixel(start_x, start_y);
                if (col_pixel != c_pixel_start | start_y + 3 > bitmap.Height | start_x + 3 > bitmap.Width | start_x - 3 < 0 | start_y - 3 < 0)
                {
                    run_x_m = false;
                    break;
                }
                pixels.Add(new Pixel() { color = bitmap.GetPixel(start_x, start_y) });
                pixels.Add(new Pixel() { point = new Point() { X = start_x, Y = start_y } });
            } while (run_x_m);
        }

        private void x_plus_1(int start_x, int start_y)
        {

            Color col_pixel;
            bool run_x_p = true;
            do
            {
                start_x++;
                col_pixel = bitmap.GetPixel(start_x, start_y);
                if (col_pixel != c_pixel_start || start_y + 3 > bitmap.Height || start_x + 3 > bitmap.Width || start_x - 3 < 0 || start_y - 3 < 0)
                {
                    run_x_p = false;
                    break;
                }
                pixels.Add(new Pixel() { color = bitmap.GetPixel(start_x, start_y) });
                pixels.Add(new Pixel() { point = new Point() { X = start_x, Y = start_y } });
            } while (run_x_p);
        }

        private void y_plus_1(int start_x, int start_y)
        {
            Color col_pixel;
            bool run_y_p = true;

            do
            {
                start_y++;
                col_pixel = bitmap.GetPixel(start_x, start_y);
                if (col_pixel != c_pixel_start || start_y + 3 > bitmap.Height || start_x + 3 > bitmap.Width || start_x - 3 < 0 || start_y - 3 < 0)
                {
                    run_y_p = false;
                    break;
                }
                pixels.Add(new Pixel() { color = bitmap.GetPixel(start_x, start_y) });
                pixels.Add(new Pixel() { point = new Point() { X = start_x, Y = start_y } });
                
            } while (run_y_p);
        }

        private void y_minus_1(int start_x, int start_y)
        {
            Color col_pixel;
            bool run_y_m = true;
            do
            {
                start_y--;
                col_pixel = bitmap.GetPixel(start_x, start_y);
                if (col_pixel != c_pixel_start || start_y + 3 > bitmap.Height || start_x + 3 > bitmap.Width || start_x - 3 < 0 || start_y - 3 < 0)
                {
                    run_y_m = false;
                    break;
                }
                pixels.Add(new Pixel() { color = bitmap.GetPixel(start_x, start_y) });
                pixels.Add(new Pixel() { point = new Point() { X = start_x, Y = start_y } });
            } while (run_y_m);
        }

        private void x_plus(int start_x, int start_y)
        {
            
            Color col_pixel;
            bool run_x_p = true;
            do
            {
                start_x++;
                col_pixel = bitmap.GetPixel(start_x , start_y);
                if (col_pixel != c_pixel_start || start_y + 3 > bitmap.Height || start_x + 3 > bitmap.Width || start_x - 3 < 0 || start_y - 3 < 0)
                {
                    run_x_p = false;
                    
                    break;
                }
                pixels.Add(new Pixel() { color = bitmap.GetPixel(start_x, start_y) });
                pixels.Add(new Pixel() { point = new Point() { X = start_x, Y = start_y } });
                y_plus_1(start_x, start_y);
                y_minus_1(start_x, start_y);
            } while (run_x_p);
        }

        private void x_minus(int start_x, int start_y)
        {
            Color col_pixel;
            bool run_x_m=true;

            do
            {
                start_x--;
                col_pixel = bitmap.GetPixel(start_x , start_y);
                if (col_pixel != c_pixel_start || start_y + 3 > bitmap.Height || start_x + 3 > bitmap.Width || start_x - 3 < 0 || start_y - 3 < 0)
                {
                    run_x_m = false;
                    break;
                }
                pixels.Add(new Pixel() { color = bitmap.GetPixel(start_x, start_y) });
                pixels.Add(new Pixel() { point = new Point() { X = start_x, Y = start_y } });
                y_plus_1(start_x, start_y);
                y_minus_1(start_x, start_y);
            } while (run_x_m);
        }

        private void y_plus(int start_x, int start_y)
        {
            Color col_pixel;
            bool run_y_p = true;

            do
            {
                start_y++;
                col_pixel = bitmap.GetPixel(start_x, start_y );
                if (col_pixel != c_pixel_start || start_y + 3 > bitmap.Height || start_x + 3 > bitmap.Width || start_x - 3 < 0 || start_y - 3 < 0)
                {
                    run_y_p = false;
                    break;
                }
                pixels.Add(new Pixel() { color = bitmap.GetPixel(start_x, start_y) });
                pixels.Add(new Pixel() { point = new Point() { X = start_x, Y = start_y } });
                x_plus_1(start_x, start_y);
                x_minus_1(start_x, start_y);
            } while (run_y_p);
        }

        private void y_minus(int start_x, int start_y)
        {
            Color col_pixel;
            bool run_y_m = true;
            do
            {
                start_y--;
                col_pixel = bitmap.GetPixel(start_x, start_y );
                if (col_pixel != c_pixel_start || start_y + 3 > bitmap.Height || start_x + 3 > bitmap.Width || start_x - 3 < 0 || start_y - 3 < 0)
                {
                    run_y_m = false;
                    break;
                }
                pixels.Add(new Pixel() { color = bitmap.GetPixel(start_x, start_y) });
                pixels.Add(new Pixel() { point = new Point() { X = start_x, Y = start_y } });
                x_plus_1(start_x, start_y);
                x_minus_1(start_x, start_y);
            } while (run_y_m);
        }
        private void Draw_pros(int start_x, int start_y)
        {
            int x, y;
            x = start_x;
            y = start_y;
            x_plus(x, y);
            y_minus(x, y);
            x_minus(x, y);
            y_plus(x, y);
            foreach (Pixel aPixel in pixels)
            {
                bitmap.SetPixel(aPixel.point.X, aPixel.point.Y, color_start);
            }
            bitmap.SetPixel(start_x, start_y, color_start);
            pixels.Clear();
            pictureBox1.Image = bitmap;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (name_Figures == 1& bitmap.Width > e.X&bitmap.Height > e.Y)
            {
                int start_x, start_y;
                start_y = e.Y;
                start_x = e.X;
                c_pixel_start = bitmap.GetPixel(e.X, e.Y);
                Draw_pros(start_x, start_y);
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (name_Figures==2)
            {
                if (!isMouse) { return; }
                addPoints.SetPoint(e.X, e.Y);
                if (addPoints.GetCountPoits() >= 2 & name_Figures == 2)
                {
                    graphics.DrawLines(pen, addPoints.GetPoints());
                    pictureBox1.Image = bitmap;
                    addPoints.SetPoint(e.X, e.Y);

                }
            }
        }
        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            pen.Width = trackBar1.Value;
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {

            isMouse = false;
            addPoints.ClearPoint();

        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isMouse = true;
        }

        private void button_Save(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(saveFileDialog1.FileName);
            }
        }

        private void more_color(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                color_start = colorDialog1.Color;
                ((Button)sender).BackColor = colorDialog1.Color;
                pen.Color = colorDialog1.Color;
            }
        }

        private void b_Brush(object sender, EventArgs e)
        {
            name_Figures = 2;
        }

        private void b_Draw(object sender, EventArgs e)
        {
            name_Figures = 1;
        }

        private void b_return(object sender, EventArgs e)
        {
            pictureBox1.Image = bitmap;
        }
    }
}
