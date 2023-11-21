using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ManejoDataBase
{
    internal class Usuario : SQLCrud<Usuario>, ICRUDOperations<Usuario>
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Id_Ciudad { get; set; }
        public Usuario(string nombre, string apellido, int id_ciudad) : base("usuario", ["nombre", "apellido", "id"])
        {
            Nombre = nombre;
            Apellido = apellido;
            Id_Ciudad = id_ciudad;
            Id = 0;
        }
        public Usuario(Usuario alumno) : this(alumno.Nombre, alumno.Apellido, alumno.Id_Ciudad)
        {
            Id = alumno.Id;
        }
        public bool Add()
        {
            DB.Insert($"{this.Nombre}", $"{this.Apellido}", this.Id_Ciudad);
            return true;
        }

        public bool Delete()
        {
            return true;
        }

        public List<Usuario> Select()
        {
            //var alumnos = DB.Select<Alumno>("SELECT * FROM alumnos");
            var alumnos = GetAll();
            return alumnos;
        }

        public bool Update()
        {
            return true;
        }

        public static explicit operator Usuario(MySqlDataReader reader)
        {
            var nombre = reader["nombre"].ToString() ?? "";
            var apellido = reader["apellido"].ToString() ?? "";
            var id = Convert.ToInt32(reader["id"]);
            return new Usuario("Maria", "Albaytero", 1);
        }
    }

}
