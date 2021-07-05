using ProyectoOOIA.Ventanas.Alumno.Eventos;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;


namespace ProyectoOOIA.Ventanas
{
    public partial class frmRegistroEvento : Form
    {
        private GestionHumanaWS.persona persona;
        private GestionEventoWS.GestionEventoWSClient daoEvento;
        private GestionEventoWS.GestionEventoWS daoEventoAlumno;
        private GestionEventoWS.eventoAlumno eventoAlumno;
        private GestionEventoWS.evento evento;
        private GestionHumanaWS.GestionHumanaWS daoAlumno;
        private GestionHumanaWS.alumno alumno;
        public frmRegistroEvento()
        {
            InitializeComponent();
            dvgInscritos.AutoGenerateColumns = false;
            dvgInscritos.RowCount = 0;
            dvgHistorial.AutoGenerateColumns = false;
            dvgHistorial.RowCount = 0;
            daoEvento = new GestionEventoWS.GestionEventoWSClient();
            daoEventoAlumno = new GestionEventoWS.GestionEventoWSClient();
            daoAlumno = new GestionHumanaWS.GestionHumanaWSClient();
            evento = new GestionEventoWS.evento();
            //alumno = new AlumnoWS.alumno();
            listarHistorial();
        }

        public frmRegistroEvento(GestionHumanaWS.persona persona)
        {
            InitializeComponent();
            this.persona = persona;
            dvgInscritos.AutoGenerateColumns = false;
            dvgInscritos.RowCount = 0;
            dvgHistorial.AutoGenerateColumns = false;
            dvgHistorial.RowCount = 0;
            daoEvento = new GestionEventoWS.GestionEventoWSClient();
            daoEventoAlumno = new GestionEventoWS.GestionEventoWSClient();
            daoAlumno = new GestionHumanaWS.GestionHumanaWSClient();
            //listarAlumnos(persona.id_persona); //obtengo el alumno
            evento = new GestionEventoWS.evento();
            this.alumno=persona as GestionHumanaWS.alumno;
            eventoAlumno = new  GestionEventoWS.eventoAlumno();
            listarHistorial();
            listarEventosInscritos();

    }

        //private void listarAlumnos(int id_persona)
        //{
        //    BindingList<AlumnoWS.alumno>
        //       alumnos = new BindingList<AlumnoWS.alumno>
        //       (daoAlumno.listarAlumno().ToList());

        //    foreach (AlumnoWS.alumno a in alumnos)
        //    {
        //        if(a.id_persona == id_persona)
        //        {
        //            this.alumno = a;
        //        }
        //    }
        //}

          private void listarHistorial()
           {
            try
            {
                BindingList<GestionEventoWS.evento>
                      eventosAlumnos = new BindingList<GestionEventoWS.evento>
                      (daoEvento.listar_eventos_pasados(this.alumno.id_alumno).ToList());
                dvgHistorial.DataSource = eventosAlumnos;
            }
            catch
            {
                return;
            }
           }

           private void listarEventosInscritos()
       {
            try
            {
                BindingList<GestionEventoWS.evento>
                   eventosAlumnos = new BindingList<GestionEventoWS.evento>
                   (daoEvento.listar_eventos_inscritos(this.alumno.id_alumno).ToList());
                dvgInscritos.DataSource = eventosAlumnos;
            }
            catch
            {
                return;
            }
       }


        private void frmEventosAlumno_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscarInscritos_Click(object sender, EventArgs e)
        {
            frmBuscarEventoAlumno aux = new frmBuscarEventoAlumno();
            aux.ShowDialog();
            this.evento = aux.Evento;
            if (this.evento == null) return;
            txtNombreEvento.Text = evento.nombre;
            dtpFechaInscritos.Value = evento.fecha;
        }

