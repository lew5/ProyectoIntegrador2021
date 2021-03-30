using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoIntegrador2021.UCs
{
    public partial class UCInicioSesion : UserControl
    {
        private const String phNumbreUsuario = "NOMBRE DE USUARIO";
        private const String phContrasenia = "CONTRASEÑA";
        public UCInicioSesion()
        {
            InitializeComponent();
        }



        private void lbl_Crear_cuenta_Click(object sender, EventArgs e)
        {
            this.ActiveControl = lbl_Crear_cuenta;
            this.SendToBack();
        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            if (txtBoxVacios())
            {
                //MENSAJE ERROR
            }
            else
            {
                //INICIAR
            }
        }

        private Boolean txtBoxVacios()
        {
            if (txtbox_NombreUsuario.Text.Trim() == "" || txtbox_NombreUsuario.Text.Trim() == phNumbreUsuario
                || txtbox_Contrasenia.Text.Trim() == "" || txtbox_Contrasenia.Text.Trim() == phContrasenia)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //PLACEHOLDER

        private void txtbox_NombreUsuario_Enter(object sender, EventArgs e)
        {
            Funciones.placeHolderEnter(txtbox_NombreUsuario, phNumbreUsuario);
        }

        private void txtbox_NombreUsuario_Leave(object sender, EventArgs e)
        {
            Funciones.placeHolderLeave(txtbox_NombreUsuario, phNumbreUsuario);
        }

        private void txtbox_Contrasenia_Enter(object sender, EventArgs e)
        {
            Funciones.placeHolderPassEnter(txtbox_Contrasenia, phContrasenia);
        }

        private void txtbox_Contrasenia_Leave(object sender, EventArgs e)
        {
            Funciones.placeHolderPassLeave(txtbox_Contrasenia, phContrasenia);
        }

        private void lbl_Olvidaste_tu_contra_MouseEnter(object sender, EventArgs e)
        {
            lbl_Olvidaste_tu_contra.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void lbl_Olvidaste_tu_contra_MouseLeave(object sender, EventArgs e)
        {
            lbl_Olvidaste_tu_contra.ForeColor = Color.Silver;
        }

        private void lbl_Crear_cuenta_MouseEnter(object sender, EventArgs e)
        {
            lbl_Crear_cuenta.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void lbl_Crear_cuenta_MouseLeave(object sender, EventArgs e)
        {
            lbl_Crear_cuenta.ForeColor = Color.Silver;
        }
    }
}
