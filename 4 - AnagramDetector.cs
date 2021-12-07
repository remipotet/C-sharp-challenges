using System;

namespace Anagram_detector
{
    class Program
    {
        static void Main()
        {
            anagram();

            static int anagram()
            {
                Console.WriteLine("Please, enter a first string:");
                string first = Console.ReadLine();
                Console.WriteLine("Enter a second one:");
                string second = Console.ReadLine();

                /* We define a counter to identify each character used for both words
                 * And a length for the loop */
                int[] counter = new int[93];

                // To make sure we don't go off-limits in the arrays
                if (first.Length >= second.Length)
                {
                    /* Basically, we are going to store every appearance of a character in the counter
                    If counter[] is a multiple of 2, it means that words are anagrams 
                    Because if they are anagrams, there will be only none or double appearance */
                    for (int i = 0; i < first.Length; i++)
                    {
                        if (first[i] != 32)
                        {
                            counter[first[i] - 33]++;
                        }
                        if (i < second.Length && second[i] != 32)
                        {
                            counter[second[i] - 33]++;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < second.Length; i++)
                    {
                        if (i < first.Length && first[i] != 32)
                        {
                            counter[first[i] - 33]++;
                        }
                        if (second[i] != 32)
                        {
                            counter[second[i] - 33]++;
                        }
                    }
                }

                // Then, depending on counter, we can conclude
                foreach (int value in counter)
                {
                    Console.WriteLine($"{value}");
                    if (value % 2 != 0)
                    {
                        return 0;
                    }
                }
                return 1;
            }
        }
    }
}
