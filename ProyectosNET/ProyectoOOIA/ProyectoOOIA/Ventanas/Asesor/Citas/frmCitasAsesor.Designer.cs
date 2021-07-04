
namespace ProyectoOOIA.Ventanas
{
    partial class frmCitasAsesor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCitasAsesor));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.lblHorario = new System.Windows.Forms.Label();
            this.btnDescargarReporte = new System.Windows.Forms.Button();
            this.btnHorario = new System.Windows.Forms.Button();
            this.dgvHorarioProf = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.btnMostrarDetalles = new System.Windows.Forms.Button();
            this.lblFechaHora = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTipoHorario = new System.Windows.Forms.ComboBox();
            this.lblTipoHorario = new System.Windows.Forms.Label();
            this.btnBuscarHorario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbTipoNombre = new System.Windows.Forms.RadioButton();
            this.rbFecha = new System.Windows.Forms.RadioButton();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.llamada = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorarioProf)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(71)))), ((int)(((byte)(123)))));
            this.pnlHeader.Controls.Add(this.btnLogout);
            this.pnlHeader.Controls.Add(this.btnHome);
            this.pnlHeader.Controls.Add(this.lblHorario);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1165, 71);
            this.pnlHeader.TabIndex = 2;
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
            this.btnLogout.Location = new System.Drawing.Point(1118, 24);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(35, 34);
            this.btnLogout.TabIndex = 14;
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnHome
            // 
            this.btnHome.Image = global::ProyectoOOIA.Properties.Resources.arrowWhite;
            this.btnHome.Location = new System.Drawing.Point(16, 28);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(25, 25);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnHome.TabIndex = 1;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario.ForeColor = System.Drawing.SystemColors.Window;
            this.lblHorario.Location = new System.Drawing.Point(60, 28);
            this.lblHorario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(187, 30);
            this.lblHorario.TabIndex = 0;
            this.lblHorario.Text = "Gestionar Asesorías";
            // 
            // btnDescargarReporte
            // 
            this.btnDescargarReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(106)))), ((int)(((byte)(145)))));
            this.btnDescargarReporte.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDescargarReporte.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescargarReporte.ForeColor = System.Drawing.Color.White;
            this.btnDescargarReporte.Location = new System.Drawing.Point(897, 81);
            this.btnDescargarReporte.Name = "btnDescargarReporte";
            this.btnDescargarReporte.Size = new System.Drawing.Size(256, 37);
            this.btnDescargarReporte.TabIndex = 15;
            this.btnDescargarReporte.Text = "Descargar reporte de opiniones";
            this.btnDescargarReporte.UseVisualStyleBackColor = false;
            this.btnDescargarReporte.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnHorario
            // 
            this.btnHorario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(106)))), ((int)(((byte)(145)))));
            this.btnHorario.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHorario.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHorario.ForeColor = System.Drawing.Color.White;
            this.btnHorario.Location = new System.Drawing.Point(737, 81);
            this.btnHorario.Name = "btnHorario";
            this.btnHorario.Size = new System.Drawing.Size(154, 37);
            this.btnHorario.TabIndex = 11;
            this.btnHorario.Text = "Registrar Horario";
            this.btnHorario.UseVisualStyleBackColor = false;
            this.btnHorario.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvHorarioProf
            // 
            this.dgvHorarioProf.AllowUserToAddRows = false;
            this.dgvHorarioProf.AllowUserToDeleteRows = false;
            this.dgvHorarioProf.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHorarioProf.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHorarioProf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHorarioProf.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.Hora,
            this.Especialidad,
            this.Nombre,
            this.Correo,
            this.DGVEstado,
            this.llamada});
            this.dgvHorarioProf.EnableHeadersVisualStyles = false;
            this.dgvHorarioProf.Location = new System.Drawing.Point(21, 202);
            this.dgvHorarioProf.Name = "dgvHorarioProf";
            this.dgvHorarioProf.ReadOnly = true;
            this.dgvHorarioProf.RowHeadersWidth = 51;
            this.dgvHorarioProf.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHorarioProf.Size = new System.Drawing.Size(1132, 397);
            this.dgvHorarioProf.TabIndex = 0;
            this.dgvHorarioProf.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHorarioProf_CellContentClick);
            this.dgvHorarioProf.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvHorarioProf_CellFormatting);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(1027, 170);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(126, 25);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar Cita";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnModificarHorario_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(9, 24);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 3;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(405, 25);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(227, 20);
            this.tbNombre.TabIndex = 4;
            // 
            // btnMostrarDetalles
            // 
            this.btnMostrarDetalles.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarDetalles.Location = new System.Drawing.Point(947, 170);
            this.btnMostrarDetalles.Name = "btnMostrarDetalles";
            this.btnMostrarDetalles.Size = new System.Drawing.Size(75, 25);
            this.btnMostrarDetalles.TabIndex = 5;
            this.btnMostrarDetalles.Text = "Detalles";
            this.btnMostrarDetalles.UseVisualStyleBackColor = true;
            this.btnMostrarDetalles.Click += new System.EventHandler(this.btnMostrarDetalles_Click);
            // 
            // lblFechaHora
            // 
            this.lblFechaHora.AutoSize = true;
            this.lblFechaHora.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHora.Location = new System.Drawing.Point(5, -3);
            this.lblFechaHora.Name = "lblFechaHora";
            this.lblFechaHora.Size = new System.Drawing.Size(45, 21);
            this.lblFechaHora.TabIndex = 6;
            this.lblFechaHora.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(400, -2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre del alumno";
            // 
            // cbTipoHorario
            // 
            this.cbTipoHorario.FormattingEnabled = true;
            this.cbTipoHorario.Location = new System.Drawing.Point(278, 25);
            this.cbTipoHorario.Name = "cbTipoHorario";
            this.cbTipoHorario.Size = new System.Drawing.Size(121, 21);
            this.cbTipoHorario.TabIndex = 8;
            // 
            // lblTipoHorario
            // 
            this.lblTipoHorario.AutoSize = true;
            this.lblTipoHorario.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoHorario.Location = new System.Drawing.Point(274, -2);
            this.lblTipoHorario.Name = "lblTipoHorario";
            this.lblTipoHorario.Size = new System.Drawing.Size(109, 21);
            this.lblTipoHorario.TabIndex = 9;
            this.lblTipoHorario.Text = "Tipo de Horario";
            // 
            // btnBuscarHorario
            // 
            this.btnBuscarHorario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarHorario.BackgroundImage")));
            this.btnBuscarHorario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarHorario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarHorario.Location = new System.Drawing.Point(662, 23);
            this.btnBuscarHorario.Name = "btnBuscarHorario";
            this.btnBuscarHorario.Size = new System.Drawing.Size(30, 26);
            this.btnBuscarHorario.TabIndex = 10;
            this.btnBuscarHorario.UseVisualStyleBackColor = true;
            this.btnBuscarHorario.Click += new System.EventHandler(this.btnBuscarHorario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 117);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 27);
            this.label1.TabIndex = 13;
            this.label1.Text = "Seleccione el tipo de búsqueda:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnBuscarHorario);
            this.groupBox1.Controls.Add(this.lblTipoHorario);
            this.groupBox1.Controls.Add(this.lblFechaHora);
            this.groupBox1.Controls.Add(this.rbTipoNombre);
            this.groupBox1.Controls.Add(this.dtpFecha);
            this.groupBox1.Controls.Add(this.rbFecha);
            this.groupBox1.Controls.Add(this.cbTipoHorario);
            this.groupBox1.Controls.Add(this.tbNombre);
            this.groupBox1.Location = new System.Drawing.Point(21, 147);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(697, 50);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // rbTipoNombre
            // 
            this.rbTipoNombre.AutoSize = true;
            this.rbTipoNombre.Location = new System.Drawing.Point(636, 30);
            this.rbTipoNombre.Margin = new System.Windows.Forms.Padding(2);
            this.rbTipoNombre.Name = "rbTipoNombre";
            this.rbTipoNombre.Size = new System.Drawing.Size(14, 13);
            this.rbTipoNombre.TabIndex = 14;
            this.rbTipoNombre.TabStop = true;
            this.rbTipoNombre.UseVisualStyleBackColor = true;
            // 
            // rbFecha
            // 
            this.rbFecha.AutoSize = true;
            this.rbFecha.Location = new System.Drawing.Point(214, 30);
            this.rbFecha.Margin = new System.Windows.Forms.Padding(2);
            this.rbFecha.Name = "rbFecha";
            this.rbFecha.Size = new System.Drawing.Size(14, 13);
            this.rbFecha.TabIndex = 13;
            this.rbFecha.TabStop = true;
            this.rbFecha.UseVisualStyleBackColor = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 125;
            // 
            // Hora
            // 
            this.Hora.HeaderText = "Hora";
            this.Hora.MinimumWidth = 6;
            this.Hora.Name = "Hora";
            this.Hora.ReadOnly = true;
            this.Hora.Width = 125;
            // 
            // Especialidad
            // 
            this.Especialidad.HeaderText = "Especialidad";
            this.Especialidad.MinimumWidth = 6;
            this.Especialidad.Name = "Especialidad";
            this.Especialidad.ReadOnly = true;
            this.Especialidad.Width = 170;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre del Alumno";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 250;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            this.Correo.Width = 200;
            // 
            // DGVEstado
            // 
            this.DGVEstado.HeaderText = "Estado de Cita";
            this.DGVEstado.Name = "DGVEstado";
            this.DGVEstado.ReadOnly = true;
            this.DGVEstado.Width = 110;
            // 
            // llamada
            // 
            this.llamada.HeaderText = "Iniciar Llamada";
            this.llamada.Name = "llamada";
            this.llamada.ReadOnly = true;
            this.llamada.Text = "Iniciar Llamada";
            
            // 
            // frmCitasAsesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 611);
            this.Controls.Add(this.btnHorario);
            this.Controls.Add(this.btnDescargarReporte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMostrarDetalles);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dgvHorarioProf);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCitasAsesor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Citas y Asesorías";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorarioProf)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.DataGridView dgvHorarioProf;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Button btnMostrarDetalles;
        private System.Windows.Forms.Label lblFechaHora;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTipoHorario;
        private System.Windows.Forms.Label lblTipoHorario;
        private System.Windows.Forms.Button btnBuscarHorario;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnHorario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbTipoNombre;
        private System.Windows.Forms.RadioButton rbFecha;
        private System.Windows.Forms.Button btnDescargarReporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVEstado;
        private System.Windows.Forms.DataGridViewButtonColumn llamada;
    }
}