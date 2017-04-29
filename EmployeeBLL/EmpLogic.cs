using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeBLL
{
    public class EmpLogic
    {
        public string getEmpFullName(int id)
        {
            if (id == 1)
                return "xyz";
            else
                return "abc";
        }
    }
}
