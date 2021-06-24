using System;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ProyectoOOIA.GestionAtencionWS;
using ProyectoOOIA.GestionHumanaWS;

namespace ProyectoOOIA.Ventanas
{
    public partial class frmCitasAlumno : Form
    {
        private GestionAtencionWS.GestionAtencionWSClient daoCita;
        private GestionAtencionWS.GestionAtencionWSClient daoHorario;
        private GestionHumanaWS.GestionHumanaWSClient humanaDao;
        private Estado estado;
        private GestionHumanaWS.miembroPUCP asesor;
        private GestionHumanaWS.persona persona;
        private GestionHumanaWS.alumno alumno;
        private GestionAtencionWS.horario horarioProfesor;
        private horarioAsesor horarioAsesor;

        public frmCitasAlumno()
        {
            InitializeComponent();
            this.estado = Estado.Inicial;
            cambiarEstado();
            humanaDao = new GestionHumanaWSClient();
            daoHorario = new GestionAtencionWSClient();
            //dgvCitasProgramadas.DataSource = 

            //esto hace que no se genere mas columnas de las que yo he definido en la interfaz grafica
            dgvCitasProgramadas.AutoGenerateColumns = false;
            dgvHistorialCitas.AutoGenerateColumns = false;
            tabCitasProgramadas.AutoScroll = false;
            tabCitasProgramadas.HorizontalScroll.Enabled = false;
            tabCitasProgramadas.HorizontalScroll.Visible = false;
            tabCitasProgramadas.HorizontalScroll.Maximum = 0;
            tabCitasProgramadas.AutoScroll = true;
        }
        public frmCitasAlumno(GestionHumanaWS.persona persona)
        {
            this.persona = persona;
            InitializeComponent();
            this.estado = Estado.Inicial;
            cambiarEstado();
            //dgvCitasProgramadas.DataSource = 

            //esto hace que no se genere mas columnas de las que yo he definido en la interfaz grafica
            dgvCitasProgramadas.AutoGenerateColumns = false;
            dgvHistorialCitas.AutoGenerateColumns = false;
            tabCitasProgramadas.AutoScroll = false;
            tabCitasProgramadas.HorizontalScroll.Enabled = false;
            tabCitasProgramadas.HorizontalScroll.Visible = false;
            tabCitasProgramadas.HorizontalScroll.Maximum = 0;
            tabCitasProgramadas.AutoScroll = true;
            daoCita = new GestionAtencionWS.GestionAtencionWSClient();
            this.alumno = persona as GestionHumanaWS.alumno;
            
            listarHistorial();
            listarCitasProgramadas();
        }

        private void listarHistorial()
        {
            GestionAtencionWS.cita[] aux=daoCita.listarCitaHistorico(this.alumno.id_alumno);
            if (aux == null) return;
            BindingList<GestionAtencionWS.cita>
               citasAlumnos = new BindingList<GestionAtencionWS.cita>
               (aux.ToList());
            dgvHistorialCitas.DataSource = citasAlumnos;
        }

        private void listarCitasProgramadas()
        {
            try
            {
                BindingList<GestionAtencionWS.cita>
                    citasAlumnos = new BindingList<GestionAtencionWS.cita>
                        (daoCita.listarCitaPendiente(this.alumno.id_alumno).ToList());
                dgvCitasProgramadas.DataSource = citasAlumnos;
            }
            catch { }
            
        }

        public void clearall()
        {
            txtAsesor.Text = "";
            
            dtpFecha.Value = DateTime.Now;
            txtMotivo.Text = "";
        }

