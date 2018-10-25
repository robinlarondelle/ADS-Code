using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FractalRecursion
{
    public partial class Form1 : Form  
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.Blue, 3);
            drawTree(g, p, 250, 350, -90, 9);
            g.Dispose();
        }


        private static void drawTree(Graphics g, Pen p, int currentX, int currentY, double angle, int depth)
        {
            if (depth == 0) return;
            double length = depth * 7.0;
            int newX = currentX + (int)(Math.Cos(ConvertToRadians(angle)) * length);
            int newY = currentY + (int)(Math.Sin(ConvertToRadians(angle)) * length);
            g.DrawLine(p, currentX, currentY, newX, newY);
            drawTree(g, p, newX, newY, angle - 20, depth - 1);
            drawTree(g, p, newX, newY, angle + 20, depth - 1);
        }

        public static double ConvertToRadians(double angle)
        {
            return (Math.PI / 180) * angle;
        }
    }
}
