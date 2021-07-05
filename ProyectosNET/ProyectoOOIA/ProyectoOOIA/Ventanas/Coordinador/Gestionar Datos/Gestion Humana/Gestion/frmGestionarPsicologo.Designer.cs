
namespace ProyectoOOIA.Ventanas.Miembro_OOIA.Cargar_Datos
{
    partial class frmGestionarPsicologo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionarPsicologo));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.txtHeader = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsbModificar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.tsbBuscar = new System.Windows.Forms.ToolStripButton();
            this.tsbCancelar = new System.Windows.Forms.ToolStripButton();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPersona = new System.Windows.Forms.TabPage();
            this.btnImagen1 = new System.Windows.Forms.Button();
            this.pbPerfil1 = new System.Windows.Forms.PictureBox();
            this.pnlPersona = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
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
            this.tabPsico = new System.Windows.Forms.TabPage();
            this.btnImagen2 = new System.Windows.Forms.Button();
            this.pbPerfil2 = new System.Windows.Forms.PictureBox();
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.lblPag2 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblMiembroPucp = new System.Windows.Forms.Label();
            this.lblPsico = new System.Windows.Forms.Label();
            this.lblRama = new System.Windows.Forms.Label();
            this.txtRama = new System.Windows.Forms.TextBox();
            this.ofd_Imagen = new System.Windows.Forms.OpenFileDialog();
            this.ttContra = new System.Windows.Forms.ToolTip(this.components);
            this.lblCampo1 = new System.Windows.Forms.Label();
            this.lblCampo2 = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPersona.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerfil1)).BeginInit();
            this.pnlPersona.SuspendLayout();
            this.tabPsico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerfil2)).BeginInit();
            this.pnlDatos.SuspendLayout();
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
            this.pnlHeader.Size = new System.Drawing.Size(744, 70);
            this.pnlHeader.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Image = global::ProyectoOOIA.Properties.Resources.arrowWhite;
            this.btnBack.Location = new System.Drawing.Point(16, 28);
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
            this.txtHeader.Location = new System.Drawing.Point(60, 28);
            this.txtHeader.Name = "txtHeader";
            this.txtHeader.Size = new System.Drawing.Size(238, 35);
            this.txtHeader.TabIndex = 2;
            this.txtHeader.Text = "Gestionar Psicologos";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbGuardar,
            this.tsbModificar,
            this.tsbEliminar,
            this.tsbBuscar,
            this.tsbCancelar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 70);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(744, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.Image = global::ProyectoOOIA.Properties.Resources.btnNuevo_Image;
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(62, 22);
            this.tsbNuevo.Text = "Nuevo";
            this.tsbNuevo.ToolTipText = "Nuevo";
            this.tsbNuevo.Click += new System.EventHandler(this.tsbNuevo_Click);
            // 
            // tsbGuardar
            // 
            this.tsbGuardar.Image = global::ProyectoOOIA.Properties.Resources.btnGuardar_Image;
            this.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGuardar.Name = "tsbGuardar";
            this.tsbGuardar.Size = new System.Drawing.Size(69, 22);
            this.tsbGuardar.Text = "Guardar";
            this.tsbGuardar.Click += new System.EventHandler(this.tsbGuardar_Click_1);
            // 
            // tsbModificar
            // 
            this.tsbModificar.Image = ((System.Drawing.Image)(resources.GetObject("tsbModificar.Image")));
            this.tsbModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModificar.Name = "tsbModificar";
            this.tsbModificar.Size = new System.Drawing.Size(78, 22);
            this.tsbModificar.Text = "Modificar";
            this.tsbModificar.Click += new System.EventHandler(this.tsbModificar_Click);
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.Image = global::ProyectoOOIA.Properties.Resources.Eraser_16x;
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(70, 22);
            this.tsbEliminar.Text = "Eliminar";
            this.tsbEliminar.Click += new System.EventHandler(this.tsbEliminar_Click);
            // 
            // tsbBuscar
            // 
            this.tsbBuscar.Image = global::ProyectoOOIA.Properties.Resources.Search_noHalo_16x;
            this.tsbBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBuscar.Name = "tsbBuscar";
            this.tsbBuscar.Size = new System.Drawing.Size(62, 22);
            this.tsbBuscar.Text = "Buscar";
            this.tsbBuscar.Click += new System.EventHandler(this.tsbBuscar_Click);
            // 
            // tsbCancelar
            // 
            this.tsbCancelar.Image = global::ProyectoOOIA.Properties.Resources.Cancel_16x;
            this.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancelar.Name = "tsbCancelar";
            this.tsbCancelar.Size = new System.Drawing.Size(73, 22);
            this.tsbCancelar.Text = "Cancelar";
            this.tsbCancelar.Click += new System.EventHandler(this.tsbCancelar_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPersona);
            this.tabControl.Controls.Add(this.tabPsico);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(0, 95);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(744, 283);
            this.tabControl.TabIndex = 4;
            // 
            // tabPersona
            // 
            this.tabPersona.Controls.Add(this.btnImagen1);
            this.tabPersona.Controls.Add(this.pbPerfil1);
            this.tabPersona.Controls.Add(this.pnlPersona);
            this.tabPersona.Location = new System.Drawing.Point(4, 27);
            this.tabPersona.Name = "tabPersona";
            this.tabPersona.Padding = new System.Windows.Forms.Padding(3);
            this.tabPersona.Size = new System.Drawing.Size(736, 252);
            this.tabPersona.TabIndex = 1;
            this.tabPersona.Text = "Información Personal";
            this.tabPersona.UseVisualStyleBackColor = true;
            // 
            // btnImagen1
            // 
            this.btnImagen1.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImagen1.Location = new System.Drawing.Point(562, 214);
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
            // pnlPersona
            // 
            this.pnlPersona.Controls.Add(this.lblCampo1);
            this.pnlPersona.Controls.Add(this.label1);
            this.pnlPersona.Controls.Add(this.dtpFechaNacimiento);
            this.pnlPersona.Controls.Add(this.txtCorreo);
            this.pnlPersona.Controls.Add(this.lblCorreo);
            this.pnlPersona.Controls.Add(this.txtDireccion);
            this.pnlPersona.Controls.Add(this.lblDireccion);
            this.pnlPersona.Controls.Add(this.lblFechaNacimiento);
            this.pnlPersona.Controls.Add(this.txtNombre);
            this.pnlPersona.Controls.Add(this.lblNombre);
            this.pnlPersona.Controls.Add(this.txtDni);
            this.pnlPersona.Controls.Add(this.lblDni);
            this.pnlPersona.Controls.Add(this.lblPersona);
            this.pnlPersona.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlPersona.Location = new System.Drawing.Point(3, 3);
            this.pnlPersona.Name = "pnlPersona";
            this.pnlPersona.Size = new System.Drawing.Size(522, 246);
            this.pnlPersona.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(429, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 26;
            this.label1.Text = "Página 1 de 2";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(160, 91);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(89, 23);
            this.dtpFechaNacimiento.TabIndex = 23;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(160, 149);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(271, 23);
            this.txtCorreo.TabIndex = 21;
            this.txtCorreo.Enter += new System.EventHandler(this.txt_Enter);
            this.txtCorreo.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(3, 150);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(66, 21);
            this.lblCorreo.TabIndex = 20;
            this.lblCorreo.Text = "Correo *";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(160, 120);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(271, 23);
            this.txtDireccion.TabIndex = 19;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(3, 121);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(70, 21);
            this.lblDireccion.TabIndex = 18;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNacimiento.Location = new System.Drawing.Point(3, 93);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(148, 21);
            this.lblFechaNacimiento.TabIndex = 16;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento *";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(160, 62);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(271, 23);
            this.txtNombre.TabIndex = 15;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(3, 63);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(137, 21);
            this.lblNombre.TabIndex = 14;
            this.lblNombre.Text = "Nombre Completo *";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(160, 33);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 23);
            this.txtDni.TabIndex = 13;
            this.txtDni.Enter += new System.EventHandler(this.txt_Enter);
            this.txtDni.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.Location = new System.Drawing.Point(3, 34);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(47, 21);
            this.lblDni.TabIndex = 10;
            this.lblDni.Text = "DNI *";
            // 
            // lblPersona
            // 
            this.lblPersona.AutoSize = true;
            this.lblPersona.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersona.Location = new System.Drawing.Point(3, 3);
            this.lblPersona.Name = "lblPersona";
            this.lblPersona.Size = new System.Drawing.Size(201, 27);
            this.lblPersona.TabIndex = 8;
            this.lblPersona.Text = "Información Personal";
            // 
            // tabPsico
            // 
            this.tabPsico.Controls.Add(this.btnImagen2);
            this.tabPsico.Controls.Add(this.pbPerfil2);
            this.tabPsico.Controls.Add(this.pnlDatos);
            this.tabPsico.Location = new System.Drawing.Point(4, 27);
            this.tabPsico.Name = "tabPsico";
            this.tabPsico.Padding = new System.Windows.Forms.Padding(3);
            this.tabPsico.Size = new System.Drawing.Size(736, 252);
            this.tabPsico.TabIndex = 0;
            this.tabPsico.Text = "Información Usuario";
            this.tabPsico.UseVisualStyleBackColor = true;
            // 
            // btnImagen2
            // 
            this.btnImagen2.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImagen2.Location = new System.Drawing.Point(562, 214);
            this.btnImagen2.Name = "btnImagen2";
            this.btnImagen2.Size = new System.Drawing.Size(139, 32);
            this.btnImagen2.TabIndex = 5;
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
            this.pbPerfil2.TabIndex = 4;
            this.pbPerfil2.TabStop = false;
            // 
            // pnlDatos
            // 
            this.pnlDatos.Controls.Add(this.lblCampo2);
            this.pnlDatos.Controls.Add(this.lblPag2);
            this.pnlDatos.Controls.Add(this.txtUsuario);
            this.pnlDatos.Controls.Add(this.txtPassword);
            this.pnlDatos.Controls.Add(this.lblPassword);
            this.pnlDatos.Controls.Add(this.lblUsuario);
            this.pnlDatos.Controls.Add(this.lblMiembroPucp);
            this.pnlDatos.Controls.Add(this.lblPsico);
            this.pnlDatos.Controls.Add(this.lblRama);
            this.pnlDatos.Controls.Add(this.txtRama);
            this.pnlDatos.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlDatos.Location = new System.Drawing.Point(3, 3);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(522, 246);
            this.pnlDatos.TabIndex = 3;
            // 
            // lblPag2
            // 
            this.lblPag2.AutoSize = true;
            this.lblPag2.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPag2.Location = new System.Drawing.Point(429, 217);
            this.lblPag2.Name = "lblPag2";
            this.lblPag2.Size = new System.Drawing.Size(90, 21);
            this.lblPag2.TabIndex = 17;
            this.lblPag2.Text = "Página 2 de 2";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(160, 33);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(150, 23);
            this.txtUsuario.TabIndex = 13;
            this.txtUsuario.Enter += new System.EventHandler(this.txt_Enter);
            this.txtUsuario.MouseHover += new System.EventHandler(this.txt_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(160, 62);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(150, 23);
            this.txtPassword.TabIndex = 12;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(3, 63);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(91, 21);
            this.lblPassword.TabIndex = 10;
            this.lblPassword.Text = "Contraseña *";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(3, 34);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(68, 21);
            this.lblUsuario.TabIndex = 9;
            this.lblUsuario.Text = "Usuario *";
            // 
            // lblMiembroPucp
            // 
            this.lblMiembroPucp.AutoSize = true;
            this.lblMiembroPucp.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiembroPucp.Location = new System.Drawing.Point(3, 3);
            this.lblMiembroPucp.Name = "lblMiembroPucp";
            this.lblMiembroPucp.Size = new System.Drawing.Size(165, 27);
            this.lblMiembroPucp.TabIndex = 7;
            this.lblMiembroPucp.Text = "Datos de Usuario";
            // 
            // lblPsico
            // 
            this.lblPsico.AutoSize = true;
            this.lblPsico.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPsico.Location = new System.Drawing.Point(3, 88);
            this.lblPsico.Name = "lblPsico";
            this.lblPsico.Size = new System.Drawing.Size(178, 27);
            this.lblPsico.TabIndex = 4;
            this.lblPsico.Text = "Datos de Psicologo";
            // 
            // lblRama
            // 
            this.lblRama.AutoSize = true;
            this.lblRama.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRama.Location = new System.Drawing.Point(3, 119);
            this.lblRama.Name = "lblRama";
            this.lblRama.Size = new System.Drawing.Size(52, 21);
            this.lblRama.TabIndex = 1;
            this.lblRama.Text = "Rama *";
            // 
            // txtRama
            // 
            this.txtRama.Location = new System.Drawing.Point(160, 118);
            this.txtRama.Name = "txtRama";
            this.txtRama.Size = new System.Drawing.Size(200, 23);
            this.txtRama.TabIndex = 0;
            // 
            // ofd_Imagen
            // 
            this.ofd_Imagen.FileName = "Alumno_Perfil";
            // 
            // ttContra
            // 
            this.ttContra.AutomaticDelay = 100;
            this.ttContra.AutoPopDelay = 2000;
            this.ttContra.InitialDelay = 100;
            this.ttContra.IsBalloon = true;
            this.ttContra.ReshowDelay = 20;
            this.ttContra.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttContra.ToolTipTitle = "Consejo";
            // 
            // lblCampo1
            // 
            this.lblCampo1.AutoSize = true;
            this.lblCampo1.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampo1.Location = new System.Drawing.Point(3, 217);
            this.lblCampo1.Name = "lblCampo1";
            this.lblCampo1.Size = new System.Drawing.Size(144, 21);
            this.lblCampo1.TabIndex = 27;
            this.lblCampo1.Text = "* Campos obligatorios";
            // 
            // lblCampo2
            // 
            this.lblCampo2.AutoSize = true;
            this.lblCampo2.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampo2.Location = new System.Drawing.Point(3, 217);
            this.lblCampo2.Name = "lblCampo2";
            this.lblCampo2.Size = new System.Drawing.Size(144, 21);
            this.lblCampo2.TabIndex = 27;
            this.lblCampo2.Text = "* Campos obligatorios";
            // 
            // frmGestionarPsicologo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 401);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pnlHeader);
            this.Name = "frmGestionarPsicologo";
            this.Text = "Gestionar Psicologos";
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPersona.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPerfil1)).EndInit();
            this.pnlPersona.ResumeLayout(false);
            this.pnlPersona.PerformLayout();
            this.tabPsico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPerfil2)).EndInit();
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.Label txtHeader;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.ToolStripButton tsbModificar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.ToolStripButton tsbBuscar;
        private System.Windows.Forms.ToolStripButton tsbCancelar;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPersona;
        private System.Windows.Forms.Panel pnlPersona;
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
        private System.Windows.Forms.TabPage tabPsico;
        private System.Windows.Forms.Button btnImagen2;
        private System.Windows.Forms.PictureBox pbPerfil2;
        private System.Windows.Forms.OpenFileDialog ofd_Imagen;
        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblMiembroPucp;
        private System.Windows.Forms.Label lblPsico;
        private System.Windows.Forms.Label lblRama;
        private System.Windows.Forms.TextBox txtRama;
        private System.Windows.Forms.Button btnImagen1;
        private System.Windows.Forms.PictureBox pbPerfil1;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label lblPag2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip ttContra;
        private System.Windows.Forms.Label lblCampo1;
        private System.Windows.Forms.Label lblCampo2;
    }
}