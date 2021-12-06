using System;

namespace nl.Commen.Models
{
    public class UserAnswer
    {
        public Guid Id { get; set; }
        public Guid AnswerId { get; set; }
        public Guid AccountId { get; set; }
    }
}