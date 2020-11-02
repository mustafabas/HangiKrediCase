using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangiKredi
{
    class Program
    {
        static void Main(string[] args)
        {

             bool close = true;
       
            while (close)
            {
                Console.WriteLine("First Line Input:");
                string inputa = Console.ReadLine();
                Console.WriteLine("Second Line Input:");

                string input = Console.ReadLine();
                string[] inputNew = input.Split(' ');
                int x = Convert.ToInt32(inputNew[0]);
                int y = Convert.ToInt32(inputNew[1]);
                string location = inputNew[2];

                Console.Write("Third Line Input : ");
                string command = Console.ReadLine();


                MarsRover marsRover = new MarsRover(0, 0, 1);
                var route = (EnumRoute)Enum.Parse(typeof(EnumRoute), location);
                marsRover.setPosition(x, y, (byte)route);
                
                marsRover.process(command);
                marsRover.printLocation();

                Console.WriteLine("To Finish Application Click To Y OR To Go On N");
                string finish = Console.ReadLine();
                if (finish.ToUpper().Equals("Y"))
                {
                    Environment.Exit(0);

                }

            }



            Console.ReadKey();
        }
    }
}
