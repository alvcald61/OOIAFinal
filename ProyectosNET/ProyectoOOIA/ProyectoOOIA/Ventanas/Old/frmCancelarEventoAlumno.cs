using System;
using System.Windows.Forms;

namespace ProyectoOOIA.Ventanas
{
    public partial class frmCancelarEventoAlumno : Form
    {
        public frmCancelarEventoAlumno()
        {
            InitializeComponent();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se elimino exitosamente", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void lblMensaje_Click(object sender, EventArgs e)
        {

        }
    }
}
