using System;

namespace Unique_Characters_in_a_String
{
    class Program
    {
        static void Main()
        {
            /* Instructions were not crystal clear as if we had to count upper and lowers separately
            But also if we had to take into account special characters such as ! , ;...
            So I decided to count upper, lowers and special characters as well and separate them */
            
            Console.WriteLine("Please, write a string:");
            string input = Console.ReadLine();
            int n = input.Length;

            /* Counter is used to store a value for each character used
            93 was obtained by using the ASCII table and the total number of characters we are interested into */
            int[] counter = new int[93];
            int value;

            // Loop depending on the string length that stores encountered characters
            for (int i = 0; i < n; i++)
            {
                // in case of space which was not included as a character
                if (input[i] != 32)
                {
                    // the decimal value of the char is taken and accounted in the counter
                    value = input[i] - 33;
                    counter[value]++;

                    // if the char was already accounted, a duplicate was found
                    if (counter[value] > 1)
                    {
                        Console.WriteLine("duplicates found.");
                        return;
                    }
                }
            }

            Console.WriteLine("all unique.");
        }
    }
}
