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

        public frmAccountSettings(TipoUsuario tipo, GestionHumanaWS.persona usuario)
        {
            InitializeComponent();
            this.usuario = (GestionHumanaWS.miembroPUCP)usuario;
            imagen_perfil = this.usuario.imagenDePerfil;
            displayData();
            estadoCorreo = Estado.Inicial;
            estadoUsuario = Estado.Inicial;
            estadoPassword = Estado.Inicial;
            txtNombre.Enabled = false;
            txtTipo.Enabled = false;
            txtCorreo.Enabled = false;
            txtUsuario.Enabled = false;
            txtPassword.Enabled = false;
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
            MemoryStream ms = new MemoryStream(image);
            pbPerfil.Image = Image.FromStream(ms);
        }

        public void displayData()
        {
            txtNombre.Text = usuario.nombre;
            if (tipo == TipoUsuario.Alumno) txtTipo.Text = "Alumno";
            if (tipo == TipoUsuario.Asesor) txtTipo.Text = "Asesor OOIA";
            if (tipo == TipoUsuario.OOIA) txtTipo.Text = "Coordinador OOIA";
            txtCorreo.Text = usuario.correo;
            txtUsuario.Text = usuario.usuario;
            txtPassword.Text = "********";
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
                displayImage(imagen_perfil);
                usuario.imagenDePerfil = imagen_perfil;
            }
        }

        private void btnEditCorreo_Click(object sender, EventArgs e)
        {
            if (estadoCorreo == Estado.Inicial)
            {
                txtCorreo.Enabled = true;
                btnEditCorreo.Image = Properties.Resources.save;
                estadoCorreo = Estado.Modificar;
            }
            else if (estadoCorreo == Estado.Modificar)
            {
                if (!txtCorreo.Modified)
                {
                    txtCorreo.Enabled = false;
                    btnEditCorreo.Image = Properties.Resources.edit_black;
                    estadoCorreo = Estado.Inicial;
                    return;
                }
                usuario.correo = txtCorreo.Text;
                int resultado = modificarCuenta();
                if (resultado != 0)
                {
                    txtCorreo.Enabled = false;
                    btnEditCorreo.Image = Properties.Resources.edit_black;
                    estadoCorreo = Estado.Inicial;
                    displayData();
                }
            }
        }

        private void btnEditUsuario_Click(object sender, EventArgs e)
        {
            if (estadoUsuario == Estado.Inicial)
            {
                txtUsuario.Enabled = true;
                btnEditUsuario.Image = Properties.Resources.save;
                estadoUsuario = Estado.Modificar;
            }
            else if (estadoUsuario == Estado.Modificar)
            {
                if(!txtUsuario.Modified)
                {
                    txtUsuario.Enabled = false;
                    btnEditUsuario.Image = Properties.Resources.edit_black;
                    estadoUsuario = Estado.Inicial;
                    return;
                }
                usuario.usuario = txtUsuario.Text;
                int resultado = modificarCuenta();
                if(resultado != 0)
                {
                    txtUsuario.Enabled = false;
                    btnEditUsuario.Image = Properties.Resources.edit_black;
                    estadoUsuario = Estado.Inicial;
                    displayData();
                }
            }
        }

        private void btnEditPassword_Click(object sender, EventArgs e)
        {
            if (estadoPassword == Estado.Inicial)
            {
                txtPassword.Enabled = true;
                btnEditPassword.Image = Properties.Resources.save;
                estadoPassword = Estado.Modificar;
            }
            else if (estadoPassword == Estado.Modificar)
            {
                if (!txtPassword.Modified)
                {
                    txtPassword.Enabled = false;
                    btnEditPassword.Image = Properties.Resources.edit_black;
                    estadoPassword = Estado.Inicial;
                    return;
                }
                usuario.password = txtPassword.Text;
                int resultado = modificarCuenta();
                if (resultado != 0)
                {
                    txtPassword.Enabled = false;
                    btnEditPassword.Image = Properties.Resources.edit_black;
                    estadoPassword = Estado.Inicial;
                    displayData();
                }
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
    }      
}
