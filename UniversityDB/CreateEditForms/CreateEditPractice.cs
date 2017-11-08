using System;
using System.Windows.Forms;
using University.DAL.Models;

namespace UniversityDB.CreateEditForms
{
    public partial class CreateEditPractice : Form
    {

        public PracticeViewModel Value { get; set; }
        public CreateEditPractice()
        {
            Value = new PracticeViewModel();
            InitializeComponent();
        }


        public CreateEditPractice(PracticeViewModel Value)
        {
            this.Value = Value;
            InitializeComponent();

            uTitle.Text = Value.TypeName;
            duration.Text = Value.DurationInMinutes.ToString();
            room.Text = Value.RoomNumber.ToString();
            practice.Text = Value.PracticeTask;
            homework.Text = Value.HomeWork;
        }

        private void saveUObject_Click(object sender, EventArgs e)
        {
            Value.TypeName = uTitle.Text;
            Value.DurationInMinutes = Int32.Parse(duration.Text);
            Value.RoomNumber = Int32.Parse(room.Text);
            Value.PracticeTask = practice.Text;
            Value.HomeWork = homework.Text;

            Close();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
