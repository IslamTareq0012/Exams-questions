using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public class Question
    {
        public int mark { get; set; }
        public string head { get; set; }
        public string body { get; set; }
        public ICorrector correctAnswer;
    }
}
