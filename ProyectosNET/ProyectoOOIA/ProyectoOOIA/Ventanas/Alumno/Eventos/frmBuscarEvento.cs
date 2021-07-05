using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using ProyectoOOIA.GestionEventoWS;

namespace ProyectoOOIA.Ventanas
{
    public partial class frmBuscarEventoAlumno : Form
    {
        private GestionHumanaWS.persona persona;
        private GestionEventoWS.GestionEventoWSClient daoEvento;
        private GestionEventoWS.evento evento = new GestionEventoWS.evento();
        private int tipo_persona;
        public frmBuscarEventoAlumno(int tipo)
        {
            InitializeComponent();
            dgvEventos.AutoGenerateColumns = false;
            daoEvento = new GestionEventoWS.GestionEventoWSClient();
            tipo_persona = tipo;
        }

        public frmBuscarEventoAlumno(GestionHumanaWS.persona persona)
        {
            InitializeComponent();
            dgvEventos.AutoGenerateColumns = false;
            this.persona = persona;
        }


        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            evento = null;
            this.Close();
        }

        public evento Evento
        {
            get => evento;
            set => evento = value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(tipo_persona==2)
                    dgvEventos.DataSource = new GestionEventoWS.GestionEventoWSClient().listarEvento_por_nombre_categoria(txtNombre.Text);
                else
                {

                    GestionEventoWS.evento[] aux = daoEvento.listarEvento_por_nombre_categoria(txtNombre.Text);
                    if (aux == null) return;
                    BindingList<GestionEventoWS.evento>
                       eventosCompletos = new BindingList<GestionEventoWS.evento>
                       (aux.ToList());

                    BindingList<GestionEventoWS.evento> eventos = new BindingList<GestionEventoWS.evento>();
                    foreach (GestionEventoWS.evento a in eventosCompletos)
                    {
                        if (a.fecha > DateTime.Now && a.activo == true) eventos.Add(a);
                    }

                    dgvEventos.DataSource = eventos;
                }
            }
            catch
            {
                return;
            }

        }

        private void dgvEventos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            evento=  dgvEventos.Rows[e.RowIndex].DataBoundItem as GestionEventoWS.evento;
            dgvEventos.Rows[e.RowIndex].Cells[0].Value = evento.nombre;
            dgvEventos.Rows[e.RowIndex].Cells[1].Value = evento.cupo;
            dgvEventos.Rows[e.RowIndex].Cells[2].Value = evento.fecha.Date.ToString("dd/MM/yyyy");
            dgvEventos.Rows[e.RowIndex].Cells[3].Value = evento.horaInicio.ToString("hh:mm");
            dgvEventos.Rows[e.RowIndex].Cells[4].Value = evento.horaFin.ToString("hh:mm");
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvEventos.CurrentRow.Index >= 0)
            {
                evento=dgvEventos.CurrentRow.DataBoundItem as GestionEventoWS.evento;
                this.Dispose();
            }
        }
    }
}
