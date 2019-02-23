using repeatedWord.Classes;
using System;
using System.Text.RegularExpressions;

namespace repeatedWord
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input1 = "Test sentence. things things";
            Console.WriteLine("The string is: " + input1);
            string answer1 = RepeatedWord(input1);
            Console.WriteLine("The answer is: " + answer1);

            string input2 = "Test . $ $ sentence test bob bob";
            Console.WriteLine("The string is: " + input2);
            string answer2 = RepeatedWord(input2);
            Console.WriteLine("The answer is: " + answer2);

            string input3 = "Test . $ $ sentence test bob ";
            Console.WriteLine("The string is: " + input3);
            string answer3 = RepeatedWord(input3);
            Console.WriteLine("The answer is: " + answer3);

            
            string input4 = "It was the best of times, it was the worst of times";
            Console.WriteLine("The string is: " + input4);
            string answer4 = RepeatedWord(input4);
            Console.WriteLine("The answer is: " + answer4);

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
                if (hTable.HashTableArray[hTable.Hash(item.ToUpper())] == null || hTable.HashTableArray[hTable.Hash(item.ToUpper())].Head.Key == "")
                {
                    hTable.AddToHashTable(item.ToUpper(), item.ToUpper()); //i want the value to be the same as the key for this
                } 
                else if(hTable.HashTableContains(item.ToUpper()) == true)
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
