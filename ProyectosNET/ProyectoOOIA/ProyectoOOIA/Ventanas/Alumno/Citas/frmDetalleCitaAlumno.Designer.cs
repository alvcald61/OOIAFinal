﻿
namespace ProyectoOOIA.Ventanas
{
    partial class frmDetalleCitaAlumno
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOrientador = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHoraInicio = new System.Windows.Forms.TextBox();
            this.txtHoraFin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMotivoConsulta = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtCompromiso = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtOpinion = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtValoracion = new System.Windows.Forms.TextBox();
            this.lbestadoCita = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(71)))), ((int)(((byte)(123)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 87);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(24, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detalle de la cita";
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRegresar.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnRegresar.Location = new System.Drawing.Point(895, 426);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(130, 36);
            this.btnRegresar.TabIndex = 5;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "Orientador";
            // 
            // txtOrientador
            // 
            this.txtOrientador.Enabled = false;
            this.txtOrientador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrientador.Location = new System.Drawing.Point(41, 112);
            this.txtOrientador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOrientador.Name = "txtOrientador";
            this.txtOrientador.ReadOnly = true;
            this.txtOrientador.Size = new System.Drawing.Size(419, 24);
            this.txtOrientador.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 27);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 27);
            this.label4.TabIndex = 10;
            this.label4.Text = "Hora inicio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(215, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 27);
            this.label5.TabIndex = 11;
            this.label5.Text = "Hora fin";
            // 
            // txtHoraInicio
            // 
            this.txtHoraInicio.Enabled = false;
            this.txtHoraInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoraInicio.Location = new System.Drawing.Point(41, 277);
            this.txtHoraInicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHoraInicio.Name = "txtHoraInicio";
            this.txtHoraInicio.ReadOnly = true;
            this.txtHoraInicio.Size = new System.Drawing.Size(132, 24);
            this.txtHoraInicio.TabIndex = 12;
            // 
            // txtHoraFin
            // 
            this.txtHoraFin.Enabled = false;
            this.txtHoraFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoraFin.Location = new System.Drawing.Point(220, 277);
            this.txtHoraFin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHoraFin.Name = "txtHoraFin";
            this.txtHoraFin.ReadOnly = true;
            this.txtHoraFin.Size = new System.Drawing.Size(145, 24);
            this.txtHoraFin.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 27);
            this.label6.TabIndex = 14;
            this.label6.Text = "Compromiso";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(553, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 27);
            this.label7.TabIndex = 16;
            this.label7.Text = "Motivo de consulta";
            // 
            // txtMotivoConsulta
            // 
            this.txtMotivoConsulta.Enabled = false;
            this.txtMotivoConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotivoConsulta.Location = new System.Drawing.Point(558, 66);
            this.txtMotivoConsulta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMotivoConsulta.Multiline = true;
            this.txtMotivoConsulta.Name = "txtMotivoConsulta";
            this.txtMotivoConsulta.ReadOnly = true;
            this.txtMotivoConsulta.Size = new System.Drawing.Size(467, 95);
            this.txtMotivoConsulta.TabIndex = 17;
            this.txtMotivoConsulta.Text = "\r\n\r\n\r\n\r\n";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Controls.Add(this.lbestadoCita);
            this.panel2.Controls.Add(this.txtValoracion);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtCompromiso);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtOpinion);
            this.panel2.Controls.Add(this.dtpFecha);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtMotivoConsulta);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtHoraFin);
            this.panel2.Controls.Add(this.txtHoraInicio);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtOrientador);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnRegresar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 87);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1100, 513);
            this.panel2.TabIndex = 3;
            // 
            // txtCompromiso
            // 
            this.txtCompromiso.Enabled = false;
            this.txtCompromiso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompromiso.Location = new System.Drawing.Point(41, 361);
            this.txtCompromiso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCompromiso.Multiline = true;
            this.txtCompromiso.Name = "txtCompromiso";
            this.txtCompromiso.ReadOnly = true;
            this.txtCompromiso.Size = new System.Drawing.Size(467, 95);
            this.txtCompromiso.TabIndex = 24;
            this.txtCompromiso.Text = "\r\n\r\n\r\n\r\n";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(553, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 27);
            this.label9.TabIndex = 23;
            this.label9.Text = "Opinión de la cita";
            // 
            // txtOpinion
            // 
            this.txtOpinion.Enabled = false;
            this.txtOpinion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpinion.Location = new System.Drawing.Point(558, 238);
            this.txtOpinion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOpinion.Multiline = true;
            this.txtOpinion.Name = "txtOpinion";
            this.txtOpinion.ReadOnly = true;
            this.txtOpinion.Size = new System.Drawing.Size(467, 73);
            this.txtOpinion.TabIndex = 22;
            this.txtOpinion.Text = "\r\n\r\n\r\n\r\n";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Location = new System.Drawing.Point(41, 186);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(419, 24);
            this.dtpFecha.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(36, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 27);
            this.label8.TabIndex = 18;
            this.label8.Text = "Estado de la cita:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(553, 332);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(165, 27);
            this.label10.TabIndex = 25;
            this.label10.Text = "Valoración de la cita";
            // 
            // txtValoracion
            // 
            this.txtValoracion.Enabled = false;
            this.txtValoracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValoracion.Location = new System.Drawing.Point(558, 361);
            this.txtValoracion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtValoracion.Multiline = true;
            this.txtValoracion.Name = "txtValoracion";
            this.txtValoracion.ReadOnly = true;
            this.txtValoracion.Size = new System.Drawing.Size(467, 34);
            this.txtValoracion.TabIndex = 26;
            this.txtValoracion.Text = "\r\n\r\n\r\n\r\n";
            // 
            // lbestadoCita
            // 
            this.lbestadoCita.AutoSize = true;
            this.lbestadoCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbestadoCita.Location = new System.Drawing.Point(199, 32);
            this.lbestadoCita.Name = "lbestadoCita";
            this.lbestadoCita.Size = new System.Drawing.Size(62, 20);
            this.lbestadoCita.TabIndex = 27;
            this.lbestadoCita.Text = "label11";
            // 
            // frmDetalleCitaAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmDetalleCitaAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle de la cita";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOrientador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHoraInicio;
        private System.Windows.Forms.TextBox txtHoraFin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMotivoConsulta;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtCompromiso;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtOpinion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtValoracion;
        private System.Windows.Forms.Label lbestadoCita;
    }
}