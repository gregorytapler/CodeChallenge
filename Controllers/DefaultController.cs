using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeChallenge.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodeChallenge.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            ConversionStringModel conversionStringModel = new ConversionStringModel();
            return conversionStringModel.StringToConvert;
        }

        [HttpPost]
        public void Post([FromBody] string value)
        {
            ConversionStringModel conversionStringModel = new ConversionStringModel(value);
            //do something with the new conversionStringModel like store information into a database or redirect to another api
        }
    }
}
