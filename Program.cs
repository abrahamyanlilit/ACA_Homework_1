using System;

namespace first
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess the secret number!");
            Random random = new Random();
            int ran_numb = random.Next(1, 1001);
            int number;
            int[] array = new int[1000];
            int length = 0;

            do
            {
                Console.WriteLine("Enter your number, please");
                number = int.Parse(Console.ReadLine());

                if (number < 1 || number > 1000)
                {
                    Console.WriteLine("Your number must be in range of 1 to 1000");
                    continue;
                }

                if (number == ran_numb)
                    Console.WriteLine("You are right!");
                else if (number > ran_numb)
                    Console.WriteLine("is greater");
                else if (number < ran_numb)
                    Console.WriteLine("is less");

                bool x = true;
                for (int j = 0; j < length; j++)
                {
                    if (array[j] == number)
                    {
                        x = false;
                        break;
                    }
                }
                if (x)
                    array[length++] = number;
            }
            while (number != ran_numb);
            Console.WriteLine("The number of expereiences are " + length);
        }
    }
}
