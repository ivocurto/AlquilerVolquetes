
using MySql.Data.MySqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ManejoDataBase
{
    public class DB
    {
        public static MySqlConnection connection;

        public static MySqlCommand command;


        static DB()
        {
            var mySqlStringConnection = @"Server=localhost;Database=alquiler_volquetes;Uid=root;Pwd=;";
            connection = new MySqlConnection(mySqlStringConnection);

            command = new MySqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;
        }

        public static void Insert(string nombre, string apellido, string mail, int? telefono, string nombre_usuario, string clave)
        {
            try
            {
                bool existencia_mail = VerificarAtributoEnBD("mail", mail);
                if (!existencia_mail)
                {
                    connection.Open();

                    command.Parameters.Clear();

                    var query = "INSERT INTO usuarios (nombre, apellido, mail, telefono, nombre_usuario, clave) VALUES (@nombre, @apellido, @mail, @telefono, @nombre_usuario, @clave)";

                    command.CommandText = query;

                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@apellido", apellido);
                    command.Parameters.AddWithValue("@mail", mail);
                    command.Parameters.AddWithValue("@telefono", telefono);
                    command.Parameters.AddWithValue("@nombre_usuario", nombre_usuario);
                    command.Parameters.AddWithValue("@clave", clave);

                    var filasAfectadas = command.ExecuteNonQuery();

                    Console.WriteLine($"Filas afectadas: {filasAfectadas}");
                }
                else
                {
                    Console.WriteLine("Ya existe una cuenta con ese mail");
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

        public static void Insert(int hash_code, int id_usuario, int? volquetes_chicos, int? volquetes_medianos, int? volquetes_grandes, DateTime fecha_ingreso, DateTime fecha_regreso)
        {
            try
            {
                connection.Open();

                command.Parameters.Clear();
                var query = "INSERT INTO pedidos_cliente (hash_code, id_usuario, volquetes_chicos, volquetes_medianos, volquetes_grandes, fecha_ingreso, fecha_regreso) VALUES (@hash_code, @id_usuario, @volquetes_chicos, @volquetes_medianos, @volquetes_grandes, @fecha_ingreso, @fecha_regreso)";

                command.CommandText = query;

                command.Parameters.AddWithValue("@hash_code", hash_code);
                command.Parameters.AddWithValue("@id_usuario", id_usuario);
                command.Parameters.AddWithValue("@volquetes_chicos", volquetes_chicos);
                command.Parameters.AddWithValue("@volquetes_medianos", volquetes_medianos);
                command.Parameters.AddWithValue("@volquetes_grandes", volquetes_grandes);
                command.Parameters.AddWithValue("@fecha_ingreso", fecha_ingreso);
                command.Parameters.AddWithValue("@fecha_regreso", fecha_regreso);

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

        public static void Select(string tabla)
        {
            try
            {
                connection.Open();

                var query = $"SELECT * FROM {tabla}";

                command.CommandText = query;


                //El execute reader devuelve un data reader(un string)
                using (var reader = command.ExecuteReader())
                {
                    // El read() lee una fila y nos pone el puntero en el siguiente hasta llegar al final
                    if (tabla == "usuarios")
                    {
                        while (reader.Read())
                        {
                            MostrarUsuario(reader);
                        }
                    } else if (tabla == "pedidos_cliente")
                    {
                        while (reader.Read())
                        {
                            MostrarPedido(reader);
                        }
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

        public static List<T> Select<T>(string query) where T : class
        {
            var lista = new List<T>();
            try
            {
                connection.Open();

                command.CommandText = query;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        T objeto = Activator.CreateInstance<T>();
                        MostrarUsuario(reader);

                        lista.Add(objeto);
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

        public static void Drop(string atributo, string atributoIngresado)
        {
            try
            {
                connection.Open();

                string query = $"DELETE FROM usuarios WHERE {atributo.ToLower()} = @{atributo.ToUpper()}";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    // Agrega el parámetro para evitar la inyección de SQL
                    cmd.Parameters.AddWithValue($"{atributo.ToUpper()}", $"{atributoIngresado.ToLower()}");

                    cmd.ExecuteNonQuery();
                }

                Console.WriteLine($"Eliminado correctamente");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static void Drop(string atributo, int atributoIngresado)
        {
            try
            {
                connection.Open();

                string query = $"DELETE FROM pedidos_cliente WHERE {atributo.ToLower()} = @{atributo.ToUpper()}";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    // Agrega el parámetro para evitar la inyección de SQL
                    cmd.Parameters.AddWithValue($"{atributo.ToUpper()}", atributoIngresado);

                    cmd.ExecuteNonQuery();
                }

                Console.WriteLine($"Eliminado correctamente");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static bool VerificarAtributoEnBD(string atributo, string atributoIngresado)
        {
            bool atributoExistente = false;

            try
            {
                connection.Open();

                string query = $"SELECT COUNT(*) FROM usuarios WHERE {atributo.ToLower()} = @{atributo.ToUpper()}";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue($"@{atributo.ToUpper()}", $"{atributoIngresado.ToLower()}");

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    // Si count es mayor que cero, significa que el atributo ya existe
                    atributoExistente = (count > 0);
                }
            }
            catch (Exception)
            {
                // Maneja la excepción de manera apropiada (registra, notifica, etc.)
                throw;
            }
            finally
            {
                connection.Close();
            }

            return atributoExistente;
        }

        public static Usuario TraerUsuarioLogueado(string nombreUsuario)
        {
            Usuario usuario = null;

            try
            {
                connection.Open();

                string query = "SELECT * FROM usuarios WHERE nombre_usuario = @NombreUsuario";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Crea un nuevo usuario con los datos de la base de datos
                            usuario = new Usuario(
                                reader["nombre"].ToString(),
                                reader["apellido"].ToString(),
                                reader["mail"].ToString(),
                                reader["telefono"] is DBNull ? (int?)null : Convert.ToInt32(reader["telefono"]),
                                reader["nombre_usuario"].ToString(),
                                reader["clave"].ToString()
                            );

                            // Asigna el ID
                            usuario.Id = Convert.ToInt32(reader["id"]);
                        }
                    }
                }
            }
            catch (Exception)
            {
                // Maneja la excepción de manera apropiada (registra, notifica, etc.)
                throw;
            }
            finally
            {
                connection.Close();
            }

            return usuario;
        }

        private static void MostrarUsuario(MySqlDataReader reader)
        {
            var id = Convert.ToInt32(reader["id"]);
            var nombre = reader["nombre"].ToString() ?? "";
            var apellido = reader["apellido"].ToString() ?? "";
            var mail = reader["mail"].ToString() ?? "";
            var telefono = Convert.ToInt32(reader["telefono"]);
            var nombre_usuario = reader["nombre_usuario"].ToString() ?? "";
            var clave = reader["clave"].ToString() ?? "";
            //muestro los datos
            Console.WriteLine($"ID: {id} - Nombre: {nombre} - Apellido: {apellido} - Mail: {mail} - Telefono {telefono} - Username: {nombre_usuario} - Clave: {clave}");
        }

        private static void MostrarPedido(MySqlDataReader reader)
        {
            var hash_code = Convert.ToInt32(reader["hash_code"]);
            var id_usuario = reader["id_usuario"].ToString() ?? "";
            var volquetes_chicos = reader["volquetes_chicos"].ToString() ?? "";
            var volquetes_medianos = reader["volquetes_medianos"].ToString() ?? "";
            var volquetes_grandes = Convert.ToInt32(reader["volquetes_grandes"]);
            var fecha_ingreso = reader["fecha_ingreso"].ToString() ?? "";
            var fecha_regreso = reader["fecha_regreso"].ToString() ?? "";
            //muestro los datos
            Console.WriteLine($"hash_code: {hash_code} - id_usuario: {id_usuario} - volquetes_chicos: {volquetes_chicos} - volquetes_medianos: {volquetes_medianos} - volquetes_grandes {volquetes_grandes} - fecha_ingreso: {fecha_ingreso} - fecha_regreso: {fecha_regreso}");
        }
    }
}
