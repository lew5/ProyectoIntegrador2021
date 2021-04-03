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
    public partial class UCItemCliente : UserControl
    {
        public UCItemCliente()
        {
            InitializeComponent();
        }

        private void lblId_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(252,228,236);
        }

        private void lblId_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }
    }
}
