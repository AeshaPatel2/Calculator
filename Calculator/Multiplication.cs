using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Multiplication
    {

        public void Multiplying()
        {
            bool exist = false;
            double sum = 0;

            Console.WriteLine("Press Escape to exist\n");

            try
            {
                do
                {
                    Console.Write("Enter a value: ");
                    double num1 = double.Parse(Console.ReadLine());

                    Console.Write("Enter a value: ");
                    double num2 = double.Parse(Console.ReadLine());

                    sum = num1 * num2;

                    Console.WriteLine(sum);

                    var keyInfo = Console.ReadKey();

                    switch (keyInfo.Key)
                    {
                        case ConsoleKey.Escape:
                            exist = true;
                            break;
                    }

                }
                while (!exist);

            }

            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Invalid Input! Try Again");
                Console.ResetColor();
                Console.ReadKey();
                Console.Clear();

                Multiplying();

            }


        }

    }
}
