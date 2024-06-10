using System;

namespace TwoThreeFourTree
{
    class Program
    {
        static void Main(string[] args)
        {
            TwoThreeFourTree tree = new TwoThreeFourTree();

            int[] numbers = { 10, 5, 15, 3, 7, 12, 20, 2, 4, 6, 8, 11, 13, 17, 25 };

            foreach (int number in numbers)
            {
                tree.Insert(number);
                Console.WriteLine("After inserting {0}:", number);
                tree.Display();
                Console.WriteLine();
            }
        }
    }

    class Node
    {
        public int[] data;
        public Node[] child;
        public Node parent;
        public int numItems;

        public Node()
        {
            data = new int[3];
            child = new Node[4];
            numItems = 0;
            parent = null;
        }
    }

    class TwoThreeFourTree
    {
        private Node root;

        public TwoThreeFourTree()
        {
            root = null;
        }

        public void Insert(int value)
        {
            Node currentNode = root;

            if (root == null)
            {
                root = new Node();
                root.data[0] = value;
                root.numItems = 1;
            }
            else
            {
                while (true)
                {
                    if (currentNode.child[0] == null)
                    {
                        InsertIntoNode(currentNode, value, null);
                        break;
                    }
                    else
                    {
                        currentNode = GetNextChild(currentNode, value);
                    }
                }
            }
        }

        public void InsertIntoNode(Node node, int value, Node childNode)
        {
            if (node.numItems < 3)
            {
                node.data[node.numItems++] = value;
                if (childNode != null)
                {
                    node.child[node.numItems] = childNode;
                }
                Array.Sort(node.data, 0, node.numItems);
            }
            else
            {
                Split(node, value, childNode);
            }
        }

        public Node GetNextChild(Node node, int value)
        {
            for (int i = 0; i < node.numItems; i++)
            {
                if (value < node.data[i])
                {
                    return node.child[i];
                }
            }
            return node.child[node.numItems];
        }

        public void Split(Node node, int value, Node childNode)
        {
            if (node.parent == null)
            {
                Node newRoot = new Node();
                newRoot.data[0] = node.data[1];
                newRoot.child[0] = node;
                node.parent = newRoot;
                root = newRoot;
            }

            Node newRightNode = new Node();
            newRightNode.data[0] = node.data[2];

            if (node == node.parent.child[0])
            {
                node.parent.child[1] = newRightNode;
            }
            else if (node == node.parent.child[1])
            {
                node.parent.child[2] = newRightNode;
            }

            InsertIntoNode(node.parent, node.data[1], newRightNode);

            Node parent = node.parent;
            Node newChild2 = parent.child[1];
            Node newChild3 = parent.child[2];

            if (value < parent.data[0])
            {
                if (parent.child[0] == null)
                {
                    parent.child[0] = new Node();
                }
                InsertIntoNode(parent.child[0], value, childNode);
            }
            else if (value < parent.data[1])
            {
                if (newChild2 == null)
                {
                    parent.child[1] = new Node();
                }
                InsertIntoNode(newChild2, value, childNode);
            }
            else
            {
                if (newChild3 == null)
                {
                    parent.child[2] = new Node();
                }
                InsertIntoNode(newChild3, value, childNode);
            }
        }


        public void Display()
        {
            Display(root, 0);
        }

        private void Display(Node node, int level)
        {
            if (node != null)
            {
                for (int i = 0; i < level; i++)
                {
                    Console.Write("    ");
                }

                for (int i = 0; i < node.numItems; i++)
                {
                    Console.Write(node.data[i] + " ");
                }
                Console.WriteLine();

                level++;

                for (int i = 0; i <= node.numItems; i++)
                {
                    Display(node.child[i], level);
                }
            }
        }
    }
}