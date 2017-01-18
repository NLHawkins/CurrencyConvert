using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConvert
{ 
 public enum currencyType
{
USD, JPY, EUR, BTC, BASE
}
/*public enum symbol
    {
        "$","
    }
*/
   
    public class Money
    {
        
        public double valueToConvert;
        public currencyType convertFromType;
        public currencyType convertToType;
        public double conversionFactor;
        public double convertedValue;
        public double convertToFact;
        public double convertFromFact;
        List<currencyType> typeList = new List<currencyType>{ currencyType.USD, currencyType.JPY, currencyType.EUR, currencyType.BTC };
        List<double> convFactList = new List<double>{ .7541, 86.3800, .7090, .0009 };
        int toTypeIndex;
        int fromTypeIndex;
        
        public Money()
        {
        }

        
        public Money(double _valueToConvert,  currencyType _convertFromType, currencyType _convertToType)
        {
            valueToConvert = _valueToConvert;
            convertFromType = _convertFromType;
            convertToType = _convertToType;

            toTypeIndex = typeList.IndexOf(convertToType);
            fromTypeIndex = typeList.IndexOf(convertFromType);

            convertToFact = convFactList[toTypeIndex];
            convertFromFact = convFactList[fromTypeIndex];

            conversionFactor = convertFromFact / convertToFact;

        }

        public virtual double Calculate()
        {
            convertedValue = valueToConvert * conversionFactor;
            return convertedValue;
        }

       
    }
}
