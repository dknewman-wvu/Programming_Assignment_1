using System;
namespace Programming_Assignment_1
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Enter the action to be performed");
            Console.WriteLine("Press 1 for Addition");
            Console.WriteLine("Press 2 for Subtraction");
            Console.WriteLine("Press 3 for Multiplication");
            Console.WriteLine("Press 4 for Division");
            Console.WriteLine("Press 5 for Square Root");
            Console.WriteLine("Press 6 for Exponent\n");


            int action = Convert.ToInt32(Console.ReadLine());

            double input_1 = 0;
            double input_2 = 0;

            if ((action < 5) || (action >5))
            {
                Console.WriteLine("Enter 1st input");
                input_1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter 2nd input");
                input_2 = Convert.ToDouble(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Enter 1st input");
                input_1 = Convert.ToDouble(Console.ReadLine());


            }

            double result = 0;
            switch (action)
            {
                case 1:
                    {
                        result = Addition(input_1, input_2);
                        break;
                    }
                case 2:
                    {
                        result = Subtraction(input_1, input_2);
                        break;
                    }
                case 3:
                    {
                        result = Multiplication(input_1, input_2);
                        break;
                    }
                case 4:
                    {
                        result = Division(input_1, input_2);
                        break;
                    }
                case 5:
                    {
                        result = SQRT(input_1);
                        break;
                    }
                case 6:
                    {
                        result = Exponent(input_1, input_2);
                        break;
                    }
                default:
                    Console.WriteLine("Wrong action!! try again");
                    break;
            }
            Console.WriteLine("The result is {0}", result);
            Console.ReadKey();
        }
        //Addition  
        public static double Addition(double input_1, double input_2)
        {
            double result = input_1 + input_2;
            return result;
        }
        //Substraction  
        public static double Subtraction(double input_1, double input_2)
        {
            double result = input_1 - input_2;
            return result;
        }
        //Multiplication  
        public static double Multiplication(double input_1, double input_2)
        {
            double result = input_1 * input_2;
            return result;
        }
        //Division  
        public static double Division(double input_1, double input_2)
        {
            double result = input_1 / input_2;
            return result;
        }
        public static double SQRT(double input_1)
        {
            double result = Math.Sqrt(input_1);
            return result;
        }

        public static double Exponent(double input_1, double input_2)
        {
            double result = Math.Pow(input_1, input_2);
            return result;
        }
    }
}