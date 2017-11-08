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
    public partial class CreateEditLecture : Form
    {
        public LectureViewModel Value { get; set; }
        public CreateEditLecture()
        {
            InitializeComponent();
            Value = new LectureViewModel();
        }

        public CreateEditLecture(LectureViewModel Value)
        {
            this.Value = Value;
            InitializeComponent();

            uTitle.Text = Value.TypeName;
            duration.Text = Value.DurationInMinutes.ToString();
            room.Text = Value.RoomNumber.ToString();
            theory.Text = Value.TheoryInformation;
        }

        private void saveUObject_Click(object sender, EventArgs e)
        {
            Value.TypeName = uTitle.Text;
            Value.DurationInMinutes = Int32.Parse(duration.Text);
            Value.RoomNumber = Int32.Parse(room.Text);
            Value.TheoryInformation = theory.Text;
            Close();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CreateEditLecture_Load(object sender, EventArgs e)
        {

        }
    }
}
