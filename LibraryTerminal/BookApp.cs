using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTerminal
{
    public class BookApp
    {
        //functions will go here
<<<<<<< HEAD
        
       static string strToParse = "Title, Author, Status, DueDate";
        string[] words = strToParse.Split(',');
        public List<Book> FindBook = new List<Book>();
        public string Title;
        public string Author;
        public string Status;
        public string DueDate;


	} 
=======

      
        //method create list of Book objects
        //from constructor into lines to write
        public static void DisplayBooks(List<Book> listOfBooks)
        {
            Console.WriteLine("List of books: ");
            Console.WriteLine("Title\t\t\tAuthor\t\t\tStatus\t\t\tDue Date");
            Console.WriteLine("-----\t\t\t------\t\t\t------\t\t\t--------");
        }

    }
>>>>>>> 37afaffc04e67ba931b45e66485288afbf3dcfcc
}


