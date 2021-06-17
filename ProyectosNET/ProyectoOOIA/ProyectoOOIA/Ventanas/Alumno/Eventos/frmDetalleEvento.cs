using System;
using System.Windows.Forms;

namespace ProyectoOOIA.Ventanas
{
    public partial class frmDetalleEvento : Form
    {
        private int flag;
        //frmPrincipalEventos principalEventos = null;

        public frmDetalleEvento()
        {
            InitializeComponent();
        }



        public frmDetalleEvento(int flag)
        {
            this.flag = flag;
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

            //if (principalEventos != null)
            //{
            //    new frmInscripcionEvento(principalEventos).Show();
            //}
            // else
            // {
            //    new frmInscripcionEvento(listaEventos).Show();
            //}
            this.Close();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
