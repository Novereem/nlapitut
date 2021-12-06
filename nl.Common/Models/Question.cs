using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace nl.Commen.Models
{
    public class Question
    {
        [Key]
        public int Id { get; set; }
        public string Text { get; set; }

        public Question()
        {
            
        }
        
        public Question(int id, string text)
        {
            Id = id;
            Text = text;
        }
    }
}