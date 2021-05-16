using System;
using System.Collections.Generic;

namespace PruebasDB.clases
{
    class Cliente
    {
        private static Cliente instance = null;
        private int _id;
        private int _usuario_id;
        private string _nombre;
        private string _apellido;
        private string _cedula;
        private string _telefono;
        private string _direccion;
        private List<Pedido> _pedidos;
        public Cliente()
        {
        }

        public void agregarPedido(Pedido elPedido)
        {
            if (_pedidos == null) _pedidos = new List<Pedido>();
            _pedidos.Add(elPedido);
            elPedido.ElCliente = this;
        }

        public static Cliente Instance()
        {
            if(instance==null)
                instance=new Cliente();
            return instance;
        }

        public int Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string Cedula { get => _cedula; set => _cedula = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        internal List<Pedido> Pedidos { get => _pedidos; set => _pedidos = value; }
        public int Usuario_id { get => _usuario_id; set => _usuario_id = value; }
    }
}
