using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ProyectoOOIA.Ventanas.Miembro_OOIA.Cargar_Datos
{
    public partial class frmGestionarCoordinador: Form
    {
        private GestionHumanaWS.GestionHumanaWSClient daoCoordinador;
        private GestionHumanaWS.coordinador coordinador;
        private Estado estado;
        private byte[] imagen_perfil;

        private Regex regex;
        private ErrorProvider errorDni;
        private ErrorProvider errorCorreo;
        private ErrorProvider errorCodigo;
        private ErrorProvider errorUsuario;

        private string[] datosAnteriores;

        public frmGestionarCoordinador()
        {
            errorCorreo = new ErrorProvider();
            errorDni = new ErrorProvider();
            errorCodigo = new ErrorProvider();
            errorUsuario = new ErrorProvider();

            InitializeComponent();
            estado = Estado.Inicial;
            clearall();
            cambiarEstado();
            daoCoordinador = new GestionHumanaWS.GestionHumanaWSClient();
            dtpFechaNacimiento.MaxDate = DateTime.Now.AddDays(-6570);
            errorCorreo.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorCodigo.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorDni.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorUsuario.BlinkStyle = ErrorBlinkStyle.NeverBlink;

            datosAnteriores = new string[4];
            for (int i = 0; i < datosAnteriores.Length; i++) datosAnteriores[i] = "";
        }

        public void clearall()
        {
            /*Persona*/
            txtDni.Text = "";
            txtNombre.Text = "";
            dtpFechaNacimiento.Value = DateTime.Today.AddDays(-6570); ;
            txtDireccion.Text = "";
            txtCorreo.Text = "";
            /*Miembro PUCP*/
            txtUsuario.Text = "";
            txtPassword.Text = "";
            /*Coordinador*/
            txtRol.Text = "";
            /*Imagen*/
            Image img = Properties.Resources.placeholder_profile;
            imagen_perfil = ImageToByte2(img);
            displayImage(imagen_perfil);
        }

        public static byte[] ImageToByte2(Image img)
        {
            using (var stream = new MemoryStream())
            {
                img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                return stream.ToArray();
            }
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
                    btnImagen1.Enabled = false;
                    btnImagen2.Enabled = false;
                    //Texto
                    /*Persona*/
                    txtDni.Enabled = false;
                    txtNombre.Enabled = false;
                    dtpFechaNacimiento.Enabled = false;
                    txtDireccion.Enabled = false;
                    txtCorreo.Enabled = false;
                    /*Miembro PUCP*/
                    txtUsuario.Enabled = false;
                    txtPassword.Enabled = false;
                    /*Coordinador*/
                    txtRol.Enabled = false;
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
                    btnImagen1.Enabled = true;
                    btnImagen2.Enabled = true;
                    //Texto
                    /*Persona*/
                    txtDni.Enabled = true;
                    txtNombre.Enabled = true;
                    dtpFechaNacimiento.Enabled = true;
                    txtDireccion.Enabled = true;
                    txtCorreo.Enabled = true;
                    /*Miembro PUCP*/
                    txtUsuario.Enabled = true;
                    txtPassword.Enabled = true;
                    /*Coordinador*/
                    txtRol.Enabled = true;
                    break;
                case Estado.Busqueda:
                    //Botones
                    tsbNuevo.Enabled = false;
                    tsbGuardar.Enabled = false;
                    tsbModificar.Enabled = true;
                    tsbBuscar.Enabled = false;
                    tsbEliminar.Enabled = true;
                    tsbCancelar.Enabled = true;
                    btnImagen1.Enabled = false;
                    btnImagen2.Enabled = false;
                    //Texto
                    /*Persona*/
                    txtDni.Enabled = false;
                    txtNombre.Enabled = false;
                    dtpFechaNacimiento.Enabled = false;
                    txtDireccion.Enabled = false;
                    txtCorreo.Enabled = false;
                    /*Miembro PUCP*/
                    txtUsuario.Enabled = false;
                    txtPassword.Enabled = false;
                    /*Coordinador*/
                    txtRol.Enabled = false;
                    break;
            }
        }

        public void displayImage(byte[] image)
        {
            try
            {
                MemoryStream ms = new MemoryStream(image);
                pbPerfil1.Image = Image.FromStream(ms);
                pbPerfil2.Image = Image.FromStream(ms);
            }
            catch { };
        }

        /*Botones de Header*/

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*Botones de Toolstrip*/

        public void fillText(GestionHumanaWS.coordinador coord)
        {
            //Persona
            txtDni.Text = coord.dni;
            txtNombre.Text = coord.nombre;
            dtpFechaNacimiento.Value = coord.fecha_nacimiento;
            txtDireccion.Text = coord.direccion;
            txtCorreo.Text = coord.correo;
            //Miembro PUCP
            txtUsuario.Text = coord.usuario;
            txtPassword.Text = "";
            imagen_perfil = coord.imagenDePerfil;
            if (imagen_perfil != null) displayImage(imagen_perfil);
            //Alumno
            txtRol.Text = coord.rol;
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            this.coordinador = new GestionHumanaWS.coordinador();
            estado = Estado.Nuevo;
            cambiarEstado();
            clearall();

            Guid miGuid = Guid.NewGuid();
            string token = Convert.ToBase64String(miGuid.ToByteArray());
            token = token.Replace("=", "").Replace("+", "");
            string pass = token.Substring(0, 7);

            txtPassword.Text = pass;
        }

        private void tsbGuardar_Click_1(object sender, EventArgs e)
        {
            //Validación Persona
            if (!validarPersona()) return;
            //Validación Miembro PUCP
            if (txtUsuario.Text == "")
            {
                MessageBox.Show("No ha ingresado el usuario", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtPassword.Text == "")
            {
                MessageBox.Show("No ha ingresado la contraseña", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Validación Coordinador
            if (txtRol.Text == "")
            {
                MessageBox.Show("No ha ingresado el rol", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Persona
            coordinador.dni = txtDni.Text;
            coordinador.nombre = txtNombre.Text;
            coordinador.fecha_nacimiento = dtpFechaNacimiento.Value;
            coordinador.fecha_nacimientoSpecified = true;
            coordinador.direccion = txtDireccion.Text;
            coordinador.correo = txtCorreo.Text;
            //Miembro PUCP
            coordinador.usuario = txtUsuario.Text;
            coordinador.password = txtPassword.Text;
            coordinador.imagenDePerfil = imagen_perfil;
            coordinador.fecha_inclusion = DateTime.Today.Date;
            coordinador.fecha_inclusionSpecified = true;
            //Psicologo
            coordinador.rol = txtRol.Text;

            if (estado.Equals(Estado.Nuevo))
            {
                int resultado = daoCoordinador.insertarCoordinador(coordinador);
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
                int resultado = daoCoordinador.modificarCoordinador(coordinador);
                if (resultado != 0)
                {
                    if (txtPassword.Text != "")
                        new GestionHumanaWS.GestionHumanaWSClient().cambiar_password(coordinador.id_miembro_pucp, txtPassword.Text);

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
            bool retorno=true;


            if (txtDni.Text == "")
            {
                MessageBox.Show("No ha ingresado el DNI", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                retorno = false;
            }
            if (txtNombre.Text == "")
            {
                MessageBox.Show("No ha ingresado el nombre", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                retorno = false;
            }
            if (dtpFechaNacimiento.Value == DateTime.Today)
            {
                MessageBox.Show("No ha ingresado correctamente la fecha de nacimiento", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                retorno = false;
            }
            if (txtDireccion.Text == "")
            {
                MessageBox.Show("No ha ingresado la dirección", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                retorno = false;
            }
            if (txtCorreo.Text == "")
            {
                MessageBox.Show("No ha ingresado el correo", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                retorno = false;
            }


            string patronDNI = @"\d{8}";
            regex = new Regex(patronDNI);
            if (!regex.IsMatch(txtDni.Text))
            {
                MessageBox.Show("El dni debe ser una cadena de 8 numeros", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                retorno = false;
            }
            string patronCorreo = @"^(([^<>()\[\]\\.,;:\s@”]+(\.[^<>()\[\]\\.,;:\s@”]+)*)|(“.+”))@((\[[0–9]{1,3}\.[0–9]{1,3}\.[0–9]{1,3}\.[0–9]{1,3}])|(([a-zA-Z\-0–9]+\.)+[a-zA-Z]{2,}))$";
            regex = new Regex(patronCorreo);
            if (!regex.IsMatch(txtCorreo.Text))
            {
                MessageBox.Show("Correo Invalido", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                retorno = false;
            }
            return retorno;
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
                int resultado = daoCoordinador.eliminarCoordinador(coordinador);
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
            frmBuscarCoordinador frmBuscar = new frmBuscarCoordinador();
            if (frmBuscar.ShowDialog() == DialogResult.OK)
            {
                this.coordinador = frmBuscar.Coordinador;
                datosAnteriores[0] = coordinador.dni;
                datosAnteriores[1] = coordinador.correo;
                datosAnteriores[2] = coordinador.usuario;
                fillText(this.coordinador);
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

        private void btnImagen_Click(object sender, EventArgs e)
        {
            if (ofd_Imagen.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(ofd_Imagen.FileName, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                //Asignamos el archivo al objeto
                imagen_perfil = br.ReadBytes((int)fs.Length);
                br.Close();
                fs.Close();
                displayImage(imagen_perfil);
            }

        }

        private void txt_Enter(object sender, EventArgs e)
        {

            Control evento = (sender as Control);
            if (evento.Name == "txtDni")
                errorDni.Clear();
            if (evento.Name == "txtCorreo")
                errorCorreo.Clear();
            if (evento.Name == "txtCodigo")
                errorCodigo.Clear();
            if (evento.Name == "txtUsuario")
                errorUsuario.Clear();
            //if (evento.Name == "dtpFechaNacimiento")
            //validarFecha(sender as DateTimePicker);
        }

        private void txt_Leave(object sender, EventArgs e)
        {//validar que el dni tenga 8 digitos
            Control evento = (sender as Control);
            if (evento.Name == "txtDni")
                validarDNI(evento as TextBox);
            if (evento.Name == "txtCorreo")
                validarCorreo(evento as TextBox);
            if (evento.Name == "txtUsuario")
                validarUsuario(evento as TextBox);
            if (evento.Name == "txtCodigo")
                validarCodigo(evento as TextBox);

        }

        private void validarCodigo(TextBox textBox)
        {
            string patronDNI = @"^[0-9]+$";
            regex = new Regex(patronDNI);
            if (!regex.IsMatch(textBox.Text))
                errorCodigo.SetError(textBox, "El codigo debe estar compuesto por números");
            else if (textBox.Text.Length != 8)
                errorCodigo.SetError(textBox, "El codigo debe tener 8 dígitos");
        }

        private void validarUsuario(TextBox textBox)
        {
            if (estado == Estado.Modificar && datosAnteriores[2] == txtUsuario.Text) return;
            else if (textBox.Text == "") errorUsuario.SetError(textBox, "Debe ingresar un usuario");
            else if (new GestionAtencionWS.GestionAtencionWSClient().validar_usuario_unico(textBox.Text) == 1)
                errorUsuario.SetError(textBox, "El usuario ya existe");
        }

        private void validarCorreo(TextBox sender)
        {
            string patronCorreo = @"^(([^<>()\[\]\\.,;:\s@”]+(\.[^<>()\[\]\\.,;:\s@”]+)*)|(“.+”))@((\[[0–9]{1,3}\.[0–9]{1,3}\.[0–9]{1,3}\.[0–9]{1,3}])|(([a-zA-Z\-0–9]+\.)+[a-zA-Z]{2,}))$";
            regex = new Regex(patronCorreo);
            if (estado == Estado.Modificar && datosAnteriores[1] == txtCorreo.Text) return;
            else if (!regex.IsMatch(txtCorreo.Text))
                errorCorreo.SetError(sender, "El correo debe ser de la forma ejemplo@servidor.extension");
        }

        private void validarDNI(TextBox sender)
        {
            string patronDNI = @"^[0-9]+$";
            regex = new Regex(patronDNI);
            if (estado == Estado.Modificar && datosAnteriores[0] == txtDni.Text) return;
            else if (!regex.IsMatch(txtDni.Text))
                errorDni.SetError(sender, "El DNI debe estar compuesto por números");
            else if (txtDni.Text.Length != 8)
                errorDni.SetError(sender, "El codigo debe tener 8 dígitos");
            else
            {
                int cantUsuarios = new GestionHumanaWS.GestionHumanaWSClient().autenticar_persona_dni(Int32.Parse(txtDni.Text));
                if (cantUsuarios == 1)
                    errorDni.SetError(sender, "Este DNI ya está registrado");
            }
        }
    }
}
