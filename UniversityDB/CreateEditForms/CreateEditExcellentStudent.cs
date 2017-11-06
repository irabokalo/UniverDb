using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
