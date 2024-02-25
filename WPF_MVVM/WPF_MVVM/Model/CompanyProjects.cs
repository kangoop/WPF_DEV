using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_MVVM.Model
{
    public class CompanyProjects
    {
        public IList<CompanyProject> All { get; set; }
    }

    public class CompanyProject
    {
        public int Ownder { get; set; }
        public bool Active { get; set; }
        public string Name { get; set; }
    }
}
