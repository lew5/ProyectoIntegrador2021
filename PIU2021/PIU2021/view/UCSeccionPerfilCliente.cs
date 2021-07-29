using System;
using System.Windows.Forms;

namespace PIU2021.view
{
    public partial class UCSeccionPerfilCliente : UserControl
    {
        public UCSeccionPerfilCliente()
        {
            InitializeComponent();
        }

        private void UCSeccionPerfilCliente_Load(object sender, EventArgs e)
        {
            Main.MostrarUC<ucPerfilCliente>(pnlContenedor);// ucPerfilCliente debe recibir Cliente como parámetro
        }



        private void gcbtnAtras_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void gbtnEditarCliente_Click(object sender, EventArgs e)
        {
            esconderBotones(true);
            Main.MostrarUC<UCEditarCliente>(pnlContenedor);
            glblTitulo.Text = "Editar cliente";
        }

        private void gbtnGuardar_Click(object sender, EventArgs e)
        {
            esconderBotones(false);
            Main.MostrarUC<ucPerfilCliente>(pnlContenedor);
            glblTitulo.Text = "Perfil cliente";
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

        private void gbtnGuardar_MouseEnter(object sender, EventArgs e)
        {
            glblToolTipGuardarCambios.Visible = true;
        }

        private void gbtnGuardar_MouseLeave(object sender, EventArgs e)
        {
            glblToolTipGuardarCambios.Visible = false;
        }

        private void esconderBotones(bool t)
        {
            if (t)
            {
                gbtnNuevoPedido.Visible = false;
                gbtnEditarCliente.Visible = false;
                gbtnEliminarCliente.Visible = false;
                gbtnGuardar.Visible = true;
            }
            else
            {
                gbtnNuevoPedido.Visible = true;
                gbtnEditarCliente.Visible = true;
                gbtnEliminarCliente.Visible = true;
                gbtnGuardar.Visible = false;
            }

        }
    }
}
