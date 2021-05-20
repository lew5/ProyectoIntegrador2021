using ProyectoIntegrador2021.clases;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoIntegrador2021.ventanas
{
    public partial class frmAgregarProductoPedido : Form
    {
        private Bitmap add = Properties.Resources.icons8_plus_math_20px;
        private Bitmap remove = Properties.Resources.icons8_subtract_20px;
        public frmAgregarProductoPedido()
        {
            InitializeComponent();
            picboxAddFila2.Image = add;
            picboxAddFila3.Image = add;
            picboxAddFila4.Image = add;
            picboxRemoveFila4.Image = remove;
        }

        private void limpiar()
        {
            foreach (Control txtbox in panel2.Controls)
            {
                if (txtbox is Guna.UI.WinForms.GunaTextBox)
                {
                    txtbox.Text = "";
                }
            }
        }

        private void agregarFila(Guna.UI.WinForms.GunaTextBox t1, Guna.UI.WinForms.GunaTextBox t2, Guna.UI.WinForms.GunaTextBox t3, Guna.UI.WinForms.GunaTextBox t4, Guna.UI.WinForms.GunaTextBox t5)
        {
            t1.Enabled = true;
            t2.Enabled = true;
            t3.Enabled = true;
            t4.Enabled = true;
            t5.Enabled = true;

            t1.Visible = true;
            t2.Visible = true;
            t3.Visible = true;
            t4.Visible = true;
            t5.Visible = true;
        }

        private void removerFila(Guna.UI.WinForms.GunaTextBox t1, Guna.UI.WinForms.GunaTextBox t2, Guna.UI.WinForms.GunaTextBox t3, Guna.UI.WinForms.GunaTextBox t4, Guna.UI.WinForms.GunaTextBox t5)
        {
            t1.Enabled = false;
            t2.Enabled = false;
            t3.Enabled = false;
            t4.Enabled = false;
            t5.Enabled = false;

            t1.Visible = false;
            t2.Visible = false;
            t3.Visible = false;
            t4.Visible = false;
            t5.Visible = false;
        }

        private void guardarPedido()
        {
            Producto producto = Producto.Instance();
            producto.Campania = Convert.ToByte(txtboxCampania1.Text.Trim());
            producto.Codigo = txtboxCodigo1.Text.Trim();
            producto.Precio = double.Parse(txtboxPrecio1.Text.Trim());
            producto.Nombre = txtboxNombre1.Text.Trim();
            Pedido pedido = Pedido.Instance();
            pedido.Cantidad = Convert.ToByte(txtboxCantidad1.Text.Trim());
            pedido.Total = producto.Precio * pedido.Cantidad;
            pedido.ElProducto = producto;
            Cliente cliente = Cliente.Instance();
            cliente.agregarPedido(pedido);
            MessageBox.Show(cliente.Pedidos[0].Total.ToString());
        }

        private void SoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnLimpiar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            limpiar();
        }

        private void picboxAddFila2_Click(object sender, EventArgs e)
        {
            picboxAddFila2.Visible = false;
            picboxAddFila3.Visible = true;
            agregarFila(txtboxCampania2, txtboxCodigo2, txtboxPrecio2, txtboxCantidad2, txtboxNombre2);

        }

        private void picboxAddFila3_Click(object sender, EventArgs e)
        {
            picboxAddFila3.Visible = false;
            if (picboxAddFila3.Image == add)
            {
                picboxAddFila3.Image = remove;
                picboxAddFila4.Visible = true;
                agregarFila(txtboxCampania3, txtboxCodigo3, txtboxPrecio3, txtboxCantidad3, txtboxNombre3);
            }
            else
            {
                picboxAddFila3.Image = add;
                picboxAddFila2.Visible = true;
                removerFila(txtboxCampania2, txtboxCodigo2, txtboxPrecio2, txtboxCantidad2, txtboxNombre2);

            } 
        }

        private void picboxAddFila4_Click(object sender, EventArgs e)
        {
            picboxAddFila4.Visible = false;
            if (picboxAddFila4.Image == add)
            {
                picboxAddFila4.Image = remove;
                picboxRemoveFila4.Visible = true;
                agregarFila(txtboxCampania4, txtboxCodigo4, txtboxPrecio4, txtboxCantidad4, txtboxNombre4);
            }
            else
            {
                picboxAddFila4.Image = add;
                picboxAddFila3.Visible = true;
                removerFila(txtboxCampania3, txtboxCodigo3, txtboxPrecio3, txtboxCantidad3, txtboxNombre3);

            }
        }

        private void picboxRemoveFila4_Click(object sender, EventArgs e)
        {
            picboxRemoveFila4.Visible = false;
            picboxAddFila4.Visible = true;
            removerFila(txtboxCampania4, txtboxCodigo4, txtboxPrecio4, txtboxCantidad4, txtboxNombre4);            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
