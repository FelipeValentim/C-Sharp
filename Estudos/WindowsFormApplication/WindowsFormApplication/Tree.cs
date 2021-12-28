using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormApplication
{
    public partial class Tree : Form
    {
        public Tree()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void buttonTree_Click(object sender, EventArgs e)
        {
            MessageBox.Show(LerChecados(treeView1.Nodes[0]));
            //MessageBox.Show(LerChecados(treeView1.Nodes[2]));

        }

        private string LerChecados(TreeNode node, string checkeds = "")
        {
            foreach (TreeNode treeNode in node.Nodes)
            {
                if (treeNode.Parent.Checked)
                {
                    checkeds += treeNode.Parent.Text + ", ";
                }
                
                if (treeNode.Checked)
                {
                    checkeds += treeNode.Text + ", ";
                }
                checkeds = LerChecados(treeNode, checkeds);
            }
            return checkeds;
        }

        private void Tree_Load(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            treeView1.Nodes.Add("Estudos");
            var node = treeView1.Nodes[0];
            loadDiretorios(@"C:\Projetos\Estudos\", ref node);
        }

        private void loadDiretorios(string diretorio, ref TreeNode node)
        {
            string[] arquivos = Directory.GetFiles(diretorio);
            foreach (string arquivo in arquivos)
            {
                node.Nodes.Add(Path.GetFileName(arquivo));
            }

            // Recursão do diretorio depois de pegar o arquivo do diretório atual
            string[] subdiretorios = Directory.GetDirectories(diretorio);
            foreach (string subdiretorio in subdiretorios)
            {
                TreeNode n = new TreeNode(Path.GetFileName(subdiretorio));
                loadDiretorios(subdiretorio, ref n);
                node.Nodes.Add(n);
            }
        }

        private void buttonDiretorio_Click(object sender, EventArgs e)
        {

        }
    }
}
