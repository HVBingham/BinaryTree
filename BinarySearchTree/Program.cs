using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree Tree = new BinaryTree();
            Tree.Add(100);
            Tree.Add(120);
            Tree.Add(50);
            Tree.Add(45);
            Tree.Add(46);
            Tree.Add(88);
            Tree.Add(119);
            Tree.Add(310);
            Tree.Search(45);
            Tree.Search(120);
            Console.ReadLine();
           
        }
    }
}
