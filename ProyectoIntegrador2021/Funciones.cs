using System;
using System.Drawing;

namespace ProyectoIntegrador2021
{
    public static class Funciones
    {
        //PLACEHOLDER
        public static void placeHolderEnter(Guna.UI.WinForms.GunaTextBox txtbox, String txt)
        {
            if (txtbox.Text.Trim() == txt)
            {
                txtbox.Clear();
                txtbox.Font = new Font("Segoe UI", 12F,FontStyle.Bold);
                txtbox.ForeColor = Color.FromArgb(64,64,64);
                txtbox.BaseColor = Color.White;
            }
        }
        public static void placeHolderLeave(Guna.UI.WinForms.GunaTextBox txtbox, String txt)
        {
            if (txtbox.Text.Trim() == "")
            {
                txtbox.Text = "   " + txt;
                txtbox.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                txtbox.ForeColor = Color.DarkGray;
                txtbox.BaseColor = Color.FromArgb(224, 224, 224);
            }
        }
        //PLACEHOLDER CONTRASEÑA
        public static void placeHolderPassEnter(Guna.UI.WinForms.GunaTextBox txtbox, String txt, System.Windows.Forms.PictureBox pic)
        {
            if (txtbox.Text.Trim() == txt)
            {              
                txtbox.Clear();
                txtbox.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
                txtbox.UseSystemPasswordChar = true;
                txtbox.PasswordChar = '●';
                txtbox.ForeColor = Color.FromArgb(64, 64, 64);
                pic.BackColor = Color.White;
                txtbox.BaseColor = Color.White;
                pic.Visible = true;
                pic.Image = ProyectoIntegrador2021.Properties.Resources.icons8_invisible_30px;
            }
        }
        public static void placeHolderPassLeave(Guna.UI.WinForms.GunaTextBox txtbox, String txt, System.Windows.Forms.PictureBox pic)
        {
            if (txtbox.Text.Trim() == "")
            {
                txtbox.Text = "   " + txt;
                txtbox.Font = new Font("Segoe UI", 10F, FontStyle.Bold);               
                txtbox.ForeColor = Color.DarkGray;
                pic.BackColor = Color.FromArgb(224, 224, 224);
                txtbox.BaseColor = Color.FromArgb(224, 224, 224);
                txtbox.UseSystemPasswordChar = false;
                txtbox.PasswordChar = '\0';
                pic.Visible = false;
            }
        }
        //MOSTRAR Y OCULTAR CONTRASEÑA
        public static void verContra(Guna.UI.WinForms.GunaTextBox txtbox, System.Windows.Forms.PictureBox pic)
        {
            txtbox.Focus();
            if (txtbox.UseSystemPasswordChar)
            {
                txtbox.PasswordChar = '\0';
                txtbox.UseSystemPasswordChar = false;
                pic.Image = ProyectoIntegrador2021.Properties.Resources.icons8_eye_30px;
            }
            else
            {
                txtbox.UseSystemPasswordChar = true;
                txtbox.PasswordChar = '●';
                pic.Image = ProyectoIntegrador2021.Properties.Resources.icons8_invisible_30px;
            }
        }
    }
}
