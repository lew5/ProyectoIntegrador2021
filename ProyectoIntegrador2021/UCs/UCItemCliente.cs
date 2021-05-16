﻿using System;
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

        private String _Id = "ID";
        private String _Nombre = "NOMBRE";
        private String _Apellido = "APELLIDO";
        private String _Telefono = "TELÉFONO";
        private String _Cedula = "CÉDULA";
        private String _Pedidos = "0";
        private String _PedidosPagos = "0";
        private String _PedidosDebe = "0";
        public UCItemCliente()
        {
            InitializeComponent();
        }

        private void lblId_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(242,242,242);
        }

        private void lblId_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }


        public string ID
        {
            get
            {
                return _Id;
            }
            set
            {
                _Id = value;
                lblId.Text = _Id;
            }
        }
        public string Nombre
        {
            get
            {
                return _Nombre;
            }
            set
            {
                _Nombre = value;
                lblNombre.Text = _Nombre;
            }
        }

        public string Apellido
        {
            get
            {
                return _Apellido;
            }
            set
            {
                _Apellido = value;
                lblApellido.Text = _Apellido;
            }
        }

        public string Telefono
        {
            get
            {
                return _Telefono;
            }
            set
            {
                _Telefono = value;
                lblTelefono.Text = _Telefono;
            }
        }

        public string Cedula
        {
            get
            {
                return _Cedula;
            }
            set
            {
                _Cedula = value;
                lblCedula.Text = _Cedula;
            }
        }

        public string Pedidos
        {
            get
            {
                return _Pedidos;
            }
            set
            {
                _Pedidos = value;
                lblPedios.Text = _Pedidos;
            }
        }

        public string PedidosPagos
        {
            get
            {
                return _PedidosPagos;
            }
            set
            {
                _PedidosPagos = value;
                lblPedidosPagos.Text = _PedidosPagos;
            }
        }

        public string PedidosDebe
        {
            get
            {
                return _PedidosDebe;
            }
            set
            {
                _PedidosDebe = value;
                lblPedidosDebe.Text = _PedidosDebe;
            }
        }

        private void lblEstado_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show(this.ID);
        }
    }
}
