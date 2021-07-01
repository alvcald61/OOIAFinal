using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoOOIA.Ventanas
{
    public partial class frmDetalleCitaAsesor : Form
    {

        ErrorProvider errorCod;
        ErrorProvider errorContacto;
        ErrorProvider errorEsp;
        ErrorProvider errorNacimiento;
        ErrorProvider errorLugar;
        ErrorProvider errorEdad;
        ErrorProvider errorDireccion;
        private GestionAtencionWS.GestionAtencionWSClient daoCita;
        private GestionEventoWS.evento evento;
        private GestionEventoWS.GestionEventoWSClient daoEvento;
        private GestionAtencionWS.cita cita;
        private BindingList<GestionAtencionWS.codigoAtencion> codigos;

        public frmDetalleCitaAsesor(GestionAtencionWS.cita cita)
        {
            InitializeComponent();
            daoCita = new GestionAtencionWS.GestionAtencionWSClient();
            daoEvento = new GestionEventoWS.GestionEventoWSClient();

            dvgCitasPasadas.AutoGenerateColumns = false;
            dvgEventosPasados.AutoGenerateColumns = false;
            this.cita = cita;
            txtCodigo.ReadOnly = true;
            txtEspecialidad.ReadOnly = true;
            txtFechaNac.ReadOnly = true;
            txtDireccion.ReadOnly = true;
            txtMotivo.ReadOnly = true;
            btnGuardar.Visible = false;
            llenaDetalle(); //si es nueva, aun no puedo llenar datos
            //si la cita ya es pasada
            if ((this.cita.fecha < DateTime.Now.Date) || ((this.cita.fecha==DateTime.Now.Date) && (this.cita.horario.horaFin.Hour<DateTime.Now.Hour))) 
                    modificarFichaAtencion();
           

            listarHistorialCitas();
            listarHistorialEventos();

        }

        private void llenaDetalle()
        {
            txtMotivo.Text = this.cita.motivo;
            txtHeader.Text = "Cita - " + this.cita.fecha.ToString("dd.MM.yyyy") + " " + this.cita.horario.horaInicio.ToString("hh:mm");
            lbNombreAlumno.Text = this.cita.alumno.nombre;
            lbNombre_ficha.Text = this.cita.alumno.nombre;
            lbNombre_eventos_cita.Text = this.cita.alumno.nombre;
            txtCodigo.Text = this.cita.alumno.codigo;
            txtEspecialidad.Text = this.cita.alumno.especialidad.nombre;
            txtFechaNac.Text = this.cita.alumno.fecha_nacimiento.ToString("dd/MM/yyyy");
            txtDireccion.Text = this.cita.alumno.direccion;
            cbCodigoAtencion.Enabled = false;
            txtCompromiso.Enabled = false;
            rbAsistio.Enabled = false;
            rbNoAsistio.Enabled = false;
            //cbCodigoAtencion.Text = this.cita.codigo_atencion.descripcion;
        }

        private void modificarFichaAtencion()
        {
            codigos = new BindingList<GestionAtencionWS.codigoAtencion>((daoCita.listarCodigo()).ToList());
            txtCompromiso.Enabled = true;
            txtCompromiso.ReadOnly = false;
            cbCodigoAtencion.Enabled = true;
            cbCodigoAtencion.DataSource = codigos;
            cbCodigoAtencion.DisplayMember = "descripcion";
            btnGuardar.Visible = true;
          
            rbAsistio.Enabled = true;
            rbNoAsistio.Enabled = true;
            

        }
        private void listarHistorialCitas()
        {
            GestionAtencionWS.cita[] aux = daoCita.listarCitaHistorico(this.cita.alumno.id_alumno);
            if (aux == null) return;
            BindingList<GestionAtencionWS.cita>
               citasAlumnos = new BindingList<GestionAtencionWS.cita>
               (aux.ToList());
            dvgCitasPasadas.DataSource = citasAlumnos;
        }

        private void listarHistorialEventos()
        {
            GestionEventoWS.evento[] aux = daoEvento.listar_eventos_pasados(this.cita.alumno.id_alumno);
            if (aux == null) return;
            BindingList<GestionEventoWS.evento>
               eventosAlumnos = new BindingList<GestionEventoWS.evento>
               (aux.ToList());
            dvgEventosPasados.DataSource = eventosAlumnos;
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmHistoriaAcademica historiaAcademica = new frmHistoriaAcademica();
            historiaAcademica.ShowDialog();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDetCitasPrev_Click(object sender, EventArgs e)
        {

            if (dvgCitasPasadas.CurrentRow != null)
            {
                GestionAtencionWS.cita cita_seleccionado =
              (GestionAtencionWS.cita)dvgCitasPasadas.CurrentRow.DataBoundItem;

                new frmDetalleCitaAlumno(cita_seleccionado,2).Show();
            }
        }

        private void btnDetEventosPrev_Click(object sender, EventArgs e)
        {
            //new frmDetalleEvento().Show();
            if (dvgEventosPasados.CurrentRow != null)
            {
                GestionEventoWS.evento evento_seleccionado =
              (GestionEventoWS.evento)dvgEventosPasados.CurrentRow.DataBoundItem;

                new frmDetalleEvento(evento_seleccionado).Show();
            }
        }

        private void activarError(Object sender, EventArgs evento)
        {
            switch ((sender as TextBox).Name)
            {
                case "txtCodigo":
                    errorCod.SetError((sender as TextBox), "Debe llenar el codigo del alumno");
                    break;
                case "txtCorreo":
                    errorContacto.Clear();
                    break;
                case "txtEspecialidad":
                    errorEsp.Clear(); break;
                case "txtLugarNac":
                    errorLugar.Clear(); break;
                case "txtFechaNac":
                    errorNacimiento.Clear(); break;
                case "txtEdad":
                    errorEdad.Clear(); break;
                case "txtDireccion":
                    errorDireccion.Clear(); break;
            }
        }
        private void desactivarError(Object sender, EventArgs evento)
        {
            //error.Clear();
            switch ((sender as TextBox).Name)
            {
                case "txtCodigo":
                    errorCod.Clear();
                    break;
                case "txtCorreo":
                    errorContacto.Clear();
                    break;
                case "txtEspecialidad":
                    errorEsp.Clear(); break;
                case "txtLugarNac":
                    errorLugar.Clear(); break;
                case "txtFechaNac":
                    errorNacimiento.Clear(); break;
                case "txtEdad":
                    errorEdad.Clear(); break;
                case "txtDireccion":
                    errorDireccion.Clear(); break;
            }
        }

        private void dvgCitasPasadas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            GestionAtencionWS.cita data = dvgCitasPasadas.Rows[e.RowIndex].DataBoundItem
            as GestionAtencionWS.cita;
            dvgCitasPasadas.Rows[e.RowIndex].Cells[0].Value = data.fecha.ToString("dd/MM/yyyy");
            dvgCitasPasadas.Rows[e.RowIndex].Cells[1].Value = data.asesor.nombre;

        }

        private void dvgEventosPasados_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            GestionEventoWS.evento data = dvgEventosPasados.Rows[e.RowIndex].DataBoundItem
            as GestionEventoWS.evento;
            dvgEventosPasados.Rows[e.RowIndex].Cells[0].Value = data.fecha.ToString("dd/MM/yyyy");
            dvgEventosPasados.Rows[e.RowIndex].Cells[1].Value = data.nombre;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtCompromiso.Text == "")
            {
                MessageBox.Show("No ha ingresado el asesor", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (rbNoAsistio.Checked == false && rbAsistio.Checked == false)
            {
                MessageBox.Show("No ha ingresado la asistencia del alumno", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.cita.compromiso = txtCompromiso.Text;
            if (rbNoAsistio.Checked == true) this.cita.asistio = 0;
            if (rbAsistio.Checked == true) this.cita.asistio = 1;
            this.cita.codigo_atencion.id_codigo_atencion = ((GestionAtencionWS.codigoAtencion)cbCodigoAtencion.SelectedItem).id_codigo_atencion;

            DialogResult dr =
               MessageBox.Show("¿Esta seguro que desea modificar la ficha de atención?", "Ficha de atención",
               MessageBoxButtons.YesNo, MessageBoxIcon.None);
            if (dr == DialogResult.Yes)
            {
                
                int resultado = daoCita.modificarCita(this.cita);
                if (resultado != 0)
                {
                    MessageBox.Show("La ficha de atención se ha modificado exitosamente", "Mensaje Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbCodigoAtencion.Enabled = false;
                    txtCompromiso.Enabled = false;
                    txtCompromiso.ReadOnly = true;
                    rbAsistio.Enabled = false;
                    rbNoAsistio.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
           
        }
    }
}
