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
        public int OrderId { get; set; }
        public string Text { get; set; }
        
        public Answer()
        {
            
        }
        public Answer(int nextQuestionId, int orderId, string text, int questionId)
        {
            Id = Guid.NewGuid();
            QuestionId = questionId;
            NextQuestionId = nextQuestionId;
            OrderId = orderId;
            Text = text;
        }
    }
}