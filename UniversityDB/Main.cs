
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
            InitializeComponent();
            
            
            InitializeTree();
            InitializeComponent();
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
                    CreateEditUniversityObj uObjWindow = new CreateEditUniversityObj();
                    if (uObjWindow.ShowDialog() == DialogResult.OK)
                    {
                        uObjWindow.Value.MajorId = majorId;
                        _repo.CreateUniversityObject(uObjWindow.Value);
                        id = uObjWindow.Value.Id;
                        title = uObjWindow.Value.TypeName;
                    }
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

    }





    public class NodeInfo
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public bool Expanded { get; set; }
    }

}
   