using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoOOIA.GestionHumanaWS;

namespace ProyectoOOIA.Ventanas
{
    public partial class frmAccountSettings : Form
    {
        private GestionHumanaWS.miembroPUCP usuario;
        private TipoUsuario tipo;
        private byte[] imagen_perfil;
        private Estado estadoCorreo;
        private Estado estadoUsuario;
        private Estado estadoPassword;
        private ErrorProvider errorContra;
        private ErrorProvider errorConfirmacion;
        private ErrorProvider errorNombre;
        private ErrorProvider errorUsuario;
        private ErrorProvider errorCorreo;
        private ErrorProvider errorNuevo;
        private String usuarioAnt;

        public frmAccountSettings(TipoUsuario tipo, GestionHumanaWS.persona usuario)
        {
            errorConfirmacion = new ErrorProvider();
            errorCorreo = new ErrorProvider();
            errorContra = new ErrorProvider();
            errorNombre = new ErrorProvider();
            errorUsuario = new ErrorProvider();
            errorNuevo = new ErrorProvider();
            InitializeComponent();
            this.usuario = (GestionHumanaWS.miembroPUCP)usuario;
            imagen_perfil = this.usuario.imagenDePerfil;
            displayData();
            estadoCorreo = Estado.Inicial;
            estadoUsuario = Estado.Inicial;
            estadoPassword = Estado.Inicial;
            txtNombre.Enabled = true;
            //txtTipo.Enabled = false;
            txtCorreo.Enabled = true;
            txtUsuario.Enabled = true;
            txtPassword.Enabled = true;
            
            errorContra.BlinkStyle=ErrorBlinkStyle.NeverBlink;
             errorConfirmacion.BlinkStyle = ErrorBlinkStyle.NeverBlink;
             errorNombre.BlinkStyle = ErrorBlinkStyle.NeverBlink;
             errorUsuario.BlinkStyle = ErrorBlinkStyle.NeverBlink;
             errorCorreo.BlinkStyle = ErrorBlinkStyle.NeverBlink;
             errorNuevo.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            usuarioAnt = this.usuario.usuario;
             txtPasswordNew.Enabled = true;
             txtConfirmacion.Enabled = true;
             ttContra.SetToolTip(txtPasswordNew,"Dejar vacio si no quiere cambiar su contraseña");
        }

        public miembroPUCP Usuario
        {
            get => usuario;
            set => usuario = value;
        }

        public static byte[] ImageToByte2(Image img)
        {
            using (var stream = new MemoryStream())
            {
                img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                return stream.ToArray();
            }
        }

        public void displayImage(byte[] image)
        {
            if (image == null) return;
            MemoryStream ms = new MemoryStream(image);
            try
            {
                pbPerfil.Image = Image.FromStream(ms);
            }
            catch
            {

            }
        }

