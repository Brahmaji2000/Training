/*Structures

2. Create a structure 
struct Books 
   private string title;
   private string author;
   private string subject;
   private int book_id;
Include 2 methods called GetValues() and ShowValues() to accept and display details.

create a Class called TestStructures that invokes the above methods of the structure to accept and display the details of the book*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass6
{
    struct Books
    {
        public string title;
        public string author;
        public string subject;
        public int book_id;

        public void getValues(string t, string a, string s, int id)
        {
            title = t;
            author = a;
            subject = s;
            book_id = id;
        }

        public void display()
        {
            Console.WriteLine("Title : {0}", title);
            Console.WriteLine("Author : {0}", author);
            Console.WriteLine("Subject : {0}", subject);
            Console.WriteLine("Book_id :{0}", book_id);
        }
    }

    class TestStructure
    {
        public static void Main(string[] args)
        {
            Books Book1 = new Books();
            Books Book2 = new Books();

            Book1.getValues("BE", "Brahamji", "EEE", 3);

            Book2.getValues("EEM", "Sai", "EEE", 4);

            Book1.display();

            Book2.display();

            Console.ReadLine();
        }
    }
}
