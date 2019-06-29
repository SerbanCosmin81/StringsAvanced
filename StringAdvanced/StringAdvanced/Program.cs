using System;

namespace StringAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            MiddleChar();
            CountChar();
            //string[] persons = new string[] { "Alex" };
            //string[] persons = new string[] {"Alex", "Jacob" };
            //string[] persons = new string[] { "Alex", "Jacob", "Mark" };
            string[] persons = new string[] { "Alex", "Jacob", "Mark", "Max" };
            LikeSystem(persons);

            Console.WriteLine(Ho());
            Console.WriteLine(Ho(Ho()));
            Console.WriteLine(Ho(Ho(Ho())));

        }

        // Strings
        //1. Middle Characther
        //You are going to be given a word.Your job is to return the middle character of the word. If the word's length is odd, return the middle character. If the word's length is even, return the middle 2 characters.

        //#Examples:

        //"test" should return "es"

        //"testing" should return "t"

        //"middle" should return "dd"

        //"A" should return "A" #Input

        //A word (string) of length 0 < str< 1000. #Output

        //The middle character(s) of the word represented as a string.

        //PS: Should work for words of 999 characters

        public static void MiddleChar()
        {
            Console.WriteLine("Enter a word: ");
            string input = Console.ReadLine();
            if (input.Length % 2 == 0)
            {
                Console.WriteLine(input.Substring((input.Length / 2) - 1, 2));
            }
            else
            {
                Console.WriteLine(input.Substring(input.Length / 2, 1));
            }

        }

        //2. The goal of this kata is to write a function that takes two inputs: a string and a character. The function will count the number of times that character appears in the string. The count is case insensitive.

        //For example:

        //countChar("fizzbuzz","z") => 4 countChar("Fancy fifth fly aloof","f") => 5 The character can be any alphanumeric character.

        public static void CountChar()
        {
            Console.WriteLine("Enter a Word: ");
            string inputStr = Console.ReadLine().ToLower();
            Console.WriteLine("Enter a Char: ");
            string inputChar = Console.ReadLine().ToLower();
            int count = 0, i = 0;
            for (i = 0; i <= inputStr.Length - 1; i++)
            {
                if (inputStr[i] == inputChar[0])
                {
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("We didn't find your Char in the Input String");
            }
            else
            {
                Console.WriteLine(count);
            }
        }

        //3. You probably know the "like" system from Facebook and other pages.People can "like" blog posts, pictures or other items. We want to create the text that should be displayed next to such an item.
        //Implement a function likes :: [String] -> String, which must take in input array, containing the names of people who like an item.It must return the display text as shown in the examples:

        //likes[] // must be "no one likes this" likes ["Peter"] // must be "Peter likes this" likes ["Jacob", "Alex"] // must be "Jacob and Alex like this" likes ["Max", "John", "Mark"] // must be "Max, John and Mark like this" likes ["Alex", "Jacob", "Mark", "Max"] // must be "Alex, Jacob and 2 others like this"

        public static void LikeSystem(string[] persons)
        {

            if (persons.Length == 0)
                Console.WriteLine("No one likes this");
            if (persons.Length == 1)
                Console.WriteLine(persons[0] + " likes this."); ;
            if (persons.Length == 2)
                Console.WriteLine(persons[0] + " and " + persons[1] + " like this.");
            if (persons.Length == 3)
                Console.WriteLine(persons[0] + "," + persons[1] + " and " + persons[2] + " like this.");
            if (persons.Length == 4)
                Console.WriteLine(persons[0] + ", " + persons[1] + " and " + (persons.Length - 2).ToString() + " others like this.");

        }

        //4. Santa is learning programming. And what could be the first program, he wants to write? Yes, the "Hello world!" of Christmas: "Ho Ho Ho!". He wants to write a function ho(), which should have the following return values:

        //ho(); // should return "Ho!" ho(ho()); // should return "Ho Ho!" ho(ho(ho())); // should return "Ho Ho Ho!" Unfortunately he couldn't find any tutorial, which explains, how he could implement that. Can you help him?

        //        Rules:

        //each call of ho() must add a "Ho" to the string the "Ho"'s must be separated by a space at the end of the string, there must be an exclamation mark (!), without a space

        static string Ho()
        {
            return "Ho!";

        }
        static string Ho(string santa)
        {
            return "Ho " + santa.ToString();
        }

    }

}
