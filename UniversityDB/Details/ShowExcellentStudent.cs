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

namespace UniversityDB.Details
{
    public partial class ShowExcellentStudent : Form
    {
        public ShowExcellentStudent()
        {
            InitializeComponent();
        }

        public ShowExcellentStudent(ExcellentStudentViewModel Value)
        {
            InitializeComponent();

            uTitle.Text = Value.TypeName;
            name.Text = Value.Name;
            surname.Text = Value.Surname;
            age.Text = Value.Age.ToString();
            favoriteSubject.Text = Value.FavoriteSubject;
            mediumMark.Text = Value.MediumMark.ToString();
            scolarship.Text = Value.ScholarShip.ToString();
        }
    }
}
