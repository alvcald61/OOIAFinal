using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoOOIA.Ventanas
{
    public partial class frmEliminarEventoOOIA : Form
    {
        public frmEliminarEventoOOIA()
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
    }
}
