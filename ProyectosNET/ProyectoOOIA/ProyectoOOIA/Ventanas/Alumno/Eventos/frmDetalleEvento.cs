using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ProyectoOOIA.GestionEventoWS;

namespace ProyectoOOIA.Ventanas
{
    public partial class frmDetalleEvento : Form
    {
        GestionEventoWS.GestionEventoWSClient daoEventoPonente;

        public frmDetalleEvento(GestionEventoWS.evento evento)
        {
            InitializeComponent();

            dtpFecha.Value = evento.fecha;
            dtpHoraInicio.Value = evento.horaInicio;
            dtpHoraInicio.Value = evento.horaFin;
            txtLugar.Text = evento.lugar;
            txtCapacidad.Text = evento.capacidad.ToString();
            txtCupo.Text = evento.capacidad.ToString();
            txtDescripcion.Text = evento.descripcion;
            MemoryStream ms = new MemoryStream(evento.imagen);
            pbEvento.Image = Image.FromStream(ms);
            daoEventoPonente = new GestionEventoWSClient();
            mostrarPonentes(evento);
        }

        public void mostrarPonentes(GestionEventoWS.evento evento)
        {
            BindingList<GestionEventoWS.ponente>
                ponentes = new BindingList<GestionEventoWS.ponente>
                (daoEventoPonente.listarPonenteXEvento(evento.id_evento).ToList());
            dgvPonentes.DataSource = ponentes;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDetalleEvento_Load(object sender, EventArgs e)
        {

        }

        private void dgvPonentes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvPonentes.Rows[e.RowIndex].DataBoundItem == null) return;
            GestionEventoWS.ponente data = dgvPonentes.Rows[e.RowIndex].DataBoundItem
                as GestionEventoWS.ponente;
            dgvPonentes.Rows[e.RowIndex].Cells[0].Value = data.nombre;
        }
    }
}
