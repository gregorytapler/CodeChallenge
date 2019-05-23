using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeChallenge.Models;
using CodeChallenge.Repository;
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
            StringRepository stringRepository = new StringRepository();
            return stringRepository.GetConvertedString(stringRepository.GetStringToConvert());
        }

        [HttpPost]
        public void Post([FromBody] string value)
        {
            //do something with the new conversionStringModel like store information into a database or redirect to another api
            StringRepository stringRepository = new StringRepository();
            stringRepository.UpdateString(value);
        }
    }
}
