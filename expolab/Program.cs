using System;

class Program
{
    static void Main()
    {
        bool repeat = true;
        while (repeat)
        {
            Console.Write("Enter an integer: ");
            int num = int.Parse(Console.ReadLine());

            if (num <= 0)
            {
                Console.WriteLine("Please enter a positive number above 0");
            }

            Console.WriteLine("Number\tSquared\tCubed");
            for (int i = 1; i <= num; i++)
            {
                int square = i * i;
                int cube = i * i * i;
                Console.WriteLine("{0}\t{1}\t{2}", i, square, cube);
            }

            Console.Write("Would you like to go again? (y/n): ");
            string answer = Console.ReadLine();
            if (answer.ToLower() != "y")
            {
                repeat = false;
            }
        }
    }
}
