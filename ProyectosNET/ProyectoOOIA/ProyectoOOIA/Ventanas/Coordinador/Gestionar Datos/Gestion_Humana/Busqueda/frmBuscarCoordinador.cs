using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoOOIA.Ventanas.Miembro_OOIA.Cargar_Datos
{

    public partial class frmBuscarCoordinador : Form
    {
        private CoordinadorWS.CoordinadorWSClient daoCoordinador;
        private CoordinadorWS.coordinador _coordinador;

        public CoordinadorWS.coordinador Coordinador { get => _coordinador; set => _coordinador = value; }

        public frmBuscarCoordinador()
        {
            InitializeComponent();
            dgvCoordinadores.AutoGenerateColumns = false;
            daoCoordinador = new CoordinadorWS.CoordinadorWSClient();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BindingList<CoordinadorWS.coordinador>
                coordinadores = new BindingList<CoordinadorWS.coordinador>
                (daoCoordinador.listarCoordinador());
            dgvCoordinadores.DataSource = coordinadores;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvCoordinadores.CurrentRow != null)
            {
                _coordinador =
              (CoordinadorWS.coordinador)dgvCoordinadores.CurrentRow.DataBoundItem;
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