        private void btnDetInscritos_Click(object sender, EventArgs e)
        {
            if (dvgInscritos.CurrentRow != null)
            {
                GestionEventoWS.evento evento_seleccionado =
              (GestionEventoWS.evento)dvgInscritos.CurrentRow.DataBoundItem;

                new frmDetalleEvento(evento_seleccionado).Show();
            }
                
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtNombreEvento.Text != "")
            {
                if (evento.cupo == 0)
                {
                    MessageBox.Show("Actualmente, el evento ya no tiene cupos", "Inscripción a Evento",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                DialogResult dr =
                   MessageBox.Show("¿Desea inscribirse a este evento?", "Inscripción a Evento",
                   MessageBoxButtons.YesNo, MessageBoxIcon.None);
                if (dr == DialogResult.Yes)
                {
                    eventoAlumno.id_alumno = alumno.id_alumno;
                    eventoAlumno.id_evento = evento.id_evento;
                    eventoAlumno.valoracionEvento = 0;
                    eventoAlumno.valoracionPonentes = 0;
                    eventoAlumno.valoracionUtilidad = 0;
                    eventoAlumno.comentario = "";
                    eventoAlumno.asistio = false;

                    int cantUsuarios = new GestionHumanaWS.GestionHumanaWSClient().validar_registro_alumno_evento(
                    alumno.id_alumno, evento.id_evento);
                    
                    if (cantUsuarios == 1)
                    {
                        MessageBox.Show("Ya se encuentra registrado en el evento", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    int resultado = daoEvento.insertarEncuestaEvento(eventoAlumno);
                    int resultado2 = daoEvento.reducir_cupo(evento);

                    if (resultado != 0 && resultado2 != 0)
                    {
                        MessageBox.Show("El registro ha sido exitoso", "Éxito", MessageBoxButtons.OK,
                               MessageBoxIcon.Exclamation);
                        listarEventosInscritos();
                        txtNombreEvento.Text = "";
                       
                    }
                    else
                    {
                        MessageBox.Show("Ha habido un error", "Error", MessageBoxButtons.RetryCancel,
                                MessageBoxIcon.Error);
                    }
                }

            }
        }

        //private void btnCancelar_Click(object sender, EventArgs e)
        //{
        //    //new frmCancelarEventoAlumno().Show();
        //    if (dvgInscritos.CurrentRow != null)
        //    {
        //        DialogResult dr =
        //       MessageBox.Show("¿Desea cancelar su inscripción a este evento?", "Cancelar Evento",
        //       MessageBoxButtons.YesNo, MessageBoxIcon.None);

        //        if (dr == DialogResult.Yes)
        //        {
        //            //falta verificar el elemento seleccionado
        //            GestionEventoWS.evento evento_seleccionado =
        //                (GestionEventoWS.evento)dvgInscritos.CurrentRow.DataBoundItem;
        //            EventoAlumnoWS.eventoAlumno aux = new eventoAlumno();
        //            aux.id_alumno = alumno.id_alumno;
        //            aux.id_evento = evento_seleccionado.id_evento;
        //            int resultado = daoEventoAlumno.eliminarEncuestaEvento(aux);
        //            if (resultado != 0)
        //            {
        //                MessageBox.Show("Se ha cancelado su inscripción al evento", "Éxito", MessageBoxButtons.OK,
        //                       MessageBoxIcon.Exclamation);
        //            }
        //            else
        //            {
        //                MessageBox.Show("Ha habido un error", "Error", MessageBoxButtons.RetryCancel,
        //                        MessageBoxIcon.Error);
        //            }
        //        }
        //    }

        //}

        private void btnDetHistorial_Click(object sender, EventArgs e)
        {
            if (dvgInscritos.CurrentRow != null)
            {
                GestionEventoWS.evento evento_seleccionado =
              (GestionEventoWS.evento)dvgHistorial.CurrentRow.DataBoundItem;
                new frmDetalleEvento(evento_seleccionado).Show();
            }   
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            new frmPrincipal((GestionHumanaWS.miembroPUCP) persona).Show();
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

        private void dvgInscritos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dvgInscritos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            GestionEventoWS.evento data = dvgInscritos.Rows[e.RowIndex].DataBoundItem
            as GestionEventoWS.evento;
            dvgInscritos.Rows[e.RowIndex].Cells[4].Value = data.categoria.nombre;

        }

        private void dvgHistorial_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            GestionEventoWS.evento data = dvgHistorial.Rows[e.RowIndex].DataBoundItem
            as GestionEventoWS.evento;
            dvgHistorial.Rows[e.RowIndex].Cells[4].Value = data.categoria.nombre;
        }

        private void btnAgregarOpinion_Click(object sender, EventArgs e)
        {
            GestionEventoWS.evento eventoSeleccionado = 
                (GestionEventoWS.evento)dvgHistorial.CurrentRow.DataBoundItem;

            if(eventoSeleccionado == null)
            {
                MessageBox.Show("Debe de seleccionar un evento", "Mensaje de error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                new frmAgregarOpinionEvento(eventoSeleccionado.id_evento, this.alumno.id_alumno).ShowDialog();
            }

        }
    }
}
