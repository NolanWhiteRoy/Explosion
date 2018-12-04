using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Explosion
{
    public partial class Form1 : Form
    {
        Graphics g;
        public Form1()
        {           
            InitializeComponent();
            g = this.CreateGraphics();
            
        }

        void drawExplosion(float x, float y, float pixels)
        {
            
            Pen exPen = new Pen(Color.Red, 2);
            //g.DrawRectangle(exPen, x, y, pixels, pixels);

            float scale = pixels / 100;//defines scale variable based on the known fact that the base drawing is 100 pixels wide. All lengths will be multiplied by scale.

            //line x values
            int x1 = 0;
            int x2 = 25;
            int x3 = 50;
            int x4 = 75;
            int x5 = 100;
            int x6 = 75;
            int x7 = 50;
            int x8 = 25;

            //line y values
            int y1 = 50;
            int y2 = 25;
            int y3 = 0;
            int y4 = 25;
            int y5 = 50;
            int y6 = 75;
            int y7 = 100;
            int y8 = 75;

            //octosecting lines drawn factoring scale and x and y parameters
            g.DrawLine(exPen, x1 * scale + x, y1 * scale + y, x5 * scale + x, y5 * scale + y);
            g.DrawLine(exPen, x2 * scale + x, y2 * scale + y, x6 * scale + x, y6 * scale + y);
            g.DrawLine(exPen, x3 * scale + x, y3 * scale + y, x7 * scale + x, y7 * scale + y);
            g.DrawLine(exPen, x4 * scale + x, y4 * scale + y, x8 * scale + x, y8 * scale + y);

            //definition of ellipse variables
            int ellipse1X = 25;
            int ellipse1Y = 25;
            int ellipse1Width = 50;

            int ellipse2X = 13;
            int ellipse2Y = 13;
            int ellipse2Width = 75;

            int ellipse3X = 0;
            int ellipse3Y = 0;
            int ellipse3Width = 100;

            int ellipse4X = 40;
            int ellipse4Y = 40;
            int ellipse4Width = 20;

            g.DrawEllipse(exPen, ellipse1X * scale + x, ellipse1Y * scale + y, ellipse1Width * scale , ellipse1Width * scale);
            exPen.Color = Color.Orange;
            g.DrawEllipse(exPen, ellipse2X * scale + x, ellipse2Y * scale + y, ellipse2Width * scale, ellipse2Width * scale);
            exPen.Color = Color.Yellow;
            g.DrawEllipse(exPen, ellipse3X * scale + x, ellipse3Y * scale + y, ellipse3Width * scale, ellipse3Width * scale);
            exPen.Width = 20* scale;
            g.DrawEllipse(exPen, ellipse4X * scale + x, ellipse4Y * scale + y, ellipse4Width * scale, ellipse4Width * scale);
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            drawExplosion(30, 50, 150);
        }
    }
}
