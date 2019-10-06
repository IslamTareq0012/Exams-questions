using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class AnswerList : List<Answer>, ICorrector
    {
        public void Add(Answer ans)
        {
            base.Add(ans);
        }

        public static Answer pickAnswer(char questionNumber, AnswerList availableAnswers)
        {
            for (int i = 0; i < availableAnswers.Count; i++)
            {
                if (availableAnswers[i].questionNumber == questionNumber)
                {
                    return availableAnswers[i];
                }
            }
            return null;
        }

        public static AnswerList pickAnswers(string answersNumbers, AnswerList availableAnswers)
        {
            char tempChar;
            char[] spearator = { ' ' };
            string[] result = answersNumbers.Split(spearator);
            AnswerList chosenAnswers = new AnswerList();
            if (result.Length != 0)
            {
                foreach (var item in result)
                {
                    if (item != "" && char.TryParse(item, out tempChar)) {
                        for (int i = 0; i < availableAnswers.Count(); i++)
                        {
                            if (tempChar == availableAnswers[i].questionNumber)
                            {
                                chosenAnswers.Add(availableAnswers[i]);
                            }
                        }
                    }
                }
            }
            if (chosenAnswers.Count() != 0)
            {
                return chosenAnswers;
            }
            return null;
        }

        public bool correct(object object1)
        {
            AnswerList ans = object1 as AnswerList;
            int numberOfAnswers = 0;
            if (ans != null)
            {
                if (ans.Count() != this.Count())
                {
                    return false;
                }
                else if (ans.Count() == this.Count())
                {
                    for (int i = 0; i < ans.Count(); i++)
                    {
                        for (int j = 0; j < this.Count(); j++)
                        {
                            if (ans[i].questionNumber == this[j].questionNumber)
                            {
                                numberOfAnswers++;
                            }
                        }
                    }
                    if (numberOfAnswers == this.Count())
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return false;
        }
    }
}
