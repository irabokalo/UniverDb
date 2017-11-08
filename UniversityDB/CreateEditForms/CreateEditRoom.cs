using System;
using System.Windows.Forms;
using University.DAL.ViewModels;

namespace UniversityDB.CreateEditForms
{
    public partial class CreateEditRoom : Form
    {
        public RoomViewModel Value { get; set; }
        public CreateEditRoom()
        {
            InitializeComponent();
            Value = new RoomViewModel();
        }

        private void saveUObject_Click(object sender, EventArgs e)
        {
            Value.TypeName = uTitle.Text;
            Value.Number = Int32.Parse(number.Text);
            Close();
        }

        public CreateEditRoom(RoomViewModel Value)
        {
            InitializeComponent();
            this.Value = Value;
            uTitle.Text = Value.TypeName;
            number.Text = Value.Number.ToString();

        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
