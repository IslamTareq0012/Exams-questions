using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    abstract class ExamParent
    {
        public int examMinutes { get; set; }
        public int numberOfQuestions { get; set; }
        public Dictionary<Question,AnswerList> questionAnswerDictionary { get; set; }
        public int totalMarks { get; set; }
        public abstract void show();
    }
}
