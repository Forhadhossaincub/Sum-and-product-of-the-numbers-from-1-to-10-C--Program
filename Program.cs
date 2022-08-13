using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_and_product_of_the_numbers_from_1_to_10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int prod;
            int sum;
            int i;
            sum = 0;
            prod = 1;
            for (i = 1; i <= 10; i++)
            {
                sum = sum + i;
                prod = prod * i;

            }


            Console.WriteLine("Sum is " + sum);
            Console.WriteLine("Product is " + prod);

            Console.ReadKey();


        }
    }
}
