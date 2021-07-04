using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoOOIA.Ventanas.Miembro_OOIA.Cargar_Datos
{

    public partial class frmBuscarPsicologo : Form
    {
        private GestionHumanaWS.GestionHumanaWSClient daoPsicologo;
        private GestionHumanaWS.psicologo _psicologo;

        public GestionHumanaWS.psicologo Psicologo { get => _psicologo; set => _psicologo = value; }

        public frmBuscarPsicologo()
        {
            InitializeComponent();
            dgvPsicologos.AutoGenerateColumns = false;
            daoPsicologo = new GestionHumanaWS.GestionHumanaWSClient();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BindingList<GestionHumanaWS.psicologo>
                psicologos = new BindingList<GestionHumanaWS.psicologo>
                (daoPsicologo.listarPsicologo(txtNombre.Text));
            dgvPsicologos.DataSource = psicologos;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvPsicologos.CurrentRow != null)
            {
                _psicologo =
              (GestionHumanaWS.psicologo)dgvPsicologos.CurrentRow.DataBoundItem;
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
