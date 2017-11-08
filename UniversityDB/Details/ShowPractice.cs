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
    public partial class ShowPractice : Form
    {
        public ShowPractice()
        {
            InitializeComponent();
        }


        public ShowPractice(PracticeViewModel Value)
        {
            InitializeComponent();

            uTitle.Text = Value.TypeName;
            duration.Text = Value.DurationInMinutes.ToString();
            room.Text = Value.RoomNumber.ToString();
            practice.Text = Value.PracticeTask;
            homework.Text = Value.HomeWork;
        }
    }
}
