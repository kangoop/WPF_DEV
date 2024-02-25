using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF_MVVM.Model;

namespace WPF_MVVM.ViewModel
{
    public class EmployeeVM : INotifyPropertyChanged
    {
        /*
         *         
        public int Id { get; set; }
        public string Name { get; set; }
        public Employee Supervisor { get; set; }
        public DateTime HireDate { get; set; }
        public decimal Vaction { get; set; }
         */
        public EmployeeVM()
        {                            
            _model = new Employee()
            {
                Id = 1,
                Name = "employee1",
                Supervisor = null,
                HireDate = new DateTime(1990, 01, 01),
                Vaction = 20.0M

            };
        }

        public EmployeeVM(Employee employee)
        {
            _model = employee;
        }

        private Employee _model;
        public Employee Employee
        {
            get
            {
                return _model;
            }
        }
        private CompanyProjects _projects;

        public string FormattedVactionBalance
        {
            get
            {
                decimal vactionBalance = _model.GetVacationBalanceInDays();

                return $"{_model.Name}-{Convert.ToInt64(vactionBalance)/7}주{Convert.ToInt64(vactionBalance%7)}일";
            }
        }

        public string Name
        {
            get
            {
                return _model.Name;
            }
            set
            {
                _model.Name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public bool IsSupervisor => _model.DirectReport.Any();

        public IEnumerable<string> ActiveProjects => _projects.All.Where(p => p.Ownder == _model.Id && p.Active).Select(p => p.Name);

        public void AddGiveBonusVaction()
        {
            if (_model.Vaction > 30M)
            {

            }
            else
            {
                _model.Vaction = _model.Vaction + 1;
               
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
           PropertyChanged(this,new PropertyChangedEventArgs(propertyName));
        }

      
    }
}
