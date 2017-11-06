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
    public partial class CreateEditSubject : Form
    {
        public SubjectViewModel Value { get; set; }
        public CreateEditSubject()
        {
            InitializeComponent();
            Value = new SubjectViewModel();
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
