namespace _321HW
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Node
    {
        public Node Left;
        public Node Right;
        public int Value;

        // Value constructor
        public Node(int value)
        {
            this.Left = null;
            this.Value = value;
            this.Right = null;
        }

        // Default constructor
        public Node()
        {
            this.Left = null;
            this.Right = null;
        }
    }
}
