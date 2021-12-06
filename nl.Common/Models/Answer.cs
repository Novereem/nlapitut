using System;
using System.ComponentModel.DataAnnotations;

namespace nl.Commen.Models
{
    public class Answer
    {
        [Key]
        public Guid Id { get; set; }
        public int QuestionId { get; set; }
        public int NextQuestionId { get; set; }
        public string Text { get; set; }
        
        public Answer()
        {
            
        }
        public Answer(int questionId, int nextQuestionId, string text)
        {
            Id = Guid.NewGuid();
            QuestionId = questionId;
            NextQuestionId = nextQuestionId;
            Text = text;
        }
    }
}