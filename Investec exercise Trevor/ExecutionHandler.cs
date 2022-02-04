using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investec_exercise_Trevor
{
    public class ExecutionHandler
    {

        public string Options(string options , string sentnce)

        {

            ///Aptly named execution handler , This class manages the execution of the two classes Duplicate counter and vowel checker, it passes the results to the 
            ///main program 


            DuplicateCounter dc = new DuplicateCounter();

            VowelChecker vc = new VowelChecker();


            var duplicates = "";
            var vowelcounter = "";
            var vowelcounter2 = "";


            if (options.Contains("1") == true)

            {
                duplicates = dc.CheckForDuplicates(sentnce);
               
            }

            

            if (options.Contains("2") == true)

            {
                vowelcounter = vc.countVowels(sentnce);
                
            }


         

            if (options.Contains("3") == true)

            {
                vowelcounter2 = vc.countVowels(sentnce,"2");
                
            }


            return duplicates + "," + vowelcounter + "," + vowelcounter2;


        }


    }
}
