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
    public partial class CreateEditHuman : CreateEditUniversityObj
    {
        public new HumanViewModel Value;


        public CreateEditHuman()
        {
            InitializeComponent();
            AddEvents();

            Text = "Create Person";
            okBtn.Enabled = Verify_Person();
        }

        public CreateEditHuman(HumanViewModel person)
        {
            InitializeComponent();
            AddEvents();

            Value = person;
            ShowInfo();

            Text = "Edit Person";
            okBtn.Enabled = Verify_Person();
        }

        private void AddEvents()
        {
            // UObject
            textBox1.TextChanged -= SomethingChanged_UObject;
            textBox1.TextChanged += SomethingChanged_Person;

            // Person
            name.TextChanged += SomethingChanged_Person;
            Surname.TextChanged += SomethingChanged_Person;
            textBox2.TextChanged += SomethingChanged_Person;


            // btnOk
            okBtn.Click -= btnOk_Click_UObject;
            okBtn.Click += btnOk_Click_Person;
        }

        protected void SomethingChanged_Person(object sender, EventArgs e)
        {
            okBtn.Enabled = Verify_Person();
        }

        protected bool Verify_Person()
        {
            return Verify_UObject() &&
                name.Text.Length > 0 &&
                Surname.Text.Length > 0 &&
                textBox2.Text.Length > 0;
        }

        protected void btnOk_Click_Person(object sender, EventArgs e)
        {
            if (Value == null)
            {
                Value = new HumanViewModel();
            }

            FillObject(Value);

            Close();
        }

        private void ShowInfo()
        {
            name.Text = Value.Name;
            Surname.Text = Value.Surname;
            textBox2.Text =  Value.Age.ToString();
        }

        protected void FillObject(HumanViewModel person)
        {
            base.FillObject(person);

            person.Name = name.Text;
            person.Surname = Surname.Text;
            person.Age = Int32.Parse(textBox2.Text);
        }

        private void okBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
