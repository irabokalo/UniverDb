using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University.DAL.Models
{
    public class Human //: UniversityObject
    {
        [Key, ForeignKey("UniversityObject")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public virtual UniversityObject UniversityObject { get; set; }
        public bool Sealed { get; set; }
    }
}
