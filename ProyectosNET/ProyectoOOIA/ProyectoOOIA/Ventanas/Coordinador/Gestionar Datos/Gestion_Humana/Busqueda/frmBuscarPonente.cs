using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoOOIA.Ventanas.Miembro_OOIA.Cargar_Datos
{

    public partial class frmBuscarPonente : Form
    {
        private GestionHumanaWS.GestionHumanaWSClient daoPonente;
        private GestionHumanaWS.ponente _ponente;

        public GestionHumanaWS.ponente Ponente { get => _ponente; set => _ponente = value; }

        public frmBuscarPonente()
        {
            InitializeComponent();
            dgvPonentes.AutoGenerateColumns = false;
            daoPonente = new GestionHumanaWS.GestionHumanaWSClient();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BindingList<GestionHumanaWS.ponente>
                ponentes = new BindingList<GestionHumanaWS.ponente>
                (daoPonente.listarPonente());
            dgvPonentes.DataSource = ponentes;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvPonentes.CurrentRow != null)
            {
                _ponente =
              (GestionHumanaWS.ponente)dgvPonentes.CurrentRow.DataBoundItem;
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
