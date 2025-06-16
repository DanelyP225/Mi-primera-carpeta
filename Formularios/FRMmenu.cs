using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PS__Lunes
{
    public partial class FRMmenu : Form
    {
        public FRMmenu()
        {
            InitializeComponent();
        }

        private void FRMmenu_Load(object sender, EventArgs e)
        {
            this.Text = "Menu General";
            this.KeyPreview = true;
        }

        private void FRMmenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) 
            {
                Application.Exit();
            }
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMcalculadora fRMcalculadora = new FRMcalculadora();
            fRMcalculadora.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMtexto fRMtexto = new FRMtexto();
            fRMtexto.ShowDialog();
        }
    }
}
