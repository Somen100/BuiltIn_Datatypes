using System;

namespace BuiltIn_Datatypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1st Q");
            int noOfContainers = 80;
            Console.WriteLine(noOfContainers +"\n");

            Console.WriteLine("2nd Q");
            bool pass = true;
            Console.WriteLine(pass + "\n");

            Console.WriteLine("3rd Q");
            Console.WriteLine("Enter a float value");
            float floatvalue= float.Parse( Console.ReadLine());
            Console.WriteLine("The float number is"+ floatvalue + "\n");

            Console.WriteLine("4th Q: + - * /");
            float num1, num2, result; char sign;
            Console.WriteLine("Enter 1st value");
             num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd value");
            num2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Select anyone operator from keyboard: + , - , * , + ");
            sign =char.Parse(Console.ReadLine());

            switch (sign)
            {

                case '+':
                    result = num1 + num2;
                    Console.WriteLine($"Sum: {result}");
                    break;

                case '-':
                    result = num1 - num2;
                    Console.WriteLine($"Difference: {result}");
                    break;

                case '*':
                    result = num1 * num2;
                    Console.WriteLine($"Product: {result}");
                    break;

                case '/':
                    if(num2== 0)
                    {
                        Console.WriteLine("Please enter not null divisor");
                        break;
                    }

                    result = num1 / num2;
                    Console.WriteLine($"Quotient: {result}");
                    break;
            }
            Console.WriteLine("5th Q:Revere a 3 letters string");
            
            Console.WriteLine("Enter 1st character");
            char char1 = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd character");
            char char2 = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter 3rd character");
            char char3 = char.Parse(Console.ReadLine());


            Console.WriteLine($"Reverse output of { char1 }{ char2 }{ char3} is { char3 }{ char2 }{ char1}");
            Console.WriteLine("*************");

            Console.WriteLine("6th Q:Check the input character");

            Console.WriteLine("Enter the character");
            char char4 = char.Parse(Console.ReadLine());
            bool numCheck = Char.IsNumber(char4);
            if (numCheck)
            {
                Console.WriteLine($"{numCheck} is a number");

            }

            bool letterCheck = Char.IsLetter(char4);
            if (letterCheck)
            {
                Console.WriteLine($"{char4} is a letter");

            }
          

            bool lowerCheck = Char.IsLower(char4);
            if (lowerCheck)
            {
                Console.WriteLine($"{char4} is a lower case letter");
            }
            

            bool upperCheck = Char.IsUpper(char4);
            if (upperCheck)
            {
                Console.WriteLine($"{char4} is an upper case letter");
            }

            Console.Read();
        }
    }
}
