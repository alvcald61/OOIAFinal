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
        private EventoAlumnoWS.EventoAlumnoWSClient daoEventoAlumno;
        private EventoAlumnoWS.eventoAlumno eventoAlumno;
        private GestionEventoWS.evento evento;
        private AlumnoWS.AlumnoWSClient daoAlumno;
        private AlumnoWS.alumno alumno;
        public frmRegistroEvento()
        {
            InitializeComponent();
            dvgInscritos.AutoGenerateColumns = false;
            dvgInscritos.RowCount = 0;
            dvgHistorial.AutoGenerateColumns = false;
            dvgHistorial.RowCount = 0;
            daoEvento = new GestionEventoWS.GestionEventoWSClient();
            daoEventoAlumno = new EventoAlumnoWS.EventoAlumnoWSClient();
            daoAlumno = new AlumnoWS.AlumnoWSClient();
            evento = new GestionEventoWS.evento();
            alumno = new AlumnoWS.alumno();
            //listarHistorial();
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
            daoEventoAlumno = new EventoAlumnoWS.EventoAlumnoWSClient();
            daoAlumno = new AlumnoWS.AlumnoWSClient();
            listarAlumnos(persona.id_persona); //obtengo el alumno
            evento = new GestionEventoWS.evento();
            //listarHistorial();
        }

        private void listarAlumnos(int id_persona)
        {
            BindingList<AlumnoWS.alumno>
               alumnos = new BindingList<AlumnoWS.alumno>
               (daoAlumno.listarAlumno().ToList());

            foreach (AlumnoWS.alumno a in alumnos)
            {
                if(a.id_persona == id_persona)
                {
                    this.alumno = a;
                }
            }
        }

        /*   private void listarHistorial()
           {
               BindingList<GestionEventoWS.evento>
                  eventosAlumnos = new BindingList<GestionEventoWS.evento>
                  (daoEvento.listar(this.alumno.id_alumno).ToList());
               dvgHistorial.DataSource = eventosAlumnos;
           }*/

        /*   private void listarEventosInscritos()
       {
           BindingList<GestionEventoWS.evento>
              eventosAlumnos = new BindingList<GestionEventoWS.evento>
              (daoEvento.listar(this.alumno.id_alumno).ToList());
           dvgInscritos.DataSource = eventosAlumnos;
       }*/


        private void frmEventosAlumno_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscarInscritos_Click(object sender, EventArgs e)
        {
            frmBuscarEventoAlumno aux = new frmBuscarEventoAlumno();
            aux.ShowDialog();
            this.evento = aux.Evento;
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
                DialogResult dr =
                   MessageBox.Show("¿Desea inscribirse a este evento?", "Inscripción a Evento",
                   MessageBoxButtons.YesNo, MessageBoxIcon.None);
                if (dr == DialogResult.Yes)
                {
                    // int resultado = daoEventoAlumno.insertar(eventoAlumno);
                    /*if (resultado != 0)
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
                    }*/
                }

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //new frmCancelarEventoAlumno().Show();
            if (dvgInscritos.CurrentRow != null)
            {
                DialogResult dr =
               MessageBox.Show("¿Desea cancelar su inscripción a este evento?", "Cancelar Evento",
               MessageBoxButtons.YesNo, MessageBoxIcon.None);

                if (dr == DialogResult.Yes)
                {
                    // int resultado = daoEventoAlumno.eliminar(eventoAlumno);
                    /*if (resultado != 0)
                    {
                        MessageBox.Show("Se ha cancelado su inscripción al evento", "Éxito", MessageBoxButtons.OK,
                               MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("Ha habido un error", "Error", MessageBoxButtons.RetryCancel,
                                MessageBoxIcon.Error);
                    }*/
                }
            }
            
        }

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

        private void dvgInscritos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dvgInscritos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            GestionEventoWS.evento data = dvgInscritos.Rows[e.RowIndex].DataBoundItem
            as GestionEventoWS.evento;
            dvgInscritos.Rows[e.RowIndex].Cells["Categoria"].Value = data.categoria.nombre;
        }

        private void dvgHistorial_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            GestionEventoWS.evento data = dvgHistorial.Rows[e.RowIndex].DataBoundItem
            as GestionEventoWS.evento;
            dvgHistorial.Rows[e.RowIndex].Cells["Categoria"].Value = data.categoria.nombre;
        }
    }
}
