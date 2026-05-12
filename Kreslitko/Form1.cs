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
    
    

    public partial class Form1 : Form
    {
        //drawing library
        Graphics mobjGraphics;
        enum enHandState {up,down,disabled}; enHandState menState;
        Pen MyPenRed;
        Pen MyPenWhite;


        //konstrucktor
        public Form1()
        {
            InitializeComponent();
        }

        public void DrawStickman(Graphics g, Pen pen, int x, int y)
        {
            g.DrawEllipse(pen, x + 100, y + 100, 50, 50);
            g.DrawLine(pen, x + 125, y + 150, x + 125, y + 250);
            g.DrawLine(pen, x + 125, y + 250, x + 100, y + 300);
            g.DrawLine(pen, x + 125, y + 250, x + 150, y + 300);
            g.DrawLine(pen, x + 125, y + 160, x + 100, y + 200);
            g.DrawLine(pen, x + 125, y + 160, x + 150, y + 200);
        }

        //form loading
        private void Form1_Load(object sender, EventArgs e)
        {
            MyPenRed = new Pen(Color.Red); MyPenRed.Width = 4;
            MyPenWhite = new Pen(Color.White); MyPenWhite.Width = 4;


            //připojit grafiku na obrázkovou krabici
            mobjGraphics = pbCanvas.CreateGraphics();

            menState = enHandState.disabled;
        }

        private void btDraw_Click(object sender, EventArgs e)
        {
            menState = enHandState.down;

            DrawStickman(mobjGraphics, MyPenRed, 0, 0);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtDisplay.Text = DateTime.Now.ToString();

            //smazat ručičky a překreslit je
            if (menState == enHandState.down) {
                //smazat ručičky
                mobjGraphics.DrawLine(MyPenWhite, 125, 160, 100, 200);
                mobjGraphics.DrawLine(MyPenWhite, 125, 160, 150, 200);
                //překreslit
                mobjGraphics.DrawLine(MyPenRed, 125, 160, 100, 150);
                mobjGraphics.DrawLine(MyPenRed, 125, 160, 150, 150);
                //změnit stav
                menState = enHandState.up;

            }
            else if (menState == enHandState.up) {
                //smazat ručičky
                mobjGraphics.DrawLine(MyPenWhite, 125, 160, 100, 150);
                mobjGraphics.DrawLine(MyPenWhite, 125, 160, 150, 150);
                //překreslit
                mobjGraphics.DrawLine(MyPenRed, 125, 160, 100, 200);
                mobjGraphics.DrawLine(MyPenRed, 125, 160, 150, 200);
                //změnit stav
                menState = enHandState.down;

            }
        }
    }
}
