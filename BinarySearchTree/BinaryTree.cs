using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class BinaryTree
    {
        public Node root;
        public BinaryTree()
        {
            root = null;
        }
        public void Add(int value)
        {
           
            if (root == null)
            {
                root =new Node(value);
                return;
            }
            AddEdge(root, new Node(value));
        }
        public void AddEdge(Node root, Node tempNode)
        {
            if (root == null)
            {
                root = tempNode;
            }
            if (tempNode.value < root.value)
            {
                if (root.left == null)
                {
                    root.left = tempNode;
                }
                else
                {
                    AddEdge(root.left, tempNode);
                }
            }
            if (tempNode.value > root.value)
            {
                if (root.right == null)
                {
                    root.right = tempNode;
                }
                else
                {
                    AddEdge(root.right, tempNode);
                }
            }
        }
    }
   
   
}
