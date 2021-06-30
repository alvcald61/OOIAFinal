
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
            this.btnCargaDatos = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnEventos = new System.Windows.Forms.Button();
            this.txtEventos = new System.Windows.Forms.Label();
            this.btnCitas = new System.Windows.Forms.Button();
            this.txtCitas = new System.Windows.Forms.Label();
            this.pnlCitas = new System.Windows.Forms.Panel();
            this.pnlEventos = new System.Windows.Forms.Panel();
            this.pnlEventosProximos = new System.Windows.Forms.Panel();
            this.pnlEventosProx = new System.Windows.Forms.Panel();
            this.lblEventosProximos = new System.Windows.Forms.Label();
            this.imagenes = new System.Windows.Forms.PictureBox();
            this.ImageTimer = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tarjeta3 = new ProyectoOOIA.Componentes.CardEvento();
            this.tarjeta2 = new ProyectoOOIA.Componentes.CardEvento();
            this.tarjeta1 = new ProyectoOOIA.Componentes.CardEvento();
            this.imagen = new OvalPictureBox();
            this.panel1.SuspendLayout();
            this.pnlCitas.SuspendLayout();
            this.pnlEventos.SuspendLayout();
            this.pnlEventosProximos.SuspendLayout();
            this.pnlEventosProx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).BeginInit();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1352, 87);
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
            this.btnSettings.Location = new System.Drawing.Point(1216, 28);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(47, 42);
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
            this.btnAtras.Location = new System.Drawing.Point(1283, 28);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(47, 42);
            this.btnAtras.TabIndex = 12;
            this.btnAtras.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnCargaDatos
            // 
            this.btnCargaDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(106)))), ((int)(((byte)(145)))));
            this.btnCargaDatos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargaDatos.FlatAppearance.BorderSize = 0;
            this.btnCargaDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargaDatos.ForeColor = System.Drawing.Color.White;
            this.btnCargaDatos.Location = new System.Drawing.Point(935, 21);
            this.btnCargaDatos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCargaDatos.Name = "btnCargaDatos";
            this.btnCargaDatos.Size = new System.Drawing.Size(241, 57);
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
            this.lblUsername.Location = new System.Drawing.Point(139, 27);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(289, 38);
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
            this.btnEventos.Location = new System.Drawing.Point(4, 41);
            this.btnEventos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEventos.Name = "btnEventos";
            this.btnEventos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnEventos.Size = new System.Drawing.Size(449, 210);
            this.btnEventos.TabIndex = 22;
            this.btnEventos.UseVisualStyleBackColor = false;
            this.btnEventos.Click += new System.EventHandler(this.botonEventos_Click);
            // 
            // txtEventos
            // 
            this.txtEventos.AutoSize = true;
            this.txtEventos.Font = new System.Drawing.Font("Gill Sans MT", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventos.ForeColor = System.Drawing.Color.Black;
            this.txtEventos.Location = new System.Drawing.Point(167, 2);
            this.txtEventos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtEventos.Name = "txtEventos";
            this.txtEventos.Size = new System.Drawing.Size(124, 40);
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
            this.btnCitas.Location = new System.Drawing.Point(7, 48);
            this.btnCitas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCitas.Name = "btnCitas";
            this.btnCitas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCitas.Size = new System.Drawing.Size(461, 207);
            this.btnCitas.TabIndex = 21;
            this.btnCitas.UseVisualStyleBackColor = false;
            this.btnCitas.Click += new System.EventHandler(this.botonCitas_Click);
            // 
            // txtCitas
            // 
            this.txtCitas.AutoSize = true;
            this.txtCitas.Font = new System.Drawing.Font("Gill Sans MT", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCitas.ForeColor = System.Drawing.Color.Black;
            this.txtCitas.Location = new System.Drawing.Point(185, 9);
            this.txtCitas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtCitas.Name = "txtCitas";
            this.txtCitas.Size = new System.Drawing.Size(86, 40);
            this.txtCitas.TabIndex = 19;
            this.txtCitas.Text = "Citas";
            this.txtCitas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCitas
            // 
            this.pnlCitas.Controls.Add(this.btnCitas);
            this.pnlCitas.Controls.Add(this.txtCitas);
            this.pnlCitas.Location = new System.Drawing.Point(0, 492);
            this.pnlCitas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlCitas.Name = "pnlCitas";
            this.pnlCitas.Size = new System.Drawing.Size(472, 258);
            this.pnlCitas.TabIndex = 23;
            // 
            // pnlEventos
            // 
            this.pnlEventos.Controls.Add(this.txtEventos);
            this.pnlEventos.Controls.Add(this.btnEventos);
            this.pnlEventos.Location = new System.Drawing.Point(480, 496);
            this.pnlEventos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlEventos.Name = "pnlEventos";
            this.pnlEventos.Size = new System.Drawing.Size(453, 255);
            this.pnlEventos.TabIndex = 24;
            // 
            // pnlEventosProximos
            // 
            this.pnlEventosProximos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(149)))), ((int)(((byte)(199)))));
            this.pnlEventosProximos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEventosProximos.Controls.Add(this.tarjeta3);
            this.pnlEventosProximos.Controls.Add(this.tarjeta2);
            this.pnlEventosProximos.Controls.Add(this.tarjeta1);
            this.pnlEventosProximos.Location = new System.Drawing.Point(935, 101);
            this.pnlEventosProximos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlEventosProximos.Name = "pnlEventosProximos";
            this.pnlEventosProximos.Size = new System.Drawing.Size(415, 649);
            this.pnlEventosProximos.TabIndex = 25;
            // 
            // pnlEventosProx
            // 
            this.pnlEventosProx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(41)))), ((int)(((byte)(71)))));
            this.pnlEventosProx.Controls.Add(this.lblEventosProximos);
            this.pnlEventosProx.Location = new System.Drawing.Point(933, 86);
            this.pnlEventosProx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlEventosProx.Name = "pnlEventosProx";
            this.pnlEventosProx.Size = new System.Drawing.Size(417, 86);
            this.pnlEventosProx.TabIndex = 0;
            // 
            // lblEventosProximos
            // 
            this.lblEventosProximos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEventosProximos.AutoSize = true;
            this.lblEventosProximos.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventosProximos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEventosProximos.Location = new System.Drawing.Point(75, 30);
            this.lblEventosProximos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEventosProximos.Name = "lblEventosProximos";
            this.lblEventosProximos.Size = new System.Drawing.Size(248, 38);
            this.lblEventosProximos.TabIndex = 0;
            this.lblEventosProximos.Text = "Eventos Próximos";
            this.lblEventosProximos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // imagenes
            // 
            this.imagenes.Location = new System.Drawing.Point(0, 86);
            this.imagenes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imagenes.Name = "imagenes";
            this.imagenes.Size = new System.Drawing.Size(933, 409);
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
            // tarjeta3
            // 
            this.tarjeta3.Location = new System.Drawing.Point(-3, 434);
            this.tarjeta3.Margin = new System.Windows.Forms.Padding(5);
            this.tarjeta3.Name = "tarjeta3";
            this.tarjeta3.Size = new System.Drawing.Size(428, 159);
            this.tarjeta3.TabIndex = 3;
            // 
            // tarjeta2
            // 
            this.tarjeta2.Location = new System.Drawing.Point(-1, 258);
            this.tarjeta2.Margin = new System.Windows.Forms.Padding(5);
            this.tarjeta2.Name = "tarjeta2";
            this.tarjeta2.Size = new System.Drawing.Size(412, 159);
            this.tarjeta2.TabIndex = 2;
            // 
            // tarjeta1
            // 
            this.tarjeta1.Location = new System.Drawing.Point(-1, 92);
            this.tarjeta1.Margin = new System.Windows.Forms.Padding(5);
            this.tarjeta1.Name = "tarjeta1";
            this.tarjeta1.Size = new System.Drawing.Size(395, 159);
            this.tarjeta1.TabIndex = 1;
            // 
            // imagen
            // 
            this.imagen.BackColor = System.Drawing.Color.Transparent;
            this.imagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imagen.Location = new System.Drawing.Point(28, 9);
            this.imagen.Margin = new System.Windows.Forms.Padding(4);
            this.imagen.Name = "imagen";
            this.imagen.Size = new System.Drawing.Size(83, 75);
            this.imagen.TabIndex = 27;
            this.imagen.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 752);
            this.Controls.Add(this.pnlEventosProx);
            this.Controls.Add(this.imagenes);
            this.Controls.Add(this.pnlEventosProximos);
            this.Controls.Add(this.pnlEventos);
            this.Controls.Add(this.pnlCitas);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú principal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlCitas.ResumeLayout(false);
            this.pnlCitas.PerformLayout();
            this.pnlEventos.ResumeLayout(false);
            this.pnlEventos.PerformLayout();
            this.pnlEventosProximos.ResumeLayout(false);
            this.pnlEventosProx.ResumeLayout(false);
            this.pnlEventosProx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).EndInit();
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