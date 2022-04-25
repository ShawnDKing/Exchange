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

        public static double ReturnExchangeRate(double From, double To)
        {

            double Num1 = From;
            double Num2 = To;
            double Answer = Num1 * Num2;
            return Answer;
        }

        public static double addUSD()
        {
            double USD = 1.00;
            return USD;
        }
        static double addGBP()
        {
            double GBP = 0.72523;
            return GBP;
        }
        public static double addCAN()
        {
            double CAN = 1.25427;
            return CAN;
        }
        public static double addEUR()
        {
            double EUR = 0.83572;
            return EUR;
        }
        

    }

}
