using System;
using System.Windows.Forms;

namespace ProyectoOOIA.Ventanas
{
    public partial class frmPrincipalMiembroOOIA : Form
    {
        public frmPrincipalMiembroOOIA()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new frmGestionEventosOOIA(Estado.Inicial).Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new frmInicioSesion().Show();
            this.Close();
        }
    }
}
