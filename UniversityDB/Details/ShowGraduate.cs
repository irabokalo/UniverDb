using System.Windows.Forms;
using University.DAL.Models;

namespace UniversityDB.Details
{
    public partial class ShowGraduate : Form
    {
        public ShowGraduate()
        {
            InitializeComponent();
        }

        public ShowGraduate(GraduateViewModel Value)
        {
            InitializeComponent();

            typeName.Text = Value.TypeName;
            name.Text = Value.Name;
            surname.Text = Value.Surname;
            age.Text = Value.Age.ToString();
            subject.Text = Value.FavoriteSubject;
            mark.Text = Value.MediumMark.ToString();
            year.Text = Value.YearOfGraduation.ToString();


        }
    }
}
