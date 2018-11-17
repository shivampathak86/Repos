using System;


namespace BinaryTree
{
   

       public class BinaryTree
        {
           public Node root;

            void mirror()
            {
                root = mirror(root);
            }

            public Node mirror(Node node)
            {
                if (node == null)
                    return node;

                /* do the subtrees */
                Node left = mirror(node.left);
                Node right = mirror(node.right);

                /* swap the left and right pointers */
                node.left = right;
                node.right = left;

                return node;
            }

           public void inOrder()
            {
                InOrder(root);
            }

            /* Helper function to test mirror(). Given a binary 
            search tree, print out its data elements in 
            increasing sorted order.*/
           public void InOrder(Node node)
            {
                if (node == null)
                    return;

                InOrder(node.left);
                Console.Write(node.data + " ");

                InOrder(node.right);
            }
            static void Main(string[] args)
        {
            /* creating a binary tree and entering the nodes */
            BinaryTree tree = new BinaryTree();
            tree.root = new Node(1);
            tree.root.left = new Node(2);
            tree.root.right = new Node(3);
            tree.root.left.left = new Node(4);
            tree.root.left.right = new Node(5);
            Console.Write("Inorder traversal of input tree is :");
            tree.inOrder();
            Console.WriteLine("");

            /* convert tree to its mirror */
            tree.mirror();
            /* print inorder traversal of the minor tree */
           Console.Write("Inorder traversal of binary tree is : ");
            tree.inOrder();
            Console.Read();

        }
    }






  public class Node
    { 
	  public int data;
      public  Node left, right;


    public Node(int item)
    {
        data = item;
        left = right = null;
    }

}
} 


