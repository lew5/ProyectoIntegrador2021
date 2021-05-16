using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasDB.clases
{

    class Pedido
    {
        private static Pedido instance = null;
        private string _codigo;
        private byte _cantidad;
        private double _total;
        private bool _estado;
        private DateTime _fecha;
        private Producto _elProducto;
        private Cliente _elCliente;
        public Pedido()
        {

        }

        public static Pedido Instance()
        {
            if (instance == null)
                instance = new Pedido();
            return instance;
        }

        public string Codigo { get => _codigo; set => _codigo = value; }
        public byte Cantidad { get => _cantidad; set => _cantidad = value; }
        public double Total { get => _total; set => _total = value; }
        public bool Estado { get => _estado; set => _estado = value; }
        public DateTime Fecha { get => _fecha; set => _fecha = value; }
        internal Producto ElProducto { get => _elProducto; set => _elProducto = value; }
        internal Cliente ElCliente { get => _elCliente; set => _elCliente = value; }
    }
}
