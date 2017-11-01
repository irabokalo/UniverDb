using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.DAL.Models
{
    public class Student : Human
    {
        public int MediumMark { get; set; }
        public string FavoriteSubject { get; set; }
    }
}
