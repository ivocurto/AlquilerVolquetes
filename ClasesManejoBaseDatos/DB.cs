
using System.Data;
using MySql.Data.MySqlClient;
using Clases;
//using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ClasesManejoBaseDatos
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

        public static void Insert(int hash_code, int id_usuario, int? volquetes_chicos, int? volquetes_medianos, int? volquetes_grandes, DateTime fecha_ingreso, DateTime fecha_regreso, string direccion)
        {
            try
            {
                connection.Open();

                command.Parameters.Clear();
                var query = "INSERT INTO pedidos_cliente (hash_code, id_usuario, volquetes_chicos, volquetes_medianos, volquetes_grandes, fecha_ingreso, fecha_regreso, direccion) VALUES (@hash_code, @id_usuario, @volquetes_chicos, @volquetes_medianos, @volquetes_grandes, @fecha_ingreso, @fecha_regreso, @direccion)";

                command.CommandText = query;

                command.Parameters.AddWithValue("@hash_code", hash_code);
                command.Parameters.AddWithValue("@id_usuario", id_usuario);
                command.Parameters.AddWithValue("@volquetes_chicos", volquetes_chicos);
                command.Parameters.AddWithValue("@volquetes_medianos", volquetes_medianos);
                command.Parameters.AddWithValue("@volquetes_grandes", volquetes_grandes);
                command.Parameters.AddWithValue("@fecha_ingreso", fecha_ingreso);
                command.Parameters.AddWithValue("@fecha_regreso", fecha_regreso);
                command.Parameters.AddWithValue("@direccion", direccion);

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

        public static void Insert(string producto, int cantidad_disponible, int cantidad_alquilados)
        {
            try
            {
                connection.Open();

                command.Parameters.Clear();

                var query = "INSERT INTO stock (producto, cantidad_disponible, cantidad_alquilados) VALUES (@producto, @cantidad_disponible, @cantidad_alquilados)";

                command.CommandText = query;

                command.Parameters.AddWithValue("@producto", producto);
                command.Parameters.AddWithValue("@cantidad_disponible", cantidad_disponible);
                command.Parameters.AddWithValue("@cantidad_alquilados", cantidad_alquilados);

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

        public static void Insert(string mail, string nombre_admin, string clave)
        {
            try
            {
                connection.Open();

                command.Parameters.Clear();
                DB.Drop("usuarios", "mail", mail);
                var query = "INSERT INTO admins (mail, nombre_admin, clave) VALUES (@mail, @nombre_admin, @clave)";

                command.CommandText = query;

                command.Parameters.AddWithValue("@mail", mail);
                command.Parameters.AddWithValue("@nombre_admin", nombre_admin);
                command.Parameters.AddWithValue("@clave", clave);

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
                    }
                    else if (tabla == "pedidos_cliente")
                    {
                        while (reader.Read())
                        {
                            MostrarPedido(reader);
                        }
                    }
                    else if (tabla == "stock")
                    {
                        while (reader.Read())
                        {
                            MostrarStock(reader);
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
                        //MostrarUsuario(reader);

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

        public static List<PedidoADO> GetPedidosByIdUsuario(int idUsuario)
        {
            string query = $"SELECT * FROM pedidos_cliente WHERE id_usuario = {idUsuario}";

            var pedidos = new List<PedidoADO>();

            try
            {
                connection.Open();

                command.CommandText = query;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        PedidoADO pedido = new PedidoADO();
                        AsignarValoresDesdeReader(pedido, reader);
                        pedidos.Add(pedido);
                    }
                }

                return pedidos;
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


        public static void AsignarValoresDesdeReader(PedidoADO pedido, MySqlDataReader reader)
        {
            pedido.Hash_code = Convert.ToInt32(reader["hash_code"]);
            pedido.Id_usuario = Convert.ToInt32(reader["id_usuario"]);
            pedido.Volquetes_chicos = reader["volquetes_chicos"] is DBNull ? (int?)null : Convert.ToInt32(reader["volquetes_chicos"]);
            pedido.Volquetes_medianos = reader["volquetes_medianos"] is DBNull ? (int?)null : Convert.ToInt32(reader["volquetes_medianos"]);
            pedido.Volquetes_grandes = reader["volquetes_grandes"] is DBNull ? (int?)null : Convert.ToInt32(reader["volquetes_grandes"]);
            pedido.Fecha_ingreso = Convert.ToDateTime(reader["fecha_ingreso"]);
            pedido.Fecha_regreso = Convert.ToDateTime(reader["fecha_regreso"]);
            pedido.Direccion = reader["direccion"].ToString() ?? "";
        }

        public static void Drop(string tabla, string atributo, string atributoIngresado)
        {
            bool connectionOpen = false;
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                    connectionOpen = true;
                }

                string query = $"DELETE FROM {tabla} WHERE {atributo.ToLower()} = @{atributo.ToUpper()}";

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
                if (connectionOpen)
                {
                    connection.Close();
                }
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
            bool connectionOpen = false;
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                    connectionOpen = true;
                }


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
                if (connectionOpen)
                {
                    connection.Close();
                }

            }

            return atributoExistente;
        }

        public static bool VerificarAtributoEnBD(string tabla, string atributo, int atributoIngresado)
        {
            bool atributoExistente = false;
            bool connectionOpen = false;
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                    connectionOpen = true;
                }


                string query = $"SELECT COUNT(*) FROM {tabla} WHERE {atributo.ToLower()} = @{atributo.ToUpper()}";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue($"@{atributo.ToUpper()}", $"{atributoIngresado}");

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
                if (connectionOpen)
                {
                    connection.Close();
                }

            }

            return atributoExistente;
        }

        public static Cliente TraerUsuarioLogueado(string nombreUsuario, string clave)
        {
            Cliente cliente = null;

            try
            {
                connection.Open();

                string query = "SELECT * FROM usuarios WHERE nombre_usuario = @NombreUsuario AND clave = @Clave";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                    command.Parameters.AddWithValue("@Clave", clave);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Crea un nuevo usuario con los datos de la base de datos
                            cliente = new Cliente(
                                Convert.ToInt32(reader["id"]),
                                reader["nombre"].ToString(),
                                reader["apellido"].ToString(),
                                reader["mail"].ToString(),
                                reader["telefono"] is DBNull ? (int?)null : Convert.ToInt32(reader["telefono"]),
                                reader["nombre_usuario"].ToString(),
                                reader["clave"].ToString()
                            );
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

            return cliente;
        }

        public static Admin TraerAdminLogueado(string nombreUsuario, string clave)
        {
            Admin admin = null;

            try
            {
                connection.Open();

                string query = "SELECT * FROM admins WHERE nombre_admin = @NombreUsuario AND clave = @Clave";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                    command.Parameters.AddWithValue("@Clave", clave);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Crea un nuevo usuario con los datos de la base de datos
                            admin = new Admin(
                                Convert.ToInt32(reader["id"]),
                                reader["nombre_usuario"].ToString(),
                                reader["mail"].ToString(),
                                reader["clave"].ToString()
                            );
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

            return admin;
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

        //public static List<Pedido> TraerPedidosDesdeBD(int idUsuario)
        //{
        //    List<Pedido> listaPedidos = null;

        //    try
        //    {
        //        connection.Open();

        //        string query = "SELECT * FROM pedidos_cliente WHERE idUsuario = @IdUsuario";

        //        using (var command = new MySqlCommand(query, connection))
        //        {
        //            command.Parameters.AddWithValue("@IdUsuario", idUsuario);

        //            using (var reader = command.ExecuteReader())
        //            {
        //                if (reader.Read())
        //                {
        //                    // Crea un nuevo usuario con los datos de la base de datos
        //                    cliente = new Cliente(
        //                        Convert.ToInt32(reader["id"]),
        //                        reader["nombre"].ToString(),
        //                        reader["apellido"].ToString(),
        //                        reader["mail"].ToString(),
        //                        reader["telefono"] is DBNull ? (int?)null : Convert.ToInt32(reader["telefono"]),
        //                        reader["nombre_usuario"].ToString(),
        //                        reader["clave"].ToString()
        //                    );
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        // Maneja la excepción de manera apropiada (registra, notifica, etc.)
        //        throw;
        //    }
        //    finally
        //    {
        //        connection.Close();
        //    }

        //    return cliente;
        //}

        private static Cliente CrearCliente(MySqlDataReader reader)
        {
            var id = Convert.ToInt32(reader["id"]);
            var nombre = reader["nombre"].ToString() ?? "";
            var apellido = reader["apellido"].ToString() ?? "";
            var mail = reader["mail"].ToString() ?? "";
            var telefono = Convert.ToInt32(reader["telefono"]);
            var nombre_usuario = reader["nombre_usuario"].ToString() ?? "";
            var clave = reader["clave"].ToString() ?? "";
            //muestro los datos
            var usuario = new Cliente(id, nombre, apellido, mail, telefono, nombre_usuario, clave);
            return usuario;
            //usuario.Add();($"ID: {id} - Nombre: {nombre} - Apellido: {apellido} - Mail: {mail} - Telefono {telefono} - Username: {nombre_usuario} - Clave: {clave}");
        }

        private static void MostrarPedido(MySqlDataReader reader)
        {
            var hash_code = Convert.ToInt32(reader["hash_code"]);
            var id_usuario = Convert.ToInt32(reader["id_usuario"]);
            var volquetes_chicos = Convert.ToInt32(reader["volquetes_chicos"]);
            var volquetes_medianos = Convert.ToInt32(reader["volquetes_medianos"]);
            var volquetes_grandes = Convert.ToInt32(reader["volquetes_grandes"]);
            var fecha_ingreso = reader["fecha_ingreso"].ToString() ?? "";
            var fecha_regreso = reader["fecha_regreso"].ToString() ?? "";
            //muestro los datos
            Console.WriteLine($"hash_code: {hash_code} - id_usuario: {id_usuario} - volquetes_chicos: {volquetes_chicos} - volquetes_medianos: {volquetes_medianos} - volquetes_grandes {volquetes_grandes} - fecha_ingreso: {fecha_ingreso} - fecha_regreso: {fecha_regreso}");
        }

        private static void MostrarStock(MySqlDataReader reader)
        {
            var id = Convert.ToInt32(reader["id"]);
            var producto = reader["producto"].ToString() ?? "";
            var cantidad_disponible = Convert.ToInt32(reader["cantidad_disponible"]);
            var cantidad_alquilados = Convert.ToInt32(reader["cantidad_alquilados"]);
            //muestro los datos
            Console.WriteLine($"id: {id} - producto: {producto} - cantidad_disponible: {cantidad_disponible} - cantidad_alquilados: {cantidad_alquilados}");
        }

        public static void ActualizarAtributoUsuario(string mail, string atributoACambiar, string nuevoAtributo)
        {
            try
            {
                connection.Open();

                if (VerificarAtributoEnBD("mail", mail))
                {
                    string query = $"UPDATE usuarios SET {atributoACambiar} = @nuevoAtributo WHERE mail = @Mail";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@nuevoAtributo", nuevoAtributo);
                        cmd.Parameters.AddWithValue("@Mail", mail);

                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            Console.WriteLine($"Atributo actualizado correctamente para el correo electrónico {mail}");
                        }
                        else
                        {
                            Console.WriteLine($"No se encontró un registro con el correo electrónico {mail}");
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"No hay un registro con el correo electrónico {mail}");
                }
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

        public static void ActualizarFechaPedido(int hash_code, string atributoACambiar, DateTime nuevoAtributo)
        {
            try
            {
                connection.Open();

                if (VerificarAtributoEnBD("pedidos_cliente", "hash_code", hash_code))
                {
                    string query = $"UPDATE pedidos_cliente SET {atributoACambiar} = @nuevoAtributo WHERE hash_code = @Hash_code";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@nuevoAtributo", nuevoAtributo);
                        cmd.Parameters.AddWithValue("@Hash_code", hash_code);

                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            Console.WriteLine($"Atributo actualizado correctamente para el pedido {hash_code}");
                        }
                        else
                        {
                            Console.WriteLine($"No se encontró un registro con el pedido {hash_code}");
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"No hay un registro con el pedido {hash_code}");
                }
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

        public static void CambiarCantidadDisponible(int id, int cantidad_a_restar, bool sumar)
        {
            try
            {
                connection.Open();

                if (VerificarAtributoEnBD("stock", "id", id))
                {
                    int cantidad_disponible = TraerCantidadVolqueteDisponible(id);
                    int cantidad_alquilados = TraerCantidadVolquetesAlquilados(id);
                    int nueva_cantidad_disponible;
                    int nueva_cantidad_alquilados;
                    if (sumar)
                    {
                        nueva_cantidad_disponible = cantidad_disponible - (-cantidad_a_restar);
                        nueva_cantidad_alquilados = cantidad_alquilados - cantidad_a_restar;
                    }
                    else
                    {
                        nueva_cantidad_disponible = cantidad_disponible - cantidad_a_restar;
                        nueva_cantidad_alquilados = cantidad_alquilados - (-cantidad_a_restar);
                    }

                    string query = $"UPDATE stock SET cantidad_disponible = @nuevaCantidadDisponible WHERE id = @Id";
                    string query2 = $"UPDATE stock SET cantidad_alquilados = @nuevaCantidadAlquilados WHERE id = @Id";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@nuevaCantidadDisponible", nueva_cantidad_disponible);
                        cmd.Parameters.AddWithValue("@Id", id);

                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            Console.WriteLine($"Atributo actualizado correctamente para el producto de id {id}");
                        }
                        else
                        {
                            Console.WriteLine($"No se encontró un registro con el producto de id {id}");
                        }
                    }
                    using (MySqlCommand cmd = new MySqlCommand(query2, connection))
                    {
                        cmd.Parameters.AddWithValue("@nuevaCantidadAlquilados", nueva_cantidad_alquilados);
                        cmd.Parameters.AddWithValue("@Id", id);

                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            Console.WriteLine($"Atributo actualizado correctamente para el producto de id {id}");
                        }
                        else
                        {
                            Console.WriteLine($"No se encontró un registro con el producto de id {id}");
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"No hay un registro con el producto de id {id}");
                }
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


        public static int TraerCantidadVolqueteDisponible(int id)
        {
            int cantidad_disponible = -1;
            try
            {
                string query = "SELECT * FROM stock WHERE id = @Id";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            cantidad_disponible = Convert.ToInt32(reader["cantidad_disponible"]);
                        }
                    }
                }
            }
            catch (Exception)
            {
                // Maneja la excepción de manera apropiada (registra, notifica, etc.)
                throw;
            }
            return cantidad_disponible;
        }

        public static int TraerCantidadVolquetesAlquilados(int id)
        {
            int cantidad_alquilados = -1;
            try
            {
                string query = "SELECT * FROM stock WHERE id = @Id";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            cantidad_alquilados = Convert.ToInt32(reader["cantidad_alquilados"]);
                        }
                    }
                }
            }
            catch (Exception)
            {
                // Maneja la excepción de manera apropiada (registra, notifica, etc.)
                throw;
            }
            return cantidad_alquilados;
        }
    }
}
