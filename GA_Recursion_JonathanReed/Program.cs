namespace GA_Recursion_JonathanReed
{
    internal class Program
    {
        /* Jonathan Reed
         * 1/22/2024
         *
         *
         */
        static void Main(string[] args)
        {

            /*while recursion is a powerful tool, it's also important to be aware of its limitations and potential drawbacks, such as stack overflow errors for very deep recursion levels. Always ensure that your base case is correctly defined to prevent infinite recursion.*/
            PrintNumbersFrom1To10(1);
            Console.WriteLine();
            CountDownAndUp(5);
            Console.WriteLine();
            int[] numbers = { 12, 45, 7, 23, 9 }; // Adding 5 hardcoded numbers to the array

            Console.WriteLine("Array elements:");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }

            int sum = CalculateSum(numbers, 0);
            Console.WriteLine($"\nSum of the array elements: {sum}");
            Console.WriteLine();
            int n = 10; // Change n to the desired Fibonacci sequence length
            Console.WriteLine($"Fibonacci sequence of length {n}:");
            for (int i = 0; i < n; i++)
            {
                int result = Fibonacci(i);
                Console.Write(result + " ");
            }
        }
        static void PrintNumbersFrom1To10(int currentNumber)
        {
            if (currentNumber <= 10)
            {
                // Step 1: Check if the current number is less than or equal to 10
                // If true, proceed with the following steps.

                // Step 2: Print the current number
                Console.WriteLine(currentNumber);

                // Step 3: Increase the current number by 1
                int nextNumber = currentNumber + 1;

                // Step 4: Recursively call the function with the next number
                PrintNumbersFrom1To10(nextNumber);

                // Step 5: When the recursion reaches 11, it stops automatically.
            }
        }
        static void CountDownAndUp(int currentNumber)
        {
            // Base Case Check for Counting Down: Ensure we don't continue indefinitely while counting down
            if (currentNumber >= 1)
            {
                //Console.WriteLine($"Before Recursive Call: {currentNumber}");

                // Recursive Call: Recursively count down
                CountDownAndUp(currentNumber - 1);

                Console.WriteLine($"After Recursive Call: {currentNumber}");
            }
        }
        static int CalculateSum(int[] arr, int index)
        {
            // Base Case: If the index is equal to the array length, return 0 (no elements to add)
            if (index == arr.Length)
            {
                return 0;
            }
            else
            {
                // Recursive Case:
                // Add the current element (at the current index) to the sum of the rest of the elements
                int currentElement = arr[index];
                int restOfTheSum = CalculateSum(arr, index + 1);
                return currentElement + restOfTheSum;
            }
        }
        static int Fibonacci(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }
    }
}