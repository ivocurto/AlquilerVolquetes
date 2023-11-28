using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class AdminConteiner
    {
        public bool CheckboxValue;
        public Admin AdminObject;
        public AdminConteiner(Admin adminObject, bool checkboxValue)
        {
            CheckboxValue = checkboxValue;
            AdminObject = adminObject;
        }
    }
}
