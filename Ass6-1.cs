/*Indexers

1. Create a class called Books with BookName and AuthorName members. Instantiate the class through constructor and also write a method Display() to display the details. Create an Indexer of Books Object to store 5 books in a class called BookShelf. Using the indexer method assign values to the books and display the same.

(Hint : Use Composition. Books object inside BookShelf class)*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass6
{
    class Books
    {

        string[] bookname = new string[3];
        string[] authorname = new string[3];

        public string this[string index]

        {
            get { return bookname; }
            set { bookname = value; }
        }

        public string _authorname
        {
            get { return authorname; }
            set { authorname = value; }
        }

    }

    class BookShelf
    {
        public static void Main(string[] args)
        {
            Books b = new Books();
            b[0] = "Telugu";
            b[1] = "Hindi";
            b[2] = "English";
            b[3] = "Maths";
            b[4] = "Physics";
            Console.WriteLine(b[0] + " " + b[1] + " " + b[2] + " " + b[3] + " " + b[4]);
        }
      
    }
}
