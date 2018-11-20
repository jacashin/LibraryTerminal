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
        
       static string strToParse = "Title, Author, Status, DueDate";
        string[] words = strToParse.Split(',');
        public List<Book> FindBook = new List<Book>();
        public string Title;
        public string Author;
        public string Status;
        public string DueDate;


	} 
}


