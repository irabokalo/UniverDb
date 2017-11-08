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
    public partial class CreateEditObject : Form
    {
        public UniversityObjectViewModel Value { get; set; }
        public CreateEditObject()
        {
            Value = new UniversityObjectViewModel();
            InitializeComponent();
        }

        public CreateEditObject(UniversityObjectViewModel Value)
        {
           this.Value = Value;
            InitializeComponent();
            uTitle.Text = Value.TypeName;
        }

        private void saveUObject_Click(object sender, EventArgs e)
        {   
            Value.TypeName = uTitle.Text;
            Close();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
