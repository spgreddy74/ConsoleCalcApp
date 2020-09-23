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
                //Use try - catch block to handle number format exception  
                Console.WriteLine("Enter number :");
                numA = Convert.ToDouble(Console.ReadLine());
                
                
                     

                //Use try - catch block to handle exceptions
                Console.WriteLine("Enter number :");
                numB = Convert.ToDouble(Console.ReadLine());  
                
                
                Console.WriteLine("Enter the operation '+ - * /' to perform");
                operation = Console.ReadLine();

                // put each case as a method 
                switch(operation)
                {
                    case "+":
                        output = Add(numA, numB); 
                        Console.WriteLine("{0} + {1} = {2}", numA, numB, output);
                        break;

                    case "-":
                        output = Sub(numA, numB);
                        Console.WriteLine("{0} - {1} = {2}", numA, numB, output);
                        break;

                    case "*":
                        output = Mul(numA, numB);
                        Console.WriteLine("{0} * {1} = {2}", numA, numB, output);
                        break;

                    case "/":
                        output = Div(numA, numB);
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

            //Addition of given numbers
            static double Add(double numA, double numB)
            {
                double output = numA + numB;
                return output;
            }

            //Substraction of given numbers         
            static double Sub(double numA, double numB)
            {
                double output = numA - numB;
                return output;
            }

            //Multiplication of given numbers         
            static double Mul(double numA, double numB)
            {
                double output = numA * numB;
                return output;
            }

            //Division of given numbers         
            static double Div(double numA, double numB)
            {
                double output = numA / numB;
                return output;
            }


        }
    }

}

