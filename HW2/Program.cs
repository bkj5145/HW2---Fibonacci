using System;

namespace HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number that you want your fibonacci sequence for: ");

            int index = Int32.Parse(Console.ReadLine());

            int previousNumber = 0;
            int secondNumber = 0;

            int totalNumber = 0;

            for (int i = 0; i <= index ; i++)
            {


                if (i == 0)
                {
                    totalNumber = 0;
                }
                if (i == 1)
                {
                    previousNumber = 0;
                    secondNumber = 1;
                    totalNumber = previousNumber + secondNumber;

                }
                if (i == 2)
                {
                    previousNumber = secondNumber;
                    totalNumber = secondNumber;
                }
                if (i > 2)
                {
                    
                    totalNumber = previousNumber + secondNumber ;
                    previousNumber = secondNumber;
                    secondNumber = totalNumber;

                }

                Console.WriteLine(totalNumber);


                
            }
            Console.WriteLine("The value you are looking for is " + totalNumber);
            Console.ReadLine();
        }
    }
}
