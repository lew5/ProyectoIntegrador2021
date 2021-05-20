namespace ProyectoIntegrador2021.clases
{
    class Producto
    {
        private static Producto instance = null;
        private byte _campania;
        private string _codigo;
        private string _nombre;
        private double _precio;
      
        public Producto(string codigo, string nombre, double precio)
        {
            _codigo = codigo;
            _nombre = nombre;
            _precio = precio;
        }

        public Producto()
        {
        }
        public static Producto Instance()
        {
            if (instance == null)
                instance = new Producto();
            return instance;
        }

        public string Codigo { get => _codigo; set => _codigo = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public double Precio { get => _precio; set => _precio = value; }
        public byte Campania { get => _campania; set => _campania = value; }
    }
}
