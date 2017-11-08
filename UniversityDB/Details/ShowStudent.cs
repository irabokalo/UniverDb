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
    public partial class ShowStudent : Form
    {
        public ShowStudent()
        {
            InitializeComponent();
        }

        public ShowStudent(StudentViewModel Value)
        {

            InitializeComponent();

            typeName.Text = Value.TypeName;
            name.Text = Value.Name;
            surname.Text = Value.Surname;
            age.Text = Value.Age.ToString();
            subject.Text = Value.FavoriteSubject;
            mark.Text = Value.MediumMark.ToString();
        }
    }
}
