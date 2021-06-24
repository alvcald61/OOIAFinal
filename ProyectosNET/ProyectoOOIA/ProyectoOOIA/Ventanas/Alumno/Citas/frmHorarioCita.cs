using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;
using System.Windows.Forms;
using ProyectoOOIA.GestionAtencionWS;

namespace ProyectoOOIA.Ventanas
{
    public partial class frmHorarioCita : Form
    {

        private GestionHumanaWS.miembroPUCP asesor;
        private GestionAtencionWS.GestionAtencionWSClient daoHorario;

        private DateTime monday;
        private DateTime friday;
        private DateTime horario_selected;
        private BindingList<GestionAtencionWS.horarioAsesor>
            horarios;

        private GestionAtencionWS.horarioAsesor retornoHorarioAsesor;


        private GestionAtencionWS.horario retorno;

        private System.Windows.Forms.RadioButton[] botones;

        private int numWeek;

        public DateTime Horario { get => horario_selected; set => horario_selected = value; }

        public frmHorarioCita(GestionHumanaWS.miembroPUCP asesor)
        {
            InitializeComponent();

            createButtons();

            numWeek = 1;
            btnPrevWeek.Enabled = false;
            btnPrevWeek.Visible = false;
            assignWeek();
            showWeek();
            
            this.asesor = asesor;
            daoHorario = new GestionAtencionWS.GestionAtencionWSClient();
            loadHorario();
        }
       
        public void createButtons()
        {
            this.botones = new System.Windows.Forms.RadioButton[90];
            for(int i=0; i<90; i++)
                botones[i] = new System.Windows.Forms.RadioButton();

            int xPos = 0;
            int yPos = 0;
            for (int i = 0; i < 90; i++)
            {
                botones[i].Tag = i + 1;
                botones[i].Appearance = Appearance.Button;
                //botones[i].FlatStyle = FlatStyle.Flat;
                //botones[i].FlatAppearance.BorderSize = 0;
                botones[i].CheckedChanged += eventoColor;

                botones[i].Margin = System.Windows.Forms.Padding.Empty;
                botones[i].Width = 94;
                botones[i].Height = 21;
                if (i % 5 == 0)
                {
                    xPos = 0;
                    yPos += 21;
                }
                botones[i].Left = xPos;
                botones[i].Top = yPos;

                tlpHorario.Controls.Add(botones[i]);
                xPos += botones[i].Width;
            }
        }

        private void eventoColor(object botones, EventArgs evento)
        {
            RadioButton boton = botones as RadioButton;
            if (boton.Checked == true) boton.BackColor = Color.Peru;
            else boton.BackColor = Color.White;
        }


        public void assignWeek()
        {
            DateTime now = DateTime.Now;
            DayOfWeek dow = now.DayOfWeek;
            int difference = 0;
            switch (dow)
            {
                case DayOfWeek.Monday:
                    difference = 0;
                    break;
                case DayOfWeek.Tuesday:
                    difference = 1;
                    break;
                case DayOfWeek.Wednesday:
                    difference = 2;
                    break;
                case DayOfWeek.Thursday:
                    difference = 3;
                    break;
                case DayOfWeek.Friday:
                    difference = 4;
                    break;
                case DayOfWeek.Saturday:
                    difference = 5;
                    break;
                case DayOfWeek.Sunday:
                    difference = 6;
                    break;
            }
            this.monday = now.AddDays(difference*(-1));
            this.friday = monday.AddDays(4);
        }


        public void showWeek()
        {
            lblWeek.Text =  monday.ToString("dd") + " de " + 
                            monday.ToString("MMMM") + " al " + 
                            friday.ToString("dd") + " de " +
                            friday.ToString("MMMM");
        }

        public void btnSeleccionar_Click(object sender, EventArgs e)
        {
            for(int i=0; i<90; i++)
            {
                if (botones[i].Checked)
                {
                    horario_selected = new DateTime(monday.Year, monday.Month,
                                                    monday.Day, 8, 0, 0);
                    horario_selected = horario_selected.AddDays(i % 5);
                    horario_selected = horario_selected.AddMinutes((i / 5)*30);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    retorno = horarios[i].horario;
                    retornoHorarioAsesor = horarios[i];
                    return;
                }

            }
            MessageBox.Show("Debe seleccionar un horario", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void loadHorario()
        {
            
            //try
            //{
                horarios = new BindingList<GestionAtencionWS.horarioAsesor>(daoHorario.listarHorarioAsesor(asesor.id_miembro_pucp));
            //}
            //catch { return; }
            DateTime now = DateTime.Now;
            for (int i=0; i<90; i++)
            {
                botones[i].BackColor = System.Drawing.Color.White;
                botones[i].Enabled = true;

                

                if (horarios[i].estado == "disponible")
                    botones[i].BackColor = System.Drawing.Color.White;
                if (horarios[i].estado == "No disponible")
                {
                    botones[i].BackColor = System.Drawing.Color.DarkGray;
                    botones[i].Enabled = false;
                }
                if (horarios[i].estado == "ocupado")
                {
                    botones[i].BackColor = System.Drawing.Color.DarkCyan;
                    botones[i].Enabled = false;
                }
                if (horarios[i].estado == "reservado")
                {
                    botones[i].BackColor = System.Drawing.Color.MidnightBlue;
                    botones[i].Enabled = false;
                }
                //if ((i % 5) < (int)now.DayOfWeek && numWeek == 1)
                //{
                //    botones[i].BackColor = System.Drawing.Color.DarkGray;
                //    botones[i].Enabled = false;
                //}

            }


        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            this.Close();
        }


        private void btnNextWeek_Click(object sender, EventArgs e)
        {
            numWeek++;
            if (numWeek == 4)
            {
                btnNextWeek.Enabled = false;
                btnNextWeek.Visible = false;
            }
            btnPrevWeek.Enabled = true;
            btnPrevWeek.Visible = true;

            monday = monday.AddDays(7);
            friday = friday.AddDays(7);
            showWeek();
            loadHorario();
        }

        private void btnPrevWeek_Click(object sender, EventArgs e)
        {
            numWeek--;
            if (numWeek == 1)
            {
                btnPrevWeek.Enabled = false;
                btnPrevWeek.Visible = false;
            }
            btnNextWeek.Enabled = true;
            btnNextWeek.Visible = true;

            monday = monday.AddDays(-7);
            friday = friday.AddDays(-7);
            showWeek();
            loadHorario();
        }

        public horario Retorno
        {
            get => retorno;
            set => retorno = value;
        }

        public horarioAsesor RetornoHorarioAsesor
        {
            get => retornoHorarioAsesor;
            set => retornoHorarioAsesor = value;
        }
    }
}
