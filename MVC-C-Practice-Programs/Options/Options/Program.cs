using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Options
{
    class OptionalParams
    {
        
            public static int AddNumbers(int a, int b, params object[] RestOfNumbers)
            {
                int result = a + b;

                if (!(RestOfNumbers == null))
                {
                    foreach (int num in RestOfNumbers)
                    {
                        result += num;
                    }
                }
                return result;
            }
            

	        public static void Main(string[] args)
            {
                Console.WriteLine(AddNumbers(10, 20, 30,40,653486,76238));
                Console.ReadLine(); 
            }
        }
    }

