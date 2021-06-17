
namespace ProyectoOOIA.Ventanas
{
    partial class frmInicioSesion
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
            this.pnlRight = new System.Windows.Forms.Panel();
            this.lblTipoIncorrecto = new System.Windows.Forms.Label();
            this.rbtMiembroOOIA = new System.Windows.Forms.RadioButton();
            this.rbtTutor = new System.Windows.Forms.RadioButton();
            this.rbtAlumno = new System.Windows.Forms.RadioButton();
            this.lblPassIncorrecto = new System.Windows.Forms.Label();
            this.lblOOIA = new System.Windows.Forms.Label();
            this.linkContraseña = new System.Windows.Forms.LinkLabel();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pbPUCP = new System.Windows.Forms.PictureBox();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.lblIncorrecto = new System.Windows.Forms.Label();
            this.pnlRight.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPUCP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(71)))), ((int)(((byte)(123)))));
            this.pnlRight.Controls.Add(this.lblIncorrecto);
            this.pnlRight.Controls.Add(this.lblTipoIncorrecto);
            this.pnlRight.Controls.Add(this.rbtMiembroOOIA);
            this.pnlRight.Controls.Add(this.rbtTutor);
            this.pnlRight.Controls.Add(this.rbtAlumno);
            this.pnlRight.Controls.Add(this.lblPassIncorrecto);
            this.pnlRight.Controls.Add(this.lblOOIA);
            this.pnlRight.Controls.Add(this.linkContraseña);
            this.pnlRight.Controls.Add(this.lblContraseña);
            this.pnlRight.Controls.Add(this.lblUsuario);
            this.pnlRight.Controls.Add(this.txtContraseña);
            this.pnlRight.Controls.Add(this.txtUsuario);
            this.pnlRight.Controls.Add(this.btnIngresar);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(318, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(618, 523);
            this.pnlRight.TabIndex = 8;
            this.pnlRight.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.pnlRight_PreviewKeyDown);
            // 
            // lblTipoIncorrecto
            // 
            this.lblTipoIncorrecto.AutoSize = true;
            this.lblTipoIncorrecto.ForeColor = System.Drawing.Color.Salmon;
            this.lblTipoIncorrecto.Location = new System.Drawing.Point(229, 325);
            this.lblTipoIncorrecto.Name = "lblTipoIncorrecto";
            this.lblTipoIncorrecto.Size = new System.Drawing.Size(146, 13);
            this.lblTipoIncorrecto.TabIndex = 15;
            this.lblTipoIncorrecto.Text = "Seleccione su tipo de usuario";
            this.lblTipoIncorrecto.Visible = false;
            // 
            // rbtMiembroOOIA
            // 
            this.rbtMiembroOOIA.AutoSize = true;
            this.rbtMiembroOOIA.ForeColor = System.Drawing.SystemColors.Control;
            this.rbtMiembroOOIA.Location = new System.Drawing.Point(383, 426);
            this.rbtMiembroOOIA.Name = "rbtMiembroOOIA";
            this.rbtMiembroOOIA.Size = new System.Drawing.Size(94, 17);
            this.rbtMiembroOOIA.TabIndex = 14;
            this.rbtMiembroOOIA.TabStop = true;
            this.rbtMiembroOOIA.Text = "Miembro OOIA";
            this.rbtMiembroOOIA.UseVisualStyleBackColor = true;
            // 
            // rbtTutor
            // 
            this.rbtTutor.AutoSize = true;
            this.rbtTutor.ForeColor = System.Drawing.SystemColors.Control;
            this.rbtTutor.Location = new System.Drawing.Point(247, 426);
            this.rbtTutor.Name = "rbtTutor";
            this.rbtTutor.Size = new System.Drawing.Size(121, 17);
            this.rbtTutor.TabIndex = 13;
            this.rbtTutor.TabStop = true;
            this.rbtTutor.Text = "Profesor o psicólogo";
            this.rbtTutor.UseVisualStyleBackColor = true;
            // 
            // rbtAlumno
            // 
            this.rbtAlumno.AutoSize = true;
            this.rbtAlumno.ForeColor = System.Drawing.SystemColors.Control;
            this.rbtAlumno.Location = new System.Drawing.Point(137, 426);
            this.rbtAlumno.Name = "rbtAlumno";
            this.rbtAlumno.Size = new System.Drawing.Size(60, 17);
            this.rbtAlumno.TabIndex = 12;
            this.rbtAlumno.TabStop = true;
            this.rbtAlumno.Text = "Alumno";
            this.rbtAlumno.UseVisualStyleBackColor = true;
            // 
            // lblPassIncorrecto
            // 
            this.lblPassIncorrecto.AutoSize = true;
            this.lblPassIncorrecto.ForeColor = System.Drawing.Color.Salmon;
            this.lblPassIncorrecto.Location = new System.Drawing.Point(254, 325);
            this.lblPassIncorrecto.Name = "lblPassIncorrecto";
            this.lblPassIncorrecto.Size = new System.Drawing.Size(112, 13);
            this.lblPassIncorrecto.TabIndex = 7;
            this.lblPassIncorrecto.Text = "Contraseña Incorrecta";
            this.lblPassIncorrecto.Visible = false;
            // 
            // lblOOIA
            // 
            this.lblOOIA.AutoSize = true;
            this.lblOOIA.Font = new System.Drawing.Font("Leelawadee", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOOIA.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblOOIA.Location = new System.Drawing.Point(171, 32);
            this.lblOOIA.Name = "lblOOIA";
            this.lblOOIA.Size = new System.Drawing.Size(281, 115);
            this.lblOOIA.TabIndex = 0;
            this.lblOOIA.Text = "OOIA";
            // 
            // linkContraseña
            // 
            this.linkContraseña.ActiveLinkColor = System.Drawing.Color.DarkGray;
            this.linkContraseña.AutoSize = true;
            this.linkContraseña.DisabledLinkColor = System.Drawing.Color.DarkGray;
            this.linkContraseña.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkContraseña.LinkColor = System.Drawing.Color.WhiteSmoke;
            this.linkContraseña.Location = new System.Drawing.Point(244, 462);
            this.linkContraseña.Name = "linkContraseña";
            this.linkContraseña.Size = new System.Drawing.Size(131, 13);
            this.linkContraseña.TabIndex = 6;
            this.linkContraseña.TabStop = true;
            this.linkContraseña.Text = "¿Olvidaste tu contraseña?";
            this.linkContraseña.VisitedLinkColor = System.Drawing.Color.Silver;
            this.linkContraseña.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkContraseña_LinkClicked_1);
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblContraseña.Location = new System.Drawing.Point(129, 269);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(96, 20);
            this.lblContraseña.TabIndex = 2;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUsuario.Location = new System.Drawing.Point(129, 197);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(68, 20);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario:";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(269, 269);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(183, 20);
            this.txtContraseña.TabIndex = 4;
            this.txtContraseña.UseSystemPasswordChar = true;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(269, 199);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(183, 20);
            this.txtUsuario.TabIndex = 3;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnIngresar.Location = new System.Drawing.Point(256, 357);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(99, 36);
            this.btnIngresar.TabIndex = 5;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.button3);
            this.pnlLeft.Controls.Add(this.button2);
            this.pnlLeft.Controls.Add(this.button1);
            this.pnlLeft.Controls.Add(this.pbPUCP);
            this.pnlLeft.Controls.Add(this.pbImagen);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(323, 523);
            this.pnlLeft.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::ProyectoOOIA.Properties.Resources.telephone;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(70, 481);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(23, 23);
            this.button3.TabIndex = 4;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::ProyectoOOIA.Properties.Resources.mobile_phone;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(41, 481);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(23, 23);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::ProyectoOOIA.Properties.Resources.mail;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(12, 481);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 23);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pbPUCP
            // 
            this.pbPUCP.Image = global::ProyectoOOIA.Properties.Resources.PUCP_logo;
            this.pbPUCP.Location = new System.Drawing.Point(66, 24);
            this.pbPUCP.Name = "pbPUCP";
            this.pbPUCP.Size = new System.Drawing.Size(180, 88);
            this.pbPUCP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPUCP.TabIndex = 1;
            this.pbPUCP.TabStop = false;
            // 
            // pbImagen
            // 
            this.pbImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImagen.Image = global::ProyectoOOIA.Properties.Resources.EEGGCC;
            this.pbImagen.Location = new System.Drawing.Point(53, 160);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(207, 211);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 0;
            this.pbImagen.TabStop = false;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter1.Enabled = false;
            this.splitter1.Location = new System.Drawing.Point(323, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1, 523);
            this.splitter1.TabIndex = 9;
            this.splitter1.TabStop = false;
            // 
            // lblIncorrecto
            // 
            this.lblIncorrecto.AutoSize = true;
            this.lblIncorrecto.ForeColor = System.Drawing.Color.Salmon;
            this.lblIncorrecto.Location = new System.Drawing.Point(238, 325);
            this.lblIncorrecto.Name = "lblIncorrecto";
            this.lblIncorrecto.Size = new System.Drawing.Size(130, 13);
            this.lblIncorrecto.TabIndex = 16;
            this.lblIncorrecto.Text = "Tipo de usuario incorrecto";
            this.lblIncorrecto.Visible = false;
            // 
            // frmInicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(936, 523);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.MaximizeBox = false;
            this.Name = "frmInicioSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de Sesion";
            this.Load += new System.EventHandler(this.frmInicioSesion_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmInicioSesion_KeyPress);
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPUCP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion


        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Label lblOOIA;
        private System.Windows.Forms.LinkLabel linkContraseña;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button btnIngresar;

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.PictureBox pbPUCP;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Splitter splitter1;


        private System.Windows.Forms.Label lblPassIncorrecto;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbtMiembroOOIA;
        private System.Windows.Forms.RadioButton rbtTutor;
        private System.Windows.Forms.RadioButton rbtAlumno;
        private System.Windows.Forms.Label lblTipoIncorrecto;
        private System.Windows.Forms.Label lblIncorrecto;
    }
}