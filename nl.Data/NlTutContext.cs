using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using nl.Commen.Interfaces;
using nl.Commen.Models;

namespace nl.Data
{
    public class NlTutContext : DbContext, INlTutContext
    {
        public DbSet<Answer> Answer { get; set; }
        public DbSet<Question> Question { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Question>().HasData(
                new Question(1, "Hoeveel geld wilt u besteden?"),
                new Question(2, "Waar ga je je laptop voor gebruiken")
            );

            modelBuilder.Entity<Answer>().HasData(
                new(1, 2, "300-500"), 
                new(1, 2, "500-800"),
                new(1,2,"800-1200"),
                new(1,2,"1200+"),
                new(2, 1, "Mail / Netflix & YouTube"), 
                new(2, 1, "Documenten bewerken"),
                new(2,1,"Foto's/videdo's bewerken"),
                new(2,1,"Gamen")
                );
        }

        public NlTutContext(DbContextOptions<NlTutContext> options)
            : base(options)
        {
            
        }
    }
}