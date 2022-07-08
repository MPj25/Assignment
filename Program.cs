// See https://aka.ms/new-console-template for more information
using System;
namespace Calculaton
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true){
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine("Hello, kindly Input your name");
                Console.ResetColor();

                string inputName = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Hello {0}", inputName);

                Console.WriteLine("Please input your Salary");
                Console.ResetColor();

                double input = Convert.ToDouble(Console.ReadLine());

                double rate;
                double tax;
                double relieve;
                double deduction;
                double takehome;



                if (input < 50000)
                {
                    relieve = 4605;
                    rate = 0.12;
                    tax = input * rate;
                    deduction = tax - relieve;
                    takehome = input - deduction;

                    Console.ForegroundColor = ConsoleColor.Magenta;

                    Console.WriteLine($" Your Tax is {tax}");
                    Console.WriteLine($" Your Relieve is {relieve}");
                    Console.WriteLine($" After all expenses, your Takehome is {takehome}");

                    Console.ResetColor();
                }
                else if (input < 500000)
                {
                    relieve = 7230;
                    rate = 0.18;
                    tax = input * rate;
                    deduction = tax - relieve;
                    takehome = input - deduction;

                    Console.ForegroundColor = ConsoleColor.Magenta;

                    Console.WriteLine($" Your Tax is {tax}");
                    Console.WriteLine($" Your Relieve is {relieve}");
                    Console.WriteLine($" After all expenses, your Takehome is {takehome}");

                    Console.ResetColor();
                }
                else if (input > 500000)
                {
                    relieve = 10050;
                    rate = 0.25;
                    tax = input * rate;
                    deduction = tax - relieve;
                    takehome = input - deduction;

                    Console.ForegroundColor = ConsoleColor.Magenta;

                    Console.WriteLine($" Your Tax is {tax}");
                    Console.WriteLine($" Your Relieve is {relieve}");
                    Console.WriteLine($" After all expenses, your Takehome is {takehome}");
                   
                    Console.ResetColor();
                }

               Console.WriteLine(" Thanks for contacting us");

                Console.WriteLine("Do you want to continue? [Y or N]");
                  
                //Get answers
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                    
                }
                else
                {
                    return;
                    //Console.WriteLine(" Thanks for contacting us");

                }
            }
        }
    }
}
