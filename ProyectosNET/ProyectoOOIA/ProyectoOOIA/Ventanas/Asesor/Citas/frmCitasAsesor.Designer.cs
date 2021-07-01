
namespace ProyectoOOIA.Ventanas
{
    partial class frmHorarioAsesor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHorarioAsesor));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnHorario = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.lblHorario = new System.Windows.Forms.Label();
            this.dgvHorarioProf = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnModificarHorario = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.btnMostrarDetalles = new System.Windows.Forms.Button();
            this.lblFechaHora = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTipoHorario = new System.Windows.Forms.ComboBox();
            this.lblTipoHorario = new System.Windows.Forms.Label();
            this.btnBuscarHorario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbFecha = new System.Windows.Forms.RadioButton();
            this.rbTipoNombre = new System.Windows.Forms.RadioButton();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorarioProf)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(71)))), ((int)(((byte)(123)))));
            this.pnlHeader.Controls.Add(this.btnHorario);
            this.pnlHeader.Controls.Add(this.btnLogout);
            this.pnlHeader.Controls.Add(this.btnHome);
            this.pnlHeader.Controls.Add(this.lblHorario);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1352, 87);
            this.pnlHeader.TabIndex = 2;
            // 
            // btnHorario
            // 
            this.btnHorario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(71)))), ((int)(((byte)(123)))));
            this.btnHorario.FlatAppearance.BorderSize = 0;
            this.btnHorario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHorario.ForeColor = System.Drawing.Color.White;
            this.btnHorario.Location = new System.Drawing.Point(1097, 15);
            this.btnHorario.Margin = new System.Windows.Forms.Padding(4);
            this.btnHorario.Name = "btnHorario";
            this.btnHorario.Size = new System.Drawing.Size(149, 65);
            this.btnHorario.TabIndex = 11;
            this.btnHorario.Text = "Registrar Horario";
            this.btnHorario.UseVisualStyleBackColor = false;
            this.btnHorario.Click += new System.EventHandler(this.button1_Click);
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
            this.btnLogout.Location = new System.Drawing.Point(1289, 38);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(47, 42);
            this.btnLogout.TabIndex = 14;
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnHome
            // 
            this.btnHome.Image = global::ProyectoOOIA.Properties.Resources.arrowWhite;
            this.btnHome.Location = new System.Drawing.Point(17, 37);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(33, 31);
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
            this.lblHorario.Location = new System.Drawing.Point(56, 37);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(251, 38);
            this.lblHorario.TabIndex = 0;
            this.lblHorario.Text = "Horario de Atención";
            // 
            // dgvHorarioProf
            // 
            this.dgvHorarioProf.AllowUserToAddRows = false;
            this.dgvHorarioProf.AllowUserToDeleteRows = false;
            this.dgvHorarioProf.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHorarioProf.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHorarioProf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHorarioProf.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.Hora,
            this.Especialidad,
            this.Nombre,
            this.Estado,
            this.Correo});
            this.dgvHorarioProf.EnableHeadersVisualStyles = false;
            this.dgvHorarioProf.Location = new System.Drawing.Point(28, 204);
            this.dgvHorarioProf.Margin = new System.Windows.Forms.Padding(4);
            this.dgvHorarioProf.Name = "dgvHorarioProf";
            this.dgvHorarioProf.ReadOnly = true;
            this.dgvHorarioProf.RowHeadersWidth = 51;
            this.dgvHorarioProf.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHorarioProf.Size = new System.Drawing.Size(1308, 533);
            this.dgvHorarioProf.TabIndex = 0;
            this.dgvHorarioProf.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvHorarioProf_CellFormatting);
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
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 125;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo ";
            this.Correo.MinimumWidth = 6;
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            this.Correo.Width = 150;
            // 
            // btnModificarHorario
            // 
            this.btnModificarHorario.Location = new System.Drawing.Point(1236, 168);
            this.btnModificarHorario.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificarHorario.Name = "btnModificarHorario";
            this.btnModificarHorario.Size = new System.Drawing.Size(100, 28);
            this.btnModificarHorario.TabIndex = 1;
            this.btnModificarHorario.Text = "Cancelar";
            this.btnModificarHorario.UseVisualStyleBackColor = true;
            this.btnModificarHorario.Click += new System.EventHandler(this.btnModificarHorario_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(14, 29);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(265, 22);
            this.dtpFecha.TabIndex = 3;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(538, 29);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(4);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(301, 22);
            this.tbNombre.TabIndex = 4;
            // 
            // btnMostrarDetalles
            // 
            this.btnMostrarDetalles.Location = new System.Drawing.Point(1128, 168);
            this.btnMostrarDetalles.Margin = new System.Windows.Forms.Padding(4);
            this.btnMostrarDetalles.Name = "btnMostrarDetalles";
            this.btnMostrarDetalles.Size = new System.Drawing.Size(100, 28);
            this.btnMostrarDetalles.TabIndex = 5;
            this.btnMostrarDetalles.Text = "Detalles";
            this.btnMostrarDetalles.UseVisualStyleBackColor = true;
            this.btnMostrarDetalles.Click += new System.EventHandler(this.btnMostrarDetalles_Click);
            // 
            // lblFechaHora
            // 
            this.lblFechaHora.AutoSize = true;
            this.lblFechaHora.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHora.Location = new System.Drawing.Point(46, 135);
            this.lblFechaHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaHora.Name = "lblFechaHora";
            this.lblFechaHora.Size = new System.Drawing.Size(56, 27);
            this.lblFechaHora.TabIndex = 6;
            this.lblFechaHora.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(561, 133);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 27);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre del alumno";
            // 
            // cbTipoHorario
            // 
            this.cbTipoHorario.FormattingEnabled = true;
            this.cbTipoHorario.Location = new System.Drawing.Point(370, 29);
            this.cbTipoHorario.Margin = new System.Windows.Forms.Padding(4);
            this.cbTipoHorario.Name = "cbTipoHorario";
            this.cbTipoHorario.Size = new System.Drawing.Size(160, 24);
            this.cbTipoHorario.TabIndex = 8;
            // 
            // lblTipoHorario
            // 
            this.lblTipoHorario.AutoSize = true;
            this.lblTipoHorario.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoHorario.Location = new System.Drawing.Point(393, 133);
            this.lblTipoHorario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoHorario.Name = "lblTipoHorario";
            this.lblTipoHorario.Size = new System.Drawing.Size(138, 27);
            this.lblTipoHorario.TabIndex = 9;
            this.lblTipoHorario.Text = "Tipo de Horario";
            // 
            // btnBuscarHorario
            // 
            this.btnBuscarHorario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarHorario.BackgroundImage")));
            this.btnBuscarHorario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarHorario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarHorario.Location = new System.Drawing.Point(943, 156);
            this.btnBuscarHorario.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarHorario.Name = "btnBuscarHorario";
            this.btnBuscarHorario.Size = new System.Drawing.Size(40, 32);
            this.btnBuscarHorario.TabIndex = 10;
            this.btnBuscarHorario.UseVisualStyleBackColor = true;
            this.btnBuscarHorario.Click += new System.EventHandler(this.btnBuscarHorario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 27);
            this.label1.TabIndex = 13;
            this.label1.Text = "Seleccione el tipo de búsqueda:";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(28, 204);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(883, 29);
            this.panel1.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbTipoNombre);
            this.groupBox1.Controls.Add(this.dtpFecha);
            this.groupBox1.Controls.Add(this.rbFecha);
            this.groupBox1.Controls.Add(this.cbTipoHorario);
            this.groupBox1.Controls.Add(this.tbNombre);
            this.groupBox1.Location = new System.Drawing.Point(28, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(883, 61);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // rbFecha
            // 
            this.rbFecha.AutoSize = true;
            this.rbFecha.Location = new System.Drawing.Point(286, 32);
            this.rbFecha.Name = "rbFecha";
            this.rbFecha.Size = new System.Drawing.Size(17, 16);
            this.rbFecha.TabIndex = 13;
            this.rbFecha.TabStop = true;
            this.rbFecha.UseVisualStyleBackColor = true;
            // 
            // rbTipoNombre
            // 
            this.rbTipoNombre.AutoSize = true;
            this.rbTipoNombre.Location = new System.Drawing.Point(846, 32);
            this.rbTipoNombre.Name = "rbTipoNombre";
            this.rbTipoNombre.Size = new System.Drawing.Size(17, 16);
            this.rbTipoNombre.TabIndex = 14;
            this.rbTipoNombre.TabStop = true;
            this.rbTipoNombre.UseVisualStyleBackColor = true;
            // 
            // frmHorarioAsesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 752);
            this.Controls.Add(this.lblFechaHora);
            this.Controls.Add(this.lblTipoHorario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscarHorario);
            this.Controls.Add(this.btnMostrarDetalles);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.btnModificarHorario);
            this.Controls.Add(this.dgvHorarioProf);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmHorarioAsesor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Horario";
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
        private System.Windows.Forms.Button btnModificarHorario;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Button btnMostrarDetalles;
        private System.Windows.Forms.Label lblFechaHora;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTipoHorario;
        private System.Windows.Forms.Label lblTipoHorario;
        private System.Windows.Forms.Button btnBuscarHorario;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.Button btnHorario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbTipoNombre;
        private System.Windows.Forms.RadioButton rbFecha;
    }
}