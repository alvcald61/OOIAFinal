using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoOOIA.Ventanas.Miembro_OOIA
{
    public partial class frmCodigosAtencion : Form
    {
        private Estado estado;
        private GestionAtencionWS.GestionAtencionWSClient daoCodigoAtencion;
        private GestionAtencionWS.codigoAtencion codigoAtencion;
        private GestionAtencionWS.codigoAtencion _codigoSeleccionado;

        public GestionAtencionWS.codigoAtencion codigoSeleccionado { get => _codigoSeleccionado; set => _codigoSeleccionado = value; }
        public frmCodigosAtencion()
        {
            InitializeComponent();
            this.estado = Estado.Inicial;
            cambiarEstado();
            daoCodigoAtencion = new GestionAtencionWS.GestionAtencionWSClient();
            dgvCodigosAtencion.AutoGenerateColumns = false;

            listarCodigos();
        }

        public void limpiar()
        {
            txtCodigoAtencion.Text = "";
            txtDescripcion.Text = "";
        }
        public void cambiarEstado()
        {
            switch (estado)
            {
                case Estado.Inicial:
                    tsbNuevo.Enabled = true;
                    tsbGuardar.Enabled = false;
                    tsbCancelar.Enabled = false;
                    tsbModificar.Enabled = true;
                    txtCodigoAtencion.Enabled = false;
                    txtDescripcion.Enabled = false;
                    break;
                case Estado.Nuevo:
                case Estado.Modificar:
                    tsbNuevo.Enabled = false;
                    tsbGuardar.Enabled = true;
                    tsbCancelar.Enabled = true;
                    tsbModificar.Enabled = false;
                    txtCodigoAtencion.Enabled = true;
                    txtDescripcion.Enabled = true;
                    break;
            }
        }

        private void listarCodigos()
        {
            //lista desde el principio los codigos de atencion
            BindingList<GestionAtencionWS.codigoAtencion>
                codigos = new BindingList<GestionAtencionWS.codigoAtencion>
                (daoCodigoAtencion.listarCodigo().ToList());
            dgvCodigosAtencion.DataSource = codigos;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            new frmInicioSesion().Show();
            this.Close();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            this.codigoAtencion = new GestionAtencionWS.codigoAtencion();
            this.estado = Estado.Nuevo;
            cambiarEstado();
            limpiar();
        }

        private void tsbGuardar_Click_1(object sender, EventArgs e)
        {
            if (txtCodigoAtencion.Text == "")
            {
                MessageBox.Show("No ha ingresado el código de atención", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtDescripcion.Text == "")
            {
                MessageBox.Show("No ha ingresado la descripción", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.codigoAtencion.codigo = txtCodigoAtencion.Text;
            this.codigoAtencion.descripcion = txtDescripcion.Text;

            if (estado.Equals(Estado.Nuevo))
            {
                int resultado = daoCodigoAtencion.insertarCodigo(codigoAtencion);
                if (resultado != 0)
                {
                    MessageBox.Show("Se ha registrado con exito", "Mensaje Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.estado = Estado.Inicial;
                    cambiarEstado();
                }
                else
                {
                    if (resultado == 0)
                        MessageBox.Show("Ha ocurrido un error", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show("El código ya se encuentra registrado", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (estado == Estado.Modificar)
            {
                int resultado = daoCodigoAtencion.modificarCodigo(codigoAtencion);
                if (resultado != 0)
                {
                    MessageBox.Show("Se ha actualizado con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.estado = Estado.Inicial;
                    cambiarEstado();
                }
                else
                    MessageBox.Show("Ha ocurrido un error", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            limpiar();
            listarCodigos();
        }

        private void tsbModificar_Click(object sender, EventArgs e)
        {
            //si selecciona una fila 

            if (dgvCodigosAtencion.CurrentRow != null)
            {
                _codigoSeleccionado =
              (GestionAtencionWS.codigoAtencion)dgvCodigosAtencion.CurrentRow.DataBoundItem;

                this.estado = Estado.Modificar;
                cambiarEstado();
                txtDescripcion.Text = _codigoSeleccionado.descripcion;
                txtCodigoAtencion.Text = _codigoSeleccionado.codigo;
                this.codigoAtencion = new GestionAtencionWS.codigoAtencion();
                this.codigoAtencion.id_codigo_atencion = _codigoSeleccionado.id_codigo_atencion;
            }

        }
    

        private void tsbEliminar_Click(object sender, EventArgs e)
        {

        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            this.estado = Estado.Inicial;
            cambiarEstado();
            limpiar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BindingList<GestionAtencionWS.codigoAtencion>
                codigos = new BindingList<GestionAtencionWS.codigoAtencion>
                (daoCodigoAtencion.listarCodigo().ToList());
            dgvCodigosAtencion.DataSource = codigos;
        }
    }
}

