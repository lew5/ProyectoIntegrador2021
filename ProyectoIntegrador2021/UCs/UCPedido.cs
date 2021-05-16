using PruebasDB.clases;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoIntegrador2021.UCs
{
    public partial class UCPedido : UserControl
    {
        Guna.UI.Lib.ScrollBar.PanelScrollHelper vsh;
        public UCPedido()
        {
            InitializeComponent();

        }

        private void UCPedido_Load(object sender, EventArgs e)
        {
            vsh = new Guna.UI.Lib.ScrollBar.PanelScrollHelper(panel1, gunaVScrollBar1, true);
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            Pedido pedido = Pedido.Instance();
            
            for (int i = 0; i < 10; i++)
            {
                pedido.Cantidad = Convert.ToByte(i);
                UserControl uc = new UCItemPedido(pedido.Codigo, "Producto anashe", 20, pedido.Cantidad);
                uc.Dock = DockStyle.Top;
                panel1.Controls.Add(uc);
            }

        }

        private void lblEstado_Click(object sender, EventArgs e)
        {
            if (lblEstado.Text.Equals("DEBE"))
            {
                lblEstado.Text = "PAGO";
                lblEstado.ForeColor = Color.Green;
            }
            else
            {
                lblEstado.Text = "DEBE";
                lblEstado.ForeColor = Color.Red;
            }
        }
    }
}
