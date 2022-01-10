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
        public string Usage { get; set; }

        public Laptop(string price, string usage)
        {
            Id = Guid.NewGuid();
            Price = price;
            Usage = usage;
        }
    }
}