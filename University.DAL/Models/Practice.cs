using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.DAL.Models
{
    public class Practice: Pair
    {
        public string HomeWork { get; set; }
        public string PracticeTask { get; set; }
    }
}
