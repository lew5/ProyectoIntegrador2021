using System;
using System.Windows.Forms;

namespace PIU2021.view
{
    public partial class UCSeccionPrfilCliente : UserControl
    {
        private ucPerfilCliente perfilCliente;
        private UCEditarCliente editarCliente;
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

        private void gbtnNuevoPedido_Click(object sender, EventArgs e)
        {
            if (perfilCliente == null)
            {
                perfilCliente = new ucPerfilCliente();
                perfilCliente.Dock = DockStyle.Fill;
                this.pnlContenedor.Controls.Add(perfilCliente);
            }
            else
            {
                editarCliente.Visible = false;
                perfilCliente.Visible = true;
                perfilCliente.BringToFront();
            }
        }

        private void gbtnEditarCliente_Click(object sender, EventArgs e)
        {
            if (editarCliente == null)
            {
                editarCliente = new UCEditarCliente();
                editarCliente.Dock = DockStyle.Fill;
                this.pnlContenedor.Controls.Add(editarCliente);
            }
            else
            {
                perfilCliente.Visible = false;
                editarCliente.Visible = true;
                editarCliente.BringToFront();
            }
        }
    }
}
