namespace PS__Lunes
{
    partial class FRMtexto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreArchivo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnDialogo = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnBorrarLn = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Plum;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(891, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Archivo de Textos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Thistle;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(391, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "¿Con Cual Nombre Vas a Crear El Archivo?";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNombreArchivo
            // 
            this.txtNombreArchivo.Location = new System.Drawing.Point(395, 57);
            this.txtNombreArchivo.Multiline = true;
            this.txtNombreArchivo.Name = "txtNombreArchivo";
            this.txtNombreArchivo.Size = new System.Drawing.Size(414, 36);
            this.txtNombreArchivo.TabIndex = 2;
            this.txtNombreArchivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreArchivo_KeyPress);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Thistle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(889, 34);
            this.label3.TabIndex = 3;
            this.label3.Text = "Contenido del Archivo";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(12, 344);
            this.txtTexto.Multiline = true;
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(891, 188);
            this.txtTexto.TabIndex = 5;
            // 
            // dgv
            // 
            this.dgv.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 147);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 62;
            this.dgv.RowTemplate.Height = 28;
            this.dgv.Size = new System.Drawing.Size(891, 191);
            this.dgv.TabIndex = 6;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // btnDialogo
            // 
            this.btnDialogo.BackColor = System.Drawing.Color.Thistle;
            this.btnDialogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDialogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDialogo.Location = new System.Drawing.Point(815, 57);
            this.btnDialogo.Name = "btnDialogo";
            this.btnDialogo.Size = new System.Drawing.Size(87, 38);
            this.btnDialogo.TabIndex = 11;
            this.btnDialogo.Text = "....";
            this.btnDialogo.UseVisualStyleBackColor = false;
            this.btnDialogo.Click += new System.EventHandler(this.btnDialogo_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnBorrarLn
            // 
            this.btnBorrarLn.BackColor = System.Drawing.Color.Pink;
            this.btnBorrarLn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarLn.Image = global::PS__Lunes.Properties.Resources.delete_table_row;
            this.btnBorrarLn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBorrarLn.Location = new System.Drawing.Point(913, 297);
            this.btnBorrarLn.Name = "btnBorrarLn";
            this.btnBorrarLn.Size = new System.Drawing.Size(158, 89);
            this.btnBorrarLn.TabIndex = 12;
            this.btnBorrarLn.Text = "Borrar Linea DGV";
            this.btnBorrarLn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBorrarLn.UseVisualStyleBackColor = false;
            this.btnBorrarLn.Click += new System.EventHandler(this.btnBorrarLn_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Pink;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Image = global::PS__Lunes.Properties.Resources.exit;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(913, 392);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(158, 89);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLeer
            // 
            this.btnLeer.BackColor = System.Drawing.Color.Pink;
            this.btnLeer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeer.Image = global::PS__Lunes.Properties.Resources.fileopen;
            this.btnLeer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLeer.Location = new System.Drawing.Point(913, 202);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(158, 89);
            this.btnLeer.TabIndex = 9;
            this.btnLeer.Text = "Leer Archivo";
            this.btnLeer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLeer.UseVisualStyleBackColor = false;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Pink;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Image = global::PS__Lunes.Properties.Resources.insert_table_row;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregar.Location = new System.Drawing.Point(913, 107);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(158, 89);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Adicional Linea";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.Color.Pink;
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear.Image = global::PS__Lunes.Properties.Resources.edit;
            this.btnCrear.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCrear.Location = new System.Drawing.Point(913, 12);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(158, 89);
            this.btnCrear.TabIndex = 7;
            this.btnCrear.Text = "Crear Archivo";
            this.btnCrear.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // FRMtexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1094, 541);
            this.Controls.Add(this.btnBorrarLn);
            this.Controls.Add(this.btnDialogo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombreArchivo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FRMtexto";
            this.Text = "FRMtexto";
            this.Load += new System.EventHandler(this.FRMtexto_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FRMtexto_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreArchivo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnDialogo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnBorrarLn;
    }
}