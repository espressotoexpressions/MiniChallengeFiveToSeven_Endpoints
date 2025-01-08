using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniChallengeFiveToSeven_Endpoints.Services
{
    public class MadlibServices
    {
        //enter logic here

        public string GenerateStory(string noun1, string adjective2, string number3, string noun4, string noun5, string adjective6, string noun7,string number8,string number9,string adjective10, string adverb11, string noun12)
        {

            string storyStr = $"Dear {noun1}, I cannot come to school today because I feel so { adjective2}. Last night I ate{number3} {noun4} and drank a litre of {noun5}. Today I woke up feeling absolutely {adjective6} and looking like a {noun7}. Anyway, please give me {number8} pieces of homework as I don’t think I will be back at school for at least {number9} years.See you when I am old and{adjective10}. Yours {adverb11}, {noun12}.";

            return storyStr;
        }

    }
}