
namespace ProyectoOOIA.Ventanas
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.imagen = new OvalPictureBox();
            this.btnCargaDatos = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnEventos = new System.Windows.Forms.Button();
            this.txtEventos = new System.Windows.Forms.Label();
            this.btnCitas = new System.Windows.Forms.Button();
            this.txtCitas = new System.Windows.Forms.Label();
            this.pnlCitas = new System.Windows.Forms.Panel();
            this.pnlEventos = new System.Windows.Forms.Panel();
            this.pnlEventosProximos = new System.Windows.Forms.Panel();
            this.tarjeta3 = new ProyectoOOIA.Componentes.CardEvento();
            this.tarjeta2 = new ProyectoOOIA.Componentes.CardEvento();
            this.tarjeta1 = new ProyectoOOIA.Componentes.CardEvento();
            this.pnlEventosProx = new System.Windows.Forms.Panel();
            this.lblEventosProximos = new System.Windows.Forms.Label();
            this.imagenes = new System.Windows.Forms.PictureBox();
            this.ImageTimer = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).BeginInit();
            this.pnlCitas.SuspendLayout();
            this.pnlEventos.SuspendLayout();
            this.pnlEventosProximos.SuspendLayout();
            this.pnlEventosProx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(71)))), ((int)(((byte)(123)))));
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Controls.Add(this.btnAtras);
            this.panel1.Controls.Add(this.imagen);
            this.panel1.Controls.Add(this.btnCargaDatos);
            this.panel1.Controls.Add(this.lblUsername);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1014, 71);
            this.panel1.TabIndex = 18;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSettings.BackgroundImage")));
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(912, 23);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(35, 34);
            this.btnSettings.TabIndex = 28;
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnAccountSettings_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.Transparent;
            this.btnAtras.BackgroundImage = global::ProyectoOOIA.Properties.Resources.logout_white;
            this.btnAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtras.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnAtras.FlatAppearance.BorderSize = 0;
            this.btnAtras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAtras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtras.Location = new System.Drawing.Point(962, 23);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(35, 34);
            this.btnAtras.TabIndex = 12;
            this.btnAtras.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // imagen
            // 
            this.imagen.BackColor = System.Drawing.Color.DarkGray;
            this.imagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imagen.Location = new System.Drawing.Point(21, 7);
            this.imagen.Name = "imagen";
            this.imagen.Size = new System.Drawing.Size(62, 61);
            this.imagen.TabIndex = 27;
            this.imagen.TabStop = false;
            // 
            // btnCargaDatos
            // 
            this.btnCargaDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(106)))), ((int)(((byte)(145)))));
            this.btnCargaDatos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargaDatos.FlatAppearance.BorderSize = 0;
            this.btnCargaDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargaDatos.ForeColor = System.Drawing.Color.White;
            this.btnCargaDatos.Location = new System.Drawing.Point(701, 17);
            this.btnCargaDatos.Name = "btnCargaDatos";
            this.btnCargaDatos.Size = new System.Drawing.Size(181, 46);
            this.btnCargaDatos.TabIndex = 13;
            this.btnCargaDatos.Text = "Gestionar Información";
            this.btnCargaDatos.UseVisualStyleBackColor = false;
            this.btnCargaDatos.Click += new System.EventHandler(this.btnCargaDatos_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(104, 22);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(224, 30);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Solorzano Tapia, José";
            // 
            // btnEventos
            // 
            this.btnEventos.BackColor = System.Drawing.Color.Transparent;
            this.btnEventos.BackgroundImage = global::ProyectoOOIA.Properties.Resources.Evento;
            this.btnEventos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEventos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEventos.FlatAppearance.BorderSize = 0;
            this.btnEventos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEventos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEventos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEventos.Location = new System.Drawing.Point(3, 33);
            this.btnEventos.Name = "btnEventos";
            this.btnEventos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnEventos.Size = new System.Drawing.Size(337, 171);
            this.btnEventos.TabIndex = 22;
            this.btnEventos.UseVisualStyleBackColor = false;
            this.btnEventos.Click += new System.EventHandler(this.botonEventos_Click);
            // 
            // txtEventos
            // 
            this.txtEventos.AutoSize = true;
            this.txtEventos.Font = new System.Drawing.Font("Gill Sans MT", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventos.ForeColor = System.Drawing.Color.Black;
            this.txtEventos.Location = new System.Drawing.Point(125, 2);
            this.txtEventos.Name = "txtEventos";
            this.txtEventos.Size = new System.Drawing.Size(101, 33);
            this.txtEventos.TabIndex = 20;
            this.txtEventos.Text = "Eventos";
            // 
            // btnCitas
            // 
            this.btnCitas.AccessibleDescription = "Hola cliente";
            this.btnCitas.AccessibleName = "hola";
            this.btnCitas.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btnCitas.BackColor = System.Drawing.Color.Transparent;
            this.btnCitas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCitas.BackgroundImage")));
            this.btnCitas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCitas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCitas.FlatAppearance.BorderSize = 0;
            this.btnCitas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCitas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCitas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCitas.Location = new System.Drawing.Point(5, 39);
            this.btnCitas.Name = "btnCitas";
            this.btnCitas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCitas.Size = new System.Drawing.Size(346, 168);
            this.btnCitas.TabIndex = 21;
            this.btnCitas.UseVisualStyleBackColor = false;
            this.btnCitas.Click += new System.EventHandler(this.botonCitas_Click);
            // 
            // txtCitas
            // 
            this.txtCitas.AutoSize = true;
            this.txtCitas.Font = new System.Drawing.Font("Gill Sans MT", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCitas.ForeColor = System.Drawing.Color.Black;
            this.txtCitas.Location = new System.Drawing.Point(139, 7);
            this.txtCitas.Name = "txtCitas";
            this.txtCitas.Size = new System.Drawing.Size(70, 33);
            this.txtCitas.TabIndex = 19;
            this.txtCitas.Text = "Citas";
            this.txtCitas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCitas
            // 
            this.pnlCitas.Controls.Add(this.btnCitas);
            this.pnlCitas.Controls.Add(this.txtCitas);
            this.pnlCitas.Location = new System.Drawing.Point(0, 400);
            this.pnlCitas.Name = "pnlCitas";
            this.pnlCitas.Size = new System.Drawing.Size(354, 210);
            this.pnlCitas.TabIndex = 23;
            // 
            // pnlEventos
            // 
            this.pnlEventos.Controls.Add(this.txtEventos);
            this.pnlEventos.Controls.Add(this.btnEventos);
            this.pnlEventos.Location = new System.Drawing.Point(360, 403);
            this.pnlEventos.Name = "pnlEventos";
            this.pnlEventos.Size = new System.Drawing.Size(340, 207);
            this.pnlEventos.TabIndex = 24;
            // 
            // pnlEventosProximos
            // 
            this.pnlEventosProximos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(149)))), ((int)(((byte)(199)))));
            this.pnlEventosProximos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEventosProximos.Controls.Add(this.tarjeta3);
            this.pnlEventosProximos.Controls.Add(this.tarjeta2);
            this.pnlEventosProximos.Controls.Add(this.tarjeta1);
            this.pnlEventosProximos.Location = new System.Drawing.Point(701, 82);
            this.pnlEventosProximos.Name = "pnlEventosProximos";
            this.pnlEventosProximos.Size = new System.Drawing.Size(312, 528);
            this.pnlEventosProximos.TabIndex = 25;
            // 
            // tarjeta3
            // 
            this.tarjeta3.Location = new System.Drawing.Point(-2, 353);
            this.tarjeta3.Name = "tarjeta3";
            this.tarjeta3.Size = new System.Drawing.Size(321, 129);
            this.tarjeta3.TabIndex = 3;
            // 
            // tarjeta2
            // 
            this.tarjeta2.Location = new System.Drawing.Point(-1, 210);
            this.tarjeta2.Name = "tarjeta2";
            this.tarjeta2.Size = new System.Drawing.Size(309, 129);
            this.tarjeta2.TabIndex = 2;
            // 
            // tarjeta1
            // 
            this.tarjeta1.Location = new System.Drawing.Point(-1, 75);
            this.tarjeta1.Name = "tarjeta1";
            this.tarjeta1.Size = new System.Drawing.Size(296, 129);
            this.tarjeta1.TabIndex = 1;
            // 
            // pnlEventosProx
            // 
            this.pnlEventosProx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(41)))), ((int)(((byte)(71)))));
            this.pnlEventosProx.Controls.Add(this.lblEventosProximos);
            this.pnlEventosProx.Location = new System.Drawing.Point(700, 70);
            this.pnlEventosProx.Name = "pnlEventosProx";
            this.pnlEventosProx.Size = new System.Drawing.Size(313, 70);
            this.pnlEventosProx.TabIndex = 0;
            // 
            // lblEventosProximos
            // 
            this.lblEventosProximos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEventosProximos.AutoSize = true;
            this.lblEventosProximos.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventosProximos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEventosProximos.Location = new System.Drawing.Point(56, 24);
            this.lblEventosProximos.Name = "lblEventosProximos";
            this.lblEventosProximos.Size = new System.Drawing.Size(191, 30);
            this.lblEventosProximos.TabIndex = 0;
            this.lblEventosProximos.Text = "Eventos Próximos";
            this.lblEventosProximos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // imagenes
            // 
            this.imagenes.Location = new System.Drawing.Point(0, 70);
            this.imagenes.Name = "imagenes";
            this.imagenes.Size = new System.Drawing.Size(700, 332);
            this.imagenes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagenes.TabIndex = 26;
            this.imagenes.TabStop = false;
            // 
            // ImageTimer
            // 
            this.ImageTimer.Enabled = true;
            this.ImageTimer.Interval = 5000;
            this.ImageTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "EEGGCC.jpg");
            this.imageList1.Images.SetKeyName(1, "Estudiante.png");
            this.imageList1.Images.SetKeyName(2, "foto-29.jpg");
            this.imageList1.Images.SetKeyName(3, "pexels-pixabay-261621.jpg");
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 611);
            this.Controls.Add(this.pnlEventosProx);
            this.Controls.Add(this.imagenes);
            this.Controls.Add(this.pnlEventosProximos);
            this.Controls.Add(this.pnlEventos);
            this.Controls.Add(this.pnlCitas);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú principal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).EndInit();
            this.pnlCitas.ResumeLayout(false);
            this.pnlCitas.PerformLayout();
            this.pnlEventos.ResumeLayout(false);
            this.pnlEventos.PerformLayout();
            this.pnlEventosProximos.ResumeLayout(false);
            this.pnlEventosProx.ResumeLayout(false);
            this.pnlEventosProx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnEventos;
        private System.Windows.Forms.Label txtEventos;
        private System.Windows.Forms.Button btnCitas;
        private System.Windows.Forms.Label txtCitas;
        private System.Windows.Forms.Panel pnlCitas;
        private System.Windows.Forms.Panel pnlEventos;
        private System.Windows.Forms.Panel pnlEventosProximos;
        private System.Windows.Forms.Panel pnlEventosProx;
        private System.Windows.Forms.Label lblEventosProximos;
        private System.Windows.Forms.PictureBox imagenes;
        private System.Windows.Forms.Timer ImageTimer;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnCargaDatos;
        private Componentes.CardEvento tarjeta3;
        private Componentes.CardEvento tarjeta2;
        private Componentes.CardEvento tarjeta1;
        private OvalPictureBox imagen;
        private System.Windows.Forms.Button btnSettings;
    }
}