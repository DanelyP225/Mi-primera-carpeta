using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PS__Lunes.Formularios
{
    public partial class FRMcalc : Form
    {
        public FRMcalc()
        {
            InitializeComponent();
        }

        private void FRMcalc_Load(object sender, EventArgs e)
        {
            this.Text = "Calc";
            this.KeyPreview = true;

            List<Item> lista = new List<Item>();

            lista.Add(new Item("Sumar", 1));
            lista.Add(new Item("Restar", 2));
            lista.Add(new Item("Multiplicar", 3));
            lista.Add(new Item("Dividir", 4));

            cboOperacion.DisplayMember = "_nombre";
            cboOperacion.ValueMember = "_valor";
            cboOperacion.DataSource = lista;
            
        }

        private void FRMcalc_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
