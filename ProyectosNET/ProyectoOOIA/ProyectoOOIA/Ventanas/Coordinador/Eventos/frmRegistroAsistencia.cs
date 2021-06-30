using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoOOIA.Ventanas.Coordinador.Eventos
{
    public partial class frmRegistroAsistencia : Form
    {
        GestionHumanaWS.GestionHumanaWSClient daoAlumno;
        GestionEventoWS.evento evento;
        public frmRegistroAsistencia(GestionEventoWS.evento evento)
        {

            
            InitializeComponent();
            this.evento=evento;
            dgvAlumnos.AutoGenerateColumns = false;
            daoAlumno = new GestionHumanaWS.GestionHumanaWSClient();
            try
            {
                BindingList<GestionHumanaWS.alumno>
                alumnos = new BindingList<GestionHumanaWS.alumno>
                (daoAlumno.listar_alumno_x_evento(this.evento.id_evento).ToList());
                dgvAlumnos.DataSource = alumnos;
            }
            catch
            {

            }

        }

        private void dgvAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmRegistroAsistencia_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void dgvAlumnos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            GestionHumanaWS.alumno data = dgvAlumnos.Rows[e.RowIndex].DataBoundItem
            as GestionHumanaWS.alumno;
            dgvAlumnos.Rows[e.RowIndex].Cells[0].Value = data.codigo;
            dgvAlumnos.Rows[e.RowIndex].Cells[1].Value = data.nombre;
            dgvAlumnos.Rows[e.RowIndex].Cells[2].Value = data.especialidad.nombre;
            dgvAlumnos.Rows[e.RowIndex].Cells[3].Value = daoAlumno.obtener_estado(evento.id_evento,data.id_alumno);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            for(int i = 0; i < dgvAlumnos.RowCount; i++)
            {
                int id_alumno = (dgvAlumnos.Rows[i].DataBoundItem as GestionHumanaWS.alumno).id_alumno;
                
                try
                {
                    bool estado=(bool)dgvAlumnos.Rows[i].Cells[3].Value;
                    daoAlumno.modifcar_asistencia(evento.id_evento, id_alumno, estado);
                }
                catch
                {

                }

                
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblBuscarEventos_Click(object sender, EventArgs e)
        {

        }
    }
}
