using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree btree = new BinaryTree(50);
            Console.WriteLine(btree.InsertValue(51));
            Console.WriteLine(btree.InsertValue(49));
            Console.WriteLine(btree.InsertValue(52));
            Console.WriteLine(btree.InsertValue(48));
            Console.WriteLine(btree.InsertValue(34));
            Console.WriteLine(btree.InsertValue(22));
            Console.WriteLine(btree.InsertValue(18));
            Console.WriteLine(btree.InsertValue(10));

            btree.PrintTree(btree.Root);

            Console.WriteLine();

        }
    }
}
