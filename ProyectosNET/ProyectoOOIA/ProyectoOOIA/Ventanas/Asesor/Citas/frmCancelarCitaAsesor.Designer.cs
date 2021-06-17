
namespace ProyectoOOIA.Ventanas
{
    partial class frmCancelarCitaAsesor
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
            this.lblCancelarCitaTiulo = new System.Windows.Forms.Label();
            this.lblCancelarCitaDescripcion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtJustificacion = new System.Windows.Forms.TextBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnCancelarCita = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lblCancelarCitaTiulo
            // 
            this.lblCancelarCitaTiulo.AutoSize = true;
            this.lblCancelarCitaTiulo.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancelarCitaTiulo.Location = new System.Drawing.Point(198, 9);
            this.lblCancelarCitaTiulo.Name = "lblCancelarCitaTiulo";
            this.lblCancelarCitaTiulo.Size = new System.Drawing.Size(178, 30);
            this.lblCancelarCitaTiulo.TabIndex = 0;
            this.lblCancelarCitaTiulo.Text = "Horario Reservado";
            this.lblCancelarCitaTiulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCancelarCitaTiulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCancelarCitaDescripcion
            // 
            this.lblCancelarCitaDescripcion.AutoSize = true;
            this.lblCancelarCitaDescripcion.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblCancelarCitaDescripcion.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancelarCitaDescripcion.Location = new System.Drawing.Point(11, 49);
            this.lblCancelarCitaDescripcion.MaximumSize = new System.Drawing.Size(570, 0);
            this.lblCancelarCitaDescripcion.Name = "lblCancelarCitaDescripcion";
            this.lblCancelarCitaDescripcion.Size = new System.Drawing.Size(569, 63);
            this.lblCancelarCitaDescripcion.TabIndex = 1;
            this.lblCancelarCitaDescripcion.Text = "Tiene una cita reservada con un alumno en el horario reservado. Si desea cancelar" +
    " la cita, se le notificará al alumno por correo y se le dará la oportunidad de r" +
    "eprogramar la cita en otro horario. ";
            this.lblCancelarCitaDescripcion.UseMnemonic = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 122);
            this.label1.MaximumSize = new System.Drawing.Size(570, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Escriba su justificación para la cancelación de la cita.";
            this.label1.UseMnemonic = false;
            // 
            // txtJustificacion
            // 
            this.txtJustificacion.Location = new System.Drawing.Point(16, 146);
            this.txtJustificacion.Multiline = true;
            this.txtJustificacion.Name = "txtJustificacion";
            this.txtJustificacion.Size = new System.Drawing.Size(556, 222);
            this.txtJustificacion.TabIndex = 3;
            this.txtJustificacion.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(15, 382);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(116, 23);
            this.btnRegresar.TabIndex = 4;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnCancelarCita
            // 
            this.btnCancelarCita.Location = new System.Drawing.Point(455, 382);
            this.btnCancelarCita.Name = "btnCancelarCita";
            this.btnCancelarCita.Size = new System.Drawing.Size(116, 23);
            this.btnCancelarCita.TabIndex = 5;
            this.btnCancelarCita.Text = "Cancelar Cita";
            this.btnCancelarCita.UseVisualStyleBackColor = true;
            this.btnCancelarCita.Click += new System.EventHandler(this.btnCancelarCita_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmCancelarCitaAsesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 450);
            this.Controls.Add(this.btnCancelarCita);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.txtJustificacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCancelarCitaDescripcion);
            this.Controls.Add(this.lblCancelarCitaTiulo);
            this.Name = "frmCancelarCitaAsesor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cancelar Cita";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCancelarCitaTiulo;
        private System.Windows.Forms.Label lblCancelarCitaDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtJustificacion;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnCancelarCita;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}