using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city = 'Ankara';
            foreach (var item in city)
            {
                Console.WriteLine(item);    
            }
            Console.ReadLine();
        }
    }
}
