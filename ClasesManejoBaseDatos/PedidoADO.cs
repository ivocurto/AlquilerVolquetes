using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ClasesManejoBaseDatos
{
    public class PedidoADO : SQLCrud<PedidoADO>, ICRUDOperations<PedidoADO>
    {
        public int Hash_code { get; set; }
        public int Id_usuario { get; set; }
        public int? Volquetes_chicos { get; set; }
        public int? Volquetes_medianos { get; set; }
        public int? Volquetes_grandes { get; set; }
        public DateTime Fecha_ingreso { get; set; }
        public DateTime Fecha_regreso { get; set; }
        public string Direccion { get; set; }

        public PedidoADO() : base("pedidos_cliente", new[] { "hash_code", "id_usuario", "volquetes_chicos", "volquetes_medianos", "volquetes_grandes", "fecha_ingreso", "fecha_regreso", "direccion" })
        {
        }

        public PedidoADO(int hash_code, int id_usuario, int? volquetes_chicos, int? volquetes_medianos, int? volquetes_grandes, DateTime fecha_ingreso, DateTime fecha_regreso, string direccion) : base("pedidos_cliente", ["hash_code", "id_usuario", "volquetes_chicos", "volquetes_medianos", "volquetes_grandes", "fecha_ingreso", "fecha_regreso", "direccion"])
        {
            Hash_code = hash_code;
            Id_usuario = id_usuario;
            Volquetes_chicos = volquetes_chicos ?? 0;
            Volquetes_medianos = volquetes_medianos ?? 0;
            Volquetes_grandes = volquetes_grandes ?? 0;
            Fecha_ingreso = fecha_ingreso;
            Fecha_regreso = fecha_regreso;
            Direccion = direccion;

        }
        public bool Add()
        {
            DB.Insert(this.Hash_code, this.Id_usuario, this.Volquetes_chicos, Volquetes_medianos, Volquetes_grandes, Fecha_ingreso, Fecha_regreso, this.Direccion);
            return true;
        }

        public bool Delete()
        {
            DB.Drop("hash_code", this.Hash_code);
            return true;
        }

        public List<PedidoADO> Select()
        {
            //var alumnos = DB.Select<Alumno>("SELECT * FROM alumnos");
            var pedidos = GetAll();
            return pedidos;
        }

        public bool Update()
        {
            return true;
        }

        //public static explicit operator Usuario(MySqlDataReader reader)
        //{
        //    var nombre = reader["nombre"].ToString() ?? "";
        //    var apellido = reader["apellido"].ToString() ?? "";
        //    var mail = reader["mail"];
        //    return new Usuario("Maria", "Albaytero", "mariaalbaytero@gmail.com", 1154879687, "mariaalbaytero", "1234");
        //}
    }

}
