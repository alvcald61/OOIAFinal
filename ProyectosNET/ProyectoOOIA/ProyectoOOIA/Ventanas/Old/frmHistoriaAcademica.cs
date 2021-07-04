using System;
using System.Windows.Forms;

namespace ProyectoOOIA.Ventanas
{
    public partial class frmHistoriaAcademica : Form
    {
        public frmHistoriaAcademica()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNotasParciales_Click(object sender, EventArgs e)
        {
            frmNotasParciales notasParciales = new frmNotasParciales();
            notasParciales.ShowDialog();
        }
    }
}
