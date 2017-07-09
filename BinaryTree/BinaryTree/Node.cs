﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class Node
    {
        public int? Data { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node() { }
        public Node(int value)
        {
            Data = value;
            Left = null;
            Right = null;
        }
    }
}
