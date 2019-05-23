using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeChallenge.Repository
{
    public class StringRepository
    {
        public StringRepository() { }

        private string _defaultConversionString = @"(id, created, employee(id, firstname, employeeType(id), lastname),location)";

        public string GetStringToConvert()
        {
            return _defaultConversionString;
        }

        public string GetConvertedString(string stringToConvert)
        {
            Services.ConversionService conversionService = new Services.ConversionService(new Services.ValidationService());
            return conversionService.ConvertString(stringToConvert);
        }

        public void UpdateString(string valueString)
        {
            //do something with valueString
        }
    }
}
