using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniChallengeFiveToSeven_Endpoints.Services
{
    public class ReverseNumServices
    {
        public string GetReverseNum(string num)
        {   int numInput=0;
            bool   isNumValid = int.TryParse(num, out numInput);
            int numReverse=0;

                if (isNumValid) // if number is valid then proceed with reversal
                {
                 
                    while (numInput != 0)
                    {
                        numReverse = numReverse * 10;  // adds an additional 0 on the numReverse array , increases length of numReverse
                        numReverse += numInput % 10; // picks up the last digit in the numInput and adds it to the numReverse Value
                        numInput = numInput / 10;// removes the last digit of the numInput 

                    }
                return $"This is your reversed number: {numReverse}";

                }
                else // else if invalid number, display error message
                {
                    return "ERROR: Your input is not a number.";
                }
        }
    }
}