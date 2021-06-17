using System;
using System.Windows.Forms;

namespace ProyectoOOIA.Ventanas.Alumno.Citas
{
    public partial class ucAsesor : UserControl
    {
        private ProfesorWS.profesor tutor;
        private PsicologoWS.psicologo psicologo;
        

        public ucAsesor(ProfesorWS.profesor t)
        {
            this.tutor = new ProfesorWS.profesor();
            InitializeComponent();
            tutor = t;

            lblNombre.Text = tutor.nombre;
            lblEspecialidad.Text = tutor.especialidad.nombre;

        }

        public ucAsesor(PsicologoWS.psicologo p)
        {
            this.psicologo = new PsicologoWS.psicologo();
            InitializeComponent();
            psicologo = p;

            lblNombre.Text = psicologo.nombre;
            lblEspecialidad.Visible = false;
        }

        private void btnOpinion_Click(object sender, EventArgs e)
        {
            new frmOpiniones().ShowDialog();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {

        }
    }
}
