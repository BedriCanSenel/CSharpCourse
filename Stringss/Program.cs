using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Intro();
            string sentence = "my name is Engin Demirog";
            var result = sentence.Length;
            var result2 = sentence.Clone();
            sentence = "My name is Derin Demirog";

            bool result3=sentence.EndsWith("ğ");
            bool result4 = sentence.StartsWith("My name");

            var result5 = sentence.IndexOf("namee");
            var result6 = sentence.IndexOf(" ");
            var result7 = sentence.LastIndexOf(" ");
            var result8 = sentence.Substring(3,4);
            var result9 = sentence.ToLower();
            var result10 = sentence.ToUpper();
            var result11 = sentence.Replace(" ", "-");
            var result12 = sentence.Remove(2);
            var result13 = sentence.Remove(2,5);





            Console.WriteLine(result13);
            Console.ReadLine();
        }

        private static void Intro()
        {
            string city = "Ankara";

            foreach (var item in city)
            {
                Console.WriteLine(item);
            }
            string city2 = "İstanbul";
            Console.WriteLine(String.Format("{0} {1}", city, city2));
        }
    }
}
