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
    public partial class UCPanelPerfilCliente : UserControl
    {

        public delegate void Evento(object sender, EventArgs e);
        public event Evento Volver_Click;

        public UCPanelPerfilCliente()
        {
            InitializeComponent();
        }
        
        private void lbl_Volver_MouseEnter(object sender, EventArgs e)
        {
            lbl_Volver.ForeColor = Color.FromArgb(254, 49, 108);
        }

        private void lbl_Volver_MouseLeave(object sender, EventArgs e)
        {
            lbl_Volver.ForeColor = Color.Silver;
        }

        private void lbl_Volver_Click(object sender, EventArgs e)
        {
            Volver_Click(sender, e);
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            lblNombreUsuario.Focus();
            pnlPerfilCliente.BringToFront();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            lblNombreUsuario.Focus();
            pnlPedidosCliente.BringToFront();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            lblNombreUsuario.Focus();
            pnlEditarCliente.BringToFront();
        }
    }
}
