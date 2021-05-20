using MySql.Data.MySqlClient;
using ProyectoIntegrador2021.clases;
using System.Windows.Forms;

namespace ProyectoIntegrador2021.db
{
    class DB
    {
        private string _url;
        private string consulta;
        private MySqlConnection mySqlConnection;
        private MySqlDataReader dataReader = null;
        private MySqlCommand command = new MySqlCommand();

        public DB(string db, string servidor, string puerto, string usuario, string password)
        {

            _url = "Database=" + db
                + "; Data Source=" + servidor
                + "; Port=" + puerto
                + "; User Id=" + usuario
                + "; Password=" + password;
            mySqlConnection = new MySqlConnection(_url);
        }

        private MySqlConnection conexion()
        {
            mySqlConnection = new MySqlConnection(_url);
            return mySqlConnection;
        }

        private void DataReader(ref MySqlCommand comm, string url)
        {
            command.CommandText = consulta;
            command.Connection = mySqlConnection;
            mySqlConnection.Open();
            dataReader = command.ExecuteReader();
        }

        public void SelectCliente()
        {
            consulta = "SELECT * FROM cliente WHERE cliente_id = '1'";
            try
            {
                DataReader(ref command, consulta);
                Cliente cliente = new Cliente();
                while (dataReader.Read())
                {
                    cliente.Id = dataReader.GetInt32(0);
                    cliente.Usuario_id = dataReader.GetInt32(1);
                    cliente.Nombre = dataReader.GetString(2);
                    cliente.Apellido = dataReader.GetString(3);
                    cliente.Cedula = dataReader.GetString(4); ;
                    cliente.Telefono = dataReader.GetString(5);
                    cliente.Direccion = dataReader.GetString(6);
                }
                MessageBox.Show(cliente.Id
                    + " - " + cliente.Usuario_id
                    + " - " + cliente.Nombre
                    + " - " + cliente.Apellido
                    + " - " + cliente.Cedula
                    + " - " + cliente.Telefono
                    + " - " + cliente.Direccion);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                mySqlConnection.Close();
            }
        }
    }


}
