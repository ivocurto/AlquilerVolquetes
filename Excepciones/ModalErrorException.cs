using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ModalErrorException : Exception
    {
        public ModalErrorException(string message) : base(message)
        {
        }
    }
}