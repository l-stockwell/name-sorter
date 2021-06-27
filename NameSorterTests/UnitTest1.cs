using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using nameSorter;

namespace NameSorterTests
{
    [TestClass]
    public class SortLinesTests
    {
        [TestMethod]
        public void TestSortNames()
        {
            IEnumerable<string> namesUnsorted = new string[] {
                "Janet Parsons",
                "Vaughn Lewis",
                "Adonis Julius Archer",
                "Shelby Nathan Yoder",
                "Marin Alvarez",
                "London Lindsey",
                "Beau Tristan Bentley",
                "Leo Gardner",
                "Hunter Uriah Mathew Clarke",
                "Mikayla Lopez",
                "Frankie Conner Ritter"
            };

            IEnumerable<string> expectedSorted = new string[] {
                "Marin Alvarez",
                "Adonis Julius Archer",
                "Beau Tristan Bentley",
                "Hunter Uriah Mathew Clarke",
                "Leo Gardner",
                "Vaughn Lewis",
                "London Lindsey",
                "Mikayla Lopez",
                "Janet Parsons",
                "Frankie Conner Ritter",
                "Shelby Nathan Yoder"
            };

            var sortFile = new SortFile();
            var sortedNames = sortFile.SortLines(namesUnsorted);

            CollectionAssert.AreEqual((System.Collections.ICollection)sortedNames, (System.Collections.ICollection)expectedSorted);
        }
        [TestMethod]
        public void TestAlreadySorted()
        {
            IEnumerable<string> namesUnsorted = new string[] {
                "Marin Alvarez",
                "Adonis Julius Archer",
                "Beau Tristan Bentley",
                "Hunter Uriah Mathew Clarke",
                "Leo Gardner",
                "Vaughn Lewis",
                "London Lindsey",
                "Mikayla Lopez",
                "Janet Parsons",
                "Frankie Conner Ritter",
                "Shelby Nathan Yoder"
            };

            IEnumerable<string> expectedSorted = new string[] {
                "Marin Alvarez",
                "Adonis Julius Archer",
                "Beau Tristan Bentley",
                "Hunter Uriah Mathew Clarke",
                "Leo Gardner",
                "Vaughn Lewis",
                "London Lindsey",
                "Mikayla Lopez",
                "Janet Parsons",
                "Frankie Conner Ritter",
                "Shelby Nathan Yoder"
            };

            var sortFile = new SortFile();
            var sortedNames = sortFile.SortLines(namesUnsorted);

            CollectionAssert.AreEqual((System.Collections.ICollection)sortedNames, (System.Collections.ICollection)expectedSorted);
        }
        [TestMethod]
        public void TestHyphenated()
        {
            IEnumerable<string> namesUnsorted = new string[] {
                "Kasie-Jane Hefner",
                "Raymond Benard-Jones",
            };

            IEnumerable<string> expectedSorted = new string[] {
                "Raymond Benard-Jones",
                "Kasie-Jane Hefner",
            };

            var sortFile = new SortFile();
            var sortedNames = sortFile.SortLines(namesUnsorted);

            CollectionAssert.AreEqual((System.Collections.ICollection)sortedNames, (System.Collections.ICollection)expectedSorted);
        }
        [TestMethod]
        public void TestFirstNameOnly()
        {
            IEnumerable<string> namesUnsorted = new string[] {
                "Vaughn",
                "Janet",
            };

            IEnumerable<string> expectedSorted = new string[] {
                "Janet",
                "Vaughn",
            };

            var sortFile = new SortFile();
            var sortedNames = sortFile.SortLines(namesUnsorted);

            CollectionAssert.AreEqual((System.Collections.ICollection)sortedNames, (System.Collections.ICollection)expectedSorted);
        }
        [TestMethod]
        public void TestManyNames()
        {
            IEnumerable<string> namesUnsorted = new string[] {
                "Janet Amy Rose Lee Parsons",
                "Vaughn John Curtis Henry Lewis",
            };

            IEnumerable<string> expectedSorted = new string[] {
                "Vaughn John Curtis Henry Lewis",
                "Janet Amy Rose Lee Parsons",
            };

            var sortFile = new SortFile();
            var sortedNames = sortFile.SortLines(namesUnsorted);

            CollectionAssert.AreEqual((System.Collections.ICollection)sortedNames, (System.Collections.ICollection)expectedSorted);
        }
        [TestMethod]
        public void TestDuplicateNames()
        {
            IEnumerable<string> namesUnsorted = new string[] {
                "Vaughn Lewis",
                "Janet Parsons",
                "Vaughn Lewis",
            };

            IEnumerable<string> expectedSorted = new string[] {
                "Vaughn Lewis",
                "Vaughn Lewis",
                "Janet Parsons"
            };

            var sortFile = new SortFile();
            var sortedNames = sortFile.SortLines(namesUnsorted);

            CollectionAssert.AreEqual((System.Collections.ICollection)sortedNames, (System.Collections.ICollection)expectedSorted);
        }
        [TestMethod]
        public void TestCaseSensitive()
        {
            IEnumerable<string> namesUnsorted = new string[] {
                "JANET PARSONS",
                "VAUGHN LEWIS"
            };

            IEnumerable<string> expectedSorted = new string[] {
                "VAUGHN LEWIS",
                "JANET PARSONS"
            };

            var sortFile = new SortFile();
            var sortedNames = sortFile.SortLines(namesUnsorted);

            CollectionAssert.AreEqual((System.Collections.ICollection)sortedNames, (System.Collections.ICollection)expectedSorted);
        }
        [TestMethod]
        public void TestLongNames()
        {
            IEnumerable<string> namesUnsorted = new string[] {
                "Hubert Blaine Wolfeschlegelsteinhausenbergerdorff",
                "Pablo Diego José Francisco de Paula Juan Nepomuceno María de los Remedios Cipriano de la Santísima Trinidad Ruiz y Picasso"
            };

            IEnumerable<string> expectedSorted = new string[] {
                "Pablo Diego José Francisco de Paula Juan Nepomuceno María de los Remedios Cipriano de la Santísima Trinidad Ruiz y Picasso",
                "Hubert Blaine Wolfeschlegelsteinhausenbergerdorff"
            };

            var sortFile = new SortFile();
            var sortedNames = sortFile.SortLines(namesUnsorted);

            CollectionAssert.AreEqual((System.Collections.ICollection)sortedNames, (System.Collections.ICollection)expectedSorted);
        }
        [TestMethod]
        public void TestShortNames()
        {
            IEnumerable<string> namesUnsorted = new string[] {
                "Amy Lee",
                "Kate Bou",
                "Mia"
            };

            IEnumerable<string> expectedSorted = new string[] {
                "Kate Bou",
                "Amy Lee",
                "Mia"
            };

            var sortFile = new SortFile();
            var sortedNames = sortFile.SortLines(namesUnsorted);

            CollectionAssert.AreEqual((System.Collections.ICollection)sortedNames, (System.Collections.ICollection)expectedSorted);
        }
    }
}
