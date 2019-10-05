using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] spearator = {' '};
            string str = "a b c d";
            string[] result = str.Split(spearator);
            foreach (var item in result)
            {
                Console.WriteLine(char.Parse(item));
            }
            Console.ReadKey();
        }
    }
}
