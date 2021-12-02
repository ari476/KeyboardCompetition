using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace הימורים
{
    public partial class הימורים : Form
    {
        public הימורים()
        {
            InitializeComponent();
        }

        private int m =199, t = 30,  prr = 0,  pgr = 0,  pyr = 0,  prm = 0,  pgm = 0,  pym = 0,
            prb = 0, pgb = 0, pyb = 0, prl = 0, pgl = 0, pyl = 0, sum = 0, g = 1, temp, sum1 = 0;
        private int c = 0 , c1 = 0,  c2 = 0;
        private bool bcrr = false, bcgr = false, bcyr = false, bcrm = false, bcgm = false, bcym = false,
        bcrb = false, bcgb = false, bcyb = false, bcrl = false, bcgl = false, bcyl = false;

        private int vprr = 0, vpgr = 0, vpyr = 0, vprm = 0, vpgm = 0, vpym = 0,
           vprb = 0, vpgb = 0, vpyb = 0, vprl = 0, vpgl = 0, vpyl = 0;
        

        Random rgen = new Random();
        private void הימורים_Load(object sender, EventArgs e)
        {
            timer.Start();
            valu.Start();
        }
      
        private void timer_Tick(object sender, EventArgs e)
        {
            time.Text = "" + t--;
            if (time.Text == "0")
            {
                timer.Stop();
                en.Start();
                loto.Start();
                animals.Start();
            }
           
        }
       
        private void crr_MouseDown(object sender, MouseEventArgs e)
        {
            turr.Start();
        }

        private void crr_MouseUp(object sender, MouseEventArgs e)
        {
            turr.Stop();
        }
       
        private void tu_Tick(object sender, EventArgs e)
        {
            prr++;
            rr.Text = "" + prr;
            many.Text = "" + m--;
            if (rr.Text == "99")
            {
                crr.Enabled = false;
                turr.Stop();
            }
                 if( many.Text == "0")
                en.Start();
        }
     
        private void cgr_MouseDown(object sender, MouseEventArgs e)
        {
            tugr.Start();
        }

        private void cgr_MouseUp(object sender, MouseEventArgs e)
        {
            tugr.Stop();
        }

        private void tugr_Tick(object sender, EventArgs e)
        {
            pgr++;
            gr.Text = "" + pgr;
            many.Text = "" + m--;
            if (gr.Text == "99")
            {
                cgr.Enabled = false;
                tugr.Stop();
            }
             if( many.Text == "0")
                en.Start();
        }

        private void cyr_MouseDown(object sender, MouseEventArgs e)
        {
            tuyr.Start();
        }
     
        private void cyr_MouseUp(object sender, MouseEventArgs e)
        {
            tuyr.Stop();
        }
       
        private void tuyr_Tick(object sender, EventArgs e)
        {
            pyr++;
            yr.Text = "" + pyr;
            many.Text = "" + m--;
            if (yr.Text == "99")
            {
                cyr.Enabled = false;
                tuyr.Stop();
            }
                 if( many.Text == "0")
                en.Start();
        }

        private void crm_MouseDown(object sender, MouseEventArgs e)
        {
            turm.Start();
        }

        private void crm_MouseUp(object sender, MouseEventArgs e)
        {
            turm.Stop();
        }

        private void turm_Tick(object sender, EventArgs e)
        {
            prm++;
            rm.Text = "" + prm;
            many.Text = "" + m--;
            if (rm.Text == "99")
            {
                crm.Enabled = false;
                turm.Stop();
            }
                if( many.Text == "0")
                en.Start();
        }

        private void cgm_MouseDown(object sender, MouseEventArgs e)
        {
            tugm.Start();
        }

        private void cgm_MouseUp(object sender, MouseEventArgs e)
        {
            tugm.Stop();
        }

        private void tugm_Tick(object sender, EventArgs e)
        {
            pgm++;
            gm.Text = "" + pgm;
            many.Text = "" + m--;
            if (gm.Text == "99")
            {
                cgm.Enabled = false;
                tugm.Stop();
            }
                if( many.Text == "0")
                en.Start();
        }

        private void cym_MouseDown(object sender, MouseEventArgs e)
        {
            tuym.Start();
        }

        private void cym_MouseUp(object sender, MouseEventArgs e)
        {
            tuym.Stop();
        }

        private void tuym_Tick(object sender, EventArgs e)
        {
            pym++; 
            ym.Text = "" + pym;
            many.Text = "" + m--;
            if (ym.Text == "99")
            {
                cym.Enabled = false;
                tuym.Stop();
            }
                 if( many.Text == "0")
                en.Start();
        }

        private void crb_MouseDown(object sender, MouseEventArgs e)
        {
            turb.Start();
        }

        private void crb_MouseUp(object sender, MouseEventArgs e)
        {
            turb.Stop();
        }

        private void turb_Tick(object sender, EventArgs e)
        {
            prb++;
            rb.Text = "" + prb;
            many.Text = "" + m--;
            if (rb.Text == "99")
            {
                crb.Enabled = false;
                turb.Stop();
            }
             if( many.Text == "0")
                en.Start();
        }

        private void cgb_MouseDown(object sender, MouseEventArgs e)
        {
            tugb.Start();
        }

        private void cgb_MouseUp(object sender, MouseEventArgs e)
        {
            tugb.Stop();
        }

        private void tugb_Tick(object sender, EventArgs e)
        {
            pgb++;
            gb.Text = "" + pgb;
            many.Text = "" + m--;
            if (gb.Text == "99")
            {
                cgb.Enabled = false;
                tugb.Stop();
            }
             if( many.Text == "0")
                en.Start();
        }

        private void cyb_MouseDown(object sender, MouseEventArgs e)
        {
            tuyb.Start();
        }

        private void cyb_MouseUp(object sender, MouseEventArgs e)
        {
            tuyb.Stop();
        }

        private void tuyb_Tick(object sender, EventArgs e)
        {
            pyb++;
            yb.Text = "" + pyb;
            many.Text = "" + m--;
            if (yb.Text == "99")
            {
                cyb.Enabled = false;
                tuyb.Stop();
            } 
            if( many.Text == "0")
                en.Start();
        }

        private void crl_MouseDown(object sender, MouseEventArgs e)
        {
            turl.Start();
        }

        private void crl_MouseUp(object sender, MouseEventArgs e)
        {
            turl.Stop();
        }

        private void turl_Tick(object sender, EventArgs e)
        {
            prl++;
            rl.Text = "" + prl;
            many.Text = "" + m--;
            if (rl.Text == "99")
            {
                crl.Enabled = false;
                turl.Stop();
            }
             if( many.Text == "0")
                en.Start();
        }

        private void cgl_MouseDown(object sender, MouseEventArgs e)
        {
            tugl.Start();
        }

        private void cgl_MouseUp(object sender, MouseEventArgs e)
        {
            tugl.Stop();
        }

        private void tugl_Tick(object sender, EventArgs e)
        {
            pgl++;
            gl.Text = "" + pgl;
            many.Text = "" + m--;
            if (gl.Text == "99") 
            {
                cgl.Enabled = false;
                tugl.Stop();
            }
       
            if( many.Text == "0")
                en.Start();
        }

        private void cyl_MouseDown(object sender, MouseEventArgs e)
        {
            tuyl.Start();
        }

        private void cyl_MouseUp(object sender, MouseEventArgs e)
        {
            tuyl.Stop();
           
        }

        private void tuyl_Tick(object sender, EventArgs e)
        {
            pyl++;
            yl.Text = "" + pyl;
            many.Text = "" + m--;
            if (yl.Text == "99")
            {
                cyl.Enabled = false;
                tuyl.Stop();
            }

            if (many.Text == "0")
                en.Start();
        
        
        }

        private void en_Tick(object sender, EventArgs e)
        {
            crr.Enabled = false;
            cgr.Enabled = false;
            cyr.Enabled = false;
            crm.Enabled = false;
            cym.Enabled = false;
            cgm.Enabled = false;
            crb.Enabled = false;
            cgb.Enabled = false;
            cyb.Enabled = false;
            cgl.Enabled = false;
            crl.Enabled = false;
            cyl.Enabled = false;
            turr.Stop();
            tugr.Stop();
            tuyr.Stop();
            turm.Stop();
            tuym.Stop();
            tugm.Stop();
            turb.Stop();
            tugb.Stop();
            tuyb.Stop();
            tugl.Stop();
            turl.Stop();
            tuyl.Stop();
            en.Stop();
        }

        private void loto_Tick(object sender, EventArgs e)
        {
            int color = rgen.Next(3);
            switch (color)
            {
                case 0: pr.Visible = true; pg.Visible = false; py.Visible = false;
                    break;

                case 1: pr.Visible = false; pg.Visible = true; py.Visible = false;
                    break;

                default:
                        pr.Visible = false; pg.Visible = false; py.Visible = true;
                    break;
            }

            if (c == 55)
                loto.Interval = 700;
            if(c == 65)
                loto.Interval = 1500;
            if (c == 70)
                loto.Stop();
                 c++;

        }

        private void animals_Tick(object sender, EventArgs e)
        {
            int animal = rgen.Next(24);
            switch (animal)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                    pcbr.Visible = true; pcbm.Visible = false; pcbb.Visible = false; pcbl.Visible = false;
                    break;
                case 11:
                case 12:
                case 13:
                case 14:
                case 15:
                case 16:
                case 17:
                    pcbr.Visible = false; pcbm.Visible = true; pcbb.Visible = false; pcbl.Visible = false;
                    break;
                case 18:
                case 19:
                case 20:
                case 21:
                    pcbr.Visible = false; pcbm.Visible = false; pcbb.Visible = true; pcbl.Visible = false;
                    break;
                case 22:
                case 23:
                    pcbr.Visible = false; pcbm.Visible = false; pcbb.Visible = false; pcbl.Visible = true;
                    break;
            } 
          
            if (c == 55)
                animals.Interval = 700;
            if(c == 65)
                animals.Interval = 1500;
            if (c > 70)
            {
                c++;
                animals.Interval = 2300;
            }

            if (c == 75)
            {
                chake.Start();
                animals.Stop();
            }
        }         

        private void valu_Tick(object sender, EventArgs e)
        {
            int v = rgen.Next(5);
            int v1 = rgen.Next(3);
         
            switch(v)
            {
                case 0: switch (v1)
                    {
                        case 0: vrr.Text = "6"; vgr.Text = "5"; vyr.Text = "5";
                            vrm.Text = "10"; vgm.Text = "9"; vym.Text = "8";
                            vrb.Text = "18"; vgb.Text = "16"; vyb.Text = "14";
                            vrl.Text = "36"; vgl.Text = "32"; vyl.Text = "28";
                           
                            vprr = 6; vpgr = 5; vpyr = 5;
                            vprm = 10; vpgm = 9; vpym = 8;
                            vprb = 18; vpgb = 16; vpyb = 14;
                            vprl = 36; vpgl = 32; vpyl = 28;
                            break;
                    
                    
                    
                    
                    case 1: vrr.Text = "5"; vgr.Text = "6"; vyr.Text = "5";
                            vrm.Text = "10"; vgm.Text = "8"; vym.Text = "9";
                            vrb.Text = "18"; vgb.Text = "14"; vyb.Text = "16";
                            vrl.Text = "36"; vgl.Text = "28"; vyl.Text = "32";

                            vprr = 5; vpgr = 6; vpyr = 5;
                            vprm = 10; vpgm = 8; vpym = 9;
                            vprb = 18; vpgb = 14; vpyb = 16;
                            vprl = 36; vpgl = 28; vpyl = 32;
                            break;
                       
                    default: vrr.Text = "6"; vgr.Text = "5"; vyr.Text = "5";
                            vrm.Text = "8"; vgm.Text = "9"; vym.Text = "10";
                            vrb.Text = "14"; vgb.Text = "16"; vyb.Text = "18";
                            vrl.Text = "32"; vgl.Text = "28"; vyl.Text = "36";
                        
                            vprr = 6; vpgr = 5; vpyr = 5;
                            vprm = 8; vpgm = 9; vpym = 10;
                            vprb = 14; vpgb = 16; vpyb = 18;
                            vprl = 32; vpgl = 28; vpyl = 36;

                            break;
                    }
                 
                    break;

                case 1: switch (v1)
                    {
                        case 0: vrr.Text = "6"; vgr.Text = "7"; vyr.Text = "4";
                            vrm.Text = "10"; vgm.Text = "12"; vym.Text = "6";
                            vrb.Text = "18"; vgb.Text = "21"; vyb.Text = "11";
                            vrl.Text = "36"; vgl.Text = "43"; vyl.Text = "23";
                         
                            vprr = 6; vpgr = 7; vpyr = 4;
                            vprm = 10; vpgm = 12; vpym = 6;
                            vprb = 18; vpgb = 21; vpyb = 11;
                            vprl = 36; vpgl = 43; vpyl = 23;
                            break;

                        case 1: vrr.Text = "4"; vgr.Text = "6"; vyr.Text = "7";
                            vrm.Text = "6"; vgm.Text = "10"; vym.Text = "12";
                            vrb.Text = "18"; vgb.Text = "11"; vyb.Text = "21";
                            vrl.Text = "43"; vgl.Text = "36"; vyl.Text = "23";

                        
                            vprr = 4; vpgr = 6; vpyr = 7;
                            vprm = 6; vpgm = 10; vpym = 12;
                            vprb = 18; vpgb = 11; vpyb = 21;
                            vprl = 43; vpgl = 36; vpyl = 23;
                            break;

                        default: vrr.Text = "7"; vgr.Text = "4"; vyr.Text = "6";
                            vrm.Text = "12"; vgm.Text = "6"; vym.Text = "10";
                            vrb.Text = "18"; vgb.Text = "11"; vyb.Text = "21";
                            vrl.Text = "23"; vgl.Text = "43"; vyl.Text = "36";
                       
                            vprr = 7; vpgr = 4; vpyr = 6;
                            vprm = 12; vpgm = 6; vpym = 10;
                            vprb = 18; vpgb = 11; vpyb = 21;
                            vprl = 23; vpgl = 43; vpyl = 36;

                            break;
                    }

                    break;

                case 2: switch (v1)
                    {
                        case 0: vrr.Text = "4"; vgr.Text = "9"; vyr.Text = "5";
                            vrm.Text = "6"; vgm.Text = "14"; vym.Text = "9";
                            vrb.Text = "11"; vgb.Text = "25"; vyb.Text = "16";
                            vrl.Text = "23"; vgl.Text = "48"; vyl.Text = "32";
                         
                            vprr = 4; vpgr = 9; vpyr = 5;
                            vprm = 6; vpgm = 14; vpym = 9;
                            vprb = 11; vpgb = 25; vpyb = 16;
                            vprl = 23; vpgl = 48; vpyl = 32;
                           
                            break;

                        case 1: vrr.Text = "5"; vgr.Text = "4"; vyr.Text = "9";
                            vrm.Text = "9"; vgm.Text = "14"; vym.Text = "6";
                            vrb.Text = "25"; vgb.Text = "16"; vyb.Text = "11";
                            vrl.Text = "48"; vgl.Text = "23"; vyl.Text = "32";
                    
                      
                            vprr = 5; vpgr = 4; vpyr = 9;
                            vprm = 9; vpgm = 14; vpym = 6;
                            vprb = 25; vpgb = 16; vpyb = 11;
                            vprl = 48; vpgl = 23; vpyl = 32;

                            break;

                        default: vrr.Text = "9"; vgr.Text = "5"; vyr.Text = "4";
                            vrm.Text = "14"; vgm.Text = "9"; vym.Text = "6";
                            vrb.Text = "16"; vgb.Text = "11"; vyb.Text = "25";
                            vrl.Text = "23"; vgl.Text = "32"; vyl.Text = "48";

                          
                            vprr = 9; vpgr = 5; vpyr = 4;
                            vprm = 14; vpgm = 9; vpym = 6;
                            vprb = 16; vpgb = 11; vpyb = 25;
                            vprl = 23; vpgl = 32; vpyl = 48;
                          
                            break;
                    }

                    break;

                case 3: switch (v1)
                    {
                        case 0: vrr.Text = "3"; vgr.Text = "6"; vyr.Text = "9";
                            vrm.Text = "6"; vgm.Text = "14"; vym.Text = "10";
                            vrb.Text = "10"; vgb.Text = "25"; vyb.Text = "18";
                            vrl.Text = "21"; vgl.Text = "48"; vyl.Text = "36";
                        
                            vprr = 3; vpgr = 6; vpyr = 9;
                            vprm = 6; vpgm = 14; vpym = 10;
                            vprb = 10; vpgb = 25; vpyb = 18;
                            vprl = 21; vpgl = 48; vpyl = 36;
                            break;
                      
                    case 1: vrr.Text = "6"; vgr.Text = "9"; vyr.Text = "3";
                            vrm.Text = "10"; vgm.Text = "14"; vym.Text = "6";
                            vrb.Text = "25"; vgb.Text = "18"; vyb.Text = "10";
                            vrl.Text = "48"; vgl.Text = "36"; vyl.Text =  "21";
                        
                            vprr = 6; vpgr = 9; vpyr = 3;
                            vprm = 10; vpgm = 14; vpym = 6;
                            vprb = 25; vpgb = 18; vpyb = 10;
                            vprl = 48; vpgl = 36; vpyl = 21;

                            break;

                        default: vrr.Text = "9"; vgr.Text = "3"; vyr.Text = "6";
                            vrm.Text = "14"; vgm.Text = "6"; vym.Text = "10";
                            vrb.Text = "25"; vgb.Text = "10"; vyb.Text = "18";
                            vrl.Text = "36"; vgl.Text = "21"; vyl.Text = "48";
                        
                           
                            vprr = 9; vpgr = 3; vpyr = 6;
                            vprm = 14; vpgm = 6; vpym = 10;
                            vprb = 25; vpgb = 10; vpyb = 18;
                            vprl = 36; vpgl = 21; vpyl = 48;
                            break;
                    }

                    break;

                case 4: switch (v1)
                    {
                        case 0: vrr.Text = "7"; vgr.Text = "3"; vyr.Text = "9";
                            vrm.Text = "12"; vgm.Text = "5"; vym.Text = "14";
                            vrb.Text = "21"; vgb.Text = "9"; vyb.Text = "25";
                            vrl.Text = "43"; vgl.Text = "19"; vyl.Text = "48";

                        
                            vprr = 7; vpgr = 3; vpyr = 9;
                            vprm = 12; vpgm = 5; vpym = 14;
                            vprb = 21; vpgb = 9; vpyb = 25;
                            vprl = 43; vpgl = 19; vpyl = 48;
                            break;
                     
                    case 1: vrr.Text = "3"; vgr.Text = "7"; vyr.Text = "9";
                            vrm.Text = "5"; vgm.Text = "12"; vym.Text = "14";
                            vrb.Text = "9"; vgb.Text = "21"; vyb.Text = "25";
                            vrl.Text = "19"; vgl.Text = "43"; vyl.Text = "48";
                      
                         
                            vprr = 3; vpgr = 7; vpyr = 9;
                            vprm = 5; vpgm = 12; vpym = 14;
                            vprb = 9; vpgb = 21; vpyb = 25;
                            vprl = 19; vpgl = 43; vpyl = 48;
                            break;

                        default: vrr.Text = "9"; vgr.Text = "3"; vyr.Text = "7";
                            vrm.Text = "14"; vgm.Text = "5"; vym.Text = "12";
                            vrb.Text = "25"; vgb.Text = "9"; vyb.Text = "21";
                            vrl.Text = "48"; vgl.Text = "19"; vyl.Text = "43";
                        
                            vprr = 9; vpgr = 3; vpyr = 7;
                            vprm = 14; vpgm = 5; vpym = 12;
                            vprb = 25; vpgb = 9; vpyb = 21;
                            vprl = 48; vpgl = 19; vpyl = 43;

                            break;
                    }

                    break;
        
            }
            valu.Stop();
        }

        private void chake_Tick(object sender, EventArgs e)
        {
            c1 = 0;
            moov.Start();
            chake.Stop();
        }

        private void moov_Tick(object sender, EventArgs e)
        {
            c1++;
            if (pcbr.Visible && pr.Visible)
            {
                bcrr = true;
                if (c1 % 2 == 0)
                    crr.Visible = false;
                else
                    crr.Visible = true;
            }

            if (pcbr.Visible && pg.Visible)
            {
                bcgr = true;
                if (c1 % 2 == 0)
                    cgr.Visible = false;
                else
                    cgr.Visible = true;
            }
            if (pcbr.Visible && py.Visible)
            {
                bcyr = true;
                if (c1 % 2 == 0)
                    cyr.Visible = false;
                else
                    cyr.Visible = true;
            }
            if (pcbm.Visible && pr.Visible)
            {
                bcrm = true;
                if (c1 % 2 == 0)
                    crm.Visible = false;
                else
                    crm.Visible = true;
            }
            if (pcbm.Visible && pg.Visible)
            {
                bcgm = true;
                if (c1 % 2 == 0)
                    cgm.Visible = false;
                else
                    cgm.Visible = true;
            }
            if (pcbm.Visible && py.Visible)
            {
                bcym = true;
                if (c1 % 2 == 0)
                    cym.Visible = false;
                else
                    cym.Visible = true;
                }
            if (pcbb.Visible && pr.Visible)
            {
                bcrb = true;
                if (c1 % 2 == 0)
                    crb.Visible = false;
                else
                    crb.Visible = true;
            }
            if (pcbb.Visible && pg.Visible)
            {
                bcgb = true;
                if (c1 % 2 == 0)
                    cgb.Visible = false;
                else
                    cgb.Visible = true;
            }
            if (pcbb.Visible && py.Visible)
            {
                bcyb = true;
                if (c1 % 2 == 0)
                    cyb.Visible = false;
                else
                    cyb.Visible = true;
            }
            if (pcbl.Visible && pr.Visible)
            {
                bcrl = true;
                if (c1 % 2 == 0)
                    crl.Visible = false;
                else
                    crl.Visible = true;
            }
            if (pcbl.Visible && pg.Visible)
            {
                bcgl = true;
                if (c1 % 2 == 0)
                    cgl.Visible = false;
                else
                    cgl.Visible = true;
            }
            if (pcbl.Visible && py.Visible)
            {
                bcyl = true;
                if (c1 % 2 == 0)
                    cyl.Visible = false;
                else
                    cyl.Visible = true;
            }

            if (c1 == 15)
                moov.Stop();
                
           
                mn.Start();

        }

        private void mn_Tick(object sender, EventArgs e)
        {


            if (bcrr)
            {
                 sum = prr * vprr;
                win.Text = "" + sum;
            }
            if (bcgr)
            {
                sum = pgr * vpgr;
                win.Text = "" + sum;
            }
                    if (bcyr)
                {
                    sum = pyr * vpyr;
                    win.Text = "" + sum;
                }
                if (bcrm)
                {
                    sum = prm * vprm;
                    win.Text = "" + sum;
                }
                if (bcgm)
                {
                    sum = pgm * vpgm;
                    win.Text = "" + sum;
                }
                if (bcym)
                {
                    sum = pym * vpym;
                    win.Text = "" + sum;
                }
                if (bcrb)
                {
                    sum =prb * vprb;
                    win.Text = "" +  sum;
                }
                if (bcgb)
                {
                    sum = pgb * vpgb;
                    win.Text = "" +  sum;
                }
                if (bcyb)
                {
                    sum =pyb * vpyb;
                    win.Text = "" +  sum;
                }
                if (bcrl)
                {
                    sum =prl * vprl;
                    win.Text = "" +  sum;
                }
                if (bcgl)
                {
                    sum = pgl * vpgl;
                    win.Text = "" + sum;
                }
                if (bcyl)
                {
                    sum = pyl * vpyl;
                    win.Text = "" + sum;
                }

                temp = sum;       
            if (win.Text != "0")
                   moov1.Start();
            else
                bgein.Start();
           
            
            mn.Stop();




            }

        private void moov1_Tick(object sender, EventArgs e)
        {

            if (c2 > 15)
            {
               moov1.Stop();
               up.Start();
            }
            c2++;
            if (c2 % 2 == 0)
                win.Visible = false;
            else
                win.Visible = true;

          sum1 =  prr + pgr + pyr+ prm +pgm+ pym+ prb+ pgb+ pyb+ prl+ pgl +pyl;
          g = m;
        
        }

        private void up_Tick(object sender, EventArgs e)
        {
            if (g == sum + m)
            {
                bgein.Start();
                up.Stop();
            }
          
            g++;
                many.Text = "" + g;
                win.Text = "" + temp;
                moov.Stop();
                win.Visible = true;
                temp--; 
         
        }

        private void bgein_Tick(object sender, EventArgs e)
        {
            m = sum + m; t = 30;  prr = 0;  pgr = 0;  pyr = 0;  prm = 0;  pgm = 0;  pym = 0;
            prb = 0; pgb = 0; pyb = 0; prl = 0; pgl = 0; pyl = 0; sum = 0; g = 1; sum1 = 0;
            c = 0 ; c1 = 0;  c2 = 0;
            bcrr = false; bcgr = false; bcyr = false; bcrm = false; bcgm = false; bcym = false;
            bcrb = false; bcgb = false; bcyb = false; bcrl = false; bcgl = false; bcyl = false;
            vprr = 0; vpgr = 0; vpyr = 0; vprm = 0; vpgm = 0; vpym = 0;
            vprb = 0; vpgb = 0; vpyb = 0; vprl = 0; vpgl = 0; vpyl = 0;
          
            timer.Start();
            valu.Start();

            rr.Text = "0"; gr.Text = "0"; yr.Text = "0"; rm.Text = "0"; gm.Text = "0"; ym.Text = "0";
            rb.Text = "0"; gb.Text = "0"; yb.Text = "0"; rl.Text = "0"; gl.Text = "0"; yl.Text = "0";

            loto.Interval = 200;
            animals.Interval = 200;

            crr.Enabled = true;
            cgr.Enabled = true;
            cyr.Enabled = true;
            crm.Enabled = true;
            cym.Enabled = true;
            cgm.Enabled = true;
            crb.Enabled = true;
            cgb.Enabled = true;
            cyb.Enabled = true;
            cgl.Enabled = true;
            crl.Enabled = true;
            cyl.Enabled = true;
            moov.Stop();

            if (many.Text == "0")
                en.Start();
            bgein.Stop();
        
        }

     
       
     
       
    }

}