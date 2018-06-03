using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactory_FirstExample_After
{
    abstract class Price
    {
        public abstract int PriceCode{ get;}
        public abstract double GetCharge(int daysRented);
        public virtual int GetFrequentRenterPoints(int daysRented)
        {
            return 1;
        }
    }

    class ChildrensPrice: Price
    {
        public override int PriceCode
        {
            get => Movie.CHILDRENS;
        }

        public override double GetCharge(int daysRented)
        {
            double result = 1.5;
            if (daysRented > 3)
                result += (daysRented - 3) * 1.5;
            return result;
        }
    }

    class NewReleasePrice : Price
    {
        public override int PriceCode
        {
            get => Movie.NEW_RELEASE;
        }

        public override double GetCharge(int daysRented)
        {
            return daysRented * 3;
        }

        public override int GetFrequentRenterPoints(int daysRented)
        {
            return (daysRented > 1) ? 2 : 1;
        }
    }

    class RegularPrice: Price
    {
        public override int PriceCode
        {
            get => Movie.REGULAR;
        }

        public override double GetCharge(int daysRented)
        {
            double result = 2;
            if (daysRented > 2)
                result += (daysRented - 2) * 1.5;
            return result;
        }
    }
}
