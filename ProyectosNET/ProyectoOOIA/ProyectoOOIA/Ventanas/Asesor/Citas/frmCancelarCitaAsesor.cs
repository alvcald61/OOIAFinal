using System;
using System.Windows.Forms;

namespace ProyectoOOIA.Ventanas
{
    public partial class frmCancelarCitaAsesor : Form
    {
        public frmCancelarCitaAsesor()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dgvOpiniones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelarCita_Click(object sender, EventArgs e)
        {
            //new frmConfirmarCancelarAsesor().Show();
            DialogResult dr =
               MessageBox.Show("¿Esta seguro que desea cancelar la cita?", "Cancelar cita",
               MessageBoxButtons.YesNo, MessageBoxIcon.None);
            if (dr == DialogResult.Yes)
            {
                MessageBox.Show("La cita ha sido cambiada exitosamente", "Cita Cancelada", MessageBoxButtons.OK);
                this.Close();
            }
        }


    }
}
