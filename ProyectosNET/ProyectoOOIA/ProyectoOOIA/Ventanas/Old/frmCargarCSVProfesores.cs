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

namespace ProyectoOOIA.Ventanas.Miembro_OOIA.Cargar_Datos
{
    public partial class frmCargarCSVProfesores : Form
    {
        public frmCargarCSVProfesores()
        {
            InitializeComponent();
        }

        private void btnSeleccionArchivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string ruta = openFileDialog1.FileName;

                txtRutaArchivo.Text = ruta;
            }
        }

        private void btnCargaDatosCSVAlumnos_Click(object sender, EventArgs e)
        {
            /*CargarCSVprofesores.ProfesoresCSVcargaWSClient cargaCSVprofesores =
                new CargarCSVprofesores.ProfesoresCSVcargaWSClient();
            FileStream fs = new FileStream(txtRutaArchivo.Text, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            //Asignamos el archivo al objeto

            int resultado = cargaCSVprofesores.CargarCSVprofesores(br.ReadBytes((int)fs.Length));
            br.Close();
            fs.Close();
            
            if (resultado == 0)
            {
                MessageBox.Show("Se han cargado los datos correctamente", "Confirmacion",
                    MessageBoxButtons.OK);
                this.Close();
            }*/
        }
    }
}
