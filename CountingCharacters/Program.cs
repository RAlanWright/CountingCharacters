using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string testString = "This is a test string" +
                " that holds several characters for " +
                "matching characters and number of times " +
                "the character appears.";

            Dictionary<char, int> charCount = new Dictionary<char,int>();
            char[] charactersInString = testString.ToCharArray();

            foreach (char character in charactersInString) {
                if (charCount.ContainsKey(character))
                {
                    charCount[character] = charCount.Count + 1;
                } else
                {
                    charCount[character] = 1;
                }
            }

            foreach (KeyValuePair<char, int> singleChar in charCount)
                {
                    Console.WriteLine(singleChar.Key + ": " + singleChar.Value);
                }



            Console.ReadLine();
        }
    }
}
