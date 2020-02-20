using System;

namespace IterativeStatement_JacobRudek
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter an integer value between 2 and 10");


            int y = Convert.ToInt32(Console.ReadLine());

            if (y % 2 == 1)
            {

                for (int i = 0; i < y - 1; i++)

                Console.WriteLine("You entered an odd number");

            }
            else
            {

                for (int i = 0; i < y + 1; i++)

                Console.WriteLine("You entered an even number");

            }

        }



    }
            }





           
        
    

