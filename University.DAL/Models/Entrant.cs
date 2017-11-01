using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.DAL.Models
{
    public class Entrant : Human
    {
        public string DesiredFaculty { get; set; }
        public string School { get; set; }
    }
}
