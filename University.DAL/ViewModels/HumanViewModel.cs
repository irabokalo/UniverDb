using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.DAL.Models
{
    public class HumanViewModel : UniversityObjectViewModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
    }
}
