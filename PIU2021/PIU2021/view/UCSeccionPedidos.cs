using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PIU2021.view
{
    public partial class UCSeccionPedidos : UserControl
    {
        private Guna.UI.Lib.ScrollBar.PanelScrollHelper vScroll;

        public static List<Color> lColores = new List<Color>();
        public static int pedidos = 0;
        public UCSeccionPedidos()
        {
            InitializeComponent();

            lColores.Add(Color.FromArgb(252, 72, 80));
            lColores.Add(Color.FromArgb(248, 200, 34));
            lColores.Add(Color.FromArgb(144, 196, 24));
            lColores.Add(Color.FromArgb(89, 173, 255));
            lColores.Add(Color.FromArgb(176, 50, 231));

            lColores = lColores.OrderBy(x => Guid.NewGuid()).ToList();
        }

        private void UCSeccionPedidos_Load(object sender, EventArgs e)
        {
            vScroll = new Guna.UI.Lib.ScrollBar.PanelScrollHelper(flowpnlPedidos, gVScrollBar, true);
            flowpnlPedidos.HorizontalScroll.Visible = false;

            for (int i = 0; i < 20; i++)
            {
                UCPedido2 uCPedido2 = new UCPedido2();
                uCPedido2.Dock = DockStyle.Top;
                this.flowpnlPedidos.Controls.Add(uCPedido2);
            }
        }

        private void gbtnNuevoPedido_Click(object sender, EventArgs e)
        {
            Main.MostrarUC<UCSeccionNuevoPedido>(this.Parent);
        }

        private void gbtnOrdenarAntiguos_Click(object sender, EventArgs e)
        {
            UCPedido2 uCPedido2 = new UCPedido2();
            uCPedido2.Dock = DockStyle.Top;
            this.flowpnlPedidos.Controls.Add(uCPedido2);
        }

        private void flowpnlPedidos_ControlAdded(object sender, ControlEventArgs e)
        {
            pedidos++;
            if (pedidos > 4)
            {
                pedidos = 0;
            }
        }
    }
}
