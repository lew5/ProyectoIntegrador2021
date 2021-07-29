using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PIU2021.view
{
    public partial class UCNuevoPedido : UserControl
    {
        public UCNuevoPedido()
        {
            InitializeComponent();
        }

        public bool validarCampos()
        {
            return gtxtboxCodigoProducto.Text.Trim().Length == 7 && gtxtboxPrecio.Text.Trim() != "";
        }

        private void cambiarCliente(bool b)
        {
            if (b)
            {
                gcpbFotoPerfil.Visible = false;
                glblCambiarCliente.Visible = false;
                glblNombreCliente.Visible = false;
                gtxtboxClienteId.Visible = true;
            }
            else
            {
                gcpbFotoPerfil.Visible = true;
                glblCambiarCliente.Visible = true;
                glblNombreCliente.Visible = true;
                gtxtboxClienteId.Visible = false;
            }
        }

        private void glblCambiarCliente_Click(object sender, EventArgs e)
        {
            cambiarCliente(true);
        }

        private void gtxtboxClienteId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (gtxtboxClienteId.Text.Trim() != "")
                {
                    cambiarCliente(false);
                }

            }
            //if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            //{
            //    e.Handled = true;
            //    MessageBox.Show("enter");
            //}
        }

        private void gtxtCodigoProducto_LostFocus(object sender, EventArgs e)
        {
            if (gtxtboxCodigoProducto.Text.Length == 6 && !gtxtboxCodigoProducto.Text.Contains("-"))
            {
                gtxtboxCodigoProducto.Text = Regex.Replace(gtxtboxCodigoProducto.Text.Trim(), ".{3}", "$0-");
                gtxtboxCodigoProducto.Text = gtxtboxCodigoProducto.Text.Remove(gtxtboxCodigoProducto.Text.Length - 1, 1);
            }

        }
        private void gtxtboxCodigoProducto_Enter(object sender, EventArgs e)
        {
            if (gtxtboxCodigoProducto.Text.Length == 7)
            {
                gtxtboxCodigoProducto.Text = gtxtboxCodigoProducto.Text.Remove(3, 1);
            }
        }

        private void gtxtboxSoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void gtxtboxClienteId_Enter(object sender, EventArgs e)
        {
            if (gtxtboxClienteId.Text.Trim().Equals("ID DEL CLIENTE"))
            {
                gtxtboxClienteId.Text = "";
            }
        }

        private void gtxtboxClienteId_Leave(object sender, EventArgs e)
        {
            if (gtxtboxClienteId.Text.Trim() == "")
            {
                gtxtboxClienteId.Text = "ID DEL CLIENTE";
            }
        }
    }
}
