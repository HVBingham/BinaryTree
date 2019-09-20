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
        public Levels level;

        public BinaryTree()
        {
            root = null;
            level = new Levels();
            
     
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
        public void AddEdge(Node node, Node tempNode)
        {
          
            if (node == null)
            {
                node = tempNode;
            }
            if (tempNode.value < node.value)
            {
                if (node.left == null)
                {
                    tempNode=node.left;
                }
                else
                {  
                    AddEdge(node.left, tempNode);
                }
            }
            else
            {
                if (node.right == null)
                {
                    tempNode=node.right;

                }
                else
                {
                    AddEdge(node.right, tempNode);
                }
            }
        }
       
       
      public Node Search(int value)
        {
            Node tempNode = root;
            while (tempNode != null)
            {
                if (tempNode.value == value)
                {
                    return tempNode;
                }
                else if (value <= tempNode.value)
                {
                    tempNode = tempNode.left;
                    Console.WriteLine("left " +value +"");
                }
                else
                {
                    tempNode = tempNode.right;
                    Console.WriteLine("Right " +value +"");
                }
            }
            return null;
            
        }
    }
   
   
}
