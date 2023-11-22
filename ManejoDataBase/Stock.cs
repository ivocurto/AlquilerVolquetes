using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDataBase
{
    public class Stock : SQLCrud<Stock>, ICRUDOperations<Stock>
    {
        public string Producto { get; set; }
        public int Cantidad_disponible { get; set; }
        public int Cantidad_alquilados { get; set; }

        public Stock(string producto, int cantidad_disponible, int cantidad_alquilados) : base("stock", ["producto", "cantidad_disponible", "cantidad_alquilados"])
        {
            Producto = producto;
            Cantidad_disponible = cantidad_disponible;
            Cantidad_alquilados = cantidad_alquilados;
        }
        public bool Add()
        {
            DB.Insert(this.Producto, this.Cantidad_disponible, this.Cantidad_alquilados);
            return true;
        }

        public bool Delete()
        {
            //DB.Drop("hash_code", this.Hash_code);
            return true;
        }

        public List<Stock> Select()
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
