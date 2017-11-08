using System;
using System.Windows.Forms;
using University.DAL.Models;

namespace UniversityDB.CreateEditForms
{
    public partial class CreateEditSubject : Form
    {
        public SubjectViewModel Value { get; set; }
        public CreateEditSubject()
        {
            InitializeComponent();
            Value = new SubjectViewModel();
        }

        public CreateEditSubject(SubjectViewModel Value)
        {
            InitializeComponent();
            this.Value = Value;
            uTitle.Text = Value.TypeName;
            name.Text = Value.Name;
            description.Text = Value.Description;
        }

        private void saveUObject_Click(object sender, EventArgs e)
        {
            Value.TypeName = uTitle.Text;
            Value.Name = name.Text;
            Value.Description = description.Text;
            Close();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
