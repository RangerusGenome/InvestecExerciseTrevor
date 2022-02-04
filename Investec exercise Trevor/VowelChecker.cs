using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investec_exercise_Trevor
{
    public class VowelChecker
    {

        public string countVowels(string sentence , string typeOfCalcInd = "1"  )
        {
            //input variables//
            //sentence = The sentence to be processed
            //typeOfCalcInd = 1 (default) counts the number of vowels , 2 changes the calculation type to check if there are more vowels or non vowels
            //This class does both types of calculations , because they are very simillair

            //declare char array with all the known vowels 
            string vowels = "aeiou";

            char[] charArr = vowels.ToCharArray();

            StringBuilder sb = new StringBuilder();

            //loop through the sentence fetch the vowels and add them to a string builder , we will later dedup this list to get unique vowel count
            foreach (char s in vowels)

            {

               foreach (char chr in sentence.ToLower())
                {
                    if (chr == s)
                    {
                        sb.Append(s);
                    }

                }
           }
            //count the total unique letters in the sentence
            var totalcountOfLetters = sentence.ToString().Distinct().Count();

            //count the unique vowels in sentence
            var countOfVowels = sb.ToString().Distinct().Count();

            //calculate the non vowels in the sentence 
            var totalCountNonVowels = totalcountOfLetters - countOfVowels;

            if (typeOfCalcInd == "1")

            {

                if (countOfVowels > 0)

                {
                    return "The number of vowels is " + countOfVowels;

                }

                else
                {

                    return "no vowels found";

                }
            }

            else if (typeOfCalcInd == "2")

            {


                if (totalCountNonVowels == countOfVowels)

                { return "The text has an equal amount of vowels and non vowels"; }

                else if (totalCountNonVowels > countOfVowels)

                { return "The text has more non vowels than vowels"; }

                else if (totalCountNonVowels < countOfVowels)

                { return "The text has more vowels than non vowels"; }


            }

            return "";


        }

        
    }
}
