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
    public partial class CreateEditEntrant : Form
    {
        public EntrantViewModel Value { get; set; }
        public CreateEditEntrant()
        {
            Value = new EntrantViewModel();
            InitializeComponent();
        }


        public CreateEditEntrant(EntrantViewModel Value)
        {
            this.Value = Value;
            InitializeComponent();
            uTitle.Text = Value.TypeName;
            name.Text = Value.Name;
            surname.Text = Value.Surname;
            age.Text = Value.Age.ToString();
            faculty.Text = Value.DesiredFaculty;
            school.Text = Value.School;
        }
        
        private void saveUObject_Click_1(object sender, EventArgs e)
        {
            Value.TypeName = uTitle.Text;
            Value.Name = name.Text;
            Value.Surname = surname.Text;
            Value.Age = Int32.Parse(age.Text);
            Value.DesiredFaculty = faculty.Text;
            Value.School = school.Text;
            Close();
        }

        private void Close_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
