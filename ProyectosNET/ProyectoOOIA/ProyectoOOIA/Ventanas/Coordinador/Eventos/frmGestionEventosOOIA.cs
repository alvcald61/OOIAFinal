using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoOOIA.EventoWS;
using ProyectoOOIA.GestionEventoWS;
using ProyectoOOIA.Ventanas.Miembro_OOIA.Eventos;
using ponente = ProyectoOOIA.GestionEventoWS.ponente;


namespace ProyectoOOIA.Ventanas
{
    public partial class frmGestionEventosOOIA : Form
    {
        private GestionHumanaWS.persona persona;

        ErrorProvider errorNombre = new ErrorProvider();
        ErrorProvider errorFecha = new ErrorProvider();
        ErrorProvider errorFin = new ErrorProvider();
        ErrorProvider errorInicio = new ErrorProvider();
        ErrorProvider errorDescripcion = new ErrorProvider();
        ErrorProvider errorLugar = new ErrorProvider();
        private GestionEventoWS.GestionEventoWSClient eventoDao;
        private GestionEventoWS.evento evento;
        private BindingList<GestionEventoWS.ponente> lista = new BindingList<GestionEventoWS.ponente>();
        private BindingList<GestionEventoWS.ponente> listaModificar = new BindingList<GestionEventoWS.ponente>();
        private GestionEventoWS.ponente ponente;
        private Byte[] imagen;
        private Estado estado = Estado.Inicial;
        public frmGestionEventosOOIA(Estado estado)
        {
            InitializeComponent();
            componentes(estado);
            cboCategoria.DataSource = new GestionEventoWS.GestionEventoWSClient().listarCategoriaEvento();
            errorNombre.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            dgvPonentes.AutoGenerateColumns = false;
            dgvPonentes.RowCount = 0;
            errorFin.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorInicio.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorFecha.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorNombre.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorLugar.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorDescripcion.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            evento = new GestionEventoWS.evento();
            eventoDao = new GestionEventoWS.GestionEventoWSClient();
        }

        public frmGestionEventosOOIA(Estado estado, GestionHumanaWS.persona persona)
        {
            InitializeComponent();
            componentes(estado);

            errorNombre.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            dgvPonentes.AutoGenerateColumns = false;
            dgvPonentes.RowCount = 0;
            errorFin.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorInicio.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorFecha.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorNombre.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorLugar.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorDescripcion.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            evento = new GestionEventoWS.evento();
            eventoDao = new GestionEventoWS.GestionEventoWSClient();
            this.persona = persona;
            cboCategoria.DataSource = eventoDao.listarCategoriaEvento();

            cboCategoria.DisplayMember = "nombre";
            


        }

