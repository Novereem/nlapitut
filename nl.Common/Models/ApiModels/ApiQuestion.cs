using System.Collections.Generic;

namespace nl.Commen.Models.ApiModels
{
    public class ApiQuestion
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public List<Answer> Answers {get; set; }

        public ApiQuestion()
        {
            
        }
        
        public ApiQuestion(int id, string text, List<Answer> answers)
        {
            Id = id;
            Text = text;
            Answers = answers;
        }

    }
}