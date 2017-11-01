using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.DAL.Models
{
    public class UniversityObjectViewModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string TypeName { get; set; }
        public DateTime CreationDate { get; set; }
        public int? MajorId { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime LastWriteTime { get; set; }

    }
}
