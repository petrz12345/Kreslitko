using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kreslitko
{
    
    /*public void DrawStickman(Graphics g, Pen pen, int x, int y)
        {
            g.DrawEllipse(pen, x + 100, y + 100, 50, 50);
            g.DrawLine(pen, x + 125, y + 150, x + 125, y + 250);
            g.DrawLine(pen, x + 125, y + 250, x + 100, y + 300);
            g.DrawLine(pen, x + 125, y + 250, x + 150, y + 300);
            g.DrawLine(pen, x + 125, y + 160, x + 100, y + 200);
            g.DrawLine(pen, x + 125, y + 160, x + 150, y + 200);
        }*/
    public partial class Form1 : Form
    {
        //drawing library
        Graphics mobjGraphics;
        //konstrucktor
        public Form1()
        {
            InitializeComponent();
        }
        //form loading
        private void Form1_Load(object sender, EventArgs e)
        {
            //připojit grafiku na obrázkovou krabici
            mobjGraphics = pbCanvas.CreateGraphics();
        }

        private void btDraw_Click(object sender, EventArgs e)
        {
            Pen MyPen = new Pen(Color.Red); MyPen.Width = 4;

            //DrawStickman(mobjGraphics, MyPen);


            
            mobjGraphics.DrawEllipse(MyPen, 100, 100, 50, 50);
            mobjGraphics.DrawLine(MyPen, 125, 150, 125, 250);
            mobjGraphics.DrawLine(MyPen, 125, 250, 100, 300);
            mobjGraphics.DrawLine(MyPen, 125, 250, 150, 300);
            mobjGraphics.DrawLine(MyPen, 125, 160, 100, 200);
            mobjGraphics.DrawLine(MyPen, 125, 160, 150, 200);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtDisplay.Text = DateTime.Now.ToString();
        }
    }
}
