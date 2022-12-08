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
        public Jatekter()
        {
            InitializeComponent();
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
                tank_pictureBox.Left -= playerSpeed;
            }
            if (e.KeyCode == Keys.Right)
            {
                tank_pictureBox.Left += playerSpeed;
            }
        }
    }
}
