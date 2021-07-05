using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoOOIA.Ventanas
{
    public partial class ucProxEvento : UserControl
    {
        public ucProxEvento(GestionEventoWS.evento evento)
        {
            InitializeComponent();
            lblNombre.Text = evento.nombre;
            lblCategoria.Text = evento.categoria.nombre;
            lblFecha.Text = evento.fecha.ToString("D");
            lblHora.Text = evento.horaInicio.ToString("hh:mm") + " a " + evento.horaFin.ToString("hh:mm");
            lblDia.Text = evento.fecha.ToString("dd");
        }
    }
}
