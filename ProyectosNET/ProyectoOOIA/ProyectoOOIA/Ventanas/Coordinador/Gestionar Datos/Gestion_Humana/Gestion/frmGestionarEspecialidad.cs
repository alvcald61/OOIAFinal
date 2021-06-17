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
    public partial class frmGestionarEspecialidad : Form
    {
        private EspecialidadWS.EspecialidadWSClient daoEspecialidad;
        private EspecialidadWS.especialidad especialidad;
        private Estado estado;

        public frmGestionarEspecialidad()
        {
            InitializeComponent();
            dgvEspecialidad.AutoGenerateColumns = false;
            estado = Estado.Inicial;
            daoEspecialidad = new EspecialidadWS.EspecialidadWSClient();
            cambiarEstado();
            mostrarEspecialidades();
            clearall();
        }

        public void clearall()
        {
            /*Especialidad*/
            txtId_especialidad.Text = "";
            txtNombre.Text = "";
        }

        public void mostrarEspecialidades()
        {
            BindingList<EspecialidadWS.especialidad>
                especialidades = new BindingList<EspecialidadWS.especialidad>
                (daoEspecialidad.listarEspecialidad().ToList());
            dgvEspecialidad.DataSource = especialidades;
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
                    txtId_especialidad.Enabled = false;
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
                    txtId_especialidad.Enabled = false;
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
                    txtId_especialidad.Enabled = false;
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
            this.especialidad = new EspecialidadWS.especialidad();
            estado = Estado.Nuevo;
            cambiarEstado();
            clearall();
        }


        private void tsbModificar_Click(object sender, EventArgs e)
        {
            this.estado = Estado.Modificar;
            if (dgvEspecialidad.CurrentRow != null)
            {
                especialidad = (EspecialidadWS.especialidad)dgvEspecialidad.CurrentRow.DataBoundItem;
                txtId_especialidad.Text = especialidad.id_especialidad.ToString();
                txtNombre.Text = especialidad.nombre;
                cambiarEstado();
            }
            else
                MessageBox.Show("Debe seleccionar una especialidad para modificar.", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {

            if (dgvEspecialidad.CurrentRow != null)
            {
                especialidad = (EspecialidadWS.especialidad)dgvEspecialidad.CurrentRow.DataBoundItem;
                DialogResult dr = MessageBox.Show("¿Esta seguro que desea eliminar este empleado?", "Mensaje de Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    int resultado = daoEspecialidad.eliminarEspecialidad(especialidad.id_especialidad);
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
                MessageBox.Show("Debe seleccionar una especialidad para eliminar.", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            this.estado = Estado.Inicial;
            clearall();
            cambiarEstado();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BindingList<EspecialidadWS.especialidad>
                especialidades = new BindingList<EspecialidadWS.especialidad>
                (daoEspecialidad.listarEspecialidad().ToList());
            dgvEspecialidad.DataSource = especialidades;
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {   
            //Validar Especialidad
            if (txtNombre.Text == "")
            {
                MessageBox.Show("No ha ingresado el nombre de la especialidad", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            especialidad.nombre = txtNombre.Text;
            if (estado.Equals(Estado.Nuevo))
            {
                int resultado = daoEspecialidad.insertarEspecialidad(especialidad);
                if (resultado != 0)
                {
                    MessageBox.Show("Se ha registrado con exito", "Mensaje Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtId_especialidad.Text = resultado.ToString();
                    this.estado = Estado.Inicial;
                    cambiarEstado();
                    mostrarEspecialidades();
                }
                else MessageBox.Show("Ha ocurrido un error en la inserción", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (estado == Estado.Modificar)
            {
                int resultado = daoEspecialidad.modificarEspecialidad(especialidad);
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
