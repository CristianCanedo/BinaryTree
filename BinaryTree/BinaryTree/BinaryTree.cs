using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class BinaryTree
    {
        public Node Root { get; set; }

        public BinaryTree()
        {
            Root = null;
        }
        public BinaryTree(int value)
        {
            Root = new Node(value);
        }

        public bool InsertValue(int value)
        {
            Node toInsert = new Node(value);
            Node current = Root;
            bool inserted = false;

            while (!inserted)
            {
                if (value < current.Data)
                {
                    if (current.Left == null)
                    {
                        current.Left = toInsert;
                        return inserted = true;
                    }
                    else
                    {
                        current = current.Left;
                    }
                }
                if (value >= current.Data)
                {
                    if (current.Right == null)
                    {
                        current.Right = toInsert;
                        return inserted = true;
                    }
                    else
                    {
                        current = current.Right;
                    }
                }
            }
            return inserted;
        }

        
        public void PrintTree(Node node)
        {
            if (node == null)
            {
                node = Root;
            }

            if (node.Left != null)
            {
                PrintTree(node.Left);
                Console.Write(" " + node.Data);
            }
            else
            {
                Console.Write(" " + node.Data);
            }

            if (node.Right != null)
            {
                PrintTree(node.Right);
            }

        }
        

    }
}
