
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using University.DAL.Models;

namespace University.DAL.ViewModels
{
    public class RoomViewModel : UniversityObjectViewModel
    {
        public int Number { get; set; }
    }


}
