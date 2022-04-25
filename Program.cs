using System;


namespace Exchange
{
    class Program
    {
        static void Main(string[] args)
        {
           
            ConsoleKeyInfo  keyInfo;
            string _fromCurrency;
            string _toCurrency;
            
            //double _total;
            do
            {
                ExchangeMonitor Xchange = new ExchangeMonitor();
                Console.WriteLine("Welcome to the currency exchange system");
                Console.WriteLine("Available currencies are: (USD) US Dollar, (GBP) British Pound, (CAN) Canadian Dollar, or (EUR) Euro");

                Console.WriteLine("Please select your currency you want to convert FROM (Example - USD): ");
                
                _fromCurrency = Console.ReadLine(); 
                //if (_fromCurrency == "USD")
                //{ _fromCurrency = Exchanger.addUSD(); }
                Console.WriteLine("\n");
                
                
                Console.WriteLine("Please select your currency you want to convert TO (Example - GBP): ");
                _toCurrency = Console.ReadLine();
                //**issue cannot convert from string to double**
                //how to make it go from "USD"string to  call the $1 from Exchanger
                Console.WriteLine("\n");


                //Console.WriteLine("Your currency exchange rate is : " + Xchange.ExchangeTracker());
                //how to get the currency rate over to here (if statements like if (_fromCurrency == "USD" then _fromCurrency = Exchanger.USD() which caused errors or ??
                Console.WriteLine("\n");
               
                Console.WriteLine("Would you like to continue? (Y or N)");
                keyInfo = Console.ReadKey();
                Console.Clear();
            } while (keyInfo.Key == ConsoleKey.Y);


            Console.WriteLine("Thank you for using the currency exchange system.");
            Console.WriteLine();
           

              
        }
    }
}
