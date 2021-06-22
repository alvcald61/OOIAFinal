using ProyectoOOIA.Ventanas.Alumno.Citas;
using System;
using System.ComponentModel;
using System.Runtime.Remoting.Channels;
using System.Windows.Forms;
using ProyectoOOIA.GestionHumanaWS;
using ProyectoOOIA.ProfesorWS;
using ProyectoOOIA.PsicologoWS;
using miembroPUCP = ProyectoOOIA.GestionHumanaWS.miembroPUCP;

namespace ProyectoOOIA.Ventanas
{
    public partial class frmListaTutores : Form
    {
        private GestionHumanaWS.GestionHumanaWSClient humanaDao;
        ProfesorWS.ProfesorWSClient daoProfesor;
        PsicologoWS.PsicologoWSClient daoPsicologo;
        
        private GestionHumanaWS.miembroPUCP asesor;
        private BindingList<ucAsesor> listaprof = new BindingList<ucAsesor>();
        private BindingList<ucAsesor> listapsi = new BindingList<ucAsesor>();
        public frmListaTutores()
        {
            InitializeComponent();
            humanaDao = new GestionHumanaWSClient();

            tabTutor.HorizontalScroll.Enabled = false;
            tabTutor.HorizontalScroll.Visible = false;
            tabTutor.HorizontalScroll.Maximum = 0;
            tabTutor.AutoScroll = true;
            tabPsic.HorizontalScroll.Enabled = false;
            tabPsic.HorizontalScroll.Visible = false;
            tabPsic.HorizontalScroll.Maximum = 0;
            tabPsic.AutoScroll = true;
            daoProfesor = new ProfesorWS.ProfesorWSClient();
            daoPsicologo = new PsicologoWS.PsicologoWSClient();

            BindingList<GestionHumanaWS.profesor>
                profesores = new BindingList<GestionHumanaWS.profesor>
                (humanaDao.listarProfesor());

            BindingList<GestionHumanaWS.psicologo>
                psicologos = new BindingList<GestionHumanaWS.psicologo>
                (humanaDao.listarPsicologo());

            for (int i = 0; i < profesores.Count / 2; i++)
            {
                ucAsesor uc = new ucAsesor(profesores[i]);
                listaprof.Add(uc);
                pnlTutorLeft.Controls.Add(uc);
                uc.Dock = DockStyle.Top;
                Panel pnl = new Panel();
                pnlTutorLeft.Controls.Add(pnl);
                pnl.Dock = DockStyle.Top;
                pnl.Height = 30;
            }
            for (int i = profesores.Count / 2; i < profesores.Count; i++)
            {
                ucAsesor uc = new ucAsesor(profesores[i]);
                listaprof.Add(uc);
                pnlTutorRight.Controls.Add(uc);
                uc.Dock = DockStyle.Top;
                Panel pnl = new Panel();
                pnlTutorRight.Controls.Add(pnl);
                pnl.Dock = DockStyle.Top;
                pnl.Height = 30;
            }

            for (int j = 0; j < psicologos.Count / 2; j++)
            {

                ucAsesor uc = new ucAsesor(psicologos[j]);
                listapsi.Add(uc);
                pnlPsicLeft.Controls.Add(uc);
                uc.Dock = DockStyle.Top;
                Panel pnl = new Panel();
                pnlPsicLeft.Controls.Add(pnl);
                pnl.Dock = DockStyle.Top;
                pnl.Height = 30;
            }
            for (int j = psicologos.Count / 2; j < psicologos.Count; j++)
            {
                ucAsesor uc = new ucAsesor(psicologos[j]);
                listapsi.Add(uc);
                pnlPsicRight.Controls.Add(uc);
                uc.Dock = DockStyle.Top;
                Panel pnl = new Panel();
                pnlPsicRight.Controls.Add(pnl);
                pnl.Dock = DockStyle.Top;
                pnl.Height = 30;
            }

            foreach (ucAsesor aux in listaprof)
            {
                Button boton;
              //  aux.Click += btnSelec_Prof;
                boton=aux.BtnSeleccionar;
                boton.Click += (object sender, EventArgs e) =>
                {
                    this.asesor = aux.Asesor;
                    this.Close();
                };

                aux.BtnSeleccionar = boton;
            }

            foreach (ucAsesor aux in listapsi)
            {
                Button boton;
                //  aux.Click += btnSelec_Prof;
                boton = aux.BtnSeleccionar;
                boton.Click += (object sender, EventArgs e) =>
                {
                    this.asesor = aux.Asesor;
                    this.Close();
                };
                
                aux.BtnSeleccionar = boton;
            }

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void btnSelec_Asesor(object sender, EventArgs e)
        //{
        //    this.asesor = ((Button) sender).Asesor;
        //    this.Close();
        //}
        

        public miembroPUCP Asesor
        {
            get => asesor;
            set => asesor = value;
        }
    }
}
