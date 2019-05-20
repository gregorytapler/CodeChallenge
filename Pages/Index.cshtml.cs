using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CodeChallenge.Pages
{
    public class IndexModel : PageModel
    {
        public Dictionary<int, string> StringsToConvert => new Dictionary<int, string>
        {
            {1, @"(id,created,employee(id,firstname,employeeType(id), lastname),location)" },
            {2, @"(id,created,candidate(id,firstname,candidateType(id), lastname),location)" }
        };

        public string ConvertedString { get; set; }

        public void OnPostConvertAsync(int id)
        {
            Services.ConversionService conversionService = new Services.ConversionService(new Services.ValidationService());
            ConvertedString = conversionService.ConvertString(StringsToConvert.Single(x => x.Key == id).Value);
        }

        public void OnPostConvertSortedAsync(int id)
        {
            Services.ConversionService conversionService = new Services.ConversionService(new Services.ValidationService());
            ConvertedString = conversionService.ConvertStringSorted(StringsToConvert.Single(x => x.Key == id).Value);
        }
    }
}
