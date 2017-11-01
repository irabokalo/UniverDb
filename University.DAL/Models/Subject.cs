using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.DAL.Models
{
    public class Subject : UniversityObject
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
