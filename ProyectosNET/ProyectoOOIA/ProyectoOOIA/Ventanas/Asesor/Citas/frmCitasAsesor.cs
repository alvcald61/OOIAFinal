using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using ProyectoOOIA.Ventanas.Asesor.Citas;

namespace ProyectoOOIA.Ventanas
{
    public partial class frmCitasAsesor : Form
    {
        private GestionAtencionWS.GestionAtencionWSClient daoCita;
        
        //private Horario _horarioSeleccionado;
        private Estado estado;
        private GestionHumanaWS.miembroPUCP asesor;
        private BindingList<GestionAtencionWS.cita> citasCompletas;
        private BindingList<String> tipos_horarios;
        public frmCitasAsesor()
        {
            InitializeComponent();
        }

        public frmCitasAsesor(GestionHumanaWS.persona persona)
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
            
            listarCitas(this.asesor.id_miembro_pucp, "");
            //inicialmente las citas activas y pendientes
            listarCitasPendientes(this.asesor.id_miembro_pucp,"");
        }

        private void listarCitasPendientes(int id_profesor, String nombre_alumno)
        {
            listarCitas(id_profesor, nombre_alumno);
            //lista citas pendientes
            try
            {
                BindingList<GestionAtencionWS.cita> citas = new BindingList<GestionAtencionWS.cita>();
                if (citasCompletas == null) return;
            foreach (GestionAtencionWS.cita c in citasCompletas)
                {
                    if ((c.fecha > DateTime.Now) && c.activo == 1) citas.Add(c);
                }
                dgvHorarioProf.DataSource = citas;
            }
            catch
            {
                return;
            }
            
            
        }

        private void listarCitasFinalizadas(int id_profesor, String nombre_alumno)
        {
            listarCitas(id_profesor, nombre_alumno);
            //lista citas finalizadas
            BindingList<GestionAtencionWS.cita> citas = new BindingList<GestionAtencionWS.cita>();
            foreach (GestionAtencionWS.cita c in citasCompletas)
            {
                if (c.fecha <= DateTime.Now && c.activo == 1) citas.Add(c);
            }

            dgvHorarioProf.DataSource = citas;
        }

        private void listarCitasCanceladas(int id_profesor, String nombre_alumno)
        {
            listarCitas(id_profesor, nombre_alumno);
            //lista citas canceladas
            BindingList<GestionAtencionWS.cita> citas = new BindingList<GestionAtencionWS.cita>();
            foreach (GestionAtencionWS.cita c in citasCompletas)
            {
                if (c.activo == 0) citas.Add(c);
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
            new frmPrincipal((GestionHumanaWS.miembroPUCP)asesor).Show();
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
            //daoCita.modificarHorarioAsesorSinID(horario);
            daoCita.modificarHorarioAsesor(horario);

        }

        private void btnBuscarHorario_Click(object sender, EventArgs e)
        {
            

            if (rbTipoNombre.Checked == true)
            {
               
                if (cbTipoHorario.Text == "Pendiente" && tbNombre.Text != "")
                    listarCitasPendientes(this.asesor.id_miembro_pucp, tbNombre.Text);

                if (cbTipoHorario.Text == "Pendiente" && tbNombre.Text == "")
                    listarCitasPendientes(this.asesor.id_miembro_pucp, "");

                if (cbTipoHorario.Text == "Cancelada" && tbNombre.Text != "")
                    listarCitasCanceladas(this.asesor.id_miembro_pucp, tbNombre.Text);

                if (cbTipoHorario.Text == "Cancelada" && tbNombre.Text == "")
                    listarCitasCanceladas(this.asesor.id_miembro_pucp, "");

                if (cbTipoHorario.Text == "Finalizada" && tbNombre.Text != "")
                    listarCitasFinalizadas(this.asesor.id_miembro_pucp, tbNombre.Text);

                if (cbTipoHorario.Text == "Finalizada" && tbNombre.Text == "")
                    listarCitasFinalizadas(this.asesor.id_miembro_pucp, "");
            }
            if (rbFecha.Checked == true)
            {
                
                BindingList<GestionAtencionWS.cita> citas = new BindingList<GestionAtencionWS.cita>();
                foreach (GestionAtencionWS.cita c in citasCompletas)
                {
                    if (c.fecha == dtpFecha.Value.Date) citas.Add(c);
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
            new frmRegistrarHorario((GestionHumanaWS.miembroPUCP)asesor).ShowDialog();

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

        private void button1_Click_1(object sender, EventArgs e)
        {
            new frmDescargarReporteOpinion(this.asesor.id_miembro_pucp).Show();
        }

    }
}
