
namespace ProyectoOOIA.Ventanas
{
    partial class frmDetalleCitaAsesor
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
            this.txtHeader = new System.Windows.Forms.Label();
            this.tabDetalleCita = new System.Windows.Forms.TabControl();
            this.tabDatosAlumnos = new System.Windows.Forms.TabPage();
            this.lbNombreAlumno = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblContacto = new System.Windows.Forms.Label();
            this.lbEspecialidad = new System.Windows.Forms.Label();
            this.lbLugarDeNacimiento = new System.Windows.Forms.Label();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.txtLugarNac = new System.Windows.Forms.TextBox();
            this.lbEdad = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtEspecialidad = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtFechaNac = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.tabFichaAtencion = new System.Windows.Forms.TabPage();
            this.pnlScrollFicha = new System.Windows.Forms.Panel();
            this.txtCompromiso = new System.Windows.Forms.TextBox();
            this.lblCompromiso = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.lblAsistencia = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTipoAlumno = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTipoCita = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnDetEventosPrev = new System.Windows.Forms.Button();
            this.btnDetCitasPrev = new System.Windows.Forms.Button();
            this.dvgEventosPasados = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgCitasPasadas = new System.Windows.Forms.DataGridView();
            this.Cita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MiembroOOIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblEventosPrev = new System.Windows.Forms.Label();
            this.lblCitasPrev = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.tabDetalleCita.SuspendLayout();
            this.tabDatosAlumnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabFichaAtencion.SuspendLayout();
            this.pnlScrollFicha.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgEventosPasados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCitasPasadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtHeader
            // 
            this.txtHeader.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeader.ForeColor = System.Drawing.SystemColors.Control;
            this.txtHeader.Location = new System.Drawing.Point(41, 37);
            this.txtHeader.Name = "txtHeader";
            this.txtHeader.Size = new System.Drawing.Size(356, 23);
            this.txtHeader.TabIndex = 0;
            this.txtHeader.Text = " Cita XXXX - 16.05.2021 8:00 am";
            // 
            // tabDetalleCita
            // 
            this.tabDetalleCita.Controls.Add(this.tabDatosAlumnos);
            this.tabDetalleCita.Controls.Add(this.tabFichaAtencion);
            this.tabDetalleCita.Controls.Add(this.tabPage2);
            this.tabDetalleCita.Controls.Add(this.tabPage4);
            this.tabDetalleCita.Font = new System.Drawing.Font("Gill Sans MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDetalleCita.Location = new System.Drawing.Point(0, 77);
            this.tabDetalleCita.Name = "tabDetalleCita";
            this.tabDetalleCita.SelectedIndex = 0;
            this.tabDetalleCita.Size = new System.Drawing.Size(800, 372);
            this.tabDetalleCita.TabIndex = 8;
            // 
            // tabDatosAlumnos
            // 
            this.tabDatosAlumnos.Controls.Add(this.lbNombreAlumno);
            this.tabDatosAlumnos.Controls.Add(this.lblCodigo);
            this.tabDatosAlumnos.Controls.Add(this.pictureBox2);
            this.tabDatosAlumnos.Controls.Add(this.lblContacto);
            this.tabDatosAlumnos.Controls.Add(this.lbEspecialidad);
            this.tabDatosAlumnos.Controls.Add(this.lbLugarDeNacimiento);
            this.tabDatosAlumnos.Controls.Add(this.lblFechaNac);
            this.tabDatosAlumnos.Controls.Add(this.txtLugarNac);
            this.tabDatosAlumnos.Controls.Add(this.lbEdad);
            this.tabDatosAlumnos.Controls.Add(this.lblDireccion);
            this.tabDatosAlumnos.Controls.Add(this.txtDireccion);
            this.tabDatosAlumnos.Controls.Add(this.txtEdad);
            this.tabDatosAlumnos.Controls.Add(this.txtEspecialidad);
            this.tabDatosAlumnos.Controls.Add(this.txtCorreo);
            this.tabDatosAlumnos.Controls.Add(this.txtFechaNac);
            this.tabDatosAlumnos.Controls.Add(this.txtCodigo);
            this.tabDatosAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDatosAlumnos.Location = new System.Drawing.Point(4, 25);
            this.tabDatosAlumnos.Name = "tabDatosAlumnos";
            this.tabDatosAlumnos.Padding = new System.Windows.Forms.Padding(3);
            this.tabDatosAlumnos.Size = new System.Drawing.Size(792, 343);
            this.tabDatosAlumnos.TabIndex = 0;
            this.tabDatosAlumnos.Text = "Datos Alumno";
            this.tabDatosAlumnos.UseVisualStyleBackColor = true;
            // 
            // lbNombreAlumno
            // 
            this.lbNombreAlumno.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreAlumno.Location = new System.Drawing.Point(3, 3);
            this.lbNombreAlumno.Name = "lbNombreAlumno";
            this.lbNombreAlumno.Size = new System.Drawing.Size(294, 38);
            this.lbNombreAlumno.TabIndex = 19;
            this.lbNombreAlumno.Text = "Huertas Hortez, Jose Luis";
            // 
            // lblCodigo
            // 
            this.lblCodigo.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(8, 51);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(135, 23);
            this.lblCodigo.TabIndex = 21;
            this.lblCodigo.Text = "Codigo del alumno";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProyectoOOIA.Properties.Resources.Estudiante;
            this.pictureBox2.Location = new System.Drawing.Point(515, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(234, 221);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // lblContacto
            // 
            this.lblContacto.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContacto.Location = new System.Drawing.Point(8, 81);
            this.lblContacto.Name = "lblContacto";
            this.lblContacto.Size = new System.Drawing.Size(74, 23);
            this.lblContacto.TabIndex = 23;
            this.lblContacto.Text = "Contacto";
            // 
            // lbEspecialidad
            // 
            this.lbEspecialidad.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.lbEspecialidad.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEspecialidad.Location = new System.Drawing.Point(8, 111);
            this.lbEspecialidad.Name = "lbEspecialidad";
            this.lbEspecialidad.Size = new System.Drawing.Size(97, 23);
            this.lbEspecialidad.TabIndex = 25;
            this.lbEspecialidad.Text = "Especialidad";
            // 
            // lbLugarDeNacimiento
            // 
            this.lbLugarDeNacimiento.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLugarDeNacimiento.Location = new System.Drawing.Point(8, 171);
            this.lbLugarDeNacimiento.Name = "lbLugarDeNacimiento";
            this.lbLugarDeNacimiento.Size = new System.Drawing.Size(135, 23);
            this.lbLugarDeNacimiento.TabIndex = 27;
            this.lbLugarDeNacimiento.Text = "Lugar de nacimiento";
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNac.Location = new System.Drawing.Point(8, 141);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(135, 23);
            this.lblFechaNac.TabIndex = 37;
            this.lblFechaNac.Text = "Fecha de nacimiento";
            // 
            // txtLugarNac
            // 
            this.txtLugarNac.Enabled = false;
            this.txtLugarNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLugarNac.Location = new System.Drawing.Point(149, 139);
            this.txtLugarNac.Name = "txtLugarNac";
            this.txtLugarNac.ReadOnly = true;
            this.txtLugarNac.Size = new System.Drawing.Size(208, 24);
            this.txtLugarNac.TabIndex = 38;
            // 
            // lbEdad
            // 
            this.lbEdad.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEdad.Location = new System.Drawing.Point(6, 201);
            this.lbEdad.Name = "lbEdad";
            this.lbEdad.Size = new System.Drawing.Size(82, 23);
            this.lbEdad.TabIndex = 29;
            this.lbEdad.Text = "Edad";
            // 
            // lblDireccion
            // 
            this.lblDireccion.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(8, 231);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(119, 23);
            this.lblDireccion.TabIndex = 33;
            this.lblDireccion.Text = "Direccion";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Enabled = false;
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(149, 229);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.ReadOnly = true;
            this.txtDireccion.Size = new System.Drawing.Size(273, 24);
            this.txtDireccion.TabIndex = 34;
            // 
            // txtEdad
            // 
            this.txtEdad.Enabled = false;
            this.txtEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdad.Location = new System.Drawing.Point(149, 199);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.ReadOnly = true;
            this.txtEdad.Size = new System.Drawing.Size(103, 24);
            this.txtEdad.TabIndex = 30;
            // 
            // txtEspecialidad
            // 
            this.txtEspecialidad.Enabled = false;
            this.txtEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEspecialidad.Location = new System.Drawing.Point(149, 109);
            this.txtEspecialidad.Name = "txtEspecialidad";
            this.txtEspecialidad.ReadOnly = true;
            this.txtEspecialidad.Size = new System.Drawing.Size(208, 24);
            this.txtEspecialidad.TabIndex = 35;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Enabled = false;
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(149, 79);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.ReadOnly = true;
            this.txtCorreo.Size = new System.Drawing.Size(208, 24);
            this.txtCorreo.TabIndex = 36;
            // 
            // txtFechaNac
            // 
            this.txtFechaNac.Enabled = false;
            this.txtFechaNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaNac.Location = new System.Drawing.Point(149, 169);
            this.txtFechaNac.Name = "txtFechaNac";
            this.txtFechaNac.ReadOnly = true;
            this.txtFechaNac.Size = new System.Drawing.Size(208, 24);
            this.txtFechaNac.TabIndex = 28;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(149, 49);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(109, 24);
            this.txtCodigo.TabIndex = 22;
            // 
            // tabFichaAtencion
            // 
            this.tabFichaAtencion.Controls.Add(this.pnlScrollFicha);
            this.tabFichaAtencion.Location = new System.Drawing.Point(4, 25);
            this.tabFichaAtencion.Name = "tabFichaAtencion";
            this.tabFichaAtencion.Padding = new System.Windows.Forms.Padding(3);
            this.tabFichaAtencion.Size = new System.Drawing.Size(792, 343);
            this.tabFichaAtencion.TabIndex = 1;
            this.tabFichaAtencion.Text = "Ficha de atencion";
            this.tabFichaAtencion.UseVisualStyleBackColor = true;
            // 
            // pnlScrollFicha
            // 
            this.pnlScrollFicha.AutoScroll = true;
            this.pnlScrollFicha.AutoScrollMargin = new System.Drawing.Size(0, 15);
            this.pnlScrollFicha.Controls.Add(this.txtCompromiso);
            this.pnlScrollFicha.Controls.Add(this.lblCompromiso);
            this.pnlScrollFicha.Controls.Add(this.radioButton2);
            this.pnlScrollFicha.Controls.Add(this.radioButton1);
            this.pnlScrollFicha.Controls.Add(this.label13);
            this.pnlScrollFicha.Controls.Add(this.textBox6);
            this.pnlScrollFicha.Controls.Add(this.lblAsistencia);
            this.pnlScrollFicha.Controls.Add(this.label6);
            this.pnlScrollFicha.Controls.Add(this.txtMotivo);
            this.pnlScrollFicha.Controls.Add(this.label5);
            this.pnlScrollFicha.Controls.Add(this.txtTipoAlumno);
            this.pnlScrollFicha.Controls.Add(this.label11);
            this.pnlScrollFicha.Controls.Add(this.txtTipoCita);
            this.pnlScrollFicha.Controls.Add(this.label12);
            this.pnlScrollFicha.Location = new System.Drawing.Point(3, 3);
            this.pnlScrollFicha.Name = "pnlScrollFicha";
            this.pnlScrollFicha.Size = new System.Drawing.Size(789, 343);
            this.pnlScrollFicha.TabIndex = 26;
            // 
            // txtCompromiso
            // 
            this.txtCompromiso.Location = new System.Drawing.Point(5, 332);
            this.txtCompromiso.Multiline = true;
            this.txtCompromiso.Name = "txtCompromiso";
            this.txtCompromiso.ReadOnly = true;
            this.txtCompromiso.Size = new System.Drawing.Size(381, 80);
            this.txtCompromiso.TabIndex = 58;
            // 
            // lblCompromiso
            // 
            this.lblCompromiso.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompromiso.Location = new System.Drawing.Point(5, 306);
            this.lblCompromiso.Name = "lblCompromiso";
            this.lblCompromiso.Size = new System.Drawing.Size(167, 23);
            this.lblCompromiso.TabIndex = 57;
            this.lblCompromiso.Text = "Compromiso";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Enabled = false;
            this.radioButton2.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(195, 281);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(48, 25);
            this.radioButton2.TabIndex = 56;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "No";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Enabled = false;
            this.radioButton1.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(137, 281);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(38, 25);
            this.radioButton1.TabIndex = 55;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Sí";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(0, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(294, 34);
            this.label13.TabIndex = 40;
            this.label13.Text = "Huertas Hortez, Jose Luis";
            // 
            // textBox6
            // 
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(5, 127);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(381, 40);
            this.textBox6.TabIndex = 54;
            // 
            // lblAsistencia
            // 
            this.lblAsistencia.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsistencia.Location = new System.Drawing.Point(5, 283);
            this.lblAsistencia.Name = "lblAsistencia";
            this.lblAsistencia.Size = new System.Drawing.Size(112, 23);
            this.lblAsistencia.TabIndex = 52;
            this.lblAsistencia.Text = "Asistencia";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 23);
            this.label6.TabIndex = 49;
            this.label6.Text = "Codigos de atencion";
            // 
            // txtMotivo
            // 
            this.txtMotivo.Enabled = false;
            this.txtMotivo.Location = new System.Drawing.Point(5, 196);
            this.txtMotivo.Multiline = true;
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.ReadOnly = true;
            this.txtMotivo.Size = new System.Drawing.Size(381, 80);
            this.txtMotivo.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 23);
            this.label5.TabIndex = 47;
            this.label5.Text = "Motivo de consulta";
            // 
            // txtTipoAlumno
            // 
            this.txtTipoAlumno.Enabled = false;
            this.txtTipoAlumno.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoAlumno.Location = new System.Drawing.Point(147, 70);
            this.txtTipoAlumno.Name = "txtTipoAlumno";
            this.txtTipoAlumno.ReadOnly = true;
            this.txtTipoAlumno.Size = new System.Drawing.Size(243, 25);
            this.txtTipoAlumno.TabIndex = 44;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(5, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(167, 23);
            this.label11.TabIndex = 43;
            this.label11.Text = "Tipo de alumno";
            // 
            // txtTipoCita
            // 
            this.txtTipoCita.Enabled = false;
            this.txtTipoCita.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoCita.Location = new System.Drawing.Point(147, 40);
            this.txtTipoCita.Name = "txtTipoCita";
            this.txtTipoCita.ReadOnly = true;
            this.txtTipoCita.Size = new System.Drawing.Size(243, 25);
            this.txtTipoCita.TabIndex = 42;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(5, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 23);
            this.label12.TabIndex = 41;
            this.label12.Text = "Tipo de cita";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox16);
            this.tabPage2.Controls.Add(this.label21);
            this.tabPage2.Controls.Add(this.textBox15);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.linkLabel1);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.textBox14);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.textBox13);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 343);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Historia academica";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox16
            // 
            this.textBox16.Enabled = false;
            this.textBox16.Location = new System.Drawing.Point(211, 237);
            this.textBox16.Name = "textBox16";
            this.textBox16.ReadOnly = true;
            this.textBox16.Size = new System.Drawing.Size(111, 20);
            this.textBox16.TabIndex = 52;
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(10, 236);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(167, 23);
            this.label21.TabIndex = 51;
            this.label21.Text = "Promdio Ponderado";
            // 
            // textBox15
            // 
            this.textBox15.Enabled = false;
            this.textBox15.Location = new System.Drawing.Point(211, 211);
            this.textBox15.Name = "textBox15";
            this.textBox15.ReadOnly = true;
            this.textBox15.Size = new System.Drawing.Size(111, 20);
            this.textBox15.TabIndex = 50;
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(10, 211);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(167, 23);
            this.label20.TabIndex = 49;
            this.label20.Text = "Créditos Aprobados";
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(10, 159);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(167, 23);
            this.label19.TabIndex = 48;
            this.label19.Text = "Estadísticas";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(6, 123);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(153, 21);
            this.linkLabel1.TabIndex = 47;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Ver Historia Académica";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(6, 100);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(167, 23);
            this.label18.TabIndex = 46;
            this.label18.Text = "Historia Académica";
            // 
            // textBox14
            // 
            this.textBox14.Enabled = false;
            this.textBox14.Location = new System.Drawing.Point(211, 185);
            this.textBox14.Name = "textBox14";
            this.textBox14.ReadOnly = true;
            this.textBox14.Size = new System.Drawing.Size(111, 20);
            this.textBox14.TabIndex = 45;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(10, 185);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(167, 23);
            this.label17.TabIndex = 44;
            this.label17.Text = "Craest";
            // 
            // textBox13
            // 
            this.textBox13.Enabled = false;
            this.textBox13.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox13.Location = new System.Drawing.Point(8, 62);
            this.textBox13.Name = "textBox13";
            this.textBox13.ReadOnly = true;
            this.textBox13.Size = new System.Drawing.Size(213, 25);
            this.textBox13.TabIndex = 43;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(4, 36);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(167, 23);
            this.label16.TabIndex = 42;
            this.label16.Text = "Estado del Alumno";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(3, 3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(294, 33);
            this.label14.TabIndex = 41;
            this.label14.Text = "Huertas Hortez, Jose Luis";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnDetEventosPrev);
            this.tabPage4.Controls.Add(this.btnDetCitasPrev);
            this.tabPage4.Controls.Add(this.dvgEventosPasados);
            this.tabPage4.Controls.Add(this.dvgCitasPasadas);
            this.tabPage4.Controls.Add(this.lblEventosPrev);
            this.tabPage4.Controls.Add(this.lblCitasPrev);
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(792, 343);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Eventos y citas";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnDetEventosPrev
            // 
            this.btnDetEventosPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetEventosPrev.Location = new System.Drawing.Point(453, 187);
            this.btnDetEventosPrev.Name = "btnDetEventosPrev";
            this.btnDetEventosPrev.Size = new System.Drawing.Size(75, 23);
            this.btnDetEventosPrev.TabIndex = 54;
            this.btnDetEventosPrev.Text = "Detalles";
            this.btnDetEventosPrev.UseVisualStyleBackColor = true;
            this.btnDetEventosPrev.Click += new System.EventHandler(this.btnDetEventosPrev_Click);
            // 
            // btnDetCitasPrev
            // 
            this.btnDetCitasPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetCitasPrev.Location = new System.Drawing.Point(453, 38);
            this.btnDetCitasPrev.Name = "btnDetCitasPrev";
            this.btnDetCitasPrev.Size = new System.Drawing.Size(75, 23);
            this.btnDetCitasPrev.TabIndex = 53;
            this.btnDetCitasPrev.Text = "Detalles";
            this.btnDetCitasPrev.UseVisualStyleBackColor = true;
            this.btnDetCitasPrev.Click += new System.EventHandler(this.btnDetCitasPrev_Click);
            // 
            // dvgEventosPasados
            // 
            this.dvgEventosPasados.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgEventosPasados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvgEventosPasados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgEventosPasados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.Nombre});
            this.dvgEventosPasados.EnableHeadersVisualStyles = false;
            this.dvgEventosPasados.Location = new System.Drawing.Point(8, 216);
            this.dvgEventosPasados.Name = "dvgEventosPasados";
            this.dvgEventosPasados.RowHeadersWidth = 51;
            this.dvgEventosPasados.Size = new System.Drawing.Size(520, 120);
            this.dvgEventosPasados.TabIndex = 52;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha del Evento";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.Width = 160;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre del Evento";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 305;
            // 
            // dvgCitasPasadas
            // 
            this.dvgCitasPasadas.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgCitasPasadas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dvgCitasPasadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgCitasPasadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cita,
            this.MiembroOOIA});
            this.dvgCitasPasadas.EnableHeadersVisualStyles = false;
            this.dvgCitasPasadas.Location = new System.Drawing.Point(8, 67);
            this.dvgCitasPasadas.Name = "dvgCitasPasadas";
            this.dvgCitasPasadas.RowHeadersWidth = 51;
            this.dvgCitasPasadas.Size = new System.Drawing.Size(520, 114);
            this.dvgCitasPasadas.TabIndex = 51;
            // 
            // Cita
            // 
            this.Cita.HeaderText = "Cita";
            this.Cita.MinimumWidth = 6;
            this.Cita.Name = "Cita";
            this.Cita.Width = 180;
            // 
            // MiembroOOIA
            // 
            this.MiembroOOIA.HeaderText = "Tutor/Psicólogo";
            this.MiembroOOIA.MinimumWidth = 6;
            this.MiembroOOIA.Name = "MiembroOOIA";
            this.MiembroOOIA.Width = 285;
            // 
            // lblEventosPrev
            // 
            this.lblEventosPrev.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventosPrev.Location = new System.Drawing.Point(4, 190);
            this.lblEventosPrev.Name = "lblEventosPrev";
            this.lblEventosPrev.Size = new System.Drawing.Size(167, 23);
            this.lblEventosPrev.TabIndex = 50;
            this.lblEventosPrev.Text = "Eventos Previos";
            // 
            // lblCitasPrev
            // 
            this.lblCitasPrev.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCitasPrev.Location = new System.Drawing.Point(3, 41);
            this.lblCitasPrev.Name = "lblCitasPrev";
            this.lblCitasPrev.Size = new System.Drawing.Size(167, 23);
            this.lblCitasPrev.TabIndex = 49;
            this.lblCitasPrev.Text = "Citas Previas";
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(3, 3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(246, 35);
            this.label15.TabIndex = 41;
            this.label15.Text = "Huertas Hortez, Jose Luis";
            // 
            // btnBack
            // 
            this.btnBack.Image = global::ProyectoOOIA.Properties.Resources.arrowWhite;
            this.btnBack.Location = new System.Drawing.Point(11, 35);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(25, 25);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBack.TabIndex = 9;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(71)))), ((int)(((byte)(123)))));
            this.pnlHeader.Controls.Add(this.txtHeader);
            this.pnlHeader.Controls.Add(this.btnBack);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(800, 71);
            this.pnlHeader.TabIndex = 10;
            // 
            // frmDetalleCitaAsesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.tabDetalleCita);
            this.MinimizeBox = false;
            this.Name = "frmDetalleCitaAsesor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ficha de datos alumno";
            this.tabDetalleCita.ResumeLayout(false);
            this.tabDatosAlumnos.ResumeLayout(false);
            this.tabDatosAlumnos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabFichaAtencion.ResumeLayout(false);
            this.pnlScrollFicha.ResumeLayout(false);
            this.pnlScrollFicha.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgEventosPasados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCitasPasadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label txtHeader;
        private System.Windows.Forms.TabControl tabDetalleCita;
        private System.Windows.Forms.TabPage tabDatosAlumnos;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label lbEdad;
        private System.Windows.Forms.TextBox txtFechaNac;
        private System.Windows.Forms.Label lbLugarDeNacimiento;
        private System.Windows.Forms.Label lbEspecialidad;
        private System.Windows.Forms.Label lblContacto;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lbNombreAlumno;
        private System.Windows.Forms.TabPage tabFichaAtencion;
        private System.Windows.Forms.Panel pnlScrollFicha;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label lblAsistencia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTipoAlumno;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTipoCita;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dvgEventosPasados;
        private System.Windows.Forms.DataGridView dvgCitasPasadas;
        private System.Windows.Forms.Label lblEventosPrev;
        private System.Windows.Forms.Label lblCitasPrev;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtEspecialidad;
        private System.Windows.Forms.Button btnDetCitasPrev;
        private System.Windows.Forms.Button btnDetEventosPrev;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.TextBox txtLugarNac;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cita;
        private System.Windows.Forms.DataGridViewTextBoxColumn MiembroOOIA;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox txtCompromiso;
        private System.Windows.Forms.Label lblCompromiso;
    }
}