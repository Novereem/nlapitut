using System;
using System.ComponentModel.DataAnnotations;

namespace nl.Commen.Models
{
    public class SingleAnswer
    {
        [Key]
        public Guid Id { get; set; }
        public string AnswerId { get; set; }
        public string Token { get; set; }
        
        public SingleAnswer()
        {
            
        }
        public SingleAnswer(string answerId, string token)
        {
            Id = Guid.NewGuid();
            AnswerId = answerId;
            Token = token;
        }
    }
}