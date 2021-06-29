using System;
using System.Windows.Forms;

using miembroPUCP = ProyectoOOIA.GestionHumanaWS.miembroPUCP;

namespace ProyectoOOIA.Ventanas.Alumno.Citas
{
    public partial class ucAsesor : UserControl
    {
        private GestionHumanaWS.miembroPUCP asesor;
        

        public ucAsesor(GestionHumanaWS.miembroPUCP t)
        {
            this.asesor = new GestionHumanaWS.profesor();
            InitializeComponent();
            asesor = t;

            lblNombre.Text = asesor.nombre;
            
            if (asesor is GestionHumanaWS.psicologo) 
                lblEspecialidad.Visible = false;
            else lblEspecialidad.Text = ((GestionHumanaWS.profesor)asesor).especialidad.nombre;

        }

        

        private void btnOpinion_Click(object sender, EventArgs e)
        {
            new frmOpiniones(asesor.id_miembro_pucp).ShowDialog();
        }

        public miembroPUCP Asesor
        {
            get => asesor;
            set => asesor = value;
        }

        private void pnlDatos_Paint(object sender, PaintEventArgs e)
        {

        }

        public Button BtnSeleccionar
        {
            get => btnSeleccionar;
            set => btnSeleccionar = value;
        }

        public Button BtnOpinion
        {
            get => btnOpinion;
            set => btnOpinion = value;
        }
    }
}
