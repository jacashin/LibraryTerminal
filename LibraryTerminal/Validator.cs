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
        public static bool IsSelectionValid(string input)
        {
            return input.Equals("author", StringComparison.CurrentCultureIgnoreCase)||
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


    }
    //validates stuff 
}
