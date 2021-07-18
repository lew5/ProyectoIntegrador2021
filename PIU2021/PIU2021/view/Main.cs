using PIU2021.view;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PIU2021
{
    public partial class Main : Form
    {

        public static void MostrarUC<UC>(Panel p) where UC : UserControl, new()
        {
            UserControl uc;
            uc = p.Controls.OfType<UC>().FirstOrDefault();
            if (uc == null)
            {
                uc = new UC();
                p.Controls.Add(uc);
                uc.Dock = DockStyle.Fill;
                uc.BringToFront();
                foreach (Control c in p.Controls)
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
        public Main()
        {
            InitializeComponent();
        }

        private void ucMenu_ClientesClick(object sender, EventArgs e)
        {
            MostrarUC<UCSeccionPerfilCliente>(pnlContenedor);
        }

        private void ucMenu_PedidosoClick(object sender, EventArgs e)
        {
            MostrarUC<UCSeccionPedidos>(pnlContenedor);
        }
    }
}
