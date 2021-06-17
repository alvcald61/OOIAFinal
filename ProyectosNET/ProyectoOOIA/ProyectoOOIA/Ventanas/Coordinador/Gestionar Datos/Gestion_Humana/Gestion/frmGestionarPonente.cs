using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoOOIA.Ventanas.Miembro_OOIA.Cargar_Datos
{
    public partial class frmGestionarPonente: Form
    {
        private GestionHumanaWS.GestionHumanaWSClient daoPonente;
        private GestionHumanaWS.ponente ponente;
        private Estado estado;

        public frmGestionarPonente()
        {
            InitializeComponent();
            estado = Estado.Inicial;
            clearall();
            cambiarEstado();
            daoPonente = new GestionHumanaWS.GestionHumanaWSClient();
        }

        public void clearall()
        {
            /*Persona*/
            txtDni.Text = "";
            txtNombre.Text = "";
            dtpFechaNacimiento.Value = DateTime.Today;
            txtDireccion.Text = "";
            txtCorreo.Text = "";
            /*Miembro PUCP*/
            txtTelefono.Text = "";
            txtOcupacion.Text = "";
            /*Coordinador*/
            txtOrganizacion.Text = "";
        }

        public void cambiarEstado()
        {
            switch (estado)
            {
                case Estado.Inicial:
                    //Botones
                    tsbNuevo.Enabled = true;
                    tsbGuardar.Enabled = false;
                    tsbModificar.Enabled = false;
                    tsbBuscar.Enabled = true;
                    tsbEliminar.Enabled = false;
                    tsbCancelar.Enabled = true;
                    //Texto
                    /*Persona*/
                    txtDni.Enabled = false;
                    txtNombre.Enabled = false;
                    dtpFechaNacimiento.Enabled = false;
                    txtDireccion.Enabled = false;
                    txtCorreo.Enabled = false;
                    /*Miembro PUCP*/
                    txtTelefono.Enabled = false;
                    txtOcupacion.Enabled = false;
                    /*Coordinador*/
                    txtOrganizacion.Enabled = false;
                    break;
                case Estado.Nuevo:
                case Estado.Modificar:
                    //Botones
                    tsbNuevo.Enabled = false;
                    tsbGuardar.Enabled = true;
                    tsbModificar.Enabled = false;
                    tsbBuscar.Enabled = false;
                    tsbEliminar.Enabled = false;
                    tsbCancelar.Enabled = true;
                    //Texto
                    /*Persona*/
                    txtDni.Enabled = true;
                    txtNombre.Enabled = true;
                    dtpFechaNacimiento.Enabled = true;
                    txtDireccion.Enabled = true;
                    txtCorreo.Enabled = true;
                    /*Miembro PUCP*/
                    txtTelefono.Enabled = true;
                    txtOcupacion.Enabled = true;
                    /*Coordinador*/
                    txtOrganizacion.Enabled = true;
                    break;
                case Estado.Busqueda:
                    //Botones
                    tsbNuevo.Enabled = false;
                    tsbGuardar.Enabled = false;
                    tsbModificar.Enabled = true;
                    tsbBuscar.Enabled = false;
                    tsbEliminar.Enabled = true;
                    tsbCancelar.Enabled = true;
                    //Texto
                    /*Persona*/
                    txtDni.Enabled = false;
                    txtNombre.Enabled = false;
                    dtpFechaNacimiento.Enabled = false;
                    txtDireccion.Enabled = false;
                    txtCorreo.Enabled = false;
                    /*Miembro PUCP*/
                    txtTelefono.Enabled = false;
                    txtOcupacion.Enabled = false;
                    /*Coordinador*/
                    txtOrganizacion.Enabled = false;
                    break;
            }
        }


        /*Botones de Header*/

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*Botones de Toolstrip*/

        public void fillText(GestionHumanaWS.ponente pon)
        {
            //Persona
            txtDni.Text = pon.dni;
            txtNombre.Text = pon.nombre;
            dtpFechaNacimiento.Value = pon.fecha_nacimiento;
            txtDireccion.Text = pon.direccion;
            txtCorreo.Text = pon.correo;
            //Miembro PUCP
            txtTelefono.Text = pon.telefono;
            txtOcupacion.Text = pon.ocupacion;
            //Alumno
            txtOrganizacion.Text = pon.organizacion;
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            this.ponente = new GestionHumanaWS.ponente();
            estado = Estado.Nuevo;
            cambiarEstado();
            clearall();
            txtOcupacion.Text = "12345";
        }

        private void tsbGuardar_Click_1(object sender, EventArgs e)
        {
            //Validación Persona
            if (txtDni.Text == "")
            {
                MessageBox.Show("No ha ingresado el DNI", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtNombre.Text == "")
            {
                MessageBox.Show("No ha ingresado el nombre", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dtpFechaNacimiento.Value == DateTime.Today)
            {
                MessageBox.Show("No ha ingresado correctamente la fecha de nacimiento", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtDireccion.Text == "")
            {
                MessageBox.Show("No ha ingresado la dirección", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtCorreo.Text == "")
            {
                MessageBox.Show("No ha ingresado el correo", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Validación Miembro PUCP
            if (txtTelefono.Text == "")
            {
                MessageBox.Show("No ha ingresado el usuario", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtOcupacion.Text == "")
            {
                MessageBox.Show("No ha ingresado la contraseña", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Validación Coordinador
            if (txtOrganizacion.Text == "")
            {
                MessageBox.Show("No ha ingresado el rol", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Persona
            ponente.dni = txtDni.Text;
            ponente.nombre = txtNombre.Text;
            ponente.fecha_nacimiento = dtpFechaNacimiento.Value;
            ponente.fecha_nacimientoSpecified = true;
            ponente.direccion = txtDireccion.Text;
            ponente.correo = txtCorreo.Text;
            //Miembro Externo
            ponente.telefono = txtTelefono.Text;
            ponente.ocupacion = txtOcupacion.Text;
            //Psicologo
            ponente.organizacion = txtOrganizacion.Text;

            if (estado.Equals(Estado.Nuevo))
            {
                int resultado = daoPonente.insertarPonente(ponente);
                if (resultado != 0)
                {
                    MessageBox.Show("Se ha registrado con exito", "Mensaje Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.estado = Estado.Inicial;
                    cambiarEstado();
                }
                else MessageBox.Show("Ha ocurrido un error en la inserción", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (estado == Estado.Modificar)
            {
                int resultado = daoPonente.modificarPonente(ponente);
                if (resultado != 0)
                {
                    MessageBox.Show("Se ha actualizado con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.estado = Estado.Inicial;
                    cambiarEstado();
                }
                else
                    MessageBox.Show("Ha ocurrido un error", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void tsbModificar_Click(object sender, EventArgs e)
        {
            this.estado = Estado.Modificar;
            cambiarEstado();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Esta seguro que desea eliminar este coordinador?", "Mensaje de Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                int resultado = daoPonente.eliminarPonente(ponente.id_ponente);
                if (resultado != 0)
                {
                    MessageBox.Show("Se ha eliminado con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.estado = Estado.Inicial;
                    cambiarEstado();
                }
                else MessageBox.Show("Ha ocurrido un error", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarPonente frmBuscar = new frmBuscarPonente();
            if (frmBuscar.ShowDialog() == DialogResult.OK)
            {
                this.ponente = frmBuscar.Ponente;
                fillText(this.ponente);
                estado = Estado.Busqueda;
                cambiarEstado();
            }
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            this.estado = Estado.Inicial;
            clearall();
            cambiarEstado();
        }
    }
}
