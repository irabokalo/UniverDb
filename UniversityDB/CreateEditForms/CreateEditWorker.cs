using System;
using System.Windows.Forms;
using University.DAL.Models;

namespace UniversityDB.CreateEditForms
{
    public partial class CreateEditWorker : Form
    {
        public WorkerViewModel Value { get; set; }

        public CreateEditWorker()           
        {
            Value = new WorkerViewModel();
            InitializeComponent();
        }

        public CreateEditWorker(WorkerViewModel Value)
        {
            this.Value = Value;
            InitializeComponent();
            uTitle.Text = Value.TypeName;
            name.Text = Value.Name;
            surname.Text = Value.Surname;
            age.Text = Value.Age.ToString();
            Education.Text = Value.Education;
        }

        private void saveUObject_Click(object sender, EventArgs e)
        {
            Value.TypeName = uTitle.Text;
            Value.Name = name.Text;
            Value.Surname = surname.Text;
            Value.Age = Int32.Parse(age.Text);
            Value.Education = Education.Text;
            Close();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
