using ProyectoIntegrador2021.ventanas;
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
    public partial class UCMenu : UserControl
    {
        public delegate void Evento (object sender, EventArgs e);
        public event Evento Inicio_Click;
        public event Evento Clientes_Click;
        public event Evento Pedidos_Click;
        public event Evento Usuarios_Click;
        public event Evento Ajustes_Click;
        public event Evento About_Click;
        public UCMenu()
        {
            InitializeComponent();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Inicio_Click(sender,e);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Clientes_Click(sender, e);
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            Pedidos_Click(sender, e);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Usuarios_Click(sender, e);
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            About_Click(sender, e);
        }

        private void btnAjustes_Click(object sender, EventArgs e)
        {
            Ajustes_Click(sender, e);
        }
    }
}
