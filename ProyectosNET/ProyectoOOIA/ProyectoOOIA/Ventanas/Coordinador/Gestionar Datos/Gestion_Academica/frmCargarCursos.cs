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
    public partial class frmCargarCursos : Form
    {
        private CursoWS.CursoWSClient daoCurso;
        private CursoWS.curso curso;
        private Estado estado;

        public frmCargarCursos()
        {
            InitializeComponent();
            dgvCursos.AutoGenerateColumns = false;
            estado = Estado.Inicial;
            daoCurso = new CursoWS.CursoWSClient();
            cambiarEstado();
            listarCursos();
            clearall();
        }

        public void clearall()
        {
            txtCodigo.Text = "";
            txtNombreCurso.Text = "";
            txtCreditos.Text = "";
        }

        public void listarCursos()
        {
            BindingList<CursoWS.curso>
                cursos = new BindingList<CursoWS.curso>
                (daoCurso.listarCurso().ToList());
            dgvCursos.DataSource = cursos;
        }
        public void cambiarEstado()
        {
            switch (estado)
            {
                case Estado.Inicial:
                    //Botones
                    tsbNuevo.Enabled = true;
                    tsbGuardar.Enabled = false;
                    tsbModificar.Enabled = true;
                    tsbEliminar.Enabled = true;
                    tsbCancelar.Enabled = true;
                    
                    txtCodigo.Enabled = false;
                    txtCreditos.Enabled = false;
                    txtNombreCurso.Enabled = false;
                    break;
                case Estado.Nuevo:
                case Estado.Modificar:
                    //Botones
                    tsbNuevo.Enabled = false;
                    tsbGuardar.Enabled = true;
                    tsbModificar.Enabled = false;
                    tsbEliminar.Enabled = false;
                    tsbCancelar.Enabled = true;
                
                    txtCodigo.Enabled = true;
                    txtCreditos.Enabled = true;
                    txtNombreCurso.Enabled = true;
                    break;
                case Estado.Busqueda:
                    //Botones
                    tsbNuevo.Enabled = false;
                    tsbGuardar.Enabled = false;
                    tsbModificar.Enabled = true;
                    tsbEliminar.Enabled = true;
                    tsbCancelar.Enabled = true;

                    txtCodigo.Enabled = false;
                    txtCreditos.Enabled = false;
                    txtNombreCurso.Enabled = false;
                    break;
            }
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            this.curso = new CursoWS.curso();
            estado = Estado.Nuevo;
            cambiarEstado();
            clearall();
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        { 
            if (txtNombreCurso.Text == "")
            {
                MessageBox.Show("No ha ingresado el nombre del curso", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtCreditos.Text == "")
            {
                MessageBox.Show("No ha ingresado los créditos del curso", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("No ha ingresado el codigo del curso", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            curso.nombreCurso = txtNombreCurso.Text;
            curso.creditos = Double.Parse(txtCreditos.Text);
            curso.codigoCurso = txtCodigo.Text;
            if (estado.Equals(Estado.Nuevo))
            {
                int resultado = daoCurso.insertarrCurso(curso);
                if (resultado != 0)
                {
                    MessageBox.Show("Se ha registrado con éxito", "Mensaje Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    curso.id_curso = resultado;
                    this.estado = Estado.Inicial;
                    cambiarEstado();
                    listarCursos();
                }
                else MessageBox.Show("Ha ocurrido un error en la inserción", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (estado == Estado.Modificar)
            {
                int resultado = daoCurso.modificarCurso(curso);
                if (resultado != 0)
                {
                    MessageBox.Show("Se ha actualizado con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.estado = Estado.Inicial;
                    cambiarEstado();
                    listarCursos();
                }
                else
                    MessageBox.Show("Ha ocurrido un error", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            clearall();

        }

        private void tsbModificar_Click(object sender, EventArgs e)
        {
            this.estado = Estado.Modificar;
            if (dgvCursos.CurrentRow != null)
            {
                curso = (CursoWS.curso)dgvCursos.CurrentRow.DataBoundItem;
                txtNombreCurso.Text = curso.nombreCurso;
                txtCodigo.Text = curso.codigoCurso;
                txtCreditos.Text = curso.creditos.ToString();
                cambiarEstado();
            }
            else
                MessageBox.Show("Debe seleccionar un curso para modificar.", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {


            if (dgvCursos.CurrentRow != null)
            {
                curso = (CursoWS.curso)dgvCursos.CurrentRow.DataBoundItem;
                DialogResult dr = MessageBox.Show("¿Esta seguro que desea eliminar este curso?", "Mensaje de Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    int resultado = daoCurso.eliminarCurso(curso.id_curso);
                    if (resultado != 0)
                    {
                        MessageBox.Show("Se ha eliminado con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.estado = Estado.Inicial;
                        cambiarEstado();
                        listarCursos();
                    }
                    else MessageBox.Show("Ha ocurrido un error", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Debe seleccionar un curso para eliminar.", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            this.estado = Estado.Inicial;
            clearall();
            cambiarEstado();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BindingList<CursoWS.curso>
                cursos = new BindingList<CursoWS.curso>
                (daoCurso.listarCurso().ToList());
            dgvCursos.DataSource = cursos;
        }
    }
}
