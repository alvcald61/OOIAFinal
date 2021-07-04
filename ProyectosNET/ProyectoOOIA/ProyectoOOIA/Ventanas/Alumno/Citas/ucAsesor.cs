using System;
using System.Drawing;
using System.IO;
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

            if (asesor.imagenDePerfil == null) pbPerfil.Image = Properties.Resources.placeholder_profile;
            else displayImage(asesor.imagenDePerfil);

            if (asesor is GestionHumanaWS.psicologo) lblEspecialidad.Text = ((GestionHumanaWS.psicologo)asesor).rama;
            else lblEspecialidad.Text = ((GestionHumanaWS.profesor)asesor).especialidad.nombre;

        }

        public void displayImage(byte[] image)
        {
            MemoryStream ms = new MemoryStream(image);
            pbPerfil.Image = Image.FromStream(ms);
        }

        private void btnOpinion_Click(object sender, EventArgs e)
        {
            new frmOpiniones(asesor).ShowDialog();
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
