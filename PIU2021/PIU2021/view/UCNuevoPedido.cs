using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIU2021.view
{
    public partial class UCNuevoPedido : UserControl
    {
        public UCNuevoPedido()
        {
            InitializeComponent();
        }

        private void cambiarCliente(bool b)
        {
            if (b)
            {
                gcpbFotoPerfil.Visible = false;
                glblCambiarCliente.Visible = false;
                glblNombreCliente.Visible = false;
                gtxtBoxClienteId.Visible = true;
            }
            else
            {
                gcpbFotoPerfil.Visible = true;
                glblCambiarCliente.Visible = true;
                glblNombreCliente.Visible = true;
                gtxtBoxClienteId.Visible = false;
            }
        }

        private void glblCambiarCliente_Click(object sender, EventArgs e)
        {
            cambiarCliente(true);
        }

        private void gtxtBoxClienteId_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == (char)Keys.Enter)
            //{
            //    if (gtxtBoxClienteId.Text.Trim() != "")
            //    {
            //        cambiarCliente(false);
            //    }

            //}
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("enter");
            }
        }

        private void gtxtCodigoProducto_LostFocus(object sender, EventArgs e)
        {
            //RegexOptions options = RegexOptions.None;
            //Regex regex = new Regex(@"[ ]{2,}", options);
            gtxtboxCodigoProducto.Text = Regex.Replace(gtxtboxCodigoProducto.Text.Trim(), ".{3}", "$0-");
            gtxtboxCodigoProducto.Text = gtxtboxCodigoProducto.Text.Remove(gtxtboxCodigoProducto.Text.Length -1,1);

        }

        private void gtxtboxSoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
