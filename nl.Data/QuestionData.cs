using System.Collections.Generic;
using System.Linq;
using nl.Commen.Interfaces;
using nl.Commen.Models;

namespace nl.Data
{
    public class QuestionData : IQuestionData
    {
        private readonly INlTutContext _context;

        public QuestionData(INlTutContext context)
        {
            _context = context;
        }

        public List<Answer> GetAnswers(int id)
        {
            return _context.Answer.Where(x => x.QuestionId == id).ToList();

        }
        public Answer GetAnswer(string id)
        {
            return _context.Answer.FirstOrDefault(x => x.Id.ToString() == id);
        }

        public Question GetQuestion(int id)
        {
            return _context.Question.FirstOrDefault(x => x.Id == id);
        }
    }
}