using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactory_FirstExample_After
{
    class Rental
    {
        private Movie _movie;
        private int _daysRented;

        public int DaysRented
        {
            get => _daysRented;
            private set => _daysRented = value;
        }

        public Movie Movie
        {
            get => _movie;
            private set => _movie = value; 
        }

        public Rental(Movie movie, int daysRented)
        {
            Movie = movie;
            DaysRented = daysRented;
        }

        public int GetFrequentRenterPoints()
        {
            return Movie.Price.GetFrequentRenterPoints(DaysRented);
        }

        public double GetCharge()
        {
            return Movie.GetCharge(DaysRented);
        }
    }
}