        public void cambiarEstado()
        {
            switch (estado)
            {
                case Estado.Inicial:
                    /*Botones*/
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = false;
                    //btnModificar.Enabled = false;
                    //btnEliminar.Enabled = false;
                    //btnDetInscritas.Enabled = false;
                    /*Cuadros de información*/
                    btnBuscarAsesor.Enabled = false;
                    btnBuscarHorario.Enabled = false;
                    txtMotivo.Enabled = false;
                    break;
                case Estado.Nuevo:
                    /*Botones*/
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnCancelar.Enabled = true;
                    //btnModificar.Enabled = false;
                    //btnEliminar.Enabled = false;
                    /*Cuadros de información*/
                    btnBuscarAsesor.Enabled = true;
                    btnBuscarHorario.Enabled = true;
                    txtMotivo.Enabled = true;
                    break;
                case Estado.Modificar:
                    /*Botones*/
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnCancelar.Enabled = true;
                    //btnModificar.Enabled = false;
                    //btnEliminar.Enabled = false;
                    /*Cuadros de información*/
                    btnBuscarAsesor.Enabled = true;
                    btnBuscarHorario.Enabled = true;
                    txtMotivo.Enabled = true;
                    break;
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            new frmPrincipal(TipoUsuario.Alumno,persona).Show();
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
            DialogResult dr =
               MessageBox.Show("¿Esta seguro que desea cancelar esta cita?", "Cancelación de cita",
               MessageBoxButtons.YesNo, MessageBoxIcon.None);
            if (dr == DialogResult.Yes)
            {
                if (dgvCitasProgramadas.CurrentRow.Index < 0)
                    MessageBox.Show("Debe seleccionar una cita", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    daoCita.eliminarCita(dgvCitasProgramadas.CurrentRow.DataBoundItem as cita);
                    MessageBox.Show("La cita ha sido cancelada exitosamente", "Cita cancelada", MessageBoxButtons.OK);
                    listarCitasProgramadas();
                }

                
            }

        }

        private void btnDetalleHistorial_Click(object sender, EventArgs e)
        {
            if (dgvHistorialCitas.CurrentRow != null)
            {
                GestionAtencionWS.cita cita_seleccionado =
              (GestionAtencionWS.cita)dgvHistorialCitas.CurrentRow.DataBoundItem;

                new frmDetalleCitaAlumno(cita_seleccionado).Show();
            }


        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //new frmCitaRegistroAlumno().ShowDialog();
            //new frmConfirmarCitaAlumno().ShowDialog();
            if (txtAsesor.Text == "")
            {
                MessageBox.Show("No ha ingresado el asesor", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dtpFecha.Value<DateTime.Now)
            {
                MessageBox.Show("No ha ingresado el horario", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtMotivo.Text == "")
            {
                MessageBox.Show("No ha ingresado el motivo", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            /*Informacion se asigna a cita*/
            //cita.motivo = txtMotivo.Text;
            //cita.asesor = 
            //cita.fechaRegistro = Date.Now;

            GestionAtencionWS.cita citaNueva = new GestionAtencionWS.cita();
            citaNueva.asesor = asignarAsesor(asesor);
            citaNueva.alumno = asignarAlumno(alumno);
            citaNueva.fecha = dtpFecha.Value;
            citaNueva.estado = true;
            citaNueva.activo = true;
            citaNueva.asistio = false;
            citaNueva.fechaSpecified = true;
            citaNueva.horario = horarioProfesor;
            citaNueva.motivo = txtMotivo.Text;
            citaNueva.compromiso = "";
            citaNueva.codigo_atencion = new codigoAtencion();
            citaNueva.codigo_atencion.id_codigo_atencion = 1;
            
            
            if (asesor is GestionHumanaWS.profesor) citaNueva.tipo_asesor = 0;
            else citaNueva.tipo_asesor = 1;

            //if (estado.Equals(Estado.Nuevo))
            //{
                DialogResult dr =
                MessageBox.Show("¿Esta seguro que desea programar la cita?", "Registro de cita",
                MessageBoxButtons.YesNo, MessageBoxIcon.None);
                if (dr == DialogResult.Yes)
                {
                //int resultado = daoCita.insertar(cita);
                int resultado = daoCita.insertarCita(citaNueva);
                if (resultado != 0)
                {
                    MessageBox.Show("La cita ha sido registrada exitosamente", "Mensaje Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string mensaje = "Estimado " + alumno.nombre + ":\n" +
                                     "Ustedes ha agendado satisfactoriamente una cita con la OOIA. A continuación le indicaremos los datos de la sesion: \n\n" +
                                     "Asesor: " + asesor.nombre + "\n" +
                                     "Fecha: " + citaNueva.fecha.Date + "\n" +
                                     "Desde las: " + citaNueva.horario.horaInicio.Hour + ":"+ citaNueva.horario.horaInicio.Minute + "\n" +
                                     "Hasta: " + citaNueva.horario.horaFin.Hour + ":" + citaNueva.horario.horaFin.Minute + "\n" +
                                     "Con el siguiente motivo: " + citaNueva.motivo + "\n\n\n\n" +
                                     "Atte. Oficina de Orientación, Información y Apoyo al Estudiante\n\n ";


                    
                    horarioAsesor.estado = "reservado";
                    
                    daoCita.modificarHorarioAsesor(horarioAsesor);
                    this.estado = Estado.Inicial;
                        cambiarEstado();
                    }
                    else MessageBox.Show("Ha ocurrido un error", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                listarCitasProgramadas();
        }


        

        private void btnAtras_Click(object sender, EventArgs e)
        {

            new frmInicioSesion().Show();
            this.Close();
        }

        private void btnAgregarOpinion_Click(object sender, EventArgs e)
        {

            GestionAtencionWS.cita cita_seleccionado =
              (GestionAtencionWS.cita)dgvHistorialCitas.CurrentRow.DataBoundItem;
            if (alumno.id_alumno > 0)
            {
                System.Console.WriteLine("El alumno no es null");
            }
            else
            {
                System.Console.WriteLine("El alumno si es null");
            }


            if (cita_seleccionado.asesor.id_miembro_pucp > 0)
            {
                System.Console.WriteLine("El asesor no es null");
            }
            else
            {
                System.Console.WriteLine("El asesor si es null");
            }
            new frmAgregarOpinion(cita_seleccionado.id_cita ,cita_seleccionado.asesor, asignarAlumno(alumno)).ShowDialog();

        }
        
        private void btnBuscarAsesor_Click(object sender, EventArgs e)
        {
            frmListaTutores aux=new frmListaTutores();
            aux.ShowDialog();
            asesor = aux.Asesor;
            if (asesor != null) this.txtAsesor.Text = asesor.nombre;

        }

        private void btnBuscarHorario_Click(object sender, EventArgs e)
        {
            frmHorarioCita frmBuscarHorario = new frmHorarioCita(asesor);
            if(frmBuscarHorario.ShowDialog() == DialogResult.OK)
            {
                dtpFecha.Value = frmBuscarHorario.Horario;
                dtpHoraInicio.Value = frmBuscarHorario.Horario;
                dtpHoraFin.Value = frmBuscarHorario.Horario.AddMinutes(30);
                horarioProfesor = frmBuscarHorario.Retorno;
                horarioAsesor = frmBuscarHorario.RetornoHorarioAsesor;
            }
        }

        private void btnDetInscritas_Click(object sender, EventArgs e)
        {
            //new frmDetalleCitaAlumno().ShowDialog();
            //this.DialogResult = DialogResult.OK;
            if (dgvCitasProgramadas.CurrentRow != null)
            {
                GestionAtencionWS.cita cita_seleccionado =
              (GestionAtencionWS.cita)dgvCitasProgramadas.CurrentRow.DataBoundItem;

                new frmDetalleCitaAlumno(cita_seleccionado).Show();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //this.cita = new CitaOOIAWS.citaOOIA();
            this.estado = Estado.Nuevo;
            cambiarEstado();
            clearall();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.estado = Estado.Inicial;
            cambiarEstado();
            clearall();
        }

        private void dgvCitasProgramadas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.estado == Estado.Inicial)
            {
                //btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
                btnDetInscritas.Enabled = true;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            
            this.estado = Estado.Modificar;
            cambiarEstado();

        }

        private void dgvCitasProgramadas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            GestionAtencionWS.cita data = dgvCitasProgramadas.Rows[e.RowIndex].DataBoundItem
            as GestionAtencionWS.cita;
            dgvCitasProgramadas.Rows[e.RowIndex].Cells[0].Value = data.asesor.nombre;
            dgvCitasProgramadas.Rows[e.RowIndex].Cells[2].Value = data.horario.horaInicio.ToString("hh:mm");
            dgvCitasProgramadas.Rows[e.RowIndex].Cells[3].Value = data.horario.horaFin.ToString("hh:mm");
        }

        private void dgvHistorialCitas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            GestionAtencionWS.cita data = dgvHistorialCitas.Rows[e.RowIndex].DataBoundItem
            as GestionAtencionWS.cita;
            dgvHistorialCitas.Rows[e.RowIndex].Cells[0].Value = data.asesor.nombre;
            dgvHistorialCitas.Rows[e.RowIndex].Cells[2].Value = data.horario.horaInicio.ToString("hh:mm");
            dgvHistorialCitas.Rows[e.RowIndex].Cells[3].Value = data.horario.horaFin.ToString("hh:mm");
        }

        private void enviarCorreo(string motivo, string mensaje)
        {
            var fromAddress = new MailAddress("OOIA.no.reply@gmail.com", "OOIA");
            var toAddress = new MailAddress(alumno.correo, alumno.nombre);
            const string fromPassword = "sistemaOOIA123";
            string subject = motivo;
            string body = mensaje;
            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }
        }


        private GestionAtencionWS.alumno asignarAlumno(GestionHumanaWS.alumno alumno)
        {
            GestionAtencionWS.alumno aux = new GestionAtencionWS.alumno();

            aux.id_alumno = alumno.id_alumno;
            aux.activo = alumno.activo;
            aux.codigo = alumno.codigo;
            aux.craest = alumno.craest;
            aux.creditos_aprobados = alumno.creditos_aprobados;
            GestionAtencionWS.especialidad auxEspecialidad = new GestionAtencionWS.especialidad();
            auxEspecialidad.nombre = alumno.especialidad.nombre;
            auxEspecialidad.activo = true;
            auxEspecialidad.id_especialidad = alumno.especialidad.id_especialidad;
            aux.especialidad = auxEspecialidad;
            aux.correo = alumno.correo;
            aux.direccion = alumno.direccion;
            aux.fecha_inclusion = alumno.fecha_inclusion;
            aux.fecha_nacimiento = alumno.fecha_nacimiento;
            aux.fecha_inclusionSpecified = true;
            aux.fecha_nacimientoSpecified = true;
            aux.dni = alumno.dni;
            aux.id_miembro_pucp = alumno.id_miembro_pucp;
            aux.id_alumno = alumno.id_alumno;
            aux.id_persona = alumno.id_persona;
            aux.imagenDePerfil = alumno.imagenDePerfil;
            aux.password = alumno.password;
            aux.usuario = alumno.usuario;
            aux.nombre = alumno.nombre;
            return aux;
    }
    private GestionAtencionWS.miembroPUCP asignarAsesor(GestionHumanaWS.miembroPUCP asesor)
    {
        GestionAtencionWS.miembroPUCP aux = new GestionAtencionWS.miembroPUCP();

        GestionAtencionWS.especialidad auxEspecialidad = new GestionAtencionWS.especialidad();
        auxEspecialidad.nombre = alumno.especialidad.nombre;
        auxEspecialidad.activo = true;
        auxEspecialidad.id_especialidad = alumno.especialidad.id_especialidad;
        aux.correo = asesor.correo;
        aux.direccion = asesor.direccion;
        aux.fecha_inclusion = asesor.fecha_inclusion;
        aux.fecha_nacimiento = asesor.fecha_nacimiento;
        aux.fecha_inclusionSpecified = true;
        aux.fecha_nacimientoSpecified = true;
        aux.dni = alumno.dni;
        aux.id_miembro_pucp = asesor.id_miembro_pucp;
        aux.id_persona = alumno.id_persona;
        aux.imagenDePerfil = alumno.imagenDePerfil;
        aux.password = alumno.password;
        aux.usuario = alumno.usuario;
        aux.nombre = alumno.nombre;
        return aux;
    }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            GestionAtencionWS.cita[] aux = daoCita.listarCitaHistoricoXNombre(this.alumno.id_alumno,txtNombreAsesor.Text);
            if (aux == null) return;
            BindingList<GestionAtencionWS.cita>
               citasAlumnos = new BindingList<GestionAtencionWS.cita>
               (aux.ToList());
            dgvHistorialCitas.DataSource = citasAlumnos;
        }

        private void tabCitasProgramadas_Click(object sender, EventArgs e)
        {

        }
    }
}