        public void displayData()
        {
            txtNombre.Text = usuario.nombre;
            //if (tipo == TipoUsuario.Alumno) txtTipo.Text = "Alumno";
            //if (tipo == TipoUsuario.Asesor) txtTipo.Text = "Asesor OOIA";
            //if (tipo == TipoUsuario.OOIA) txtTipo.Text = "Coordinador OOIA";
            txtCorreo.Text = usuario.correo;
            txtUsuario.Text = usuario.usuario;
            txtPassword.Text = "";
            displayImage(((GestionHumanaWS.miembroPUCP)usuario).imagenDePerfil);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
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
                usuario.imagenDePerfil = imagen_perfil;
                displayImage(usuario.imagenDePerfil);
                
            }
        }

        
        public int modificarCuenta()
        {
            int resultado = 0;
            
            DialogResult dr = MessageBox.Show("¿Esta seguro que desea guardar los cambios a su cuenta?", "Mensaje de Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                GestionHumanaWS.GestionHumanaWSClient daoUsuario = new GestionHumanaWS.GestionHumanaWSClient();
                if (this.usuario.GetType() == typeof(GestionHumanaWS.alumno)) resultado = daoUsuario.modificarAlumno((GestionHumanaWS.alumno)usuario);
                if (this.usuario.GetType() == typeof(GestionHumanaWS.profesor)) resultado = daoUsuario.modificarProfesores((GestionHumanaWS.profesor)usuario);
                if (this.usuario.GetType() == typeof(GestionHumanaWS.psicologo)) resultado = daoUsuario.modificarPsicologo((GestionHumanaWS.psicologo)usuario);
                if (this.usuario.GetType() == typeof(GestionHumanaWS.coordinador)) resultado = daoUsuario.modificarCoordinador((GestionHumanaWS.coordinador)usuario);
                if (resultado != 0)
                {
                    MessageBox.Show("Se ha actualizado con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Ha ocurrido un error", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return resultado;
        }

        private void errorEntrada(object sender, EventArgs e)
        {
            TextBox entrada=sender as TextBox;
            if (entrada.Name == "txtNombre") errorNombre.Clear();
            if (entrada.Name == "txtCorreo") errorCorreo.Clear();
            if (entrada.Name == "txtUsuario") errorUsuario.Clear();
//            if (entrada.Name == "txtPasswordNew") errorco.Clear();
            if (entrada.Name == "txtPassword") errorContra.Clear();
            if (entrada.Name == "txtConfirmacion") errorConfirmacion.Clear();
            if (entrada.Name == "txtPasswordNew")errorNuevo.Clear();
        }

        private void errorSalida(object sender, EventArgs e)
        {
            TextBox entrada = sender as TextBox;
            if (entrada.Name == "txtNombre") 
                validarNombre(entrada);
            if (entrada.Name == "txtCorreo")
                validarCorreo(entrada);
            if (entrada.Name == "txtUsuario")
                validarUsuario(entrada);
            if (entrada.Name == "txtPassword")
                validarContra(entrada);
            if (entrada.Name == "txtPasswordNew")
                validarNuevaContra(entrada);
            if (entrada.Name == "txtConfirmacion")
                validarNew(entrada);
            
        }

        private void validarNuevaContra(TextBox entrada)
        {
            if(txtPasswordNew.Text=="")errorNuevo.SetError(entrada,"Debe ingresar una contraseña");
        }

        private void validarNew(TextBox entrada)
        {
            if(entrada.Text!=txtPasswordNew.Text)errorConfirmacion.SetError(entrada,"Debe escribir la misma contraseña");
        }

        private void validarContra(TextBox entrada)
        {
            if (entrada.Text == "") return;
             if(new GestionHumanaWS.GestionHumanaWSClient().autenticarUsuario(usuario.usuario,txtPassword.Text)==0)
                errorContra.SetError(entrada,"La contraseña es incorrecta");
             else
             {
                 txtPasswordNew.Enabled = true;
                 txtConfirmacion.Enabled = true;
             }
        }

        private void validarUsuario(TextBox entrada)
        {
            if (entrada.Text == usuarioAnt)
            {
                errorUsuario.Clear();
                return;
            }
            if (entrada.Text == "") errorUsuario.SetError(entrada, "Debe ingresar un usuario");
            else
            if (new GestionAtencionWS.GestionAtencionWSClient().validar_usuario_unico(entrada.Text) == 1)
            {
                errorUsuario.SetError(entrada, "El usuario ya existe");
            }
        }

        private void validarCorreo(TextBox entrada)
        {
            
            string patronCorreo = @"^(([^<>()\[\]\\.,;:\s@”]+(\.[^<>()\[\]\\.,;:\s@”]+)*)|(“.+”))@((\[[0–9]{1,3}\.[0–9]{1,3}\.[0–9]{1,3}\.[0–9]{1,3}])|(([a-zA-Z\-0–9]+\.)+[a-zA-Z]{2,}))$";
            Regex regex = new Regex(patronCorreo);
            if(!regex.IsMatch(entrada.Text))
                errorCorreo.SetError(entrada,"Debe ingresar un correo de la forma ejemplo@ejemplo.ejemplo<");
                
        }

        private void validarNombre(TextBox entrada)
        {
            if(entrada.Text=="")errorNombre.SetError(entrada,"Debe ingresar un nombre");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string patronCorreo = @"^(([^<>()\[\]\\.,;:\s@”]+(\.[^<>()\[\]\\.,;:\s@”]+)*)|(“.+”))@((\[[0–9]{1,3}\.[0–9]{1,3}\.[0–9]{1,3}\.[0–9]{1,3}])|(([a-zA-Z\-0–9]+\.)+[a-zA-Z]{2,}))$";
            Regex regex = new Regex(patronCorreo);
            if(MessageBox.Show("¿Desea guardar los cambios?","Confirmación",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
            {
                if (txtNombre.Text == "")
                {
                    MessageBox.Show("Debe ingresar un nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (txtCorreo.Text == "")
                {
                    MessageBox.Show("Debe ingresar un correo valido", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
                else if (!regex.IsMatch(txtCorreo.Text))
                {
                    MessageBox.Show("Debe ingresar un correo valido", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
                else if (txtUsuario.Text != usuarioAnt && txtUsuario.Text == "")
                {
                    MessageBox.Show("Debe ingresar un usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (txtUsuario.Text != usuarioAnt &&
                         new GestionAtencionWS.GestionAtencionWSClient().validar_usuario_unico(txtUsuario.Text) == 1)
                {
                    MessageBox.Show("El usuario ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                usuario.correo = txtCorreo.Text;
                usuario.nombre = txtNombre.Text;
                usuario.usuario = txtUsuario.Text;
                usuario.imagenDePerfil = imagen_perfil;
                usuario.fecha_inclusionSpecified = true;
                usuario.fecha_nacimientoSpecified = true;
                GestionHumanaWS.GestionHumanaWSClient dao = new GestionHumanaWSClient();
                if (txtPasswordNew.Text != "")
                {

                    if (txtPasswordNew.Text == txtConfirmacion.Text)
                    {
                        dao.cambiar_password(usuario.id_miembro_pucp, txtPasswordNew.Text);
                        MessageBox.Show("Registro Exitoso", "Usuario Actualizado", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Confirmación de contraseña incorrecta", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                    }
                }


                if (usuario is GestionHumanaWS.alumno) dao.modificarAlumno(usuario as alumno);
                else if (usuario is coordinador) dao.modificarCoordinador(usuario as coordinador);
                else
                {
                    if (usuario is GestionHumanaWS.profesor is GestionHumanaWS.profesor) dao.modificarProfesores(usuario as profesor);
                    else dao.modificarPsicologo(usuario as psicologo);
                }

                MessageBox.Show("Registro Exitoso", "Usuario Actualizado", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }      
}

