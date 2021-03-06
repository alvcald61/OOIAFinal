using ProyectoOOIA.GestionAtencionWS;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoOOIA.Ventanas
{
    public partial class frmOpiniones : Form
    {
        private GestionAtencionWS.GestionAtencionWSClient daoEncuesta;

        public frmOpiniones(GestionHumanaWS.miembroPUCP asesor)
        {
            daoEncuesta = new GestionAtencionWS.GestionAtencionWSClient();
            InitializeComponent();
            dgvOpiniones.AutoGenerateColumns = false;
            lblAsesor.Text = "Asesor: " + asesor.nombre;
            listarEncuestas(asesor.id_miembro_pucp);
           
        }

        private void listarEncuestas(int idAsesor)
        {
            try
            {
                BindingList<GestionAtencionWS.encuesta> listaEncuestas = new BindingList<GestionAtencionWS.encuesta>(
                    daoEncuesta.listarEncuestaxAsesor(idAsesor).ToList());

                if (listaEncuestas != null)
                    dgvOpiniones.DataSource = listaEncuestas;
            }
            catch { };
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void dgvOpiniones_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            GestionAtencionWS.encuesta data = dgvOpiniones.Rows[e.RowIndex].DataBoundItem
           as GestionAtencionWS.encuesta;
            dgvOpiniones.Rows[e.RowIndex].Cells[0].Value = data.alumno.nombre;
            dgvOpiniones.Rows[e.RowIndex].Cells[1].Value = data.descripcion;
        }

    }
}
