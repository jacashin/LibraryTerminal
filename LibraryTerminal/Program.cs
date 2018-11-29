using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace LibraryTerminal
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
<<<<<<< HEAD
            Console.WriteLine("Please enter 'Title' to search by title, 'Author' to search by author, or 'List' to see the entire book list");//JA
            string UserInput = Console.ReadLine();//JA
           
                while (string.IsNullOrEmpty(UserInput))   //JA
                {
                    Console.WriteLine("Invalid, please try again");
                    UserInput = Console.ReadLine();
                }

            if (!Validator.IsSelectionValid(UserInput))//JA
            {
                Console.WriteLine("Invalid, please try again");
                UserInput = Console.ReadLine();
=======

=======

                      
>>>>>>> bbdb7880cd06776ad98e875b7644c32173b8d83c
            string path = FileManagement.GetPath();
>>>>>>> e28f4b7757d79b2789dae75d3ba967abf4f7e002

            }
            string path = FileManagement.GetPath();
            List<string> listOfStrings = FileManagement.ReadFile(path);

<<<<<<< HEAD
            if (UserInput.Equals("author", StringComparison.CurrentCultureIgnoreCase))
=======
            foreach (var book in listOfStrings)
>>>>>>> e28f4b7757d79b2789dae75d3ba967abf4f7e002
            {
                Console.WriteLine("Please enter the author you wish to search for");
                var author = Console.ReadLine();
               
                if (Validator.IsValidAuthor(author))
                {
                    Console.WriteLine($"{ParseFile.GetBookAuthor()}");
                }
                else
                {
                    Console.WriteLine($"Invalid Author...");
                    Console.ReadLine();
                }
            }
            else if (UserInput.Equals("title", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("please enter the title you wish to search for");
                var title = Console.ReadLine();
                if (Validator.IsValidTitle(title))
                {
                    Console.WriteLine($"{ParseFile.GetBookTitle()}");
                }
                else
                {
                    Console.WriteLine($"Invalid Title...");
                    Console.ReadLine();
                }
            }
            else if (UserInput.Equals("list", StringComparison.CurrentCultureIgnoreCase))
            {
                foreach (var book in listOfStrings)
                {
                    Console.WriteLine(book);
                }
                listOfStrings.Add("teal");

                FileManagement.WriteFile(listOfStrings, path);
            }
            foreach (var book in listOfStrings)
            {
                Console.WriteLine(book);
            }
            Console.ReadLine();

        }
    }
}
