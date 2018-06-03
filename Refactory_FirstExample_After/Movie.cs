using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactory_FirstExample_After
{
    class Movie
    {
        public const int CHILDRENS = 2;
        public const int REGULAR = 0;
        public const int NEW_RELEASE = 1;

        private string _title;
        private Price _price;

        public string Title
        {
            get => _title;
            private set => _title = value;
        }

        public Price Price
        {
            get => _price;
            set => _price = value;
        }

        public void SetPriceCode(int value)
        {
            switch (value)
            {
                case REGULAR:
                    Price = new RegularPrice();
                    break;
                case CHILDRENS:
                    Price = new ChildrensPrice();
                    break;
                case NEW_RELEASE:
                    Price = new NewReleasePrice();
                    break;
                default:
                    throw new ArgumentException("Incorrect Price Code");
            }

        }

        public Movie(string title, int priceCode)
        {
            Title = title;
            SetPriceCode(priceCode);
        }

        public double GetCharge(int daysRented)
        {
            return Price.GetCharge(daysRented);
        }
    }
}
