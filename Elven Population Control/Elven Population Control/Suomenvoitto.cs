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
    public partial class Suomenvoitto : Form
    {
        public Suomenvoitto()
        {
            InitializeComponent();
        }

        private void btn_ei_Click(object sender, EventArgs e)
        {

        }

        private void btn_joo_Click(object sender, EventArgs e)
        {
            SimoSim uj = new SimoSim();
            uj.nehez(1);
            this.Dispose(false) ;
        }

        private void btn_beache_Click(object sender, EventArgs e)
        {
            Szint uj = new Szint();
            uj.Show();
            this.Dispose(false);
        }

        private void btn_historical_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
