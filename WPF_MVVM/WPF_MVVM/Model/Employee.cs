using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_MVVM.Model
{
    public class Employee
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public Employee Supervisor { get; set; }
        public DateTime HireDate { get; set; }
        public decimal Vaction { get; set; }

        public void Clock() { 
        
        }

        public decimal GetVacationBalanceInDays()
        {
            return Vaction;
        }

        public IList<Employee> DirectReport
        {
            get
            {
                return Supervisor.DirectReport;
            }
        }
    }
}
