using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public static class ManejoDeValidaciones
    {
        public static List<string> CrearListaDeDatos(params string[] datos)
        {
            return new List<string>(datos);
        }

        public static bool ValidarContraseña(List<string> datos)
        {
            return datos[1] == datos[3];
        }

        public static bool ComprobarStringVacio(List<string> lista)
        {
            return !lista.Any(s => string.IsNullOrEmpty(s));
        }

        public static bool ComprobarExistenciaUsuario(List<string> lista, List<Cliente> listaUsuarios)
        {
            if (listaUsuarios == null)
            {
                return true;
            }

            return !listaUsuarios.Any(usuario => usuario.NombreUsuario == lista[0] || usuario.MailUsuario == lista[2]);
        }
        public static bool ComprobarExistenciaAdmin(List<string> lista, List<Admin> listaUsuarios)
        {
            if (listaUsuarios == null)
            {
                return true;
            }

            return !listaUsuarios.Any(usuario => usuario.NombreUsuario == lista[0] || usuario.MailUsuario == lista[2]);
        }

        public static bool IsEmailFormat(string input)
        {
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";
            return System.Text.RegularExpressions.Regex.IsMatch(input, emailPattern);
        }

        public static bool VerificarEstadoTxtBox(string texto)
        {
            return string.IsNullOrWhiteSpace(texto);
        }
        public static bool VerificarNumeroTelefonico(string numero)
        {
            if (numero.Length != 10)
            {
                return false;
            }

            if (numero.StartsWith("11") && numero.Substring(2).All(char.IsDigit))
            {
                return true;
            }

            return false;
        }

    }
}
