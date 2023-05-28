using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            start_job();
        }
        List<Pixel> pixels=new List<Pixel>(1280*1960); 
        Color color_start;
        Color c_pixel_start;
        static string file = @"C:\Users\Misha\source\repos\Course_2\Start_picture.png";
        Bitmap bitmap = new Bitmap(file);
        private void all_Color_Click(object sender, EventArgs e)
        {
            color_start = ((Button)sender).BackColor;
        }
        private void start_job()
        {
            pictureBox1.Image = bitmap;
            pictureBox1.BackColor = Color.Black;
        }
        private void b_open_Click(object sender, EventArgs e)
        {


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = null;
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
                bitmap = new Bitmap(openFileDialog1.FileName);
            }

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
        private void brush(int start_x, int start_y)
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
            int start_x, start_y;
            start_y = e.Y;
            start_x = e.X;
            c_pixel_start= bitmap.GetPixel(e.X, e.Y);
            brush(start_x, start_y);
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
            }
        }
    }
}
