using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeChallenge.Models
{
    public class ConversionStringModel
    {
        private string _defaultConversionString = @"(id, created, employee(id, firstname, employeeType(id), lastname),location)";

        public ConversionStringModel() {
            StringToConvert = _defaultConversionString;
        }

        public ConversionStringModel(string conversionString)
        {
            StringToConvert = conversionString;
        }

        public string StringToConvert { get; }
    }
}
