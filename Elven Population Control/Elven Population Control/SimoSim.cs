using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elven_Population_Control
{
    public partial class SimoSim : Form
    {
        static int counter = 0;
        static int nehezseg = 0;
        static int timerend;
        static List<PictureBox> enemies =new List<PictureBox>();
        static int namec = 0;
        static Random muzzleloc = new Random();
        static Random dir = new Random();
        static int hel = 0;
        static string[] muszka =new string[5] { "Sasha", "Vasily", "Dmitri", "Ivan", "Sergey" };
        static string irany = "";
        public SimoSim()
        {
            InitializeComponent();
        }
        public void nehez(int diff)
        {
            if (diff==3)
            {
                this.BackgroundImage = Properties.Resources.forest;
            }
            nehezseg = diff;
            timerset();
        }

        private void timerset()
        {
            if (nehezseg==1)
            {
                HayasMosin();
            }
            else if (nehezseg == 3)
            {
                Random velet = new Random();
                timerend = velet.Next(80, 100);
                timer_life.Start();

                /*
                Olemme tehneet isänmaan ylpeyden!
                */
            }
        }

        private void HayasMosin()
        {
            generatesoldiers();
            timer_life.Start();
            
            

        }

        private void generatesoldiers()
        {

            PictureBox enemy = new PictureBox();
            enemy.BackColor = Color.Transparent;
            enemy.Size = new Size(30, 60);
            enemy.Location = new Point(200, 560);
            enemy.Image = Properties.Resources.soldier;
            enemy.SizeMode = PictureBoxSizeMode.Zoom;
            enemy.Click += new EventHandler(Kattintas);
            enemy.Name = muszka[namec];
            this.Controls.Add(enemy);
            enemies.Add(enemy);
            enemy.BringToFront();
            namec++;
            enemy.Cursor = System.Windows.Forms.Cursors.Cross;

        }

        private void Kattintas(object sender, EventArgs e)
        {
            PictureBox kattintott = sender as PictureBox;
            kattintott.Image = Properties.Resources.bloodymess;
            kattintott.Size = new Size(50, 20);
            if (enemies.Contains(kattintott))
            {
                kattintott.Location = new Point(kattintott.Location.X, kattintott.Location.Y + 10);
            }
            
            enemies.Remove(kattintott);
            

        }

        private void timer_life_Tick(object sender, EventArgs e)
        {
            counter++;


            {
                /*
                if (nehezseg==3)
                {
                    pctbx_muzzle.Location = new Point(pctbx_muzzle.Location.X + muzzleloc.Next(0, 130), pctbx_muzzle.Location.Y + muzzleloc.Next(0, 130));
                    if (pctbx_direction.Image==null&&counter/5==0)
                    {
                        if (dir.Next(0,100)>50)
                        {
                            pctbx_direction.Image = Properties.Resources.arrow_right;
                            pctbx_direction.Visible = true;
                            irany = "right";
                        }
                        else
                        {
                            pctbx_direction.Image = Properties.Resources.arrow_left;
                            pctbx_direction.Visible = true;
                            irany = "left";
                        }
                    }

                    if (counter/10==0)
                    {
                        hel = counter;

                        pctbx_muzzle.Visible = true;
                    }
                    if (counter==hel+3)
                    {
                        irany = "";
                        pctbx_muzzle.Visible = false;

                    }



                }
                else
                */
            }
            {
                if (counter==20)
                {
                    generatesoldiers();
                }
                else if (counter == 40)
                {
                    generatesoldiers();
                }
                else if (counter == 60)
                {
                    generatesoldiers();
                }
                else if (counter == 80)
                {
                    generatesoldiers();
                }
                if (enemies.Count==0)
                {
                    timer_life.Stop();
                    Suomenvoitto uj = new Suomenvoitto();
                    
                }
                else
                {
                    for (int i = 0; i < enemies.Count; i++)
                    {
                        enemies[i].Location = new Point(enemies[i].Location.X + 5, enemies[i].Location.Y);
                    }
                }
                
            }
            
        }

        private void SimoSim_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void SimoSim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (irany=="right"&& e.KeyChar==Convert.ToChar( Keys.Right))
            {
                bool sikeres = true;
                ugras(sikeres);
            }
            else if (irany=="left" && e.KeyChar == Convert.ToChar(Keys.Left))
            {
                bool sikeres = true;
                ugras(sikeres);
            }
            else if ((irany == "right" && !(e.KeyChar == Convert.ToChar(Keys.Right)))||(irany==""))
            {
                bool sikeres = false;
                ugras(sikeres);
            }
            else if ((irany == "left" && !(e.KeyChar == Convert.ToChar(Keys.Left))) || (irany == ""))
            {
                bool sikeres = false;
                ugras(sikeres);
            }
        }

        private void ugras(bool sikeres)
        {
            if (sikeres)
            {
                pctbx_direction.Image = null;
                irany = "";
                counter = 0;
            }
            else
            {
                lbl_anyways.Visible = true;
                lbl_ohno.Visible = true;
                this.BackgroundImage = null;
                this.BackColor = Color.Black;
                pctbx_muzzle.Visible = false;
                pctbx_direction.Visible = false;
            }
        }
    }
}
