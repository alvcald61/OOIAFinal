using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoOOIA.Ventanas.Miembro_OOIA.Cargar_Datos
{

    public partial class frmBuscarAlumno : Form
    {
        private GestionHumanaWS.GestionHumanaWSClient daoAlumno;
        private GestionHumanaWS.alumno _alumno;

        public GestionHumanaWS.alumno Alumno { get => _alumno; set => _alumno = value; }

        public frmBuscarAlumno()
        {
            InitializeComponent();
            dgvAlumnos.AutoGenerateColumns = false;
            daoAlumno = new GestionHumanaWS.GestionHumanaWSClient();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BindingList<GestionHumanaWS.alumno>
                alumnos = new BindingList<GestionHumanaWS.alumno>
                (daoAlumno.listarAlumno().ToList());
            dgvAlumnos.DataSource = alumnos;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvAlumnos.CurrentRow != null)
            {
                _alumno =
              (GestionHumanaWS.alumno)dgvAlumnos.CurrentRow.DataBoundItem;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void dgvAlumnos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            GestionHumanaWS.alumno data = dgvAlumnos.Rows[e.RowIndex].DataBoundItem
            as GestionHumanaWS.alumno;
            dgvAlumnos.Rows[e.RowIndex].Cells["Especialidad"].Value = data.especialidad.nombre;
        }
    }
}
