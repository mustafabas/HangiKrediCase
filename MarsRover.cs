using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangiKredi
{
	public class MarsRover
	{



		public int x = 0;
		public int y = 0;
		public byte route =(byte)EnumRoute.N;

		public MarsRover(int x, int y, byte route)
		{
			this.x = x;
			this.y = y;
			this.route = route;
		}

		public void setPosition(int x, int y, byte route)
		{
			this.x = x;
			this.y = y;
			this.route = route;

		}
        public void process(String s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'L')
                {
                    turnLeft();
                }
                else if (s[i] == 'R')
                {
                    turnRight();
                }
                else
                {
                    move();
                }
            }
        }

        public void move()
        {
            if (this.route == (byte)EnumRoute.N)
            {
                this.y++;
            }
            else if (this.route == (byte)EnumRoute.E)
            {
                this.x++;
            }
            else if (this.route == (byte)EnumRoute.S)
            {
                this.y--;
            }
            else if (this.route == (byte)EnumRoute.W)
            {
                this.x--;
            }
        }

        public void turnRight()
        {
            if (this.route + 1 > (byte)EnumRoute.W)
            {
                this.route = (byte)EnumRoute.N;
            }
            else
            {
                this.route++;
            }
        }

        public void turnLeft()
        {
            if (this.route - 1 < (byte)EnumRoute.N)
            {
                this.route = (byte)EnumRoute.W;
            }
            else
            {
                this.route = (byte)(route - 1);
            }
        }


        public void printLocation()
        {
            String temp;
            if (this.route == (byte)EnumRoute.N)
            {
                temp = "N";
            }
            else if (this.route == (byte)EnumRoute.E)
            {
                temp = "E";
            }
            else if (this.route == (byte)EnumRoute.S)
            {
                temp = "S";
            }
            else
            {
                temp = "W";
            }

           Console.WriteLine(x + " " + y + " " + temp);
        }


    }
}
