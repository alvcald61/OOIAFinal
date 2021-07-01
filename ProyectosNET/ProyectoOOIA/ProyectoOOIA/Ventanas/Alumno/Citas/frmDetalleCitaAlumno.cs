using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ProyectoOOIA.Ventanas
{
    public partial class frmDetalleCitaAlumno : Form
    {
        private GestionAtencionWS.GestionAtencionWSClient daoCita;
        public frmDetalleCitaAlumno(GestionAtencionWS.cita cita, int estado_cita)
        {
            
            InitializeComponent();
            daoCita = new GestionAtencionWS.GestionAtencionWSClient();

            buscarOpinion(cita);
            txtOrientador.ReadOnly = true;
            txtCompromiso.ReadOnly = true;
            txtMotivoConsulta.ReadOnly = true;
            txtHoraInicio.ReadOnly = true;
            txtOpinion.ReadOnly = true;
            txtValoracion.ReadOnly = true;
            txtHoraFin.ReadOnly = true;
            dtpFecha.Enabled = false;
            dtpFecha.Value = cita.fecha;
            txtOrientador.Text = cita.asesor.nombre;
            txtMotivoConsulta.Text = cita.motivo;
            txtCompromiso.Text = cita.compromiso;
            txtHoraInicio.Text = cita.horario.horaInicio.ToString("hh:mm");
            txtHoraFin.Text = cita.horario.horaFin.ToString("hh:mm");
            if (estado_cita == 1)
            {
                lbestadoCita.Text = "Pendiente";
                lbestadoCita.ForeColor = Color.Red;
            }
            if (estado_cita == 2)
            {
                lbestadoCita.Text = "Finalizada";
                lbestadoCita.ForeColor = Color.Green;
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
                if (e.fid_cita == cita.id_cita)
                {
                    String descripcion_puntaje="";
                    txtOpinion.Text = e.descripcion;

                    if (e.puntaje == 1) descripcion_puntaje = " Pésimo";
                    if (e.puntaje == 2) descripcion_puntaje = " Malo";
                    if (e.puntaje == 3) descripcion_puntaje = " Normal";
                    if (e.puntaje == 4) descripcion_puntaje = " Bueno";
                    if (e.puntaje == 5) descripcion_puntaje = " Excelente";

                    txtValoracion.Text = e.puntaje.ToString() + descripcion_puntaje;
                }
                    
            }
            
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {

            this.Close();
        }


    }
}
