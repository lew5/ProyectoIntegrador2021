using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegrador2021.UCs
{
    public partial class UCItemPedidoCliente : UserControl
    {
        public UCItemPedidoCliente()
        {
            InitializeComponent();
        }

        private void lnlPnl_info_MouseEnter(object sender, EventArgs e)
        {
            gunaShadowPanel1.ShadowColor = Color.FromArgb(255, 234, 240);
        }

        private void lnlPnl_info_MouseLeave(object sender, EventArgs e)
        {
            gunaShadowPanel1.ShadowColor = Color.Transparent;          
        }
    }
}
