using System.Collections.Generic;
using System.Linq;
using nl.Commen.Interfaces;
using nl.Commen.Models;

namespace nl.Data
{
    public class AnswerData
    {
        private readonly INlTutContext _context;

        public AnswerData(INlTutContext context)
        {
            _context = context;
        }
        
        public List<Laptop> GetLaptopByPrice(string price)
        {
            return _context.Laptops.Where(x => x.Price.Contains(price)).ToList();
        }
        
        public List<Laptop> GetLaptopByUsage(string usage)
        {
            return _context.Laptops.Where(x => x.Usage.Contains(usage)).ToList();
        }
    }
}