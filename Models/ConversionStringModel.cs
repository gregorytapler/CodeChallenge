using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodeChallenge.Models
{
    public class ConversionStringModel
    {
        public ConversionStringModel() { }

        public ConversionStringModel(string conversionString)
        {
            StringToConvert = conversionString;
        }

        [Required]
        public string StringToConvert { get; set; }
    }
}
