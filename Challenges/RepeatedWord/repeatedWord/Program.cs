using repeatedWord.Classes;
using System;
using System.Text.RegularExpressions;

namespace repeatedWord
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input = "Test sentence. things things";
            string answer = RepeatedWord(input);
            Console.WriteLine(answer);
            Console.ReadLine(); //just to stop it from auto quit
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
                if (hTable.HashTableArray[hTable.Hash(item)] == null)
                {
                    hTable.AddToHashTable(item, item); //i want the value to be the same as the key for this
                } 
                else if(hTable.HashTableContains(item) == true)
                {
                    return item;
                }

            }
            //means went through all the words and didn't find a collision therefore returning and exiting before this point, so no duplicates
            Console.WriteLine("There were no duplicate words in this string");
            return null;
        }
    }
}
