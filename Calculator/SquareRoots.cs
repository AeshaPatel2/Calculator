using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class SquareRoots
    {
        public void SquareRooting()
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

                    sum = Math.Sqrt(num1);

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

                SquareRooting();

            }
            
        }
        
    }
}
