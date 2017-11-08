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
    public partial class ShowEntrant : Form
    {
        public ShowEntrant()
        {
            InitializeComponent();
        }

        public ShowEntrant(EntrantViewModel Value)
        {
            InitializeComponent();
            typeName.Text = Value.TypeName;
            name.Text = Value.Name;
            surname.Text = Value.Surname;
            age.Text = Value.Age.ToString();
            faculty.Text = Value.DesiredFaculty;
            school.Text = Value.School;
        }
    }
}
