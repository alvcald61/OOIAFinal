using System;
using System.Windows.Forms;

namespace ProyectoOOIA.Ventanas
{

    public partial class frmInicioSesion : Form
    {

        public frmInicioSesion()
        {
            InitializeComponent();
        }

        private void frmInicioSesion_Load(object sender, EventArgs e)
        {

        }


        private void linkContraseña_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new frmReestablecerContraseña().ShowDialog();
        }


        private void btnIngresar_Click(object sender, EventArgs e)
        {
            lblPassIncorrecto.Visible = false;
            int id_persona =
                new GestionHumanaWS.GestionHumanaWSClient().autenticarUsuario(txtUsuario.Text,txtContraseña.Text);
            


            if (id_persona == 0)
            {
                lblPassIncorrecto.Visible = true;
            }
            else
            {
                int tipoUsuario = new GestionHumanaWS.GestionHumanaWSClient().tipoUsuario(id_persona);

                if ( tipoUsuario == 1)
                {
                    new frmPrincipal(TipoUsuario.Alumno, id_persona, tipoUsuario).Show();
                    this.Close();
                }
                else if (tipoUsuario == 2 || tipoUsuario == 3)
                {
                    new frmPrincipal(TipoUsuario.Asesor, id_persona, tipoUsuario).Show();
                    this.Close();
                }
                else if (tipoUsuario == 4)
                {
                    new frmPrincipal(TipoUsuario.OOIA, id_persona, tipoUsuario).Show();
                    this.Close();
                }
            }
        }

        private void frmInicioSesion_KeyPress(object sender, KeyPressEventArgs e)
        {
       
       
        }

        private void pnlRight_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
        }

    }
}

