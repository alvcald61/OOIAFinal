using System;
using System.Windows.Forms;

namespace ProyectoOOIA.Ventanas
{
    public partial class frmConfirmarOpinion : Form
    {
        public frmConfirmarOpinion()
        {
            InitializeComponent();
        }

        private void btnSi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Su opinión ha sido registrada exitosamente", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
