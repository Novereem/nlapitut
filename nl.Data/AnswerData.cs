using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using nl.Commen.Interfaces;
using nl.Commen.Models;

namespace nl.Data
{
    public class AnswerData : IAnswerData
    {
        private readonly INlTutContext _context;

        public AnswerData(INlTutContext context)
        {
            _context = context;
        }

        public UserAnswer GetUserAnswersByToken(string token)
        {
            /*UserAnswer userAnswer = _context.UserAnswers.FirstOrDefault(x => x.Token == token);
            return userAnswer;*/
            UserAnswer userAnswer = (from u in _context.UserAnswers.Include(x => x.Answers) where u.Token == token select u).FirstOrDefault();
            return userAnswer;
        }

        public List<Answer> GetAllAnswers()
        {
            return _context.Answer.Where(x => x.Id != null).ToList();
        }

        public List<Component> GetAllComponents()
        {
            return _context.Components.Where(x => x.Id != null).ToList();
        }
    }
}