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
    public partial class Szint : Form
    {
        static int diff = 0;
        public Szint()
        {
            InitializeComponent();
            rdbtn_med.Checked = true;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (diff!=2)
            {
                SimoSim uj = new SimoSim();
                uj.nehez(diff);
                this.Hide();
                uj.Show();
            }
            else if (diff==2)
            {

            }
            
        }

        private void Szint_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void rdbtn_hell_CheckedChanged(object sender, EventArgs e)
        {
            diff = 3;
        }

        private void rdbtn_med_CheckedChanged(object sender, EventArgs e)
        {
            diff = 2;
        }

        private void rdbtn_tchórzliwa_cipka_CheckedChanged(object sender, EventArgs e)
        {
            diff = 1;
        }
    }
}
