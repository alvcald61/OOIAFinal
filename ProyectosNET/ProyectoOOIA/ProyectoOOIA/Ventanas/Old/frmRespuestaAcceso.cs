using System;
using System.Windows.Forms;

namespace ProyectoOOIA.Ventanas
{
    public partial class frmRespuestaAcceso : Form
    {
        private Boolean estado;
        public frmRespuestaAcceso()
        {
            InitializeComponent();
        }
        public frmRespuestaAcceso(Boolean estado)
        {
            InitializeComponent();
            this.estado = estado;
        }
    }
}
