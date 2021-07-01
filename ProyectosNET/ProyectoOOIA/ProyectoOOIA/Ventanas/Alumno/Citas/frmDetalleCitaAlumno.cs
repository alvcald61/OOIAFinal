using System;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ProyectoOOIA.Ventanas
{
    public partial class frmDetalleCitaAlumno : Form
    {
        private GestionAtencionWS.GestionAtencionWSClient daoCita;
        public frmDetalleCitaAlumno(GestionAtencionWS.cita cita)
        {
            
            InitializeComponent();
            daoCita = new GestionAtencionWS.GestionAtencionWSClient();

            buscarOpinion(cita);
            txtOrientador.ReadOnly = true;
            txtCompromiso.ReadOnly = true;
            txtMotivoConsulta.ReadOnly = true;
            txtHoraInicio.ReadOnly = true;
            txtOpinion.ReadOnly = true;
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
            if(cita.asistio == 0)
            {
                rbNoAsistio.Checked = true;
            }
            else
            {
                rbAsistio.Checked = true;
            }

        }

        private void buscarOpinion(GestionAtencionWS.cita cita)
        {
            GestionAtencionWS.encuesta[] aux = daoCita.listarEncuestaxAlumno(cita.alumno.id_alumno);
            if (aux == null) return;
            BindingList<GestionAtencionWS.encuesta>
               opiniones = new BindingList<GestionAtencionWS.encuesta>
               (aux.ToList());

            foreach(GestionAtencionWS.encuesta e in opiniones){
                if(e.fid_cita == cita.id_cita)
                    txtOpinion.Text = e.descripcion;
            }
            
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {

            this.Close();
        }


    }
}
