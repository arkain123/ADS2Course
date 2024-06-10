using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Node
    {
        public int Value { get; set; }
        public bool IsRed { get; set; }
        public Node Parent { get; set; }
        public Node LeftChild { get; set; }
        public Node RightChild { get; set; }

        public Node(int value)
        {
            Value = value;
            IsRed = true;
            Parent = null;
            LeftChild = null;
            RightChild = null;
        }
    }
}
