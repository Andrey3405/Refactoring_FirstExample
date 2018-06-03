using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactory_FirstExample
{
    class Movie
    {
        public const int CHILDRENS = 2;
        public const int REGULAR = 0;
        public const int NEW_RELEASE = 1;

        private string _title;
        private int _priceCode;

        public string Title
        {
            get => _title;
        }

        public int PriceCode
        {
            get => _priceCode;
            set => _priceCode = value;
        }

        public Movie(string title, int priceCode)
        {
            _title = title;
            PriceCode = priceCode;
        }
    }
}
