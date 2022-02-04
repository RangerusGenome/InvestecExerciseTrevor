using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investec_exercise_Trevor
{
    public class Program
    {
        static void Main(string[] args)

           
        {
            //
            ExecutionHandler exechndl = new ExecutionHandler();


            Console.WriteLine("Enter text to be analysed");

            var sentence = Console.ReadLine();

            Console.Beep();

            Console.WriteLine("Enter which operations to do on the supplied text, ‘1’ for a duplicate character check, ‘2’ to count the number of vowels, ‘3’ to check if there are more vowels or non vowels, or any combination of ‘1’, ‘2’ and ‘3’ to perform multiple checks.");

            var opt = Console.ReadLine();

            var output = exechndl.Options(opt, sentence);

            Console.WriteLine(output.Replace(',', '\n'));

            Console.Read();


        }
    }
}
