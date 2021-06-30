using System;
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
        
        public frmDetalleCitaAsesor(GestionAtencionWS.cita cita)
        {
            InitializeComponent();

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
            //new frmDetalleCitaAlumno().Show();
        }

        private void btnDetEventosPrev_Click(object sender, EventArgs e)
        {
            //new frmDetalleEvento().Show();
        }

        private void activarError(Object sender,EventArgs evento)
        {
            switch ((sender as TextBox).Name)
            {
                case "txtCodigo":
                    errorCod.SetError((sender as TextBox),"Debe llenar el codigo del alumno");
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
            switch ( (sender as TextBox).Name){
                case "txtCodigo":
                    errorCod.Clear();
                    break;
                case "txtCorreo":
                    errorContacto.Clear();
                    break;
                case "txtEspecialidad":
                    errorEsp.Clear();break;
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
    }
}
