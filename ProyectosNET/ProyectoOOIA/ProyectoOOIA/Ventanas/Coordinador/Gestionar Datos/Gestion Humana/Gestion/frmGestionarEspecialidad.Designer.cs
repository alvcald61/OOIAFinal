
namespace ProyectoOOIA.Ventanas.Miembro_OOIA.Cargar_Datos.Gestion_Humana
{
    partial class frmGestionarEspecialidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionarEspecialidad));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.tsEspecialidad = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsbModificar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.tsbCancelar = new System.Windows.Forms.ToolStripButton();
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.lblLista = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgvEspecialidad = new System.Windows.Forms.DataGridView();
            this.id_especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtId_especialidad = new System.Windows.Forms.TextBox();
            this.lblId_especialidad = new System.Windows.Forms.Label();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.tsEspecialidad.SuspendLayout();
            this.pnlDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecialidad)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(71)))), ((int)(((byte)(123)))));
            this.pnlHeader.Controls.Add(this.btnBack);
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(744, 70);
            this.pnlHeader.TabIndex = 2;
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
            // lblHeader
            // 
            this.lblHeader.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHeader.Location = new System.Drawing.Point(66, 28);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(238, 35);
            this.lblHeader.TabIndex = 2;
            this.lblHeader.Text = "Gestionar Especialidades";
            // 
            // tsEspecialidad
            // 
            this.tsEspecialidad.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbGuardar,
            this.tsbModificar,
            this.tsbEliminar,
            this.tsbCancelar});
            this.tsEspecialidad.Location = new System.Drawing.Point(0, 70);
            this.tsEspecialidad.Name = "tsEspecialidad";
            this.tsEspecialidad.Size = new System.Drawing.Size(744, 25);
            this.tsEspecialidad.TabIndex = 3;
            this.tsEspecialidad.Text = "tsAlumno";
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNuevo.Image")));
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(62, 22);
            this.tsbNuevo.Text = "&Nuevo";
            this.tsbNuevo.ToolTipText = "&Nuevo";
            this.tsbNuevo.Click += new System.EventHandler(this.tsbNuevo_Click);
            // 
            // tsbGuardar
            // 
            this.tsbGuardar.Image = ((System.Drawing.Image)(resources.GetObject("tsbGuardar.Image")));
            this.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGuardar.Name = "tsbGuardar";
            this.tsbGuardar.Size = new System.Drawing.Size(69, 22);
            this.tsbGuardar.Text = "&Guardar";
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
            // tsbCancelar
            // 
            this.tsbCancelar.Image = global::ProyectoOOIA.Properties.Resources.Cancel_16x;
            this.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancelar.Name = "tsbCancelar";
            this.tsbCancelar.Size = new System.Drawing.Size(73, 22);
            this.tsbCancelar.Text = "Cancelar";
            this.tsbCancelar.Click += new System.EventHandler(this.tsbCancelar_Click);
            // 
            // pnlDatos
            // 
            this.pnlDatos.Controls.Add(this.btnBuscar);
            this.pnlDatos.Controls.Add(this.lblBuscar);
            this.pnlDatos.Controls.Add(this.lblLista);
            this.pnlDatos.Controls.Add(this.textBox1);
            this.pnlDatos.Controls.Add(this.dgvEspecialidad);
            this.pnlDatos.Controls.Add(this.txtNombre);
            this.pnlDatos.Controls.Add(this.lblNombre);
            this.pnlDatos.Controls.Add(this.txtId_especialidad);
            this.pnlDatos.Controls.Add(this.lblId_especialidad);
            this.pnlDatos.Controls.Add(this.lblEspecialidad);
            this.pnlDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDatos.Location = new System.Drawing.Point(0, 95);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(744, 296);
            this.pnlDatos.TabIndex = 4;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(462, 119);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 24;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(12, 121);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(123, 21);
            this.lblBuscar.TabIndex = 23;
            this.lblBuscar.Text = "Ingrese el nombre:";
            // 
            // lblLista
            // 
            this.lblLista.AutoSize = true;
            this.lblLista.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLista.Location = new System.Drawing.Point(12, 91);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(212, 27);
            this.lblLista.TabIndex = 22;
            this.lblLista.Text = "Lista de Especialidades";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(160, 121);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(292, 20);
            this.textBox1.TabIndex = 21;
            // 
            // dgvEspecialidad
            // 
            this.dgvEspecialidad.AllowUserToAddRows = false;
            this.dgvEspecialidad.AllowUserToDeleteRows = false;
            this.dgvEspecialidad.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEspecialidad.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEspecialidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEspecialidad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_especialidad,
            this.nombre});
            this.dgvEspecialidad.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvEspecialidad.EnableHeadersVisualStyles = false;
            this.dgvEspecialidad.Location = new System.Drawing.Point(17, 147);
            this.dgvEspecialidad.Name = "dgvEspecialidad";
            this.dgvEspecialidad.RowHeadersVisible = false;
            this.dgvEspecialidad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEspecialidad.Size = new System.Drawing.Size(520, 138);
            this.dgvEspecialidad.TabIndex = 20;
            // 
            // id_especialidad
            // 
            this.id_especialidad.DataPropertyName = "id_especialidad";
            this.id_especialidad.HeaderText = "Id";
            this.id_especialidad.Name = "id_especialidad";
            this.id_especialidad.Width = 80;
            // 
            // nombre
            // 
            this.nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre de la especialidad";
            this.nombre.Name = "nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(160, 64);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(292, 20);
            this.txtNombre.TabIndex = 19;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(12, 61);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(139, 21);
            this.lblNombre.TabIndex = 18;
            this.lblNombre.Text = "Nombre Especialidad";
            // 
            // txtId_especialidad
            // 
            this.txtId_especialidad.Location = new System.Drawing.Point(160, 38);
            this.txtId_especialidad.Name = "txtId_especialidad";
            this.txtId_especialidad.Size = new System.Drawing.Size(81, 20);
            this.txtId_especialidad.TabIndex = 17;
            // 
            // lblId_especialidad
            // 
            this.lblId_especialidad.AutoSize = true;
            this.lblId_especialidad.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId_especialidad.Location = new System.Drawing.Point(12, 36);
            this.lblId_especialidad.Name = "lblId_especialidad";
            this.lblId_especialidad.Size = new System.Drawing.Size(99, 21);
            this.lblId_especialidad.TabIndex = 16;
            this.lblId_especialidad.Text = "Id Especialidad";
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecialidad.Location = new System.Drawing.Point(12, 9);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(120, 27);
            this.lblEspecialidad.TabIndex = 9;
            this.lblEspecialidad.Text = "Especialidad";
            // 
            // frmGestionarEspecialidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 401);
            this.Controls.Add(this.pnlDatos);
            this.Controls.Add(this.tsEspecialidad);
            this.Controls.Add(this.pnlHeader);
            this.Name = "frmGestionarEspecialidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestionar Especialidades";
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.tsEspecialidad.ResumeLayout(false);
            this.tsEspecialidad.PerformLayout();
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecialidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.ToolStrip tsEspecialidad;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbModificar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.ToolStripButton tsbCancelar;
        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtId_especialidad;
        private System.Windows.Forms.Label lblId_especialidad;
        private System.Windows.Forms.Label lblLista;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgvEspecialidad;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_especialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
    }
}