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
        int enemySpeed =15;
        int score = 0;
        int enemyBulletTimer = 300;
        PictureBox[] elfek=new PictureBox[69];
        bool mozoghat = false;
        public Jatekter()
        {
            InitializeComponent();
            makeInvaders();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            enemyBulletTimer -= 10;
            
            if (enemyBulletTimer < 1)
            {
                enemyBulletTimer = 300;
                golo("sadBullet");
            } 
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
                        gameOver("You've been invaded by the invaders, you are now sad!");
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
                }

                if (x is PictureBox && (string)x.Tag == "bullet")
                {
                    x.Top -= 20;

                    if (x.Top < 15)
                    {
                        this.Controls.Remove(x);
                        ;
                    }
                }

                if (x is PictureBox && (string)x.Tag == "sadBullet")
                {

                    x.Top += 20;

                    if (x.Top > 620)
                    {
                        this.Controls.Remove(x);
                    }

                    if (x.Bounds.IntersectsWith(tank_pictureBox.Bounds))
                    {
                        this.Controls.Remove(x);
                        gameOver("You've been killed by the bullet. Now you are sad forever!");
                        
                    }

                }
            }
        

            if (score > 15)
            {
                enemySpeed = 25;
                playerSpeed = 30;
                
            }
            
            pontok_lbl.Text = $"Pontok: {score}";
            if (score == elfek.Length)
            {
                gameOver("NYERTÉL!!!!!");
                
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
                mozoghat = true;
            }
            
            if (e.KeyCode == Keys.Left && mozoghat == true)
            {
                tank_pictureBox.Location =new Point(tank_pictureBox.Location.X-playerSpeed,tank_pictureBox.Location.Y);
            }
            if (e.KeyCode == Keys.Right && mozoghat == true)
            {
                tank_pictureBox.Location = new Point(tank_pictureBox.Location.X + playerSpeed, tank_pictureBox.Location.Y);
            }
        }

        private void golo(string bulletTag)
        {
            PictureBox bullet = new PictureBox();
            bullet.Image = Properties.Resources.bullet;
            bullet.Size = new Size(5, 20);
            bullet.Tag = bulletTag;
            bullet.Left = tank_pictureBox.Left + tank_pictureBox.Width / 2;

            if ((string)bullet.Tag == "bullet")
            {
                bullet.Top = tank_pictureBox.Top - 20;
            }
            else if ((string)bullet.Tag == "sadBullet")
            {
                bullet.Top = -100;
            }


            this.Controls.Add(bullet);
            bullet.BringToFront();

        
    }

        private void makeInvaders()
        {

           
            int left =730 ;
            for (int i = 0; i < elfek.Length; i++)
            {

                elfek[i] = new PictureBox();
                elfek[i].Size = new Size(60, 50);
                elfek[i].Image = Properties.Resources.MicrosoftTeams_image__1__removebg_preview;
                elfek[i].SizeMode = PictureBoxSizeMode.StretchImage;
                elfek[i].Top = 15; 
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
        private void gameOver(string message)
        {
            
            timer1.Stop();
            MessageBox.Show(message + "Pontok: " + score);
            
            pontok_lbl.Text = $" Pontok: {score}";

            Application.Restart(); 
            
        }

        private void Jatekter_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                golo("bullet");
                //golo("sadbullet");
            }
        }
    }
}
