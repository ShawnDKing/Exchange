using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange

{
    

    public class ExchangeMonitor 
    {

        private int convertCount = 0;
        //private double grandTotal;

        public double ExchangeTracker(double one, double two)
        {
            //keep track of num times ran and grand total of exchanges in USD
            convertCount++;
            double _grandTotal = one + two;
            // format to two decimal places - String.Format("{0:0.00}"
            return _grandTotal;
          
        }
    }
}
    
        
       



