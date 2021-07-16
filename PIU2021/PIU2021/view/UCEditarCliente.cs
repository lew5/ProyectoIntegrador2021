using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PIU2021.view
{
    public partial class UCEditarCliente : UserControl
    {
        private OpenFileDialog openFileDialog;
        private Image imagen;
        private Bitmap bmap;
        public UCEditarCliente()
        {
            InitializeComponent();
        }


        private void gtpbCambiarFoto_Click(object sender, EventArgs e)
        {
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            openFileDialog.InitialDirectory = "C:\\";
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            DialogResult dr = openFileDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                imagen = Image.FromFile(openFileDialog.FileName);
                bmap = (Bitmap)imagen;
                gcpbFotoDePerfil.Image = bmap;
            }
        }


        private void gtpbCambiarFoto_MouseEnter(object sender, EventArgs e)
        {
            gtpbCambiarFoto.Visible = true;
        }

        private void gtpbCambiarFoto_MouseLeave(object sender, EventArgs e)
        {
            gtpbCambiarFoto.Visible = false;
        }

        private void gtxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void gtxtTelefono_LostFocus(object sender, EventArgs e)
        {
            if (gtxtTelefono.Text.Trim().Length == 9 && gtxtTelefono.Text.Trim().Length != 0)
            {
                gtxtTelefono.Text = gtxtTelefono.Text.Insert(0, "(");
                gtxtTelefono.Text = gtxtTelefono.Text.Insert(4, ")");
                gtxtTelefono.Text = gtxtTelefono.Text.Insert(5, " ");
                gtxtTelefono.Text = gtxtTelefono.Text.Insert(9, " ");
            }
        }
        private void gtxtTelefono_GotFocus(object sender, EventArgs e)
        {
            if (gtxtTelefono.Text.Trim().Length != 0)
            {
                gtxtTelefono.Text = gtxtTelefono.Text.Remove(0, 1);
                gtxtTelefono.Text = gtxtTelefono.Text.Remove(3, 1);
                gtxtTelefono.Text = gtxtTelefono.Text.Remove(3, 1);
                gtxtTelefono.Text = gtxtTelefono.Text.Remove(6, 1);
            }
        }

        private void gtxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (gtxtNombre.Text.Trim().Length == 0)
            {
                e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == 'ñ');
            }
            else
            {
                e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space || e.KeyChar == 'ñ');
            }
            
        }      

        private void gtxtNombre_LostFocus(object sender, EventArgs e)
        {
            RegexOptions options = RegexOptions.None;
            Regex regex = new Regex(@"[ ]{2,}", options);
            gtxtNombre.Text = regex.Replace(gtxtNombre.Text.Trim(), @" ");           
        }

        private void gtxtDireccion_LostFocus(object sender, EventArgs e)
        {
            RegexOptions options = RegexOptions.None;
            Regex regex = new Regex(@"[ ]{2,}", options);
            gtxtDireccion.Text = regex.Replace(gtxtDireccion.Text.Trim(), @" ");
        }
    }
}
