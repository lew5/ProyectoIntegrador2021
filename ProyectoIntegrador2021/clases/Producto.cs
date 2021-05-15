using System;

namespace PruebasDB.clases
{
    class Producto
    {
        private string _codigo;
        private string _nombre;
        private double _precio;

        public Producto(string codigo, string nombre, double precio)
        {
            _codigo = codigo;
            _nombre = nombre;
            _precio = precio;
        }

        public string Codigo { get => _codigo; set => _codigo = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public double Precio { get => _precio; set => _precio = value; }
    }
}
