using System;
using System.Drawing;
using System.Windows.Forms;

namespace PIU2021.view
{
    public partial class UCPedido : UserControl
    {

        private Color cabeceraColor = Color.FromArgb(64, 64, 64);
        private Color cabeceraHoverColor = Color.FromArgb(248, 48, 104);
        public UCPedido()
        {
            InitializeComponent();
        }

        private void UCPedido_Load(object sender, EventArgs e)
        {
        }

        private void gtpbVerDetalles_MouseEnter(object sender, EventArgs e)
        {
            gepnlCabecera.BaseColor = cabeceraHoverColor;
            pnlCabecera.BackColor = cabeceraHoverColor;
            gtpbVerDetalles.Refresh();
            gtpbVerDetalles.BaseDepth = 127;
        }

        private void gtpbVerDetalles_MouseLeave(object sender, EventArgs e)
        {
            gepnlCabecera.BaseColor = cabeceraColor;
            pnlCabecera.BackColor = cabeceraColor;
            gtpbVerDetalles.Refresh();
            gtpbVerDetalles.BaseDepth = 0;
        }
    }
}
