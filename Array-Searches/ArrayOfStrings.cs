using System;
using System.Collections.Generic;
using System.Text;

namespace Array_Searches
{
    class ArrayOfStrings
    {
        private string[] words = { "friends", "Romans", "and", "Countrymen", "lend", "me", "your", "ears.", "I", "come", "to", "bury", "Caeser", "not", "to", "praise", "him."};

        public ArrayOfStrings()
        {

        }

        public void displayValues()
        {
            for(int a = 0; a < words.Length; a++)
            {
                Console.WriteLine(words[a]);
            }
        }

        public void searhForWord(string searchWord)
        {
            for (int a = 0; a < words.Length; a++)
            {
                if (searchWord == words[a])
                {
                    Console.WriteLine(searchWord + " is in the list of words");
                    return;
                }
            }

            Console.WriteLine(searchWord + " is not in this list");
        }

        public void numberOfElements(string searchWord)
        {
            int count = 0;

            for (int a = 0; a < words.Length; a++)
            {
                count++;

                if (searchWord == words[a])
                {
                    Console.WriteLine(count + " searche(s) was done to find the word " + searchWord);
                    return;
                }

            }
        }
    }
}
