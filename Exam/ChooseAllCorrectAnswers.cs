using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class ChooseAllCorrectAnswers : Question
    {

        public ChooseAllCorrectAnswers(string head, string body, int mark, ICorrector correctAnswer)
        {
            base.head = head;
            base.body = body;
            base.correctAnswer = correctAnswer;
            base.mark = mark;

        }
        public override string ToString()
        {
            return $"Choose all correct answers : {base.body}";
        }
    }
}
