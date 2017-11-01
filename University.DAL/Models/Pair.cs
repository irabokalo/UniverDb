using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.DAL.Models
{
    public class Pair: UniversityObject
    {
        public int RoomNumber { get; set; }
        public int DurationInMinutes { get; set; }
    }
}
