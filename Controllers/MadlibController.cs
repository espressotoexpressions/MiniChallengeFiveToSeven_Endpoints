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
    public class MadlibController : ControllerBase
    {
        private readonly MadlibServices _madlibServices;

        public MadlibController(MadlibServices madlibServices)
        {
            _madlibServices = madlibServices;
        }

        [HttpGet]
        [Route("Madlib/{noun1},{adjective2},{number3}, {noun4},{noun5},{adjective6},{noun7},{number8},{number9},{adjective10},{adverb11},{noun12}")]

        public string GenerateStory(string noun1, string adjective2, string number3, string noun4, string noun5, string adjective6, string noun7, string number8, string number9, string adjective10, string adverb11, string noun12)
        {
            return _madlibServices.GenerateStory(noun1, adjective2, number3, noun4, noun5, adjective6, noun7, number8, number9, adjective10, adverb11, noun12);
        }
    }
}