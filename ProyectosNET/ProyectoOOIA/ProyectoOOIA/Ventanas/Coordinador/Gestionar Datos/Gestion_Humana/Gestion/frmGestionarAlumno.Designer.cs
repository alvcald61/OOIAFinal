
namespace ProyectoOOIA.Ventanas.Miembro_OOIA.Cargar_Datos
{
    partial class frmGestionarAlumno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionarAlumno));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.txtHeader = new System.Windows.Forms.Label();
            this.tsAlumno = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsbModificar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.tsbBuscar = new System.Windows.Forms.ToolStripButton();
            this.tsbCancelar = new System.Windows.Forms.ToolStripButton();
            this.pnlDatosAlumno = new System.Windows.Forms.Panel();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblMiembroPucp = new System.Windows.Forms.Label();
            this.cbEspecialidad = new System.Windows.Forms.ComboBox();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.lblAlumno = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPersona = new System.Windows.Forms.TabPage();
            this.btnImagen1 = new System.Windows.Forms.Button();
            this.pbPerfil1 = new System.Windows.Forms.PictureBox();
            this.pnlDatosPersona = new System.Windows.Forms.Panel();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblPersona = new System.Windows.Forms.Label();
            this.tabAlumno = new System.Windows.Forms.TabPage();
            this.btnImagen2 = new System.Windows.Forms.Button();
            this.pbPerfil2 = new System.Windows.Forms.PictureBox();
            this.ofd_Imagen = new System.Windows.Forms.OpenFileDialog();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.tsAlumno.SuspendLayout();
            this.pnlDatosAlumno.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPersona.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerfil1)).BeginInit();
            this.pnlDatosPersona.SuspendLayout();
            this.tabAlumno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerfil2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(71)))), ((int)(((byte)(123)))));
            this.pnlHeader.Controls.Add(this.btnBack);
            this.pnlHeader.Controls.Add(this.txtHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(744, 76);
            this.pnlHeader.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Image = global::ProyectoOOIA.Properties.Resources.arrowWhite;
            this.btnBack.Location = new System.Drawing.Point(26, 28);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(25, 25);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBack.TabIndex = 3;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtHeader
            // 
            this.txtHeader.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeader.ForeColor = System.Drawing.SystemColors.Control;
            this.txtHeader.Location = new System.Drawing.Point(66, 28);
            this.txtHeader.Name = "txtHeader";
            this.txtHeader.Size = new System.Drawing.Size(238, 35);
            this.txtHeader.TabIndex = 2;
            this.txtHeader.Text = "Gestionar Alumnos";
            // 
            // tsAlumno
            // 
            this.tsAlumno.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsAlumno.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbGuardar,
            this.tsbModificar,
            this.tsbEliminar,
            this.tsbBuscar,
            this.tsbCancelar});
            this.tsAlumno.Location = new System.Drawing.Point(0, 76);
            this.tsAlumno.Name = "tsAlumno";
            this.tsAlumno.Size = new System.Drawing.Size(744, 27);
            this.tsAlumno.TabIndex = 2;
            this.tsAlumno.Text = "tsAlumno";
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNuevo.Image")));
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(66, 24);
            this.tsbNuevo.Text = "Nuevo";
            this.tsbNuevo.ToolTipText = "Nuevo";
            this.tsbNuevo.Click += new System.EventHandler(this.tsbNuevo_Click);
            // 
            // tsbGuardar
            // 
            this.tsbGuardar.Image = ((System.Drawing.Image)(resources.GetObject("tsbGuardar.Image")));
            this.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGuardar.Name = "tsbGuardar";
            this.tsbGuardar.Size = new System.Drawing.Size(73, 24);
            this.tsbGuardar.Text = "Guardar";
            this.tsbGuardar.Click += new System.EventHandler(this.tsbGuardar_Click_1);
            // 
            // tsbModificar
            // 
            this.tsbModificar.Image = ((System.Drawing.Image)(resources.GetObject("tsbModificar.Image")));
            this.tsbModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModificar.Name = "tsbModificar";
            this.tsbModificar.Size = new System.Drawing.Size(82, 24);
            this.tsbModificar.Text = "Modificar";
            this.tsbModificar.Click += new System.EventHandler(this.tsbModificar_Click);
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEliminar.Image")));
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(74, 24);
            this.tsbEliminar.Text = "Eliminar";
            this.tsbEliminar.Click += new System.EventHandler(this.tsbEliminar_Click);
            // 
            // tsbBuscar
            // 
            this.tsbBuscar.Image = ((System.Drawing.Image)(resources.GetObject("tsbBuscar.Image")));
            this.tsbBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBuscar.Name = "tsbBuscar";
            this.tsbBuscar.Size = new System.Drawing.Size(66, 24);
            this.tsbBuscar.Text = "Buscar";
            this.tsbBuscar.Click += new System.EventHandler(this.tsbBuscar_Click);
            // 
            // tsbCancelar
            // 
            this.tsbCancelar.Image = ((System.Drawing.Image)(resources.GetObject("tsbCancelar.Image")));
            this.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancelar.Name = "tsbCancelar";
            this.tsbCancelar.Size = new System.Drawing.Size(77, 24);
            this.tsbCancelar.Text = "Cancelar";
            this.tsbCancelar.Click += new System.EventHandler(this.tsbCancelar_Click);
            // 
            // pnlDatosAlumno
            // 
            this.pnlDatosAlumno.Controls.Add(this.txtUsuario);
            this.pnlDatosAlumno.Controls.Add(this.txtPassword);
            this.pnlDatosAlumno.Controls.Add(this.lblPassword);
            this.pnlDatosAlumno.Controls.Add(this.lblUsuario);
            this.pnlDatosAlumno.Controls.Add(this.lblMiembroPucp);
            this.pnlDatosAlumno.Controls.Add(this.cbEspecialidad);
            this.pnlDatosAlumno.Controls.Add(this.lblEspecialidad);
            this.pnlDatosAlumno.Controls.Add(this.lblAlumno);
            this.pnlDatosAlumno.Controls.Add(this.txtCodigo);
            this.pnlDatosAlumno.Controls.Add(this.lblCodigo);
            this.pnlDatosAlumno.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlDatosAlumno.Location = new System.Drawing.Point(3, 3);
            this.pnlDatosAlumno.Name = "pnlDatosAlumno";
            this.pnlDatosAlumno.Size = new System.Drawing.Size(522, 246);
            this.pnlDatosAlumno.TabIndex = 3;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(152, 30);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(145, 20);
            this.txtUsuario.TabIndex = 13;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(152, 56);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(145, 20);
            this.txtPassword.TabIndex = 12;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(6, 56);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(81, 21);
            this.lblPassword.TabIndex = 10;
            this.lblPassword.Text = "Contraseña";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(6, 27);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(58, 21);
            this.lblUsuario.TabIndex = 9;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblMiembroPucp
            // 
            this.lblMiembroPucp.AutoSize = true;
            this.lblMiembroPucp.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiembroPucp.Location = new System.Drawing.Point(3, 0);
            this.lblMiembroPucp.Name = "lblMiembroPucp";
            this.lblMiembroPucp.Size = new System.Drawing.Size(236, 27);
            this.lblMiembroPucp.TabIndex = 7;
            this.lblMiembroPucp.Text = "Datos de Miembro PUCP";
            // 
            // cbEspecialidad
            // 
            this.cbEspecialidad.FormattingEnabled = true;
            this.cbEspecialidad.Location = new System.Drawing.Point(152, 155);
            this.cbEspecialidad.Name = "cbEspecialidad";
            this.cbEspecialidad.Size = new System.Drawing.Size(179, 21);
            this.cbEspecialidad.TabIndex = 6;
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecialidad.Location = new System.Drawing.Point(6, 153);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(83, 21);
            this.lblEspecialidad.TabIndex = 5;
            this.lblEspecialidad.Text = "Especialidad";
            // 
            // lblAlumno
            // 
            this.lblAlumno.AutoSize = true;
            this.lblAlumno.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlumno.Location = new System.Drawing.Point(3, 99);
            this.lblAlumno.Name = "lblAlumno";
            this.lblAlumno.Size = new System.Drawing.Size(171, 27);
            this.lblAlumno.TabIndex = 4;
            this.lblAlumno.Text = "Datos del Alumno";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(152, 129);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 3;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(3, 126);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(96, 21);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "Codigo PUCP";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPersona);
            this.tabControl.Controls.Add(this.tabAlumno);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl.Location = new System.Drawing.Point(0, 103);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(744, 278);
            this.tabControl.TabIndex = 4;
            // 
            // tabPersona
            // 
            this.tabPersona.Controls.Add(this.btnImagen1);
            this.tabPersona.Controls.Add(this.pbPerfil1);
            this.tabPersona.Controls.Add(this.pnlDatosPersona);
            this.tabPersona.Location = new System.Drawing.Point(4, 22);
            this.tabPersona.Name = "tabPersona";
            this.tabPersona.Padding = new System.Windows.Forms.Padding(3);
            this.tabPersona.Size = new System.Drawing.Size(736, 252);
            this.tabPersona.TabIndex = 1;
            this.tabPersona.Text = "Datos Persona";
            this.tabPersona.UseVisualStyleBackColor = true;
            // 
            // btnImagen1
            // 
            this.btnImagen1.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImagen1.Location = new System.Drawing.Point(564, 214);
            this.btnImagen1.Name = "btnImagen1";
            this.btnImagen1.Size = new System.Drawing.Size(139, 32);
            this.btnImagen1.TabIndex = 11;
            this.btnImagen1.Text = "Seleccionar Imagen";
            this.btnImagen1.UseVisualStyleBackColor = true;
            this.btnImagen1.Click += new System.EventHandler(this.btnImagen_Click);
            // 
            // pbPerfil1
            // 
            this.pbPerfil1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPerfil1.Location = new System.Drawing.Point(531, 6);
            this.pbPerfil1.Name = "pbPerfil1";
            this.pbPerfil1.Size = new System.Drawing.Size(196, 202);
            this.pbPerfil1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPerfil1.TabIndex = 10;
            this.pbPerfil1.TabStop = false;
            // 
            // pnlDatosPersona
            // 
            this.pnlDatosPersona.Controls.Add(this.dtpFechaNacimiento);
            this.pnlDatosPersona.Controls.Add(this.txtCorreo);
            this.pnlDatosPersona.Controls.Add(this.lblCorreo);
            this.pnlDatosPersona.Controls.Add(this.txtDireccion);
            this.pnlDatosPersona.Controls.Add(this.lblDireccion);
            this.pnlDatosPersona.Controls.Add(this.lblFechaNacimiento);
            this.pnlDatosPersona.Controls.Add(this.txtNombre);
            this.pnlDatosPersona.Controls.Add(this.lblNombre);
            this.pnlDatosPersona.Controls.Add(this.txtDni);
            this.pnlDatosPersona.Controls.Add(this.lblDni);
            this.pnlDatosPersona.Controls.Add(this.lblPersona);
            this.pnlDatosPersona.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlDatosPersona.Location = new System.Drawing.Point(3, 3);
            this.pnlDatosPersona.Name = "pnlDatosPersona";
            this.pnlDatosPersona.Size = new System.Drawing.Size(522, 246);
            this.pnlDatosPersona.TabIndex = 9;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(151, 82);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(89, 20);
            this.dtpFechaNacimiento.TabIndex = 22;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(151, 134);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(271, 20);
            this.txtCorreo.TabIndex = 21;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(7, 132);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(56, 21);
            this.lblCorreo.TabIndex = 20;
            this.lblCorreo.Text = "Correo";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(151, 108);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(271, 20);
            this.txtDireccion.TabIndex = 19;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(7, 106);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(70, 21);
            this.lblDireccion.TabIndex = 18;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNacimiento.Location = new System.Drawing.Point(7, 83);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(138, 21);
            this.lblFechaNacimiento.TabIndex = 16;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(151, 55);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(271, 20);
            this.txtNombre.TabIndex = 15;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(7, 53);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(127, 21);
            this.lblNombre.TabIndex = 14;
            this.lblNombre.Text = "Nombre Completo";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(151, 29);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 20);
            this.txtDni.TabIndex = 13;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.Location = new System.Drawing.Point(7, 27);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(37, 21);
            this.lblDni.TabIndex = 10;
            this.lblDni.Text = "DNI";
            // 
            // lblPersona
            // 
            this.lblPersona.AutoSize = true;
            this.lblPersona.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersona.Location = new System.Drawing.Point(3, 0);
            this.lblPersona.Name = "lblPersona";
            this.lblPersona.Size = new System.Drawing.Size(166, 27);
            this.lblPersona.TabIndex = 8;
            this.lblPersona.Text = "Datos de Persona";
            // 
            // tabAlumno
            // 
            this.tabAlumno.Controls.Add(this.btnImagen2);
            this.tabAlumno.Controls.Add(this.pbPerfil2);
            this.tabAlumno.Controls.Add(this.pnlDatosAlumno);
            this.tabAlumno.Location = new System.Drawing.Point(4, 22);
            this.tabAlumno.Name = "tabAlumno";
            this.tabAlumno.Padding = new System.Windows.Forms.Padding(3);
            this.tabAlumno.Size = new System.Drawing.Size(736, 252);
            this.tabAlumno.TabIndex = 0;
            this.tabAlumno.Text = "Datos Alumno";
            this.tabAlumno.UseVisualStyleBackColor = true;
            // 
            // btnImagen2
            // 
            this.btnImagen2.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImagen2.Location = new System.Drawing.Point(564, 214);
            this.btnImagen2.Name = "btnImagen2";
            this.btnImagen2.Size = new System.Drawing.Size(139, 32);
            this.btnImagen2.TabIndex = 12;
            this.btnImagen2.Text = "Seleccionar Imagen";
            this.btnImagen2.UseVisualStyleBackColor = true;
            this.btnImagen2.Click += new System.EventHandler(this.btnImagen_Click);
            // 
            // pbPerfil2
            // 
            this.pbPerfil2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPerfil2.Location = new System.Drawing.Point(531, 6);
            this.pbPerfil2.Name = "pbPerfil2";
            this.pbPerfil2.Size = new System.Drawing.Size(196, 202);
            this.pbPerfil2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPerfil2.TabIndex = 11;
            this.pbPerfil2.TabStop = false;
            // 
            // ofd_Imagen
            // 
            this.ofd_Imagen.FileName = "Alumno_Perfil";
            // 
            // frmGestionarAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 401);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.tsAlumno);
            this.Controls.Add(this.pnlHeader);
            this.Name = "frmGestionarAlumno";
            this.Text = "Cargar Alumno";
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.tsAlumno.ResumeLayout(false);
            this.tsAlumno.PerformLayout();
            this.pnlDatosAlumno.ResumeLayout(false);
            this.pnlDatosAlumno.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPersona.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPerfil1)).EndInit();
            this.pnlDatosPersona.ResumeLayout(false);
            this.pnlDatosPersona.PerformLayout();
            this.tabAlumno.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPerfil2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.Label txtHeader;
        private System.Windows.Forms.ToolStrip tsAlumno;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.ToolStripButton tsbModificar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.ToolStripButton tsbBuscar;
        private System.Windows.Forms.ToolStripButton tsbCancelar;
        private System.Windows.Forms.Panel pnlDatosAlumno;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ComboBox cbEspecialidad;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.Label lblAlumno;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPersona;
        private System.Windows.Forms.Panel pnlDatosPersona;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblPersona;
        private System.Windows.Forms.TabPage tabAlumno;
        private System.Windows.Forms.OpenFileDialog ofd_Imagen;
        private System.Windows.Forms.Label lblMiembroPucp;
        private System.Windows.Forms.Button btnImagen1;
        private System.Windows.Forms.PictureBox pbPerfil1;
        private System.Windows.Forms.PictureBox pbPerfil2;
        private System.Windows.Forms.Button btnImagen2;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
    }
}