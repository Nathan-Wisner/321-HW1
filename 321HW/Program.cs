namespace _321HW
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class Program
    {
        private static string Input
        {
            get
            {
                // Ask user for input
                Console.WriteLine("Enter a collection of numbers in the range of 0 - 100 seperated by spaces: ");

                // Read in input from user
                string value = Console.ReadLine();

                return value;
            }
        }

        private static void Main(string[] args)
        {
            // Create a tree using BST
            BST tree = new BST();

            // Get the input
            string input = Input;

            // Loop until there is an input, checks for null cases
            while (string.IsNullOrEmpty(input))
            {
                input = Input;
            }

            // Split the values into a string array
            string[] splitStrings = input.Split(null);

            // For every string in the array, add it to our tree
            foreach (string s in splitStrings)
            {
                tree.Add(int.Parse(s), ref tree.Root);
            }

            // Print the Tree contents
            Console.Write("Tree Contents: ");

            tree.Print(tree.GetRoot());

            // Add space before text
            Console.WriteLine();

            // Calculate mininum possible height
            int minLayers = (int)Math.Ceiling(Math.Log(tree.Count + 1, 2)) - 1;

            // Print mininum possible height
            Console.WriteLine("The mininum layers possible is: " + minLayers.ToString() + " Excluding the root");

            // Give the size of the tree
            Console.WriteLine(string.Empty);
            Console.Write("The size of the BST is: ");
            Console.WriteLine(tree.Count);
        }
    }
}
