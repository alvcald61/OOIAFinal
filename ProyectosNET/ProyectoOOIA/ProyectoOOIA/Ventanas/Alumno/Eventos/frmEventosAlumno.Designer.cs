
namespace ProyectoOOIA.Ventanas
{
    partial class frmRegistroEvento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistroEvento));
            this.tabEventos = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblNombreInscritos = new System.Windows.Forms.Label();
            this.txtNombreEvento = new System.Windows.Forms.TextBox();
            this.dtpFechaInscritos = new System.Windows.Forms.DateTimePicker();
            this.btnBuscarInscritos = new System.Windows.Forms.Button();
            this.lblFechaInscritos = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnDetInscritos = new System.Windows.Forms.Button();
            this.lblEventosInscritos = new System.Windows.Forms.Label();
            this.dvgInscritos = new System.Windows.Forms.DataGridView();
            this.NombreEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabHistorial = new System.Windows.Forms.TabPage();
            this.lblEventosPasados = new System.Windows.Forms.Label();
            this.btnDetHistorial = new System.Windows.Forms.Button();
            this.dvgHistorial = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblEventos = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.tabEventos.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgInscritos)).BeginInit();
            this.tabHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgHistorial)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.SuspendLayout();
            // 
            // tabEventos
            // 
            this.tabEventos.Controls.Add(this.tabPage1);
            this.tabEventos.Controls.Add(this.tabHistorial);
            this.tabEventos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabEventos.Location = new System.Drawing.Point(0, 77);
            this.tabEventos.Name = "tabEventos";
            this.tabEventos.SelectedIndex = 0;
            this.tabEventos.Size = new System.Drawing.Size(1014, 536);
            this.tabEventos.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.btnRegistrar);
            this.tabPage1.Controls.Add(this.btnDetInscritos);
            this.tabPage1.Controls.Add(this.lblEventosInscritos);
            this.tabPage1.Controls.Add(this.dvgInscritos);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1006, 508);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Eventos inscritos";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblNombreInscritos);
            this.panel2.Controls.Add(this.txtNombreEvento);
            this.panel2.Controls.Add(this.dtpFechaInscritos);
            this.panel2.Controls.Add(this.btnBuscarInscritos);
            this.panel2.Controls.Add(this.lblFechaInscritos);
            this.panel2.Location = new System.Drawing.Point(25, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(676, 124);
            this.panel2.TabIndex = 44;
            // 
            // lblNombreInscritos
            // 
            this.lblNombreInscritos.AutoSize = true;
            this.lblNombreInscritos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreInscritos.Location = new System.Drawing.Point(3, 15);
            this.lblNombreInscritos.Name = "lblNombreInscritos";
            this.lblNombreInscritos.Size = new System.Drawing.Size(132, 17);
            this.lblNombreInscritos.TabIndex = 28;
            this.lblNombreInscritos.Text = "Nombre del evento:";
            // 
            // txtNombreEvento
            // 
            this.txtNombreEvento.Enabled = false;
            this.txtNombreEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreEvento.Location = new System.Drawing.Point(137, 15);
            this.txtNombreEvento.Name = "txtNombreEvento";
            this.txtNombreEvento.Size = new System.Drawing.Size(289, 23);
            this.txtNombreEvento.TabIndex = 29;
            // 
            // dtpFechaInscritos
            // 
            this.dtpFechaInscritos.Enabled = false;
            this.dtpFechaInscritos.Location = new System.Drawing.Point(137, 51);
            this.dtpFechaInscritos.Name = "dtpFechaInscritos";
            this.dtpFechaInscritos.Size = new System.Drawing.Size(200, 21);
            this.dtpFechaInscritos.TabIndex = 42;
            // 
            // btnBuscarInscritos
            // 
            this.btnBuscarInscritos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarInscritos.Location = new System.Drawing.Point(432, 15);
            this.btnBuscarInscritos.Name = "btnBuscarInscritos";
            this.btnBuscarInscritos.Size = new System.Drawing.Size(87, 26);
            this.btnBuscarInscritos.TabIndex = 38;
            this.btnBuscarInscritos.Text = "Buscar";
            this.btnBuscarInscritos.UseVisualStyleBackColor = true;
            this.btnBuscarInscritos.Click += new System.EventHandler(this.btnBuscarInscritos_Click);
            // 
            // lblFechaInscritos
            // 
            this.lblFechaInscritos.AutoSize = true;
            this.lblFechaInscritos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInscritos.Location = new System.Drawing.Point(3, 54);
            this.lblFechaInscritos.Name = "lblFechaInscritos";
            this.lblFechaInscritos.Size = new System.Drawing.Size(51, 17);
            this.lblFechaInscritos.TabIndex = 34;
            this.lblFechaInscritos.Text = "Fecha:";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(719, 136);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(79, 29);
            this.btnRegistrar.TabIndex = 40;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnDetInscritos
            // 
            this.btnDetInscritos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetInscritos.Location = new System.Drawing.Point(885, 136);
            this.btnDetInscritos.Name = "btnDetInscritos";
            this.btnDetInscritos.Size = new System.Drawing.Size(95, 29);
            this.btnDetInscritos.TabIndex = 39;
            this.btnDetInscritos.Text = "Ver detalles";
            this.btnDetInscritos.UseVisualStyleBackColor = true;
            this.btnDetInscritos.Click += new System.EventHandler(this.btnDetInscritos_Click);
            // 
            // lblEventosInscritos
            // 
            this.lblEventosInscritos.AutoSize = true;
            this.lblEventosInscritos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventosInscritos.Location = new System.Drawing.Point(19, 148);
            this.lblEventosInscritos.Name = "lblEventosInscritos";
            this.lblEventosInscritos.Size = new System.Drawing.Size(132, 17);
            this.lblEventosInscritos.TabIndex = 37;
            this.lblEventosInscritos.Text = "Eventos Inscritos";
            // 
            // dvgInscritos
            // 
            this.dvgInscritos.AllowUserToAddRows = false;
            this.dvgInscritos.AllowUserToDeleteRows = false;
            this.dvgInscritos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgInscritos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvgInscritos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgInscritos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreEvento,
            this.Fecha,
            this.HoraInicio,
            this.HoraFin,
            this.Categoria});
            this.dvgInscritos.EnableHeadersVisualStyles = false;
            this.dvgInscritos.Location = new System.Drawing.Point(22, 171);
            this.dvgInscritos.Name = "dvgInscritos";
            this.dvgInscritos.ReadOnly = true;
            this.dvgInscritos.RowHeadersWidth = 51;
            this.dvgInscritos.Size = new System.Drawing.Size(958, 327);
            this.dvgInscritos.TabIndex = 36;
            this.dvgInscritos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgInscritos_CellContentClick);
            this.dvgInscritos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dvgInscritos_CellFormatting);
            // 
            // NombreEvento
            // 
            this.NombreEvento.DataPropertyName = "nombre";
            this.NombreEvento.HeaderText = "Nombre";
            this.NombreEvento.MinimumWidth = 6;
            this.NombreEvento.Name = "NombreEvento";
            this.NombreEvento.ReadOnly = true;
            this.NombreEvento.Width = 400;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "fecha";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 125;
            // 
            // HoraInicio
            // 
            this.HoraInicio.DataPropertyName = "horaInicio";
            this.HoraInicio.HeaderText = "Hora Inicio";
            this.HoraInicio.MinimumWidth = 6;
            this.HoraInicio.Name = "HoraInicio";
            this.HoraInicio.ReadOnly = true;
            this.HoraInicio.Width = 120;
            // 
            // HoraFin
            // 
            this.HoraFin.DataPropertyName = "horaFin";
            this.HoraFin.HeaderText = "Hora Fin";
            this.HoraFin.MinimumWidth = 6;
            this.HoraFin.Name = "HoraFin";
            this.HoraFin.ReadOnly = true;
            this.HoraFin.Width = 120;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.MinimumWidth = 6;
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            this.Categoria.Width = 140;
            // 
            // tabHistorial
            // 
            this.tabHistorial.BackColor = System.Drawing.SystemColors.Control;
            this.tabHistorial.Controls.Add(this.lblEventosPasados);
            this.tabHistorial.Controls.Add(this.btnDetHistorial);
            this.tabHistorial.Controls.Add(this.dvgHistorial);
            this.tabHistorial.Location = new System.Drawing.Point(4, 24);
            this.tabHistorial.Name = "tabHistorial";
            this.tabHistorial.Padding = new System.Windows.Forms.Padding(3);
            this.tabHistorial.Size = new System.Drawing.Size(1006, 508);
            this.tabHistorial.TabIndex = 1;
            this.tabHistorial.Text = "Historial de eventos";
            // 
            // lblEventosPasados
            // 
            this.lblEventosPasados.AutoSize = true;
            this.lblEventosPasados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventosPasados.Location = new System.Drawing.Point(19, 38);
            this.lblEventosPasados.Name = "lblEventosPasados";
            this.lblEventosPasados.Size = new System.Drawing.Size(133, 17);
            this.lblEventosPasados.TabIndex = 41;
            this.lblEventosPasados.Text = "Eventos Pasados";
            // 
            // btnDetHistorial
            // 
            this.btnDetHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetHistorial.Location = new System.Drawing.Point(884, 15);
            this.btnDetHistorial.Name = "btnDetHistorial";
            this.btnDetHistorial.Size = new System.Drawing.Size(95, 29);
            this.btnDetHistorial.TabIndex = 40;
            this.btnDetHistorial.Text = "Ver detalles";
            this.btnDetHistorial.UseVisualStyleBackColor = true;
            this.btnDetHistorial.Click += new System.EventHandler(this.btnDetHistorial_Click);
            // 
            // dvgHistorial
            // 
            this.dvgHistorial.AllowUserToAddRows = false;
            this.dvgHistorial.AllowUserToDeleteRows = false;
            this.dvgHistorial.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgHistorial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dvgHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgHistorial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dvgHistorial.EnableHeadersVisualStyles = false;
            this.dvgHistorial.Location = new System.Drawing.Point(22, 71);
            this.dvgHistorial.Name = "dvgHistorial";
            this.dvgHistorial.ReadOnly = true;
            this.dvgHistorial.RowHeadersWidth = 51;
            this.dvgHistorial.Size = new System.Drawing.Size(958, 327);
            this.dvgHistorial.TabIndex = 37;
            this.dvgHistorial.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dvgHistorial_CellFormatting);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 400;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "fecha";
            this.dataGridViewTextBoxColumn2.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "horaInicio";
            this.dataGridViewTextBoxColumn3.HeaderText = "Hora Inicio";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 120;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "horaFin";
            this.dataGridViewTextBoxColumn4.HeaderText = "Hora Fin";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 120;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Categoria";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 140;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(71)))), ((int)(((byte)(123)))));
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.lblEventos);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1014, 71);
            this.panel1.TabIndex = 43;
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
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblEventos
            // 
            this.lblEventos.AutoSize = true;
            this.lblEventos.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventos.ForeColor = System.Drawing.SystemColors.Window;
            this.lblEventos.Location = new System.Drawing.Point(40, 30);
            this.lblEventos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEventos.Name = "lblEventos";
            this.lblEventos.Size = new System.Drawing.Size(189, 29);
            this.lblEventos.TabIndex = 3;
            this.lblEventos.Text = "Lista de Eventos";
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(11, 30);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(25, 25);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnHome.TabIndex = 2;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // frmRegistroEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 611);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabEventos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmRegistroEvento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eventos";
            this.Load += new System.EventHandler(this.frmEventosAlumno_Load);
            this.tabEventos.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgInscritos)).EndInit();
            this.tabHistorial.ResumeLayout(false);
            this.tabHistorial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgHistorial)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabEventos;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnDetInscritos;
        private System.Windows.Forms.Button btnBuscarInscritos;
        private System.Windows.Forms.Label lblEventosInscritos;
        private System.Windows.Forms.DataGridView dvgInscritos;
        private System.Windows.Forms.Label lblFechaInscritos;
        private System.Windows.Forms.TextBox txtNombreEvento;
        private System.Windows.Forms.Label lblNombreInscritos;
        private System.Windows.Forms.TabPage tabHistorial;
        private System.Windows.Forms.Button btnDetHistorial;
        private System.Windows.Forms.DataGridView dvgHistorial;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Label lblEventos;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblEventosPasados;
        private System.Windows.Forms.DateTimePicker dtpFechaInscritos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
    }
}