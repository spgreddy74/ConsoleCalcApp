using System;

namespace ConsoleCalcApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double numA;
            double numB;
            String operation;
            double output;
            var keepAlive = true;


            while(keepAlive)
            {
                //Use try - catch block to handle exceptions 
                Console.WriteLine("Enter number :");
                numA = Convert.ToDouble(Console.ReadLine());

                //Use try - catch block to handle exceptions
                Console.WriteLine("Enter number :");
                numB = Convert.ToDouble(Console.ReadLine());  

                Console.WriteLine("Enter the operation '+ - * /' to perform");
                operation = Console.ReadLine();

                // put each case a method 
                switch(operation)
                {
                    case "+":
                        output = numA + numB;
                        Console.WriteLine("{0} + {1} = {2}", numA, numB, output);
                        break;

                    case "-":
                        output = numA - numB;
                        Console.WriteLine("{0} - {1} = {2}", numA, numB, output);
                        break;

                    case "*":
                        output = numA * numB;
                        Console.WriteLine("{0} * {1} = {2}", numA, numB, output);
                        break;

                    case "/":
                        output = numA / numB;
                        Console.WriteLine("{0} / {1} = {2}", numA, numB, output);
                        break;

                    case "-1":
                        keepAlive = false;
                        break;

                    default:
                        output = 0;
                        break;
                }

                
                
            }

        }
    }

}

