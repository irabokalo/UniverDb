using System.Windows.Forms;
using University.DAL.ViewModels;

namespace UniversityDB.Details
{
    public partial class ShowRoom : Form
    {
        public ShowRoom()
        {
            InitializeComponent();
        }

        public ShowRoom(RoomViewModel Value)
        {
            InitializeComponent();

            uTitle.Text = Value.TypeName;
            number.Text = Value.Number.ToString();

        }
    }
}
