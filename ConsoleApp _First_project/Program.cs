using System;

namespace ConsoleApp__First_project
{
    class Program
    {
        static void Main(string[] args)
        {


            /* Console.WriteLine("Enter a number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a second number: ");
             int number2 = Convert.ToInt32(Console.ReadLine());*/
            // i changed int to double for use of decimals



            string welc = "Welcome to the Calculator! ";
            Console.WriteLine(welc);
           
            bool is_calculating = true;

            while (is_calculating)
            {
              
                    Console.WriteLine("Please enter a number: ");
                double number1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter operator: ");
                Console.WriteLine("1 - subtraction");
                Console.WriteLine("2 - addition");
                Console.WriteLine("3 - division");
                Console.WriteLine("4 - multiplication");

                int op = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter a second number: ");
                double number2 = Convert.ToDouble(Console.ReadLine());



                static double AdditionMethod(double number1, double number2)
                {
                    return number1 + number2;
                }
                static double SubtractionMethod(double number1, double number2)
                {
                    return number1 - number2;
                }
                static double DivisionMethod(double number1, double number2)
                {


                    return number1 / number2;
                    
                   
                }
                static double MultiplicationMethod(double number1, double number2)
                {
                    return number1 * number2;
                }

                switch (op)
                {
                    case 1:
                        Console.WriteLine($"{number1} - {number2} = " + SubtractionMethod(number1, number2 ));
                        break;
                    case 2:
                        Console.WriteLine($"{number1} + {number2} = " + AdditionMethod(number1, number2 ));
                        break;
                    case 3:
                       
                        if (number2 == 0)
                        {
                            Console.WriteLine("you can not divide by zero!");

                        }
                        else
                        {
                            Console.WriteLine($"{number1} / {number2} = " + DivisionMethod(number1, number2));
                        }

                        break;
                    case 4:
                        Console.WriteLine($"{number1} * {number2} = " + MultiplicationMethod(number1, number2));
                        break;


                    default:
                        Console.WriteLine("invalid operation");
                        break;
                }

                bool NorY = true;
                
                while (NorY)
                {

                    Console.WriteLine("Do you wish to calculate something else? y/n");
                    string cont_string = Console.ReadLine();

                    switch (cont_string)
                    {

                        case "y":
                            Console.WriteLine("Restarting program");
                            NorY = false;
                            break;
                        case "n":
                            is_calculating = false;
                            NorY = false;
                            break;

                        default:
                            Console.WriteLine("Please answer again!");
                            break;
                    }
                }



              

            }

            


         
            
            
            
            //  int number = Convert.ToInt32("");
            //Console.WriteLine(number + );







        }

        private static string AdditionMethod(double number1, double number2)
        {
            throw new NotImplementedException();
        }
    }
}
