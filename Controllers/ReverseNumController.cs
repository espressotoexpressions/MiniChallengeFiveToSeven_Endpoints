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
    public class ReverseNumController : ControllerBase
    {
        private readonly ReverseNumServices _reverseNumServices;

        public ReverseNumController(ReverseNumServices reverseNumServices)
        {
            _reverseNumServices = reverseNumServices;
        }

        [HttpGet]
        [Route("ReverseNum/{num}")]

        public string GetReverseNum(string num)
        {
            return _reverseNumServices.GetReverseNum(num);
        }

    }
}