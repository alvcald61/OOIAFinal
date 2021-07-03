using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoOOIA.Ventanas.Alumno.Eventos
{
    public partial class frmAgregarOpinionEvento : Form
    {
        private GestionEventoWS.eventoAlumno eventoAlumno;
        private GestionEventoWS.GestionEventoWSClient daoEventoAlumno;

        public frmAgregarOpinionEvento(int idEvento, int idAlumno)
        {
            InitializeComponent();
            eventoAlumno = new GestionEventoWS.eventoAlumno();
            daoEventoAlumno = new GestionEventoWS.GestionEventoWSClient();
            eventoAlumno.id_evento = idEvento;
            eventoAlumno.id_alumno = idAlumno;
        }

        private void frmAgregarOpinionEvento_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Esta seguro que desea agregar su opinión?", "Agregar opinión de evento",
               MessageBoxButtons.YesNo, MessageBoxIcon.None);
            if (dr == DialogResult.Yes)
            {
                eventoAlumno.comentario = txtComentario.Text;

                if (rdbPesimo.Checked)
                {
                    eventoAlumno.valoracionPonentes = 1;
                }
                else if (rdbMalo.Checked)
                {
                    eventoAlumno.valoracionPonentes = 2;
                }
                else if (rdbNormal.Checked)
                {
                    eventoAlumno.valoracionPonentes = 3;
                }
                else if (rdbBueno.Checked)
                {
                    eventoAlumno.valoracionPonentes = 4;
                }
                else if (rdbExcelente.Checked)
                {
                    eventoAlumno.valoracionPonentes = 5;
                }
                else
                {
                    eventoAlumno.valoracionPonentes = 0;
                }

                if (radioButton5.Checked)
                {
                    eventoAlumno.valoracionEvento = 1;
                }
                else if (radioButton4.Checked)
                {
                    eventoAlumno.valoracionEvento = 2;
                }
                else if (radioButton3.Checked)
                {
                    eventoAlumno.valoracionEvento = 3;
                }
                else if (radioButton2.Checked)
                {
                    eventoAlumno.valoracionEvento = 4;
                }
                else if (radioButton1.Checked)
                {
                    eventoAlumno.valoracionEvento = 5;
                }
                else
                {
                    eventoAlumno.valoracionEvento = 0;
                }

                if (radioButton10.Checked)
                {
                    eventoAlumno.valoracionUtilidad = 1;
                }
                else if (radioButton9.Checked)
                {
                    eventoAlumno.valoracionUtilidad = 2;
                }
                else if (radioButton8.Checked)
                {
                    eventoAlumno.valoracionUtilidad = 3;
                }
                else if (radioButton7.Checked)
                {
                    eventoAlumno.valoracionUtilidad = 4;
                }
                else if (radioButton6.Checked)
                {
                    eventoAlumno.valoracionUtilidad = 5;
                }
                else
                {
                    eventoAlumno.valoracionUtilidad = 0;
                }

                if (daoEventoAlumno.modificarEncuestaEvento(eventoAlumno) == 1)
                {
                    MessageBox.Show("La opinion se agrego exitosamente", "Exito", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }
                else
                    MessageBox.Show("Ha habido un error", "Error", MessageBoxButtons.RetryCancel,
                        MessageBoxIcon.Error);

                this.Close();
            }
        }
    }
}
