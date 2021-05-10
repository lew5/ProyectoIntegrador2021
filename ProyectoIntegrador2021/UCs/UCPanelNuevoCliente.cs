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
    public partial class UCPanelNuevoCliente : UserControl
    {

        public delegate void Evento(object sender, EventArgs e);
        public event Evento Volver_Click;

        public UCPanelNuevoCliente()
        {
            InitializeComponent();
        }

        private void lblNuevoCliente_volver_Click(object sender, EventArgs e)
        {
            Volver_Click(sender,e);
        }
    }
}
