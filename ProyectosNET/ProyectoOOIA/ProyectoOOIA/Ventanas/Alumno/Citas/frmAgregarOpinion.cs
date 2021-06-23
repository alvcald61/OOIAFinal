using System;
using System.Windows.Forms;

namespace ProyectoOOIA.Ventanas
{
    public partial class frmAgregarOpinion : Form
    {
        private GestionAtencionWS.GestionAtencionWSClient daoEncuesta;
        private GestionAtencionWS.encuesta encuesta;
        private GestionAtencionWS.alumno alumno;
        private GestionAtencionWS.miembroPUCP  asesor;
        private GestionAtencionWS.cita cita = new GestionAtencionWS.cita();

        public frmAgregarOpinion(int idCita,GestionAtencionWS.miembroPUCP asesor, GestionAtencionWS.alumno alumno)
        {
            
            encuesta = new GestionAtencionWS.encuesta();
            this.alumno = alumno;
            this.asesor = asesor;
            encuesta.asesor = asesor;
            encuesta.alumno = alumno;
            encuesta.fid_cita = idCita;
            daoEncuesta = new GestionAtencionWS.GestionAtencionWSClient();
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           
            DialogResult dr =
               MessageBox.Show("¿Esta seguro que desea agregar su opinión?", "Agregar opinión de Asesor",
               MessageBoxButtons.YesNo, MessageBoxIcon.None);
            if (dr == DialogResult.Yes)
            {
                encuesta.descripcion = txtDescripcion.Text;
                if (radioButton1.Checked)
                {
                    encuesta.puntaje = 1;
                }else if (radioButton2.Checked)
                {
                    encuesta.puntaje = 2;
                }else if (radioButton3.Checked)
                {
                    encuesta.puntaje = 3;
                }else if (radioButton4.Checked)
                {
                    encuesta.puntaje = 4;
                }else if (radioButton5.Checked)
                {
                    encuesta.puntaje = 5;
                }
                else
                {
                    encuesta.puntaje = -1;
                }

                if (daoEncuesta.insertarEncuesta(encuesta) == 1)
                {
                    MessageBox.Show("El registro ha sido exitoso", "Exito", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }
                else
                    MessageBox.Show("Ha habido un error", "Error", MessageBoxButtons.RetryCancel,
                        MessageBoxIcon.Error);

                this.Close();
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
