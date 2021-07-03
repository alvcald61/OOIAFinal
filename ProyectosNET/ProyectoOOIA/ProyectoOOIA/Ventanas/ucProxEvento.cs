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
        public ucProxEvento(string nombre, string categoria, DateTime fecha)
        {
            InitializeComponent();
            lblNombre.Text = nombre;
            lblCategoria.Text = categoria;
            lblFecha.Text = fecha.ToString("D");
            lblDia.Text = fecha.ToString("dd");
        }
    }
}
