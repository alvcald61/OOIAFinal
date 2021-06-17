
namespace ProyectoOOIA.Ventanas
{
    partial class frmCitasAlumno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCitasAlumno));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.lblCitasHeader = new System.Windows.Forms.Label();
            this.dgvCitasProgramadas = new System.Windows.Forms.DataGridView();
            this.Orientador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asistencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabHistorial = new System.Windows.Forms.TabControl();
            this.tabCitasProgramadas = new System.Windows.Forms.TabPage();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.pnlRegistrarCita = new System.Windows.Forms.Panel();
            this.lblRegistrar = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblAsesor = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHoraInicio = new System.Windows.Forms.Label();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.lblHoraFin = new System.Windows.Forms.Label();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.txtAsesor = new System.Windows.Forms.TextBox();
            this.btnBuscarAsesor = new System.Windows.Forms.Button();
            this.txtHoraInicio = new System.Windows.Forms.TextBox();
            this.btnBuscarHorario = new System.Windows.Forms.Button();
            this.txtHoraFin = new System.Windows.Forms.TextBox();
            this.lblListaCitasInscritas = new System.Windows.Forms.Label();
            this.btnDetInscritas = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tabHistorialCitas = new System.Windows.Forms.TabPage();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblListaCitasPasadas = new System.Windows.Forms.Label();
            this.btnAgregarOpinion = new System.Windows.Forms.Button();
            this.btnDetHistorial = new System.Windows.Forms.Button();
            this.dgvHistorialCitas = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitasProgramadas)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabHistorial.SuspendLayout();
            this.tabCitasProgramadas.SuspendLayout();
            this.pnlRegistrarCita.SuspendLayout();
            this.tabHistorialCitas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialCitas)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(71)))), ((int)(((byte)(123)))));
            this.panel1.Controls.Add(this.btnAtras);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.lblCitasHeader);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1352, 87);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btnAtras
            // 
            this.btnAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtras.BackColor = System.Drawing.Color.Transparent;
            this.btnAtras.BackgroundImage = global::ProyectoOOIA.Properties.Resources.logout_white;
            this.btnAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtras.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnAtras.FlatAppearance.BorderSize = 0;
            this.btnAtras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAtras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtras.Location = new System.Drawing.Point(1289, 34);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(4);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(47, 42);
            this.btnAtras.TabIndex = 13;
            this.btnAtras.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(15, 39);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(33, 31);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnHome.TabIndex = 1;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblCitasHeader
            // 
            this.lblCitasHeader.AutoSize = true;
            this.lblCitasHeader.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCitasHeader.ForeColor = System.Drawing.SystemColors.Window;
            this.lblCitasHeader.Location = new System.Drawing.Point(65, 39);
            this.lblCitasHeader.Name = "lblCitasHeader";
            this.lblCitasHeader.Size = new System.Drawing.Size(206, 38);
            this.lblCitasHeader.TabIndex = 0;
            this.lblCitasHeader.Text = "Citas y Asesorías";
            // 
            // dgvCitasProgramadas
            // 
            this.dgvCitasProgramadas.AllowUserToDeleteRows = false;
            this.dgvCitasProgramadas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCitasProgramadas.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCitasProgramadas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCitasProgramadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCitasProgramadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Orientador,
            this.Fecha,
            this.HoraInicio,
            this.HoraFin,
            this.Asistencia});
            this.dgvCitasProgramadas.EnableHeadersVisualStyles = false;
            this.dgvCitasProgramadas.Location = new System.Drawing.Point(35, 372);
            this.dgvCitasProgramadas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCitasProgramadas.Name = "dgvCitasProgramadas";
            this.dgvCitasProgramadas.ReadOnly = true;
            this.dgvCitasProgramadas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvCitasProgramadas.RowHeadersWidth = 51;
            this.dgvCitasProgramadas.RowTemplate.Height = 24;
            this.dgvCitasProgramadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCitasProgramadas.Size = new System.Drawing.Size(1296, 246);
            this.dgvCitasProgramadas.TabIndex = 1;
            this.dgvCitasProgramadas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCitasProgramadas_CellContentClick);
            // 
            // Orientador
            // 
            this.Orientador.HeaderText = "Orientador";
            this.Orientador.MinimumWidth = 6;
            this.Orientador.Name = "Orientador";
            this.Orientador.ReadOnly = true;
            this.Orientador.Width = 285;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 125;
            // 
            // HoraInicio
            // 
            this.HoraInicio.HeaderText = "Hora Inicio";
            this.HoraInicio.MinimumWidth = 6;
            this.HoraInicio.Name = "HoraInicio";
            this.HoraInicio.ReadOnly = true;
            this.HoraInicio.Width = 125;
            // 
            // HoraFin
            // 
            this.HoraFin.HeaderText = "Hora Fin";
            this.HoraFin.MinimumWidth = 6;
            this.HoraFin.Name = "HoraFin";
            this.HoraFin.ReadOnly = true;
            this.HoraFin.Width = 125;
            // 
            // Asistencia
            // 
            this.Asistencia.HeaderText = "Asistencia";
            this.Asistencia.MinimumWidth = 6;
            this.Asistencia.Name = "Asistencia";
            this.Asistencia.ReadOnly = true;
            this.Asistencia.Width = 125;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnEliminar.Location = new System.Drawing.Point(1068, 336);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(123, 31);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Controls.Add(this.tabHistorial);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Location = new System.Drawing.Point(0, 87);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1352, 665);
            this.panel2.TabIndex = 3;
            // 
            // tabHistorial
            // 
            this.tabHistorial.Controls.Add(this.tabCitasProgramadas);
            this.tabHistorial.Controls.Add(this.tabHistorialCitas);
            this.tabHistorial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabHistorial.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabHistorial.Location = new System.Drawing.Point(0, 0);
            this.tabHistorial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabHistorial.Name = "tabHistorial";
            this.tabHistorial.SelectedIndex = 0;
            this.tabHistorial.Size = new System.Drawing.Size(1352, 665);
            this.tabHistorial.TabIndex = 3;
            // 
            // tabCitasProgramadas
            // 
            this.tabCitasProgramadas.BackColor = System.Drawing.SystemColors.Control;
            this.tabCitasProgramadas.Controls.Add(this.btnCancelar);
            this.tabCitasProgramadas.Controls.Add(this.btnNuevo);
            this.tabCitasProgramadas.Controls.Add(this.pnlRegistrarCita);
            this.tabCitasProgramadas.Controls.Add(this.lblListaCitasInscritas);
            this.tabCitasProgramadas.Controls.Add(this.btnDetInscritas);
            this.tabCitasProgramadas.Controls.Add(this.btnGuardar);
            this.tabCitasProgramadas.Controls.Add(this.btnEliminar);
            this.tabCitasProgramadas.Controls.Add(this.dgvCitasProgramadas);
            this.tabCitasProgramadas.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCitasProgramadas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabCitasProgramadas.Location = new System.Drawing.Point(4, 30);
            this.tabCitasProgramadas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabCitasProgramadas.Name = "tabCitasProgramadas";
            this.tabCitasProgramadas.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabCitasProgramadas.Size = new System.Drawing.Size(1344, 631);
            this.tabCitasProgramadas.TabIndex = 0;
            this.tabCitasProgramadas.Text = "Citas programadas";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnCancelar.Location = new System.Drawing.Point(267, 6);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(123, 31);
            this.btnCancelar.TabIndex = 55;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnNuevo.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnNuevo.Location = new System.Drawing.Point(11, 6);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(123, 31);
            this.btnNuevo.TabIndex = 54;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // pnlRegistrarCita
            // 
            this.pnlRegistrarCita.Controls.Add(this.lblRegistrar);
            this.pnlRegistrarCita.Controls.Add(this.dtpFecha);
            this.pnlRegistrarCita.Controls.Add(this.lblAsesor);
            this.pnlRegistrarCita.Controls.Add(this.lblFecha);
            this.pnlRegistrarCita.Controls.Add(this.lblHoraInicio);
            this.pnlRegistrarCita.Controls.Add(this.txtMotivo);
            this.pnlRegistrarCita.Controls.Add(this.lblHoraFin);
            this.pnlRegistrarCita.Controls.Add(this.lblMotivo);
            this.pnlRegistrarCita.Controls.Add(this.txtAsesor);
            this.pnlRegistrarCita.Controls.Add(this.btnBuscarAsesor);
            this.pnlRegistrarCita.Controls.Add(this.txtHoraInicio);
            this.pnlRegistrarCita.Controls.Add(this.btnBuscarHorario);
            this.pnlRegistrarCita.Controls.Add(this.txtHoraFin);
            this.pnlRegistrarCita.Location = new System.Drawing.Point(11, 68);
            this.pnlRegistrarCita.Margin = new System.Windows.Forms.Padding(4);
            this.pnlRegistrarCita.Name = "pnlRegistrarCita";
            this.pnlRegistrarCita.Size = new System.Drawing.Size(773, 270);
            this.pnlRegistrarCita.TabIndex = 53;
            // 
            // lblRegistrar
            // 
            this.lblRegistrar.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrar.Location = new System.Drawing.Point(19, 0);
            this.lblRegistrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegistrar.Name = "lblRegistrar";
            this.lblRegistrar.Size = new System.Drawing.Size(276, 28);
            this.lblRegistrar.TabIndex = 50;
            this.lblRegistrar.Text = "Registrar una nueva cita";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Location = new System.Drawing.Point(133, 63);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(265, 25);
            this.dtpFecha.TabIndex = 52;
            // 
            // lblAsesor
            // 
            this.lblAsesor.AutoSize = true;
            this.lblAsesor.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsesor.Location = new System.Drawing.Point(19, 28);
            this.lblAsesor.Name = "lblAsesor";
            this.lblAsesor.Size = new System.Drawing.Size(75, 27);
            this.lblAsesor.TabIndex = 25;
            this.lblAsesor.Text = "Asesor: ";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(19, 63);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(65, 27);
            this.lblFecha.TabIndex = 26;
            this.lblFecha.Text = "Fecha: ";
            // 
            // lblHoraInicio
            // 
            this.lblHoraInicio.AutoSize = true;
            this.lblHoraInicio.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraInicio.Location = new System.Drawing.Point(19, 96);
            this.lblHoraInicio.Name = "lblHoraInicio";
            this.lblHoraInicio.Size = new System.Drawing.Size(106, 27);
            this.lblHoraInicio.TabIndex = 27;
            this.lblHoraInicio.Text = "Hora inicio: ";
            // 
            // txtMotivo
            // 
            this.txtMotivo.Enabled = false;
            this.txtMotivo.Location = new System.Drawing.Point(24, 165);
            this.txtMotivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMotivo.Multiline = true;
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(647, 94);
            this.txtMotivo.TabIndex = 36;
            // 
            // lblHoraFin
            // 
            this.lblHoraFin.AutoSize = true;
            this.lblHoraFin.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraFin.Location = new System.Drawing.Point(292, 96);
            this.lblHoraFin.Name = "lblHoraFin";
            this.lblHoraFin.Size = new System.Drawing.Size(85, 27);
            this.lblHoraFin.TabIndex = 28;
            this.lblHoraFin.Text = "Hora fin: ";
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotivo.Location = new System.Drawing.Point(19, 137);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(222, 27);
            this.lblMotivo.TabIndex = 35;
            this.lblMotivo.Text = "Ingrese motivo de consulta:";
            // 
            // txtAsesor
            // 
            this.txtAsesor.Enabled = false;
            this.txtAsesor.Location = new System.Drawing.Point(133, 31);
            this.txtAsesor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAsesor.Name = "txtAsesor";
            this.txtAsesor.ReadOnly = true;
            this.txtAsesor.Size = new System.Drawing.Size(327, 25);
            this.txtAsesor.TabIndex = 29;
            // 
            // btnBuscarAsesor
            // 
            this.btnBuscarAsesor.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarAsesor.Location = new System.Drawing.Point(467, 32);
            this.btnBuscarAsesor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscarAsesor.Name = "btnBuscarAsesor";
            this.btnBuscarAsesor.Size = new System.Drawing.Size(44, 27);
            this.btnBuscarAsesor.TabIndex = 34;
            this.btnBuscarAsesor.Text = "...";
            this.btnBuscarAsesor.UseVisualStyleBackColor = true;
            this.btnBuscarAsesor.Click += new System.EventHandler(this.btnBuscarAsesor_Click);
            // 
            // txtHoraInicio
            // 
            this.txtHoraInicio.Enabled = false;
            this.txtHoraInicio.Location = new System.Drawing.Point(133, 96);
            this.txtHoraInicio.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoraInicio.Name = "txtHoraInicio";
            this.txtHoraInicio.ReadOnly = true;
            this.txtHoraInicio.Size = new System.Drawing.Size(115, 25);
            this.txtHoraInicio.TabIndex = 31;
            // 
            // btnBuscarHorario
            // 
            this.btnBuscarHorario.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarHorario.Location = new System.Drawing.Point(407, 64);
            this.btnBuscarHorario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscarHorario.Name = "btnBuscarHorario";
            this.btnBuscarHorario.Size = new System.Drawing.Size(44, 27);
            this.btnBuscarHorario.TabIndex = 33;
            this.btnBuscarHorario.Text = "...";
            this.btnBuscarHorario.UseVisualStyleBackColor = true;
            this.btnBuscarHorario.Click += new System.EventHandler(this.btnBuscarHorario_Click);
            // 
            // txtHoraFin
            // 
            this.txtHoraFin.Enabled = false;
            this.txtHoraFin.Location = new System.Drawing.Point(387, 96);
            this.txtHoraFin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHoraFin.Name = "txtHoraFin";
            this.txtHoraFin.ReadOnly = true;
            this.txtHoraFin.Size = new System.Drawing.Size(115, 25);
            this.txtHoraFin.TabIndex = 32;
            // 
            // lblListaCitasInscritas
            // 
            this.lblListaCitasInscritas.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaCitasInscritas.Location = new System.Drawing.Point(29, 341);
            this.lblListaCitasInscritas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblListaCitasInscritas.Name = "lblListaCitasInscritas";
            this.lblListaCitasInscritas.Size = new System.Drawing.Size(276, 28);
            this.lblListaCitasInscritas.TabIndex = 51;
            this.lblListaCitasInscritas.Text = "Lista de Citas Inscritas";
            // 
            // btnDetInscritas
            // 
            this.btnDetInscritas.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnDetInscritas.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnDetInscritas.Location = new System.Drawing.Point(1196, 337);
            this.btnDetInscritas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDetInscritas.Name = "btnDetInscritas";
            this.btnDetInscritas.Size = new System.Drawing.Size(135, 30);
            this.btnDetInscritas.TabIndex = 7;
            this.btnDetInscritas.Text = "Ver detalle";
            this.btnDetInscritas.UseVisualStyleBackColor = false;
            this.btnDetInscritas.Click += new System.EventHandler(this.btnDetInscritas_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnGuardar.Location = new System.Drawing.Point(139, 6);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(123, 31);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // tabHistorialCitas
            // 
            this.tabHistorialCitas.BackColor = System.Drawing.SystemColors.Control;
            this.tabHistorialCitas.Controls.Add(this.btnBuscar);
            this.tabHistorialCitas.Controls.Add(this.label1);
            this.tabHistorialCitas.Controls.Add(this.textBox1);
            this.tabHistorialCitas.Controls.Add(this.lblListaCitasPasadas);
            this.tabHistorialCitas.Controls.Add(this.btnAgregarOpinion);
            this.tabHistorialCitas.Controls.Add(this.btnDetHistorial);
            this.tabHistorialCitas.Controls.Add(this.dgvHistorialCitas);
            this.tabHistorialCitas.Location = new System.Drawing.Point(4, 30);
            this.tabHistorialCitas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabHistorialCitas.Name = "tabHistorialCitas";
            this.tabHistorialCitas.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabHistorialCitas.Size = new System.Drawing.Size(1344, 631);
            this.tabHistorialCitas.TabIndex = 1;
            this.tabHistorialCitas.Text = "Historial de citas";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnBuscar.Location = new System.Drawing.Point(871, 44);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(123, 31);
            this.btnBuscar.TabIndex = 55;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(35, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 25);
            this.label1.TabIndex = 54;
            this.label1.Text = "Ingrese el nombre de un tutor o una fecha:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(371, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(474, 25);
            this.textBox1.TabIndex = 53;
            // 
            // lblListaCitasPasadas
            // 
            this.lblListaCitasPasadas.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaCitasPasadas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblListaCitasPasadas.Location = new System.Drawing.Point(30, 113);
            this.lblListaCitasPasadas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblListaCitasPasadas.Name = "lblListaCitasPasadas";
            this.lblListaCitasPasadas.Size = new System.Drawing.Size(276, 28);
            this.lblListaCitasPasadas.TabIndex = 52;
            this.lblListaCitasPasadas.Text = "Lista de Citas Pasadas";
            // 
            // btnAgregarOpinion
            // 
            this.btnAgregarOpinion.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAgregarOpinion.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnAgregarOpinion.Location = new System.Drawing.Point(1044, 111);
            this.btnAgregarOpinion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarOpinion.Name = "btnAgregarOpinion";
            this.btnAgregarOpinion.Size = new System.Drawing.Size(137, 30);
            this.btnAgregarOpinion.TabIndex = 7;
            this.btnAgregarOpinion.Text = "Agregar opinión";
            this.btnAgregarOpinion.UseVisualStyleBackColor = false;
            this.btnAgregarOpinion.Click += new System.EventHandler(this.btnAgregarOpinion_Click);
            // 
            // btnDetHistorial
            // 
            this.btnDetHistorial.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnDetHistorial.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnDetHistorial.Location = new System.Drawing.Point(1196, 111);
            this.btnDetHistorial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDetHistorial.Name = "btnDetHistorial";
            this.btnDetHistorial.Size = new System.Drawing.Size(135, 30);
            this.btnDetHistorial.TabIndex = 6;
            this.btnDetHistorial.Text = "Ver detalle";
            this.btnDetHistorial.UseVisualStyleBackColor = false;
            this.btnDetHistorial.Click += new System.EventHandler(this.btnDetalleHistorial_Click);
            // 
            // dgvHistorialCitas
            // 
            this.dgvHistorialCitas.AllowUserToDeleteRows = false;
            this.dgvHistorialCitas.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHistorialCitas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvHistorialCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorialCitas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgvHistorialCitas.EnableHeadersVisualStyles = false;
            this.dgvHistorialCitas.Location = new System.Drawing.Point(35, 158);
            this.dgvHistorialCitas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvHistorialCitas.Name = "dgvHistorialCitas";
            this.dgvHistorialCitas.ReadOnly = true;
            this.dgvHistorialCitas.RowHeadersWidth = 51;
            this.dgvHistorialCitas.RowTemplate.Height = 24;
            this.dgvHistorialCitas.Size = new System.Drawing.Size(1296, 460);
            this.dgvHistorialCitas.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Orientador";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 285;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Hora Inicio";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Hora Fin";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Asistencia";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1352, 87);
            this.panel3.TabIndex = 4;
            // 
            // frmCitasAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 752);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmCitasAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de citas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitasProgramadas)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tabHistorial.ResumeLayout(false);
            this.tabCitasProgramadas.ResumeLayout(false);
            this.pnlRegistrarCita.ResumeLayout(false);
            this.pnlRegistrarCita.PerformLayout();
            this.tabHistorialCitas.ResumeLayout(false);
            this.tabHistorialCitas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialCitas)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Label lblCitasHeader;
        private System.Windows.Forms.DataGridView dgvCitasProgramadas;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabControl tabHistorial;
        private System.Windows.Forms.TabPage tabCitasProgramadas;
        private System.Windows.Forms.TabPage tabHistorialCitas;
        private System.Windows.Forms.Button btnDetHistorial;
        private System.Windows.Forms.DataGridView dgvHistorialCitas;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnAgregarOpinion;
        private System.Windows.Forms.Button btnDetInscritas;
        private System.Windows.Forms.Button btnBuscarAsesor;
        private System.Windows.Forms.Button btnBuscarHorario;
        private System.Windows.Forms.TextBox txtHoraFin;
        private System.Windows.Forms.TextBox txtHoraInicio;
        private System.Windows.Forms.TextBox txtAsesor;
        private System.Windows.Forms.Label lblHoraFin;
        private System.Windows.Forms.Label lblHoraInicio;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblAsesor;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.Label lblListaCitasInscritas;
        private System.Windows.Forms.Label lblRegistrar;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblListaCitasPasadas;
        private System.Windows.Forms.Panel pnlRegistrarCita;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Orientador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asistencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}