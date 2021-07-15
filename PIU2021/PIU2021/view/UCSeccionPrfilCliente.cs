using System;
using System.Windows.Forms;

namespace PIU2021.view
{
    public partial class UCSeccionPrfilCliente : UserControl
    {
        public UCSeccionPrfilCliente()
        {
            InitializeComponent();
        }

        private void gbtnNuevoPedido_MouseEnter(object sender, EventArgs e)
        {
            glblToolTipNuevoPedido.Visible = true;
        }

        private void gbtnNuevoPedido_MouseLeave(object sender, EventArgs e)
        {
            glblToolTipNuevoPedido.Visible = false;
        }

        private void gbtnEditarCliente_MouseEnter(object sender, EventArgs e)
        {
            glblToolTipEditarCliente.Visible = true;
        }

        private void gbtnEditarCliente_MouseLeave(object sender, EventArgs e)
        {
            glblToolTipEditarCliente.Visible = false;
        }

        private void gbtnEliminarCliente_MouseEnter(object sender, EventArgs e)
        {
            glblToolTipEliminarCliente.Visible = true;
        }

        private void gbtnEliminarCliente_MouseLeave(object sender, EventArgs e)
        {
            glblToolTipEliminarCliente.Visible = false;
        }
    }
}
