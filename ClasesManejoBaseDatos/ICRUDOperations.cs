using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesManejoBaseDatos
{
    internal interface ICRUDOperations<T>
    {
        bool Add();

        bool Update();

        bool Delete();

        List<T> Select();
    }
}
