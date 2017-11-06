
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using University.DAL;
using University.DAL.Models;
using UniversityDB.CreateEditForms;

namespace UniversityDB
{
    public partial class Main : Form
    {
        private UniversityRepository _repo;

        private List<string> TypesOfEntities = new List<string>
            {
                "University Object",
                "Human",
                "Subject",
                "Student",
                "Entrant",
                "Graduate",
                "Teacher",
                "Excellent Student",
                "Teacher",
                "Pair",
                "Lecture",
                "Practice"
            };

        private ContextMenu contextMenu;

        public Main()
        {
            _repo = new UniversityRepository();

            MenuItem details = new MenuItem("Details", btnDetails_Click);
            MenuItem create = new MenuItem("Create", btnCreate_Click);
            MenuItem edit = new MenuItem("Edit", btnEdit_Click);
            MenuItem delete = new MenuItem("Delete", btnDelete_Click);
            contextMenu = new ContextMenu(new MenuItem[] { create, details, edit, delete });


            InitializeComponent();


            InitializeTree();
            //  InitializeComponent();
        }

        private List<string> GetTypesOfEntities(string parentType)
        {
            return TypesOfEntities;
        }

        private void InitializeTree()
        {
            foreach (KeyValuePair<string, IEnumerable<UniversityObjectViewModel>> pair in _repo.GetAllObjectsByMajor(null))
            {
                foreach (UniversityObjectViewModel uobj in pair.Value)
                {
                    TreeNode node = tree.Nodes.Add(uobj.TypeName);
                    node.Tag = new NodeInfo { Id = uobj.Id, Type = pair.Key, Expanded = false };

                    foreach (KeyValuePair<string, IEnumerable<UniversityObjectViewModel>> pair2 in _repo.GetAllObjectsByMajor(uobj.Id))
                    {
                        foreach (UniversityObjectViewModel uobj2 in pair2.Value)
                        {
                            TreeNode node2 = node.Nodes.Add(uobj2.TypeName);
                            node2.Tag = new NodeInfo { Id = uobj2.Id, Type = pair2.Key, Expanded = false };
                        }
                    }
                }
            }
        }

        private void tree_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            NodeInfo info1 = (NodeInfo)e.Node.Tag;
            if (!info1.Expanded)
            {
                foreach (TreeNode node2 in e.Node.Nodes)
                {
                    NodeInfo info2 = (NodeInfo)node2.Tag;
                    foreach (KeyValuePair<string, IEnumerable<UniversityObjectViewModel>> pair in _repo.GetAllObjectsByMajor(info2.Id))
                    {
                        foreach (UniversityObjectViewModel uobj in pair.Value)
                        {
                            TreeNode node3 = node2.Nodes.Add(uobj.TypeName);
                            node3.Tag = new NodeInfo { Id = uobj.Id, Type = pair.Key, Expanded = false };
                        }
                    }
                }

                info1.Expanded = true;
            }
        }

