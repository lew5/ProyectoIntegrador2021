using System;
using System.Windows.Forms;

namespace PIU2021.view
{
    public partial class UCSeccionPedidos : UserControl
    {
        Guna.UI.Lib.ScrollBar.PanelScrollHelper vScroll;
        public UCSeccionPedidos()
        {
            InitializeComponent();
        }

        private void UCSeccionPedidos_Load(object sender, EventArgs e)
        {
            vScroll = new Guna.UI.Lib.ScrollBar.PanelScrollHelper(flowpnlPedidos, gVScrollBar, true);
            flowpnlPedidos.HorizontalScroll.Visible = false;
        }
    }
}
