using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.DAL.Models
{
    public class GraduateViewModel : StudentViewModel
    {
        public int YearOfGraduation { get; set; }
    }
}
