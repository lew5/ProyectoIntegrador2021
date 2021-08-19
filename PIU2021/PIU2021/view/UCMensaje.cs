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

    public partial class UCMensaje : UserControl
    {
        private Image iconoError = PIU2021.Properties.Resources.iconError;
        private Color colorError = Color.FromArgb(240, 122, 119);
        private Image iconoExito = PIU2021.Properties.Resources.iconExito2;
        private Color colorExito = Color.FromArgb(75, 211, 101);
        public UCMensaje(string texto, bool tipo)
        {
            InitializeComponent();
            this.glblTexto.Text = texto;
            // true éxito - false error 
            if (tipo)
            {
                this.picIcono.Image = iconoExito;
                this.glpnlFondo.LineColor = colorExito;
            }
            else
            {
                this.picIcono.Image = iconoError;
                this.glpnlFondo.LineColor = colorError;
            }
        }

        private void picCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void UCMensaje_Load(object sender, EventArgs e)
        {
            Location = new Point((Parent.Width - Width) - 20, (Parent.Height - Height) - 20);
            timerCerrar.Enabled = true;
            timerCerrar.Start();
        }

        private void timerCerrar_Tick(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
