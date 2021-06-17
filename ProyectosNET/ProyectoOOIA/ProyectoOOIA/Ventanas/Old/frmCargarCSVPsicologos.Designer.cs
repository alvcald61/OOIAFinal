
namespace ProyectoOOIA.Ventanas.Miembro_OOIA.Cargar_Datos
{
    partial class frmCargarCSVPsicologos
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
            this.btnCargaDatosCSVAlumnos = new System.Windows.Forms.Button();
            this.lblTituloCargaCSVAlumnos = new System.Windows.Forms.Label();
            this.btnSeleccionArchivo = new System.Windows.Forms.Button();
            this.txtRutaArchivo = new System.Windows.Forms.TextBox();
            this.lblRutaArchivoCSV = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCargaDatosCSVAlumnos
            // 
            this.btnCargaDatosCSVAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnCargaDatosCSVAlumnos.Location = new System.Drawing.Point(299, 301);
            this.btnCargaDatosCSVAlumnos.Name = "btnCargaDatosCSVAlumnos";
            this.btnCargaDatosCSVAlumnos.Size = new System.Drawing.Size(167, 37);
            this.btnCargaDatosCSVAlumnos.TabIndex = 9;
            this.btnCargaDatosCSVAlumnos.Text = "Cargar datos";
            this.btnCargaDatosCSVAlumnos.UseVisualStyleBackColor = true;
            this.btnCargaDatosCSVAlumnos.Click += new System.EventHandler(this.btnCargaDatosCSVAlumnos_Click);
            // 
            // lblTituloCargaCSVAlumnos
            // 
            this.lblTituloCargaCSVAlumnos.AutoSize = true;
            this.lblTituloCargaCSVAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblTituloCargaCSVAlumnos.Location = new System.Drawing.Point(12, 39);
            this.lblTituloCargaCSVAlumnos.Name = "lblTituloCargaCSVAlumnos";
            this.lblTituloCargaCSVAlumnos.Size = new System.Drawing.Size(368, 26);
            this.lblTituloCargaCSVAlumnos.TabIndex = 8;
            this.lblTituloCargaCSVAlumnos.Text = "Carga de psicologos por archivo .csv";
            // 
            // btnSeleccionArchivo
            // 
            this.btnSeleccionArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSeleccionArchivo.Location = new System.Drawing.Point(591, 131);
            this.btnSeleccionArchivo.Name = "btnSeleccionArchivo";
            this.btnSeleccionArchivo.Size = new System.Drawing.Size(188, 27);
            this.btnSeleccionArchivo.TabIndex = 7;
            this.btnSeleccionArchivo.Text = "Seleccionar archivo";
            this.btnSeleccionArchivo.UseVisualStyleBackColor = true;
            this.btnSeleccionArchivo.Click += new System.EventHandler(this.btnSeleccionArchivo_Click);
            // 
            // txtRutaArchivo
            // 
            this.txtRutaArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtRutaArchivo.Location = new System.Drawing.Point(187, 99);
            this.txtRutaArchivo.Name = "txtRutaArchivo";
            this.txtRutaArchivo.Size = new System.Drawing.Size(592, 26);
            this.txtRutaArchivo.TabIndex = 6;
            // 
            // lblRutaArchivoCSV
            // 
            this.lblRutaArchivoCSV.AutoSize = true;
            this.lblRutaArchivoCSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRutaArchivoCSV.Location = new System.Drawing.Point(12, 102);
            this.lblRutaArchivoCSV.Name = "lblRutaArchivoCSV";
            this.lblRutaArchivoCSV.Size = new System.Drawing.Size(151, 20);
            this.lblRutaArchivoCSV.TabIndex = 5;
            this.lblRutaArchivoCSV.Text = "Ruta de archivo csv:";
            // 
            // frmCargarCSVPsicologos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCargaDatosCSVAlumnos);
            this.Controls.Add(this.lblTituloCargaCSVAlumnos);
            this.Controls.Add(this.btnSeleccionArchivo);
            this.Controls.Add(this.txtRutaArchivo);
            this.Controls.Add(this.lblRutaArchivoCSV);
            this.Name = "frmCargarCSVPsicologos";
            this.Text = "frmCargarCSVPsicologos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCargaDatosCSVAlumnos;
        private System.Windows.Forms.Label lblTituloCargaCSVAlumnos;
        private System.Windows.Forms.Button btnSeleccionArchivo;
        private System.Windows.Forms.TextBox txtRutaArchivo;
        private System.Windows.Forms.Label lblRutaArchivoCSV;
    }
}