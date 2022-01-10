using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nl.Commen.Models
{
    public class SingleAnswerTemp
    {
        [Key]
        public Guid Id { get; set; }
        public string AnswerId { get; set; }
        public string Token { get; set; }

        public SingleAnswerTemp()
        {

        }
        public SingleAnswerTemp(string answerId, string token)
        {
            Id = Guid.NewGuid();
            AnswerId = answerId;
            Token = token;
        }
    }
}
