using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoOOIA.Ventanas.Miembro_OOIA.Cargar_Datos
{

    public partial class frmBuscarPsicologo : Form
    {
        private PsicologoWS.PsicologoWSClient daoPsicologo;
        private PsicologoWS.psicologo _psicologo;

        public PsicologoWS.psicologo Psicologo { get => _psicologo; set => _psicologo = value; }

        public frmBuscarPsicologo()
        {
            InitializeComponent();
            dgvPsicologos.AutoGenerateColumns = false;
            daoPsicologo = new PsicologoWS.PsicologoWSClient();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BindingList<PsicologoWS.psicologo>
                psicologos = new BindingList<PsicologoWS.psicologo>
                (daoPsicologo.listarPsicologo());
            dgvPsicologos.DataSource = psicologos;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvPsicologos.CurrentRow != null)
            {
                _psicologo =
              (PsicologoWS.psicologo)dgvPsicologos.CurrentRow.DataBoundItem;
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
