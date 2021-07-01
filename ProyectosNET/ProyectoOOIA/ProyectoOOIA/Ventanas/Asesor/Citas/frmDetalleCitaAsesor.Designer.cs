
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtHeader = new System.Windows.Forms.Label();
            this.tabDetalleCita = new System.Windows.Forms.TabControl();
            this.tabDatosAlumnos = new System.Windows.Forms.TabPage();
            this.lbNombreAlumno = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.pImageAlumno = new System.Windows.Forms.PictureBox();
            this.lbEspecialidad = new System.Windows.Forms.Label();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.txtFechaNac = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtEspecialidad = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.tabFichaAtencion = new System.Windows.Forms.TabPage();
            this.pnlScrollFicha = new System.Windows.Forms.Panel();
            this.cbCodigoAtencion = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtCompromiso = new System.Windows.Forms.TextBox();
            this.lblCompromiso = new System.Windows.Forms.Label();
            this.rbNoAsistio = new System.Windows.Forms.RadioButton();
            this.rbAsistio = new System.Windows.Forms.RadioButton();
            this.lbNombre_ficha = new System.Windows.Forms.Label();
            this.lblAsistencia = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnDetEventosPrev = new System.Windows.Forms.Button();
            this.btnDetCitasPrev = new System.Windows.Forms.Button();
            this.dvgEventosPasados = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgCitasPasadas = new System.Windows.Forms.DataGridView();
            this.FechaCita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MiembroOOIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblEventosPrev = new System.Windows.Forms.Label();
            this.lblCitasPrev = new System.Windows.Forms.Label();
            this.lbNombre_eventos_cita = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.tabDetalleCita.SuspendLayout();
            this.tabDatosAlumnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pImageAlumno)).BeginInit();
            this.tabFichaAtencion.SuspendLayout();
            this.pnlScrollFicha.SuspendLayout();
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
            this.txtHeader.Location = new System.Drawing.Point(55, 46);
            this.txtHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtHeader.Name = "txtHeader";
            this.txtHeader.Size = new System.Drawing.Size(475, 28);
            this.txtHeader.TabIndex = 0;
            this.txtHeader.Text = " Cita XXXX - 16.05.2021 8:00 am";
            // 
            // tabDetalleCita
            // 
            this.tabDetalleCita.Controls.Add(this.tabDatosAlumnos);
            this.tabDetalleCita.Controls.Add(this.tabFichaAtencion);
            this.tabDetalleCita.Controls.Add(this.tabPage4);
            this.tabDetalleCita.Font = new System.Drawing.Font("Gill Sans MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDetalleCita.Location = new System.Drawing.Point(0, 95);
            this.tabDetalleCita.Margin = new System.Windows.Forms.Padding(4);
            this.tabDetalleCita.Name = "tabDetalleCita";
            this.tabDetalleCita.SelectedIndex = 0;
            this.tabDetalleCita.Size = new System.Drawing.Size(1067, 458);
            this.tabDetalleCita.TabIndex = 8;
            // 
            // tabDatosAlumnos
            // 
            this.tabDatosAlumnos.Controls.Add(this.lbNombreAlumno);
            this.tabDatosAlumnos.Controls.Add(this.lblCodigo);
            this.tabDatosAlumnos.Controls.Add(this.pImageAlumno);
            this.tabDatosAlumnos.Controls.Add(this.lbEspecialidad);
            this.tabDatosAlumnos.Controls.Add(this.lblFechaNac);
            this.tabDatosAlumnos.Controls.Add(this.txtFechaNac);
            this.tabDatosAlumnos.Controls.Add(this.lblDireccion);
            this.tabDatosAlumnos.Controls.Add(this.txtDireccion);
            this.tabDatosAlumnos.Controls.Add(this.txtEspecialidad);
            this.tabDatosAlumnos.Controls.Add(this.txtCodigo);
            this.tabDatosAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDatosAlumnos.Location = new System.Drawing.Point(4, 30);
            this.tabDatosAlumnos.Margin = new System.Windows.Forms.Padding(4);
            this.tabDatosAlumnos.Name = "tabDatosAlumnos";
            this.tabDatosAlumnos.Padding = new System.Windows.Forms.Padding(4);
            this.tabDatosAlumnos.Size = new System.Drawing.Size(1059, 424);
            this.tabDatosAlumnos.TabIndex = 0;
            this.tabDatosAlumnos.Text = "Datos Alumno";
            this.tabDatosAlumnos.UseVisualStyleBackColor = true;
            // 
            // lbNombreAlumno
            // 
            this.lbNombreAlumno.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreAlumno.Location = new System.Drawing.Point(9, 16);
            this.lbNombreAlumno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNombreAlumno.Name = "lbNombreAlumno";
            this.lbNombreAlumno.Size = new System.Drawing.Size(392, 47);
            this.lbNombreAlumno.TabIndex = 19;
            this.lbNombreAlumno.Text = "Huertas Hortez, Jose Luis";
            // 
            // lblCodigo
            // 
            this.lblCodigo.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(11, 79);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(180, 28);
            this.lblCodigo.TabIndex = 21;
            this.lblCodigo.Text = "Codigo del alumno";
            // 
            // pImageAlumno
            // 
            this.pImageAlumno.Image = global::ProyectoOOIA.Properties.Resources.Estudiante;
            this.pImageAlumno.Location = new System.Drawing.Point(687, 39);
            this.pImageAlumno.Margin = new System.Windows.Forms.Padding(4);
            this.pImageAlumno.Name = "pImageAlumno";
            this.pImageAlumno.Size = new System.Drawing.Size(312, 272);
            this.pImageAlumno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pImageAlumno.TabIndex = 31;
            this.pImageAlumno.TabStop = false;
            // 
            // lbEspecialidad
            // 
            this.lbEspecialidad.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.lbEspecialidad.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEspecialidad.Location = new System.Drawing.Point(11, 122);
            this.lbEspecialidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEspecialidad.Name = "lbEspecialidad";
            this.lbEspecialidad.Size = new System.Drawing.Size(129, 28);
            this.lbEspecialidad.TabIndex = 25;
            this.lbEspecialidad.Text = "Especialidad";
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNac.Location = new System.Drawing.Point(11, 170);
            this.lblFechaNac.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(180, 28);
            this.lblFechaNac.TabIndex = 37;
            this.lblFechaNac.Text = "Fecha de nacimiento";
            // 
            // txtFechaNac
            // 
            this.txtFechaNac.Enabled = false;
            this.txtFechaNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaNac.Location = new System.Drawing.Point(199, 168);
            this.txtFechaNac.Margin = new System.Windows.Forms.Padding(4);
            this.txtFechaNac.Name = "txtFechaNac";
            this.txtFechaNac.ReadOnly = true;
            this.txtFechaNac.Size = new System.Drawing.Size(276, 29);
            this.txtFechaNac.TabIndex = 38;
            // 
            // lblDireccion
            // 
            this.lblDireccion.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(11, 213);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(159, 28);
            this.lblDireccion.TabIndex = 33;
            this.lblDireccion.Text = "Direccion";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Enabled = false;
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(199, 213);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.ReadOnly = true;
            this.txtDireccion.Size = new System.Drawing.Size(450, 29);
            this.txtDireccion.TabIndex = 34;
            // 
            // txtEspecialidad
            // 
            this.txtEspecialidad.Enabled = false;
            this.txtEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEspecialidad.Location = new System.Drawing.Point(199, 120);
            this.txtEspecialidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtEspecialidad.Name = "txtEspecialidad";
            this.txtEspecialidad.ReadOnly = true;
            this.txtEspecialidad.Size = new System.Drawing.Size(276, 29);
            this.txtEspecialidad.TabIndex = 35;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(199, 77);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(144, 29);
            this.txtCodigo.TabIndex = 22;
            // 
            // tabFichaAtencion
            // 
            this.tabFichaAtencion.Controls.Add(this.pnlScrollFicha);
            this.tabFichaAtencion.Location = new System.Drawing.Point(4, 30);
            this.tabFichaAtencion.Margin = new System.Windows.Forms.Padding(4);
            this.tabFichaAtencion.Name = "tabFichaAtencion";
            this.tabFichaAtencion.Padding = new System.Windows.Forms.Padding(4);
            this.tabFichaAtencion.Size = new System.Drawing.Size(1059, 424);
            this.tabFichaAtencion.TabIndex = 1;
            this.tabFichaAtencion.Text = "Ficha de atencion";
            this.tabFichaAtencion.UseVisualStyleBackColor = true;
            // 
            // pnlScrollFicha
            // 
            this.pnlScrollFicha.AutoScroll = true;
            this.pnlScrollFicha.AutoScrollMargin = new System.Drawing.Size(0, 15);
            this.pnlScrollFicha.Controls.Add(this.cbCodigoAtencion);
            this.pnlScrollFicha.Controls.Add(this.btnGuardar);
            this.pnlScrollFicha.Controls.Add(this.txtCompromiso);
            this.pnlScrollFicha.Controls.Add(this.lblCompromiso);
            this.pnlScrollFicha.Controls.Add(this.rbNoAsistio);
            this.pnlScrollFicha.Controls.Add(this.rbAsistio);
            this.pnlScrollFicha.Controls.Add(this.lbNombre_ficha);
            this.pnlScrollFicha.Controls.Add(this.lblAsistencia);
            this.pnlScrollFicha.Controls.Add(this.label6);
            this.pnlScrollFicha.Controls.Add(this.txtMotivo);
            this.pnlScrollFicha.Controls.Add(this.label5);
            this.pnlScrollFicha.Location = new System.Drawing.Point(4, 4);
            this.pnlScrollFicha.Margin = new System.Windows.Forms.Padding(4);
            this.pnlScrollFicha.Name = "pnlScrollFicha";
            this.pnlScrollFicha.Size = new System.Drawing.Size(1052, 422);
            this.pnlScrollFicha.TabIndex = 26;
            // 
            // cbCodigoAtencion
            // 
            this.cbCodigoAtencion.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCodigoAtencion.FormattingEnabled = true;
            this.cbCodigoAtencion.Location = new System.Drawing.Point(12, 84);
            this.cbCodigoAtencion.Name = "cbCodigoAtencion";
            this.cbCodigoAtencion.Size = new System.Drawing.Size(502, 29);
            this.cbCodigoAtencion.TabIndex = 60;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(75)))));
            this.btnGuardar.Location = new System.Drawing.Point(793, 28);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(114, 34);
            this.btnGuardar.TabIndex = 59;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtCompromiso
            // 
            this.txtCompromiso.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompromiso.Location = new System.Drawing.Point(7, 409);
            this.txtCompromiso.Margin = new System.Windows.Forms.Padding(4);
            this.txtCompromiso.Multiline = true;
            this.txtCompromiso.Name = "txtCompromiso";
            this.txtCompromiso.ReadOnly = true;
            this.txtCompromiso.Size = new System.Drawing.Size(507, 98);
            this.txtCompromiso.TabIndex = 58;
            // 
            // lblCompromiso
            // 
            this.lblCompromiso.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompromiso.Location = new System.Drawing.Point(7, 377);
            this.lblCompromiso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompromiso.Name = "lblCompromiso";
            this.lblCompromiso.Size = new System.Drawing.Size(223, 28);
            this.lblCompromiso.TabIndex = 57;
            this.lblCompromiso.Text = "Compromiso";
            // 
            // rbNoAsistio
            // 
            this.rbNoAsistio.AutoSize = true;
            this.rbNoAsistio.Enabled = false;
            this.rbNoAsistio.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNoAsistio.Location = new System.Drawing.Point(264, 314);
            this.rbNoAsistio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbNoAsistio.Name = "rbNoAsistio";
            this.rbNoAsistio.Size = new System.Drawing.Size(58, 31);
            this.rbNoAsistio.TabIndex = 56;
            this.rbNoAsistio.TabStop = true;
            this.rbNoAsistio.Text = "No";
            this.rbNoAsistio.UseVisualStyleBackColor = true;
            // 
            // rbAsistio
            // 
            this.rbAsistio.AutoSize = true;
            this.rbAsistio.Enabled = false;
            this.rbAsistio.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAsistio.Location = new System.Drawing.Point(184, 314);
            this.rbAsistio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbAsistio.Name = "rbAsistio";
            this.rbAsistio.Size = new System.Drawing.Size(46, 31);
            this.rbAsistio.TabIndex = 55;
            this.rbAsistio.TabStop = true;
            this.rbAsistio.Text = "Sí";
            this.rbAsistio.UseVisualStyleBackColor = true;
            // 
            // lbNombre_ficha
            // 
            this.lbNombre_ficha.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre_ficha.Location = new System.Drawing.Point(0, 0);
            this.lbNombre_ficha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNombre_ficha.Name = "lbNombre_ficha";
            this.lbNombre_ficha.Size = new System.Drawing.Size(392, 42);
            this.lbNombre_ficha.TabIndex = 40;
            this.lbNombre_ficha.Text = "Huertas Hortez, Jose Luis";
            // 
            // lblAsistencia
            // 
            this.lblAsistencia.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsistencia.Location = new System.Drawing.Point(7, 314);
            this.lblAsistencia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAsistencia.Name = "lblAsistencia";
            this.lblAsistencia.Size = new System.Drawing.Size(149, 28);
            this.lblAsistencia.TabIndex = 52;
            this.lblAsistencia.Text = "Asistencia";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 53);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 28);
            this.label6.TabIndex = 49;
            this.label6.Text = "Codigos de atencion";
            // 
            // txtMotivo
            // 
            this.txtMotivo.Enabled = false;
            this.txtMotivo.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotivo.Location = new System.Drawing.Point(12, 187);
            this.txtMotivo.Margin = new System.Windows.Forms.Padding(4);
            this.txtMotivo.Multiline = true;
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.ReadOnly = true;
            this.txtMotivo.Size = new System.Drawing.Size(507, 98);
            this.txtMotivo.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 155);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 28);
            this.label5.TabIndex = 47;
            this.label5.Text = "Motivo de consulta";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnDetEventosPrev);
            this.tabPage4.Controls.Add(this.btnDetCitasPrev);
            this.tabPage4.Controls.Add(this.dvgEventosPasados);
            this.tabPage4.Controls.Add(this.dvgCitasPasadas);
            this.tabPage4.Controls.Add(this.lblEventosPrev);
            this.tabPage4.Controls.Add(this.lblCitasPrev);
            this.tabPage4.Controls.Add(this.lbNombre_eventos_cita);
            this.tabPage4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.tabPage4.Location = new System.Drawing.Point(4, 30);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1059, 424);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Eventos y citas";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnDetEventosPrev
            // 
            this.btnDetEventosPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetEventosPrev.Location = new System.Drawing.Point(604, 230);
            this.btnDetEventosPrev.Margin = new System.Windows.Forms.Padding(4);
            this.btnDetEventosPrev.Name = "btnDetEventosPrev";
            this.btnDetEventosPrev.Size = new System.Drawing.Size(100, 28);
            this.btnDetEventosPrev.TabIndex = 54;
            this.btnDetEventosPrev.Text = "Detalles";
            this.btnDetEventosPrev.UseVisualStyleBackColor = true;
            this.btnDetEventosPrev.Click += new System.EventHandler(this.btnDetEventosPrev_Click);
            // 
            // btnDetCitasPrev
            // 
            this.btnDetCitasPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetCitasPrev.Location = new System.Drawing.Point(604, 47);
            this.btnDetCitasPrev.Margin = new System.Windows.Forms.Padding(4);
            this.btnDetCitasPrev.Name = "btnDetCitasPrev";
            this.btnDetCitasPrev.Size = new System.Drawing.Size(100, 28);
            this.btnDetCitasPrev.TabIndex = 53;
            this.btnDetCitasPrev.Text = "Detalles";
            this.btnDetCitasPrev.UseVisualStyleBackColor = true;
            this.btnDetCitasPrev.Click += new System.EventHandler(this.btnDetCitasPrev_Click);
            // 
            // dvgEventosPasados
            // 
            this.dvgEventosPasados.AllowUserToAddRows = false;
            this.dvgEventosPasados.AllowUserToDeleteRows = false;
            this.dvgEventosPasados.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.dvgEventosPasados.Location = new System.Drawing.Point(11, 266);
            this.dvgEventosPasados.Margin = new System.Windows.Forms.Padding(4);
            this.dvgEventosPasados.Name = "dvgEventosPasados";
            this.dvgEventosPasados.ReadOnly = true;
            this.dvgEventosPasados.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dvgEventosPasados.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dvgEventosPasados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgEventosPasados.Size = new System.Drawing.Size(693, 148);
            this.dvgEventosPasados.TabIndex = 52;
            this.dvgEventosPasados.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dvgEventosPasados_CellFormatting);
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha del Evento";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 160;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre del Evento";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 305;
            // 
            // dvgCitasPasadas
            // 
            this.dvgCitasPasadas.AllowUserToAddRows = false;
            this.dvgCitasPasadas.AllowUserToDeleteRows = false;
            this.dvgCitasPasadas.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgCitasPasadas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dvgCitasPasadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgCitasPasadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FechaCita,
            this.MiembroOOIA});
            this.dvgCitasPasadas.EnableHeadersVisualStyles = false;
            this.dvgCitasPasadas.Location = new System.Drawing.Point(11, 82);
            this.dvgCitasPasadas.Margin = new System.Windows.Forms.Padding(4);
            this.dvgCitasPasadas.Name = "dvgCitasPasadas";
            this.dvgCitasPasadas.ReadOnly = true;
            this.dvgCitasPasadas.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dvgCitasPasadas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dvgCitasPasadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgCitasPasadas.Size = new System.Drawing.Size(693, 140);
            this.dvgCitasPasadas.TabIndex = 51;
            this.dvgCitasPasadas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dvgCitasPasadas_CellFormatting);
            // 
            // FechaCita
            // 
            this.FechaCita.HeaderText = "Fecha de la cita";
            this.FechaCita.MinimumWidth = 6;
            this.FechaCita.Name = "FechaCita";
            this.FechaCita.ReadOnly = true;
            this.FechaCita.Width = 180;
            // 
            // MiembroOOIA
            // 
            this.MiembroOOIA.HeaderText = "Tutor/Psicólogo";
            this.MiembroOOIA.MinimumWidth = 6;
            this.MiembroOOIA.Name = "MiembroOOIA";
            this.MiembroOOIA.ReadOnly = true;
            this.MiembroOOIA.Width = 285;
            // 
            // lblEventosPrev
            // 
            this.lblEventosPrev.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventosPrev.Location = new System.Drawing.Point(5, 234);
            this.lblEventosPrev.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEventosPrev.Name = "lblEventosPrev";
            this.lblEventosPrev.Size = new System.Drawing.Size(223, 28);
            this.lblEventosPrev.TabIndex = 50;
            this.lblEventosPrev.Text = "Eventos Previos";
            // 
            // lblCitasPrev
            // 
            this.lblCitasPrev.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCitasPrev.Location = new System.Drawing.Point(4, 50);
            this.lblCitasPrev.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCitasPrev.Name = "lblCitasPrev";
            this.lblCitasPrev.Size = new System.Drawing.Size(223, 28);
            this.lblCitasPrev.TabIndex = 49;
            this.lblCitasPrev.Text = "Citas Previas";
            // 
            // lbNombre_eventos_cita
            // 
            this.lbNombre_eventos_cita.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre_eventos_cita.Location = new System.Drawing.Point(4, 4);
            this.lbNombre_eventos_cita.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNombre_eventos_cita.Name = "lbNombre_eventos_cita";
            this.lbNombre_eventos_cita.Size = new System.Drawing.Size(328, 43);
            this.lbNombre_eventos_cita.TabIndex = 41;
            this.lbNombre_eventos_cita.Text = "Huertas Hortez, Jose Luis";
            // 
            // btnBack
            // 
            this.btnBack.Image = global::ProyectoOOIA.Properties.Resources.arrowWhite;
            this.btnBack.Location = new System.Drawing.Point(15, 43);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(33, 31);
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
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1067, 87);
            this.pnlHeader.TabIndex = 10;
            // 
            // frmDetalleCitaAsesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.tabDetalleCita);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "frmDetalleCitaAsesor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ficha de datos alumno";
            this.tabDetalleCita.ResumeLayout(false);
            this.tabDatosAlumnos.ResumeLayout(false);
            this.tabDatosAlumnos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pImageAlumno)).EndInit();
            this.tabFichaAtencion.ResumeLayout(false);
            this.pnlScrollFicha.ResumeLayout(false);
            this.pnlScrollFicha.PerformLayout();
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
        private System.Windows.Forms.TabPage tabFichaAtencion;
        private System.Windows.Forms.Panel pnlScrollFicha;
        private System.Windows.Forms.Label lblAsistencia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbNombre_ficha;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label lbNombre_eventos_cita;
        private System.Windows.Forms.DataGridView dvgEventosPasados;
        private System.Windows.Forms.DataGridView dvgCitasPasadas;
        private System.Windows.Forms.Label lblEventosPrev;
        private System.Windows.Forms.Label lblCitasPrev;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.Button btnDetCitasPrev;
        private System.Windows.Forms.Button btnDetEventosPrev;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.RadioButton rbAsistio;
        private System.Windows.Forms.RadioButton rbNoAsistio;
        private System.Windows.Forms.TextBox txtCompromiso;
        private System.Windows.Forms.Label lblCompromiso;
        private System.Windows.Forms.TabPage tabDatosAlumnos;
        private System.Windows.Forms.Label lbNombreAlumno;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.PictureBox pImageAlumno;
        private System.Windows.Forms.Label lbEspecialidad;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.TextBox txtFechaNac;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtEspecialidad;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaCita;
        private System.Windows.Forms.DataGridViewTextBoxColumn MiembroOOIA;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cbCodigoAtencion;
    }
}