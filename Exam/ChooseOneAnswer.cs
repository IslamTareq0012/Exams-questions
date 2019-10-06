using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class ChooseOneAnswer :Question
    {
        public ChooseOneAnswer(string head, string body, int mark, ICorrector correctAnswer)
        {
            base.head = head;
            base.body = body;
            base.correctAnswer = correctAnswer;
            base.mark = mark;
        }
        public override string ToString()
        {
            return $"Choose one answer : {base.body}";
        }
    }
}
