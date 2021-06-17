using System;
using System.Windows.Forms;

namespace ProyectoOOIA.Ventanas

{
    public partial class frmPrincipalAlumno : Form
    {
        public frmPrincipalAlumno()
        {
            InitializeComponent();

        }

        private void pnlLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new frmInicioSesion().Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new frmCitasAlumno().Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new frmListaTutores().Show();
            this.Close();
        }



        private void button4_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void ovalPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtTramites_Click(object sender, EventArgs e)
        {

        }

        private void txtEventos_Click(object sender, EventArgs e)
        {

        }

        private void txtHorarios_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_Click(object sender, EventArgs e)
        {

        }
    }
}
