using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoIntegrador2021.UCs
{
    public partial class UCNuevoUsuario : UserControl
    {
        private const String phNombreUsuario = "NOMBRE DE USUARIO";
        private const String phEmail = "E-MAIL";
        private const String phContrasenia = "CONTRASEÑA";
        private const String phRepetirContrasenia = "REPETIR CONTRASEÑA";
        private const String phContraseniAdmin = "CONTRASEÑA DEL ADMIN";
        public UCNuevoUsuario()
        {
            InitializeComponent();
        }



        private void lbl_Volver_Click(object sender, EventArgs e)
        {
            this.ActiveControl = lbl_Volver;
            this.SendToBack();
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            if (txtBoxVacios())
            {
                //MENSEJE ERROR
            }
            else
            {
                //GUARDAR USUARIO EN LA BD
            }
        }




        private Boolean txtBoxVacios()
        {
            if (
                txtbox_Registrar_Nombre_usuario.Text.Trim() == "" || txtbox_Registrar_Nombre_usuario.Text.Trim() == phNombreUsuario
                || txtbox_Registrar_Email.Text.Trim() == "" || txtbox_Registrar_Email.Text.Trim() == phEmail
                || txtbox_Registrar_Contrasenia.Text.Trim() == "" || txtbox_Registrar_Contrasenia.Text.Trim() == phContrasenia
                || txtbox_Registrar_Repetir_contrasenia.Text.Trim() == "" || txtbox_Registrar_Repetir_contrasenia.Text.Trim() == phRepetirContrasenia
                || txtbox_Registrar_Contrasenia_admin.Text.Trim() == "" || txtbox_Registrar_Contrasenia_admin.Text.Trim() == phContraseniAdmin
                )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //PLACEHOLDER
        private void txtbox_Registrar_Nombre_usuario_Enter(object sender, EventArgs e)
        {
            Funciones.placeHolderEnter(txtbox_Registrar_Nombre_usuario, phNombreUsuario);
        }

        private void txtbox_Registrar_Nombre_usuario_Leave(object sender, EventArgs e)
        {
            Funciones.placeHolderLeave(txtbox_Registrar_Nombre_usuario, phNombreUsuario);
        }

        private void txtbox_Registrar_Email_Enter(object sender, EventArgs e)
        {
            Funciones.placeHolderEnter(txtbox_Registrar_Email, phEmail);
        }

        private void txtbox_Registrar_Email_Leave(object sender, EventArgs e)
        {
            Funciones.placeHolderLeave(txtbox_Registrar_Email, phEmail);
        }

        private void txtbox_Registrar_Contrasenia_Enter(object sender, EventArgs e)
        {
            Funciones.placeHolderPassEnter(txtbox_Registrar_Contrasenia, phContrasenia,pic_VerContra);
        }

        private void txtbox_Registrar_Contrasenia_Leave(object sender, EventArgs e)
        {
            Funciones.placeHolderPassLeave(txtbox_Registrar_Contrasenia, phContrasenia, pic_VerContra);
        }

        private void txtbox_Registrar_Repetir_contrasenia_Enter(object sender, EventArgs e)
        {
            Funciones.placeHolderPassEnter(txtbox_Registrar_Repetir_contrasenia, phRepetirContrasenia,pic_VerRepContra);
        }

        private void txtbox_Registrar_Repetir_contrasenia_Leave(object sender, EventArgs e)
        {
            Funciones.placeHolderPassLeave(txtbox_Registrar_Repetir_contrasenia, phRepetirContrasenia,pic_VerRepContra);
        }

        private void txtbox_Registrar_Contrasenia_admin_Enter(object sender, EventArgs e)
        {
            Funciones.placeHolderPassEnter(txtbox_Registrar_Contrasenia_admin, phContraseniAdmin,pic_VerAdminContra);
        }

        private void txtbox_Registrar_Contrasenia_admin_Leave(object sender, EventArgs e)
        {
            Funciones.placeHolderPassLeave(txtbox_Registrar_Contrasenia_admin, phContraseniAdmin, pic_VerAdminContra);
        }

        private void lbl_Volver_MouseEnter(object sender, EventArgs e)
        {
            lbl_Volver.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void lbl_Volver_MouseLeave(object sender, EventArgs e)
        {
            lbl_Volver.ForeColor = Color.Silver;
        }

        private void pic_VerContra_Click(object sender, EventArgs e)
        {
            Funciones.verContra(txtbox_Registrar_Contrasenia,pic_VerContra);
        }

        private void pic_VerRepContra_Click(object sender, EventArgs e)
        {
            Funciones.verContra(txtbox_Registrar_Repetir_contrasenia, pic_VerRepContra);
        }

        private void pic_VerAdminContra_Click(object sender, EventArgs e)
        {
            Funciones.verContra(txtbox_Registrar_Contrasenia_admin, pic_VerAdminContra);
        }
    }
}
