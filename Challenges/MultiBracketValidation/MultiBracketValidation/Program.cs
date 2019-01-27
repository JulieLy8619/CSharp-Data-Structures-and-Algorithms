using System;
using MultiBracketValidation.Classes;

namespace MultiBracketValidation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Should Pass: {}[([{}])]");
            MultiBracketValidation("{}[([{}])]");
            Console.WriteLine(); //just because I like space

            Console.WriteLine("Should Fail: (cat]");
            MultiBracketValidation("(cat]");
            Console.ReadLine(); //to stop it from auto exit
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool MultiBracketValidation(string input)
        {
            
        }
    }
}
