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
            lblHeader.Text = evento.nombre;
            dgvPonentes.AutoGenerateColumns = false;
            txtLugar.ReadOnly = true;
            txtCapacidad.ReadOnly = true;
            txtCupo.ReadOnly = true;
            txtDescripcion.ReadOnly=true;
            dtpFecha.Value = evento.fecha;
            dtpHoraInicio.Value = evento.horaInicio;
            dtpHoraFin.Value = evento.horaFin;
            txtLugar.Text = evento.lugar;
            txtCapacidad.Text = evento.capacidad.ToString();
            txtCupo.Text = evento.capacidad.ToString();
            txtDescripcion.Text = evento.descripcion;
            MemoryStream ms;
            if (evento.imagen != null)
            {
                ms = new MemoryStream(evento.imagen);
                pbEvento.Image = Image.FromStream(ms);
            }
            else
            {

            }

            daoEventoPonente = new GestionEventoWSClient();
            dtpFecha.Enabled = false;
            dtpHoraInicio.Enabled = false;
            mostrarPonentes(evento);
        }

        public void mostrarPonentes(GestionEventoWS.evento evento)
        {
            
            GestionEventoWS.ponente[] aux = daoEventoPonente.listarPonenteXEvento(evento.id_evento);
            if (aux == null) return;
            BindingList<GestionEventoWS.ponente>
               eventosAlumnos = new BindingList<GestionEventoWS.ponente>
               (aux.ToList());
            dgvPonentes.DataSource = eventosAlumnos;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
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
