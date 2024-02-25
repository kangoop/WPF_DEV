using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF5_DAY2_1
{
    public class Employee
    {
        public string EmployeeName { get; set; }

        public override string ToString()
        {
            return EmployeeName;
        }
    }
}
