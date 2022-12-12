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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rchtxtbx_lore.Enabled = false;
            timer_crawl.Start();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Szint uj = new Szint();
            this.Hide();
            uj.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void timer_crawl_Tick(object sender, EventArgs e)
        {
            
            if (rchtxtbx_lore.Location.Y!=36)
            {
                rchtxtbx_lore.Location = new Point(rchtxtbx_lore.Location.X, rchtxtbx_lore.Location.Y - 2);
            }
            else if (rchtxtbx_lore.Location.X != 10)
            {
                timer_crawl.Interval = 2;
                rchtxtbx_lore.Location = new Point(rchtxtbx_lore.Location.X-1, rchtxtbx_lore.Location.Y);
            }
            else
            {
                this.MaximumSize = new Size(878, 507);
                if (this.Size== new Size(878, 507))
                {
                    timer_crawl.Stop();
                    
                    this.MinimumSize = new Size(878, 507);
                    pctbx_start.Visible = true;
                    lbl_title.Visible = true;
                }
                else 
                {
                    this.MinimumSize = this.Size;
                    this.Size = new Size(this.Size.Width+10, this.Size.Height + 10);
                }
                
               
                
            }
                

            
            
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            timer_crawl.Stop();
            this.MinimumSize = new Size(878, 507);
            pctbx_start.Visible = true;
            lbl_title.Visible = true;
            rchtxtbx_lore.Location = new Point(10, 36);


        }
    }
}
