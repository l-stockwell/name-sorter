using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace nameSorter
{
    public class SortFile
    {
        public static void Main(string[] args)
        {
            // Set input and output file references
            var input = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName, "unsorted-names-list.txt");
            var output = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName, "sorted-names-list.txt");

            Console.WriteLine("Sorting names...\n");

            // Sort names and write to output file
            SortFile sort = new SortFile();
            sort.SortingFile(input, output);

            Console.WriteLine("\nSorted unsorted-names-list.txt. Sorted file saved into sorted-names-list.txt.");
            Console.ReadLine();
        }

        /* Sorts a names list text file given an input .txt file,
         * prints and writes the sorted names to an output .txt file */
        public void SortingFile(string FileName, string OutputFile)
        {
            var lines = File.ReadLines(FileName); // Read and store names list

            var sortedLines = SortLines(lines); // Sort names by last name

            foreach (string line in sortedLines) // Print sorted names to screen
            {
                Console.WriteLine(line);
            }

            File.CreateText(OutputFile).Close(); //Creates ouput text file
            File.WriteAllLines(OutputFile, sortedLines); //Write lines to text file
        }

        /* Sorts a names list by last name */
        public IEnumerable<string> SortLines(IEnumerable<string> InputList)
        {
            // Split name list by spaces, order by last element (last name), and create the new sorted list
            var sorted = InputList.OrderBy(x => x.Split(' ')
                         .Last())
                         .ThenBy(x => x)
                         .ToList();

            return sorted;
        }
    }
}
