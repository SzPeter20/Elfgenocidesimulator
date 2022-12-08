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
    public partial class Jatekter : Form
    {
        int playerSpeed = 12;
        int enemySpeed = 5;
        int score = 0;
        PictureBox[] elfek=new PictureBox[10];
        public Jatekter()
        {
            InitializeComponent();
            makeInvaders();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void Jatekter_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void Jatekter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Space)
            {
                timer1.Start();
            }
            if (e.KeyCode == Keys.Left)
            {
                tank_pictureBox.Location =new Point(tank_pictureBox.Location.X-10,tank_pictureBox.Location.Y);
            }
            if (e.KeyCode == Keys.Right)
            {
                tank_pictureBox.Location = new Point(tank_pictureBox.Location.X + 10, tank_pictureBox.Location.Y);
            }
        }
        private void makeInvaders()
        {

            int x = 55;
            int y = 25;
            
            for (int i = 0; i < elfek.Length; i++)
            {

                elfek[i] = new PictureBox();
                elfek[i].Size = new Size(60, 50);
                elfek[i].Image = Properties.Resources.MicrosoftTeams_image__1__removebg_preview;
                elfek[i].SizeMode = PictureBoxSizeMode.StretchImage;
                this.Controls.Add(elfek[i]);
                elfek[i].Location = new Point();
                elfek[i].BackColor = Color.Transparent;
               
            }


        }

        private void Jatekter_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
