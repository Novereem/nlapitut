using System.Collections.Generic;
using nl.Commen.Interfaces;
using nl.Commen.Models;

namespace nl.Tests.FakeData
{
    public class FakeQuestionData : IQuestionData
    {
        public Question GetQuestion(int id)
        {
            if (id == 1)
            {
                return new Question(1, "First Question");
            }
            
            if (id == 2)
            {
                return new Question(2, "Second Question");
            }

            return null;
        }
        public List<Answer> GetAnswers(int id)
        {
            if (id == 1)
            {
                List<Answer> answers = new List<Answer>()
                {
                    new Answer(1, 2, "First Option", 1),
                    new Answer(1, 2, "Second Option", 2),
                    new Answer(1, 2, "Third Option", 3),
                    new Answer(1, 2, "Fourth Option", 4)
                };
                return answers;
            }
            
            if (id == 2)
            {
                List<Answer> answers = new List<Answer>()
                {
                    new Answer(2, 3, "First Option", 1),
                    new Answer(2, 3, "Second Option", 2),
                    new Answer(2, 3, "Third Option", 3),
                    new Answer(2, 3, "Fourth Option", 4)
                };
                return answers;
            }

            return null;
        }
        public Answer GetAnswer(string id)
        {
            if (id == "First Option")
            {
                return new Answer(1, 2, "First Option", 1);
            }

            return null;
        }

        public void SaveUserAnswers(UserAnswer userAnswer)
        {
            throw new System.NotImplementedException();
        }

        public void SaveSingleAnswer(string token, string answerId)
        {
            if (answerId != "First Option")
            {
                throw new System.NotImplementedException();
            }
        }

        

        public void RemovePreExistingUserAnswers(string token)
        {
            throw new System.NotImplementedException();
        }

        public List<SingleAnswerTemp> GetUserAnswersTemps(string token)
        {
            throw new System.NotImplementedException();
        }
    }
}