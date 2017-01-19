using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConvert
{
    public enum currencyType
    {
        USD, JPY, EUR, BTC,
    }
    
    public class Money
    {

        public double valueToConvert;
        public currencyType convertFromType;
        public currencyType convertToType;
        public double conversionFactor;
        public double convertedValue;
        public double convertToFact;
        public double convertFromFact;
        private List<currencyType> typeList = new List<currencyType> { currencyType.USD, currencyType.JPY, currencyType.EUR, currencyType.BTC };
        private List<double> convFactList = new List<double> { .7541, 86.3800, .7090, .0009 };
        public List<string> symbol = new List<string> { "$", "¥", "€", "Ƀ" };
        public int toTypeIndex;
        public int fromTypeIndex;
        public string convertedSymbol;

        public Money()
        {
        }


        public Money(double _valueToConvert, currencyType _convertFromType, currencyType _convertToType)
        {
            valueToConvert = _valueToConvert;
            convertFromType = _convertFromType;
            convertToType = _convertToType;

            toTypeIndex = typeList.IndexOf(convertToType);
            fromTypeIndex = typeList.IndexOf(convertFromType);

            convertToFact = convFactList[toTypeIndex];
            convertFromFact = convFactList[fromTypeIndex];

            conversionFactor = convertToFact / convertFromFact;
        }
        public virtual string ConvertSymbol()
        {
            convertedSymbol = symbol[toTypeIndex];
            return convertedSymbol;
        }
    

        public virtual double Calculate()
        {
            convertedValue = valueToConvert * conversionFactor;
            return convertedValue;

        }

    }
}
