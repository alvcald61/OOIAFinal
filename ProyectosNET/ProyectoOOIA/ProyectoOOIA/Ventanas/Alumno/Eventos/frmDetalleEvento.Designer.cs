
namespace ProyectoOOIA.Ventanas
{
    partial class frmDetalleEvento
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
            this.lblPonentes = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.pbEvento = new System.Windows.Forms.PictureBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCupo = new System.Windows.Forms.Label();
            this.txtLugar = new System.Windows.Forms.TextBox();
            this.txtCupo = new System.Windows.Forms.TextBox();
            this.lblSlash = new System.Windows.Forms.Label();
            this.txtCapacidad = new System.Windows.Forms.TextBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.dtpHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.dgvPonentes = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pbEvento)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPonentes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPonentes
            // 
            this.lblPonentes.BackColor = System.Drawing.Color.Transparent;
            this.lblPonentes.Font = new System.Drawing.Font("Gill Sans MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPonentes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPonentes.Location = new System.Drawing.Point(43, 356);
            this.lblPonentes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPonentes.Name = "lblPonentes";
            this.lblPonentes.Size = new System.Drawing.Size(171, 37);
            this.lblPonentes.TabIndex = 2;
            this.lblPonentes.Text = "Ponentes:";
            this.lblPonentes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFecha
            // 
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Gill Sans MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFecha.Location = new System.Drawing.Point(43, 130);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(121, 37);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "Fecha:";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbEvento
            // 
            this.pbEvento.Image = global::ProyectoOOIA.Properties.Resources.EEGGCC;
            this.pbEvento.Location = new System.Drawing.Point(560, 95);
            this.pbEvento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbEvento.Name = "pbEvento";
            this.pbEvento.Size = new System.Drawing.Size(491, 298);
            this.pbEvento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEvento.TabIndex = 7;
            this.pbEvento.TabStop = false;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(560, 405);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(489, 133);
            this.txtDescripcion.TabIndex = 10;
            // 
            // dtpFecha
            // 
            this.dtpFecha.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.dtpFecha.Location = new System.Drawing.Point(172, 137);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(281, 22);
            this.dtpFecha.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(71)))), ((int)(((byte)(123)))));
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.lblHeader);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 87);
            this.panel1.TabIndex = 44;
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Image = global::ProyectoOOIA.Properties.Resources.arrowWhite;
            this.btnBack.Location = new System.Drawing.Point(15, 42);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(33, 31);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBack.TabIndex = 18;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
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
            this.btnLogout.Location = new System.Drawing.Point(1289, 36);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(47, 42);
            this.btnLogout.TabIndex = 14;
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.SystemColors.Window;
            this.lblHeader.Location = new System.Drawing.Point(53, 42);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(257, 33);
            this.lblHeader.TabIndex = 3;
            this.lblHeader.Text = "Nombre de Evento";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(43, 207);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 37);
            this.label1.TabIndex = 46;
            this.label1.Text = "Lugar:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCupo
            // 
            this.lblCupo.BackColor = System.Drawing.Color.Transparent;
            this.lblCupo.Font = new System.Drawing.Font("Gill Sans MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCupo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCupo.Location = new System.Drawing.Point(43, 304);
            this.lblCupo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCupo.Name = "lblCupo";
            this.lblCupo.Size = new System.Drawing.Size(227, 37);
            this.lblCupo.TabIndex = 47;
            this.lblCupo.Text = "Cupos disponibles:";
            this.lblCupo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLugar
            // 
            this.txtLugar.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLugar.Location = new System.Drawing.Point(49, 247);
            this.txtLugar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLugar.Name = "txtLugar";
            this.txtLugar.Size = new System.Drawing.Size(404, 31);
            this.txtLugar.TabIndex = 48;
            // 
            // txtCupo
            // 
            this.txtCupo.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCupo.Location = new System.Drawing.Point(277, 305);
            this.txtCupo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCupo.Name = "txtCupo";
            this.txtCupo.Size = new System.Drawing.Size(61, 31);
            this.txtCupo.TabIndex = 49;
            // 
            // lblSlash
            // 
            this.lblSlash.BackColor = System.Drawing.Color.Transparent;
            this.lblSlash.Font = new System.Drawing.Font("Gill Sans MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlash.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSlash.Location = new System.Drawing.Point(348, 300);
            this.lblSlash.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSlash.Name = "lblSlash";
            this.lblSlash.Size = new System.Drawing.Size(36, 37);
            this.lblSlash.TabIndex = 50;
            this.lblSlash.Text = "/";
            this.lblSlash.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCapacidad
            // 
            this.txtCapacidad.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapacidad.Location = new System.Drawing.Point(392, 305);
            this.txtCapacidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCapacidad.Name = "txtCapacidad";
            this.txtCapacidad.Size = new System.Drawing.Size(61, 31);
            this.txtCapacidad.TabIndex = 51;
            // 
            // lblHora
            // 
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Font = new System.Drawing.Font("Gill Sans MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblHora.Location = new System.Drawing.Point(43, 162);
            this.lblHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(121, 37);
            this.lblHora.TabIndex = 52;
            this.lblHora.Text = "Hora:";
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpHoraInicio
            // 
            this.dtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraInicio.Location = new System.Drawing.Point(172, 169);
            this.dtpHoraInicio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpHoraInicio.Name = "dtpHoraInicio";
            this.dtpHoraInicio.Size = new System.Drawing.Size(96, 22);
            this.dtpHoraInicio.TabIndex = 54;
            // 
            // dgvPonentes
            // 
            this.dgvPonentes.AllowUserToAddRows = false;
            this.dgvPonentes.AllowUserToDeleteRows = false;
            this.dgvPonentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPonentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre});
            this.dgvPonentes.Location = new System.Drawing.Point(49, 396);
            this.dgvPonentes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPonentes.Name = "dgvPonentes";
            this.dgvPonentes.ReadOnly = true;
            this.dgvPonentes.RowHeadersWidth = 51;
            this.dgvPonentes.Size = new System.Drawing.Size(405, 143);
            this.dgvPonentes.TabIndex = 55;
            this.dgvPonentes.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPonentes_CellFormatting);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 304;
            // 
            // frmDetalleEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dgvPonentes);
            this.Controls.Add(this.dtpHoraInicio);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.txtCapacidad);
            this.Controls.Add(this.lblSlash);
            this.Controls.Add(this.txtCupo);
            this.Controls.Add(this.txtLugar);
            this.Controls.Add(this.lblCupo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.pbEvento);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblPonentes);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDetalleEvento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vista de evento";
            this.Load += new System.EventHandler(this.frmDetalleEvento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbEvento)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPonentes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPonentes;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.PictureBox pbEvento;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCupo;
        private System.Windows.Forms.TextBox txtLugar;
        private System.Windows.Forms.TextBox txtCupo;
        private System.Windows.Forms.Label lblSlash;
        private System.Windows.Forms.TextBox txtCapacidad;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.DateTimePicker dtpHoraInicio;
        private System.Windows.Forms.DataGridView dgvPonentes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
    }
}