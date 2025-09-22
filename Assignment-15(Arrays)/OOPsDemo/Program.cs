// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");



using System.Globalization;

namespace MyDemo
{
    class Program
    {
        delegate void Greet(string name);
        static string name;
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Your Name:");
            name = Console.ReadLine();
            Greet g = Greetings;
            g(name);
            
            Console.WriteLine("Will be displaying all the array problems");
            Console.WriteLine("Press Enter every time for next step");
            Console.ReadKey();
            
            Console.WriteLine(Environment.NewLine);
            Display1();
            Console.WriteLine(Environment.NewLine);
            Console.ReadKey();
            Display3();
            Console.WriteLine(Environment.NewLine);
            Console.ReadKey();
            Display4();
            Console.WriteLine(Environment.NewLine);
            Console.ReadKey();
            Display2();
            Console.WriteLine(Environment.NewLine);
            Console.ReadKey();
        }
        static void Display1()
        {
            int[] arr = { 12, 45, 67, 23, 89, 34 };
            int sum = 0;
            foreach (int num in arr)
                sum += num;
            Console.WriteLine("Displaying the contents of Array");
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine(Environment.NewLine);

            double average = (double)sum / arr.Length;
            Console.WriteLine("Sum = " + sum);
            Console.WriteLine("Average = " + average);
        }
        static void Greetings(String name)
        {
            Console.WriteLine(" Hey " + name);
        }

        static void Display2()
        {
            int[,] a = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int[,] b = { { 9, 8, 7 }, { 6, 5, 4 }, { 3, 2, 1 } };
            int[,] sum = new int[3, 3];

            Console.WriteLine("Displaying the contents of 3 X 3 matrix");

            Console.WriteLine("Matrix A:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(a[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nMatrix B:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(b[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine(Environment.NewLine);
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    sum[i, j] = a[i, j] + b[i, j];

            Console.WriteLine("Sum of matrices:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    Console.Write(sum[i, j] + " ");
                Console.WriteLine();
            }
        }

        static void Display3()
        {
            int[] arr = { 12, 45, 67, 23, 89, 34 };
            int max = arr[0];
            foreach (int num in arr)
                if (num > max)
                    max = num;

            Console.WriteLine("Displaying the contents of Array");
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("Maximum element = " + max);
        }
        static void Display4()
        {
            int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int rows = arr.GetLength(0);
            int cols = arr.GetLength(1);


            Console.WriteLine("Elements of the 2D array:");
            for (int i = 0; i < rows; i++) // Rows
            {
                for (int j = 0; j < cols; j++) // Columns
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine(); // Move to next line after each row
            }
            Console.WriteLine(Environment.NewLine);

            for (int j = 0; j < cols; j++)
            {
                int colSum = 0;
                for (int i = 0; i < rows; i++)
                    colSum += arr[i, j];
                Console.WriteLine($"Sum of column {j + 1} = {colSum}");
            }
            Console.WriteLine(Environment.NewLine);

            for (int i = 0; i < rows; i++)
            {
                int rowSum = 0;
                for (int j = 0; j < cols; j++)
                    rowSum += arr[i, j];
                Console.WriteLine($"Sum of row {i + 1} = {rowSum}");
            }
        }
    }
}
