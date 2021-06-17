using ProyectoOOIA.AlumnoWS;
using ProyectoOOIA.PonenteWS;
using ProyectoOOIA.ProfesorWS;
using System;
using System.Windows.Forms;

namespace ProyectoOOIA.Ventanas.Miembro_OOIA.Eventos
{
    public partial class frmMostrarPonentes : Form
    {

        private int tipoUsuario = -1;
        private GestionEventoWS.ponente ponente=null;

        public frmMostrarPonentes()
        {
            InitializeComponent();
            dgvPonentes.AutoGenerateColumns = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //tipoUsuario = cmbHorario.SelectedIndex;


            ponente = new GestionEventoWS.ponente();
            dgvPonentes.DataSource = new GestionHumanaWS.GestionHumanaWSClient().listarPonente();

        }

        public int TipoUsuario
        {
            get => tipoUsuario;
            set => tipoUsuario = value;
        }

       

        public GestionEventoWS.ponente Ponente
        {
            get => ponente;
            set => ponente = value;
        }

        private void dgvPonentes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            GestionHumanaWS.ponente aux = (GestionHumanaWS.ponente)dgvPonentes.Rows[e.RowIndex].DataBoundItem ;
            
                dgvPonentes.Rows[e.RowIndex].Cells[0].Value = aux.nombre;
                dgvPonentes.Rows[e.RowIndex].Cells[1].Value = aux.correo;
            
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (ponente == null) return;
             GestionHumanaWS.ponente persona= dgvPonentes.CurrentRow.DataBoundItem as GestionHumanaWS.ponente;
             ponente.activo = persona.activo;
             ponente.id_ponente = persona.id_ponente;
             ponente.organizacion = persona.organizacion;
             ponente.correo = persona.correo;
             ponente.direccion = persona.direccion;
             ponente.dni = persona.dni;
             ponente.fecha_nacimiento = persona.fecha_nacimiento;
             ponente.fecha_nacimientoSpecified = true;
             ponente.id_miembro_externo = persona.id_miembro_externo;
             ponente.id_persona = persona.id_persona;
             ponente.nombre = persona.nombre;
             ponente.ocupacion = persona.ocupacion;
             ponente.telefono = persona.telefono;


             this.Dispose();
        }
    }
}
