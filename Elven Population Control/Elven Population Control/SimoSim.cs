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
                timerend = velet.Next(10, 69);
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
            for (int i = 0; i < 5; i++)
            {
                PictureBox enemy = new PictureBox();
                enemy.BackColor = Color.Transparent;
                enemy.Size = new Size(20,50);
                enemy.Location=new Point(85, 506);
            }
        }

        private void timer_life_Tick(object sender, EventArgs e)
        {

            counter++;
            if (counter==timerend)
            {
                MessageBox.Show("Lelőttek a mesterlövész finnelfek! Egy vagy a sok szár közül. Nem lehet újra kezdeni mert a mögötted lévőket is lelőtték.");
            }
        }
    }
}
