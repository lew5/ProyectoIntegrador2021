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
    public partial class UCPanelClientes : UserControl
    {
        public delegate void Evento(object sender, EventArgs e);
        public event Evento Nuevo_Click;
        public event Evento Perfil_Click;

        public UCPanelClientes()
        {
            InitializeComponent();
        }

        private void btnClientes_nuevo_Click(object sender, EventArgs e)
        {
            Nuevo_Click(sender,e);
        }

        private void picboxNextPage_Click(object sender, EventArgs e)
        {
            Perfil_Click(sender, e);
        }
    }
}
