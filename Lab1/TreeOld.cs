//using System;
//using System.Collections.Generic;
//using System.ComponentModel.Design;
//using System.Linq;
//using System.Runtime.InteropServices;
//using System.Runtime.Remoting.Messaging;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using System.Windows.Forms.VisualStyles;

//namespace Lab1
//{
//    internal class Tree
//    {
//        public Node root;
//        public string txtnodes = "";
//        public int comp = 0;
        
//        public void Insert(int key)
//        {
//            Node newNode = new Node(key);
//            // Создание узла
//            newNode.LeftChild = null;
//            newNode.RightChild = null;
//            comp = 0;
            
//            if (root == null) // Если корневой узел не существует
//            {
//                root = newNode;
//                root.IsRed = false;
//            } else            // Корневой узел существует
//            {
//                Node current = root;
//                Node parent;

//                while(true)
//                {
//                    parent = current;       // запоминаем родителя
//                    if (key < current.Key)  // движение налево
//                    {
//                        comp++;
//                        current = current.LeftChild;
//                        if (current == null)// Достигнут конец ветви
//                        {
//                            if (parent.IsRed)
//                                newNode.IsRed = false;
//                            else
//                                newNode.IsRed = true;
//                            parent.LeftChild = newNode; // Вставка узла
//                            newNode.IsRed = false;
//                            return;
//                        }
//                    } else                  // Движение направо
//                    {
//                        comp++;
//                        current = current.RightChild;
//                        if (current == null)
//                        {
//                            if (parent.IsRed)
//                                newNode.IsRed = false;
//                            else
//                                newNode.IsRed = true;
//                            parent.RightChild = newNode;
//                            return;
//                        }
//                    }
//                }
//            }
//        }

//        private void AdjustTreeAfterInsert(Node node)
//        {
//            while (node.Parent != null && node.Parent.Color == NodeColor.Red)
//            {
//                if (node.Parent == node.Parent.Parent.LeftChild)
//                {
//                    Node uncle = node.Parent.Parent.RightChild;
//                    if (uncle != null && uncle.Color == NodeColor.Red)
//                    {
//                        node.Parent.Color = NodeColor.Black;
//                        uncle.Color = NodeColor.Black;
//                        node.Parent.Parent.Color = NodeColor.Red;
//                        node = node.Parent.Parent;
//                    }
//                    else
//                    {
//                        if (node == node.Parent.RightChild)
//                        {
//                            node = node.Parent;
//                            RotateLeft(node);
//                        }
//                        node.Parent.Color = NodeColor.Black;
//                        node.Parent.Parent.Color = NodeColor.Red;
//                        RotateRight(node.Parent.Parent);
//                    }
//                }
//                else
//                {
//                    Node uncle = node.Parent.Parent.LeftChild;
//                    if (uncle != null && uncle.Color == NodeColor.Red)
//                    {
//                        node.Parent.Color = NodeColor.Black;
//                        uncle.Color = NodeColor.Black;
//                        node.Parent.Parent.Color = NodeColor.Red;
//                        node = node.Parent.Parent;
//                    }
//                    else
//                    {
//                        if (node == node.Parent.LeftChild)
//                        {
//                            node = node.Parent;
//                            RotateRight(node);
//                        }
//                        node.Parent.Color = NodeColor.Black;
//                        node.Parent.Parent.Color = NodeColor.Red;
//                        RotateLeft(node.Parent.Parent);
//                    }
//                }
//            }
//            Root.Color = NodeColor.Black;
//        }

//        public bool Remove(int key)
//        {
//            // предполагается, что дерево не пусто
//            Node current = root;
//            Node parent = root;
//            comp = 0;
//            bool isLeftChild = true;
//            while (current.Key != key)
//            {
//                parent = current;
//                if (key < current.Key)
//                {
//                    comp++;
//                    isLeftChild = true;
//                    current = current.LeftChild;
//                } else
//                {
//                    comp++;
//                    isLeftChild = false;
//                    current = current.RightChild;
//                }
//                if (current == null)
//                    return false;
//            }

