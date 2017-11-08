using System;
using System.Windows.Forms;
using University.DAL.Models;

namespace UniversityDB.CreateEditForms
{
    public partial class CreateEditHuman : Form
    {
        public HumanViewModel Value { get; set; }
        public CreateEditHuman()
        {
            Value = new HumanViewModel();
            InitializeComponent();
        }

        public CreateEditHuman(HumanViewModel Value)
        {
            InitializeComponent();
            this.Value = Value;
           

            uTitle.Text = Value.TypeName;
            name.Text = Value.Name;
            surname.Text = Value.Surname;
            age.Text = Value.Age.ToString();
        }

        private void CreateEditHuman_Load(object sender, EventArgs e)
        {
            
        }

        private void saveUObject_Click(object sender, EventArgs e)
        {
            Value.TypeName = uTitle.Text;
            Value.Name = name.Text;
            Value.Surname = surname.Text;
            Value.Age = Int32.Parse(age.Text);
            Close();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
