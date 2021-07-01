using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using ProyectoOOIA.Ventanas.Asesor.Citas;

namespace ProyectoOOIA.Ventanas
{
    public partial class frmHorarioAsesor : Form
    {
        private GestionAtencionWS.GestionAtencionWSClient daoCita;
        private GestionHumanaWS.persona persona;
        //private Horario _horarioSeleccionado;
        private Estado estado;
        private GestionHumanaWS.miembroPUCP asesor;
        private BindingList<GestionAtencionWS.cita> citasCompletas;
        private BindingList<String> tipos_horarios;
        public frmHorarioAsesor()
        {
            InitializeComponent();
        }

        public frmHorarioAsesor(GestionHumanaWS.persona persona)
        {
            InitializeComponent();
            this.asesor = persona as GestionHumanaWS.miembroPUCP;
            daoCita = new GestionAtencionWS.GestionAtencionWSClient();
            dgvHorarioProf.AutoGenerateColumns = false;
            tipos_horarios = new BindingList<String>();
            tipos_horarios.Add("Pendiente");
            tipos_horarios.Add("Finalizada");
            tipos_horarios.Add("Cancelada");
            cbTipoHorario.DataSource = tipos_horarios;
            //inicialmente las citas activas y pendientes
            listarCitasPendientes(this.asesor.id_miembro_pucp,"");
        }

        private void listarCitasPendientes(int id_profesor, String nombre_alumno)
        {
            listarCitas(id_profesor, nombre_alumno);

            //lista citas pendientes
            BindingList<GestionAtencionWS.cita> citas = new BindingList<GestionAtencionWS.cita>();
            foreach(GestionAtencionWS.cita c in citasCompletas)
            {
                if ((c.fecha > DateTime.Now) && c.activo==1) citas.Add(c);
            }
            
            dgvHorarioProf.DataSource = citas;
        }
        private void listarCitas(int id_profesor, String nombre_alumno)
        {
            //lista todo
            GestionAtencionWS.cita[] aux = daoCita.listarCitasProfesor(id_profesor, nombre_alumno);
            if (aux == null) return;
            BindingList<GestionAtencionWS.cita>
               citasProfesor = new BindingList<GestionAtencionWS.cita>
               (aux.ToList());

            citasCompletas = citasProfesor;
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            new frmPrincipal(TipoUsuario.Asesor,persona).Show();
            this.Close();
        }
        


        private void btnMostrarDetalles_Click(object sender, EventArgs e)
        {
            
            if (dgvHorarioProf.CurrentRow != null)
            {
                GestionAtencionWS.cita cita_seleccionado =
              (GestionAtencionWS.cita)dgvHorarioProf.CurrentRow.DataBoundItem;
               
                new frmDetalleCitaAsesor(cita_seleccionado).Show();
            }
        }

        private void btnModificarHorario_Click(object sender, EventArgs e)
        {
            
             new frmCancelarCitaAsesor(dgvHorarioProf.CurrentRow.DataBoundItem as GestionAtencionWS.cita,asesor).ShowDialog();

            GestionAtencionWS.horarioAsesor horario = new GestionAtencionWS.horarioAsesor();
            horario.horario = (dgvHorarioProf.CurrentRow.DataBoundItem as GestionAtencionWS.cita).horario;
            horario.fid_asesor = asesor.id_miembro_pucp;
            horario.estado = "disponible";
            //MessageBox.Show(horario.horario.id_horario + " " + horario.id_horario_asesor);
            daoCita.modificarHorarioAsesorSinID(horario);

        }

        private void btnBuscarHorario_Click(object sender, EventArgs e)
        {
            /*dgvHorarioProf.DataSource =
                daoHorario.listarHorario(tbNombre.Text);*/
            BindingList<GestionAtencionWS.cita> citas = new BindingList<GestionAtencionWS.cita>();
            //lista por nombre
            if(tbNombre.Text != "") listarCitas(this.asesor.id_miembro_pucp, tbNombre.Text);
            if (cbTipoHorario.Text == "Pendiente") listarCitasPendientes(this.asesor.id_miembro_pucp, "");
            else
            {
                foreach (GestionAtencionWS.cita c in citasCompletas)
                {
                    if (cbTipoHorario.Text == "Cancelada")
                    {
                        if (c.activo == 0) citas.Add(c);

                    }
                    if (cbTipoHorario.Text == "Finalizada")
                    {
                        if (c.fecha <= DateTime.Now && c.activo == 1) citas.Add(c);

                    }
                    if (c.fecha == dtpFecha.Value) citas.Add(c);
                }
                dgvHorarioProf.DataSource = citas;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new frmInicioSesion().Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new frmRegistrarHorario((GestionHumanaWS.miembroPUCP)persona).ShowDialog();

        }

        private void dgvHorarioProf_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            GestionAtencionWS.cita data = dgvHorarioProf.Rows[e.RowIndex].DataBoundItem
            as GestionAtencionWS.cita;
            dgvHorarioProf.Rows[e.RowIndex].Cells[0].Value = data.fecha.ToString("dd/MM/yyyy");
            dgvHorarioProf.Rows[e.RowIndex].Cells[1].Value = data.horario.horaInicio.ToString("hh:mm");
            dgvHorarioProf.Rows[e.RowIndex].Cells[2].Value = data.alumno.especialidad.nombre;
            dgvHorarioProf.Rows[e.RowIndex].Cells[3].Value = data.alumno.nombre;
            if((data.fecha >= DateTime.Now) && data.activo==1)
                dgvHorarioProf.Rows[e.RowIndex].Cells[4].Value = "Pendiente";
            if ((data.fecha < DateTime.Now) && data.activo == 1)
                dgvHorarioProf.Rows[e.RowIndex].Cells[4].Value = "Finalizada";
            if (data.activo == 0)
                dgvHorarioProf.Rows[e.RowIndex].Cells[4].Value = "Cancelada";
            dgvHorarioProf.Rows[e.RowIndex].Cells[5].Value = data.alumno.correo;
        }
    }
}
