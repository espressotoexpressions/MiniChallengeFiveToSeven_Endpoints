using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MiniChallengeFiveToSeven_Endpoints.Services;

namespace MiniChallengeFiveToSeven_Endpoints.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddOrEvenController : ControllerBase
    {
        private readonly AddOrEvenServices _addOrEvenServices;

        public AddOrEvenController( AddOrEvenServices addOrEvenServices){
            _addOrEvenServices = addOrEvenServices;
        }

        [HttpGet]
        [Route("OddOrEven/{num}")]
        public  string IsItOddOrEven(string num)
        {
            return _addOrEvenServices.IsItOddOrEven(num);
        }


    }
}