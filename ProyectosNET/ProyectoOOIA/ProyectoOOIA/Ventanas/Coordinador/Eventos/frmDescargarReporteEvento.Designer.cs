
namespace ProyectoOOIA.Ventanas.Asesor.Citas
{
    partial class frmDescargarReporteEvento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDescargarReporteEvento));
            this.btnGuardarReporte = new System.Windows.Forms.Button();
            this.axAcroPDF = new AxAcroPDFLib.AxAcroPDF();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardarReporte
            // 
            this.btnGuardarReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnGuardarReporte.Location = new System.Drawing.Point(269, 12);
            this.btnGuardarReporte.Name = "btnGuardarReporte";
            this.btnGuardarReporte.Size = new System.Drawing.Size(215, 28);
            this.btnGuardarReporte.TabIndex = 0;
            this.btnGuardarReporte.Text = "Descargar Reporte";
            this.btnGuardarReporte.UseVisualStyleBackColor = true;
            this.btnGuardarReporte.Click += new System.EventHandler(this.btnGuardarReporte_Click);
            // 
            // axAcroPDF
            // 
            this.axAcroPDF.Enabled = true;
            this.axAcroPDF.Location = new System.Drawing.Point(12, 46);
            this.axAcroPDF.Name = "axAcroPDF";
            this.axAcroPDF.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF.OcxState")));
            this.axAcroPDF.Size = new System.Drawing.Size(766, 406);
            this.axAcroPDF.TabIndex = 2;
            // 
            // frmDescargarReporteEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.axAcroPDF);
            this.Controls.Add(this.btnGuardarReporte);
            this.Name = "frmDescargarReporteEvento";
            this.Text = "Descargar Reporte de Evento";
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGuardarReporte;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF;
    }
}