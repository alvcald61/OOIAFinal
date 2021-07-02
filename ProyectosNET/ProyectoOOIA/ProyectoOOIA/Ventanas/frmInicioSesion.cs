using System;
using System.Windows.Forms;

namespace ProyectoOOIA.Ventanas
{

    public partial class frmInicioSesion : Form
    {

        private GestionHumanaWS.GestionHumanaWSClient daoUsuario;
        private GestionHumanaWS.miembroPUCP usuario;
        private int id_usuario;

        public frmInicioSesion()
        {
            InitializeComponent();
            daoUsuario = new GestionHumanaWS.GestionHumanaWSClient();
        }



        private void linkContraseña_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new frmReestablecerContraseña().ShowDialog();
        }


        private void btnIngresar_Click(object sender, EventArgs e)
        {
            lblPassIncorrecto.Visible = false;
            id_usuario = daoUsuario.autenticarUsuario(txtUsuario.Text,txtContraseña.Text);

            if (id_usuario == 0)
            {
                lblPassIncorrecto.Visible = true;
            }
            else
            {
                int tipoUsuario = daoUsuario.tipoUsuario(id_usuario);

                switch (tipoUsuario)
                {
                    case 1:
                        usuario = daoUsuario.listar_alumno_x_id(id_usuario);
                        break;
                    case 2:
                        usuario = daoUsuario.listarProfesorId(id_usuario);
                        break;
                    case 3:
                        usuario = daoUsuario.listar_psicologo_x_id(id_usuario);
                        break;
                    case 4:
                        usuario = daoUsuario.listar_coordinador_x_id(id_usuario);
                        break;
                }
                new frmPrincipal(usuario).Show();
                this.Close();
            }
        }
    }
}

