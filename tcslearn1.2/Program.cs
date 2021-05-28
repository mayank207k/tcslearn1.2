using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tcsLearn1.2
{
    class Class1
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Basic Calculator");

            Console.WriteLine("Main Menu : \n 0 - Exit \n 1 - Add \n 2 - Subtract \n 3 - Multiply \n 4 - Divide");
            Console.WriteLine("Enter your choice from 1-4 to perform action");
            string ch = Console.ReadLine();

            int choice = Convert.ToInt32(ch);

            int A, B, result;
            do
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the first number A:");
                        A = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the second number B:");
                        B = Convert.ToInt32(Console.ReadLine());
                        result = A + B;
                        Console.WriteLine("Result: Add: sum = {0} ", result);
                        break;

                    case 2:
                        Console.WriteLine("Enter the first number A:");
                        A = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the second number B:");
                        B = Convert.ToInt32(Console.ReadLine());
                        result = A - B;
                        Console.WriteLine("Result: subtraction: difference={0} ", result);
                        break;
                    case 3:
                        Console.WriteLine("enter the first number A:");
                        A = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter the second number B:");
                        B = Convert.ToInt32(Console.ReadLine());
                        result = A * B;
                        Console.WriteLine("Result: multiplication: product={0} ", result);
                        break;

                    case 4:
                        Console.WriteLine("enter the first number A:");
                        A = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter the second number B:");
                        B = Convert.ToInt32(Console.ReadLine());
                        result = A / B;
                        Console.WriteLine("Result: division: Quotient={0} ", result);

                        break;

                    default:
                        Console.WriteLine("enter valid input");
                        break;
                }
                Console.WriteLine("Enter Your choice as below");
                Console.WriteLine("Main Menu : \n 0 - Exit \n 1 - Add \n 2 - Subtract \n 3 - Multiply \n 4 - Divide");
                ch = Console.ReadLine();
                choice = Convert.ToInt32(ch);
            } while (choice != 0);
        }
    }
}
