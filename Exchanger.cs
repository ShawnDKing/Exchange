using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange
{
    public static class Exchanger
    {


        //manages currency exchange. Specifically, you will write methods for each currency type and exchange rate
        public static float _fromCurrency;
        public static float _toCurrency;
        public static int total = 0;

        static Exchanger()
        {
            float From = _fromCurrency;
            float To = _toCurrency;
            total++;
        }
        static float ConvertCurrency(float From, float To)
        {
            float exchangeRate = From / To;
            return exchangeRate;
        }
        

    }

}
