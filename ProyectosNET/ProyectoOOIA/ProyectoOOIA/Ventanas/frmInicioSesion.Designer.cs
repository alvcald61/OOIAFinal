
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
            this.lblPassIncorrecto = new System.Windows.Forms.Label();
            this.lblOOIA = new System.Windows.Forms.Label();
            this.linkContraseña = new System.Windows.Forms.LinkLabel();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pbPUCP = new System.Windows.Forms.PictureBox();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pnlRight.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPUCP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(71)))), ((int)(((byte)(123)))));
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
            // 
            // lblPassIncorrecto
            // 
            this.lblPassIncorrecto.AutoSize = true;
            this.lblPassIncorrecto.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassIncorrecto.ForeColor = System.Drawing.Color.Salmon;
            this.lblPassIncorrecto.Location = new System.Drawing.Point(201, 315);
            this.lblPassIncorrecto.Name = "lblPassIncorrecto";
            this.lblPassIncorrecto.Size = new System.Drawing.Size(231, 23);
            this.lblPassIncorrecto.TabIndex = 7;
            this.lblPassIncorrecto.Text = "Usuarui y/o contraseña Incorrecta";
            this.lblPassIncorrecto.Visible = false;
            // 
            // lblOOIA
            // 
            this.lblOOIA.AutoSize = true;
            this.lblOOIA.Font = new System.Drawing.Font("Leelawadee", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOOIA.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblOOIA.Location = new System.Drawing.Point(171, 44);
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
            this.linkContraseña.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkContraseña.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkContraseña.LinkColor = System.Drawing.Color.WhiteSmoke;
            this.linkContraseña.Location = new System.Drawing.Point(233, 406);
            this.linkContraseña.Name = "linkContraseña";
            this.linkContraseña.Size = new System.Drawing.Size(174, 23);
            this.linkContraseña.TabIndex = 6;
            this.linkContraseña.TabStop = true;
            this.linkContraseña.Text = "¿Olvidaste tu contraseña?";
            this.linkContraseña.VisitedLinkColor = System.Drawing.Color.Silver;
            this.linkContraseña.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkContraseña_LinkClicked_1);
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblContraseña.Location = new System.Drawing.Point(129, 269);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(102, 23);
            this.lblContraseña.TabIndex = 2;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUsuario.Location = new System.Drawing.Point(129, 204);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(73, 23);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario:";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(269, 266);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(183, 26);
            this.txtContraseña.TabIndex = 4;
            this.txtContraseña.UseSystemPasswordChar = true;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(269, 199);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(183, 26);
            this.txtUsuario.TabIndex = 3;
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(106)))), ((int)(((byte)(145)))));
            this.btnIngresar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.Location = new System.Drawing.Point(253, 357);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(133, 36);
            this.btnIngresar.TabIndex = 5;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.pbPUCP);
            this.pnlLeft.Controls.Add(this.pbImagen);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(323, 523);
            this.pnlLeft.TabIndex = 0;
            // 
            // pbPUCP
            // 
            this.pbPUCP.Image = global::ProyectoOOIA.Properties.Resources.PUCP_logo;
            this.pbPUCP.Location = new System.Drawing.Point(28, 24);
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
            this.pbImagen.Location = new System.Drawing.Point(28, 160);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(250, 200);
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
    }
}