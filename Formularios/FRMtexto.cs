using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PS__Lunes
{
    public partial class FRMtexto : Form
    {
        private string rutaCompletaArchivo = "";
        public FRMtexto()
        {
            InitializeComponent();
            Estilodgv();
        }

        private static string ruta = @"C:\Users\Onel Luis Pelegrino\Documents\DANELY\ITLA\2025\C2\FUNDAMENTOS DE PROGRAMACIÓN\Textos1\";

        private void FRMtexto_Load(object sender, EventArgs e)
        {
            this.Text = "Crear Archivo Texto"; //Cambiamos el titulo principal al formulario
            this.KeyPreview = true; //Activamos las teclas de funciones
        }

        private void FRMtexto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) //Pregunta si presionaste la tecla Enter
            {
                this.Close(); //Cerramos el formulario
            }
        }

        private void txtNombreArchivo_KeyPress(object sender, KeyPressEventArgs e) // va manejar la tecla Enter
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                e.Handled = true; //Se preciono la tecla ENTER y la convertimos en true
                if (txtNombreArchivo.Text.Trim() != string.Empty) //Preguntamos si es diferente de vacio
                {
                    txtTexto.Focus(); //Mueve el cursor al textbox indicado 
                }
            }
        }

      
        // -------------------------------------------------------------------
        // BOTONES
        // -------------------------------------------------------------------

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (txtNombreArchivo.Text.Trim() != string.Empty) 
            {
                if (txtTexto.Text.Trim() != string.Empty) 
                {
                    string route = ruta + txtNombreArchivo.Text + ".txt";

                    EscribirEnElDgv(route);
                    CrearArchivoDeTexto(route);
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombreArchivo.Text.Trim() != string.Empty)
            {
                if (txtTexto.Text.Trim() != string.Empty)
                {
                    string route = ruta + txtNombreArchivo.Text + ".txt";

                    Adicionaltexto(route);
                }
            }
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            string rutaArchivo;

            if (!string.IsNullOrEmpty(rutaCompletaArchivo))
            {
                rutaArchivo = rutaCompletaArchivo; // Usamos la ruta del diálogo
            }
            else
            {
                rutaArchivo = ruta + txtNombreArchivo.Text.Trim() + ".txt"; // Ruta por defecto
            }

            LeerArchivo(rutaArchivo);
        }

        private void btnDialogo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                rutaCompletaArchivo = openFileDialog.FileName; // Guardamos la ruta completa
                txtNombreArchivo.Text = Path.GetFileNameWithoutExtension(rutaCompletaArchivo); // Mostramos solo el nombre
                EscribirEnElDgv(rutaCompletaArchivo);
            }
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.Rows.Count > 0)
            {
                txtNombreArchivo.Text = dgv.CurrentRow.Cells[0].Value.ToString();
                LeerArchivo(txtNombreArchivo.Text);
            }
        }

        private void btnBorrarLn_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count > 0)
            {
                BorrarLineaDelDataGridView();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close(); //Cerramos el formulario
        }

        // -------------------------------------------------------------------
        // METODOS
        // -------------------------------------------------------------------

        private void EscribirEnElDgv(string PathFilesName)
        {
            dgv.Rows.Add(); //Le agregamos una linea al DataGridView
            int xRows = dgv.Rows.Count -1;
            dgv[0, xRows].Value = PathFilesName;
        }

        private void CrearArchivoDeTexto(string NombreDelArchivo) 
        {
            string rutaDelArchivo = NombreDelArchivo;
            string _Escribir_texto = txtTexto.Text.Trim();

            using (StreamWriter Archivolog = File.AppendText(rutaDelArchivo)) 
            {
                DateTime _fechaDeHoy = new DateTime();

                _fechaDeHoy = DateTime.Now;

                string stFecha = Convert.ToDateTime(_fechaDeHoy).ToString("yyyyMMdd");

                Archivolog.WriteLine(stFecha + " " + _Escribir_texto);

                Archivolog.Close();
            }
        }

        private void Adicionaltexto(string NombreDelArchivo) 
        {
            string rutaDelArchivo =   NombreDelArchivo;
            string texto = txtTexto.Text.Trim();

            using (StreamWriter file = new StreamWriter(rutaDelArchivo, true))
            {
                file.WriteLine(texto);
                file.Close();
            }

        }

        private void LeerArchivo(string NombreDelArchivo) 
        {
            string rutaDelArchivo = NombreDelArchivo;
            string linea = "";
            string texto = "";

            using (StreamReader file = new StreamReader(rutaDelArchivo)) 
            {
                while ((linea = file.ReadLine ()) != null) //Hace un arreglo con ENTER
                {
                    texto = texto + linea + "\r\n";
                }

                txtTexto.Text = texto;
            }
        }

        private void BorrarLineaDelDataGridView()
        {
            int CuantasLineasTengo = Convert.ToInt32(dgv.RowCount);

            if (CuantasLineasTengo == 1)
            {
                dgv.Rows.RemoveAt(dgv.Rows.Count - 1);
            }
            else
            {
                dgv.Rows.Remove(dgv.CurrentRow);
            }
        }


        private void Estilodgv()
        {
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersVisible = true;
            this.dgv.RowHeadersVisible = false;

            this.dgv.Columns.Add("A", "Texto");
            //this.dgv.Columns.Add("B", "Otro");

            DataGridViewColumn
            column = dgv.Columns[0]; column.Width = 260;
            //column = dgv.Columns[1]; column.Width = 50; 

            this.dgv.BorderStyle = BorderStyle.FixedSingle;
            this.dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            this.dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv.DefaultCellStyle.SelectionBackColor = Color.LightYellow;
            this.dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
            this.dgv.BackgroundColor = Color.LavenderBlush;

            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            this.dgv.ColumnHeadersDefaultCellStyle.Padding = new Padding(0, 6, 0, 6);
            this.dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.CornflowerBlue;
            this.dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

       
    }
}
