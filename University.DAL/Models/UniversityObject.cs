using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.DAL.Models
{
    public class UniversityObject
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string TypeName { get; set; }
        public DateTime CreationDate { get; set; }
        [ForeignKey("Major")]
        public int? MajorId { get; set; }
        public virtual UniversityObject Major { get; set; }
        public bool Sealed { get; set; }
    }
}
