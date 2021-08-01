using System;
using System.Drawing;
using System.Windows.Forms;

namespace PIU2021.view
{
    public partial class UCPedido2 : UserControl
    {
        private Color bColor = Color.FromArgb(89, 173, 255);
        private Color hColor = Color.FromArgb(248, 48, 104);
        private string nombreCliente = "NOMBRE CLIENTE";
        private DateTime fechaPedido = DateTime.Now;
        private string cantProductos = "Productos";
        private string precioTotal = "00.00";

        public UCPedido2()
        {
            InitializeComponent();
        }

        private void gtpbEvento_MouseEnter(object sender, EventArgs e)
        {
            gepnlBordeColor.BaseColor = HColor;
            gtpbEvento.BaseDepth = 70;
        }

        private void gtpbEvento_MouseLeave(object sender, EventArgs e)
        {
            gepnlBordeColor.BaseColor = BColor;
            gtpbEvento.BaseDepth = 0;
        }

        private void gtpbEvento_Click(object sender, EventArgs e)
        {
            Main.MostrarUC<UCSeccionDetallePedido>(this.Parent.Parent.Parent);
        }

        private void UCPedido2_Load(object sender, EventArgs e)
        {
            BColor = UCSeccionPedidos.lColores[UCSeccionPedidos.pedidos];
        }


        public Color BColor
        {
            get => bColor;
            set
            {
                bColor = value;
                gepnlBordeColor.BaseColor = bColor;
            }
        }
        public Color HColor { get => hColor; set => hColor = value; }
        public string NombreCliente
        {
            get => nombreCliente;
            set
            {
                nombreCliente = value;
                glblNombreCliente.Text = nombreCliente;
            }
        }
        public DateTime FechaPedido
        {
            get => fechaPedido;
            set
            {
                fechaPedido = value;
                glblFecha.Text = fechaPedido.ToString("MMMM dd, yyy");
                glblFecha.Text = glblFecha.Text.Replace(glblFecha.Text.Substring(0, 1), glblFecha.Text.Substring(0, 1).ToUpper());

            }
        }
        public string CantProductos
        {
            get => cantProductos;
            set
            {
                cantProductos = value;
                glblCantProductos.Text = "Productos x" + cantProductos.ToString();
            }
        }
        public string PrecioTotal
        {
            get => precioTotal;
            set
            {
                precioTotal = value;
                glblTotal.Text = precioTotal;
            }
        }
    }
}