        private void tree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right && tree.SelectedNode != null)
            {
                contextMenu.Show(tree, e.Location);
            }
        }



        private void Create(string type, TreeNode parent)
        {
            int id = 0;
            string title = "";
            int? majorId = parent == null
                ? null
                : (int?)((NodeInfo)parent.Tag).Id;

            switch (type)
            {
                case "University Object":
                    CreateEditObject uObjWindow = new CreateEditObject();
                    uObjWindow.ShowDialog();
                    uObjWindow.Value.MajorId = majorId;
                    id = _repo.CreateUniversityObject(uObjWindow.Value);
                    title = uObjWindow.Value.TypeName;
                    break;

                case "Human":
                    CreateEditHuman personWindow = new CreateEditHuman();
                    personWindow.ShowDialog();
                    personWindow.Value.MajorId = majorId;
                    id = _repo.CreateHuman(personWindow.Value);
                    title = personWindow.Value.TypeName;
                    break;
                case "Subject":
                    CreateEditSubject SubjectWindow = new CreateEditSubject();
                    SubjectWindow.ShowDialog();
                    SubjectWindow.Value.MajorId = majorId;
                    id = _repo.CreateSubject(SubjectWindow.Value);
                    title = SubjectWindow.Value.TypeName;
                    break;
                case "Student":
                    CreateEditStudent studentWindow = new CreateEditStudent();
                    studentWindow.ShowDialog();
                    studentWindow.Value.MajorId = majorId;
                    id = _repo.CreateStudent(studentWindow.Value);          
                    title = studentWindow.Value.TypeName;
                    break;
                case "Entrant":
                    CreateEditEntrant entrantWindow = new CreateEditEntrant();
                    entrantWindow.ShowDialog();
                    entrantWindow.Value.MajorId = majorId;
                    id = _repo.CreateEntrant(entrantWindow.Value);               
                    title = entrantWindow.Value.TypeName;
                    break;
                case "Teacher":
                    CreateEditTeacher teacherWindow = new CreateEditTeacher();
                    teacherWindow.ShowDialog();
                    teacherWindow.Value.MajorId = majorId;
                    id = _repo.CreateTeacher(teacherWindow.Value);
                    title = teacherWindow.Value.TypeName;
                    break;
                case "Pair":
                    CreateEditPair pairWindow = new CreateEditPair();
                    pairWindow.ShowDialog();
                    pairWindow.Value.MajorId = majorId;
                    id = _repo.CreatePair(pairWindow.Value);
                    title = pairWindow.Value.TypeName;
                    break;
                case "Practice":
                    CreateEditPractice practiceWindow = new CreateEditPractice();
                    practiceWindow.ShowDialog();
                    practiceWindow.Value.MajorId = majorId;
                    id = _repo.CreatePractice(practiceWindow.Value);
                    title = practiceWindow.Value.TypeName;
                    break;
                case "Lecture":
                    CreateEditLecture LectureWindow = new CreateEditLecture();
                    LectureWindow.ShowDialog();
                    LectureWindow.Value.MajorId = majorId;
                    id = _repo.CreateLecture(LectureWindow.Value);
                    title = LectureWindow.Value.TypeName;
                    break;
                case "Graduate":
                    CreateEditGraduate GraduateWindow = new CreateEditGraduate();
                    GraduateWindow.ShowDialog();
                    GraduateWindow.Value.MajorId = majorId;
                    id = _repo.CreateGraduate(GraduateWindow.Value);
                    title = GraduateWindow.Value.TypeName;
                    break;
                case "Excellent Student":
                    CreateEditExcellentStudent excellentStudentWindow = new CreateEditExcellentStudent();
                    excellentStudentWindow.ShowDialog();
                    excellentStudentWindow.Value.MajorId = majorId;
                    id = _repo.CreateExcellentStudent(excellentStudentWindow.Value);
                    title = excellentStudentWindow.Value.TypeName;
                    break;



            }

            if (id != 0)
            {
                TreeNode current = parent == null
                ? tree.Nodes.Add(title)
                : parent.Nodes.Add(title);

                current.Tag = new NodeInfo { Id = id, Type = type, Expanded = true };
            }

        }

        private void ShowDetails(string type, int id)
        {
            switch (type)
            {

            }
        }

        private void Edit(string type, int id)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            Select window = new Select(GetTypesOfEntities("root"));

            window.ShowDialog();
            Create(window.SelectedType, null);


        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            NodeInfo info = (NodeInfo)tree.SelectedNode.Tag;

            Select window = new Select(GetTypesOfEntities(info.Type));

            window.ShowDialog();
            Create(window.SelectedType, tree.SelectedNode);

        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            NodeInfo info = (NodeInfo)tree.SelectedNode.Tag;
            ShowDetails(info.Type, info.Id);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            NodeInfo info = (NodeInfo)tree.SelectedNode.Tag;
            Edit(info.Type, info.Id);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            NodeInfo info = (NodeInfo)tree.SelectedNode.Tag;
            //  Delete(info.Type, info.Id);
        }


    }

    public class NodeInfo
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public bool Expanded { get; set; }
    }

}
