using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class TrueOrFalse : Question
    {
        public TrueOrFalse(string  head, string body , int mark , ICorrector correctAnswer) {
            base.head = head;
            base.body = body;
            base.correctAnswer = correctAnswer;
            base.mark = mark;
        }
        public override string ToString()
        {
            return $"Choose only true or false : {base.body}";
        }
    }
}
