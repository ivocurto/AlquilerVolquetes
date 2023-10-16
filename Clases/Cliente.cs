using Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Cliente : Usuario
    {
        private List<Volquete> volquetesPedidos;
        private List<Volquete> volquetesInstalados;
        private string direccion;
        private string telefono;
        private int valorCompra;

        

        public Cliente(string nombreUsuario, string mailUsusario, string claveUsuario,ERolUsuario rol , List<Volquete> volquetesPedidos, List<Volquete> volquetesInstalados, string direccion, string telefono, int valorCompra) : base(nombreUsuario, mailUsusario, claveUsuario, rol)
        {
            this.volquetesPedidos = volquetesPedidos;
            this.volquetesInstalados = volquetesInstalados;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.ValorCompra = valorCompra;
        }

        public List<Volquete> VolquetesPedidos { get => volquetesPedidos; set => volquetesPedidos = value; }
        public List<Volquete> VolquetesInstalados { get => volquetesInstalados; set => volquetesInstalados = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public int ValorCompra { get => valorCompra; set => valorCompra = value; }
    }
}
