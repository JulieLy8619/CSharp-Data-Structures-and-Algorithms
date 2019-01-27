using System;
using MultiBracketValidation.Classes;

namespace MultiBracketValidation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Should Pass: {}[([{}])]");
            bool answer1 = MultiBracketValidation("{}[([{}])]");
            Console.WriteLine(answer1);
            Console.WriteLine(); //just because I like space

            Console.WriteLine("Should Pass: ");
            bool answer2 = MultiBracketValidation("(wordswordswords)");
            Console.WriteLine(answer2);
            Console.WriteLine(); //just because I like space

            Console.WriteLine("Should Fail: (cat]");
            bool answer3 = MultiBracketValidation("(cat]");
            Console.WriteLine(answer3);
            Console.WriteLine(); //just because I like space

            Console.WriteLine("Should Fail: {(})");
            bool answer4 = MultiBracketValidation("{(})");
            Console.WriteLine(answer4);
            Console.WriteLine(); //just because I like space

            Console.ReadLine(); //to stop it from auto exit
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool MultiBracketValidation(string input)
        {
            CharStack bracketStack = new CharStack();
            for (int i = 0; i <input.Length; i++)
            {
                if (input[i] == '{' || input[i] == '[' || input[i] == '(')
                {
                    bracketStack.Push(input[i]);
                }
                if (input[i] == '}')
                {
                    if (bracketStack.Top != null && bracketStack.Top.Value == '{')
                    {
                        bracketStack.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (input[i] == ']')
                {
                    if (bracketStack.Top != null && bracketStack.Top.Value == '[')
                    {
                        bracketStack.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (input[i] == ')')
                {
                    if (bracketStack.Top != null && bracketStack.Top.Value == '(')
                    {
                        bracketStack.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            if(bracketStack.Top == null)
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
