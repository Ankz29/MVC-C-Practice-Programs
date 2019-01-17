using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equals
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 20;
            int j = 20;
            Direction d1 = Direction.east;
            Direction d2 = Direction.west;


            Console.WriteLine(i.Equals(j));
            Console.WriteLine(d1.Equals(d2));

            Console.ReadLine(); 
        }

        public enum Direction
        {
            east,
            west,
            north,
            south
        }


    }
}
