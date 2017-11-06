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
    public partial class CreateEditGraduate : Form
    {
        public GraduateViewModel Value { get; set; }
        public CreateEditGraduate()
        {
            Value = new GraduateViewModel();
            InitializeComponent();
        }

        private void saveUObject_Click(object sender, EventArgs e)
        {
            Value.TypeName = uTitle.Text;
            Value.Name = name.Text;
            Value.Surname = surname.Text;
            Value.Age = Int32.Parse(age.Text);
            Value.FavoriteSubject = favoriteSubject.Text;
            Value.MediumMark = Int32.Parse(mediumMark.Text);
            Value.YearOfGraduation = Int32.Parse(year.Text);
            Close();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    
    }
}