        private void componentes(Estado estado)
        {
            switch (estado)
            {
                case Estado.Inicial:
                    btnNuevo.Enabled = false;
                    btnAgregarImagen.Enabled = false;
                    btnAgregarPonente.Enabled = false;
                    btnBuscar.Enabled = true;
                    btnCancelar.Enabled = false;
                    btnEliminarPonente.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnModificar.Enabled = false;
                    dtpFechaEvento.Enabled = false;
                    dtpFin.Enabled = true;
                    dtpInicio.Enabled = true;
                    txtNombre.Enabled = false;
                    txtNombrePonente.Enabled = false;
                    txtDescripcion.Enabled = false;
                    cboCategoria.Enabled = false;
                    dgvPonentes.Enabled = false;
                    npdCapacidad.Enabled = false;
                    txtLugar.Enabled = false;
                    dgvPonentes.RowCount = 1;
                    btnBuscarPonente.Enabled = false;
                    cboCategoria.Enabled = false;
                    dtpFin.Enabled = false;
                    dtpInicio.Enabled = false;
                    btnEliminar.Enabled = false;
                    break;
                case Estado.Nuevo:
                    btnNuevo.Enabled = true;
                    btnAgregarImagen.Enabled = true;
                    btnAgregarPonente.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnEliminarPonente.Enabled = true;
                    btnGuardar.Enabled = true;
                    btnNuevo.Enabled = true;
                    btnModificar.Enabled = false;
                    dtpFechaEvento.Enabled = true;
                    dtpFin.Enabled = true;
                    dtpInicio.Enabled = true;
                    txtNombre.Enabled = true;
                    txtNombrePonente.Enabled = false;
                    txtDescripcion.Enabled = true;
                    cboCategoria.Enabled = true;
                    dgvPonentes.Enabled = true;
                    npdCapacidad.Enabled = true;
                    txtLugar.Enabled = true;
                    btnBuscarPonente.Enabled = true;
                    cboCategoria.Enabled = true;
                    btnEliminar.Enabled = false;

                    break;
                case Estado.Busqueda:
                    btnNuevo.Enabled = false;
                    btnAgregarImagen.Enabled = false;
                    btnAgregarPonente.Enabled = false;
                    btnBuscar.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnEliminarPonente.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnModificar.Enabled = true;
                    dtpFechaEvento.Enabled = false;
                    dtpFin.Enabled = true;
                    dtpInicio.Enabled = true;
                    txtNombre.Enabled = false;
                    txtNombrePonente.Enabled = false;
                    txtDescripcion.Enabled = false;
                    cboCategoria.Enabled = false;
                    dgvPonentes.Enabled = false;
                    npdCapacidad.Enabled = false;
                    txtLugar.Enabled = false;
                    cboCategoria.Enabled = false;
                    dtpFin.Enabled = false;
                    dtpInicio.Enabled = false;
                    btnEliminar.Enabled = true;
                    break;
                case Estado.Modificar:
                    btnNuevo.Enabled = true;
                    btnAgregarImagen.Enabled = true;
                    btnAgregarPonente.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnEliminarPonente.Enabled = true;
                    btnGuardar.Enabled = true;
                    btnNuevo.Enabled = true;
                    btnModificar.Enabled = false;
                    dtpFechaEvento.Enabled = true;
                    dtpFin.Enabled = true;
                    dtpInicio.Enabled = true;
                    txtNombre.Enabled = true;
                    txtNombrePonente.Enabled = false;
                    txtDescripcion.Enabled = true;
                    cboCategoria.Enabled = true;
                    dgvPonentes.Enabled = true;
                    npdCapacidad.Enabled = true;
                    txtLugar.Enabled = true;
                    btnBuscarPonente.Enabled = true;
                    cboCategoria.Enabled = true;
                    btnEliminar.Enabled = true;
                    break;

            }
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarEventoAlumno aux=new frmBuscarEventoAlumno();
            aux.ShowDialog();
            componentes(Estado.Busqueda);
            evento = aux.Evento;
            txtNombre.Text = evento.nombre;
            txtDescripcion.Text = "Descripcion";
            txtLugar.Text = evento.lugar;
            dtpFechaEvento.Value = evento.fecha;
            dtpInicio.Value = evento.horaInicio;
            dtpFin.Value = evento.horaFin;
            cboCategoria.SelectedItem = evento.categoria;
            
            npdCapacidad.Value = evento.capacidad;
            try
            {
                pictureBox1.Image = new Bitmap(new MemoryStream(evento.imagen));
            }
            catch (Exception exception)
            {
                MessageBox.Show("Este evento no tiene imagen asociada", "Imagen",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
            lista = new BindingList<ponente>();
            if (evento.ponentes== null) return;
            foreach (GestionEventoWS.ponente auxPonente in evento.ponentes)

            {
                dgvPonentes.Rows.Add();
                dgvPonentes.Rows[dgvPonentes.RowCount - 1].Cells[0].Value = auxPonente.nombre;
                listaModificar.Add(auxPonente);
                

            }
            
            



        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new frmPrincipal(TipoUsuario.OOIA,persona).Show();
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validacionDatos()==1)
            {
                evento.nombre = txtNombre.Text;
                evento.fecha = dtpFechaEvento.Value;
                evento.fechaSpecified = true;
                evento.activo = true;
                evento.capacidad = Decimal.ToInt32(npdCapacidad.Value);
                evento.horaInicio = dtpInicio.Value;
                evento.horaFin = dtpFin.Value;
                evento.horaFinSpecified = true;
                evento.horaInicioSpecified = true;
                evento.categoria = new GestionEventoWS.categoriaEvento();
                evento.categoria=(GestionEventoWS.categoriaEvento)cboCategoria.SelectedItem ;
                evento.lugar = txtLugar.Text;
                evento.descripcion = txtDescripcion.Text;
                evento.imagen = imagen;
                evento.ponentes = lista.ToArray();
                
                

                //evento.ponentes = lista.ToArray();
                DialogResult dr =
                    MessageBox.Show("¿Desea registrar este evento?", "Guardar Evento",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    if(estado==Estado.Nuevo)
                    {
                        evento.coordinador = new GestionEventoWS.coordinador();
                        evento.coordinador.id_coordinador = (persona as GestionHumanaWS.coordinador).id_coordinador;
                        if (eventoDao.insertarEvento(evento) == 1)
                        {
                            MessageBox.Show("El registro ha sido exitoso", "Exito", MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
                        }
                        else
                            MessageBox.Show("Ha habido un error", "Error", MessageBoxButtons.RetryCancel,
                                MessageBoxIcon.Error);
                    }
                    else if (estado == Estado.Modificar)
                    {
                        foreach (GestionEventoWS.ponente xPonente in listaModificar)
                        {
                                Console.WriteLine(xPonente.id_ponente);
                        }
                        evento.ponentes = listaModificar.ToArray();
                        if (eventoDao.modificarEvento(evento) == 1)
                        {
                            MessageBox.Show("La modificacion ha sido exitoso", "Exito", MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
                        }
                        else
                            MessageBox.Show("Ha habido un error en la modificación", "Error", MessageBoxButtons.RetryCancel,
                                MessageBoxIcon.Error);
                    }

                }
            }
        }

        private int validacionDatos()
        {
            if (lista.Count == 0 && estado==Estado.Inicial)
            {
                MessageBox.Show("Debe ingresar al menos un ponente", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return 0;
            }
            else if(listaModificar.Count==0 && estado==Estado.Modificar){
                MessageBox.Show("Debe ingresar al menos un ponente", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return 0;
            }
            else if(dtpInicio.Value>dtpFin.Value ) MessageBox.Show("La hora final debe ser mayor a la inicial", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if(txtDescripcion.Text=="" || txtLugar.Text=="" || txtNombre.Text=="") MessageBox.Show("Debe ingresar algún texto en los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return 1;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            componentes(Estado.Nuevo);
            estado = Estado.Nuevo;


        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            if (agregarImagen.ShowDialog() == DialogResult.OK)
            {
                imagen = File.ReadAllBytes(agregarImagen.InitialDirectory + agregarImagen.FileName);
                pictureBox1.Image = new Bitmap(agregarImagen.InitialDirectory + agregarImagen.FileName);
                
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            componentes(Estado.Inicial);
            limpiar();
        }

        private void limpiar()
        {
             txtNombre.Text="";
            dtpFechaEvento.Value=DateTime.Today;
            npdCapacidad.Value=1;
             dtpInicio.Value=DateTime.Now;
             dtpFin.Value = DateTime.Now;
             cboCategoria.SelectedIndex = 0;
            txtLugar.Text="";
            txtDescripcion.Text="";
            pictureBox1.Image = null;
            lista.Clear();
            evento.coordinador = null;
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            estado = Estado.Modificar;
            componentes(Estado.Nuevo);
            
        }

        private void btnAgregarPonente_Click(object sender, EventArgs e)
        {
            if (estado == Estado.Nuevo) agregaNuevo();
            else agregaModificar();
        }

        private void agregaModificar()
        {
            if (ponente != null)
            {
                dgvPonentes.Rows.Add();
                dgvPonentes.Rows[dgvPonentes.RowCount - 1].Cells[0].Value = ponente.nombre;
                listaModificar.Add(ponente);
                ponente = null;
            }
            else
                MessageBox.Show("no puede agregar a un ponente dos veces", "error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }


        private void agregaNuevo()
        {
            if (ponente != null)
            {
                dgvPonentes.Rows.Add();
                dgvPonentes.Rows[dgvPonentes.RowCount - 1].Cells[0].Value = ponente.nombre;
                lista.Add(ponente);
                ponente = null;
            }
            else
                MessageBox.Show("no puede agregar a un ponente dos veces", "error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }
        private void btnBuscarPonente_Click(object sender, EventArgs e)
        {
            frmMostrarPonentes mostrar = new frmMostrarPonentes();
            mostrar.ShowDialog();
            ponente = mostrar.Ponente;
            //ponente = asignarPersona(mostrar.Ponente);
            txtNombrePonente.Text = ponente.nombre;

        }

        private CoordinadorWS.coordinador asignarPersona(PonenteWS.persona mostrarPersona)
        {
            CoordinadorWS.coordinador aux= new CoordinadorWS.coordinador();
            aux.nombre = mostrarPersona.nombre;
            aux.correo = mostrarPersona.correo;
            aux.id_persona = mostrarPersona.id_persona;
            aux.direccion = mostrarPersona.direccion;
            //aux.edad = mostrarPersona.edad;
            aux.dni = mostrarPersona.dni;
            return aux;

        }

        private void btnEliminarPonente_Click(object sender, EventArgs e)
        {
            if (dgvPonentes.CurrentRow.Index >= 0 && estado==Estado.Nuevo)
            {
                lista.RemoveAt(dgvPonentes.CurrentRow.Index);
                dgvPonentes.Rows.RemoveAt(dgvPonentes.CurrentRow.Index);
            }
            else if (dgvPonentes.CurrentRow.Index >= 0 && estado == Estado.Modificar)
            {
                listaModificar.RemoveAt(dgvPonentes.CurrentRow.Index);
                dgvPonentes.Rows.RemoveAt(dgvPonentes.CurrentRow.Index);
            }
        }
        
        private void txtNombre_Leave(object sender, EventArgs e)
        {
            
            if (txtNombre.Text == "")
                errorNombre.SetError(txtNombre,"El campo es obligatorio");


        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            errorNombre.Clear();
        }

        private void txtHoraInicio_Enter(object sender, EventArgs e)
        {
           
            errorInicio.Clear();
        }

        private void txtHora_Leave(object sender, EventArgs e)
        {
            if(dtpFin.Value.TimeOfDay <= dtpInicio.Value.TimeOfDay)
                errorFin.SetError(dtpFin,"La hora final debe ser mayor que la inicial");
            
           
        }
        private void txtHoraFin_Enter(object sender, EventArgs e)
        {
           
            errorFin.Clear();
            
        }

        private void txtHoraFin_Leave(object sender, EventArgs e)
        {
            
           if(dtpFin.Value<=dtpInicio.Value)
               errorFin.SetError(dtpFin,"La hora final debe ser mayor que la inicial");
           else errorInicio.Clear();


        }

        private void txtLugar_Enter(object sender, EventArgs e)
        {
            errorLugar.Clear();
        }

        private void txtLugar_Leave(object sender, EventArgs e)
        {
            if(txtLugar.Text=="")
                errorLugar.SetError(txtLugar,"El campo es obligatorio");
        }

     

      
        

      

        private void dtpInicio_Enter(object sender, EventArgs e)
        {
            errorInicio.Clear();
            
        }

        private void dtpInicio_Leave(object sender, EventArgs e)
        {
            if(dtpFin.Value <= dtpInicio.Value)
                errorInicio.SetError(dtpInicio,"La hora inicial debe ser menor que la inicial");
           else errorFin.Clear();

        }

        private void dtpFecha_Enter(object sender, EventArgs e)
        {
            errorFecha.Clear();
        }

        private void dtpFecha_Leave(object sender, EventArgs e)
        {
            if(dtpFechaEvento.Value< DateTime.Today)
                errorFecha.SetError(dtpFechaEvento,"No puede seleccionr un dia pasado");
        }

        private void txtDescripcion_Enter_1(object sender, EventArgs e)
        {
            errorDescripcion.Clear();
        }

        private void txtDescripcion_Leave(object sender, EventArgs e)
        {
            if(txtDescripcion.Text=="")
                errorDescripcion.SetError(txtDescripcion,"Debe llenar este campo");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            eventoDao.eliminarEvento(evento);
        }

        private void cboCategoria_EnabledChanged(object sender, EventArgs e)
        {
            
        }

        private void dtpInicio_LocationChanged(object sender, EventArgs e)
        {

        }

        private void dgvPonentes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
           
            
        }
    }
    
}
