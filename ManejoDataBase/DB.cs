
using MySql.Data.MySqlClient;

namespace ManejoDataBase
{
    internal class DB
    {
        public static MySqlConnection connection;

        public static MySqlCommand command;


        static DB()
        {
            var mySqlStringConnection = @"Server=localhost;Database=utn;Uid=root;Pwd=;";
            connection = new MySqlConnection(mySqlStringConnection);

            command = new MySqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;
        }

        public static void Insert(string nombre, string apellido, int id_ciudad)
        {
            try
            {
                connection.Open();

                command.Parameters.Clear();

                var query = "INSERT INTO usuarios (nombre, apellido, mail, telefono, nombre_usuario, clave) VALUES (@nombre, @apellido, @mail, @telefono, @nombre_usuario, @clave)";

                command.CommandText = query;

                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@apellido", apellido);
                command.Parameters.AddWithValue("@mail", apellido);
                command.Parameters.AddWithValue("@telefono", apellido);
                command.Parameters.AddWithValue("@nombre_usuario", apellido);
                command.Parameters.AddWithValue("@clave", apellido);



                var filasAfectadas = command.ExecuteNonQuery();

                Console.WriteLine($"Filas afectadas: {filasAfectadas}");
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static void Select()
        {
            try
            {
                connection.Open();

                var query = "SELECT * FROM alumnos";

                command.CommandText = query;


                //El execute reader devuelve un data reader(un string)
                using (var reader = command.ExecuteReader())
                {
                    // El read() lee una fila y nos pone el puntero en el siguiente hasta llegar al final
                    while (reader.Read())
                    {
                        var nombre = reader["nombre"].ToString() ?? "";
                        var apellido = reader["apellido"].ToString() ?? "";
                        var id = Convert.ToInt32(reader["id"]);
                        //muestro los datos
                        Console.WriteLine($"ID: {id} - Nombre: {nombre} - Apellido: {apellido}");
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static List<T> Select<T>(string query) where T : Usuario
        {
            var lista = new List<T>();
            try
            {
                connection.Open();

                //var query = "SELECT * FROM alumnos";

                command.CommandText = query;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        T objeto = (T)reader;

                        lista.Add(objeto);
                        //mostrar los datos
                        //Console.WriteLine($"ID: {id} - Nombre: {nombre}");
                    }
                }

                return lista;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
