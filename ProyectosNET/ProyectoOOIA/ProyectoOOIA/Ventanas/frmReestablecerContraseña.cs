using System;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;

namespace ProyectoOOIA.Ventanas
{
    public partial class frmReestablecerContraseña : Form
    {
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
            string contra = cadenaAletaoria();
            //metodo para buscar usuarios por correo y actualizar su clave
            enviarContrasenia(contra);
        }

        private void enviarContrasenia(string contra)
        {
            var fromAddress = new MailAddress("alvarocalderom@gmail.com", "OOIA");
            var toAddress = new MailAddress(txtcorreo.Text, "Usuario");
            const string fromPassword = "juntosaporlaundecima";
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
            int longitud = 7;
            Guid miGuid = Guid.NewGuid();
            string token = Convert.ToBase64String(miGuid.ToByteArray());
            token = token.Replace("=", "").Replace("+", "");
            return token;
        }
    }
}
