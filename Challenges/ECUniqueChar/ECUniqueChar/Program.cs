using HashTable.Classes;
using System;

namespace ECUniqueChar
{
    public class Program
    {
        static void Main(string[] args)
        {
            string str1 = "teststringthatwillfail";
            Console.WriteLine("String is: " + str1);
            bool answer1 = UniqueChara(str1);
            Console.WriteLine(answer1);

            string str2 = "abc";
            Console.WriteLine("String is: " + str2);
            bool answer2 = UniqueChara(str2);
            Console.WriteLine(answer2);

            Console.ReadLine(); //so it doesn't auto quit
        }

        public static bool UniqueChara(string input)
        {
            Hashtable ht = new Hashtable();
            string temp = "";
            if (input.Length == 0)
            {
                return false; //technically no chara is and isn't uniqueu chara, i chose false
            }
            for (int i = 0; i < input.Length; i++)
            {
                temp = input[i].ToString();
                if (ht.HashTableContains(temp) == true)
                {
                    return false; //means duplicate
                }
                else
                {
                    ht.AddToHashTable(temp, temp);
                }
            }
            return true; //means it got through string and it didn't exit due to a duplicate
        }
    }
}
