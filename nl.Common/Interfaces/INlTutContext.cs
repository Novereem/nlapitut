using System;
using Microsoft.EntityFrameworkCore;
using nl.Commen.Models;

namespace nl.Commen.Interfaces
{
    
    public interface INlTutContext : IDbContext, IDisposable
    {
        public DbSet<Question> Question { get; set; }
        
        public DbSet<Answer> Answer { get; set; }
    }
}