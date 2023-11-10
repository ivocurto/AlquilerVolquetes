using Clases;
using System;
using System.Collections.Generic;
using System.Data;
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
        private int idPedido;
        private int index;
        private DateTime fechaPedido;
        private DateTime fechaEntrega;
       

        public Pedido(List<Volquete> volquetesPedidos, List<Volquete> volquetesInstalados, string cliente, DateTime fechaPedido, DateTime fechaEntrega) 
        {
            this.volquetesPedidos = volquetesPedidos;
            this.volquetesInstalados = volquetesInstalados;
            this.cliente = cliente;            
            this.FechaPedido = fechaPedido;
            this.fechaEntrega = fechaEntrega;
        }

        public List<Volquete> VolquetesPedidos { get => volquetesPedidos; set => volquetesPedidos = value; }
        public List<Volquete> VolquetesInstalados { get => volquetesInstalados; set => volquetesInstalados = value; }
        public string Cliente { get => cliente; set => cliente = value; }
        public int IdPedido { get => idPedido; set => idPedido = value; }
        public DateTime FechaPedido { get => fechaPedido; set => fechaPedido = value; }
        public DateTime FechaEntrega { get => fechaEntrega; set => fechaEntrega = value; }
        public int Index { get => index; set => index = value; }

        public static bool operator -(Pedido pedido, DateTime fecha)
        {
            return fecha > pedido.FechaEntrega;
        }
        public static int operator +(Pedido pedido, DateTime fechaActual)
        {
            if (fechaActual < pedido.FechaEntrega)
            {
                TimeSpan diferencia = pedido.FechaEntrega - fechaActual;
                return diferencia.Days;
            }
            else
            {
                return -1; 
            }
        }

        public void GenerarIdPedido(List<int> ids)
        {
            int id;
            Random random = new Random();

            do
            {
                id = random.Next(0, 100000); 
            } while (ids.Contains(id)); 

            ids.Add(id);
            idPedido = id;
        }

        public int CalcularPrecioPedido()
        {
            return 0;
        }


    }
}
