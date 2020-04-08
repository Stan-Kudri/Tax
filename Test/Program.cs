using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tax;

namespace Tax
{
    class Program
    {
        public static void Print(Property[] property)
        {
            for (int i = 0; i < property.Length; i++)
            {
                Console.WriteLine($"{i+1} налог на {property[i].GetType()} состовляет {property[i].TaxCalculation()}");
            }
        }

        static void Main(string[] args)
        {
            var arrayValuesTax = new Property[]
            {
                new Apparment(5000),
                new Apparment(7000),
                new Apparment(4500),
                new Car(3000),
                new Car(2750),
                new CountryHouse(4350),
                new CountryHouse(5200),
            };
            Print(arrayValuesTax);
            

            Console.Read();
        }
    }
}

