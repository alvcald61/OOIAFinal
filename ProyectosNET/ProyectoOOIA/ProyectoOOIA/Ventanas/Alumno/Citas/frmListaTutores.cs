using ProyectoOOIA.Ventanas.Alumno.Citas;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ProyectoOOIA.Ventanas
{
    public partial class frmListaTutores : Form
    {

        ProfesorWS.ProfesorWSClient daoProfesor;
        PsicologoWS.PsicologoWSClient daoPsicologo;

        public frmListaTutores()
        {
            InitializeComponent();

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

            BindingList<ProfesorWS.profesor>
                profesores = new BindingList<ProfesorWS.profesor>
                (daoProfesor.listarProfesor());

            BindingList<PsicologoWS.psicologo>
                psicologos = new BindingList<PsicologoWS.psicologo>
                (daoPsicologo.listarPsicologo());

            for (int i = 0; i < profesores.Count / 2; i++)
            {
                UserControl uc = new ucAsesor(profesores[i]);
                pnlTutorLeft.Controls.Add(uc);
                uc.Dock = DockStyle.Top;
                Panel pnl = new Panel();
                pnlTutorLeft.Controls.Add(pnl);
                pnl.Dock = DockStyle.Top;
                pnl.Height = 30;
            }
            for (int i = profesores.Count / 2; i < profesores.Count; i++)
            {
                UserControl uc = new ucAsesor(profesores[i]);
                pnlTutorRight.Controls.Add(uc);
                uc.Dock = DockStyle.Top;
                Panel pnl = new Panel();
                pnlTutorRight.Controls.Add(pnl);
                pnl.Dock = DockStyle.Top;
                pnl.Height = 30;
            }

            for (int j = 0; j < psicologos.Count / 2; j++)
            {
                UserControl uc = new ucAsesor(psicologos[j]);
                pnlPsicLeft.Controls.Add(uc);
                uc.Dock = DockStyle.Top;
                Panel pnl = new Panel();
                pnlPsicLeft.Controls.Add(pnl);
                pnl.Dock = DockStyle.Top;
                pnl.Height = 30;
            }
            for (int j = psicologos.Count / 2; j < psicologos.Count; j++)
            {
                UserControl uc = new ucAsesor(psicologos[j]);
                pnlPsicRight.Controls.Add(uc);
                uc.Dock = DockStyle.Top;
                Panel pnl = new Panel();
                pnlPsicRight.Controls.Add(pnl);
                pnl.Dock = DockStyle.Top;
                pnl.Height = 30;
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
