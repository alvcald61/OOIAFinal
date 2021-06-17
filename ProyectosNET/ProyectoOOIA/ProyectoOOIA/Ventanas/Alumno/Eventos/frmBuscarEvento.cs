using System;
using System.Windows.Forms;
using ProyectoOOIA.GestionEventoWS;

namespace ProyectoOOIA.Ventanas
{
    public partial class frmBuscarEventoAlumno : Form
    {
        private GestionHumanaWS.persona persona;
        private GestionEventoWS.evento evento = new GestionEventoWS.evento();
        public frmBuscarEventoAlumno()
        {
            InitializeComponent();
            dgvEventos.AutoGenerateColumns = false;
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
            this.Close();
        }

        public evento Evento
        {
            get => evento;
            set => evento = value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvEventos.DataSource = new GestionEventoWS.GestionEventoWSClient().listarEvento_por_nombre_categoria(txtNombre.Text);

        }

        private void dgvEventos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            evento=  dgvEventos.Rows[e.RowIndex].DataBoundItem as GestionEventoWS.evento;
            dgvEventos.Rows[e.RowIndex].Cells[0].Value = evento.nombre;
            dgvEventos.Rows[e.RowIndex].Cells[1].Value = evento.fecha.Date.Day+"/"+evento.fecha.Month+"/"+evento.fecha.Year;
            dgvEventos.Rows[e.RowIndex].Cells[2].Value = evento.horaInicio.TimeOfDay.Hours+":"+evento.horaInicio.Minute;
            dgvEventos.Rows[e.RowIndex].Cells[3].Value = evento.horaFin.TimeOfDay.Hours +":"+evento.horaFin.Minute;
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
