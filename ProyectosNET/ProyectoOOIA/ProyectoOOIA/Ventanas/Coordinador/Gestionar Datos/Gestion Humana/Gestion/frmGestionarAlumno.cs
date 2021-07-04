using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ProyectoOOIA.Ventanas.Miembro_OOIA.Cargar_Datos
{
    public partial class frmGestionarAlumno : Form
    {

        private GestionHumanaWS.GestionHumanaWSClient daoEspecialidad;
        private GestionHumanaWS.GestionHumanaWSClient daoAlumno;
        private GestionHumanaWS.alumno alumno;
        private byte[] imagen_perfil;
        private Estado estado;
        private Regex regex ;
        private ErrorProvider errorDni;
        private ErrorProvider errorCorreo;
        private ErrorProvider errorCodigo;
        private ErrorProvider errorUsuario;
        private string[] datosAnteriores;

        public frmGestionarAlumno()
        {
            errorCorreo = new ErrorProvider();
            errorDni = new ErrorProvider();
            errorCodigo = new ErrorProvider();
            errorUsuario = new ErrorProvider();
            InitializeComponent();
            estado = Estado.Inicial;
            clearall();
            cambiarEstado();
            //Inicializar DAO
            daoEspecialidad = new GestionHumanaWS.GestionHumanaWSClient();
            daoAlumno = new GestionHumanaWS.GestionHumanaWSClient();
            //Inicializar ComboBox Especialidad
            cbEspecialidad.DataSource = new BindingList<GestionHumanaWS.especialidad>
                (daoEspecialidad.listarEspecialidad().ToList());
            cbEspecialidad.DisplayMember = "nombre";
            cbEspecialidad.ValueMember = "id_especialidad";
            dtpFechaNacimiento.MaxDate = DateTime.Now.AddDays(-5840);
            errorCorreo.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorCodigo.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorDni.BlinkStyle= ErrorBlinkStyle.NeverBlink;
            errorUsuario.BlinkStyle= ErrorBlinkStyle.NeverBlink;
            datosAnteriores = new string[4];
            for (int i = 0; i < datosAnteriores.Length; i++) datosAnteriores[i] = "";
        }

        public void clearall()
        {
            /*Persona*/
            txtDni.Text = "";
            txtNombre.Text = "";
            dtpFechaNacimiento.Value = DateTime.Today.AddDays(-6570);
            txtDireccion.Text = "";
            txtCorreo.Text = "";
            /*Miembro PUCP*/
            txtUsuario.Text = "";
            txtPassword.Text = "";
            /*Alumno*/
            txtCodigo.Text = "";
            cbEspecialidad.SelectedIndex = -1;
            /*Imagen*/
            Image img = Properties.Resources.placeholder_profile;
            imagen_perfil = ImageToByte2(img);
            displayImage(imagen_perfil);
            errorCodigo.Clear();
            errorCorreo.Clear();
            errorDni.Clear();
            errorUsuario.Clear();
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
                    /*Alumno*/
                    txtCodigo.Enabled = false;
                    cbEspecialidad.Enabled = false;
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
                    /*Alumno*/
                    txtCodigo.Enabled = true;
                    cbEspecialidad.Enabled = true;
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
                    /*Alumno*/
                    txtCodigo.Enabled = false;
                    cbEspecialidad.Enabled = false;
                    break;
            }
        }

        public void displayImage(byte[] image)
        {
            MemoryStream ms = new MemoryStream(image);
            pbPerfil1.Image = Image.FromStream(ms);
            pbPerfil2.Image = Image.FromStream(ms);
        }

        /*Botones de Header*/
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*Botones de Toolstrip*/

        public void fillText(GestionHumanaWS.alumno alu)
        {
            //Persona
            txtDni.Text = alu.dni;
            txtNombre.Text = alu.nombre;
            dtpFechaNacimiento.Value = alu.fecha_nacimiento;
            txtDireccion.Text = alu.direccion;
            txtCorreo.Text = alu.correo;
            //Miembro PUCP
            txtUsuario.Text = alu.usuario;
            txtPassword.Text = "";
            imagen_perfil = alu.imagenDePerfil;
            if(imagen_perfil != null)displayImage(imagen_perfil);
            //Alumno
            txtCodigo.Text = alumno.codigo;
            GestionHumanaWS.especialidad esp_selected = new GestionHumanaWS.especialidad();
            esp_selected.id_especialidad = alu.especialidad.id_especialidad;
            esp_selected.nombre = alu.especialidad.nombre;
            cbEspecialidad.SelectedValue = esp_selected.id_especialidad;
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            this.alumno = new GestionHumanaWS.alumno();
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
            if(!validarPersona()) return;
            //Validación Miembro PUCP
            if (!validarUsuario()) return;
            //Validación Alumno
            if (!validarAlumno()) return;

            //Persona
            alumno.dni = txtDni.Text;
            alumno.nombre = txtNombre.Text;
            alumno.fecha_nacimiento = dtpFechaNacimiento.Value;
            alumno.fecha_nacimientoSpecified = true;
            alumno.direccion = txtDireccion.Text;
            alumno.correo = txtCorreo.Text;
            //Miembro PUCP
            alumno.usuario = txtUsuario.Text;
            alumno.password = txtPassword.Text;
            alumno.imagenDePerfil = imagen_perfil;
            alumno.fecha_inclusion = DateTime.Today.Date;
            alumno.fecha_inclusionSpecified = true;
            //Alumno
            alumno.codigo = txtCodigo.Text;
            GestionHumanaWS.especialidad esp_selected = (GestionHumanaWS.especialidad)cbEspecialidad.SelectedItem;
            alumno.especialidad = new GestionHumanaWS.especialidad();
            alumno.especialidad.id_especialidad = esp_selected.id_especialidad;
            alumno.craest = 0;
            alumno.creditos_aprobados = 0;

            if (estado.Equals(Estado.Nuevo))
            {
                //Validacion de persona repetida
                int cantUsuarios = new GestionHumanaWS.GestionHumanaWSClient().autenticar_persona_dni(
                int.Parse(txtDni.Text));
                //int cantUsuarios = 1;
                if (cantUsuarios == 1)
                {
                    MessageBox.Show("Ya existe una persona registrada con el mismo DNI", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int resultado = daoAlumno.insertarAlumno(alumno);
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
                int resultado = daoAlumno.modificarAlumno(alumno);
                if (resultado != 0)
                {
                    if (txtPassword.Text != "")
                        new GestionHumanaWS.GestionHumanaWSClient().cambiar_password(alumno.id_miembro_pucp, txtPassword.Text);

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
            if (txtDni.Text.Length != 8)
            {
                MessageBox.Show("El DNI debe conformarse de 8 números", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtNombre.Text == "")
            {
                MessageBox.Show("No ha ingresado el nombre", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if ((DateTime.Today.Year - dtpFechaNacimiento.Value.Year) < 14)
            {
                MessageBox.Show("La fecha ingresada es incorrecta", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtDireccion.Text == "")
            {
                MessageBox.Show("No ha ingresado la dirección", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false ;
            }
            if (txtCorreo.Text == "")
            {
                MessageBox.Show("No ha ingresado el correo", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false ;
            }
            string patronDNI = @"\d{8}";
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

        private bool validarUsuario()
        {
            if (txtUsuario.Text == "")
            {
                MessageBox.Show("No ha ingresado el usuario", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtPassword.Text == "" && estado == Estado.Nuevo)
            {
                MessageBox.Show("No ha ingresado la contraseña", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private bool validarAlumno()
        {
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("No ha ingresado el código", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cbEspecialidad.SelectedIndex == -1)
            {
                MessageBox.Show("No ha seleccionado la especialidad", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void tsbModificar_Click(object sender, EventArgs e)
        {
            this.estado = Estado.Modificar;
            cambiarEstado();
            ttContraseña.SetToolTip(txtPassword, "Dejar vacia para mantener la contraseña anterior");
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Esta seguro que desea eliminar este alumno?", "Mensaje de Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                int resultado = daoAlumno.eliminarAlumno(alumno.id_alumno);
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
            frmBuscarAlumno frmBuscar = new frmBuscarAlumno();
            if (frmBuscar.ShowDialog() == DialogResult.OK)
            {
                this.alumno = frmBuscar.Alumno;
                datosAnteriores[0] = alumno.dni;
                datosAnteriores[1] = alumno.correo;
                datosAnteriores[2] = alumno.usuario;
                datosAnteriores[3] = alumno.codigo;
                fillText(this.alumno);
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

        private void txtDni_Leave(object sender, EventArgs e)
        {//validar que el dni tenga 8 digitos
            Control evento = (sender as Control);
            if (evento.Name=="txtDni")
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
            if (estado == Estado.Modificar)
                if (datosAnteriores[3] == txtCodigo.Text) return;
            string patronDNI = @"\d{8}";
            regex = new Regex(patronDNI);
            if (!regex.IsMatch(textBox.Text))
                errorCodigo.SetError(textBox, "El codigo debe tener 8 digitos");
        }

        private void validarUsuario(TextBox textBox)
        {
            if (estado == Estado.Modificar)
                if (datosAnteriores[2] == txtUsuario.Text) return;
            if (textBox.Text == "") errorUsuario.SetError(textBox,"Debe ingresar un usuario");
            else 
            if(new GestionAtencionWS.GestionAtencionWSClient().validar_usuario_unico(textBox.Text)==1)
            {
                errorUsuario.SetError(textBox, "El usuario ya existe");
            }
        }

        private void validarCorreo(TextBox sender)
        {
            string patronCorreo = @"^(([^<>()\[\]\\.,;:\s@”]+(\.[^<>()\[\]\\.,;:\s@”]+)*)|(“.+”))@((\[[0–9]{1,3}\.[0–9]{1,3}\.[0–9]{1,3}\.[0–9]{1,3}])|(([a-zA-Z\-0–9]+\.)+[a-zA-Z]{2,}))$";
            regex = new Regex(patronCorreo);
            if (estado == Estado.Modificar)
                if (datosAnteriores[1] == txtCorreo.Text) return;
            if (!regex.IsMatch(txtCorreo.Text))
            {
                errorCorreo.SetError(sender,"El correo debe ser de la forma ejemplo@servidor.extension");

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
                if (cantUsuarios == 1)    errorDni.SetError(sender, "Este DNI ya está registrado");   
            }
        }

        private void txtDni_Enter(object sender, EventArgs e)
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

        
    }
}
