using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoOOIA.Ventanas.Miembro_OOIA.Cargar_Datos
{
    public partial class frmGestionarProfesor : Form
    {
        private EspecialidadWS.EspecialidadWSClient daoEspecialidad;
        private ProfesorWS.ProfesorWSClient daoProfesor;
        private ProfesorWS.profesor profesor;
        private byte[] imagen_perfil;
        private Estado estado;

        public frmGestionarProfesor()
        {
            InitializeComponent();
            estado = Estado.Inicial;
            clearall();
            cambiarEstado();
            daoEspecialidad = new EspecialidadWS.EspecialidadWSClient();
            daoProfesor = new ProfesorWS.ProfesorWSClient();
            cbEspecialidad.DataSource = new BindingList<EspecialidadWS.especialidad>
                (daoEspecialidad.listarEspecialidad().ToList());
            cbEspecialidad.DisplayMember = "nombre";
            cbEspecialidad.ValueMember = "id_especialidad";
        }

        public void clearall()
        {
            /*Persona*/

            txtDni.Text = "";
            txtNombre.Text = "";
            dtpFechaNacimiento.Value = DateTime.Today;
            txtDireccion.Text = "";
            txtCorreo.Text = "";
            /*Miembro PUCP*/
            txtUsuario.Text = "";
            txtPassword.Text = "";
            /*Profesor*/
            cbEspecialidad.SelectedIndex = -1;
            txtFacultad.Text = "";
            txtCategoria.Text = "";
            /*Imagen*/
            Image img = Properties.Resources.placeholder_profile;
            imagen_perfil = ImageToByte2(img);
            displayImage(imagen_perfil);
        }

        public static byte[] ImageToByte2(Image img)
        {
            using (var stream = new MemoryStream())
            {
                img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                return stream.ToArray();
            }
        }

        public void cambiarEstado()
        {
            switch (estado)
            {
                case Estado.Inicial:
                    //Botones
                    tsbNuevo.Enabled = true;
                    tsbGuardar.Enabled = false;
                    tsbModificar.Enabled = false;
                    tsbBuscar.Enabled = true;
                    tsbEliminar.Enabled = false;
                    tsbCancelar.Enabled = true;
                    btnImagen1.Enabled = false;
                    btnImagen2.Enabled = false;
                    //Texto
                    /*Persona*/
                    txtDni.Enabled = false;
                    txtNombre.Enabled = false;
                    dtpFechaNacimiento.Enabled = false;
                    txtDireccion.Enabled = false;
                    txtCorreo.Enabled = false;
                    /*Miembro PUCP*/
                    txtUsuario.Enabled = false;
                    txtPassword.Enabled = false;
                    /*Profesor*/
                    txtFacultad.Enabled = false;
                    txtCategoria.Enabled = false;
                    cbEspecialidad.Enabled = false;
                    break;
                case Estado.Nuevo:
                case Estado.Modificar:
                    //Botones
                    tsbNuevo.Enabled = false;
                    tsbGuardar.Enabled = true;
                    tsbModificar.Enabled = false;
                    tsbBuscar.Enabled = false;
                    tsbEliminar.Enabled = false;
                    tsbCancelar.Enabled = true;
                    btnImagen1.Enabled = false;
                    btnImagen2.Enabled = true;
                    //Texto
                    /*Persona*/
                    txtDni.Enabled = true;
                    txtNombre.Enabled = true;
                    dtpFechaNacimiento.Enabled = true;
                    txtDireccion.Enabled = true;
                    txtCorreo.Enabled = true;
                    /*Miembro PUCP*/
                    txtUsuario.Enabled = true;
                    txtPassword.Enabled = true;
                    /*Profesor*/
                    txtFacultad.Enabled = true;
                    txtCategoria.Enabled = true;
                    cbEspecialidad.Enabled = true;
                    break;
                case Estado.Busqueda:
                    //Botones
                    tsbNuevo.Enabled = false;
                    tsbGuardar.Enabled = false;
                    tsbModificar.Enabled = true;
                    tsbBuscar.Enabled = false;
                    tsbEliminar.Enabled = true;
                    tsbCancelar.Enabled = true;
                    btnImagen1.Enabled = false;
                    btnImagen2.Enabled = false;
                    //Texto
                    /*Persona*/
                    txtDni.Enabled = false;
                    txtNombre.Enabled = false;
                    dtpFechaNacimiento.Enabled = false;
                    txtDireccion.Enabled = false;
                    txtCorreo.Enabled = false;
                    /*Miembro PUCP*/
                    txtUsuario.Enabled = false;
                    txtPassword.Enabled = false;
                    /*Profesor*/
                    txtFacultad.Enabled = false;
                    txtCategoria.Enabled = false;
                    cbEspecialidad.Enabled = false;
                    break;
            }
        }

        public void displayImage(byte[] image)
        {
            MemoryStream ms = new MemoryStream(image);
            pbPerfil1.Image = Image.FromStream(ms);
            pbPerfil2.Image = Image.FromStream(ms);
        }

        /*Botones de Header*/
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*Botones de Toolstrip*/

        public void fillText(ProfesorWS.profesor profe)
        {
            //Persona
            txtDni.Text = profe.dni;
            txtNombre.Text = profe.nombre;
            dtpFechaNacimiento.Value = profe.fecha_nacimiento;
            txtDireccion.Text = profe.direccion;
            txtCorreo.Text = profe.correo;
            //Miembro PUCP
            txtUsuario.Text = profe.usuario;
            txtPassword.Text = "*********";;
            imagen_perfil = profe.imagenDePerfil;
            if (imagen_perfil != null) displayImage(imagen_perfil);
            //Alumno
            txtFacultad.Text = profe.facultad;
            txtCategoria.Text = profe.categoria;
            cbEspecialidad.SelectedValue = profe.especialidad.id_especialidad;
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            this.profesor = new ProfesorWS.profesor();
            estado = Estado.Nuevo;
            cambiarEstado();
            clearall();
            txtPassword.Text = "12345";
        }

        private void tsbGuardar_Click_1(object sender, EventArgs e)
        {
            //Validación Persona
            if (txtDni.Text == "")
            {
                MessageBox.Show("No ha ingresado el DNI", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtNombre.Text == "")
            {
                MessageBox.Show("No ha ingresado el nombre", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dtpFechaNacimiento.Value == DateTime.Today)
            {
                MessageBox.Show("No ha ingresado correctamente la fecha de nacimiento", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtDireccion.Text == "")
            {
                MessageBox.Show("No ha ingresado la dirección", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtCorreo.Text == "")
            {
                MessageBox.Show("No ha ingresado el correo", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Validación Miembro PUCP
            if (txtUsuario.Text == "")
            {
                MessageBox.Show("No ha ingresado el usuario", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtPassword.Text == "")
            {
                MessageBox.Show("No ha ingresado la contraseña", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Validación Profesor
            if (cbEspecialidad.SelectedIndex == -1)
            {
                MessageBox.Show("No ha seleccionado la especialidad", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtFacultad.Text == "")
            {
                MessageBox.Show("No ha ingresado la facultad", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtCategoria.Text == "")
            {
                MessageBox.Show("No ha ingresado la categoría", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            //Persona
            profesor.dni = txtDni.Text;
            profesor.nombre = txtNombre.Text;
            profesor.fecha_nacimiento = dtpFechaNacimiento.Value;
            profesor.fecha_nacimientoSpecified = true;
            profesor.direccion = txtDireccion.Text;
            profesor.correo = txtCorreo.Text;
            //Miembro PUCP
            profesor.usuario = txtUsuario.Text;
            profesor.password = txtPassword.Text;
            profesor.imagenDePerfil = imagen_perfil;
            profesor.fecha_inclusion = DateTime.Today.Date;
            profesor.fecha_inclusionSpecified = true;
            //Alumno
            profesor.facultad = txtFacultad.Text;
            profesor.categoria = txtCategoria.Text;
            EspecialidadWS.especialidad esp_selected = (EspecialidadWS.especialidad)cbEspecialidad.SelectedItem;
            profesor.especialidad = new ProfesorWS.especialidad();
            profesor.especialidad.id_especialidad = esp_selected.id_especialidad;
            profesor.especialidad.nombre = esp_selected.nombre;

            if (estado.Equals(Estado.Nuevo))
            {
                int resultado = daoProfesor.insertarProfesor(this.profesor);
                if (resultado != 0)
                {
                    MessageBox.Show("Se ha registrado con exito", "Mensaje Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.estado = Estado.Inicial;
                    cambiarEstado();
                }
                else MessageBox.Show("Ha ocurrido un error en la inserción", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (estado == Estado.Modificar)
            {
                int resultado = daoProfesor.modificarProfesor(profesor);
                if (resultado != 0)
                {
                    MessageBox.Show("Se ha actualizado con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.estado = Estado.Inicial;
                    cambiarEstado();
                }
                else
                    MessageBox.Show("Ha ocurrido un error", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void tsbModificar_Click(object sender, EventArgs e)
        {
            this.estado = Estado.Modificar;
            cambiarEstado();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Esta seguro que desea eliminar este profesor?", "Mensaje de Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                int resultado = daoProfesor.eliminarProfesor(profesor.id_profesor);
                if (resultado != 0)
                {
                    MessageBox.Show("Se ha eliminado con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.estado = Estado.Inicial;
                    cambiarEstado();
                }
                else MessageBox.Show("Ha ocurrido un error", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarProfesor frmBuscar = new frmBuscarProfesor();
            if (frmBuscar.ShowDialog() == DialogResult.OK)
            {
                this.profesor = frmBuscar.Profesor;
                fillText(this.profesor);
                estado = Estado.Busqueda;
                cambiarEstado();
            }
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            this.estado = Estado.Inicial;
            clearall();
            cambiarEstado();
        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            if (ofd_Imagen.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(ofd_Imagen.FileName, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                //Asignamos el archivo al objeto
                imagen_perfil = br.ReadBytes((int)fs.Length);
                br.Close();
                fs.Close();
                displayImage(imagen_perfil);
            }

        }

    }
}
