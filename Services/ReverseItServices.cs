using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniChallengeFiveToSeven_Endpoints.Services
{
    public class ReverseItServices
    {
        
        public string GetReverseString(string inputString)
        {
        
        string reversedString="";
        if (inputString != ""){

            for (int s = inputString.Length - 1; s >= 0; s--){
                reversedString += inputString[s];
            }

            return $"You entered {inputString}, reversed is {reversedString}";
        }
        else{
            return "ERROR: No string input to process...";
        }

        }
    }
}