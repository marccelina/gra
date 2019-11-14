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
        public int zmienna1, zmienna2;
        public int[] Tablicadogry;
        public Form2()
        {
            InitializeComponent();
            Tablica();

            List<Button> button = new List<Button>
            { button1,button2,button3,button4, button5,button6 };

            for (int i = 0; i < 90; i++)
            {
                    foreach (var item in button)
                    {
                       item.Text = Tablicadogry[i].ToString();
                        
                    }
                    
            }

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
            //uzytkownik1.wspX = e.X;
            //uzytkownik1.wspY = e.Y;
           //Invalidate();
            /* string s, c;
             s = index.ToString();
             c = index2.ToString();
             MessageBox.Show(c);
             MessageBox.Show(s);*/
        }

        public void Tablica() {

            
            Tablicadogry = new int[82];
            Random random = new Random();
            for (int i = 0; i < 8; i++)
            {
                
                
                  zmienna1 = random.Next(240, 1530);
                  zmienna2 = zmienna1 / 120;
                  Tablicadogry[i] = zmienna2;
                 }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Pink  ;
            button1.Text = " ";

            //ruch komputera
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            
          /* Graphics l = e.Graphics;
            Pen p = new Pen(Color.Black, 2);


            for (int i = 0; i < 451; i = i + 60)
            {
                for (int j = 0; j < 451; j = j + 60)
                {
                    l.DrawRectangle(p, 600 + j, 200 + i, 60, 60);
                }
            }
            //Random random = new Random();
            for (int a = 0; a < 8; a++) {
                for (int b = 0 ; b < 8; b++){
                for (int i = 0; i < 451; i = i + 60)
                {
                    for (int j = 0; j < 451; j = j + 60)
                    {
                        string s = Tablicadogry[a, b].ToString();
                        FontFamily ff = new FontFamily("Arial");
                        System.Drawing.Font font = new System.Drawing.Font(ff, 20);
                        l.DrawString(s, font, Brushes.Red, 610 + i, 210 + j);
                    }
                } } }
            
            int index, index2;
            index = uzytkownik1.wspY ;
            index2 = uzytkownik1.wspX ;
             string d, c;
             d = index.ToString();
             c = index2.ToString();
             MessageBox.Show(c);
             MessageBox.Show(d);


            
            
           e.Graphics.FillRectangle(Brushes.Pink, uzytkownik1.wspX, uzytkownik1.wspY, 60, 60);
            //e.Graphics.Save();
           */
        }

    }
}
