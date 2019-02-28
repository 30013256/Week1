/*fowrdslash star is for multi line*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jacquesApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.White;


            int pin = 123;
            decimal savings = 100.00M;



            Console.WriteLine("Please enter your firstname: ");
            string firstname = Console.ReadLine();

            Console.WriteLine("Please enter your lastname: ");
            string lastname = Console.ReadLine();

            Console.WriteLine("Please enter your age");
            int age = int.Parse(Console.ReadLine());


            Console.Write (firstname + " " + lastname+" ");

            Console.WriteLine("Enter pin");
            pin = int.Parse (Console.ReadLine());

            if (pin == 123 && age == 17 && firstname == "Jacques" && lastname == "Rockell")
            {

                Console.WriteLine("Unlocked");

                Console.WriteLine("Enter withdraw ammount:");
                decimal withdraw = decimal.Parse(Console.ReadLine());

                Console.WriteLine(firstname + " " + lastname + " " + "Savings$" + savings+"-" + "$" + withdraw);

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
