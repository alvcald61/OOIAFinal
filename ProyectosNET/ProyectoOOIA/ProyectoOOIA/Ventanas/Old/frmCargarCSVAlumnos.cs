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
    public partial class frmCargarCSVAlumnos : Form
    {
        public frmCargarCSVAlumnos()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmCargarCSVAlumnos_Load(object sender, EventArgs e)
        {

        }

        private void lblRutaArchivoCSV_Click(object sender, EventArgs e)
        {

        }

        private void btnSeleccionArchivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if(openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string ruta = openFileDialog.FileName;
                txtRutaArchivo.Text = ruta;
            }
        }

        private void btnCargaDatosCSVAlumnos_Click(object sender, EventArgs e)
        {
            /*CargarCSValumnos.AlumnosCSVcargaWSClient cargaCSVAlumnos =
                new CargarCSValumnos.AlumnosCSVcargaWS1Client();*/
           

            FileStream fs = new FileStream(txtRutaArchivo.Text, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            //Asignamos el archivo al objeto
          
            /*int resultado = cargaCSVAlumnos.CargarCSValumnos(br.ReadBytes((int)fs.Length));
            br.Close();
            fs.Close();
            if(resultado == 0)
            {
                MessageBox.Show("Se han cargado los datos correctamente", "Confirmacion",
                    MessageBoxButtons.OK);
                this.Close();
            }*/
        }
    }
}
