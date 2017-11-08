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
    public partial class CreateEditPair : Form
    {
        public PairViewModel Value { get; set; }
        public CreateEditPair()
        {
            Value = new PairViewModel();
            InitializeComponent();
        }

        public CreateEditPair(PairViewModel Value)
        {
            this.Value = Value;
            InitializeComponent();

            uTitle.Text = Value.TypeName;
            duration.Text = Value.DurationInMinutes.ToString();
            room.Text = Value.RoomNumber.ToString();
        }

        private void saveUObject_Click(object sender, EventArgs e)
        {
            Value.TypeName = uTitle.Text;
            Value.DurationInMinutes = Int32.Parse(duration.Text);
            Value.RoomNumber = Int32.Parse(room.Text);

            Close();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Close_Click_1(object sender, EventArgs e)
        {

        }
    }
}
