using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactory_FirstExample_After
{
    class Customer
    {
        private string _name;
        private List<Rental> rentals = new List<Rental>();

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
            rentals.Add(arg);
        }

        private double AmountFor(Rental rental)
        {
            return rental.GetCharge();
        }

        private double GetTotalCharge()
        {
            double result = 0;
            rentals.ForEach(rental => result += rental.GetCharge());
            return result;
        }

        private int GetTotalFrequentRenterPoints()
        {
            int result = 0;
            rentals.ForEach(rental => result += rental.GetFrequentRenterPoints());
            return result;
        }

        public string Statement()
        {
            string result = "Прокат " + Name + "\n";

            foreach (Rental rental in rentals)
            {
                //Вывод результатов для каждого проката
                result += $"\t{rental.Movie.Title}\t" +
                    $"{rental.GetCharge()} {Environment.NewLine}";
            }

            result += $"Сумма задолженности: {GetTotalCharge()} {Environment.NewLine}";
            result += $"Вы заработали {GetTotalFrequentRenterPoints()} бонусных очков";
            return result;
        }
    }
}
