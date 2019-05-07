using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Addition add = new Addition();
            Subtraction subtract = new Subtraction();
            Multiplication multiply = new Multiplication();
            Division divid = new Division();


            //size of the console.
            Console.WindowHeight = 40;
            Console.WindowWidth = 150;

            //Ascii characters in dark cyan, centered 
            string title = @"
                          ______     ___       __        ______  __    __   __          ___   .___________.  ______   .______      
                         /      |   /   \     |  |      /      ||  |  |  | |  |        /   \  |           | /  __  \  |   _  \     
                        |  ,----'  /  ^  \    |  |     |  ,----'|  |  |  | |  |       /  ^  \ `---|  |----`|  |  |  | |  |_)  |    
                        |  |      /  /_\  \   |  |     |  |     |  |  |  | |  |      /  /_\  \    |  |     |  |  |  | |      /     
                        |  `----./  _____  \  |  `----.|  `----.|  `--'  | |  `----./  _____  \   |  |     |  `--'  | |  |\  \----.
                         \______/__/     \__\ |_______| \______| \______/  |_______/__/     \__\  |__|      \______/  | _| `._____|
                                                                                                           
                           ";
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (title.Length / 2)) + "}", title));
            Console.ResetColor();

            string text = "Enter any key to begin";
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (title.Length / 2)) + "}", text));

            Console.ReadKey();
            Console.Clear();

            //function menu with arrow key selection
            var menu = new Menu(new string[] { "Addition", "Subtraction", "Multiplication", "Division", "Exit" });
            var menuPainter = new MenuPainter(menu);

            bool exist = false;

            do
            {
                bool done = false;
                do
                {
                    Console.Clear();
                    menuPainter.Paint(2, 1);

                    var keyInfo = Console.ReadKey();

                    switch (keyInfo.Key)
                    {
                        case ConsoleKey.UpArrow:
                            menu.MoveUp();
                            break;
                        case ConsoleKey.DownArrow:
                            menu.MoveDown();
                            break;
                        case ConsoleKey.Enter:
                            done = true;
                            break;

                    }
                }
                while (!done);


                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Selected option: " + (menu.SelectedOption));
                Console.ResetColor();


                //switching to different classes according to the selected menu option


                var selection = menu.SelectedOption;

                switch (selection)
                {
                    case "Addition":
                        add.Adding();
                        break;
                    case "Subtraction":
                        subtract.Subtracting();
                        break;
                    case "Multiplication":
                        multiply.Multiplying();
                        break;
                    case "Division":
                        divid.Dividing();
                        break;
                    case "Exit":
                        Console.WriteLine("Goodbye!");
                        Environment.Exit(0);
                        exist = true;
                        break;

                }



            }
            while (!exist);

           




        }

    }

}
