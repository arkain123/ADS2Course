using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Tree
    {
        public string txtnodes;
        public int comp = 0;

        public Node Root { get; private set; }

        public void Insert(int value)
        {
            comp = 0;
            Node newNode = new Node(value);
            if (Root == null)
            {
                Root = newNode;
                Root.IsRed = false;
            }
            else
            {
                InsertNode(Root, newNode);
                AdjustTreeAfterInsert(newNode);
            }
        }

        private void InsertNode(Node root, Node newNode)
        {
            if (newNode.Value < root.Value)
            {
                comp++;
                if (root.LeftChild == null)
                {
                    root.LeftChild = newNode;
                    newNode.Parent = root;
                }
                else
                {
                    InsertNode(root.LeftChild, newNode);
                }
            }
            else
            {
                if (root.RightChild == null)
                {
                    root.RightChild = newNode;
                    newNode.Parent = root;
                }
                else
                {
                    InsertNode(root.RightChild, newNode);
                }
            }
        }

        private void AdjustTreeAfterInsert(Node node)
        {
            while (node.Parent != null && node.Parent.IsRed == true)
            {
                if (node.Parent == node.Parent.Parent.LeftChild)
                {
                    Node uncle = node.Parent.Parent.RightChild;
                    if (uncle != null && uncle.IsRed == true)
                    {
                        node.Parent.IsRed = false;
                        uncle.IsRed = false;
                        node.Parent.Parent.IsRed = true;
                        node = node.Parent.Parent;
                    }
                    else
                    {
                        if (node == node.Parent.RightChild)
                        {
                            node = node.Parent;
                            RotateLeft(node);
                        }
                        node.Parent.IsRed = false;
                        node.Parent.Parent.IsRed = true;
                        RotateRight(node.Parent.Parent);
                    }
                }
                else
                {
                    Node uncle = node.Parent.Parent.LeftChild;
                    if (uncle != null && uncle.IsRed == true)
                    {
                        node.Parent.IsRed = false;
                        uncle.IsRed = false;
                        node.Parent.Parent.IsRed = true;
                        node = node.Parent.Parent;
                    }
                    else
                    {
                        if (node == node.Parent.LeftChild)
                        {
                            node = node.Parent;
                            RotateRight(node);
                        }
                        node.Parent.IsRed = false;
                        node.Parent.Parent.IsRed = true;
                        RotateLeft(node.Parent.Parent);
                    }
                }
            }
            Root.IsRed = false;
        }

        public bool Remove(int key)
        {
            // предполагается, что дерево не пусто
            Node current = Root;
            Node parent = Root;
            comp = 0;
            bool isLeftChild = true;
            while (current.Value != key)
            {
                parent = current;
                if (key < current.Value)
                {
                    comp++;
                    isLeftChild = true;
                    current = current.LeftChild;
                }
                else
                {
                    comp++;
                    isLeftChild = false;
                    current = current.RightChild;
                }
                if (current == null)
                    return false;
            }

            // Удаляемый узел найден
            // Если узел не имеет потомков
            if (current.LeftChild == null && current.RightChild == null)
            {
                if (current == Root)
                    Root = null;
                else if (isLeftChild)
                    parent.LeftChild = null;
                else
                    parent.RightChild = null;
            }
            // Если нет правого потомка, узел заменяется левым поддеревом
            else if (current.RightChild == null)
            {
                if (current == Root)
                    Root = current.LeftChild;
                else if (isLeftChild)
                    parent.LeftChild = current.LeftChild;
                else
                    parent.RightChild = current.LeftChild;
            }
            // Если нет левого потомка, узел заменяется правым поддеревом
            else if (current.LeftChild == null)
            {
                if (current == Root)
                    Root = current.RightChild;
                else if (isLeftChild)
                    parent.LeftChild = current.RightChild;
                else
                    parent.RightChild = current.RightChild;
            }
            else
            {
                Node successor = GetSuccessor(current);
                // Родитель current связывается с преемником
                if (current == Root)
                    Root = successor;
                else if (isLeftChild)
                    parent.LeftChild = successor;
                else
                    parent.RightChild = successor;
                // Преемник связывается с левым потомком current
                successor.LeftChild = current.LeftChild;
            }

            return true;
        }

        private Node GetSuccessor(Node delNode)
        {
            Node successorParent = delNode;
            Node successor = delNode;
            Node current = delNode.RightChild;          // Переход к правому потомку

            while (current != null)
            {
                successorParent = successor;
                successor = current;
                current = current.LeftChild;

            }
            // Если преемником не является
            if (successor != delNode.RightChild)    // Правым потомком
            {                                       // Создать связи между узлами
                successorParent.LeftChild = successor.RightChild;
                successor.RightChild = delNode.RightChild;
            }

            return successor;
        }

        private void RotateLeft(Node node)
        {
            Node pivot = node.RightChild;
            node.RightChild = pivot.LeftChild;
            if (pivot.LeftChild != null)
            {
                pivot.LeftChild.Parent = node;
            }
            pivot.Parent = node.Parent;
            if (node.Parent == null)
            {
                Root = pivot;
            }
            else if (node == node.Parent.LeftChild)
            {
                node.Parent.LeftChild = pivot;
            }
            else
            {
                node.Parent.RightChild = pivot;
            }
            pivot.LeftChild = node;
            node.Parent = pivot;
        }

        private void RotateRight(Node node)
        {
            Node pivot = node.LeftChild;
            node.LeftChild = pivot.RightChild;
            if (pivot.RightChild != null)
            {
                pivot.RightChild.Parent = node;
            }
            pivot.Parent = node.Parent;
            if (node.Parent == null)
            {
                Root = pivot;
            }
            else if (node == node.Parent.RightChild)
            {
                node.Parent.RightChild = pivot;
            }
            else
            {
                node.Parent.LeftChild = pivot;
            }
            pivot.RightChild = node;
            node.Parent = pivot;
        }

        public int InOrder(Node localRoot)
        {
            int sum = 0;
            if (localRoot != null)
            {
                sum += InOrder(localRoot.LeftChild);
                txtnodes += ("->" + localRoot.Value.ToString());
                sum += localRoot.Value;
                sum += InOrder(localRoot.RightChild);
            }
            return sum;
        }

        public int PreOrder(Node localRoot)
        {
            int sum = 0;
            if (localRoot != null)
            {
                txtnodes += ("->" + localRoot.Value.ToString());
                sum += localRoot.Value;
                sum += PreOrder(localRoot.LeftChild);
                sum += PreOrder(localRoot.RightChild);
            }
            return sum;
        }

        public int PostOrder(Node localRoot)
        {
            int sum = 0;
            if (localRoot != null)
            {
                sum += InOrder(localRoot.RightChild);
                txtnodes += ("->" + localRoot.Value.ToString());
                sum += localRoot.Value;
                sum += InOrder(localRoot.LeftChild);
            }
            return sum;
        }

        public int Sum()
        {
            return PostOrder(Root);
        }

        public string Find(int key)
        {
            Node current = Root;
            string nodesdata = Root.Value.ToString();
            while (current.Value != key)
            {
                if (key < current.Value)
                {

                    current = current.LeftChild;
                }
                else
                {
                    current = current.RightChild;
                }
                if (current == null)
                    return "Not found!";
                nodesdata += "->" + current.Value.ToString();
            }

            return nodesdata;
        }
    }
}
