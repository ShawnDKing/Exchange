using System;

namespace Exchange
{
    class Program
    {
        static void Main(string[] args)
        {
            string fromCurrency = " ";
            string toCurrency = " ";
            int total = 1;

            Console.WriteLine("Welcome to the currency echange system");
            Console.WriteLine("Available currencies are: (USD) US Dollar, (GBP) British Pound, (CAN) Canadian Dollar, or (EUR) Euro");

            Console.WriteLine("Would you like to convert currency now? (Y or N)");

            string answer = Console.ReadLine();
            string choice = answer.ToUpper();
            while (choice == "Y")
            {
                Console.WriteLine("Please select your currency you want to convert FROM (Example - USD): ");
                fromCurrency = Console.ReadLine();

                Console.WriteLine("Please select your currency you want to convert TO (Example - USD): ");
                toCurrency = Console.ReadLine();



                Console.WriteLine("The exchange rate in us dollars is: ");
            }

            Console.WriteLine("Your total currency in USD = " + total);
            Console.WriteLine("Thank you for using the currency exchange.");
        }
    }
}
