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
        //Constructor
        public Form1() => InitializeComponent();

        //Create window
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.Blue, 3);
            DrawTree(g, p, 250, 350, -90, 9);
            g.Dispose();
        }

        //This is the recursive method. You can see here that the DrawTree method is called within it's own body
        //Graphics g is the window, Pen p is used to draw a line in the window. CurrentX and CurrentY are the current
        //coordinates. The angle defines the angle between lines. Depth is the size of the problem, because depth
        //decides how "deep" we need to go. The DrawLine method is the work done. So when deciding what the time-
        //complexity is, we need to ask our self "How many times extra do i have to perform the work when the size
        //of the problem doubles?". Take n = 3, each branch splits in 2 new branches. So we have to perform 2x2x2 work
        //When n = 6, we have to perform 2x2x2x2x2x2 work. So: complexity is 2^n. This is an example of an Exponential 
        //complexity. Now for the memory-complexity, we have to look at how much memory is taken at any given point 
        //in time. The depth of the tree decides how many times DrawTree has to be called. So the depth of the tree also
        //decides how many memory there is used at any give time. So: memory-complexity -> O(n)
        //
        //time-complexity   -> O(2^n)
        //memory-complexity -> O(n)
        private static void DrawTree(Graphics g, Pen p, int currentX, int currentY, double angle, int depth)
        {
            //This is our stop-criteria
            if (depth == 0) return;

            //As we go deeper inside the tree, our tree-branch length will decline
            double length = depth * 7.0;

            //Create new coordinates for the new branch
            int newX = currentX + (int)(Math.Cos(ConvertToRadians(angle)) * length);
            int newY = currentY + (int)(Math.Sin(ConvertToRadians(angle)) * length);

            //Draw a line on the canvas. This is where the work is done
            g.DrawLine(p, currentX, currentY, newX, newY);

            //Create a new branch (this is the recursion)
            DrawTree(g, p, newX, newY, angle - 20, depth - 1);
            DrawTree(g, p, newX, newY, angle + 20, depth - 1);
        }

        private static double ConvertToRadians(double angle) => (Math.PI / 180) * angle;
    }
}
