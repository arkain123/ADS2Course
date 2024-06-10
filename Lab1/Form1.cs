using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab1
{
    public partial class Form1 : Form
    {
        readonly Tree theTree;

        public Form1()
        {
            theTree = new Tree(); //создание экземпляра дерева
            InitializeComponent();
        }

        public void DisplayTree(Node node, int indent, TreeNode treeNode)
        {
            if (node != null)
            {
                string indentation = new string(' ', indent * 2);
                TreeNode childNode = new TreeNode($"{indentation}{node.Value}"); // Добавляем цвет к тексту узла
                treeNode.Nodes.Add(childNode);
                DisplayTree(node.LeftChild, indent + 1, childNode);
                DisplayTree(node.RightChild, indent + 1, childNode);
            }
        }

        private void UpdateTreeView()
        {
            treeView1.Nodes.Clear();
            if (theTree.Root != null)
            {
                TreeNode rootNode = new TreeNode(theTree.Root.Value.ToString());
                rootNode.ForeColor = GetNodeColor(theTree.Root.IsRed);
                AddChildNodes(rootNode, theTree.Root);
                treeView1.Nodes.Add(rootNode);
            }
            treeView1.ExpandAll();
        }

        private Color GetNodeColor(bool isred)
        {
            return isred ? Color.Red : Color.Black;
        }

        private void AddChildNodes(TreeNode parentNode, Node node)
        {
            if (node.LeftChild != null)
            {
                TreeNode leftNode = new TreeNode(node.LeftChild.Value.ToString());
                leftNode.ForeColor = GetNodeColor(node.LeftChild.IsRed);
                parentNode.Nodes.Add(leftNode);
                AddChildNodes(leftNode, node.LeftChild);
            }
            if (node.RightChild != null)
            {
                TreeNode rightNode = new TreeNode(node.RightChild.Value.ToString());
                rightNode.ForeColor = GetNodeColor(node.RightChild.IsRed);
                parentNode.Nodes.Add(rightNode);
                AddChildNodes(rightNode, node.RightChild);
            }
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            theTree.Insert(Int32.Parse(keyTextBox.Text));
            keyTextBox.Clear();
            UpdateTreeView();
            nodesTextBox.Text = "Num of comparisons: " + theTree.comp.ToString();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            theTree.Remove(Int32.Parse(keyTextBox.Text));
            keyTextBox.Clear();
            UpdateTreeView();
            nodesTextBox.Text = "Num of comparisons: " + theTree.comp.ToString();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            nodesTextBox.Text = theTree.Find(Int32.Parse(keyTextBox.Text));
        }

        private void sumButton_Click(object sender, EventArgs e)
        {
            int n1 = theTree.Sum();
            nodesTextBox.Text = "Sum: " + n1.ToString();
        }

        private void PreOrderButton_Click(object sender, EventArgs e)
        {
            theTree.txtnodes = "";
            int sum = theTree.PreOrder(theTree.Root);
            nodesTextBox.Text = theTree.txtnodes.ToString() + " Comparisons: " + sum.ToString();
        }

        private void InOrderButton_Click(object sender, EventArgs e)
        {
            theTree.txtnodes = "";
            int sum = theTree.InOrder(theTree.Root);
            nodesTextBox.Text = theTree.txtnodes.ToString() + " Comparisons: " + sum.ToString();
        }

        private void PostOrderButton_Click(object sender, EventArgs e)
        {
            theTree.txtnodes = "";
            int sum = theTree.PostOrder(theTree.Root);
            nodesTextBox.Text = theTree.txtnodes.ToString() + " Comparisons: " + sum.ToString();
        }

        private void balanceButton_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            //theTree.Balance();
            TreeNode rootNode = new TreeNode($"{theTree.Root.Value}");
            treeView1.Nodes.Add(rootNode);
            DisplayTree(theTree.Root.LeftChild, 1, rootNode);
            DisplayTree(theTree.Root.RightChild, 1, rootNode);
            treeView1.ExpandAll();
        }
    }
}
