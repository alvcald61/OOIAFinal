using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ProyectoOOIA.Ventanas
{
    public partial class frmCitasAlumno : Form
    {
        //private CitaOOIAWS.CitaOOIAWSClient daoCita;
        //private HorarioAWS.HorarioAWSClient daoHorario;
        //private MiembroPUCPAWS.MiembroPUCPAWSClient daoMiembroPUCP;
        private Estado estado;
        private GestionHumanaWS.persona persona;
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd,
            int wMsg, int wParam, int lParam);

        public frmCitasAlumno()
        {
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
        }



        public void clearall()
        {
            txtAsesor.Text = "";
            txtHoraInicio.Text = "";
            txtHoraFin.Text = "";
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
            //new frmCancelarCitaAlumno().ShowDialog();
            DialogResult dr =
               MessageBox.Show("¿Esta seguro que desea cancelar esta cita?", "Cancelación de cita",
               MessageBoxButtons.YesNo, MessageBoxIcon.None);
            if (dr == DialogResult.Yes)
            {
                MessageBox.Show("La cita ha sido cancelada exitosamente", "Cita cancelada", MessageBoxButtons.OK);
            }

        }

        private void btnDetalleHistorial_Click(object sender, EventArgs e)
        {
            //tenemos que almacenar los datos en la pantalla
            new frmDetalleCitaAlumno().ShowDialog();
            //this.Close();
            this.DialogResult = DialogResult.OK;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0xA1, 0x2, 0);
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
            if (txtHoraInicio.Text == "" || txtHoraFin.Text == "")
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

            if (estado.Equals(Estado.Nuevo))
            {
                DialogResult dr =
                MessageBox.Show("¿Esta seguro que desea programar la cita?", "Registro de cita",
                MessageBoxButtons.YesNo, MessageBoxIcon.None);
                if (dr == DialogResult.Yes)
                {
                    //int resultado = daoCita.insertar(cita);
                    int resultado = 1;
                    if (resultado != 0)
                    {
                        MessageBox.Show("La cita ha sido registrada exitosamente", "Mensaje Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.estado = Estado.Inicial;
                        cambiarEstado();
                    }
                    else MessageBox.Show("Ha ocurrido un error", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (estado.Equals(Estado.Modificar))
            {
                DialogResult dr =
                MessageBox.Show("¿Esta seguro que desea modificar la cita?", "Modificación de cita",
                MessageBoxButtons.YesNo, MessageBoxIcon.None);
                if (dr == DialogResult.Yes)
                {
                    //int resultado = daoCita.modificar(cita);
                    int resultado = 1;
                    if (resultado != 0)
                    {
                        MessageBox.Show("La cita ha sido modificada exitosamente", "Mensaje Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.estado = Estado.Inicial;
                        cambiarEstado();
                    }
                    else MessageBox.Show("Ha ocurrido un error", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {

            new frmInicioSesion().Show();
            this.Close();
        }

        private void btnAgregarOpinion_Click(object sender, EventArgs e)
        {
            new frmAgregarOpinion().ShowDialog();

        }

        private void btnBuscarAsesor_Click(object sender, EventArgs e)
        {
            new frmListaTutores().Show();
        }

        private void btnBuscarHorario_Click(object sender, EventArgs e)
        {
            new frmHorarioCita().Show();
        }

        private void btnDetInscritas_Click(object sender, EventArgs e)
        {
            new frmDetalleCitaAlumno().ShowDialog();
            this.DialogResult = DialogResult.OK;
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
    }
}
