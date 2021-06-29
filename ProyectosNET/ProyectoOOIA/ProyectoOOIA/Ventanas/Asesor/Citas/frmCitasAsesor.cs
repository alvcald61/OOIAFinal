using System;
using System.Windows.Forms;
using ProyectoOOIA.Ventanas.Asesor.Citas;

namespace ProyectoOOIA.Ventanas
{
    public partial class frmHorarioAsesor : Form
    {
        private GestionHumanaWS.persona persona;
        //private Horario _horarioSeleccionado;

        public frmHorarioAsesor()
        {
            InitializeComponent();
        }

        public frmHorarioAsesor(GestionHumanaWS.persona persona)
        {
            InitializeComponent();
            this.persona = persona;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            new frmPrincipal(TipoUsuario.Asesor,persona).Show();
            this.Close();
        }
        


        private void btnMostrarDetalles_Click(object sender, EventArgs e)
        {
            /*_horarioSeleccionado = (Horario)dvgHorarioProf.CurrentRow.DataBoundItem;*/
            new frmDetalleCitaAsesor().Show();
        }

        private void btnModificarHorario_Click(object sender, EventArgs e)
        {
            
            //Se le pasa el alumno asociado al evento seleccioando new frmCancelarCitaAsesor().ShowDialog();
        }

        private void btnBuscarHorario_Click(object sender, EventArgs e)
        {
            /*dgvHorarioProf.DataSource =
                daoHorario.listarHorario(tbNombre.Text);*/
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new frmInicioSesion().Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new frmRegistrarHorario().ShowDialog();

        }
    }
}
