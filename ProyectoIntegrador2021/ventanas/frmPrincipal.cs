using ProyectoIntegrador2021.UCs;
using System.Linq;
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
            mostrarSeccion<UCPanelInicio>();
        }

        private void ucMenu1_Clientes_Click(object sender, System.EventArgs e)
        {
            mostrarSeccion<UCPanelClientes>();
        }



        //

        private void mostrarSeccion<Seccion>() where Seccion : UserControl, new()
        {
            UserControl uc;
            uc = pnlContenedor.Controls.OfType<Seccion>().FirstOrDefault();
            if (uc == null)
            {
                uc = new Seccion();
                pnlContenedor.Controls.Add(uc);
                uc.Dock = DockStyle.Fill;
                uc.BringToFront();
                foreach (Control c in pnlContenedor.Controls)
                    if (uc.Name != c.Name)
                    {
                        c.Dispose();
                    }
            }
            else
            {
                uc.BringToFront();
            }
        }
    }
}

