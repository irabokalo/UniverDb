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

        public CreateEditGraduate(GraduateViewModel Value)
        {
            this.Value = Value;
            InitializeComponent();
            uTitle.Text = Value.TypeName;
            name.Text = Value.Name;
            surname.Text = Value.Surname;
            age.Text = Value.Age.ToString();
            favoriteSubject.Text = Value.FavoriteSubject;
            mediumMark.Text = Value.MediumMark.ToString();
            year.Text = Value.YearOfGraduation.ToString();
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
