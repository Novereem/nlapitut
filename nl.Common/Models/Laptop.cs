using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace nl.Commen.Models
{
    public class Laptop
    {
        [Key]
        public Guid Id { get; set; }
        public string Price { get; set; }
        public string Processor { get; set; }
        public string Storage { get; set; }
        public string Ram { get; set; }
        public string GraphicsCard { get; set; }
        public string ScreenSize { get; set; }

        public Laptop()
        {
            
        }
        public Laptop(string price, string usage)
        {
            Id = Guid.NewGuid();
            Price = price;
        }
    }
}