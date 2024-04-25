using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Сonsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("\r\n1. 5 + 3 =\r\n2. 10 - 4 =\r\n3. 6 * 2 =\r\n4. 12 + 7 =\r\n5. 20 - 9 =\r\n6. 4 * 5 =");
            while (true)
            {
                int choice = 0;
                Console.WriteLine("Mathematic Battle");
                Console.WriteLine("write number 1: ");
                string number_1 = "empty";
                number_1 = Console.ReadLine();
                Console.WriteLine("write number 1: ");
                string number_2 = "empty";
                number_2 = Console.ReadLine();
                Console.WriteLine("Choose what you want: \n1.Adding\r\n2.Subtraction\r\n3.Division\r\n4.Multiplication\r\n5.Adding the individual values of a 3 digit number together\r\n6.Exit from program");
                Console.WriteLine("Choose and put number from 1 to 5");

                choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    int numb_1 = 0, numb_2 = 0;
                    numb_1 = int.Parse(number_1);
                    numb_2 = int.Parse(number_2);
                    Console.WriteLine($"Result: {numb_1 + numb_2}");
                    continue;
                }

                if (choice == 2)
                {
                    int numb_1 = 0, numb_2 = 0;
                    numb_1 = int.Parse(number_1);
                    numb_2 = int.Parse(number_2);
                    Console.WriteLine($"Result: {numb_1 - numb_2}");
                    continue;
                }

                if (choice == 3)
                {
                    int numb_1 = 0, numb_2 = 0;
                    numb_1 = int.Parse(number_1);
                    numb_2 = int.Parse(number_2);
                    Console.WriteLine($"Result: {numb_1 * numb_2}");
                    continue;
                }

                if (choice == 4)
                {
                    int numb_1 = 0, numb_2 = 0;
                    numb_1 = int.Parse(number_1);
                    numb_2 = int.Parse(number_2);
                    Console.WriteLine($"Result: {numb_1 / numb_2}");
                    continue;
                }

                if (choice == 5)
                {
                    Console.WriteLine("Enter a three-digit number:");
                    int number = int.Parse(Console.ReadLine());


                    int digit_1 = number / 100;
                    int digit_2 = (number / 10) % 10;
                    int digit_3 = number % 10;
                    int sum = digit_1 + digit_2 + digit_3;
                    Console.WriteLine("Sum of the individual digits: " + sum);
                    continue;
                }

                if (choice == 6)
                {
                    Console.Write("\nThank you for using our App for high level dificult calculations!");
                    break;
                }

                else
                {
                    Console.Write("\nUuuuuups something going wrong! Try again!");
                }

            }


        }


    }
};