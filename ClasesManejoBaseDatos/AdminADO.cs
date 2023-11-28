using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesManejoBaseDatos
{
    public class AdminADO : SQLCrud<AdminADO>, ICRUDOperations<AdminADO>
    {
        public string Mail { get; set; }
        public string Nombre_admin { get; set; }
        public string Clave { get; set; }
        public int Id { get; set; }

        public AdminADO() : base("admins", new[] { "id", "mail", "nombre_admin", "clave" })
        {
        }
        public AdminADO(string mail, string nombre_admin, string clave) : base("admins", ["mail", "nombre_admin", "clave"])
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
            DB.Drop("id", this.Id);
            return true;
        }

        public List<AdminADO> Select()
        {
            var stock = GetAll();
            return stock;
        }

        public bool Update()
        {
            return true;
        }
    }
}
