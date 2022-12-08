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
        public Szint()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Jatekter uj = new Jatekter();
            this.Hide();
            uj.Show();
        }
    }
}
