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



            try
            {

                Console.Write("Enter a number: ");
                double a = double.Parse(Console.ReadLine());

                Console.Write("Enter a number: ");
                double b = double.Parse(Console.ReadLine());

                double z = (a * b);

                Console.WriteLine("{0} * {1} = {2}", a, b, z);
                Console.ReadKey();
            }

            catch(FormatException)
            {
                Console.WriteLine("Invalid Input! Try Again");
                Console.ReadKey();
                Console.Clear();

                Multiplying();

            }

                       
        }

    }
}
