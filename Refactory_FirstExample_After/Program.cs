using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactory_FirstExample_After
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer("Customer1");

            Movie comedy = new Movie("Комедия", 1);
            Movie horror = new Movie("Ужасы", 0);

            customer.AddRental(new Rental(comedy, 5));
            customer.AddRental(new Rental(horror, 10));

            Console.WriteLine(customer.Statement());

            Console.ReadKey();
        }
    }
}
