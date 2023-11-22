using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Macs;

namespace ClasesManejoBaseDatos
{
    public class UsuarioADO : SQLCrud<UsuarioADO>, ICRUDOperations<UsuarioADO>
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Mail { get; set; }
        public int Telefono { get; set; }
        public string Nombre_usuario { get; set; }
        public string Clave { get; set; }

        public UsuarioADO(string nombre, string apellido, string mail, int? telefono, string nombre_usuario, string clave) : base("usuario", ["id", "nombre", "apellido", "mail", "telefono", "nombre_usuario", "clave"])
        {
            Nombre = nombre;
            Apellido = apellido;
            Mail = mail;
            Id = 0;
            if (telefono.HasValue)
            {
                Telefono = telefono.Value;
            }
            Nombre_usuario = nombre_usuario;
            Clave = clave;

        }
        public UsuarioADO(UsuarioADO usuario) : this(usuario.Nombre, usuario.Apellido, usuario.Mail, usuario.Telefono, usuario.Nombre_usuario, usuario.Clave)
        {
            Id = usuario.Id;
        }
        public bool Add()
        {
            DB.Insert($"{this.Nombre}", $"{this.Apellido}", $"{this.Mail}", this.Telefono, $"{this.Nombre_usuario}", $"{this.Clave}");
            return true;
        }

        public bool Delete()
        {
            DB.Drop("usuarios", "mail", this.Mail);
            return true;
        }

        public List<UsuarioADO> Select()
        {
            //var alumnos = DB.Select<Alumno>("SELECT * FROM alumnos");
            var alumnos = GetAll();
            return alumnos;
        }

        public bool Update()
        {
            return true;
        }

    }

}
