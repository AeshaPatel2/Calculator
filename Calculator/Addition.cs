using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Addition
    {
        public void Adding()
        {
            try
            {

            Console.Write("Enter the number of values you'd like to add: ");
            int numberOfValues = int.Parse(Console.ReadLine());

            double[] valueStorage = new double[numberOfValues];
            double sum = 0;

            for (int i = 0; i < numberOfValues; i++)
            {
                Console.Write("Enter a number: ");
                valueStorage[i] = double.Parse(Console.ReadLine());

                sum += valueStorage[i];

                Console.WriteLine(sum);
                             
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

                Adding();

            }
                                                      

        }

    }
}



