using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class DataContainer
    {
        public bool CheckboxValue;
        public Usuario UserObject;

        public DataContainer(bool checkboxValue, Usuario userObject)
        {
            CheckboxValue = checkboxValue;
            UserObject = userObject;
        }
    }
}
