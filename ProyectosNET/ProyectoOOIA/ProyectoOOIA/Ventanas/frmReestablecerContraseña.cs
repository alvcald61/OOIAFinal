using System;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;
using ProyectoOOIA.GestionHumanaWS;

namespace ProyectoOOIA.Ventanas
{
    public partial class frmReestablecerContraseña : Form
    {
        private GestionHumanaWS.GestionHumanaWSClient inicioSesion = new GestionHumanaWSClient();
        public frmReestablecerContraseña()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose(true);
        }

        private void btnReestablecer_Click(object sender, EventArgs e)
        {
            Object[] lista = inicioSesion.listar_usuario_correo(txtcorreo.Text);
            int usuario = (int)lista[1];
            string correo = (string)lista[0];
            if (usuario == 0)
            {
                MessageBox.Show("El usuario no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string contra = cadenaAletaoria().Substring(0,7);
                enviarContrasenia(contra, correo);
                inicioSesion.cambiar_password(usuario, contra);
                MessageBox.Show("La contraseña ha sido reestablecida, revise su correo:\n" + correo, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void enviarContrasenia(string contra, string correo)
        {
            var fromAddress = new MailAddress("OOIA.no.reply@gmail.com", "OOIA");
            var toAddress = new MailAddress(correo, "Usuario");
            const string fromPassword = "sistemaOOIA123";
            const string subject = "Contraseña actualizada";
            string body = "Estimado usuario, hemos actualizado su contraseña.\n\n\nSu nueva contraseña es " + contra + "\n";

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }

        }


        private string cadenaAletaoria()
        {
            
            Guid miGuid = Guid.NewGuid();
            string token = Convert.ToBase64String(miGuid.ToByteArray());
            token = token.Replace("=", "").Replace("+", "");
            return token;
        }
    }
}
