using System;
using System.Transactions;

namespace DoWhile2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool retry = true;
            Random random = new Random();
            do
            {
                int randomNumber = random.Next(1, 50);
                while (true)
                {
                    Console.WriteLine("Guess a number from 1 - 50");
                    var myNum = int.Parse(Console.ReadLine());
                    if (myNum > randomNumber)
                    {
                        Console.WriteLine("Too High!");
                    }
                    else if (myNum < randomNumber)
                    {
                        Console.WriteLine("Too Low!");
                    }
                    else
                    {
                        Console.WriteLine("Lucky Guess!");
                    }

                }
            } while (retry);
        }
    }
}
