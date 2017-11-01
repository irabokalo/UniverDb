using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University.DAL.Models
{
    public class Student //: Human
    {
        [Key, ForeignKey("UniversityObject")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public int MediumMark { get; set; }
        public string FavoriteSubject { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public virtual UniversityObject UniversityObject { get; set; }
        public bool Sealed { get; set; }
    }
}
