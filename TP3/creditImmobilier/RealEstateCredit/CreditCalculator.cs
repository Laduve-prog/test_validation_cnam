﻿using RealEstateCredit;

public class CreditCalculator
{
    public static void Main(string[] args)
    {
        if (args.Length != 3)
        {
            displayView.PrintUsage();
        }
        else
        {
            decimal loanAmount = decimal.Parse(args[0]);
            int monthsDuration = int.Parse(args[1]);
            decimal nominalRate = decimal.Parse(args[2]);

            try
            {
                MonthlyPaymentsCalculator calculator = new MonthlyPaymentsCalculator(loanAmount, monthsDuration, nominalRate);
                decimal totalAmount = calculator.CalculateTotalAmount();
            }
            catch
            {

            }
        }
    }
}

