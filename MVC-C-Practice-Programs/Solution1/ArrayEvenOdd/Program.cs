using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayEvenOdd
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Array elements are: ");
        
            int[] b = { 2, 4, 6, 8, 5, 4, 9 };
            for (int i = 0; i <= 6; i++)
            {
                Console.WriteLine(b[i] + "--->" + i);

            }
            

            int countEven=0, countOdd = 0;
            for (int i = 0; i <= 6; i++)
            {
                if(b[i]%2==0)
                {
                    countEven++;
                    
                }
                else if(b[i]%2==1)
                {
                    countOdd++;
                   
                }

            }
            Console.WriteLine("even: " +countEven);
            Console.WriteLine("odd :"+ countOdd);
            Console.ReadKey();


           
        }
    }
}
