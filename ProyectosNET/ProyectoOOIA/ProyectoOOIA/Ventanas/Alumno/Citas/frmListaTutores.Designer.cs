
using System.Windows.Forms;

namespace ProyectoOOIA.Ventanas
{
    partial class frmListaTutores
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAtras = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabTutor = new System.Windows.Forms.TabPage();
            this.pnlTutorRight = new System.Windows.Forms.Panel();
            this.pnlTutorLeft = new System.Windows.Forms.Panel();
            this.tabPsic = new System.Windows.Forms.TabPage();
            this.pnlPsicRight = new System.Windows.Forms.Panel();
            this.pnlPsicLeft = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabTutor.SuspendLayout();
            this.tabPsic.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(71)))), ((int)(((byte)(123)))));
            this.panel1.Controls.Add(this.btnAtras);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(936, 71);
            this.panel1.TabIndex = 0;
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.Transparent;
            this.btnAtras.BackgroundImage = global::ProyectoOOIA.Properties.Resources.arrowWhite;
            this.btnAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtras.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnAtras.FlatAppearance.BorderSize = 0;
            this.btnAtras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAtras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtras.Location = new System.Drawing.Point(12, 26);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(31, 34);
            this.btnAtras.TabIndex = 13;
            this.btnAtras.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(58, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de tutores y psicólogos";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabTutor);
            this.tabControl.Controls.Add(this.tabPsic);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 71);
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Drawing.Point(6, 10);
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(936, 459);
            this.tabControl.TabIndex = 1;
            // 
            // tabTutor
            // 
            this.tabTutor.AutoScrollMargin = new System.Drawing.Size(0, 200);
            this.tabTutor.BackColor = System.Drawing.SystemColors.Control;
            this.tabTutor.Controls.Add(this.pnlTutorRight);
            this.tabTutor.Controls.Add(this.pnlTutorLeft);
            this.tabTutor.Location = new System.Drawing.Point(4, 36);
            this.tabTutor.Name = "tabTutor";
            this.tabTutor.Padding = new System.Windows.Forms.Padding(3);
            this.tabTutor.Size = new System.Drawing.Size(928, 419);
            this.tabTutor.TabIndex = 0;
            this.tabTutor.Text = "Tutores";
            // 
            // pnlTutorRight
            // 
            this.pnlTutorRight.AutoSize = true;
            this.pnlTutorRight.Location = new System.Drawing.Point(520, 73);
            this.pnlTutorRight.Name = "pnlTutorRight";
            this.pnlTutorRight.Size = new System.Drawing.Size(400, 338);
            this.pnlTutorRight.TabIndex = 1;
            // 
            // pnlTutorLeft
            // 
            this.pnlTutorLeft.AutoSize = true;
            this.pnlTutorLeft.Location = new System.Drawing.Point(8, 73);
            this.pnlTutorLeft.Name = "pnlTutorLeft";
            this.pnlTutorLeft.Size = new System.Drawing.Size(400, 338);
            this.pnlTutorLeft.TabIndex = 0;
            // 
            // tabPsic
            // 
            this.tabPsic.Controls.Add(this.pnlPsicRight);
            this.tabPsic.Controls.Add(this.pnlPsicLeft);
            this.tabPsic.Location = new System.Drawing.Point(4, 36);
            this.tabPsic.Name = "tabPsic";
            this.tabPsic.Padding = new System.Windows.Forms.Padding(3);
            this.tabPsic.Size = new System.Drawing.Size(928, 419);
            this.tabPsic.TabIndex = 1;
            this.tabPsic.Text = "Psicólogos";
            this.tabPsic.UseVisualStyleBackColor = true;
            // 
            // pnlPsicRight
            // 
            this.pnlPsicRight.AutoSize = true;
            this.pnlPsicRight.Location = new System.Drawing.Point(520, 85);
            this.pnlPsicRight.Name = "pnlPsicRight";
            this.pnlPsicRight.Size = new System.Drawing.Size(400, 338);
            this.pnlPsicRight.TabIndex = 3;
            // 
            // pnlPsicLeft
            // 
            this.pnlPsicLeft.AutoSize = true;
            this.pnlPsicLeft.Location = new System.Drawing.Point(8, 85);
            this.pnlPsicLeft.Name = "pnlPsicLeft";
            this.pnlPsicLeft.Size = new System.Drawing.Size(400, 338);
            this.pnlPsicLeft.TabIndex = 2;
            // 
            // frmListaTutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(936, 530);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "frmListaTutores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tutores";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabTutor.ResumeLayout(false);
            this.tabTutor.PerformLayout();
            this.tabPsic.ResumeLayout(false);
            this.tabPsic.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabTutor;
        private System.Windows.Forms.TabPage tabPsic;
        private Button btnAtras;
        private Panel pnlTutorRight;
        private Panel pnlTutorLeft;
        private Panel pnlPsicRight;
        private Panel pnlPsicLeft;
    }
}