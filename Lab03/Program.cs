using System;

namespace Lab03
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ListAmount();
            Diamond();
        }

        public static int Product(int[] array)
        {
            int total = 1;
            if (array.Length < 3)
                total = 0;
            else if (array.Length > 2)
                for (int i = 0; i < 3; i++)
                {
                    total *= array[i];
                }
            return total;
        }

        public static void ListAmount()
        {
            Console.Write("Please enter a number between 2-10: ");
            string input = Console.ReadLine();
            int inputNum = Convert.ToInt32(input);

            int[] array = new int[inputNum];
            int[] array2 = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} of {1} - Enter a number: ", i + 1, inputNum);
                string input2 = Console.ReadLine();
                int inputNum2 = Convert.ToInt32(input2);
                array2[i] = inputNum2;
            }
            int sum = 0;
            for (int i = 0; i < array2.Length; i++)
            {
                sum += array2[i];
            }
            int avg = sum / array2.Length;

            Console.WriteLine("The average of these {0} numbers is: {1}", array2.Length, avg);
        }

        public static void Diamond()
        {
            Console.WriteLine("Program for displaying pattern of *.");
            Console.Write("Enter the maximum number of *: (Top to Middle line)");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < (n - i); j++)
                    Console.Write(" ");
                for (int j = 1; j <= i; j++)
                    Console.Write("*");
                for (int k = 1; k < i; k++)
                    Console.Write("*");
                Console.WriteLine();
            }

            for (int i = n - 1; i >= 1; i--)
            {
                for (int j = 0; j < (n - i); j++)
                    Console.Write(" ");
                for (int j = 1; j <= i; j++)
                    Console.Write("*");
                for (int k = 1; k < i; k++)
                    Console.Write("*");
                Console.WriteLine();
            }

            Console.WriteLine();
        }

        public static int Challenge4(int[] arr)
        {
            int n = arr.Length;
            // Sort the array 
            Array.Sort(arr);
            // find the max frequency using  
            // linear traversal 
            int max_count = 1, res = arr[0];
            int curr_count = 1;
            for (int i = 1; i < n; i++)
            {
                if (arr[i] == arr[i - 1])
                    curr_count++;
                else
                {
                    if (curr_count > max_count)
                    {
                        max_count = curr_count;
                        res = arr[i - 1];
                    }
                    curr_count = 1;
                }
            }
            // If last element is most frequent 
            if (curr_count > max_count)
            {
                max_count = curr_count;
                res = arr[n - 1];
            }
            return res;
        }
    }
}
