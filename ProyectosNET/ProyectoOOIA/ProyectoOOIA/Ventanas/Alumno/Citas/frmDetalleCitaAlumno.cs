using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ProyectoOOIA.Ventanas
{
    public partial class frmDetalleCitaAlumno : Form
    {
 
        public frmDetalleCitaAlumno(GestionAtencionWS.cita cita)
        {
            InitializeComponent();
            txtOrientador.ReadOnly = true;
            txtCompromiso.ReadOnly = true;
            txtMotivoConsulta.ReadOnly = true;
            txtHoraInicio.ReadOnly = true;
            rbAsistio.Enabled = false;
            rbNoAsistio.Enabled = false;
            txtHoraFin.ReadOnly = true;
            dtpFecha.Enabled = false;
            dtpFecha.Value = cita.fecha;
            txtOrientador.Text = cita.asesor.nombre;
            txtMotivoConsulta.Text = cita.motivo;
            txtCompromiso.Text = cita.compromiso;
            txtHoraInicio.Text = cita.horario.horaInicio.ToString("hh:mm");
            txtHoraFin.Text = cita.horario.horaFin.ToString("hh:mm");
            if(cita.asistio == true)
            {
                rbAsistio.Checked = true;
            }
            else
            {
                rbNoAsistio.Checked = true;
            }

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {

            this.Close();
        }


    }
}
