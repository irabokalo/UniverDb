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
    public partial class ShowHuman : Form
    {
        public ShowHuman(HumanViewModel Value)
        {
            InitializeComponent();
            name.Text = Value.Name;
            surname.Text = Value.Surname;
            age.Text = Value.Age.ToString();
        }

    }
}
