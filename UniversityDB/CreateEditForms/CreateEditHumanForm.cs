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
    public partial class CreateEditHumanForm : Form
    {
        HumanViewModel Value;
        public CreateEditHumanForm()
        {
            InitializeComponent();

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Name ==  "tabPageUniversity")
            {

            }
        }
    }
}
