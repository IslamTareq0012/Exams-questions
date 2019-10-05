using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class AnswerList : List<Answer>
    {
        public void Add(Answer ans) {
            base.Add(ans);
        }

        public Answer pickAnswer(char questionNumber , AnswerList availableAnswers) {
            for (int i = 0; i < availableAnswers.Count; i++) {
                if (availableAnswers[i].questionNumber == questionNumber) {
                    return availableAnswers[i];
                }
            }
            return null; 
        }

        public AnswerList pickAnswers(string answersNumbers, AnswerList availableAnswers) {
            char[] spearator = { ' ' };
            string[] result = answersNumbers.Split(spearator);
            AnswerList chosenAnswers = new AnswerList();
            int numberOfChosenAnswers = result.Length;
            if (result.Length != 0) {
                for (int i = 0; i < availableAnswers.Count; i++)
                {
                    if (Char.Parse(result[i]) == availableAnswers[i].questionNumber && result.Length != 0) {
                        chosenAnswers.Add(availableAnswers[i]);
                        numberOfChosenAnswers--;
                    }
                    if (result.Length == 0) {
                        break;
                    }
                }
            }
            if (chosenAnswers.Count() !=0) {
                return chosenAnswers;
            }
            return null;
        }
    }
}
