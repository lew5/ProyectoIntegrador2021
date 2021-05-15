using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasDB.clases
{
    class Usuario
    {
        private int _id;
        private string _nombre;
        private string _password;
        private string _email;

        public Usuario(string nombre,string password,string email)
        {
            this._nombre = nombre;
            this._password = password;
            this._email = email;
        }

        public int Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Password { get => _password; set => _password = value; }
        public string Email { get => _email; set => _email = value; }
    }
}
