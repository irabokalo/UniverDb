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
    public partial class CreateEditHuman : Form
    {
        public new HumanViewModel Value;


        //public CreateEditHuman()
        //{
        //    InitializeComponent();
        //    AddEvents();

        //    Text = "Create Person";
        //    btnOk.Enabled = Verify_Person();
        //}

        //public CreateEditHuman(HumanViewModel person) : base(person)
        //{
        //    InitializeComponent();
        //    AddEvents();

        //    Value = person;
        //    ShowInfo();

        //    Text = "Edit Person";
        //    okBtn.Enabled = Verify_Person();
        //}

        //private void AddEvents()
        //{
        //    // UObject
        //    textBox1.TextChanged -= SomethingChanged_UObject;
        //    txtForTitle.TextChanged += SomethingChanged_Person;

        //    // Person
        //    datePickerForBirthday.ValueChanged += SomethingChanged_Person;
        //    txtForName.TextChanged += SomethingChanged_Person;
        //    txtForSurname.TextChanged += SomethingChanged_Person;
        //    txtForPatronymic.TextChanged += SomethingChanged_Person;

        //    // btnOk
        //    btnOk.Click -= btnOk_Click_UObject;
        //    btnOk.Click += btnOk_Click_Person;
        //}

        //protected void SomethingChanged_Person(object sender, EventArgs e)
        //{
        //    btnOk.Enabled = Verify_Person();
        //}

        //protected bool Verify_Person()
        //{
        //    return Verify_UObject() &&
        //        txtForName.Text.Length > 0 &&
        //        txtForSurname.Text.Length > 0 &&
        //        txtForPatronymic.Text.Length > 0;
        //}

        //protected void btnOk_Click_Person(object sender, EventArgs e)
        //{
        //    if (Value == null)
        //    {
        //        Value = new Person();
        //    }

        //    FillObject(Value);

        //    Close();
        //}

        //private void ShowInfo()
        //{
        //    txtForName.Text = Value.Name;
        //    txtForSurname.Text = Value.Surname;
        //    txtForPatronymic.Text = Value.Patronymic;
        //    datePickerForBirthday.Value = Value.Birthday;
        //    radioForGender_Female.Checked = !(radioForGender_Male.Checked = Value.Gender);
        //}

        //protected void FillObject(Person person)
        //{
        //    base.FillObject(person);

        //    person.Name = txtForName.Text;
        //    person.Surname = txtForSurname.Text;
        //    person.Patronymic = txtForPatronymic.Text;
        //    person.Birthday = datePickerForBirthday.Value;
        //    person.Gender = radioForGender_Male.Checked;
        //}

    }
}
