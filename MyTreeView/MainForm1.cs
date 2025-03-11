using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLib;
using ClassLib.Models;

namespace MyTreeView
{
    public partial class MainForm1 : Form
    {
        private List<TreeNodeModel> treeData_;
        private ArtistsModel artistsModel_;
        public MainForm1()
        {
            InitializeComponent();

            treeData_ = new List<TreeNodeModel>();

            artistsModel_ = new ArtistsModel();
        }

        private void MainForm1_Load(object sender, EventArgs e)
        {
            {
                treeData_.Add(new TreeNodeModel("Исскуство"));
                var artNode = treeData_[0];
                var artists = artNode.AddChildNode("Художники");
                artists.AddChildNode("Винсент Ван Гог");
                artists.AddChildNode("Леонардо Да Винчи");
                artists.AddChildNode("Сальвадора Дали");

                var countries = artNode.AddChildNode("Страны");
                countries.AddChildNode("Нидерланды");
                countries.AddChildNode("Италия");
                countries.AddChildNode("Испания");

                var picture = artNode.AddChildNode("Картины");
                picture.AddChildNode("Звездная ночь");
                picture.AddChildNode("Мона Лиза");
                picture.AddChildNode("Постоянство памяти");
            }
        
            FillTreeNodeCollection(treeData_, MyTreeView.Nodes);
            treeView1.ExpandAll();
            Table.DataSource = artistsModel_.Artists;
            FillTableAliases();
        }

        static private void FillTreeNodeCollection(List<TreeNodeModel> sourceData, TreeNodeCollection targetData) 
        {
            foreach (var node in sourceData)
            {
                var treeNode = new TreeNode(node.Name);
                targetData.Add(treeNode); 

                if (node.Children != null && node.Children.Count > 0)
                {
                    FillTreeNodeCollection(node.Children, treeNode.Nodes); 
                }
            }
        }

        private void FillTableAliases()
        {
            foreach (DataGridViewColumn column in Table.Columns)
            {
                if (Artist.Aliases.TryGetValue(column.Name, out string alias))
                {
                    column.HeaderText = alias;
                }
            }


            Table.Columns[Table.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }  
    }
}
