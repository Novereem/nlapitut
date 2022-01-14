using System;

namespace nl.Commen.Models
{
    public class Component
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Score { get; set; }

        public Component()
        {
            
        }
        
        public Component(string name, string type, int score)
        {
            Id = Guid.NewGuid();
            Name = name;
            Type = type;
            Score = score;
        }
    }
}