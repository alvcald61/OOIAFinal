using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoOOIA.Ventanas.Miembro_OOIA.Cargar_Datos.Gestion_Humana
{
    public partial class frmGestionarCategoria : Form
    {
        private GestionEventoWS.GestionEventoWSClient daoCategoria;
        private GestionEventoWS.categoriaEvento categoriaEvento;
        private Estado estado;

        public frmGestionarCategoria()
        {
            InitializeComponent();
            dgvCategoria.AutoGenerateColumns = false;
            estado = Estado.Inicial;
            daoCategoria = new GestionEventoWS.GestionEventoWSClient();
            cambiarEstado();
            mostrarEspecialidades();
            clearall();
        }

        public void clearall()
        {
            /*Especialidad*/
            txtId_categoria.Text = "";
            txtNombre.Text = "";
        }

        public void mostrarEspecialidades()
        {
            BindingList<GestionEventoWS.categoriaEvento>
                especialidades = new BindingList<GestionEventoWS.categoriaEvento>
                (daoCategoria.listarCategoriaEvento().ToList());
            dgvCategoria.DataSource = especialidades;
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
                    //Texto
                    /*Especialidad*/
                    txtId_categoria.Enabled = false;
                    txtNombre.Enabled = false;
                    break;
                case Estado.Nuevo:
                case Estado.Modificar:
                    //Botones
                    tsbNuevo.Enabled = false;
                    tsbGuardar.Enabled = true;
                    tsbModificar.Enabled = false;
                    tsbEliminar.Enabled = false;
                    tsbCancelar.Enabled = true;
                    //Texto
                    /*Especialidad*/
                    txtId_categoria.Enabled = false;
                    txtNombre.Enabled = true;
                    break;
                case Estado.Busqueda:
                    //Botones
                    tsbNuevo.Enabled = false;
                    tsbGuardar.Enabled = false;
                    tsbModificar.Enabled = true;
                    tsbEliminar.Enabled = true;
                    tsbCancelar.Enabled = true;
                    //Texto
                    /*Persona*/
                    txtId_categoria.Enabled = false;
                    txtNombre.Enabled = false;
                    break;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            this.categoriaEvento = new GestionEventoWS.categoriaEvento();
            estado = Estado.Nuevo;
            cambiarEstado();
            clearall();
        }


        private void tsbModificar_Click(object sender, EventArgs e)
        {
            this.estado = Estado.Modificar;
            if (dgvCategoria.CurrentRow != null)
            {
                categoriaEvento = (GestionEventoWS.categoriaEvento)dgvCategoria.CurrentRow.DataBoundItem;
                txtId_categoria.Text = categoriaEvento.id_categoria.ToString();
                txtNombre.Text = categoriaEvento.nombre;
                cambiarEstado();
            }
            else
                MessageBox.Show("Debe seleccionar una especialidad para modificar.", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {

            if (dgvCategoria.CurrentRow != null)
            {
                categoriaEvento = (GestionEventoWS.categoriaEvento)dgvCategoria.CurrentRow.DataBoundItem;
                DialogResult dr = MessageBox.Show("¿Esta seguro que desea eliminar esta categoria?", "Mensaje de Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    int resultado = daoCategoria.eliminarCategoriaEvento(categoriaEvento);
                    if (resultado != 0)
                    {
                        MessageBox.Show("Se ha eliminado con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.estado = Estado.Inicial;
                        cambiarEstado();
                        mostrarEspecialidades();
                    }
                    else MessageBox.Show("Ha ocurrido un error", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Debe seleccionar una categoria para eliminar.", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            this.estado = Estado.Inicial;
            clearall();
            cambiarEstado();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BindingList<GestionEventoWS.categoriaEvento>
                especialidades = new BindingList<GestionEventoWS.categoriaEvento>
                (daoCategoria.listarCategoriaEvento().ToList());
            dgvCategoria.DataSource = especialidades;
        }

        private void tsbGuardar_Click_1(object sender, EventArgs e)
        {   
            //Validar Especialidad
            if (txtNombre.Text == "")
            {
                MessageBox.Show("No ha ingresado el nombre de la categoria", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            categoriaEvento.nombre = txtNombre.Text;
            if (estado.Equals(Estado.Nuevo))
            {
                int resultado = daoCategoria.insertarCategoriaEvento(categoriaEvento);
                if (resultado != 0)
                {
                    MessageBox.Show("Se ha registrado con exito", "Mensaje Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtId_categoria.Text = resultado.ToString();
                    this.estado = Estado.Inicial;
                    cambiarEstado();
                    mostrarEspecialidades();
                }
                else MessageBox.Show("Ha ocurrido un error en la inserción", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (estado == Estado.Modificar)
            {
                int resultado = daoCategoria.modificarCategoriaEvento(categoriaEvento);
                if (resultado != 0)
                {
                    MessageBox.Show("Se ha actualizado con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.estado = Estado.Inicial;
                    cambiarEstado();
                    mostrarEspecialidades();
                }
                else
                    MessageBox.Show("Ha ocurrido un error", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
