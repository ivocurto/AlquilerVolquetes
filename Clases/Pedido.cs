using Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Pedido
    {
        private string cliente;
        private List<Volquete> volquetesPedidos;
        private List<Volquete> volquetesInstalados;
        private int idCliente;
       

        public Pedido(List<Volquete> volquetesPedidos, List<Volquete> volquetesInstalados, string cliente) 
        {
            this.volquetesPedidos = volquetesPedidos;
            this.volquetesInstalados = volquetesInstalados;
            this.cliente = cliente;            
        }

        public List<Volquete> VolquetesPedidos { get => volquetesPedidos; set => volquetesPedidos = value; }
        public List<Volquete> VolquetesInstalados { get => volquetesInstalados; set => volquetesInstalados = value; }
        public string Cliente { get => cliente; set => cliente = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }
    }
}
