using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LibraryTerminal
{
    public class Validator
    {
<<<<<<< HEAD
        public static bool IsSelectionValid(string input)
        {
            return input.Equals("author", StringComparison.CurrentCultureIgnoreCase) ||
                input.Equals("title", StringComparison.CurrentCultureIgnoreCase) ||
                input.Equals("list", StringComparison.CurrentCultureIgnoreCase);
        }
        public static bool IsValidAuthor(string author)
        {
            var x = new Regex("[/w]");
            if (!string.IsNullOrEmpty(author) && x.IsMatch(author))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool IsValidTitle(string title)
        {

            if (!string.IsNullOrEmpty(title))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


=======
        static public string DetermineTitleOrAuthor()
        {
            string userInput = Console.ReadLine();
            bool validAnswer = false;

            while (validAnswer == false)
            {
                if (string.IsNullOrEmpty(userInput))   //JA
                {
                    validAnswer = false;
                }
                else if (userInput.Equals("title", StringComparison.OrdinalIgnoreCase))
                {
                    userInput = "title";
                    validAnswer = true;
                    break;
                }
                else if (userInput.Equals("author", StringComparison.OrdinalIgnoreCase))
                {
                    userInput = "author";
                    validAnswer = true;
                    break;
                }
                else
                {
                    validAnswer = false;
                }
                Console.Write("Invalid, please enter title or author: ");
                userInput = Console.ReadLine();
            }
            return userInput;
        }

        public static int MenuChoice()
        {
            string menuChoice = Console.ReadLine();
            bool validNumber = false;
            int menuNum = 0;
            while (validNumber == false)
            {
                bool realNumber = int.TryParse(menuChoice, out menuNum);
                if (realNumber == true && menuNum < 6 && menuNum > 0)
                {
                    validNumber = true;
                    break;
                }
                Console.Write("Sorry, that is not a valid menu choice.  Please enter 1-5: ");
                menuChoice = Console.ReadLine();
            }
            return menuNum;
        }
        //create 2 functions that takes in the user input is a title / author, return bool if it is in the list

        public static bool BookTitleValidator(Dictionary<int, Book> listOfBooks, string userInput)
        {
            bool validBookTitle = false;

            foreach (var book in listOfBooks)
            {
                if (book.Value.Title.Equals(userInput, StringComparison.OrdinalIgnoreCase))
                {
                    validBookTitle = true;
                    break;
                }
                else
                {
                    validBookTitle = false;
                }
            }
            if (validBookTitle == false)
            {
                Console.WriteLine("That book is not in our collection.");
            }
            return validBookTitle;
        }

        public static bool BookAuthorValidator(Dictionary<int, Book> listOfBooks, string userInput)
        {
            bool validBookAuthor = false;

            foreach (var book in listOfBooks)
            {
                if (book.Value.Title.Equals(userInput, StringComparison.OrdinalIgnoreCase))
                {
                    validBookAuthor = true;
                    break;
                }
                else
                {
                    validBookAuthor = false;
                }
            }
            if (validBookAuthor == false)
            {
                Console.WriteLine("That author is not in our collection.");
            }
            return validBookAuthor;
        }
>>>>>>> 3a0f849923c132d920b106e26dc8e7a66252a1e9
    }
    //validates stuff 
}
     
