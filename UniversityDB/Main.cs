
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using University.DAL;
using University.DAL.Models;
using UniversityDB.CreateEditForms;
using UniversityDB.Details;

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
                "Worker",
                "Excellent Student",
                "Worker",
                "Pair",
                "Lecture",
                "Practice",
                "Room"
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

        private List<string> GetTypesOfEntities()
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

                case "Room":
                    CreateEditRoom room = new CreateEditRoom();
                    room.ShowDialog();
                    room.Value.MajorId = majorId;
                    id = _repo.CreateRoom(room.Value);
                    title = room.Value.TypeName;
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
                case "Worker":
                    CreateEditWorker WorkerWindow = new CreateEditWorker();
                    WorkerWindow.ShowDialog();
                    WorkerWindow.Value.MajorId = majorId;
                    id = _repo.CreateWorker(WorkerWindow.Value);
                    title = WorkerWindow.Value.TypeName;
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

                case "University Object":
                    ShowObject uObjWnd = new ShowObject(_repo.GetUObjectById(id));
                    uObjWnd.ShowDialog();
                    break;
                case "Human":
                    ShowHuman personWnd = new ShowHuman(_repo.GetHumanById(id));
                    personWnd.ShowDialog();
                    break;
                case "Subject":
                    ShowSubject workerWnd = new ShowSubject(_repo.GetSubjectById(id));
                    workerWnd.ShowDialog();
                    break;
                case "Worker":
                    ShowWorker WorkerWnd = new ShowWorker(_repo.GetWorkerById(id));
                    WorkerWnd.ShowDialog();
                    break;
                case "Graduate":
                    ShowGraduate graduateWnd = new ShowGraduate(_repo.GetGraduateById(id));
                    graduateWnd.ShowDialog();
                    break;
                case "Entrant":
                    ShowEntrant entrantWnd = new ShowEntrant(_repo.GetEntrantById(id));
                    entrantWnd.ShowDialog();
                    break;
                case "Student":
                    ShowStudent studentWnd = new ShowStudent(_repo.GetStudentById(id));
                    studentWnd.ShowDialog();
                    break;
                case "Pair":
                    ShowPair pairWnd = new ShowPair(_repo.GetPairById(id));
                    pairWnd.ShowDialog();
                    break;
                case "Practice":
                    ShowPractice practiceWnd = new ShowPractice(_repo.GetPracticeById(id));
                    practiceWnd.ShowDialog();
                    break;
                case "Lecture":
                    ShowLecture lectureWnd = new ShowLecture(_repo.GetLectureById(id));
                    lectureWnd.ShowDialog();
                    break;
                case "Room":
                    ShowRoom room = new ShowRoom(_repo.GetRoomById(id));
                    room.ShowDialog();
                    break;
                case "Excellent Student":
                    ShowExcellentStudent fStudentWnd = new ShowExcellentStudent(_repo.GetExcellentStudentById(id));
                    fStudentWnd.ShowDialog();
                    break;
                default:
                    throw new ArgumentException();
            }
        }
        

        private void Edit(string type, int id)
        {
            switch (type)
            {
                case "University Object":
                    CreateEditObject uObjWindow = new CreateEditObject(_repo.GetUObjectById(id));
                    if (uObjWindow.ShowDialog() == DialogResult.OK)
                    {
                        _repo.UpdateUObject(uObjWindow.Value);
                        tree.SelectedNode.Text = uObjWindow.Value.TypeName;
                    }
                    break;
                case "Human":
                    CreateEditHuman personWindow = new CreateEditHuman(_repo.GetHumanById(id));
                    personWindow.ShowDialog();

                    _repo.UpdatePerson(personWindow.Value);
                    tree.SelectedNode.Text = personWindow.Value.TypeName;

                    break;

                case "Room":
                    CreateEditRoom roomWindow = new CreateEditRoom(_repo.GetRoomById(id));
                    roomWindow.ShowDialog();
                    _repo.UpdateRoom(roomWindow.Value);
                    tree.SelectedNode.Text = roomWindow.Value.TypeName;

                    break;
                case "Subject":
                    CreateEditSubject workerWindow = new CreateEditSubject(_repo.GetSubjectById(id));
                    workerWindow.ShowDialog();
                    _repo.UpdateSubject(workerWindow.Value);
                    tree.SelectedNode.Text = workerWindow.Value.TypeName;

                    break;
                case "Worker":
                    CreateEditWorker WorkerWindow = new CreateEditWorker(_repo.GetWorkerById(id));
                    WorkerWindow.ShowDialog();

                    _repo.UpdateWorker(WorkerWindow.Value);
                    tree.SelectedNode.Text = WorkerWindow.Value.TypeName;

                    break;
                case "Entrant":
                    CreateEditEntrant entrantWindow = new CreateEditEntrant(_repo.GetEntrantById(id));
                    entrantWindow.ShowDialog();

                    _repo.UpdateEntrant(entrantWindow.Value);
                    tree.SelectedNode.Text = entrantWindow.Value.TypeName;

                    break;
                case "Graduate":
                    CreateEditGraduate graduateWindow = new CreateEditGraduate(_repo.GetGraduateById(id));
                    graduateWindow.ShowDialog();
                    _repo.UpdateGraduate(graduateWindow.Value);
                    tree.SelectedNode.Text = graduateWindow.Value.TypeName;

                    break;

                case "Student":
                    CreateEditStudent studentWindow = new CreateEditStudent(_repo.GetStudentById(id));
                    studentWindow.ShowDialog();
                    _repo.UpdateStudent(studentWindow.Value);
                    tree.SelectedNode.Text = studentWindow.Value.TypeName;

                    break;

                case "Pair":
                    CreateEditPair pairWindow = new CreateEditPair(_repo.GetPairById(id));
                    pairWindow.ShowDialog();
                    _repo.UpdatePair(pairWindow.Value);
                    tree.SelectedNode.Text = pairWindow.Value.TypeName;
                    break;

                case "Practice":
                    CreateEditPractice practiceWindow = new CreateEditPractice(_repo.GetPracticeById(id));
                    practiceWindow.ShowDialog();
                    _repo.UpdatePractice(practiceWindow.Value);
                    tree.SelectedNode.Text = practiceWindow.Value.TypeName;
                    break;

                case "Lecture":
                    CreateEditLecture lectureWindow = new CreateEditLecture(_repo.GetLectureById(id));
                    lectureWindow.ShowDialog();
                    _repo.UpdateLecture(lectureWindow.Value);
                    tree.SelectedNode.Text = lectureWindow.Value.TypeName;
                    break;

                case "Excellent Student":
                    CreateEditExcellentStudent foreignStudentWindow = new CreateEditExcellentStudent(_repo.GetExcellentStudentById(id));
                    foreignStudentWindow.ShowDialog();
                    _repo.UpdateExcellentStudent(foreignStudentWindow.Value);
                    tree.SelectedNode.Text = foreignStudentWindow.Value.TypeName;
                    break;

                default:
                    throw new ArgumentException();
            }
        }

        private void Delete(string type, int id)
        {
            DialogResult result = MessageBox.Show("Are you sure you want delete the object?",
                "Delete object", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                switch (type)
                {
                    case "University Object":
                        _repo.DeleteUObject(id);
                        break;
                    case "Subject":
                        _repo.DeleteSubject(id);
                        break;
                    case "Human":
                        _repo.DeletePerson(id);
                        break;
                    case "Student":
                        _repo.DeleteStudent(id);
                        break;
                    case "Entrant":
                        _repo.DeleteEntrant(id);
                        break;
                    case "Worker":                      
                        _repo.DeleteWorker(id);
                        break;
                    case "Excellent Student":
                        _repo.DeleteExcellentStudent(id);
                        break;
                    case "Graduate":
                        _repo.DeleteGraduate(id);
                        break;
                    case "Pair":
                        _repo.DeletePair(id);
                        break;
                    case "Lecture":
                        _repo.DeleteLecture(id);
                        break;
                    case "Practice":
                        _repo.DeletePractice(id);
                        break;
                    case "Room":
                        _repo.DeleteRoom(id);
                        break;
                    default:
                        throw new ArgumentException();
                }

                foreach (KeyValuePair<string, IEnumerable<UniversityObjectViewModel>> pair in _repo.GetAllObjectsByMajor(id))
                {
                    foreach (UniversityObjectViewModel uobj in pair.Value)
                    {
                        uobj.MajorId = null;
                        _repo.UpdateUObject(uobj);
                        TreeNode node = tree.Nodes.Add(uobj.TypeName); // Зміни не відображаються. Чомусь.
                        node.Tag = new NodeInfo { Id = uobj.Id, Type = pair.Key, Expanded = false };
                    }
                }

                tree.SelectedNode.Remove();
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            Select window = new Select(GetTypesOfEntities());
            window.ShowDialog();
            Create(window.SelectedType, null);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            NodeInfo info = (NodeInfo)tree.SelectedNode.Tag;

            Select window = new Select(GetTypesOfEntities());

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
            Delete(info.Type, info.Id);
        }

    }

    public class NodeInfo
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public bool Expanded { get; set; }
    }

}
