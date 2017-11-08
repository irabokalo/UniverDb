using System;
using System.Windows.Forms;
using University.DAL.Models;

namespace UniversityDB.CreateEditForms
{
    public partial class CreateEditExcellentStudent : Form
    {
        public ExcellentStudentViewModel Value { get; set; }
        public CreateEditExcellentStudent()
        {
            Value = new ExcellentStudentViewModel();
            InitializeComponent();
        }

        public CreateEditExcellentStudent(ExcellentStudentViewModel Value)
        {
            this.Value = Value;
            InitializeComponent();

            uTitle.Text = Value.TypeName;
            name.Text = Value.Name;
            surname.Text = Value.Surname;
            age.Text = Value.Age.ToString();
            favoriteSubject.Text = Value.FavoriteSubject;
            mediumMark.Text = Value.MediumMark.ToString();
            scolarship.Text = Value.ScholarShip.ToString();
        }

        private void saveUObject_Click_1(object sender, EventArgs e)
        {
            Value.TypeName = uTitle.Text;
            Value.Name = name.Text;
            Value.Surname = surname.Text;
            Value.Age = Int32.Parse(age.Text);
            Value.FavoriteSubject = favoriteSubject.Text;
            Value.MediumMark = Int32.Parse(mediumMark.Text);
            Value.ScholarShip = Int32.Parse(scolarship.Text);
            Close();
        }

        private void Close_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
