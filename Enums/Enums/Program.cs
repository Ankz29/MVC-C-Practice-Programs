using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values=(int[])Enum.GetValues(typeof(Gender));


            foreach (int Val in values )
            {
                Console.WriteLine(Val); 
            }

            string [] Names=(string[])Enum.GetNames(typeof(Gender));

            foreach (string Nam in Names)
            {
                Console.WriteLine(Nam);
            }

        }


    }

    public enum Gender
    {
        male,
        female,
        unknown
    }
}
