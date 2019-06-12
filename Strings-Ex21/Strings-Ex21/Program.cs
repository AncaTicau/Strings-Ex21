using System;

namespace Strings_Ex21
{
    class Program
    {
        static void Main(string[] args)
        {
            string givenString = "This is a string";
            int givenIndex = 3;
            Console.WriteLine(RemoveChar(givenString, givenIndex));
        }
        //Write a method that to remove the nth index character from a nonempty string.
        public static string RemoveChar(string input, int index)
        {
            if (index > input.Length)
            {
                return input;
            }

            string result = input.Remove(index - 1, 1);

            return result;
        }
    }
}
