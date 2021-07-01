using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoOOIA.Ventanas.Asesor.Citas
{
    public partial class frmDescargarReporteEvento : Form
    {
        private ReporteEventoAlumnoWS.ReporteEventoAlumnoWSClient daoReporte;
        private byte[] arreglo = null;
        private int idEvento;
        public frmDescargarReporteEvento(int idEvento)
        {

            this.idEvento = idEvento;
            InitializeComponent();
            daoReporte = new ReporteEventoAlumnoWS.ReporteEventoAlumnoWSClient();
            cargarReporte();
            btnGuardarReporte.Enabled = false;

            
        }

        private void cargarReporte()
        {
            try
            {
                arreglo = daoReporte.generarReporteEvento(this.idEvento);
            }catch
            {
                return;
            }
            
            File.WriteAllBytes("temporal.pdf", arreglo);
            axAcroPDF.setShowToolbar(true);
            axAcroPDF.LoadFile("temporal.pdf");
            btnGuardarReporte.Enabled = true;
        }

        private void btnGuardarReporte_Click(object sender, EventArgs e)
        {
            try
            {
                File.Delete("temporal.pdf");
            }
            catch (Exception ex)
            {

            }
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Documento pdf|*.pdf";
            saveFileDialog1.Title = "Guardar plantilla de carga CSV";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK && arreglo != null)
            {
                try
                {
                    File.WriteAllBytes(saveFileDialog1.FileName, arreglo);
                    MessageBox.Show("Se ha guardado el archivo con éxito", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se ha podido guardar el archivo", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
