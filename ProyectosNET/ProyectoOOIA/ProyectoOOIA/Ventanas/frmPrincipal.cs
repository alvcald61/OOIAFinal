using ProyectoOOIA.Ventanas.Miembro_OOIA;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ProyectoOOIA.GestionEventoWS;
using miembroPUCP = ProyectoOOIA.GestionHumanaWS.miembroPUCP;

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
        private GestionEventoWS.GestionEventoWSClient eventoDao;
        private BindingList<GestionEventoWS.evento> listaEventos;
        public frmPrincipal(TipoUsuario tipoUsuario, int id_usuario, int tipoIdUsuario)
        {

            InitializeComponent();
            usuarioDao = new GestionHumanaWS.GestionHumanaWSClient();
            listaEventos = new BindingList<evento>();
            eventoDao = new GestionEventoWSClient();
            btnCargaDatos.Visible = false;
            tipo = tipoUsuario;
            this.id_usuario = id_usuario;
            this.tipoIdUsuario = tipoIdUsuario;
            
            if (tipo == TipoUsuario.Asesor)
            {
                
                if (tipoIdUsuario == 2) usuario = usuarioDao.listarProfesorId(id_usuario);
                else if (tipoIdUsuario == 3) usuario = usuarioDao.listar_psicologo_x_id(id_usuario);
                btnEventos.Enabled = false;
                txtEventos.Enabled = false;
                
            }
            else 
            if (tipo == TipoUsuario.OOIA)
            {
                usuario = usuarioDao.listar_coordinador_x_id(id_usuario);
                btnCargaDatos.Visible = true;
                btnCitas.Enabled = false;
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
            eventoDao = new GestionEventoWSClient();
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

        private void frmPrincipal_Load_1(object sender, EventArgs e)
        {
            frmPrincipal_Load(sender,e);
            iniciarEventosProximos();
        }

        private void iniciarEventosProximos()
        {
            evento[] aux;
            try
            {
                 aux = eventoDao.listar_tres_eventos_proximos();
            }
            catch
            {
                return;
            }
            if (aux == null) return;
            listaEventos =new BindingList<evento>(aux);
            if (listaEventos.Count > 0)
                tarjeta1.iniciarComponentes(listaEventos[0].nombre, listaEventos[0].descripcion, listaEventos[0].fecha);
            else tarjeta1.Visible = false;
            if (listaEventos.Count > 1)
                tarjeta2.iniciarComponentes(listaEventos[1].nombre, listaEventos[1].descripcion, listaEventos[1].fecha);
            else tarjeta2.Visible = false;
            if (listaEventos.Count > 2)
                tarjeta3.iniciarComponentes(listaEventos[2].nombre, listaEventos[2].descripcion, listaEventos[2].fecha);
            else tarjeta2.Visible = false;
        }

        private void btnAccountSettings_Click(object sender, EventArgs e)
        {
            new frmAccountSettings(tipo, usuario).ShowDialog();
        }

        private void txtA_Click(object sender, EventArgs e)
        {

        }
    }
}

