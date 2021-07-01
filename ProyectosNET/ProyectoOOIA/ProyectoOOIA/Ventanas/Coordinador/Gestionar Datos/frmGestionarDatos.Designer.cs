﻿
namespace ProyectoOOIA.Ventanas.Miembro_OOIA
{
    partial class frmCargarDatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCargarDatos));
            this.archivos = new System.Windows.Forms.OpenFileDialog();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.txtHeader = new System.Windows.Forms.Label();
            this.panelGestionHumana = new System.Windows.Forms.TabControl();
            this.tabGestionHumana = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnEspecialidad = new System.Windows.Forms.Button();
            this.lblEspecialidadForm = new System.Windows.Forms.Label();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlCoordinador = new System.Windows.Forms.Panel();
            this.btnCoordinador = new System.Windows.Forms.Button();
            this.lblCoordinadorForm = new System.Windows.Forms.Label();
            this.lblCoordinador = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pnlEspecialidad = new System.Windows.Forms.Panel();
            this.btnPonente = new System.Windows.Forms.Button();
            this.lblPonenteForm = new System.Windows.Forms.Label();
            this.lblPonente = new System.Windows.Forms.Label();
            this.pnlAsesor = new System.Windows.Forms.Panel();
            this.btnAsesorFile = new System.Windows.Forms.Button();
            this.rbPsicologo = new System.Windows.Forms.RadioButton();
            this.rbProfesor = new System.Windows.Forms.RadioButton();
            this.lblTipoAsesor = new System.Windows.Forms.Label();
            this.lblAsesor = new System.Windows.Forms.Label();
            this.btnAsesorCSV = new System.Windows.Forms.Button();
            this.lblAsesorCSV = new System.Windows.Forms.Label();
            this.lblAsesorForm = new System.Windows.Forms.Label();
            this.txtAsesor = new System.Windows.Forms.TextBox();
            this.btnAsesor = new System.Windows.Forms.Button();
            this.pnlAlumno = new System.Windows.Forms.Panel();
            this.btnAlumnoFile = new System.Windows.Forms.Button();
            this.lblAlumno = new System.Windows.Forms.Label();
            this.btnAlumnoCSV = new System.Windows.Forms.Button();
            this.lblAlumnoCSV = new System.Windows.Forms.Label();
            this.lblAlumnoForm = new System.Windows.Forms.Label();
            this.txtAlumno = new System.Windows.Forms.TextBox();
            this.btnAlumno = new System.Windows.Forms.Button();
            this.tabGestionAtencion = new System.Windows.Forms.TabPage();
            this.pnlCodigoAtencion = new System.Windows.Forms.Panel();
            this.btnCodigoAtencion = new System.Windows.Forms.Button();
            this.lblCodigoAtencionForm = new System.Windows.Forms.Label();
            this.lblCodigoAtencion = new System.Windows.Forms.Label();
            this.tabEvento = new System.Windows.Forms.TabPage();
            this.pnlCategoria = new System.Windows.Forms.Panel();
            this.btnCategoria = new System.Windows.Forms.Button();
            this.lblCategoriaForm = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.tabPlantillaCSV = new System.Windows.Forms.TabPage();
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.btnDescargarPlantilla = new System.Windows.Forms.Button();
            this.guardarPlantilla = new System.Windows.Forms.SaveFileDialog();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.panelGestionHumana.SuspendLayout();
            this.tabGestionHumana.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlCoordinador.SuspendLayout();
            this.pnlEspecialidad.SuspendLayout();
            this.pnlAsesor.SuspendLayout();
            this.pnlAlumno.SuspendLayout();
            this.tabGestionAtencion.SuspendLayout();
            this.pnlCodigoAtencion.SuspendLayout();
            this.tabEvento.SuspendLayout();
            this.pnlCategoria.SuspendLayout();
            this.tabPlantillaCSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            this.SuspendLayout();
            // 
            // archivos
            // 
            this.archivos.Filter = "Archivos CSV (*.csv)|*.csv|Archivo de texto (*.txt)|*.txt";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(71)))), ((int)(((byte)(123)))));
            this.pnlHeader.Controls.Add(this.btnBack);
            this.pnlHeader.Controls.Add(this.txtHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(912, 87);
            this.pnlHeader.TabIndex = 0;
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
            this.btnBack.TabIndex = 4;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtHeader
            // 
            this.txtHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeader.ForeColor = System.Drawing.SystemColors.Control;
            this.txtHeader.Location = new System.Drawing.Point(55, 42);
            this.txtHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtHeader.Name = "txtHeader";
            this.txtHeader.Size = new System.Drawing.Size(488, 46);
            this.txtHeader.TabIndex = 1;
            this.txtHeader.Text = "Gestionar Información del Sistema";
            // 
            // panelGestionHumana
            // 
            this.panelGestionHumana.Controls.Add(this.tabGestionHumana);
            this.panelGestionHumana.Controls.Add(this.tabGestionAtencion);
            this.panelGestionHumana.Controls.Add(this.tabEvento);
            this.panelGestionHumana.Controls.Add(this.tabPlantillaCSV);
            this.panelGestionHumana.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGestionHumana.Location = new System.Drawing.Point(0, 87);
            this.panelGestionHumana.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelGestionHumana.Name = "panelGestionHumana";
            this.panelGestionHumana.SelectedIndex = 0;
            this.panelGestionHumana.Size = new System.Drawing.Size(912, 480);
            this.panelGestionHumana.TabIndex = 1;
            // 
            // tabGestionHumana
            // 
            this.tabGestionHumana.AutoScroll = true;
            this.tabGestionHumana.Controls.Add(this.panel3);
            this.tabGestionHumana.Controls.Add(this.panel1);
            this.tabGestionHumana.Controls.Add(this.pnlEspecialidad);
            this.tabGestionHumana.Controls.Add(this.pnlAsesor);
            this.tabGestionHumana.Controls.Add(this.pnlAlumno);
            this.tabGestionHumana.Location = new System.Drawing.Point(4, 25);
            this.tabGestionHumana.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabGestionHumana.Name = "tabGestionHumana";
            this.tabGestionHumana.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabGestionHumana.Size = new System.Drawing.Size(904, 451);
            this.tabGestionHumana.TabIndex = 0;
            this.tabGestionHumana.Text = "Gestion de Usuarios";
            this.tabGestionHumana.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnEspecialidad);
            this.panel3.Controls.Add(this.lblEspecialidadForm);
            this.panel3.Controls.Add(this.lblEspecialidad);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(4, 493);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(875, 96);
            this.panel3.TabIndex = 41;
            // 
            // btnEspecialidad
            // 
            this.btnEspecialidad.Location = new System.Drawing.Point(539, 38);
            this.btnEspecialidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEspecialidad.Name = "btnEspecialidad";
            this.btnEspecialidad.Size = new System.Drawing.Size(184, 36);
            this.btnEspecialidad.TabIndex = 37;
            this.btnEspecialidad.Text = "Gestionar Especialidades";
            this.btnEspecialidad.UseVisualStyleBackColor = true;
            this.btnEspecialidad.Click += new System.EventHandler(this.btnEspecialidad_Click);
            // 
            // lblEspecialidadForm
            // 
            this.lblEspecialidadForm.AutoSize = true;
            this.lblEspecialidadForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecialidadForm.Location = new System.Drawing.Point(8, 42);
            this.lblEspecialidadForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEspecialidadForm.Name = "lblEspecialidadForm";
            this.lblEspecialidadForm.Size = new System.Drawing.Size(342, 24);
            this.lblEspecialidadForm.TabIndex = 36;
            this.lblEspecialidadForm.Text = "Gestionar especialidades por formulario";
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecialidad.Location = new System.Drawing.Point(7, 4);
            this.lblEspecialidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(197, 31);
            this.lblEspecialidad.TabIndex = 12;
            this.lblEspecialidad.Text = "Especialidades";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlCoordinador);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(4, 397);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 96);
            this.panel1.TabIndex = 40;
            // 
            // pnlCoordinador
            // 
            this.pnlCoordinador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCoordinador.Controls.Add(this.btnCoordinador);
            this.pnlCoordinador.Controls.Add(this.lblCoordinadorForm);
            this.pnlCoordinador.Controls.Add(this.lblCoordinador);
            this.pnlCoordinador.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCoordinador.Location = new System.Drawing.Point(0, 0);
            this.pnlCoordinador.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlCoordinador.Name = "pnlCoordinador";
            this.pnlCoordinador.Size = new System.Drawing.Size(875, 96);
            this.pnlCoordinador.TabIndex = 41;
            // 
            // btnCoordinador
            // 
            this.btnCoordinador.Location = new System.Drawing.Point(539, 38);
            this.btnCoordinador.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCoordinador.Name = "btnCoordinador";
            this.btnCoordinador.Size = new System.Drawing.Size(184, 36);
            this.btnCoordinador.TabIndex = 37;
            this.btnCoordinador.Text = "Gestionar Coordinadores";
            this.btnCoordinador.UseVisualStyleBackColor = true;
            this.btnCoordinador.Click += new System.EventHandler(this.btnCoordinador_Click);
            // 
            // lblCoordinadorForm
            // 
            this.lblCoordinadorForm.AutoSize = true;
            this.lblCoordinadorForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoordinadorForm.Location = new System.Drawing.Point(8, 42);
            this.lblCoordinadorForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCoordinadorForm.Name = "lblCoordinadorForm";
            this.lblCoordinadorForm.Size = new System.Drawing.Size(338, 24);
            this.lblCoordinadorForm.TabIndex = 36;
            this.lblCoordinadorForm.Text = "Gestionar coordinadores por formulario";
            // 
            // lblCoordinador
            // 
            this.lblCoordinador.AutoSize = true;
            this.lblCoordinador.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoordinador.Location = new System.Drawing.Point(7, 4);
            this.lblCoordinador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCoordinador.Name = "lblCoordinador";
            this.lblCoordinador.Size = new System.Drawing.Size(192, 31);
            this.lblCoordinador.TabIndex = 12;
            this.lblCoordinador.Text = "Coordinadores";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(531, 38);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 36);
            this.button1.TabIndex = 37;
            this.button1.Text = "Gestionar Especialidades";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 42);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(342, 24);
            this.label6.TabIndex = 36;
            this.label6.Text = "Gestionar especialidades por formulario";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(7, 4);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(197, 31);
            this.label13.TabIndex = 12;
            this.label13.Text = "Especialidades";
            // 
            // pnlEspecialidad
            // 
            this.pnlEspecialidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEspecialidad.Controls.Add(this.btnPonente);
            this.pnlEspecialidad.Controls.Add(this.lblPonenteForm);
            this.pnlEspecialidad.Controls.Add(this.lblPonente);
            this.pnlEspecialidad.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEspecialidad.Location = new System.Drawing.Point(4, 301);
            this.pnlEspecialidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlEspecialidad.Name = "pnlEspecialidad";
            this.pnlEspecialidad.Size = new System.Drawing.Size(875, 96);
            this.pnlEspecialidad.TabIndex = 39;
            // 
            // btnPonente
            // 
            this.btnPonente.Location = new System.Drawing.Point(539, 38);
            this.btnPonente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPonente.Name = "btnPonente";
            this.btnPonente.Size = new System.Drawing.Size(184, 36);
            this.btnPonente.TabIndex = 37;
            this.btnPonente.Text = "Gestionar Ponentes";
            this.btnPonente.UseVisualStyleBackColor = true;
            this.btnPonente.Click += new System.EventHandler(this.btnPonente_Click);
            // 
            // lblPonenteForm
            // 
            this.lblPonenteForm.AutoSize = true;
            this.lblPonenteForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPonenteForm.Location = new System.Drawing.Point(8, 42);
            this.lblPonenteForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPonenteForm.Name = "lblPonenteForm";
            this.lblPonenteForm.Size = new System.Drawing.Size(295, 24);
            this.lblPonenteForm.TabIndex = 36;
            this.lblPonenteForm.Text = "Gestionar ponentes por formulario";
            // 
            // lblPonente
            // 
            this.lblPonente.AutoSize = true;
            this.lblPonente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPonente.Location = new System.Drawing.Point(7, 4);
            this.lblPonente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPonente.Name = "lblPonente";
            this.lblPonente.Size = new System.Drawing.Size(129, 31);
            this.lblPonente.TabIndex = 12;
            this.lblPonente.Text = "Ponentes";
            // 
            // pnlAsesor
            // 
            this.pnlAsesor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAsesor.Controls.Add(this.btnAsesorFile);
            this.pnlAsesor.Controls.Add(this.rbPsicologo);
            this.pnlAsesor.Controls.Add(this.rbProfesor);
            this.pnlAsesor.Controls.Add(this.lblTipoAsesor);
            this.pnlAsesor.Controls.Add(this.lblAsesor);
            this.pnlAsesor.Controls.Add(this.btnAsesorCSV);
            this.pnlAsesor.Controls.Add(this.lblAsesorCSV);
            this.pnlAsesor.Controls.Add(this.lblAsesorForm);
            this.pnlAsesor.Controls.Add(this.txtAsesor);
            this.pnlAsesor.Controls.Add(this.btnAsesor);
            this.pnlAsesor.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAsesor.Location = new System.Drawing.Point(4, 139);
            this.pnlAsesor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlAsesor.Name = "pnlAsesor";
            this.pnlAsesor.Size = new System.Drawing.Size(875, 162);
            this.pnlAsesor.TabIndex = 38;
            // 
            // btnAsesorFile
            // 
            this.btnAsesorFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsesorFile.Location = new System.Drawing.Point(488, 116);
            this.btnAsesorFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAsesorFile.Name = "btnAsesorFile";
            this.btnAsesorFile.Size = new System.Drawing.Size(44, 27);
            this.btnAsesorFile.TabIndex = 40;
            this.btnAsesorFile.Text = "...";
            this.btnAsesorFile.UseVisualStyleBackColor = true;
            this.btnAsesorFile.Click += new System.EventHandler(this.btnAsesorFile_Click);
            // 
            // rbPsicologo
            // 
            this.rbPsicologo.AutoSize = true;
            this.rbPsicologo.Location = new System.Drawing.Point(652, 31);
            this.rbPsicologo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbPsicologo.Name = "rbPsicologo";
            this.rbPsicologo.Size = new System.Drawing.Size(90, 21);
            this.rbPsicologo.TabIndex = 39;
            this.rbPsicologo.TabStop = true;
            this.rbPsicologo.Text = "Psicologo";
            this.rbPsicologo.UseVisualStyleBackColor = true;
            // 
            // rbProfesor
            // 
            this.rbProfesor.AutoSize = true;
            this.rbProfesor.Checked = true;
            this.rbProfesor.Location = new System.Drawing.Point(531, 31);
            this.rbProfesor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbProfesor.Name = "rbProfesor";
            this.rbProfesor.Size = new System.Drawing.Size(83, 21);
            this.rbProfesor.TabIndex = 38;
            this.rbProfesor.TabStop = true;
            this.rbProfesor.Text = "Profesor";
            this.rbProfesor.UseVisualStyleBackColor = true;
            // 
            // lblTipoAsesor
            // 
            this.lblTipoAsesor.AutoSize = true;
            this.lblTipoAsesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoAsesor.Location = new System.Drawing.Point(8, 37);
            this.lblTipoAsesor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoAsesor.Name = "lblTipoAsesor";
            this.lblTipoAsesor.Size = new System.Drawing.Size(136, 24);
            this.lblTipoAsesor.TabIndex = 37;
            this.lblTipoAsesor.Text = "Tipo de asesor";
            // 
            // lblAsesor
            // 
            this.lblAsesor.AutoSize = true;
            this.lblAsesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsesor.Location = new System.Drawing.Point(7, 0);
            this.lblAsesor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAsesor.Name = "lblAsesor";
            this.lblAsesor.Size = new System.Drawing.Size(128, 31);
            this.lblAsesor.TabIndex = 12;
            this.lblAsesor.Text = "Asesores";
            // 
            // btnAsesorCSV
            // 
            this.btnAsesorCSV.Location = new System.Drawing.Point(539, 112);
            this.btnAsesorCSV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAsesorCSV.Name = "btnAsesorCSV";
            this.btnAsesorCSV.Size = new System.Drawing.Size(184, 34);
            this.btnAsesorCSV.TabIndex = 34;
            this.btnAsesorCSV.Text = "Cargar desde csv";
            this.btnAsesorCSV.UseVisualStyleBackColor = true;
            this.btnAsesorCSV.Click += new System.EventHandler(this.btnAsesorCSV_Click);
            // 
            // lblAsesorCSV
            // 
            this.lblAsesorCSV.AutoSize = true;
            this.lblAsesorCSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsesorCSV.Location = new System.Drawing.Point(8, 89);
            this.lblAsesorCSV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAsesorCSV.Name = "lblAsesorCSV";
            this.lblAsesorCSV.Size = new System.Drawing.Size(317, 24);
            this.lblAsesorCSV.TabIndex = 36;
            this.lblAsesorCSV.Text = "Cargar Asesores desde archivo CSV";
            // 
            // lblAsesorForm
            // 
            this.lblAsesorForm.AutoSize = true;
            this.lblAsesorForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsesorForm.Location = new System.Drawing.Point(8, 63);
            this.lblAsesorForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAsesorForm.Name = "lblAsesorForm";
            this.lblAsesorForm.Size = new System.Drawing.Size(292, 24);
            this.lblAsesorForm.TabIndex = 35;
            this.lblAsesorForm.Text = "Gestionar asesores por formulario";
            // 
            // txtAsesor
            // 
            this.txtAsesor.Enabled = false;
            this.txtAsesor.Location = new System.Drawing.Point(13, 118);
            this.txtAsesor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAsesor.Name = "txtAsesor";
            this.txtAsesor.Size = new System.Drawing.Size(467, 22);
            this.txtAsesor.TabIndex = 18;
            // 
            // btnAsesor
            // 
            this.btnAsesor.Location = new System.Drawing.Point(539, 59);
            this.btnAsesor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAsesor.Name = "btnAsesor";
            this.btnAsesor.Size = new System.Drawing.Size(184, 36);
            this.btnAsesor.TabIndex = 15;
            this.btnAsesor.Text = "Gestionar Asesores";
            this.btnAsesor.UseVisualStyleBackColor = true;
            this.btnAsesor.Click += new System.EventHandler(this.btnAsesor_Click);
            // 
            // pnlAlumno
            // 
            this.pnlAlumno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAlumno.Controls.Add(this.btnAlumnoFile);
            this.pnlAlumno.Controls.Add(this.lblAlumno);
            this.pnlAlumno.Controls.Add(this.btnAlumnoCSV);
            this.pnlAlumno.Controls.Add(this.lblAlumnoCSV);
            this.pnlAlumno.Controls.Add(this.lblAlumnoForm);
            this.pnlAlumno.Controls.Add(this.txtAlumno);
            this.pnlAlumno.Controls.Add(this.btnAlumno);
            this.pnlAlumno.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAlumno.Location = new System.Drawing.Point(4, 4);
            this.pnlAlumno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlAlumno.Name = "pnlAlumno";
            this.pnlAlumno.Size = new System.Drawing.Size(875, 135);
            this.pnlAlumno.TabIndex = 37;
            // 
            // btnAlumnoFile
            // 
            this.btnAlumnoFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlumnoFile.Location = new System.Drawing.Point(488, 90);
            this.btnAlumnoFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAlumnoFile.Name = "btnAlumnoFile";
            this.btnAlumnoFile.Size = new System.Drawing.Size(44, 27);
            this.btnAlumnoFile.TabIndex = 37;
            this.btnAlumnoFile.Text = "...";
            this.btnAlumnoFile.UseVisualStyleBackColor = true;
            this.btnAlumnoFile.Click += new System.EventHandler(this.btnAlumnoFile_Click);
            // 
            // lblAlumno
            // 
            this.lblAlumno.AutoSize = true;
            this.lblAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlumno.Location = new System.Drawing.Point(7, 0);
            this.lblAlumno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAlumno.Name = "lblAlumno";
            this.lblAlumno.Size = new System.Drawing.Size(119, 31);
            this.lblAlumno.TabIndex = 12;
            this.lblAlumno.Text = "Alumnos";
            // 
            // btnAlumnoCSV
            // 
            this.btnAlumnoCSV.Location = new System.Drawing.Point(539, 86);
            this.btnAlumnoCSV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAlumnoCSV.Name = "btnAlumnoCSV";
            this.btnAlumnoCSV.Size = new System.Drawing.Size(184, 34);
            this.btnAlumnoCSV.TabIndex = 34;
            this.btnAlumnoCSV.Text = "Cargar desde csv";
            this.btnAlumnoCSV.UseVisualStyleBackColor = true;
            this.btnAlumnoCSV.Click += new System.EventHandler(this.btnAlumnoCSV_Click);
            // 
            // lblAlumnoCSV
            // 
            this.lblAlumnoCSV.AutoSize = true;
            this.lblAlumnoCSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlumnoCSV.Location = new System.Drawing.Point(8, 63);
            this.lblAlumnoCSV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAlumnoCSV.Name = "lblAlumnoCSV";
            this.lblAlumnoCSV.Size = new System.Drawing.Size(313, 24);
            this.lblAlumnoCSV.TabIndex = 36;
            this.lblAlumnoCSV.Text = "Cargar Alumnos desde archivo CSV";
            // 
            // lblAlumnoForm
            // 
            this.lblAlumnoForm.AutoSize = true;
            this.lblAlumnoForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlumnoForm.Location = new System.Drawing.Point(8, 37);
            this.lblAlumnoForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAlumnoForm.Name = "lblAlumnoForm";
            this.lblAlumnoForm.Size = new System.Drawing.Size(288, 24);
            this.lblAlumnoForm.TabIndex = 35;
            this.lblAlumnoForm.Text = "Gestionar alumnos por formulario";
            // 
            // txtAlumno
            // 
            this.txtAlumno.Enabled = false;
            this.txtAlumno.Location = new System.Drawing.Point(13, 92);
            this.txtAlumno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAlumno.Name = "txtAlumno";
            this.txtAlumno.Size = new System.Drawing.Size(467, 22);
            this.txtAlumno.TabIndex = 18;
            // 
            // btnAlumno
            // 
            this.btnAlumno.Location = new System.Drawing.Point(539, 33);
            this.btnAlumno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAlumno.Name = "btnAlumno";
            this.btnAlumno.Size = new System.Drawing.Size(184, 36);
            this.btnAlumno.TabIndex = 15;
            this.btnAlumno.Text = "Gestionar Alumnos";
            this.btnAlumno.UseVisualStyleBackColor = true;
            this.btnAlumno.Click += new System.EventHandler(this.btnAlumno_Click);
            // 
            // tabGestionAtencion
            // 
            this.tabGestionAtencion.AutoScroll = true;
            this.tabGestionAtencion.Controls.Add(this.pnlCodigoAtencion);
            this.tabGestionAtencion.Location = new System.Drawing.Point(4, 25);
            this.tabGestionAtencion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabGestionAtencion.Name = "tabGestionAtencion";
            this.tabGestionAtencion.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabGestionAtencion.Size = new System.Drawing.Size(904, 451);
            this.tabGestionAtencion.TabIndex = 2;
            this.tabGestionAtencion.Text = "Gestion de Citas";
            this.tabGestionAtencion.UseVisualStyleBackColor = true;
            // 
            // pnlCodigoAtencion
            // 
            this.pnlCodigoAtencion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCodigoAtencion.Controls.Add(this.btnCodigoAtencion);
            this.pnlCodigoAtencion.Controls.Add(this.lblCodigoAtencionForm);
            this.pnlCodigoAtencion.Controls.Add(this.lblCodigoAtencion);
            this.pnlCodigoAtencion.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCodigoAtencion.Location = new System.Drawing.Point(4, 4);
            this.pnlCodigoAtencion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlCodigoAtencion.Name = "pnlCodigoAtencion";
            this.pnlCodigoAtencion.Size = new System.Drawing.Size(896, 96);
            this.pnlCodigoAtencion.TabIndex = 40;
            // 
            // btnCodigoAtencion
            // 
            this.btnCodigoAtencion.Location = new System.Drawing.Point(539, 38);
            this.btnCodigoAtencion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCodigoAtencion.Name = "btnCodigoAtencion";
            this.btnCodigoAtencion.Size = new System.Drawing.Size(184, 36);
            this.btnCodigoAtencion.TabIndex = 37;
            this.btnCodigoAtencion.Text = "Gestionar Códigos";
            this.btnCodigoAtencion.UseVisualStyleBackColor = true;
            this.btnCodigoAtencion.Click += new System.EventHandler(this.btnCodigoAtencion_Click);
            // 
            // lblCodigoAtencionForm
            // 
            this.lblCodigoAtencionForm.AutoSize = true;
            this.lblCodigoAtencionForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoAtencionForm.Location = new System.Drawing.Point(8, 42);
            this.lblCodigoAtencionForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoAtencionForm.Name = "lblCodigoAtencionForm";
            this.lblCodigoAtencionForm.Size = new System.Drawing.Size(387, 24);
            this.lblCodigoAtencionForm.TabIndex = 36;
            this.lblCodigoAtencionForm.Text = "Gestionar códigos de atención por formulario";
            // 
            // lblCodigoAtencion
            // 
            this.lblCodigoAtencion.AutoSize = true;
            this.lblCodigoAtencion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoAtencion.Location = new System.Drawing.Point(7, 4);
            this.lblCodigoAtencion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoAtencion.Name = "lblCodigoAtencion";
            this.lblCodigoAtencion.Size = new System.Drawing.Size(264, 31);
            this.lblCodigoAtencion.TabIndex = 12;
            this.lblCodigoAtencion.Text = "Códigos de Atención";
            // 
            // tabEvento
            // 
            this.tabEvento.Controls.Add(this.pnlCategoria);
            this.tabEvento.Location = new System.Drawing.Point(4, 25);
            this.tabEvento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabEvento.Name = "tabEvento";
            this.tabEvento.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabEvento.Size = new System.Drawing.Size(904, 451);
            this.tabEvento.TabIndex = 3;
            this.tabEvento.Text = "Gestion de Eventos";
            this.tabEvento.UseVisualStyleBackColor = true;
            // 
            // pnlCategoria
            // 
            this.pnlCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCategoria.Controls.Add(this.btnCategoria);
            this.pnlCategoria.Controls.Add(this.lblCategoriaForm);
            this.pnlCategoria.Controls.Add(this.lblCategoria);
            this.pnlCategoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCategoria.Location = new System.Drawing.Point(4, 4);
            this.pnlCategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlCategoria.Name = "pnlCategoria";
            this.pnlCategoria.Size = new System.Drawing.Size(896, 96);
            this.pnlCategoria.TabIndex = 41;
            // 
            // btnCategoria
            // 
            this.btnCategoria.Location = new System.Drawing.Point(539, 38);
            this.btnCategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(184, 36);
            this.btnCategoria.TabIndex = 37;
            this.btnCategoria.Text = "Gestionar Categorías";
            this.btnCategoria.UseVisualStyleBackColor = true;
            this.btnCategoria.Click += new System.EventHandler(this.btnCategoria_Click);
            // 
            // lblCategoriaForm
            // 
            this.lblCategoriaForm.AutoSize = true;
            this.lblCategoriaForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaForm.Location = new System.Drawing.Point(8, 42);
            this.lblCategoriaForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoriaForm.Name = "lblCategoriaForm";
            this.lblCategoriaForm.Size = new System.Drawing.Size(391, 24);
            this.lblCategoriaForm.TabIndex = 36;
            this.lblCategoriaForm.Text = "Gestionar categorías de evento por formulario";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(7, 4);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(261, 31);
            this.lblCategoria.TabIndex = 12;
            this.lblCategoria.Text = "Categoría de Evento";
            // 
            // tabPlantillaCSV
            // 
            this.tabPlantillaCSV.AutoScroll = true;
            this.tabPlantillaCSV.Controls.Add(this.axAcroPDF1);
            this.tabPlantillaCSV.Controls.Add(this.btnDescargarPlantilla);
            this.tabPlantillaCSV.Location = new System.Drawing.Point(4, 25);
            this.tabPlantillaCSV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPlantillaCSV.Name = "tabPlantillaCSV";
            this.tabPlantillaCSV.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPlantillaCSV.Size = new System.Drawing.Size(904, 451);
            this.tabPlantillaCSV.TabIndex = 4;
            this.tabPlantillaCSV.Text = "Plantilla de carga CSV";
            this.tabPlantillaCSV.UseVisualStyleBackColor = true;
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(0, 33);
            this.axAcroPDF1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(657, 453);
            this.axAcroPDF1.TabIndex = 1;
            // 
            // btnDescargarPlantilla
            // 
            this.btnDescargarPlantilla.Location = new System.Drawing.Point(367, 5);
            this.btnDescargarPlantilla.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDescargarPlantilla.Name = "btnDescargarPlantilla";
            this.btnDescargarPlantilla.Size = new System.Drawing.Size(171, 28);
            this.btnDescargarPlantilla.TabIndex = 0;
            this.btnDescargarPlantilla.Text = "Descargar Plantilla";
            this.btnDescargarPlantilla.UseVisualStyleBackColor = true;
            this.btnDescargarPlantilla.Click += new System.EventHandler(this.btnDescargarPlantilla_Click);
            // 
            // frmCargarDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(912, 567);
            this.Controls.Add(this.panelGestionHumana);
            this.Controls.Add(this.pnlHeader);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimizeBox = false;
            this.Name = "frmCargarDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestionar Información";
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.panelGestionHumana.ResumeLayout(false);
            this.tabGestionHumana.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlCoordinador.ResumeLayout(false);
            this.pnlCoordinador.PerformLayout();
            this.pnlEspecialidad.ResumeLayout(false);
            this.pnlEspecialidad.PerformLayout();
            this.pnlAsesor.ResumeLayout(false);
            this.pnlAsesor.PerformLayout();
            this.pnlAlumno.ResumeLayout(false);
            this.pnlAlumno.PerformLayout();
            this.tabGestionAtencion.ResumeLayout(false);
            this.pnlCodigoAtencion.ResumeLayout(false);
            this.pnlCodigoAtencion.PerformLayout();
            this.tabEvento.ResumeLayout(false);
            this.pnlCategoria.ResumeLayout(false);
            this.pnlCategoria.PerformLayout();
            this.tabPlantillaCSV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog archivos;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.TabControl panelGestionHumana;
        private System.Windows.Forms.TabPage tabGestionHumana;
        private System.Windows.Forms.Button btnAlumno;
        private System.Windows.Forms.Label txtHeader;
        private System.Windows.Forms.TabPage tabGestionAtencion;
        private System.Windows.Forms.Button btnAlumnoCSV;
        private System.Windows.Forms.TextBox txtAlumno;
        private System.Windows.Forms.Label lblAlumno;
        private System.Windows.Forms.Panel pnlAlumno;
        private System.Windows.Forms.Label lblAlumnoCSV;
        private System.Windows.Forms.Label lblAlumnoForm;
        private System.Windows.Forms.Panel pnlAsesor;
        private System.Windows.Forms.Label lblAsesor;
        private System.Windows.Forms.Button btnAsesorCSV;
        private System.Windows.Forms.Label lblAsesorCSV;
        private System.Windows.Forms.Label lblAsesorForm;
        private System.Windows.Forms.TextBox txtAsesor;
        private System.Windows.Forms.Button btnAsesor;
        private System.Windows.Forms.Label lblTipoAsesor;
        private System.Windows.Forms.Panel pnlEspecialidad;
        private System.Windows.Forms.Label lblPonente;
        private System.Windows.Forms.Button btnPonente;
        private System.Windows.Forms.Label lblPonenteForm;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnEspecialidad;
        private System.Windows.Forms.Label lblEspecialidadForm;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlCoordinador;
        private System.Windows.Forms.Button btnCoordinador;
        private System.Windows.Forms.Label lblCoordinadorForm;
        private System.Windows.Forms.Label lblCoordinador;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton rbPsicologo;
        private System.Windows.Forms.RadioButton rbProfesor;
        private System.Windows.Forms.Button btnAsesorFile;
        private System.Windows.Forms.Button btnAlumnoFile;
        private System.Windows.Forms.Panel pnlCodigoAtencion;
        private System.Windows.Forms.Button btnCodigoAtencion;
        private System.Windows.Forms.Label lblCodigoAtencionForm;
        private System.Windows.Forms.Label lblCodigoAtencion;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.TabPage tabEvento;
        private System.Windows.Forms.Panel pnlCategoria;
        private System.Windows.Forms.Button btnCategoria;
        private System.Windows.Forms.Label lblCategoriaForm;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TabPage tabPlantillaCSV;
        private System.Windows.Forms.Button btnDescargarPlantilla;
        private System.Windows.Forms.SaveFileDialog guardarPlantilla;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
    }
}