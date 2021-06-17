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
            lblTipoIncorrecto.Visible = false;
            lblIncorrecto.Visible = false;
            int id_persona =
                new GestionHumanaWS.GestionHumanaWSClient().autenticarUsuario(txtUsuario.Text,txtContraseña.Text);
            int tipoUsuario = new GestionHumanaWS.GestionHumanaWSClient().tipoUsuario(id_persona);

            if (rbtAlumno.Checked == false && rbtTutor.Checked == false && rbtMiembroOOIA.Checked == false)
            {
                lblPassIncorrecto.Visible = false;
                lblTipoIncorrecto.Visible = true;
                lblIncorrecto.Visible = false;
            }
            else
            if (id_persona == 0)
            {
                lblTipoIncorrecto.Visible = false;
                lblPassIncorrecto.Visible = true;
                lblIncorrecto.Visible = false;
            }
            else
            {

                if (rbtAlumno.Checked == true && tipoUsuario == 1)
                {
                    new frmPrincipal(TipoUsuario.Alumno, id_persona, tipoUsuario).Show();
                    this.Close();
                }
                else if (rbtTutor.Checked == true && (tipoUsuario == 2 || tipoUsuario == 3))
                {
                    new frmPrincipal(TipoUsuario.Asesor, id_persona, tipoUsuario).Show();
                    this.Close();
                }
                else if (tipoUsuario == 4)
                {
                    new frmPrincipal(TipoUsuario.OOIA, id_persona, tipoUsuario).Show();
                    this.Close();
                }
                else
                {
                    lblTipoIncorrecto.Visible = false;
                    lblPassIncorrecto.Visible = false;
                    lblIncorrecto.Visible = true;
                }

            }
        }

        private void frmInicioSesion_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = '\n';
            if (e.KeyChar == c)
                btnIngresar_Click(null, null);
        }

        private void pnlRight_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
                btnIngresar_Click(null, null);
        }

    }
}

