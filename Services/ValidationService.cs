using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeChallenge.Services
{
    internal class ValidationService
    {
        internal void Validate(string stringToConvert)
        {
            if (String.IsNullOrWhiteSpace(stringToConvert))
                throw new Exception("Invalid String");
        }
    }
}
