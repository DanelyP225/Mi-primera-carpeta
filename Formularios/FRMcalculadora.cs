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
    public partial class FRMcalculadora : Form
    {
        public FRMcalculadora()
        {
            InitializeComponent();
        }

        string input = string.Empty;
       

        private void FRMcalculadora_Load(object sender, EventArgs e)
        {
            this.Text = "Calculadora";
            this.KeyPreview = true;
        }

        private void FRMcalculadora_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
               this.Close(); //Esto cierra el formulario
            }
        }

        // BOTONES DE LA CALCULADORA

        private void btn01_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "1";
            this.textBox1.Text += input;
        }

        private void btn02_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "2";
            this.textBox1.Text += input;
        }

        private void btn03_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "3";
            this.textBox1.Text += input;
        }

        private void btn04_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "4";
            this.textBox1.Text += input;
        }

        private void btn05_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "5";
            this.textBox1.Text += input;
        }

        private void btn06_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "6";
            this.textBox1.Text += input;
        }

        private void btn07_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "7";
            this.textBox1.Text += input;
        }

        private void btn08_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "8";
            this.textBox1.Text += input;
        }

        private void btn09_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "9";
            this.textBox1.Text += input;
        }

        private void btn00_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "0";
            this.textBox1.Text += input;
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            input += ".";
        }

        private void btnLimpiador_Click(object sender, EventArgs e)
        {
            input = string.Empty;
            textBox1.Clear();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            input += "*";
            textBox1.Text = input;
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            input += "/";
            textBox1.Text = input;
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            input += "-";
            textBox1.Text = input;
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            input += "+";
            textBox1.Text = input;
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            try
            {
                var result = new DataTable().Compute(input, null);
                textBox1.Text = result.ToString();
                input = result.ToString(); // Para permitir seguir calculando
            }
            catch
            {
                textBox1.Text = "Error";
                input = string.Empty;
            }
        }

        private void btnPorcentaje_Click(object sender, EventArgs e)
        {
            double valor;
            if (double.TryParse(input, out valor))
            {
                valor = valor / 100;
                textBox1.Text = valor.ToString();
                input = valor.ToString(); // actualiza el input para permitir cálculos posteriores
            }
            else
            {
                MessageBox.Show("Error: ingrese un número válido.");
            }
        }

        private void btnRaizCuadrada_Click(object sender, EventArgs e)
        {
            double valor;
            if (double.TryParse(input, out valor))
            {
                if (valor < 0)
                {
                    MessageBox.Show("No se calcula la raíz de un número negativo");
                }
                else
                {
                    valor = Math.Sqrt(valor);
                    textBox1.Text = valor.ToString();
                    input = valor.ToString(); // actualiza input con el nuevo valor
                }
            }
            else
            {
                MessageBox.Show("Error: ingrese un número válido.");
            }
        }

    }
}
