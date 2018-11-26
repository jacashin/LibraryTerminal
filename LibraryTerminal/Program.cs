using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTerminal
{
    class Program
    {
        static void Main(string[] args)
        {
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

            }
 
            // alternative approach
            /*switch (UserInput.ToLower())
            {
                case "author":
                    Console.WriteLine("please enter the author you wish to search for");
                    var author = Console.ReadLine();
                    Console.WriteLine($"{ParseFile.GetBookAuthor()}");
                    // do something with author...
                    break;
                case "title":
                    Console.WriteLine("please enter the title you wish to search for");
                    break;
                case "list":
                    // titl
                    break;
                default:
                    break;
            }*/

            // 1) get the list of books
            string path = FileManagement.GetPath();
            List<string> listOfStrings = FileManagement.ReadFile(path);

            // 2) check what form of searching is desired
            if (UserInput.Equals("author", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("Please enter the author you wish to search for");
                var author = Console.ReadLine();
                // validate the author
                if (Validator.IsValidAuthor(author))
                {
                    // search books using author
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
                // validate title
                if (Validator.IsValidTitle(title))
                {
                    // search books using title
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
              // string path = FileManagement.GetPath();

                //List<string> listOfStrings = FileManagement.ReadFile(path);

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
