using System;

namespace MagicNumber.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, digitOne, digitTwo, digitThree;
            
            for(int i = 100; i < 1000; i++)
            {
                number = i;
                digitOne = number / 100;
                number -= digitOne*100;
                digitTwo = number / 10;
                number -= digitTwo*10;
                digitThree = number;
                number = (digitOne * digitOne * digitOne) + (digitTwo * digitTwo * digitTwo) + (digitThree * digitThree * digitThree);


                if (i == number)
                {
                    Console.WriteLine("Eine Magische Zahl lautet {0} da {1}^3+{2}^3+{3}^3={0}",i,digitOne,digitTwo,digitThree);
                }

                

            }
        }
    }
}
