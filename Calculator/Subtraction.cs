using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Subtraction
    {
        public void Subtracting()
        {

            try
            {

                Console.Write("Enter the number of values you'd like to add: ");
                int numberOfValues = int.Parse(Console.ReadLine());

                double[] valueStorage = new double[numberOfValues];
                double minus = 0;

                for (int i = 0; i < numberOfValues; i++)
                {
                    Console.Write("Enter a number: ");
                    valueStorage[i] = double.Parse(Console.ReadLine());

                    minus -= valueStorage[i]; 
                                        
                      Console.WriteLine(minus);

                }

                Console.ReadKey();

            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Invalid Input! Try Again");
                Console.ResetColor();
                Console.ReadKey();
                Console.Clear();

                Subtracting();

            }



        }

    }
}
