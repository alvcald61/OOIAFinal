
namespace ProyectoOOIA.Ventanas
{
    partial class frmAccountSettings
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnEditCorreo = new System.Windows.Forms.PictureBox();
            this.pbPerfil = new System.Windows.Forms.PictureBox();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlImage = new System.Windows.Forms.Panel();
            this.btnImagen = new System.Windows.Forms.Button();
            this.pnlData = new System.Windows.Forms.Panel();
            this.btnEditPassword = new System.Windows.Forms.PictureBox();
            this.btnEditUsuario = new System.Windows.Forms.PictureBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.ofd_Imagen = new System.Windows.Forms.OpenFileDialog();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditCorreo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerfil)).BeginInit();
            this.pnlBody.SuspendLayout();
            this.pnlImage.SuspendLayout();
            this.pnlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(71)))), ((int)(((byte)(123)))));
            this.pnlHeader.Controls.Add(this.btnBack);
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(584, 71);
            this.pnlHeader.TabIndex = 19;
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Image = global::ProyectoOOIA.Properties.Resources.arrowWhite;
            this.btnBack.Location = new System.Drawing.Point(11, 25);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(25, 25);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBack.TabIndex = 21;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHeader.Location = new System.Drawing.Point(53, 25);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(238, 35);
            this.lblHeader.TabIndex = 20;
            this.lblHeader.Text = "Cuenta de Usuario";
            // 
            // btnEditCorreo
            // 
            this.btnEditCorreo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditCorreo.Image = global::ProyectoOOIA.Properties.Resources.edit_black1;
            this.btnEditCorreo.Location = new System.Drawing.Point(263, 166);
            this.btnEditCorreo.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditCorreo.Name = "btnEditCorreo";
            this.btnEditCorreo.Size = new System.Drawing.Size(25, 25);
            this.btnEditCorreo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnEditCorreo.TabIndex = 22;
            this.btnEditCorreo.TabStop = false;
            this.btnEditCorreo.Click += new System.EventHandler(this.btnEditCorreo_Click);
            // 
            // pbPerfil
            // 
            this.pbPerfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPerfil.Location = new System.Drawing.Point(10, 10);
            this.pbPerfil.Margin = new System.Windows.Forms.Padding(10);
            this.pbPerfil.Name = "pbPerfil";
            this.pbPerfil.Size = new System.Drawing.Size(196, 202);
            this.pbPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPerfil.TabIndex = 20;
            this.pbPerfil.TabStop = false;
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.pnlImage);
            this.pnlBody.Controls.Add(this.pnlData);
            this.pnlBody.Location = new System.Drawing.Point(8, 77);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(571, 333);
            this.pnlBody.TabIndex = 21;
            // 
            // pnlImage
            // 
            this.pnlImage.Controls.Add(this.pbPerfil);
            this.pnlImage.Controls.Add(this.btnImagen);
            this.pnlImage.Location = new System.Drawing.Point(4, 3);
            this.pnlImage.Name = "pnlImage";
            this.pnlImage.Size = new System.Drawing.Size(217, 330);
            this.pnlImage.TabIndex = 28;
            // 
            // btnImagen
            // 
            this.btnImagen.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImagen.Location = new System.Drawing.Point(36, 222);
            this.btnImagen.Name = "btnImagen";
            this.btnImagen.Size = new System.Drawing.Size(139, 32);
            this.btnImagen.TabIndex = 26;
            this.btnImagen.Text = "Cambiar Imagen";
            this.btnImagen.UseVisualStyleBackColor = true;
            this.btnImagen.Click += new System.EventHandler(this.btnImagen_Click);
            // 
            // pnlData
            // 
            this.pnlData.Controls.Add(this.btnEditPassword);
            this.pnlData.Controls.Add(this.btnEditUsuario);
            this.pnlData.Controls.Add(this.btnEditCorreo);
            this.pnlData.Controls.Add(this.txtPassword);
            this.pnlData.Controls.Add(this.txtUsuario);
            this.pnlData.Controls.Add(this.txtTipo);
            this.pnlData.Controls.Add(this.txtCorreo);
            this.pnlData.Controls.Add(this.txtNombre);
            this.pnlData.Controls.Add(this.lblNombre);
            this.pnlData.Controls.Add(this.lblTipo);
            this.pnlData.Controls.Add(this.lblUsuario);
            this.pnlData.Controls.Add(this.lblPassword);
            this.pnlData.Controls.Add(this.lblCorreo);
            this.pnlData.Location = new System.Drawing.Point(227, 3);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(341, 330);
            this.pnlData.TabIndex = 27;
            // 
            // btnEditPassword
            // 
            this.btnEditPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditPassword.Image = global::ProyectoOOIA.Properties.Resources.edit_black1;
            this.btnEditPassword.Location = new System.Drawing.Point(213, 292);
            this.btnEditPassword.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditPassword.Name = "btnEditPassword";
            this.btnEditPassword.Size = new System.Drawing.Size(25, 25);
            this.btnEditPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnEditPassword.TabIndex = 32;
            this.btnEditPassword.TabStop = false;
            this.btnEditPassword.Click += new System.EventHandler(this.btnEditPassword_Click);
            // 
            // btnEditUsuario
            // 
            this.btnEditUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditUsuario.Image = global::ProyectoOOIA.Properties.Resources.edit_black1;
            this.btnEditUsuario.Location = new System.Drawing.Point(213, 229);
            this.btnEditUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditUsuario.Name = "btnEditUsuario";
            this.btnEditUsuario.Size = new System.Drawing.Size(25, 25);
            this.btnEditUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnEditUsuario.TabIndex = 31;
            this.btnEditUsuario.TabStop = false;
            this.btnEditUsuario.Click += new System.EventHandler(this.btnEditUsuario_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(8, 292);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(200, 30);
            this.txtPassword.TabIndex = 30;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(8, 229);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(200, 30);
            this.txtUsuario.TabIndex = 29;
            // 
            // txtTipo
            // 
            this.txtTipo.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipo.Location = new System.Drawing.Point(8, 103);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(163, 30);
            this.txtTipo.TabIndex = 28;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(8, 166);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(250, 30);
            this.txtCorreo.TabIndex = 27;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(8, 40);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(300, 30);
            this.txtNombre.TabIndex = 26;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(3, 10);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(79, 27);
            this.lblNombre.TabIndex = 21;
            this.lblNombre.Text = "Nombre";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(3, 73);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(136, 27);
            this.lblTipo.TabIndex = 24;
            this.lblTipo.Text = "Tipo de Usuario";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(3, 199);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(72, 27);
            this.lblUsuario.TabIndex = 22;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(3, 262);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(101, 27);
            this.lblPassword.TabIndex = 23;
            this.lblPassword.Text = "Contraseña";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(3, 136);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(162, 27);
            this.lblCorreo.TabIndex = 25;
            this.lblCorreo.Text = "Correo Electrónico";
            // 
            // ofd_Imagen
            // 
            this.ofd_Imagen.FileName = "openFileDialog1";
            // 
            // frmAccountSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlHeader);
            this.Name = "frmAccountSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Propiedades de Cuenta";
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditCorreo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerfil)).EndInit();
            this.pnlBody.ResumeLayout(false);
            this.pnlImage.ResumeLayout(false);
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.PictureBox pbPerfil;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Panel pnlImage;
        private System.Windows.Forms.Button btnImagen;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.PictureBox btnEditCorreo;
        private System.Windows.Forms.PictureBox btnEditPassword;
        private System.Windows.Forms.PictureBox btnEditUsuario;
        private System.Windows.Forms.OpenFileDialog ofd_Imagen;
    }
}