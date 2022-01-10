using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace nl.Commen.Models
{
    public class UserAnswer
    {
        [Key]
        public Guid Id { get; set; }
        public List<SingleAnswer> Answers { get; set; }
        public string Token { get; set; }

        public UserAnswer()
        {

        }
        public UserAnswer(string token, List<SingleAnswer> allAnswers)
        {
            Id = Guid.NewGuid();
            Answers = allAnswers;
            Token = token;
        }
    }
}