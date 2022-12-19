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
        static int time = 0;
        static int muzzleY;
        static int muzzleX;
        static bool jumped = false;
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
            muzzleX = pctbx_muzzle.Location.X;
            muzzleY = pctbx_muzzle.Location.Y;
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
                timer_flash.Start();

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
                    elfinvictory();
                    


                    
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

        private void elfinvictory()
        {
            Suomenvoitto uj = new Suomenvoitto();
            uj.Show();
            this.Dispose(false);
        }

        private void SimoSim_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void SimoSim_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            
            bool sikeres;
            if (pctbx_muzzle.Visible == true)
            {
                if (irany == "right" && (e.KeyChar).ToString().ToLower() == (Convert.ToChar(Keys.D)).ToString().ToLower())
                {
                    jumped = true;
                    pctbx_direction.Image = null;
                    pctbx_direction.Visible = false;
                    

                    sikeres = true;
                    ugras(sikeres);
                }
                else if (irany == "left" && e.KeyChar.ToString().ToLower() == (Convert.ToChar(Keys.A)).ToString().ToLower())
                {
                    jumped = true;
                    pctbx_direction.Image = null;
                    pctbx_direction.Visible = false;
                    

                    sikeres = true;
                    ugras(sikeres);
                }
                else if (irany == "left" && e.KeyChar.ToString().ToLower() == Convert.ToChar(Keys.D).ToString().ToLower())
                {
                    sikeres = false;
                    ugras(sikeres);
                }
                else if (irany == "right" && e.KeyChar.ToString().ToLower() == Convert.ToChar(Keys.A).ToString().ToLower())
                {
                    sikeres = false;
                    ugras(sikeres);
                }

            }
            
            if (!(e.KeyChar.ToString().ToLower() == Convert.ToChar(Keys.A).ToString().ToLower() && !(e.KeyChar.ToString().ToLower() == Convert.ToChar(Keys.D).ToString().ToLower())))
            {
                sikeres = false;
                ugras(sikeres);
            }


        }

        private void ugras(bool sikeres)
        {
            if (sikeres)
            {
                pctbx_direction.Image = null;
                pctbx_direction.Visible = false;
                irany = "";
            }
            else
            {


                timer_flash.Stop();
                lbl_anyways.Visible = true;
                lbl_ohno.Visible = true;
                this.BackgroundImage = Properties.Resources.rip;
                this.BackgroundImageLayout = ImageLayout.Zoom;
                this.BackColor = Color.Black;
                pctbx_muzzle.Visible = false;
                pctbx_direction.Visible = false;
                btn_stop.Visible = true;
                btn_continue.Visible = true;
                
            }
        }

        private void timer_flash_Tick(object sender, EventArgs e)
        {
            {
                time++;
                if (time==2&&irany=="")
                {
                    if (50<dir.Next(0,100))
                    {
                        irany = "right";
                        pctbx_letter.Image = Properties.Resources.D;
                        pctbx_direction.Image = Properties.Resources.arrow_right;
                        pctbx_direction.Visible = true;
                    }
                    else
                    {
                        irany = "left";
                        pctbx_letter.Image = Properties.Resources.A;
                        pctbx_direction.Image = Properties.Resources.arrow_left;
                        pctbx_direction.Visible = true;
                    }
                    time = 0;
                }
                if (time==5)
                {
                    jumped = false;
                    pctbx_muzzle.Location = new Point(muzzleX + muzzleloc.Next(0, 160), muzzleY + muzzleloc.Next(0, 160));
                    pctbx_muzzle.Visible = true;
                }
                if (time==6)
                {
                    pctbx_muzzle.Visible = false;
                    time = 0;
                    if (!jumped)
                    {
                        ugras(false);
                    }
                    
                }

                
                
            }
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            btn_stop.Visible = false;
            btn_continue.Visible = false;
            btn_other.Visible = true;
            btn_rest.Visible = true;
            lbl_doyouwant.Visible = true;
        }

        private void btn_continue_Click(object sender, EventArgs e)
        {
            SimoSim uj = new SimoSim();
            uj.nehez(3);
            uj.Show();
            this.Dispose(false);
        }

        private void btn_other_Click(object sender, EventArgs e)
        {
            Szint uj = new Szint();
            uj.Show();
            this.Dispose(false);
        }

        private void btn_rest_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
