namespace _321HW
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class BST
    {
        public Node Root = null;
        public int Count = 0;

        // Constructor with value
        public BST(int val)
        {
            this.Root = new _321HW.Node(val);
        }

        // Default constructor
        public BST()
        {
            this.Root = null;
        }

        // Adds value to list from the root
        public void Add(int value, ref Node root)
        {
            // Check if at destination
            if (root == null)
            {
                root = new _321HW.Node(value);
                this.Count++;
            }

            // Check if new value is greater than current
            else if (root.Value < value)
            {
                this.Add(value, ref root.Right);
            }

            // Check if new value is less than current
            else if (root.Value > value)
            {
                this.Add(value, ref root.Left);
            }
        }

        // Prints BST in order
        public void Print(Node newNode)
        {
            if (newNode != null)
            {
                this.Print(newNode.Left);
                Console.Write(newNode.Value.ToString());
                this.Print(newNode.Right);
            }

        }

        // Traverses list in order to add items for full printing
        public void TraverseInOrder(ref Node newNode, ref List<int> list)
        {
            if (newNode != null)
            {
                this.TraverseInOrder(ref newNode.Left, ref list);
                list.Add(newNode.Value);
                this.TraverseInOrder(ref newNode.Right, ref list);
            }
        }

        // Returns root
        public Node GetRoot()
        {
            return this.Root;
        }
    }
}
