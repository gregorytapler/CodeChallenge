using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge.Services
{
    internal class ConversionService
    {
        ValidationService _validationService;
        internal StringBuilder ConvertedString;

        internal ConversionService(ValidationService validationService)
        {
            _validationService = validationService;
        }

        internal string ConvertString(string stringToConvert)
        {
            try
            {
                _validationService.Validate(stringToConvert);
                return ConvertStringInternal(stringToConvert);
            }
            catch(Exception ex)
            {
                return $@"Invalid string {stringToConvert}";
            }
        }

        internal string ConvertStringSorted(string stringToConvert)
        {
            try
            {
                _validationService.Validate(stringToConvert);
                return ConvertStringInternal(stringToConvert, true);
            }
            catch (Exception ex)
            {
                return $@"Invalid string {stringToConvert}";
            }
        }

        private string ConvertStringInternal(string stringToConvert, bool sortConvertedString = false)
        {
            TreeService treeService = new TreeService(stringToConvert);

            TreePrintingService treePrintingService = new TreePrintingService();
            treePrintingService.PrintTree(treeService.GetTree(), string.Empty, sortConvertedString);
            return treePrintingService.PrintedTree.ToString();
        }
    }
}
