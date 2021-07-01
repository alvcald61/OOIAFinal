using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoOOIA.Ventanas.Asesor.Citas
{
    public partial class frmRegistrarHorario : Form
    {
        private GestionHumanaWS.miembroPUCP asesor;
        private GestionAtencionWS.GestionAtencionWSClient daoHorario;

        private Estado estado;

        private BindingList<GestionAtencionWS.horarioAsesor> horarios;

        private System.Windows.Forms.CheckBox[] botones;

        public frmRegistrarHorario(GestionHumanaWS.miembroPUCP asesor)
        {
            InitializeComponent();
            this.asesor = asesor;
            this.estado = Estado.Inicial;
            createButtons();
            cambiarEstado();
            

            daoHorario = new GestionAtencionWS.GestionAtencionWSClient();
            loadHorario();
        }

        public void cambiarEstado()
        {
            switch (this.estado)
            {
                case Estado.Inicial:
                    btnModificar.Text = "Modificar";
                    btnCancelar.Enabled = false;
                    foreach (CheckBox cb in botones) cb.Enabled = false;
                    break;
                case Estado.Modificar:
                    btnModificar.Text = "Guardar Cambios";
                    btnCancelar.Enabled = true;
                    foreach (CheckBox cb in botones)
                        if (cb.BackColor != System.Drawing.Color.DarkGray)
                            cb.Enabled = true;
                    break;
            }
        }

        public void createButtons()
        {
            this.botones = new System.Windows.Forms.CheckBox[90];
            for (int i = 0; i < 90; i++)
                botones[i] = new System.Windows.Forms.CheckBox();

            int xPos = 0;
            int yPos = 0;
            for (int i = 0; i < 90; i++)
            {
                botones[i].Tag = i + 1;
                botones[i].Appearance = Appearance.Button;
                //botones[i].FlatStyle = FlatStyle.Flat;
                //botones[i].FlatAppearance.BorderSize = 0;
                botones[i].CheckedChanged += eventoColor;

                botones[i].Margin = System.Windows.Forms.Padding.Empty;
                botones[i].Width = 94;
                botones[i].Height = 21;
                if (i % 5 == 0)
                {
                    xPos = 0;
                    yPos += 21;
                }
                botones[i].Left = xPos;
                botones[i].Top = yPos;

                tlpHorario.Controls.Add(botones[i]);
                xPos += botones[i].Width;
            }
        }

        private void eventoColor(object botones, EventArgs evento)
        {
            CheckBox boton = botones as CheckBox;
            if (boton.Checked == true)
            {
                if (boton.BackColor == System.Drawing.Color.White) boton.BackColor = System.Drawing.Color.DarkCyan;
            }else
            {
                if (boton.BackColor == System.Drawing.Color.DarkCyan) boton.BackColor = System.Drawing.Color.White;

            }
        }

        private void loadHorario()
        {
            try
            {
                horarios = new BindingList<GestionAtencionWS.horarioAsesor>(daoHorario.listarHorarioAsesor(asesor.id_miembro_pucp));
            }
            catch { return; }
            for (int i = 0; i < 90; i++)
            {
                if (horarios[i].estado == "disponible")
                    botones[i].BackColor = System.Drawing.Color.White;
                if (horarios[i].estado == "ocupado")
                    botones[i].BackColor = System.Drawing.Color.DarkCyan;
                if (horarios[i].estado == "No disponible")
                {
                    botones[i].BackColor = System.Drawing.Color.DarkGray;
                    botones[i].Enabled = false;
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.estado == Estado.Inicial)
            {
                this.estado = Estado.Modificar;
                cambiarEstado();
            }
            else if (this.estado == Estado.Modificar)
            {
                this.estado = Estado.Inicial;
                cambiarEstado();

                DialogResult dr =
              MessageBox.Show("¿Esta seguro que desea guardar los cambios a su horario?", "Cancelación de cambios",
              MessageBoxButtons.YesNo, MessageBoxIcon.None);
                if (dr == DialogResult.Yes)
                {
                    for (int i = 0; i < 90; i++)
                    {
                        if (botones[i].BackColor == System.Drawing.Color.White) horarios[i].estado = "disponible";
                        if (botones[i].BackColor == System.Drawing.Color.DarkCyan) horarios[i].estado = "ocupado";
                        daoHorario.modificarHorarioAsesor(horarios[i]);
                    }

                    //loadHorario();
                    MessageBox.Show("Actualización Exitosa", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult dr =
              MessageBox.Show("¿Esta seguro que desea cancelar los cambios a su horario?", "Cancelación de cambios",
              MessageBoxButtons.YesNo, MessageBoxIcon.None);
            if (dr == DialogResult.Yes)
            {
                loadHorario();
            }
        }
    }
}
