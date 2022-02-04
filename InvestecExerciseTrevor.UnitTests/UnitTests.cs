using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Investec_exercise_Trevor;

namespace InvestecExerciseTrevor.UnitTests
{
    [TestClass]
    public class InvestecExerciseUnitTests
    {
        [TestMethod]
        public void CheckForDuplicates_where_DuplicatesPresent_()
        {


            //arrange 
            var dupCounter = new DuplicateCounter();


            //act 

           var result =  dupCounter.CheckForDuplicates("i like apples");



            //asert 

            Assert.AreEqual( "Found the follwoing Duplicates : ilep" , result);


            
        }

        [TestMethod]
        public void CheckForDuplicates_Where_NoDuplicatesPresent_()

        {


            //arrange 

            var dupCounter = new DuplicateCounter();

            //act 

            var result = dupCounter.CheckForDuplicates("abcd");

            //assert

            Assert.AreEqual( "No duplicate values were found" , result);






        }


        [TestMethod]
        public void CountVowels_where_5vowels_present_()

        {

            //arrange 

            VowelChecker vchecker = new VowelChecker();

            //act

            var result = vchecker.countVowels("aeiou");


            //assert 

            Assert.AreEqual(result, "The number of vowels is 5");
        
        
        }


        [TestMethod]

        public void CountVowels_where_no_vowels_present_()

        {

            //arrange 

            VowelChecker vchecker = new VowelChecker();

            //act

            var result = vchecker.countVowels("N52B25");


            //assert 

            Assert.AreEqual(result, "no vowels found");


        }

        [TestMethod]
        public void CountVowels_where_equal_amount_of_vowels_present_()

        {




            //arrange 

            VowelChecker vchecker = new VowelChecker();

            //act

            var result = vchecker.countVowels("EZ" ,"2");


            //assert 

            Assert.AreEqual(result, "The text has an equal amount of vowels and non vowels");
        }

        [TestMethod]
        public void CountVowels_where_more_non_vowels_that_vowels_()

        {

            //arrange 

            VowelChecker vchecker = new VowelChecker();

            //act

            var result = vchecker.countVowels("zzBa", "2");


            //assert 

            Assert.AreEqual(result, "The text has more non vowels than vowels");


        }

        [TestMethod]

        public void CountVowels_where_more_vowels_that_non_vowels_()

        {

            //arrange 

            VowelChecker vchecker = new VowelChecker();

            //act

            var result = vchecker.countVowels("aeizzzzz", "2");


            //assert 

            Assert.AreEqual(result, "The text has more vowels than non vowels");


        }



    }
}
