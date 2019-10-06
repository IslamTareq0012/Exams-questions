using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Answer : ICorrector
    {
        public char questionNumber { get; set; }
        public string answerBody { get; set; }
        public Answer(char number , string body) {
            questionNumber = number;
            answerBody = body;
        }

        public bool correct(object object1)
        {
            Answer ans = object1 as Answer;
            if ( ans != null) {

                if (this.answerBody == ans.answerBody)
                {
                    return true;
                }
                else {
                    return false;
                }
            }
            return false;
        }
    }
}
