using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        Użytkownik uzytkownik1 = new Użytkownik();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {

            //int index = 0;
            //int index2 = 0;
            //index = e.X;
            //index2 = e.Y;
            //użytkownik1.Wspol_myszki(e.X, e.Y);
            uzytkownik1.wspX = e.X;
            uzytkownik1.wspY = e.Y;
            
            /* string s, c;
             s = index.ToString();
             c = index2.ToString();
             MessageBox.Show(c);
             MessageBox.Show(s);*/

        }
        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            Graphics l = e.Graphics;
            Pen p = new Pen(Color.Black, 2);
            //RectangleF[,] R = new RectangleF[10,10];
            // Brush b = new Brush();
            //l.FillRectangle(b, 0, 0, 30, 30);
           

            for (int i = 0; i < 451; i = i + 60)
            {
                for (int j = 0; j < 451; j = j + 60)
                {
                    l.DrawRectangle(p, 600 + j, 200 + i, 60, 60);
                }
            }
            Random random = new Random();
            for (int i = 0; i < 451; i = i + 60)
            {

                for (int j = 0; j < 451; j = j + 60)
                {
                    int zmienna, zmienna1;
                    zmienna1 = random.Next(240, 1530);
                    zmienna = zmienna1 / 120;
                    string s = zmienna.ToString();
                    FontFamily ff = new FontFamily("Arial");
                    System.Drawing.Font font = new System.Drawing.Font(ff, 20);
                    l.DrawString(s, font, Brushes.Red, 610 + i, 210 + j);
                }
            }


            //if( uzytkownik1.wspY >=0   )
            
            e.Graphics.FillRectangle(Brushes.Pink, uzytkownik1.wspX,uzytkownik1.wspY, 60, 60);
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}
