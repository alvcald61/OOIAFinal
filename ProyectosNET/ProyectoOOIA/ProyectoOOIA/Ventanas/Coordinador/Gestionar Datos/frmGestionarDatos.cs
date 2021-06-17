using ProyectoOOIA.Ventanas.Miembro_OOIA.Cargar_Datos;
using ProyectoOOIA.Ventanas.Miembro_OOIA.Cargar_Datos.Gestion_Academica;
using ProyectoOOIA.Ventanas.Miembro_OOIA.Cargar_Datos.Gestion_Humana;
using System;
using System.IO;
using System.Windows.Forms;

namespace ProyectoOOIA.Ventanas.Miembro_OOIA
{
    public partial class frmCargarDatos : Form
    {
        public frmCargarDatos()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*TAB Gestion Humana*/
        //Alumno
        private void btnAlumno_Click(object sender, EventArgs e)
        {
            new frmGestionarAlumno().ShowDialog();
        }

        private void btnAlumnoFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string ruta = openFileDialog.FileName;
                txtAlumno.Text = ruta;
            }
        }

        private void btnAlumnoCSV_Click(object sender, EventArgs e)
        {
            if(txtAlumno.Text == "")
            {
                MessageBox.Show("Debe seleccionar una archivo de carga.", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            FileStream fs = new FileStream(txtAlumno.Text, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            CargarCSValumnosWS.AlumnosCSVcargaWS1Client cargaCSVAlumnos =
                new CargarCSValumnosWS.AlumnosCSVcargaWS1Client();
            
            int resultado = 1;
            resultado = cargaCSVAlumnos.CargarCSValumnos(br.ReadBytes((int)fs.Length));
            br.Close();
            fs.Close();
            if(resultado == 0)
                MessageBox.Show("Se han cargado los datos correctamente", "Confirmacion",
                    MessageBoxButtons.OK);
            else
                MessageBox.Show("Ha ocurrido un error en la carga de los datos", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Asesor
        private void btnAsesor_Click(object sender, EventArgs e)
        {
            if (rbProfesor.Checked) new frmGestionarProfesor().ShowDialog();
            if (rbPsicologo.Checked) new frmGestionarPsicologo().ShowDialog();
        }

        private void btnAsesorFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string ruta = openFileDialog.FileName;

                txtAsesor.Text = ruta;
            }
        }

        private void btnAsesorCSV_Click(object sender, EventArgs e)
        {
            if (txtAsesor.Text == "")
            {
                MessageBox.Show("Debe seleccionar una archivo de carga.", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FileStream fs = new FileStream(txtAsesor.Text, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            
            int resultado = 1;
            if (rbProfesor.Checked)
            {
                CargarCSVprofesoresWS.ProfesoresCSVcargaWSClient cargaCSVprofesores =
                    new CargarCSVprofesoresWS.ProfesoresCSVcargaWSClient();
                resultado = cargaCSVprofesores.CargarCSVprofesores(br.ReadBytes((int)fs.Length));
            }
            if (rbPsicologo.Checked)
            {
                CargarCSVpsicologosWS.PsicologosCSVcargaWSClient cargaCSVpsicologos =
                new CargarCSVpsicologosWS.PsicologosCSVcargaWSClient();
                resultado = cargaCSVpsicologos.CargarCSVpsicologos(br.ReadBytes((int)fs.Length));
            }
            br.Close();
            fs.Close();
            if (resultado == 0)
                MessageBox.Show("Se han cargado los datos correctamente", "Confirmacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            else 
                MessageBox.Show("Ha ocurrido un error en la carga de los datos", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnPonente_Click(object sender, EventArgs e)
        {
            new frmGestionarEspecialidad().ShowDialog();
        }

        private void btnCoordinador_Click(object sender, EventArgs e)
        {
            new frmGestionarCoordinador().ShowDialog();
        }

        private void btnEspecialidad_Click(object sender, EventArgs e)
        {
            new frmGestionarEspecialidad().ShowDialog();
        }

        /*TAB Gestion Atencion*/
        private void btnCodigoAtencion_Click(object sender, EventArgs e)
        {
            new frmCodigosAtencion().ShowDialog();
        }

        /*TAB Gestion Academica*/
        private void btnEvaluacionFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string ruta = openFileDialog.FileName;
                txtEvaluacion.Text = ruta;
            }
        }

        private void btnEvaluacionCSV_Click(object sender, EventArgs e)
        {
            if (txtEvaluacion.Text == "")
            {
                MessageBox.Show("Debe seleccionar una archivo de carga.", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FileStream fs = new FileStream(txtEvaluacion.Text, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            CargarCSVevaluacionesWS.EvaluacionesCSVcargaWSClient cargaCSVevaluaciones =
                new CargarCSVevaluacionesWS.EvaluacionesCSVcargaWSClient();
            int resultado = 1;
            resultado = cargaCSVevaluaciones.CargarCSVevaluaciones(br.ReadBytes((int)fs.Length));
            br.Close();
            fs.Close();
            if (resultado == 0)
                MessageBox.Show("Se han cargado los datos correctamente", "Confirmacion",
                    MessageBoxButtons.OK);
            else
                MessageBox.Show("Ha ocurrido un error en la carga de los datos", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnCursoLlevadoFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string ruta = openFileDialog.FileName;
                txtCursoLlevado.Text = ruta;
            }
        }

        private void btnCursoLlevadoCSV_Click(object sender, EventArgs e)
        {
            if (txtCursoLlevado.Text == "")
            {
                MessageBox.Show("Debe seleccionar una archivo de carga.", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FileStream fs = new FileStream(txtCursoLlevado.Text, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            CargarCSVcursosLlevadosWS.CursosLlevadosCSVcargaWSClient cargaCSVcursosLlevados =
                new CargarCSVcursosLlevadosWS.CursosLlevadosCSVcargaWSClient();
            int resultado = 1;
            resultado = cargaCSVcursosLlevados.CargarCSVcursosLlevados(br.ReadBytes((int)fs.Length));
            br.Close();
            fs.Close();
            if (resultado == 0)
                MessageBox.Show("Se han cargado los datos correctamente", "Confirmacion",
                    MessageBoxButtons.OK);
            else
                MessageBox.Show("Ha ocurrido un error en la carga de los datos", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnCursoLlevado_Click(object sender, EventArgs e)
        {
            new frmCargarCursosLlevados().ShowDialog();
        }
    }
}
