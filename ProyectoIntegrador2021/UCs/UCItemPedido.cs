using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegrador2021.UCs
{
    public partial class UCItemPedido : UserControl
    {
        NumberFormatInfo nfi = new NumberFormatInfo { NumberDecimalSeparator = ",", NumberGroupSeparator = "." };
        private float precio = 0;
        private float total = 0;
        private byte cantidad = 1;
        private string nombre = "nombre del producto";
        private string codigo = "código del producto";
     

        public float Precio {
            get
            {
                return precio;
            }
            set
            {
                precio = value;
                lblProductoPrecio.Text = "$ " + precio.ToString("#,##0.00", nfi);
            }
        }
        public float Total {
            get
            {
                return total;
            }
            set
            {
                total = value;
                lblTotal.Text = "$ " + total.ToString();
            }
        }
        public byte Cantidad {
            get
            {
                return cantidad;
            }
            set
            {
                cantidad = value;
                numCantidad.Value = cantidad;                
                total = cantidad * precio;
                lblTotal.Text = "$ " + total.ToString("#,##0.00", nfi);
            }
        }
        public string Nombre {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
                lblProductoNombre.Text = nombre;
            }
        }
        public string Codigo {
            get
            {
                return codigo;
            }
            set
            {
                codigo = value;
                lblProductoCodigo.Text = codigo;
            }
        }

        public UCItemPedido()
        {
            InitializeComponent();
        }

        public UCItemPedido(string codigo, string nombre, float precio, byte cantidad)
        {
            InitializeComponent();
            Codigo = codigo;
            Nombre = nombre;
            Precio = precio;
            Cantidad = cantidad;
            Total = precio * cantidad;            

        }

        private void lblQuitar_MouseEnter(object sender, EventArgs e)
        {
            lblQuitar.ForeColor = Color.FromArgb(254, 49, 108);
        }

        private void lblQuitar_MouseLeave(object sender, EventArgs e)
        {
            lblQuitar.ForeColor = Color.DimGray;
        }

        private void lblQuitar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void numCantidad_ValueChanged(object sender, EventArgs e)
        {
            cantidad = Convert.ToByte(numCantidad.Value);
            lblTotal.Text = "$ " + (cantidad * precio).ToString("#,##0.00", nfi);
        }
    }
}
