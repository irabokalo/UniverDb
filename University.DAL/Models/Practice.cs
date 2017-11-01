using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.DAL.Models
{
    public class Practice//: Pair
    {
        [Key, ForeignKey("UniversityObject")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string HomeWork { get; set; }
        public string PracticeTask { get; set; }
        public bool Sealed { get; set; }
        public int RoomNumber { get; set; }
        public int DurationInMinutes { get; set; }
        public virtual UniversityObject UniversityObject { get; set; }

    }
}
