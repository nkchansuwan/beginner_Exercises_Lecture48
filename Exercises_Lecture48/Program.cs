using System;

namespace Exercises_Lecture48
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberDiviseBy3();

            SumAllNumberEnter();

            CalculateFactorial();

            RandomNumber();

            FineMaximumNumber();
        }

        public static void NumberDiviseBy3()
        {
            var count = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine(string.Format("1 - 100 divisible by 3 = {0}", count));
        }

        public static void SumAllNumberEnter()
        {
            const string keyWord = "ok";
            var value = "";
            var sum = 0;
            while (value != keyWord)
            {
                Console.Write(@"Enter number or ok to see result : ");
                value = Console.ReadLine();

                if (value == keyWord)
                {
                    break;
                }

                var intValue = Convert.ToInt32(value);
                sum = sum + intValue;
            }

            Console.WriteLine(string.Format("Result = {0}", sum));
        }

        public static void CalculateFactorial()
        {
            Console.Write("Enter number for calculate factorial : ");
            var number = Convert.ToInt32(Console.ReadLine());
            var result = 1;
            for (int i = number ; i > 0; i--)
            {
                result = result * i;
            }
            Console.WriteLine(string.Format("{0}!={1}",number, result));
        }

        public static void RandomNumber()
        {
            Random random = new Random();

            for (int i = 0; i < 4; i++)
            {
                var ran = random.Next(1, 10);
                Console.Write("Guess the number (1-10) :");
                var number = Convert.ToInt32(Console.ReadLine());
                if (ran == number)
                {
                    Console.WriteLine("You won");
                    break;
                }
                else
                {
                    Console.WriteLine("You lost");
                }
            }
        }

        public static void FineMaximumNumber()
        {
            Console.Write("Enter as series of numbers :");
            var seriesNumber = Console.ReadLine();
            var arrNumber = seriesNumber.Split(',');
            var max = 0;
            var number = 0;
            foreach (var item in arrNumber)
            {
                number = Convert.ToInt32(item);
                if (max <= number)
                {
                    max = number;
                }
            }
            Console.WriteLine(max);
        }
    }
}
