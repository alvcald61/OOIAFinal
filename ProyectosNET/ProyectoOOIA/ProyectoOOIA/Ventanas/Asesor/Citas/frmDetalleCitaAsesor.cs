using System;
using System.Windows.Forms;

namespace ProyectoOOIA.Ventanas
{
    public partial class frmDetalleCitaAsesor : Form
    {
        public frmDetalleCitaAsesor()
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
            new frmDetalleCitaAsesor().Show();
        }

        private void btnDetEventosPrev_Click(object sender, EventArgs e)
        {
            new frmDetalleEvento().Show();
        }
    }
}
