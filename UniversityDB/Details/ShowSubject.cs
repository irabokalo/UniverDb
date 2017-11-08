using System.Windows.Forms;
using University.DAL.Models;

namespace UniversityDB.Details
{
    public partial class ShowSubject : Form
    {
        public ShowSubject(SubjectViewModel Value )
        {
            InitializeComponent();
            typeName.Text = Value.TypeName;
            name.Text = Value.Name;
            description.Text = Value.Description;
        }
    }
}
