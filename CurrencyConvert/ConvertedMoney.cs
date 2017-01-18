using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConvert
{
    public class ConvertedMoney : Money
    {

        
        public ConvertedMoney(double _valueToConvert, currencyType _convertFromType, currencyType _convertToType) : base(_valueToConvert,_convertFromType, _convertToType)
        {


        }

        public override double Calculate()
        {
            return convertedValue;
        }
    }
}
