﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConvert
{
    class Program
    {
        static void Main(string[] args)
        {

            Money convertedMoney = new ConvertedMoney(1, currencyType.USD, currencyType.EUR);
            double converted = convertedMoney.Calculate();
            string convertSymbol = convertedMoney.ConvertSymbol();
            
            Console.WriteLine($"{convertSymbol}{converted}");


        }
    }
}
