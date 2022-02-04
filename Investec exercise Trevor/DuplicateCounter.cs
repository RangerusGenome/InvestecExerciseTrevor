using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investec_exercise_Trevor
{
    public class DuplicateCounter
    {
        public string CheckForDuplicates(string sentence)

        {

            //check for duplicates using linq simpler
            var result = sentence.ToLower().Replace(" ", "")
                 .GroupBy(_ => _)
                 .Where(x => x.Count() > 1)
                 .Select(x => x.Key);


            //count the duplicates if none, return appropriate response ,if present same 
            if (result.Count() == 0)

            {
                return "No duplicate values were found";
            }

            else

            {
                return "Found the follwoing Duplicates : " + string.Join("", result);


            }





        }
    }
}

