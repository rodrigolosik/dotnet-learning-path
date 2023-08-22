using System;

namespace Delegate.Console.LiquidSalaryCalculator
{
    internal class Program
    {
        private delegate void TaxCalculatorDelegate(double salary);
        private delegate void ProcessDiscountsDelegate(double salary);

        static void Main(string[] args)
        {
            TaxCalculatorDelegate taxCalculatorHandler = TaxCalculator;
            ProcessDiscountsDelegate processDiscountHandler = ProcessDiscounts;

            LiquidSalaryCalculator(taxCalculatorHandler, processDiscountHandler, 5000);
        }

        private static void TaxCalculator(double salary)
        {
            // Implement tax calculation logic here
            // For example:
            double tax = salary * 0.2; // 20% tax
        }

        private static void ProcessDiscounts(double salary)
        {
            // Implement discount processing logic here
            // For example:
            double discount = salary * 0.1; // 10% discount
        }

        static double LiquidSalaryCalculator(TaxCalculatorDelegate taxCalculator, ProcessDiscountsDelegate processDiscounts, double salary)
        {
            return 0;
        }
    }
}