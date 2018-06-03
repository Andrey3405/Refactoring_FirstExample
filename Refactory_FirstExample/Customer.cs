using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactory_FirstExample
{
    class Customer
    {
        private string _name;
        private ArrayList _rentals = new ArrayList();

        public string Name
        {
            get => _name;
            private set => _name = value;
        }

        public Customer(string name)
        {
            Name = name;
        }

        public void AddRental(Rental arg)
        {
            _rentals.Add(arg);
        }

        public string Statement()
        {
            double totalAmount = 0;
            int frequentRenterPoints = 0;
            IEnumerable rentals = _rentals;
            string result = "Прокат " + Name + "\n";

            foreach(Rental rental in rentals)
            {
                double thisAmount = 0;
                Rental each = rental;

                switch (rental.Movie.PriceCode)
                {
                    case Movie.REGULAR:
                        thisAmount += 2;
                        if (each.DaysRented > 2)
                            thisAmount += (each.DaysRented - 2) * 1.5;
                        break;
                    case Movie.NEW_RELEASE:
                        thisAmount += each.DaysRented * 3;
                        break;
                    case Movie.CHILDRENS:
                        thisAmount += 1.5;
                        if (each.DaysRented > 3)
                            thisAmount += (each.DaysRented - 3) * 1.5;
                        break;
                }

                frequentRenterPoints++;

                if ((each.Movie.PriceCode == Movie.NEW_RELEASE) &&
                    each.DaysRented > 1) frequentRenterPoints++;

                result += "\t" + each.Movie.Title +"\t" + thisAmount.ToString() + "\n";
                totalAmount += thisAmount;
            }

            result += "Сумма задолженности: " + totalAmount.ToString() + "\n";
            result += "Вы заработали " + frequentRenterPoints.ToString() + " бонусных очков";
            return result;
        }
    }
}