//            // Удаляемый узел найден
//            // Если узел не имеет потомков
//            if (current.LeftChild == null && current.RightChild == null)
//            {
//                if (current == root)
//                    root = null;
//                else if (isLeftChild)
//                    parent.LeftChild = null;
//                else
//                    parent.RightChild = null;
//            }
//            // Если нет правого потомка, узел заменяется левым поддеревом
//            else if (current.RightChild == null)
//            {
//                if (current == root)
//                    root = current.LeftChild;
//                else if (isLeftChild)
//                    parent.LeftChild = current.LeftChild;
//                else
//                    parent.RightChild = current.LeftChild;
//            }
//            // Если нет левого потомка, узел заменяется правым поддеревом
//            else if (current.LeftChild == null)
//            {
//                if (current == root)
//                    root = current.RightChild;
//                else if (isLeftChild)
//                    parent.LeftChild = current.RightChild;
//                else
//                    parent.RightChild = current.RightChild;
//            }
//            else
//            {
//                Node successor = GetSuccessor(current);
//                // Родитель current связывается с преемником
//                if (current == root)
//                    root = successor;
//                else if (isLeftChild)
//                    parent.LeftChild = successor;
//                else
//                    parent.RightChild = successor;
//                // Преемник связывается с левым потомком current
//                successor.LeftChild = current.LeftChild;
//            }

//            return true;
//        }

//        private Node GetSuccessor(Node delNode)
//        {
//            Node successorParent = delNode;
//            Node successor = delNode;
//            Node current = delNode.RightChild;          // Переход к правому потомку
            
//            while (current != null)
//            {
//                successorParent = successor;
//                successor = current;
//                current = current.LeftChild;

//            }
//                                                    // Если преемником не является
//            if (successor != delNode.RightChild)    // Правым потомком
//            {                                       // Создать связи между узлами
//                successorParent.LeftChild = successor.RightChild;
//                successor.RightChild = delNode.RightChild;
//            }

//            return successor;
//        }

//        public string Find(int key)
//        {
//            Node current = root;
//            string nodesdata = root.key.ToString();
//            while (current.Key != key)
//            {
//                if (key < current.Key)
//                {

//                    current = current.LeftChild;
//                }
//                else
//                {
//                    current = current.RightChild;
//                }
//                if (current == null)
//                    return "Not found!";
//                nodesdata += "->" + current.key.ToString();
//            }

//            return nodesdata;
//        }

//        public int InOrder(Node localRoot)
//        {
//            int sum = 0;
//            if (localRoot != null)
//            {
//                sum += InOrder(localRoot.LeftChild);
//                txtnodes += ("->" + localRoot.Key.ToString());
//                sum += localRoot.Key;
//                sum += InOrder(localRoot.RightChild);
//            }
//            return sum;
//        }

//        public int PreOrder(Node localRoot)
//        {
//            int sum = 0;
//            if (localRoot != null)
//            {
//                txtnodes += ("->" + localRoot.Key.ToString());
//                sum += localRoot.Key;
//                sum += PreOrder(localRoot.LeftChild);
//                sum += PreOrder(localRoot.RightChild);
//            }
//            return sum;
//        }

//        public int PostOrder(Node localRoot)
//        {
//            int sum = 0;
//            if (localRoot != null)
//            {
//                sum += InOrder(localRoot.RightChild);
//                txtnodes += ("->" + localRoot.Key.ToString());
//                sum += localRoot.Key;
//                sum += InOrder(localRoot.LeftChild);
//            }
//            return sum;
//        }

//        public int Sum()
//        {
//            return PostOrder(root);
//        }

//        private void GetArr(Node node, int[] Arr, ref int n)
//        {
//            if (node != null)
//            {
//                GetArr(node.LeftChild, Arr, ref n);
//                Arr[n++] = node.Key;
//                GetArr(node.RightChild, Arr, ref n);
//            }
//        }

//        private Node BuildBalancedTree(int[] sortedElements, int left, int right)
//        {
//            if (left > right)
//            {
//                return null;
//            }

//            int mid = (left + right) / 2;
//            Node newNode = new Node(sortedElements[mid]);
//            newNode.LeftChild = BuildBalancedTree(sortedElements, left, mid - 1);
//            newNode.RightChild = BuildBalancedTree(sortedElements, mid + 1, right);

//            return newNode;
//        }

//        private int GetNodeCount(Node node)
//        {
//            if (node == null)
//            {
//                return 0;
//            }

//            return 1 + GetNodeCount(node.LeftChild) + GetNodeCount(node.RightChild);
//        }

//        public void Balance()
//        {
//            int[] sortedElements = new int[GetNodeCount(root)];
//            int index = 0;
//            GetArr(root, sortedElements, ref index);

//            root = BuildBalancedTree(sortedElements, 0, sortedElements.Length - 1);
//        }
//    }
//}
