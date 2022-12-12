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
        static string[] muszka =new string[5] { "Sasha", "Vasily", "Dmitri", "Ivan", "Sergey" };
        public SimoSim()
        {
            InitializeComponent();
        }
        public void nehez(int diff)
        {
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
                timerend = velet.Next(100, 690);
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

        }

        private void Kattintas(object sender, EventArgs e)
        {
            PictureBox kattintott = sender as PictureBox;
            kattintott.Image = Properties.Resources.bloodymess;
            kattintott.Size = new Size(50, 20);
            kattintott.Location = new Point(kattintott.Location.X, kattintott.Location.Y + 10);
            enemies.Remove(kattintott);

        }

        private void timer_life_Tick(object sender, EventArgs e)
        {
            counter++;
            if (nehezseg==3)
            {
                
                if (counter == timerend)
                {
                    MessageBox.Show("Lelőttek a mesterlövész elfinek! Egy vagy a sok szár közül. Nem lehet újra kezdeni mert a mögötted lévőket is lelőtték.");
                }
            }
            else
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
                    MessageBox.Show("Olemme tehneet isänmaan ylpeyden!");
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
    }
}
