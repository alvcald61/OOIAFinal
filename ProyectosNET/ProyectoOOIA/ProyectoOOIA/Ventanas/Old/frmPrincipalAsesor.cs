using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoOOIA.Ventanas
{
    public partial class frmPrincipalAsesor : Form
    {
        private int indice;
        private BindingList<Bitmap> listaImagenes = new BindingList<Bitmap>();

        public frmPrincipalAsesor()
        {
            InitializeComponent();
            listaImagenes.Add(ProyectoOOIA.Properties.Resources.profesor);
            listaImagenes.Add(ProyectoOOIA.Properties.Resources.EEGGCC);
            listaImagenes.Add(ProyectoOOIA.Properties.Resources.Estudiante);
            listaImagenes.Add(ProyectoOOIA.Properties.Resources.Tramite);
            imagenes.Image = listaImagenes[0];
            //ToolTip ttEjemplo = new ToolTip();



        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            new frmInicioSesion().Show();
            this.Close();
        }

        private void txtHorarios_Click(object sender, EventArgs e)
        {

        }

        private void txtEventos_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new frmHorarioAsesor().Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new frmRegistroEvento().Show();
            this.Close();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            indice++;
            if (indice >= listaImagenes.Count)
                indice = 0;
            imagenes.Image = listaImagenes[indice];
        }
    }
}
