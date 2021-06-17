
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistroEvento));
            this.tabEventos = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblNombreInscritos = new System.Windows.Forms.Label();
            this.txtNombreInscritos = new System.Windows.Forms.TextBox();
            this.dtpFechaInscritos = new System.Windows.Forms.DateTimePicker();
            this.lblCategoriaInscritos = new System.Windows.Forms.Label();
            this.txtCategoriaInscritos = new System.Windows.Forms.TextBox();
            this.btnBuscarInscritos = new System.Windows.Forms.Button();
            this.lblFechaInscritos = new System.Windows.Forms.Label();
            this.txtHoraInscritos = new System.Windows.Forms.TextBox();
            this.lblHoraInscritos = new System.Windows.Forms.Label();
            this.btnAcceder = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblNombreHistorial = new System.Windows.Forms.Label();
            this.txtNombreHistorial = new System.Windows.Forms.TextBox();
            this.dtpFechaHistorial = new System.Windows.Forms.DateTimePicker();
            this.lblCategoríaHistorial = new System.Windows.Forms.Label();
            this.txtCategoriaHistorial = new System.Windows.Forms.TextBox();
            this.btnBuscarHistorial = new System.Windows.Forms.Button();
            this.lblFechaHistorial = new System.Windows.Forms.Label();
            this.txtHoraHistorial = new System.Windows.Forms.TextBox();
            this.lblHoraHistorial = new System.Windows.Forms.Label();
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabEventos.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgInscritos)).BeginInit();
            this.tabHistorial.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.tabPage1.Controls.Add(this.btnAcceder);
            this.tabPage1.Controls.Add(this.btnEliminar);
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
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblNombreInscritos);
            this.panel2.Controls.Add(this.txtNombreInscritos);
            this.panel2.Controls.Add(this.dtpFechaInscritos);
            this.panel2.Controls.Add(this.lblCategoriaInscritos);
            this.panel2.Controls.Add(this.txtCategoriaInscritos);
            this.panel2.Controls.Add(this.btnBuscarInscritos);
            this.panel2.Controls.Add(this.lblFechaInscritos);
            this.panel2.Controls.Add(this.txtHoraInscritos);
            this.panel2.Controls.Add(this.lblHoraInscritos);
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
            // txtNombreInscritos
            // 
            this.txtNombreInscritos.Enabled = false;
            this.txtNombreInscritos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreInscritos.Location = new System.Drawing.Point(137, 15);
            this.txtNombreInscritos.Name = "txtNombreInscritos";
            this.txtNombreInscritos.Size = new System.Drawing.Size(289, 23);
            this.txtNombreInscritos.TabIndex = 29;
            // 
            // dtpFechaInscritos
            // 
            this.dtpFechaInscritos.Enabled = false;
            this.dtpFechaInscritos.Location = new System.Drawing.Point(137, 73);
            this.dtpFechaInscritos.Name = "dtpFechaInscritos";
            this.dtpFechaInscritos.Size = new System.Drawing.Size(200, 21);
            this.dtpFechaInscritos.TabIndex = 42;
            // 
            // lblCategoriaInscritos
            // 
            this.lblCategoriaInscritos.AutoSize = true;
            this.lblCategoriaInscritos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaInscritos.Location = new System.Drawing.Point(3, 44);
            this.lblCategoriaInscritos.Name = "lblCategoriaInscritos";
            this.lblCategoriaInscritos.Size = new System.Drawing.Size(73, 17);
            this.lblCategoriaInscritos.TabIndex = 30;
            this.lblCategoriaInscritos.Text = "Categoria:";
            // 
            // txtCategoriaInscritos
            // 
            this.txtCategoriaInscritos.Enabled = false;
            this.txtCategoriaInscritos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoriaInscritos.Location = new System.Drawing.Point(137, 44);
            this.txtCategoriaInscritos.Name = "txtCategoriaInscritos";
            this.txtCategoriaInscritos.Size = new System.Drawing.Size(137, 23);
            this.txtCategoriaInscritos.TabIndex = 31;
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
            this.lblFechaInscritos.Location = new System.Drawing.Point(3, 73);
            this.lblFechaInscritos.Name = "lblFechaInscritos";
            this.lblFechaInscritos.Size = new System.Drawing.Size(51, 17);
            this.lblFechaInscritos.TabIndex = 34;
            this.lblFechaInscritos.Text = "Fecha:";
            // 
            // txtHoraInscritos
            // 
            this.txtHoraInscritos.Enabled = false;
            this.txtHoraInscritos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoraInscritos.Location = new System.Drawing.Point(432, 71);
            this.txtHoraInscritos.Name = "txtHoraInscritos";
            this.txtHoraInscritos.Size = new System.Drawing.Size(74, 23);
            this.txtHoraInscritos.TabIndex = 35;
            // 
            // lblHoraInscritos
            // 
            this.lblHoraInscritos.AutoSize = true;
            this.lblHoraInscritos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraInscritos.Location = new System.Drawing.Point(349, 74);
            this.lblHoraInscritos.Name = "lblHoraInscritos";
            this.lblHoraInscritos.Size = new System.Drawing.Size(79, 17);
            this.lblHoraInscritos.TabIndex = 32;
            this.lblHoraInscritos.Text = "Hora inicio:";
            // 
            // btnAcceder
            // 
            this.btnAcceder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcceder.Location = new System.Drawing.Point(634, 136);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(79, 29);
            this.btnAcceder.TabIndex = 43;
            this.btnAcceder.Text = "Acceder";
            this.btnAcceder.UseVisualStyleBackColor = true;
            this.btnAcceder.Click += new System.EventHandler(this.btnAcceder_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(804, 136);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 29);
            this.btnEliminar.TabIndex = 41;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            this.lblEventosInscritos.Location = new System.Drawing.Point(22, 133);
            this.lblEventosInscritos.Name = "lblEventosInscritos";
            this.lblEventosInscritos.Size = new System.Drawing.Size(132, 17);
            this.lblEventosInscritos.TabIndex = 37;
            this.lblEventosInscritos.Text = "Eventos Inscritos";
            // 
            // dvgInscritos
            // 
            this.dvgInscritos.AllowUserToDeleteRows = false;
            this.dvgInscritos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgInscritos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
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
            this.dvgInscritos.RowHeadersWidth = 51;
            this.dvgInscritos.Size = new System.Drawing.Size(958, 327);
            this.dvgInscritos.TabIndex = 36;
            // 
            // NombreEvento
            // 
            this.NombreEvento.HeaderText = "Nombre";
            this.NombreEvento.MinimumWidth = 6;
            this.NombreEvento.Name = "NombreEvento";
            this.NombreEvento.Width = 400;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.Width = 125;
            // 
            // HoraInicio
            // 
            this.HoraInicio.HeaderText = "Hora Inicio";
            this.HoraInicio.MinimumWidth = 6;
            this.HoraInicio.Name = "HoraInicio";
            this.HoraInicio.Width = 120;
            // 
            // HoraFin
            // 
            this.HoraFin.HeaderText = "Hora Fin";
            this.HoraFin.MinimumWidth = 6;
            this.HoraFin.Name = "HoraFin";
            this.HoraFin.Width = 120;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.MinimumWidth = 6;
            this.Categoria.Name = "Categoria";
            this.Categoria.Width = 140;
            // 
            // tabHistorial
            // 
            this.tabHistorial.BackColor = System.Drawing.SystemColors.Control;
            this.tabHistorial.Controls.Add(this.panel3);
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
            // panel3
            // 
            this.panel3.Controls.Add(this.lblNombreHistorial);
            this.panel3.Controls.Add(this.txtNombreHistorial);
            this.panel3.Controls.Add(this.dtpFechaHistorial);
            this.panel3.Controls.Add(this.lblCategoríaHistorial);
            this.panel3.Controls.Add(this.txtCategoriaHistorial);
            this.panel3.Controls.Add(this.btnBuscarHistorial);
            this.panel3.Controls.Add(this.lblFechaHistorial);
            this.panel3.Controls.Add(this.txtHoraHistorial);
            this.panel3.Controls.Add(this.lblHoraHistorial);
            this.panel3.Location = new System.Drawing.Point(22, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(564, 124);
            this.panel3.TabIndex = 45;
            // 
            // lblNombreHistorial
            // 
            this.lblNombreHistorial.AutoSize = true;
            this.lblNombreHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreHistorial.Location = new System.Drawing.Point(3, 15);
            this.lblNombreHistorial.Name = "lblNombreHistorial";
            this.lblNombreHistorial.Size = new System.Drawing.Size(132, 17);
            this.lblNombreHistorial.TabIndex = 28;
            this.lblNombreHistorial.Text = "Nombre del evento:";
            // 
            // txtNombreHistorial
            // 
            this.txtNombreHistorial.Enabled = false;
            this.txtNombreHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreHistorial.Location = new System.Drawing.Point(137, 15);
            this.txtNombreHistorial.Name = "txtNombreHistorial";
            this.txtNombreHistorial.Size = new System.Drawing.Size(289, 23);
            this.txtNombreHistorial.TabIndex = 29;
            // 
            // dtpFechaHistorial
            // 
            this.dtpFechaHistorial.Enabled = false;
            this.dtpFechaHistorial.Location = new System.Drawing.Point(137, 73);
            this.dtpFechaHistorial.Name = "dtpFechaHistorial";
            this.dtpFechaHistorial.Size = new System.Drawing.Size(200, 21);
            this.dtpFechaHistorial.TabIndex = 42;
            // 
            // lblCategoríaHistorial
            // 
            this.lblCategoríaHistorial.AutoSize = true;
            this.lblCategoríaHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoríaHistorial.Location = new System.Drawing.Point(3, 44);
            this.lblCategoríaHistorial.Name = "lblCategoríaHistorial";
            this.lblCategoríaHistorial.Size = new System.Drawing.Size(73, 17);
            this.lblCategoríaHistorial.TabIndex = 30;
            this.lblCategoríaHistorial.Text = "Categoria:";
            // 
            // txtCategoriaHistorial
            // 
            this.txtCategoriaHistorial.Enabled = false;
            this.txtCategoriaHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoriaHistorial.Location = new System.Drawing.Point(137, 44);
            this.txtCategoriaHistorial.Name = "txtCategoriaHistorial";
            this.txtCategoriaHistorial.Size = new System.Drawing.Size(137, 23);
            this.txtCategoriaHistorial.TabIndex = 31;
            // 
            // btnBuscarHistorial
            // 
            this.btnBuscarHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarHistorial.Location = new System.Drawing.Point(432, 15);
            this.btnBuscarHistorial.Name = "btnBuscarHistorial";
            this.btnBuscarHistorial.Size = new System.Drawing.Size(87, 26);
            this.btnBuscarHistorial.TabIndex = 38;
            this.btnBuscarHistorial.Text = "Buscar";
            this.btnBuscarHistorial.UseVisualStyleBackColor = true;
            this.btnBuscarHistorial.Click += new System.EventHandler(this.btnBuscarHistorial_Click);
            // 
            // lblFechaHistorial
            // 
            this.lblFechaHistorial.AutoSize = true;
            this.lblFechaHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHistorial.Location = new System.Drawing.Point(3, 73);
            this.lblFechaHistorial.Name = "lblFechaHistorial";
            this.lblFechaHistorial.Size = new System.Drawing.Size(51, 17);
            this.lblFechaHistorial.TabIndex = 34;
            this.lblFechaHistorial.Text = "Fecha:";
            // 
            // txtHoraHistorial
            // 
            this.txtHoraHistorial.Enabled = false;
            this.txtHoraHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoraHistorial.Location = new System.Drawing.Point(432, 71);
            this.txtHoraHistorial.Name = "txtHoraHistorial";
            this.txtHoraHistorial.Size = new System.Drawing.Size(74, 23);
            this.txtHoraHistorial.TabIndex = 35;
            // 
            // lblHoraHistorial
            // 
            this.lblHoraHistorial.AutoSize = true;
            this.lblHoraHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraHistorial.Location = new System.Drawing.Point(349, 74);
            this.lblHoraHistorial.Name = "lblHoraHistorial";
            this.lblHoraHistorial.Size = new System.Drawing.Size(79, 17);
            this.lblHoraHistorial.TabIndex = 32;
            this.lblHoraHistorial.Text = "Hora inicio:";
            // 
            // lblEventosPasados
            // 
            this.lblEventosPasados.AutoSize = true;
            this.lblEventosPasados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventosPasados.Location = new System.Drawing.Point(22, 133);
            this.lblEventosPasados.Name = "lblEventosPasados";
            this.lblEventosPasados.Size = new System.Drawing.Size(133, 17);
            this.lblEventosPasados.TabIndex = 41;
            this.lblEventosPasados.Text = "Eventos Pasados";
            // 
            // btnDetHistorial
            // 
            this.btnDetHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetHistorial.Location = new System.Drawing.Point(885, 122);
            this.btnDetHistorial.Name = "btnDetHistorial";
            this.btnDetHistorial.Size = new System.Drawing.Size(95, 29);
            this.btnDetHistorial.TabIndex = 40;
            this.btnDetHistorial.Text = "Ver detalles";
            this.btnDetHistorial.UseVisualStyleBackColor = true;
            this.btnDetHistorial.Click += new System.EventHandler(this.btnDetHistorial_Click);
            // 
            // dvgHistorial
            // 
            this.dvgHistorial.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgHistorial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dvgHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgHistorial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dvgHistorial.EnableHeadersVisualStyles = false;
            this.dvgHistorial.Location = new System.Drawing.Point(22, 157);
            this.dvgHistorial.Name = "dvgHistorial";
            this.dvgHistorial.RowHeadersWidth = 51;
            this.dvgHistorial.Size = new System.Drawing.Size(958, 327);
            this.dvgHistorial.TabIndex = 37;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 400;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Hora Inicio";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 120;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Hora Fin";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 120;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Categoria";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
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
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(595, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(74, 23);
            this.textBox1.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(527, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 43;
            this.label1.Text = "Hora fin:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgHistorial)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabEventos;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnDetInscritos;
        private System.Windows.Forms.Button btnBuscarInscritos;
        private System.Windows.Forms.Label lblEventosInscritos;
        private System.Windows.Forms.DataGridView dvgInscritos;
        private System.Windows.Forms.TextBox txtHoraInscritos;
        private System.Windows.Forms.Label lblFechaInscritos;
        private System.Windows.Forms.Label lblHoraInscritos;
        private System.Windows.Forms.TextBox txtCategoriaInscritos;
        private System.Windows.Forms.Label lblCategoriaInscritos;
        private System.Windows.Forms.TextBox txtNombreInscritos;
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
        private System.Windows.Forms.Button btnAcceder;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblNombreHistorial;
        private System.Windows.Forms.TextBox txtNombreHistorial;
        private System.Windows.Forms.DateTimePicker dtpFechaHistorial;
        private System.Windows.Forms.Label lblCategoríaHistorial;
        private System.Windows.Forms.TextBox txtCategoriaHistorial;
        private System.Windows.Forms.Button btnBuscarHistorial;
        private System.Windows.Forms.Label lblFechaHistorial;
        private System.Windows.Forms.TextBox txtHoraHistorial;
        private System.Windows.Forms.Label lblHoraHistorial;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}