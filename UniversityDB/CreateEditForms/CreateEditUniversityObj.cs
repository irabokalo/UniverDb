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
    public partial class CreateEditUniversityObj : Form
    {
        public UniversityObjectViewModel Value;
        public CreateEditUniversityObj()
        {
            InitializeComponent();
            AddEvents();

            Text = "Create UObject";
           Ok.Enabled = Verify_UObject();
        }

        public CreateEditUniversityObj(UniversityObjectViewModel obj)
        {
            InitializeComponent();
            AddEvents();

            Value = obj;
            ShowInfo();

            Text = "Edit UObject";
            Ok.Enabled = Verify_UObject();
        }

        private void AddEvents()
        {
            // UObject
            textBox1.TextChanged += SomethingChanged_UObject;

            // btnOk
            Ok.Click += btnOk_Click_UObject;
        }

        protected void SomethingChanged_UObject(object sender, EventArgs e)
        {
            Ok.Enabled = Verify_UObject();
        }

        protected bool Verify_UObject()
        {
            return textBox1.Text.Length > 0;
        }

        protected void btnOk_Click_UObject(object sender, EventArgs e)
        {
            if (Value == null)
            {
                Value = new UniversityObjectViewModel();
            }

            FillObject(Value);

            Close();
        }

        private void ShowInfo()
        {
            textBox1.Text = Value.TypeName;
        }

        protected void FillObject(UniversityObjectViewModel uObj)
        {
            uObj.TypeName = textBox1.Text;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
