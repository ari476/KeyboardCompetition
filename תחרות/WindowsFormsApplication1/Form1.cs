using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int c1 = 0, c2 = 0, c3 = 3;
        private bool pl1 = false, pl2 = false, over = true, ag =false;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int t = e.KeyValue;
            int a = e.KeyValue; 
           
            if (t == 65 || t == 68)
                a = t;
         
            if(!over)
            {
                if (a == 65 && c2 % 2 == 0)
                {
                    pl2 = true;
                    c2++;
                }
                else if (a == 68 && c2 % 2 != 0)
                {
                    pl2 = true;
                    c2++;
                }
                pcb2.Refresh();


                if (t == 100 && c1 % 2 == 0)
                {
                    pl1 = true;
                    c1++;
                }
                else if (t == 102 && c1 % 2 != 0)
                {
                    pl1 = true;
                    c1++;
                }
                pcb1.Refresh();

                pl1 = false;
                pl2 = false;

                if (c2 == 100)
                {
                    res.Text = "PLAYER 1 WIN"; over = true;
                }
                if (c1 == 100)
                {
                    res.Text = "PLAYER 2 WIN"; over = true;
                }

                if (c1 == 100 && c2 == 100)
                {
                    res.Text = "DRAW"; over = true;
                }

                if (over)
                    button1.Text = "AGAIN"; 
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void pcb1_Paint(object sender, PaintEventArgs e)
        {
            int Wd = pcb1.ClientRectangle.Width,     // רוחב וגובה של שטח הלקוח
                Ht = pcb1.ClientRectangle.Height;
                // קנה מידע לאורך ציר אופקי וציר אנכי
            float xScale = (float)(Wd / 100.0), yScale = (float)(Ht / 100.0);
            SolidBrush SBrush = new SolidBrush(Color.LightBlue);
            
            e.Graphics.FillRectangle(SBrush, 0, (100 - c1) * yScale, 100 * xScale, c1 * yScale);
                pr2.Text = "" + c1 + "%";
            if(ag)
                e.Graphics.FillRectangle(SBrush, 0,0,0,0);
            
            }

        private void pcb2_Paint(object sender, PaintEventArgs e)
        {
            int Wd = pcb1.ClientRectangle.Width,     // רוחב וגובה של שטח הלקוח
               Ht = pcb1.ClientRectangle.Height;
            // קנה מידע לאורך ציר אופקי וציר אנכי
            float xScale = (float)(Wd / 100.0), yScale = (float)(Ht / 100.0);
            SolidBrush SBrush = new SolidBrush(Color.LightBlue);
      
                e.Graphics.FillRectangle(SBrush, 0, (100 - c2) * yScale, 100 * xScale, c2 * yScale);
                pr1.Text = "" + c2 + "%";
            
            if (ag)
                    e.Graphics.FillRectangle(SBrush, 0, 0, 0, 0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string v = "GO";
            if (c3 != 0)
                button1.Text = "" + c3--;
            else
            {
                button1.Text = v;
                over = false;
                timer1.Stop();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "AGAIN")
            {
                c1 = 0; c2 = 0; c3 = 3;
                pl1 = false; pl2 = false;
                pr1.Text = ""; pr2.Text = "";
                ag = true; pcb1.Refresh(); pcb2.Refresh();
                res.Text = "";
            }
            
            timer1.Start(); 
        }
    }
}
