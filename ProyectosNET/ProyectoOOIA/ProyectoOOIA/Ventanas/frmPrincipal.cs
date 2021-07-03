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
        private GestionHumanaWS.miembroPUCP usuario;
        private GestionEventoWS.GestionEventoWSClient eventoDao;
        private BindingList<GestionEventoWS.evento> listaEventos;

        public frmPrincipal(GestionHumanaWS.miembroPUCP usuario)
        {

            InitializeComponent();
            listaEventos = new BindingList<evento>();
            eventoDao = new GestionEventoWSClient();

            this.usuario = usuario;

            if (usuario.GetType() == typeof(GestionHumanaWS.alumno)) tipo = TipoUsuario.Alumno;
            if (usuario.GetType() == typeof(GestionHumanaWS.profesor)) tipo = TipoUsuario.Asesor;
            if (usuario.GetType() == typeof(GestionHumanaWS.psicologo)) tipo = TipoUsuario.Asesor;
            if (usuario.GetType() == typeof(GestionHumanaWS.coordinador)) tipo = TipoUsuario.OOIA;

            arrangeMenu();
            loadImages();
            iniciarEventosProximos();

            ToolTip ttEjemplo = new ToolTip();
            ttEjemplo.SetToolTip(btnAsesorias, "Programar citas");
            
        }

        public void arrangeMenu()
        {
            lblUsername.Text = usuario.nombre;
            try
            {
                imagen.BackgroundImage = new Bitmap(new MemoryStream(((miembroPUCP)usuario).imagenDePerfil));
            }
            catch (Exception exception)
            {
                imagen.BackgroundImage = ProyectoOOIA.Properties.Resources.placeholder_profile;
                Console.WriteLine(exception);
            }
            if (tipo == TipoUsuario.Alumno)
            {
                lblTitulo.Text = "OOIA - Alumno";
                //Visible
                btnAsesorias.Visible = true;
                btnEventos.Visible = false;
                btnInfo.Visible = false;
                //Enabled
                btnAsesorias.Enabled = true;
                btnEventos.Enabled = false;
                btnInfo.Enabled = false;
                //Positions
                btnAsesorias.Location = new Point(12,6);
                btnEventos.Location = new Point(130, 6);

            }
            else if (tipo == TipoUsuario.Asesor)
            {
                lblTitulo.Text = "OOIA - Asesor";
                //Visible
                btnAsesorias.Visible = true;
                btnEventos.Visible = false;
                btnInfo.Visible = false;
                //Enabled
                btnAsesorias.Enabled = true;
                btnEventos.Enabled = false;
                btnInfo.Enabled = false;
                //Positions
                btnAsesorias.Location = new Point(12, 6);
            }
            else if (tipo == TipoUsuario.OOIA)
            {
                lblTitulo.Text = "OOIA - Administrador";
                //Visible
                btnAsesorias.Visible = false;
                btnEventos.Visible = true;
                btnInfo.Visible = true;
                //Enabled
                btnAsesorias.Enabled = false;
                btnEventos.Enabled = true;
                btnInfo.Enabled = true;
                //Positions
                btnEventos.Location = new Point(12, 6);
                btnInfo.Location = new Point(130, 6);
            }
        }

        public void loadImages()
        {
            listaImagenes.Add(ProyectoOOIA.Properties.Resources.profesor);
            listaImagenes.Add(ProyectoOOIA.Properties.Resources.EEGGCC);
            listaImagenes.Add(ProyectoOOIA.Properties.Resources.Estudiante);
            listaImagenes.Add(ProyectoOOIA.Properties.Resources.Tramite);
            imagenes.Image = listaImagenes[0];
        }

        private void imageTimer_Tick(object sender, EventArgs e)
        {
            indice++;
            if (indice >= listaImagenes.Count)
                indice = 0;
            imagenes.Image = listaImagenes[indice];
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            new frmInicioSesion().Show();
            this.Close();
        }


        private void iniciarEventosProximos()
        {
            try
            {
                evento[] aux = eventoDao.listar_tres_eventos_proximos();
                if (aux == null) return;
                listaEventos = new BindingList<evento>(aux);
                foreach (evento e in listaEventos)
                {
                    ucProxEvento uc = new ucProxEvento(e.nombre, e.categoria.nombre, e.fecha);
                    pnlProxEventos.Controls.Add(uc);
                    uc.Dock = DockStyle.Top;
                }

            }
            catch { return; }
            
        }

        private void btnAccountSettings_Click(object sender, EventArgs e)
        {
            frmAccountSettings aux=new frmAccountSettings(tipo, usuario);
            aux.ShowDialog();
            usuario = aux.Usuario;
            arrangeMenu();
            displayImage(usuario.imagenDePerfil);
            
        }

        public void displayImage(byte[] image)
        {
            if (image == null) return;
            MemoryStream ms = new MemoryStream(image);
            try
            {
                imagen.Image = Image.FromStream(ms);
            }
            catch
            {

            }
        }


        private void btnInfo_Click(object sender, EventArgs e)
        {
            new frmCargarDatos().ShowDialog();
        }

        private void btnEvento_Click(object sender, EventArgs e)
        {
            if (tipo == TipoUsuario.Alumno) new frmRegistroEvento(usuario).Show();
            if (tipo == TipoUsuario.OOIA) new frmGestionEventosOOIA(Estado.Inicial, usuario).Show();
            this.Close();
        }

        private void btnAsesoria_Click(object sender, EventArgs e)
        {
            if (tipo == TipoUsuario.Alumno) new frmCitasAlumno(usuario).Show();
            if (tipo == TipoUsuario.Asesor) new frmHorarioAsesor(usuario).Show();
            this.Close();
        }
    }
}

