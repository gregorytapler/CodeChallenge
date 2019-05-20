using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CodeChallenge.Pages
{
    public class AboutModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "As a code challenge, convert the string: (id,created,employee(id,firstname,employeeType(id), lastname),location)" +
                " from a single-line nested parenthesis string to indented format.";
        }
    }
}
