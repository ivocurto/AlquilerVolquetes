using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDataBase
{
    public class Admin : SQLCrud<Admin>, ICRUDOperations<Admin>
    {
        public string Mail { get; set; }
        public string Nombre_admin { get; set; }
        public string Clave { get; set; }

        public Admin(string mail, string nombre_admin, string clave) : base("admins", ["mail", "nombre_admin", "clave"])
        {
            Mail = mail;
            Nombre_admin = nombre_admin;
            Clave = clave;
        }
        public bool Add()
        {
            DB.Insert(this.Mail, this.Nombre_admin, this.Clave);
            return true;
        }

        public bool Delete()
        {
            //DB.Drop("hash_code", this.Hash_code);
            return true;
        }

        public List<Admin> Select()
        {
            //var alumnos = DB.Select<Alumno>("SELECT * FROM alumnos");
            var stock = GetAll();
            return stock;
        }

        public bool Update()
        {
            return true;
        }
    }
}
