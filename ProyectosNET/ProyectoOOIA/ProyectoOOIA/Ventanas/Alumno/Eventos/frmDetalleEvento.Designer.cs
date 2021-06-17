
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
            this.lblPonentes.Location = new System.Drawing.Point(32, 289);
            this.lblPonentes.Name = "lblPonentes";
            this.lblPonentes.Size = new System.Drawing.Size(128, 30);
            this.lblPonentes.TabIndex = 2;
            this.lblPonentes.Text = "Ponentes:";
            this.lblPonentes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFecha
            // 
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Gill Sans MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFecha.Location = new System.Drawing.Point(32, 106);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(91, 30);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "Fecha:";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbEvento
            // 
            this.pbEvento.Image = global::ProyectoOOIA.Properties.Resources.placeholder_profile;
            this.pbEvento.Location = new System.Drawing.Point(420, 77);
            this.pbEvento.Name = "pbEvento";
            this.pbEvento.Size = new System.Drawing.Size(368, 242);
            this.pbEvento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEvento.TabIndex = 7;
            this.pbEvento.TabStop = false;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(420, 329);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(368, 109);
            this.txtDescripcion.TabIndex = 10;
            // 
            // dtpFecha
            // 
            this.dtpFecha.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.dtpFecha.Location = new System.Drawing.Point(129, 111);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(212, 20);
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 71);
            this.panel1.TabIndex = 44;
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Image = global::ProyectoOOIA.Properties.Resources.arrowWhite;
            this.btnBack.Location = new System.Drawing.Point(11, 34);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(25, 25);
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
            this.btnLogout.Location = new System.Drawing.Point(967, 29);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(35, 34);
            this.btnLogout.TabIndex = 14;
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.SystemColors.Window;
            this.lblHeader.Location = new System.Drawing.Point(40, 34);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(215, 29);
            this.lblHeader.TabIndex = 3;
            this.lblHeader.Text = "Nombre de Evento";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(32, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 30);
            this.label1.TabIndex = 46;
            this.label1.Text = "Lugar:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCupo
            // 
            this.lblCupo.BackColor = System.Drawing.Color.Transparent;
            this.lblCupo.Font = new System.Drawing.Font("Gill Sans MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCupo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCupo.Location = new System.Drawing.Point(32, 247);
            this.lblCupo.Name = "lblCupo";
            this.lblCupo.Size = new System.Drawing.Size(170, 30);
            this.lblCupo.TabIndex = 47;
            this.lblCupo.Text = "Cupos disponibles:";
            this.lblCupo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLugar
            // 
            this.txtLugar.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLugar.Location = new System.Drawing.Point(37, 201);
            this.txtLugar.Name = "txtLugar";
            this.txtLugar.Size = new System.Drawing.Size(304, 26);
            this.txtLugar.TabIndex = 48;
            // 
            // txtCupo
            // 
            this.txtCupo.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCupo.Location = new System.Drawing.Point(208, 248);
            this.txtCupo.Name = "txtCupo";
            this.txtCupo.Size = new System.Drawing.Size(47, 26);
            this.txtCupo.TabIndex = 49;
            // 
            // lblSlash
            // 
            this.lblSlash.BackColor = System.Drawing.Color.Transparent;
            this.lblSlash.Font = new System.Drawing.Font("Gill Sans MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlash.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSlash.Location = new System.Drawing.Point(261, 244);
            this.lblSlash.Name = "lblSlash";
            this.lblSlash.Size = new System.Drawing.Size(27, 30);
            this.lblSlash.TabIndex = 50;
            this.lblSlash.Text = "/";
            this.lblSlash.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCapacidad
            // 
            this.txtCapacidad.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapacidad.Location = new System.Drawing.Point(294, 248);
            this.txtCapacidad.Name = "txtCapacidad";
            this.txtCapacidad.Size = new System.Drawing.Size(47, 26);
            this.txtCapacidad.TabIndex = 51;
            // 
            // lblHora
            // 
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Font = new System.Drawing.Font("Gill Sans MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblHora.Location = new System.Drawing.Point(32, 132);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(91, 30);
            this.lblHora.TabIndex = 52;
            this.lblHora.Text = "Hora:";
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpHoraInicio
            // 
            this.dtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraInicio.Location = new System.Drawing.Point(129, 137);
            this.dtpHoraInicio.Name = "dtpHoraInicio";
            this.dtpHoraInicio.Size = new System.Drawing.Size(73, 20);
            this.dtpHoraInicio.TabIndex = 54;
            // 
            // dgvPonentes
            // 
            this.dgvPonentes.AllowUserToAddRows = false;
            this.dgvPonentes.AllowUserToDeleteRows = false;
            this.dgvPonentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPonentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre});
            this.dgvPonentes.Location = new System.Drawing.Point(37, 322);
            this.dgvPonentes.Name = "dgvPonentes";
            this.dgvPonentes.ReadOnly = true;
            this.dgvPonentes.RowHeadersWidth = 51;
            this.dgvPonentes.Size = new System.Drawing.Size(304, 116);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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