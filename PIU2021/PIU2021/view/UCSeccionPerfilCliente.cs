using System;
using System.Windows.Forms;

namespace PIU2021.view
{
    public partial class UCSeccionPerfilCliente : UserControl
    {
        private ucPerfilCliente perfilCliente;
        private UCEditarCliente editarCliente;
        public UCSeccionPerfilCliente()
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
            Main.MostrarUC<ucPerfilCliente>(pnlContenedor);
            glblTitulo.Text = "Perfil cliente";
        }

        private void gbtnEditarCliente_Click(object sender, EventArgs e)
        {
            Main.MostrarUC<UCEditarCliente>(pnlContenedor);
            glblTitulo.Text = "Editar cliente";
        }

        private void gcbtnAtras_Click(object sender, EventArgs e)
        {
            this.Dispose()
;        }

        private void UCSeccionPerfilCliente_Load(object sender, EventArgs e)
        {
            Main.MostrarUC<ucPerfilCliente>(pnlContenedor);// ucPerfilCliente debe recibir Cliente como parámetro
        }
    }
}
