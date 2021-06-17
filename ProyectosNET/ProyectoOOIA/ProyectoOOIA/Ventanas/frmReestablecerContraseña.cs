using System;
using System.Windows.Forms;

namespace ProyectoOOIA.Ventanas
{
    public partial class frmReestablecerContraseña : Form
    {
        public frmReestablecerContraseña()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose(true);
        }

        private void btnReestablecer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nueva contraseña enviada al correo:\n" + txtContraseña.Text, "Contraseña Reestablecida", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
