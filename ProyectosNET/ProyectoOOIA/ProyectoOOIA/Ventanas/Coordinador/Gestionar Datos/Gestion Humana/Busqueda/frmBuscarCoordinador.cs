using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoOOIA.Ventanas.Miembro_OOIA.Cargar_Datos
{

    public partial class frmBuscarCoordinador : Form
    {
        private GestionHumanaWS.GestionHumanaWSClient daoCoordinador;
        private GestionHumanaWS.coordinador _coordinador;

        public GestionHumanaWS.coordinador Coordinador { get => _coordinador; set => _coordinador = value; }

        public frmBuscarCoordinador()
        {
            InitializeComponent();
            dgvCoordinadores.AutoGenerateColumns = false;
            daoCoordinador = new GestionHumanaWS.GestionHumanaWSClient();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BindingList<GestionHumanaWS.coordinador>
                coordinadores = new BindingList<GestionHumanaWS.coordinador>
                (daoCoordinador.listarCoordinador());
            dgvCoordinadores.DataSource = coordinadores;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvCoordinadores.CurrentRow != null)
            {
                _coordinador =
              (GestionHumanaWS.coordinador)dgvCoordinadores.CurrentRow.DataBoundItem;
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
