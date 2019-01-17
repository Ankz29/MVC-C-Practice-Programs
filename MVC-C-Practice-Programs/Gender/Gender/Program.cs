using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gender
{
    class Program
    {
        static void Main(string[] args)
        {

            Customer[] custom = new Customer[4];

            custom[0] = new Customer
            {
                Name = "Ankita",
                Gendr = Genderr.female 
            };
            custom[1] = new Customer
            {
                Name = "Ankit",
                Gendr = Genderr.male
            };

            custom[2] = new Customer
            {
                Name = "anisha",
                Gendr = Genderr.female 
            };
            custom[3] = new Customer
            {
                Name = "xyz",
                Gendr = Genderr.unknown 
            };

            foreach (Customer c in custom)
            {
                Console.WriteLine("Name=  "+ c.Name+ " Gender= "+ GetGender(c.Gendr));
            }

            Console.ReadKey();
        }

        public static string GetGender(Genderr Gendr)
        {
            switch (Gendr)
            {
                case Genderr.unknown :
                    return "unknown";
                case Genderr.male :
                    return "male";
                case Genderr.female :
                    return "Female";
                default:
                    return "please check and retry";

            }

        }

    }

    public enum Genderr
    {
        male,
        female, 
        unknown
    }
    class Customer
    {
        public string Name { get; set; }
        public Genderr Gendr { get; set; }


    }
}

    

