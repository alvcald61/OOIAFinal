
namespace ProyectoOOIA.Ventanas
{
    partial class frmReestablecerContraseña
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
            this.lblOOIA = new System.Windows.Forms.Label();
            this.lblIngresarContraseña = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnReestablecer = new System.Windows.Forms.Button();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblOOIA
            // 
            this.lblOOIA.AutoSize = true;
            this.lblOOIA.Font = new System.Drawing.Font("Leelawadee", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOOIA.ForeColor = System.Drawing.Color.White;
            this.lblOOIA.Location = new System.Drawing.Point(144, 46);
            this.lblOOIA.Name = "lblOOIA";
            this.lblOOIA.Size = new System.Drawing.Size(281, 115);
            this.lblOOIA.TabIndex = 1;
            this.lblOOIA.Text = "OOIA";
            // 
            // lblIngresarContraseña
            // 
            this.lblIngresarContraseña.AutoSize = true;
            this.lblIngresarContraseña.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresarContraseña.ForeColor = System.Drawing.Color.White;
            this.lblIngresarContraseña.Location = new System.Drawing.Point(128, 189);
            this.lblIngresarContraseña.Name = "lblIngresarContraseña";
            this.lblIngresarContraseña.Size = new System.Drawing.Size(131, 23);
            this.lblIngresarContraseña.TabIndex = 2;
            this.lblIngresarContraseña.Text = "Ingrese su usuario:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(106)))), ((int)(((byte)(145)))));
            this.btnCancelar.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(200, 311);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(160, 41);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnReestablecer
            // 
            this.btnReestablecer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(106)))), ((int)(((byte)(145)))));
            this.btnReestablecer.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReestablecer.ForeColor = System.Drawing.Color.White;
            this.btnReestablecer.Location = new System.Drawing.Point(201, 264);
            this.btnReestablecer.Name = "btnReestablecer";
            this.btnReestablecer.Size = new System.Drawing.Size(160, 41);
            this.btnReestablecer.TabIndex = 5;
            this.btnReestablecer.Text = "Reestablecer contraseña";
            this.btnReestablecer.UseVisualStyleBackColor = false;
            this.btnReestablecer.Click += new System.EventHandler(this.btnReestablecer_Click);
            // 
            // txtcorreo
            // 
            this.txtcorreo.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcorreo.Location = new System.Drawing.Point(131, 223);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(294, 23);
            this.txtcorreo.TabIndex = 6;
            // 
            // frmReestablecerContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(71)))), ((int)(((byte)(123)))));
            this.ClientSize = new System.Drawing.Size(544, 441);
            this.Controls.Add(this.txtcorreo);
            this.Controls.Add(this.btnReestablecer);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblIngresarContraseña);
            this.Controls.Add(this.lblOOIA);
            this.MaximizeBox = false;
            this.Name = "frmReestablecerContraseña";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reestablecer Contraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOOIA;
        private System.Windows.Forms.Label lblIngresarContraseña;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnReestablecer;
        private System.Windows.Forms.TextBox txtcorreo;
    }
}