using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge.Services
{
    /// <summary>
    /// String conversion service
    /// </summary>
    internal class ConversionService
    {
        ValidationService _validationService;
        internal StringBuilder ConvertedString;

        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <param name="validationService"></param>
        internal ConversionService(ValidationService validationService)
        {
            _validationService = validationService;
        }

        /// <summary>
        /// Convert the given string to a nested list
        /// </summary>
        /// <param name="stringToConvert">Parameterized string to convert</param>
        /// <returns></returns>
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

        /// <summary>
        /// Convert the givent string to a nested list and sort
        /// </summary>
        /// <param name="stringToConvert">Parameterized string to convert</param>
        /// <returns></returns>
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

        /// <summary>
        /// Convert the incoming string and set sort based on incoming sort parameter
        /// </summary>
        /// <param name="stringToConvert">String value to convert</param>
        /// <param name="sortConvertedString">Are we sorting the output</param>
        /// <returns></returns>
        private string ConvertStringInternal(string stringToConvert, bool sortConvertedString = false)
        {
            //initialize the TreeService with the incoming string
            TreeService treeService = new TreeService(stringToConvert);

            TreePrintingService treePrintingService = new TreePrintingService();

            //Using the TreePrintingService print the tree and return
            treePrintingService.PrintTree(treeService.GetTree(), string.Empty, sortConvertedString);
            return treePrintingService.PrintedTree.ToString();
        }
    }
}
