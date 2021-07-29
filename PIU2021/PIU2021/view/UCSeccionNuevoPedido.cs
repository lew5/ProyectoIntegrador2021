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
    public partial class UCSeccionNuevoPedido : UserControl
    {
        public UCSeccionNuevoPedido()
        {
            InitializeComponent();
        }

        private void gcbtnAtras_Click(object sender, EventArgs e)
        {
            Main.MostrarUC<UCSeccionPedidos>(this.Parent);
        }

        private void gbtnGuardar_Click(object sender, EventArgs e)
        {
            if (ucNuevoPedido.validarCampos())
            {
                MessageBox.Show(ucNuevoPedido.validarCampos().ToString());
            }
            else
            {
                MessageBox.Show(ucNuevoPedido.validarCampos().ToString());
            }
        }
    }
}
