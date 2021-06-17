using System;
using System.Windows.Forms;

namespace ProyectoOOIA.Ventanas
{
    public partial class frmRegistroEvento : Form
    {
        private GestionHumanaWS.persona persona;

        public frmRegistroEvento()
        {
            InitializeComponent();
        }

        public frmRegistroEvento(GestionHumanaWS.persona persona)
        {
            InitializeComponent();
            this.persona = persona;
        }
        private void frmEventosAlumno_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscarInscritos_Click(object sender, EventArgs e)
        {
            new frmBuscarEventoAlumno().Show();
        }

        private void btnDetInscritos_Click(object sender, EventArgs e)
        {
            new frmDetalleEvento().Show();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //new frmAgregarEventoAlumno().Show();
            DialogResult dr =
               MessageBox.Show("¿Desea inscribirse a este evento?", "Inscripción a Evento",
               MessageBoxButtons.YesNo, MessageBoxIcon.None);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //new frmCancelarEventoAlumno().Show();
            DialogResult dr =
               MessageBox.Show("¿Desea cancelar su inscripción a este evento?", "Cancelar Evento",
               MessageBoxButtons.YesNo, MessageBoxIcon.None);
        }

        private void btnDetHistorial_Click(object sender, EventArgs e)
        {
            new frmDetalleEvento().Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            new frmPrincipal(TipoUsuario.Alumno,persona).Show();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new frmInicioSesion().Show();
            this.Close();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            new frmAccesoEvento().ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarHistorial_Click(object sender, EventArgs e)
        {

        }
    }
}
