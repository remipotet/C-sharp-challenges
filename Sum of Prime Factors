using System;

namespace Sum_of_Prime_Factors
{
    class Program
    {
        static void Main()
		{
			// Ask the user for a n input
			Console.WriteLine("Please enter a value for n:");
			int n = Convert.ToInt32(Console.ReadLine());

			/* Find all the prime factors of n and summarize them
			Finding the prime factors can be done without trial division 
			However, for a first time, let's do it easy */

			/* I create a boolean to help me finding prime factors
			And also an integer for the sum of prime factors 
			And finally, a temporary valued used in the loops */
			bool prime;
			int sum = 0;
			int temp = n;

			// I start at i = 2, since 0 and 1 are not prime factors
			for (int i = 2; i <= temp; i++)
            {
				prime = true;
				if (temp % i == 0)
                {
					for (int j = 2; j < i; j++)
                    {
						if (i % j == 0)
                        {
							prime = false;
                        }
                    }
                }
				else
                {
					prime = false;
                }
				if (prime == true)
                {
					Console.WriteLine($"{i} is a prime factor of {n}");
					// The sum is built
					sum += i;
					// The countdown and the temporary value are adapted
					temp = temp / i;
					i = 1;
                }
            }

			// Print the result
			Console.WriteLine($"The sum of prime factors of {n} is {sum}");

		}
	}
}
