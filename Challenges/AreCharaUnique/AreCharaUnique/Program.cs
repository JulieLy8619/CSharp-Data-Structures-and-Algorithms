using System;

namespace AreCharaUnique
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool mainAnswer1 = AreCharactersUnique("tes");
            Console.WriteLine("tes is " + mainAnswer1);
            bool mainAnswer2 = AreCharactersUnique("test");
            Console.WriteLine("test is " + mainAnswer2);
            bool mainAnswer3 = AreCharactersUnique("`~234g");
            Console.WriteLine("`~234g is " + mainAnswer3);

            Console.ReadLine(); // so it doesn't auto quit
        }

        /// <summary>
        /// determines if a string contains all unique characters
        /// </summary>
        /// <param name="input">the string to evaluate</param>
        /// <returns>true or false if it contains all uniques or not</returns>
        public static bool AreCharactersUnique(string input)
        {
            if (input.Length > 0)
            {
                string shortenString = input;
                for (int i = 1; i < input.Length; i++)
                {
                    if (input[0] == input[i])
                    {
                        return false;
                    }
                }
                if (input != null)
                {
                    shortenString = input.TrimStart(input[0]);
                }
                bool answer = AreCharactersUnique(shortenString);
                return answer;
            }
            else
            {
                return true; //technically it is neither if it is null but I need this to be true otherwise I don't ever return a true case
            }
        }
    }
}
