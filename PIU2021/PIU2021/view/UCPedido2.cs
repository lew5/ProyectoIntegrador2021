using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIU2021.view
{
    public partial class UCPedido2 : UserControl
    {
        private Color bColor = Color.FromArgb(89, 173, 255);
        public UCPedido2()
        {
            InitializeComponent();
        }

        private void gtpbEvento_MouseEnter(object sender, EventArgs e)
        {
            gepnlBordeColor.BaseColor = Color.FromArgb(248, 48, 104);
        }

        private void gtpbEvento_MouseLeave(object sender, EventArgs e)
        {
            gepnlBordeColor.BaseColor = bColor;
        }

        private void gtpbEvento_Click(object sender, EventArgs e)
        {
            Main.MostrarUC<UCSeccionDetallePedido>(this.Parent.Parent.Parent);
        }
    }
}
