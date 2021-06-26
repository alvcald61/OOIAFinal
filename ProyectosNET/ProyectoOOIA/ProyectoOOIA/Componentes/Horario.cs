using System.ComponentModel;
using System.Windows.Forms;

namespace ProyectoOOIA.Componentes
{
    public partial class Horario : UserControl
    {
        BindingList<CheckBox> lista = new BindingList<CheckBox>();
        public Horario()
        {
            InitializeComponent();
            

        }
        

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
