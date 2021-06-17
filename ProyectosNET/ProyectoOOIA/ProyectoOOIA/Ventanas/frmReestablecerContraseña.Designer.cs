
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
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnReestablecer = new System.Windows.Forms.Button();
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
            this.lblIngresarContraseña.ForeColor = System.Drawing.Color.White;
            this.lblIngresarContraseña.Location = new System.Drawing.Point(128, 189);
            this.lblIngresarContraseña.Name = "lblIngresarContraseña";
            this.lblIngresarContraseña.Size = new System.Drawing.Size(147, 13);
            this.lblIngresarContraseña.TabIndex = 2;
            this.lblIngresarContraseña.Text = "Ingrese su correo electronico:";
            // 
            // txtContraseña
            // 
            this.txtContraseña.AccessibleName = "";
            this.txtContraseña.Location = new System.Drawing.Point(131, 219);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(284, 20);
            this.txtContraseña.TabIndex = 3;
            this.txtContraseña.UseWaitCursor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Leelawadee", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(201, 311);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(143, 41);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnReestablecer
            // 
            this.btnReestablecer.Font = new System.Drawing.Font("Leelawadee", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReestablecer.Location = new System.Drawing.Point(201, 264);
            this.btnReestablecer.Name = "btnReestablecer";
            this.btnReestablecer.Size = new System.Drawing.Size(143, 41);
            this.btnReestablecer.TabIndex = 5;
            this.btnReestablecer.Text = "Reestablecer contraseña";
            this.btnReestablecer.UseVisualStyleBackColor = true;
            this.btnReestablecer.Click += new System.EventHandler(this.btnReestablecer_Click);
            // 
            // frmReestablecerContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(71)))), ((int)(((byte)(123)))));
            this.ClientSize = new System.Drawing.Size(547, 450);
            this.Controls.Add(this.btnReestablecer);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtContraseña);
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
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnReestablecer;
    }
}