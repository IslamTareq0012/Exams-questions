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


            AnswerList lst = new AnswerList() { new Answer('a' , "True") , new Answer('b', "false") , new Answer('c', "maybe") };
            //AnswerList lst2 = new AnswerList() { new Answer('c', "True"), new Answer('b', "false") };
            //Answer ans = new Answer('a' , "YES");
            //foreach (var item in AnswerList.pickAnswers("a b" , lst))
            //{
            //Console.WriteLine(/*lst2.correct(AnswerList.pickAnswers("c b", lst))*/ ans.correct(new Answer('a',"YESsss")));
            //}
            ExamParent exam = new PracticeExam();
            exam.questionAnswerDictionary = new Dictionary<Question, AnswerList>();
            exam.questionAnswerDictionary.Add(new TrueOrFalse("True or false" , "Is the sky blue?",2, new Answer('a', "True")),lst);
            foreach (var item in exam.questionAnswerDictionary)
            {
                Console.WriteLine($"{item.Key.head}");
                Console.WriteLine($"{item.Key.body}");
                Console.WriteLine($"marks : {item.Key.mark}");
                foreach (var item2 in item.Value)
                {
                    Console.WriteLine(item2.questionNumber + ")" + item2.answerBody);
                }
                if (item.Key.correctAnswer.correct(AnswerList.pickAnswer(Console.ReadKey().KeyChar, item.Value)))
                {
                    exam.totalMarks = exam.totalMarks + item.Key.mark;
                }
            }
            Console.WriteLine("\n"+"total user marks " + exam.totalMarks);
            Console.ReadKey();
        }
    }
}
