using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{

    public class Volquete
    {
        private int id;
        private int cantidad;
        private string medidaVolquete;
        private int precioUnitario;

        public Volquete(int id, string medidaVolquete, int precioUnitario)
        {
            this.Id = id;
            this.Cantidad = 0;
            this.MedidaVolquete = medidaVolquete;
            this.PrecioUnitario = precioUnitario;
        }
        public int Id { get => id; set => id = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public string MedidaVolquete { get => medidaVolquete; set => medidaVolquete = value; }
        public int PrecioUnitario { get => precioUnitario; set => precioUnitario = value; }
        public override string ToString()
        {
            return $"{Cantidad} {MedidaVolquete} ${PrecioUnitario * Cantidad}";
        }
    }
        
}
