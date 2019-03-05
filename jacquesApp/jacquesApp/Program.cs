using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Enter 1 for Calculator or 2 for Bank");

            int app = int.Parse(Console.ReadLine());



            if (app == 1)
            {
                Console.Clear();
                Calulator();


            }

            else if (app == 2)
            {
                Console.Clear();
                Bank();

            }

        }



        public static void Calulator()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;



            Console.WriteLine("Enter your calculation");

            Double num1 = double.Parse(Console.ReadLine());

            string calulation = Console.ReadLine();

            Double num2 = double.Parse(Console.ReadLine());

            double resalt = 0;

            if (calulation == "+")
            {

                Add(num1, num2);
                resalt = num1 + num2;


            }


            else if (calulation == "/")
            {

                resalt = num1 / num2;

            }

            else if (calulation == "-")
            {
                resalt = num1 - num2;


            }


            else if (calulation == "*")
            {

                resalt = num1 * num2;

            }

            Console.Write(num1 + calulation + num2 + "=" + resalt);

            Console.ReadLine();

        }

        static void Add(double num1, double num2)
        {
            Console.WriteLine("{0}", num1 + num2);
        }


        static void Divide(double num1, double num2)
        {

            Console.WriteLine("{0}", num1 / num2);


        }

        static void Multiply(double num1, double num2)
        {

            Console.WriteLine("{0}", num1 * num2);

        }

        static void Minus(double num1, double num2)
        {

            Console.WriteLine("{0}", num1 - num2);

        }


        public static void Bank()
        {

            Console.ForegroundColor = ConsoleColor.Green;


            int pin = 123;
            decimal savings = 100.00M;



            Console.WriteLine("Please enter your firstname: ");
            string firstname = Console.ReadLine();

            Console.WriteLine("Please enter your lastname: ");
            string lastname = Console.ReadLine();

            Console.WriteLine("Please enter your age");
            int age = int.Parse(Console.ReadLine());


            Console.Write(firstname + " " + lastname + " ");

            Console.WriteLine("Enter pin");
            pin = int.Parse(Console.ReadLine());

            if (pin == 123 && age == 17 && firstname == "Jacques" && lastname == "Rockell")
            {

                Console.WriteLine("Unlocked");

                Console.WriteLine("Enter withdraw ammount:");
                decimal withdraw = decimal.Parse(Console.ReadLine());

                Console.WriteLine(firstname + " " + lastname + " " + "Savings$" + savings + "-" + "$" + withdraw);

                savings = savings - withdraw;

                Console.WriteLine("Your new ballence is $" + savings);
            }

            else
            {
                Console.WriteLine("Locked");

            }




            Console.ReadLine();


        }



    }


}