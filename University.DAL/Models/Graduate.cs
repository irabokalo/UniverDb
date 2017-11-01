using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.DAL.Models
{
    public class Graduate // :Student
    {
        [Key, ForeignKey("UniversityObject")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public int MediumMark { get; set; }
        public string FavoriteSubject { get; set; }
        public int YearOfGraduation { get; set; }
        public virtual UniversityObject UniversityObject { get; set; }
        public bool Sealed { get; set; }
    }
}
