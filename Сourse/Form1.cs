using System;
using System.Drawing;

using System.Windows.Forms;

namespace Сourse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetSize();
        }
        private class AddPoints
        {
            private int index;
            private Point[] points;
            public AddPoints(int size)
            {
                if (size <= 0) size = 2;
                points = new Point[size];
            }
            public void SetPoint(int x,int y)
            {
                if (index >=points.Length )
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
            public int GetCountPoits() {
                return index;
            }
            public Point[] GetPoints()
            {
                return points;
            }
        }
        private AddPoints addPoints = new AddPoints(2);
        private bool Mouse = false;
        Bitmap map = new Bitmap(100, 100);
        Graphics graphics;
        Pen pen = new Pen(Color.Black);
        private void SetSize()
        {
            Rectangle rectangle = Screen.PrimaryScreen.Bounds;
            map = new Bitmap(rectangle.Width, rectangle.Height);
            graphics = Graphics.FromImage(map);
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Mouse = true;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            Mouse = false;
            addPoints.ClearPoint();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!Mouse) { return; }
            addPoints.SetPoint(e.X, e.Y);
            if (addPoints.GetCountPoits()>=2)
            {
                graphics.DrawLines(pen,addPoints.GetPoints());
                pictureBox1.Image = map;
                addPoints.SetPoint(e.X, e.Y);
                
            }
        }
    }
}
