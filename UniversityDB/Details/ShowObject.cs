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

namespace UniversityDB.Details
{
    public partial class ShowObject : Form
    {
        public UniversityObjectViewModel Value { get; set; }
        public ShowObject()
        {
            Value = new UniversityObjectViewModel();
            InitializeComponent();
        }

        public ShowObject(UniversityObjectViewModel Value)
        {
            this.Value = Value;
            InitializeComponent();
            typeName.Text = Value.TypeName;
        }
    }
}
