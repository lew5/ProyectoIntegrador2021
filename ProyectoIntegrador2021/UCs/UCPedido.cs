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
    public partial class UCPedido : UserControl
    {
        Guna.UI.Lib.ScrollBar.PanelScrollHelper vsh;
        public UCPedido()
        {
            InitializeComponent();

        }

        private void UCPedido_Load(object sender, EventArgs e)
        {
            vsh = new Guna.UI.Lib.ScrollBar.PanelScrollHelper(panel1,gunaVScrollBar1,true);
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            UserControl uc = new UCItemPedido("223-232", "Producto anashe", 23, 2);
            uc.Dock = DockStyle.Top;
            panel1.Controls.Add(uc);
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
