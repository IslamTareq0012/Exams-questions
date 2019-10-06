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
            //char[] spearator = {' '};
            //string str = "a b c d";
            //string[] result = str.Split(spearator);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(char.Parse(item));
            //}
            

            AnswerList lst = new AnswerList() { new Answer('c' , "True") , new Answer('b', "false") , new Answer('a', "maybe") };
            AnswerList lst2 = new AnswerList() { new Answer('c', "True"), new Answer('b', "false") };
            Answer ans = new Answer('a' , "YES");
            //foreach (var item in AnswerList.pickAnswers("a b" , lst))
            //{
                Console.WriteLine(/*lst2.correct(AnswerList.pickAnswers("c b", lst))*/ ans.correct(new Answer('a',"YESsss")));
            //}
            Console.ReadKey();
        }
    }
}
