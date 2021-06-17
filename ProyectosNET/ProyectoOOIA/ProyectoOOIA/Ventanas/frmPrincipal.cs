using ProyectoOOIA.Ventanas.Miembro_OOIA;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ProyectoOOIA.GestionHumanaWS;

namespace ProyectoOOIA.Ventanas
{
    public partial class frmPrincipal : Form
    {
        private BindingList<Bitmap> listaImagenes = new BindingList<Bitmap>();
        private int indice = 0;
        private TipoUsuario tipo;
        private int id_usuario;
        private int tipoIdUsuario;
        private GestionHumanaWS.persona usuario = null;
        private GestionHumanaWS.GestionHumanaWSClient usuarioDao;
        public frmPrincipal(TipoUsuario tipoUsuario, int id_usuario, int tipoIdUsuario)
        {
            InitializeComponent();
            usuarioDao = new GestionHumanaWS.GestionHumanaWSClient();
            btnCargaDatos.Visible = false;
            tipo = tipoUsuario;
            this.id_usuario = id_usuario;
            this.tipoIdUsuario = tipoIdUsuario;
            if (tipo == TipoUsuario.Asesor)
            {
                if (tipoIdUsuario == 2) usuario = usuarioDao.listar_profesor_x_id(id_usuario);
                else if (tipoIdUsuario == 3) usuario = usuarioDao.listar_psicologo_x_id(id_usuario);
                btnEventos.Enabled = false;
                //btnEventos.Visible = false;
                txtEventos.Enabled = false;

            }

            if (tipo == TipoUsuario.OOIA)
            {
                usuario = usuarioDao.listar_coordinador_x_id(id_usuario);
                btnCargaDatos.Visible = true;
                btnCitas.Enabled = false;
                //btnCitas.Visible = false;
                txtCitas.Enabled = false;
            }
            else usuario = usuarioDao.listar_alumno_x_id(id_usuario);
            listaImagenes.Add(ProyectoOOIA.Properties.Resources.profesor);
            listaImagenes.Add(ProyectoOOIA.Properties.Resources.EEGGCC);
            listaImagenes.Add(ProyectoOOIA.Properties.Resources.Estudiante);
            listaImagenes.Add(ProyectoOOIA.Properties.Resources.Tramite);
            imagenes.Image = listaImagenes[0];
            ToolTip ttEjemplo = new ToolTip();

            ttEjemplo.SetToolTip(btnCitas, "Programar citas");

        }
        public frmPrincipal(TipoUsuario tipoUsuario, GestionHumanaWS.persona persona)
        {
            InitializeComponent();

            btnCargaDatos.Visible = false;
            tipo = tipoUsuario;
            //this.id_usuario = id_usuario;
            //this.tipoIdUsuario = tipoIdUsuario;
            this.usuario = persona;
            if (tipo == TipoUsuario.Asesor)
            {
                btnEventos.Enabled = false;
                //btnEventos.Visible = false;
                txtEventos.Enabled = false;

            }

            if (tipo == TipoUsuario.OOIA)
            {
                btnCargaDatos.Visible = true;
                btnCitas.Enabled = false;
                //btnCitas.Visible = false;
                txtCitas.Enabled = false;
            }

            listaImagenes.Add(ProyectoOOIA.Properties.Resources.profesor);
            listaImagenes.Add(ProyectoOOIA.Properties.Resources.EEGGCC);
            listaImagenes.Add(ProyectoOOIA.Properties.Resources.Estudiante);
            listaImagenes.Add(ProyectoOOIA.Properties.Resources.Tramite);
            imagenes.Image = listaImagenes[0];
            //ToolTip ttEjemplo = new ToolTip();

            //ttEjemplo.SetToolTip(btnCitas, "Programar citas");

        }



        private void imagenes_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            indice++;
            if (indice >= listaImagenes.Count)
                indice = 0;
            imagenes.Image = listaImagenes[indice];
        }

        private void botonCitas_Click(object sender, EventArgs e)
        {
            if (tipo == TipoUsuario.Alumno) new frmCitasAlumno(usuario).Show();
            if (tipo == TipoUsuario.Asesor) new frmHorarioAsesor(usuario).Show();
            this.Close();
        }

        private void botonEventos_Click(object sender, EventArgs e)
        {
            if (tipo == TipoUsuario.Alumno) new frmRegistroEvento(usuario).Show();
            if (tipo == TipoUsuario.OOIA) new frmGestionEventosOOIA(Estado.Inicial, usuario).Show();
            this.Close();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            new frmInicioSesion().Show();
            this.Close();
        }

        private void btnCargaDatos_Click(object sender, EventArgs e)
        {
            new frmCargarDatos().ShowDialog();

        }

        private void frmPrincipal_ClientSizeChanged(object sender, EventArgs e)
        {

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblUsername.Text = usuario.nombre;
            try
            {
                imagen.BackgroundImage = new Bitmap(new MemoryStream(((miembroPUCP)usuario).imagenDePerfil));
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                //throw;
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmPrincipal_Load_1(object sender, EventArgs e)
        {
            frmPrincipal_Load(sender,e);
        }
    }
}

