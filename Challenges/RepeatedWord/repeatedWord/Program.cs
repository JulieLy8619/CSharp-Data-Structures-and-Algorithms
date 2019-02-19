using repeatedWord.Classes;
using System;
using System.Text.RegularExpressions;

namespace repeatedWord
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        
        public static string RepeatedWord(string str)
        {
            //put the words into an array
            HashTable2 hTable = new HashTable2();
            string[] strArr = new string[str.Length];
            string pattern = @"\W";
            strArr = Regex.Split(str, pattern);

            //hashes each word from the array
            foreach (var item in strArr)
            {
                hTable.AddToHashTable(item, item); //i want the value to be the same as the key for this
            }

            //looks for collison, if collison then check value then return
            if ()
            {

            }
            else
            {
                Console.WriteLine("There were no duplicate words in this string");
                return null;
            }

        }
    }
}
