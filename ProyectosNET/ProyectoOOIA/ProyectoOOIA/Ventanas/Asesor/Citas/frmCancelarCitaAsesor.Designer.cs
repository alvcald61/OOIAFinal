
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
            this.lblHorario = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnHorario = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlHeader.SuspendLayout();
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
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario.ForeColor = System.Drawing.SystemColors.Window;
            this.lblHorario.Location = new System.Drawing.Point(189, 9);
            this.lblHorario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(187, 30);
            this.lblHorario.TabIndex = 0;
            this.lblHorario.Text = "Cancelación de Cita";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.BackgroundImage = global::ProyectoOOIA.Properties.Resources.logout_white;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(967, 31);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(35, 34);
            this.btnLogout.TabIndex = 14;
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnHorario
            // 
            this.btnHorario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(71)))), ((int)(((byte)(123)))));
            this.btnHorario.FlatAppearance.BorderSize = 0;
            this.btnHorario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHorario.ForeColor = System.Drawing.Color.White;
            this.btnHorario.Location = new System.Drawing.Point(823, 12);
            this.btnHorario.Name = "btnHorario";
            this.btnHorario.Size = new System.Drawing.Size(112, 53);
            this.btnHorario.TabIndex = 11;
            this.btnHorario.Text = "Registrar Horario";
            this.btnHorario.UseVisualStyleBackColor = false;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(71)))), ((int)(((byte)(123)))));
            this.pnlHeader.Controls.Add(this.btnHorario);
            this.pnlHeader.Controls.Add(this.btnLogout);
            this.pnlHeader.Controls.Add(this.lblHorario);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(584, 47);
            this.pnlHeader.TabIndex = 6;
            // 
            // frmCancelarCitaAsesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.btnCancelarCita);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.txtJustificacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCancelarCitaDescripcion);
            this.Controls.Add(this.lblCancelarCitaTiulo);
            this.Name = "frmCancelarCitaAsesor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cancelar Cita";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
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
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnHorario;
        private System.Windows.Forms.Panel pnlHeader;
    }
}