
namespace ProyectoOOIA.Ventanas.Miembro_OOIA.Cargar_Datos
{
    partial class frmCargarCSVAlumnos
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
            this.lblRutaArchivoCSV = new System.Windows.Forms.Label();
            this.txtRutaArchivo = new System.Windows.Forms.TextBox();
            this.btnSeleccionArchivo = new System.Windows.Forms.Button();
            this.lblTituloCargaCSVAlumnos = new System.Windows.Forms.Label();
            this.btnCargaDatosCSVAlumnos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRutaArchivoCSV
            // 
            this.lblRutaArchivoCSV.AutoSize = true;
            this.lblRutaArchivoCSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRutaArchivoCSV.Location = new System.Drawing.Point(12, 94);
            this.lblRutaArchivoCSV.Name = "lblRutaArchivoCSV";
            this.lblRutaArchivoCSV.Size = new System.Drawing.Size(151, 20);
            this.lblRutaArchivoCSV.TabIndex = 0;
            this.lblRutaArchivoCSV.Text = "Ruta de archivo csv:";
            this.lblRutaArchivoCSV.Click += new System.EventHandler(this.lblRutaArchivoCSV_Click);
            // 
            // txtRutaArchivo
            // 
            this.txtRutaArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtRutaArchivo.Location = new System.Drawing.Point(187, 91);
            this.txtRutaArchivo.Name = "txtRutaArchivo";
            this.txtRutaArchivo.Size = new System.Drawing.Size(592, 26);
            this.txtRutaArchivo.TabIndex = 1;
            this.txtRutaArchivo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnSeleccionArchivo
            // 
            this.btnSeleccionArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSeleccionArchivo.Location = new System.Drawing.Point(591, 123);
            this.btnSeleccionArchivo.Name = "btnSeleccionArchivo";
            this.btnSeleccionArchivo.Size = new System.Drawing.Size(188, 27);
            this.btnSeleccionArchivo.TabIndex = 2;
            this.btnSeleccionArchivo.Text = "Seleccionar archivo";
            this.btnSeleccionArchivo.UseVisualStyleBackColor = true;
            this.btnSeleccionArchivo.Click += new System.EventHandler(this.btnSeleccionArchivo_Click);
            // 
            // lblTituloCargaCSVAlumnos
            // 
            this.lblTituloCargaCSVAlumnos.AutoSize = true;
            this.lblTituloCargaCSVAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblTituloCargaCSVAlumnos.Location = new System.Drawing.Point(12, 31);
            this.lblTituloCargaCSVAlumnos.Name = "lblTituloCargaCSVAlumnos";
            this.lblTituloCargaCSVAlumnos.Size = new System.Drawing.Size(348, 26);
            this.lblTituloCargaCSVAlumnos.TabIndex = 3;
            this.lblTituloCargaCSVAlumnos.Text = "Carga de alumnos por archivo .csv";
            // 
            // btnCargaDatosCSVAlumnos
            // 
            this.btnCargaDatosCSVAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnCargaDatosCSVAlumnos.Location = new System.Drawing.Point(299, 293);
            this.btnCargaDatosCSVAlumnos.Name = "btnCargaDatosCSVAlumnos";
            this.btnCargaDatosCSVAlumnos.Size = new System.Drawing.Size(167, 37);
            this.btnCargaDatosCSVAlumnos.TabIndex = 4;
            this.btnCargaDatosCSVAlumnos.Text = "Cargar datos";
            this.btnCargaDatosCSVAlumnos.UseVisualStyleBackColor = true;
            this.btnCargaDatosCSVAlumnos.Click += new System.EventHandler(this.btnCargaDatosCSVAlumnos_Click);
            // 
            // frmCargarCSVAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCargaDatosCSVAlumnos);
            this.Controls.Add(this.lblTituloCargaCSVAlumnos);
            this.Controls.Add(this.btnSeleccionArchivo);
            this.Controls.Add(this.txtRutaArchivo);
            this.Controls.Add(this.lblRutaArchivoCSV);
            this.Name = "frmCargarCSVAlumnos";
            this.Text = "frmCargarCSVAlumnos";
            this.Load += new System.EventHandler(this.frmCargarCSVAlumnos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRutaArchivoCSV;
        private System.Windows.Forms.TextBox txtRutaArchivo;
        private System.Windows.Forms.Button btnSeleccionArchivo;
        private System.Windows.Forms.Label lblTituloCargaCSVAlumnos;
        private System.Windows.Forms.Button btnCargaDatosCSVAlumnos;
    }
}