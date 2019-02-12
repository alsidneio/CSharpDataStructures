using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_structures_and_algorithms
{
    class BST
    {
        // A binary tree is just a collection of Binary Tree Nodes with a 
        // "Root" node as the access point to the rest of the tree.

        private TreeNode root;

        public BST()
        {
            root = null;
        }

        public void PreOrder()
        {
            PreOrder(root);
            Console.WriteLine("========== Traversal Finished ==========");
        }
        private void PreOrder(TreeNode Node)
        {
            if (Node == null)
            {
                return;
            }

            Console.WriteLine(Node.data);
            PreOrder(Node.left);
            PreOrder(Node.right);
        }
        //===================== START OF TRAVERSAL METHODS==========================================//
        public void PostOrder()
        {
            PostOrder(root);
            Console.WriteLine("========== Traversal Finished ==========");
        }
        private void PostOrder(TreeNode Node)
        {
            if (Node == null)
            {
                return;
            }

            PostOrder(Node.left);
            PostOrder(Node.right);
            Console.WriteLine(Node.data);
        }
        public void InOrder()
        {
            InOrder(root);
            Console.WriteLine("========== Traversal Finished ==========");
        }
        private void InOrder(TreeNode Node)
        {
            if (Node == null)
            {
                return;
            }

            InOrder(Node.left);
            Console.WriteLine(Node.data);
            InOrder(Node.right);
            
        }

        //====================================== END OF TRAVERSAL METHODS =======================//


        //Add a node to the BST
        public void Insert(int key)
        {
            TreeNode newNode = new TreeNode(key);

            if(root== null)
            {
                root = newNode;
            }
            else
            {
                TreeNode current = root;
                TreeNode Parent;
                while(true)
            }
        }



    }
}
