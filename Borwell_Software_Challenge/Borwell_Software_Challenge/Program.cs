using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Borwell_Software_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Software Challenge");
            //Accepting the value for the height in metres
            Console.WriteLine("Enter the height of the room in metres");
            decimal height = Convert.ToDecimal(Console.ReadLine());
            //Accepting the value for the length in metres
            Console.WriteLine("Enter the length of the room in metres");
            decimal length = Convert.ToDecimal(Console.ReadLine());
            //Accepting the value for the width in metres
            Console.WriteLine("Enter the width of the room in metres");
            decimal width = Convert.ToDecimal(Console.ReadLine());

            while (true)
            {
                //Selecting a calulation 
                Console.WriteLine("Select what you would like calculate: Area of the floor[1], Amount of paint needed[2]. Volume of the Room [3], Exit [0]");
                int selection = Convert.ToInt32(Console.ReadLine());

                if (selection == 1)
                {
                    //Calculating the area which is the width times the height
                    decimal area = length * width;
                    Console.WriteLine("Area of the floor is: " + area + " metres squared");

                }
                else if (selection == 2)
                {
                    //Calculating the amount of paint needed which is the area of all 4 walls
                    decimal paint = ((height * width) * 2) + ((height * length) * 2);
                    Console.WriteLine("Amount of paint needed is: " + paint + " metres squared");

                }
                else if (selection == 3)
                {
                    //Calculating the volume which the all thrre values multiplied 
                    decimal volume = length * width * height;
                    Console.WriteLine("Volume of the room is: " + volume + " metres cubed");
                }
                else if (selection == 0)
                {
                    //Exiting the application
                    Console.WriteLine("Press enter to quit");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Selection please choose again");

                }
            }
            Console.ReadLine();

        }
    }
}
