using ProyectoIntegrador2021.UCs;
using System.Windows.Forms;

namespace ProyectoIntegrador2021.ventanas
{
    public partial class frmPrincipal : Form
    {

        public frmPrincipal()
        {
            InitializeComponent();
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
        }

        private void ucMenu1_Inicio_Click(object sender, System.EventArgs e)
        {
            ucPanelClientes1.Hide();
            ucPanelInicio1.Show();
        }

        private void ucMenu1_Clientes_Click(object sender, System.EventArgs e)
        {
            ucPanelInicio1.Hide();
            ucPanelClientes1.Show();       
        }
    }
}

