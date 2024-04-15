using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string palindrome)
        {
            var reversed = "";
            for (int i = palindrome.Length - 1; i >= 0; i++)
            {
                reversed += palindrome[i];
            }

            if (reversed == palindrome)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
