using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ProyectoOOIA.Ventanas.Miembro_OOIA.Cargar_Datos
{
    public partial class frmGestionarPonente: Form
    {
        private GestionHumanaWS.GestionHumanaWSClient daoPonente;
        private GestionHumanaWS.ponente ponente;
        private Estado estado;
        private Regex regex;
        private ErrorProvider errorDni;
        private ErrorProvider errorCorreo;
        private string[] datosAnteriores;
        public frmGestionarPonente()
        {
            InitializeComponent();
            errorDni = new ErrorProvider();
            errorCorreo = new ErrorProvider();
            errorDni.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorCorreo.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            dtpFechaNacimiento.MaxDate = DateTime.Now.AddDays(-5840);
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
            dtpFechaNacimiento.Value = DateTime.Today.AddDays(-5840);
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
            if (!validarPersona()) return;

            //Validación Miembro PUCP
            if (txtTelefono.Text == "")
            {
                MessageBox.Show("No ha ingresado el telefono", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtOcupacion.Text == "")
            {
                MessageBox.Show("No ha ingresado la ocupacion", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Validación Coordinador
            if (txtOrganizacion.Text == "")
            {
                MessageBox.Show("No ha ingresado la organizacion", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Validacion de persona repetida
            int cantUsuarios = new GestionHumanaWS.GestionHumanaWSClient().autenticar_persona_dni(
            int.Parse(txtDni.Text));
            if (cantUsuarios == 1)
            {
                MessageBox.Show("Ya existe una persona registrada con el mismo DNI", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        private bool validarPersona()
        {
            
            if (txtDni.Text == "")
            {
                MessageBox.Show("No ha ingresado el DNI", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtNombre.Text == "")
            {
                MessageBox.Show("No ha ingresado el nombre", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (dtpFechaNacimiento.Value == DateTime.Today)
            {
                MessageBox.Show("No ha ingresado correctamente la fecha de nacimiento", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtDireccion.Text == "")
            {
                MessageBox.Show("No ha ingresado la dirección", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtCorreo.Text == "")
            {
                MessageBox.Show("No ha ingresado el correo", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string patronDNI = @"^\d{8}(?:[-\s]\d{4})?$";
            regex = new Regex(patronDNI);
            if (!regex.IsMatch(txtDni.Text))
            {
                MessageBox.Show("El dni debe ser una cadena de 8 numeros", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            string patronCorreo = @"^(([^<>()\[\]\\.,;:\s@”]+(\.[^<>()\[\]\\.,;:\s@”]+)*)|(“.+”))@((\[[0–9]{1,3}\.[0–9]{1,3}\.[0–9]{1,3}\.[0–9]{1,3}])|(([a-zA-Z\-0–9]+\.)+[a-zA-Z]{2,}))$";
            regex = new Regex(patronCorreo);
            if (!regex.IsMatch(txtCorreo.Text))
            {
                MessageBox.Show("Correo Invalido", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void tsbModificar_Click(object sender, EventArgs e)
        {
            this.estado = Estado.Modificar;
            cambiarEstado();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Esta seguro que desea eliminar este ponente?", "Mensaje de Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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

        private void txtDni_Leave(object sender, EventArgs e)
        {//validar que el dni tenga 8 digitos
            Control evento = (sender as Control);
            if (evento.Name == "txtDni")
                validarDNI(evento as TextBox);
            if (evento.Name == "txtCorreo")
                validarCorreo(evento as TextBox);
            

        }



        private void validarCorreo(TextBox sender)
        {
            string patronCorreo = @"^(([^<>()\[\]\\.,;:\s@”]+(\.[^<>()\[\]\\.,;:\s@”]+)*)|(“.+”))@((\[[0–9]{1,3}\.[0–9]{1,3}\.[0–9]{1,3}\.[0–9]{1,3}])|(([a-zA-Z\-0–9]+\.)+[a-zA-Z]{2,}))$";
            regex = new Regex(patronCorreo);
            if (estado == Estado.Modificar)
                if (datosAnteriores[1] == txtCorreo.Text) return;
            if (!regex.IsMatch(txtCorreo.Text))
            {
                errorCorreo.SetError(sender, "El correo debe ser de la forma ejemplo@servidor.extension");

            }

        }

        private void validarDNI(TextBox sender)
        {
            string patronDNI = @"\d{8}";
            regex = new Regex(patronDNI);
            if (estado == Estado.Modificar)
                if (datosAnteriores[0] == txtDni.Text) return;
            if (!regex.IsMatch(txtDni.Text))
                errorDni.SetError(sender, "El DNI debe tener 8 digitos");
            else
            {
                int cantUsuarios = new GestionHumanaWS.GestionHumanaWSClient().autenticar_persona_dni(Int32.Parse(txtDni.Text));
                if (cantUsuarios == 1) errorDni.SetError(sender, "Este DNI ya está registrado");
            }
        }

        private void txtDni_Enter(object sender, EventArgs e)
        {
            Control evento = (sender as Control);
            if (evento.Name == "txtDni")
                errorDni.Clear();
            if (evento.Name == "txtCorreo")
                errorCorreo.Clear();
            
        }
        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
