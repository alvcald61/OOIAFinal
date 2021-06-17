using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoOOIA.Ventanas.Miembro_OOIA.Cargar_Datos.Gestion_Academica
{
    public partial class frmBuscarCursosLlevados : Form
    {
        private CursoLlevadoWS.CursoLlevadoWSClient daoCurso;
        private CursoLlevadoWS.cursoLlevado _curso;
        private GestionHumanaWS.alumno alumno;

        public CursoLlevadoWS.cursoLlevado CursoLlevado { get => _curso; set => _curso = value; }
        public frmBuscarCursosLlevados()
        {
            InitializeComponent();
            dgvCursos.AutoGenerateColumns = false;
            daoCurso = new CursoLlevadoWS.CursoLlevadoWSClient();
        }


        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarAlumno frmBuscar = new frmBuscarAlumno();
            if (frmBuscar.ShowDialog() == DialogResult.OK)
            {

                this.alumno = frmBuscar.Alumno;
                txtNombre.Text = alumno.nombre;
                BindingList<CursoLlevadoWS.cursoLlevado>
                cursos = new BindingList<CursoLlevadoWS.cursoLlevado>
                (daoCurso.listarCursoLlevado(alumno.id_alumno).ToList());
                dgvCursos.DataSource = cursos;
                
            }
            
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

   
        
        private void dgvCursos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            CursoLlevadoWS.cursoLlevado data = dgvCursos.Rows[e.RowIndex].DataBoundItem
           as CursoLlevadoWS.cursoLlevado;
            dgvCursos.Rows[e.RowIndex].Cells["NombreCurso"].Value = data.curso.nombreCurso;
        }
    }
}
