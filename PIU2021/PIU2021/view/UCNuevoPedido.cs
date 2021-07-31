using System;
using System.Globalization;
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
            return gtxtboxCodigoProducto.Text.Trim().Length == 7 && gtxtboxPrecio.Text.Trim() != "" && gtxtboxClienteId.Text.Length <= 4;
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
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
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
            else
            {
                cambiarCliente(false);
            }
        }

        private void gtxtboxCantidad_Leave(object sender, EventArgs e)
        {
            if (gtxtboxCantidad.Text.Trim().Equals("") || gtxtboxCantidad.Text.Trim().Equals("0"))
            {
                gtxtboxCantidad.Text = "1";
            }
        }

        private void gtxtboxPrecio_Leave(object sender, EventArgs e)
        {
            if (gtxtboxPrecio.Text.Trim().Length <= 6 && gtxtboxPrecio.Text.Trim().Length != 0)
            {
                gtxtboxPrecio.Text = string.Format(CultureInfo.CreateSpecificCulture("es-UY"), "{0:c}", double.Parse(gtxtboxPrecio.Text));
                gtxtboxPrecio.Text = gtxtboxPrecio.Text.Trim().Replace("$U", "");
            }
            
        }

        private void gtxtboxPrecio_Enter(object sender, EventArgs e)
        {
            gtxtboxPrecio.Text = gtxtboxPrecio.Text.Trim().Replace(",00", "").Replace("$U", "").Replace(",","").Replace(".","");
        }

        private void gtxtboxDescripcion_Enter(object sender, EventArgs e)
        {
            if (gtxtboxDescripcion.Text.Trim().Equals("Sin descripción"))
            {
                gtxtboxDescripcion.Text = "";
            }
        }

        private void gtxtboxDescripcion_Leave(object sender, EventArgs e)
        {
            if (gtxtboxDescripcion.Text.Trim() == "")
            {
                gtxtboxDescripcion.Text = "Sin descripción";
            }
        }
    }
}
