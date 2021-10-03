using System;

namespace Learning
{
    class Program
    {
        static void Main(string[] args)
        {

            double num1;
            double num2;
            double result;
            bool useAgain = true;
            string response;

            while (useAgain)
            {
                response = "";

                Console.WriteLine("Enter Number 1: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter Number 2: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter an option: ");
                Console.WriteLine("+ : Add");
                Console.WriteLine("- : Minus");
                Console.WriteLine("* : Mulitply");
                Console.WriteLine("/ : Divide");

                switch (Console.ReadLine())
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine(num1 + "+" + num2 + " is: " + result);
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine(num1 + "-" + num2 + " is: " + result);
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine(num1 + "*" + num2 + " is: " + result);
                        break;
                    case "/":
                        result = num1 / num2;
                        Console.WriteLine(num1 + "/" + num2 + " is: " + result);
                        break;
                }

                Console.WriteLine("Would you like to use again? [Y/N]");
                response = Console.ReadLine();
                response = response.ToUpper();

                if (response == "Y")
                {
                    useAgain = true;
                }

                else if (response == "N")
                {
                    useAgain = false;
                }

            }


        }
    }
}
