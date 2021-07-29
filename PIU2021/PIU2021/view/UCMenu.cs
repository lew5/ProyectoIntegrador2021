using System;
using System.Windows.Forms;

namespace PIU2021
{
    public partial class UCMenu : UserControl
    {

        public event EventHandler InicioClick;
        public event EventHandler ClientesClick;
        public event EventHandler PedidosClick;
        public event EventHandler InfoClick;
        public event EventHandler AjustesClick;

        public UCMenu()
        {
            InitializeComponent();
        }

        private void gbtnInicio_Click(object sender, EventArgs e)
        {
            InicioClick?.Invoke(this, e);
        }

        private void gbtnClientes_Click(object sender, EventArgs e)
        {
            ClientesClick?.Invoke(this, e);
        }

        private void gbtnPedidos_Click(object sender, EventArgs e)
        {
            PedidosClick?.Invoke(this, e);
        }

        private void gbtnInfo_Click(object sender, EventArgs e)
        {
            InfoClick?.Invoke(this, e);
        }

        private void gbtnAjustes_Click(object sender, EventArgs e)
        {
            AjustesClick?.Invoke(this, e);
        }
    }
}
