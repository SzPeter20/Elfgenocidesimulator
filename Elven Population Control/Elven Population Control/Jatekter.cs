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
        PictureBox[] elfek=new PictureBox[50];
        public Jatekter()
        {
            InitializeComponent();
            makeInvaders();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "sadInvaders")
                {
                    x.Left += enemySpeed;

                    if (x.Left > 730)
                    {
                        x.Top += 65;
                        x.Left = -80;
                    }


                    if (x.Bounds.IntersectsWith(tank_pictureBox.Bounds))
                    {
                        MessageBox.Show("GAME OVER");
                    }

                    foreach (Control y in this.Controls)
                    {
                        if (y is PictureBox && (string)y.Tag == "bullet")
                        {
                            if (y.Bounds.IntersectsWith(x.Bounds))
                            {
                                this.Controls.Remove(x);
                                this.Controls.Remove(y);
                                score += 1;

                            }
                        }
                    }
                    if (score > 8)
                    {
                        enemySpeed = 12;
                    }
                }
            }
        }
        private void Jatekter_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void Jatekter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Space)
            {
                timer1.Start();
                pontok_lbl.Text = "Pontok: " + score;
                golo();
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

        private void golo()
        {
            PictureBox bullet = new PictureBox();
            bullet.Image = Properties.Resources.bullet_png_clipart_11;

        }

        private void makeInvaders()
        {

           
            int left = 0;
            for (int i = 0; i < elfek.Length; i++)
            {

                elfek[i] = new PictureBox();
                elfek[i].Size = new Size(60, 50);
                elfek[i].Image = Properties.Resources.MicrosoftTeams_image__1__removebg_preview;
                elfek[i].SizeMode = PictureBoxSizeMode.StretchImage;
                elfek[i].Top = 5; 
                elfek[i].Left = left;
                elfek[i].Tag = "sadInvaders";
                this.Controls.Add(elfek[i]);
                
                elfek[i].BackColor = Color.Transparent;
                left = left - 80;

            }


        }

        private void Jatekter_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
