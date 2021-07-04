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
        private GestionHumanaWS.GestionHumanaWSClient daoAlumno;
        private GestionEventoWS.evento evento;
        private BindingList<bool> lista;
        private int vez = 0;
        public frmRegistroAsistencia(GestionEventoWS.evento evento)
        {

            
            InitializeComponent();
            lista = new BindingList<bool>();
            this.evento=evento;
            dgvAlumnos.AutoGenerateColumns = false;
            daoAlumno = new GestionHumanaWS.GestionHumanaWSClient();
            try
            {
                //daoAlumno.obtener_estado(evento.id_evento, data.id_alumno);
                BindingList<GestionHumanaWS.alumno>
                alumnos = new BindingList<GestionHumanaWS.alumno>
                (daoAlumno.listar_alumno_x_evento(this.evento.id_evento).ToList());
                dgvAlumnos.DataSource = alumnos;
                bool b;

                for (int i = 0; i < alumnos.Count; i++)
                {
                    //if (new GestionAtencionWS.GestionAtencionWSClient().obtener_estado(evento.id_evento, alumnos[i].id_alumno, 0) == 1) b = true;
                    //else b = false;
                    //lista.Add(b);
                    lista.Add(new GestionEventoWS.GestionEventoWSClient().obtener_estado(this.evento.id_evento, alumnos[i].id_alumno));
                }
                vez = 1;

            }
            catch
            {

            }

            dgvAlumnos.RowsAdded += (object sender, DataGridViewRowsAddedEventArgs e) =>
              {
                  dgvAlumnos.Rows[e.RowIndex].Cells["Asistencia"].Value = lista[e.RowIndex];
              };


        }

        

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();

        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea guardar los cambios?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            foreach(DataGridViewRow row in dgvAlumnos.Rows)
            {
                    int id_alumno = (row.DataBoundItem as GestionHumanaWS.alumno).id_alumno;
                    bool estado=(bool)row.Cells[3].Value;
                    daoAlumno.modifcar_asistencia(evento.id_evento, id_alumno, estado);
            }
        }



        private void dgvAlumnos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            GestionHumanaWS.alumno data = dgvAlumnos.Rows[e.RowIndex].DataBoundItem
                    as GestionHumanaWS.alumno;
            
            dgvAlumnos.Rows[e.RowIndex].Cells[0].Value = data.codigo;
            dgvAlumnos.Rows[e.RowIndex].Cells[1].Value = data.nombre;
            dgvAlumnos.Rows[e.RowIndex].Cells[2].Value = data.especialidad.nombre;
            //if (vez == 1)
            //{
            //    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)dgvAlumnos.Rows[e.RowIndex].Cells[3];
            //    if (lista[e.RowIndex])
            //    {
            //        chk.Value = chk.TrueValue;
            //    }
            //    else chk.Value = chk.FalseValue;


            //}
            //if (e.RowIndex == lista.Count - 1) vez++;



        }
    }
}
