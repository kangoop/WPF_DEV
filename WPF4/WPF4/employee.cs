using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF4
{
    class employee
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public override string ToString()
        {
            return $"{FirstName},{LastName}";
        }

        public void SayHello()
        {
            System.Windows.MessageBox.Show("Hello");
        }


    }
}
