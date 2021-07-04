using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoOOIA.Ventanas.Miembro_OOIA.Cargar_Datos
{

    public partial class frmBuscarProfesor : Form
    {
        private GestionHumanaWS.GestionHumanaWSClient daoProfesor;
        private GestionHumanaWS.profesor _profesor;

        public GestionHumanaWS.profesor Profesor { get => _profesor; set => _profesor = value; }

        public frmBuscarProfesor()
        {
            InitializeComponent();
            dgvProfesores.AutoGenerateColumns = false;
            daoProfesor = new GestionHumanaWS.GestionHumanaWSClient();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                BindingList<GestionHumanaWS.profesor>
                    profesores = new BindingList<GestionHumanaWS.profesor>
                    (daoProfesor.listarProfesor(txtNombre.Text).ToList());
                dgvProfesores.DataSource = profesores;
            }
            catch
            {
                return;
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvProfesores.CurrentRow != null)
            {
                _profesor =
              (GestionHumanaWS.profesor)dgvProfesores.CurrentRow.DataBoundItem;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void dgvProfesores_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            GestionHumanaWS.profesor data = dgvProfesores.Rows[e.RowIndex].DataBoundItem
            as GestionHumanaWS.profesor;
            dgvProfesores.Rows[e.RowIndex].Cells["Especialidad"].Value = data.especialidad.nombre;
        }
    }
}

