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
        public static double _fromCurrency;
        public static double _toCurrency;
        public static int total = 0;

        static Exchanger()
        {
           double From = _fromCurrency;
            double To = _toCurrency;
            total++;
        }
        static double ConvertCurrency(double From, double To)
        {
            double exchangeRate = From * To;
            return exchangeRate;
        }

        static double USD(double cashIn)
        {
            double USD = 1;
            return USD;
        }
        static double GBP(double cashIn)
        {
            double GBP = 0.72523;
            return GBP;
        }
        static double CAN(double cashIn)
        {
            double CAN = 0.72523;
            return CAN;
        }
        static double EUR(double cashIn)
        {
            double EUR = 0.72523;
            return EUR;
        }
        

    }

}
