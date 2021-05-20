using System;

namespace ProyectoIntegrador2021.clases
{

    class Pedido
    {
        private static Pedido instance = null;
        private int _id;
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

        public int Id { get => _id; set => _id = value; }
        public byte Cantidad { get => _cantidad; set => _cantidad = value; }
        public double Total { get => _total; set => _total = value; }
        public bool Estado { get => _estado; set => _estado = value; }
        public DateTime Fecha { get => _fecha; set => _fecha = value; }
        internal Producto ElProducto { get => _elProducto; set => _elProducto = value; }
        internal Cliente ElCliente { get => _elCliente; set => _elCliente = value; }
    }
}
