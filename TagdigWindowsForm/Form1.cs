using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TagdigWindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void újTagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.ujTag.Show();
        }

        private void tagMódisításaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.tagModositas.Show();
        }

        private void újBefizetésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.ujBefizetes.Show();
        }

        private void befizetésLekérdezéseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.befizetesLekerdezes.Show();
        }
    }
}
