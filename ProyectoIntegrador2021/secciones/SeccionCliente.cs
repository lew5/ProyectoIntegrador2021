﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegrador2021.secciones
{
    public partial class SeccionCliente : UserControl
    {
        public SeccionCliente()
        {
            InitializeComponent();
        }

        private void mostrarSub<Sub>() where Sub : UserControl, new()
        {
            UserControl uc;
            uc = pnlContenedor.Controls.OfType<Sub>().FirstOrDefault();
            if (uc == null)
            {
                uc = new Sub();
                pnlContenedor.Controls.Add(uc);
                uc.Dock = DockStyle.Fill;
                uc.BringToFront();
                foreach (Control c in pnlContenedor.Controls)
                    if (uc.Name != c.Name)
                    {
                        c.Dispose();
                    }
            }
            else
            {
                uc.BringToFront();
            }
        }

        private void ucPanelClientes_Nuevo_Click(object sender, EventArgs e)
        {
            ucPanelNuevoCliente.BringToFront();
        }

        private void ucPanelNuevoCliente_Volver_Click(object sender, EventArgs e)
        {
            ucPanelClientes.BringToFront();
        }

        private void ucPanelPerfilCliente_Volver_Click(object sender, EventArgs e)
        {
            ucPanelClientes.BringToFront();
        }

        private void ucPanelClientes_Perfil_Click(object sender, EventArgs e)
        {
            ucPanelPerfilCliente.BringToFront();
        }
    }
}