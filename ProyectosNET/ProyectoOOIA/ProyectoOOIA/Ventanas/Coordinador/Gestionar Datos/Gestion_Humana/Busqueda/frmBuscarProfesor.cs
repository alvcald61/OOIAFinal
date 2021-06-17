using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoOOIA.Ventanas.Miembro_OOIA.Cargar_Datos
{

    public partial class frmBuscarProfesor : Form
    {
        private ProfesorWS.ProfesorWSClient daoProfesor;
        private ProfesorWS.profesor _profesor;

        public ProfesorWS.profesor Profesor { get => _profesor; set => _profesor = value; }

        public frmBuscarProfesor()
        {
            InitializeComponent();
            dgvProfesores.AutoGenerateColumns = false;
            daoProfesor = new ProfesorWS.ProfesorWSClient();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BindingList<ProfesorWS.profesor>
                profesores = new BindingList<ProfesorWS.profesor>
                (daoProfesor.listarProfesor().ToList());
            dgvProfesores.DataSource = profesores;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvProfesores.CurrentRow != null)
            {
                _profesor =
              (ProfesorWS.profesor)dgvProfesores.CurrentRow.DataBoundItem;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void dgvProfesores_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            ProfesorWS.profesor data = dgvProfesores.Rows[e.RowIndex].DataBoundItem
            as ProfesorWS.profesor;
            dgvProfesores.Rows[e.RowIndex].Cells["Especialidad"].Value = data.especialidad.nombre;
        }
    }
}

