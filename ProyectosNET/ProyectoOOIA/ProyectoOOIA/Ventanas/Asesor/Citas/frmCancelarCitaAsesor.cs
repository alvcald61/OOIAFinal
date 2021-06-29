using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace ProyectoOOIA.Ventanas
{
    public partial class frmCancelarCitaAsesor : Form
    {
        private bool respuesta = false;
        private GestionHumanaWS.persona alumno;
        public frmCancelarCitaAsesor(GestionHumanaWS.persona alumno)
        {
            this.alumno = alumno;
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dgvOpiniones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            respuesta = false;
            this.Close();
        }

        private void btnCancelarCita_Click(object sender, EventArgs e)
        {
            //new frmConfirmarCancelarAsesor().Show();
            DialogResult dr =
               MessageBox.Show("¿Esta seguro que desea cancelar la cita?", "Cancelar cita",
               MessageBoxButtons.YesNo, MessageBoxIcon.None);
            if (dr == DialogResult.Yes)
            {
                respuesta = true;
                MessageBox.Show("La cita ha sido cambiada exitosamente", "Cita Cancelada", MessageBoxButtons.OK);
                this.Close();
            }
           
        }
        private void enviarCorreo(string motivo, string mensaje)
        {
            var fromAddress = new MailAddress("OOIA.no.reply@gmail.com", "OOIA");
            var toAddress = new MailAddress(alumno.correo, alumno.nombre);
            const string fromPassword = "sistemaOOIA123";
            string subject = motivo;
            string body = mensaje;
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


    }
}
