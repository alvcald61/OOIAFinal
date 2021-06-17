using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoOOIA.Ventanas.Miembro_OOIA
{
    public partial class frmCodigosAtencion : Form
    {
        private Estado estado;
        private CodigoAtencionWS.CodigoAtencionWSClient daoCodigoAtencion;
        private CodigoAtencionWS.codigoAtencion codigoAtencion;
        private CodigoAtencionWS.codigoAtencion _codigoSeleccionado;

        public CodigoAtencionWS.codigoAtencion codigoSeleccionado { get => _codigoSeleccionado; set => _codigoSeleccionado = value; }
        public frmCodigosAtencion()
        {
            InitializeComponent();
            this.estado = Estado.Inicial;
            cambiarEstado();
            daoCodigoAtencion = new CodigoAtencionWS.CodigoAtencionWSClient();
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

                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnEditar.Enabled = true;
                    txtCodigoAtencion.Enabled = false;
                    txtDescripcion.Enabled = false;
                    break;
                case Estado.Nuevo:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnEditar.Enabled = false;
                    txtCodigoAtencion.Enabled = true;
                    txtDescripcion.Enabled = true;
                    break;
                case Estado.Modificar:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnEditar.Enabled = false;
                    txtCodigoAtencion.Enabled = true;
                    txtDescripcion.Enabled = true;
                    break;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
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
                else MessageBox.Show("Ha ocurrido un error", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void listarCodigos()
        {
            //lista desde el principio los codigos de atencion
            BindingList<CodigoAtencionWS.codigoAtencion>
                codigos = new BindingList<CodigoAtencionWS.codigoAtencion>
                (daoCodigoAtencion.listarCodigo().ToList());
            dgvCodigosAtencion.DataSource = codigos;
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.codigoAtencion = new CodigoAtencionWS.codigoAtencion();
            this.estado = Estado.Nuevo;
            cambiarEstado();
            limpiar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.estado = Estado.Inicial;
            cambiarEstado();
            limpiar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //si selecciona una fila 

            if (dgvCodigosAtencion.CurrentRow != null)
            {
                _codigoSeleccionado =
              (CodigoAtencionWS.codigoAtencion)dgvCodigosAtencion.CurrentRow.DataBoundItem;

                this.estado = Estado.Modificar;
                cambiarEstado();
                txtDescripcion.Text = _codigoSeleccionado.descripcion;
                txtCodigoAtencion.Text = _codigoSeleccionado.codigo;
                this.codigoAtencion = new CodigoAtencionWS.codigoAtencion();
                this.codigoAtencion.id_codigo_atencion = _codigoSeleccionado.id_codigo_atencion;
            }

        }



        private void dgvCodigosAtencion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
    }
}

