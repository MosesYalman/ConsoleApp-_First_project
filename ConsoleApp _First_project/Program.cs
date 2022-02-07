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

                Console.Write("Enter operator: ");
                string op = Console.ReadLine();


                Console.WriteLine("Enter a second number: ");
                double number2 = Convert.ToDouble(Console.ReadLine());

                if (op == "+")
                {
                    Console.WriteLine(number1 + number2);
                }
                else if (op == "-")
                {
                    Console.WriteLine(number1 - number2);
                }
                else if (op == "*")
                {
                    Console.WriteLine(number1 * number2);
                }
                else if (op == "/")
                {
                    Console.WriteLine(number1 / number2);

                    if (number2 == 0)

                        Console.WriteLine("You cannot divide by 0.");
                  
                }
                else
                {
                    Console.WriteLine("you entered an invalid operator");

                }
                
                
                   
                


                Console.WriteLine("Do you wish to calculate something else? yes/no");
                string cont_string = Console.ReadLine();
                if(cont_string == "no")
                {
                    is_calculating = false;
                }
                else if(cont_string != "yes")
                {
                    Console.WriteLine("invalid option, restarting program");
                }

            }




         
            
            
            
            //  int number = Convert.ToInt32("");
            //Console.WriteLine(number + );







        }
    }
}
