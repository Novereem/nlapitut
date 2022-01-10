using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using nl.Commen.Interfaces;
using nl.Commen.Models;

namespace nl.Data
{
    public class NlTutContext : DbContext, INlTutContext
    {
        /**Migrations
         *- dotnet ef migrations add (migration name) -p "../nl.Data"
         *- dotnet ef database update
         *- dotnet ef migrations add UserAnswerTable -p "../nl.Data"
         * visual studio
         * add-migration (naam)
         * update-database
         */
        public DbSet<Answer> Answer { get; set; }
        public DbSet<UserAnswer> UserAnswers { get; set; }
        public DbSet<SingleAnswer> SingeAnswers { get; set; }
        public DbSet<SingleAnswerTemp> SingleAnswerTemp { get; set; }
        public DbSet<Question> Question { get; set; }
        public DbSet<Laptop> Laptops { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Question>().HasData(
                new Question(1, "Hoeveel geld wilt u besteden?"),
                new Question(2, "Waar ga je je laptop voor gebruiken?"),
                new Question(3, "Is het vooral video of foto bewerking?"),
                new Question(4, "Wat voor soort games speelt u?"),
                new Question(5, "Welke van de onderstaande games heeft u gespeeld of bent u van plan te spelen?"),
                new Question(6, "Doet u het professioneel?"),
                new Question(7, "Heeft u vaak veel programma's tegelijkertijd aanstaan? (4 of meer)"),
                new Question(8, "Heeft U liever meer FPS, en/of betere graphics"),
                new Question(9, "Welk grootte scherm heeft u het liefst")
            );

            modelBuilder.Entity<Answer>().HasData(
                //1
                new Answer(1, 2, "300-500"), 
                new Answer(1, 2, "500-800"),
                new Answer(1,2,"800-1200"),
                new Answer(1,2,"1200+"),
                
                //2
                new Answer(2, 7, "Mail / Netflix & YouTube"), 
                new Answer(2, 7, "Documenten bewerken"),
                new Answer(2,3,"Foto's/video's bewerken"),
                new Answer(2,4,"Gamen"),
                
                //3
                new Answer(3, 6, "Foto's"),
                new Answer(3, 6, "Video's"),
                
                //4
                new Answer(4,5,"Shooters"),
                new Answer(4,5,"Moba"),
                new Answer(4,5,"Action-adventure"),
                new Answer(4,5,"Esports"),
                new Answer(4,5,"Real-time strategy"),
                
                //5
                new Answer(5,8,"Counter-Strike: Global Offensive"),
                new Answer(5,8,"New World"),
                new Answer(5,8,"Dota 2"),
                new Answer(5,8,"Battlefield 2042"),
                new Answer(5,8,"Rocket League"),
                new Answer(5,8,"Apex Legends"),
                new Answer(5,8,"Phasmophobia"),
                new Answer(5,8,"Dead by Daylight"),
                new Answer(5,8,"Tom Clancy's Rainbow Six: Siege"),
                new Answer(5,8,"Team Fortress 2"),
                new Answer(5,8,"Rust"),
                new Answer(5,8,"Destiny 2"),
                new Answer(5,8,"PLAYERUNKNOWN'S BATTLEGROUNDS"),
                new Answer(5,8,"Garry's Mod"),
                new Answer(5,8,"Left 4 Dead 2"),
                new Answer(5,8,"Bloons TD 6"),
                new Answer(5,8,"Brawlhalla"),
                new Answer(5,8,"Euro Truck Simulator 2"),
                new Answer(5,8,"Among Us"),
                new Answer(5,8,"Grand Theft Auto 5"),
                
                //6
                new Answer(6,7,"Ja"),
                new Answer(6,7,"Nee"),
                
                //7
                new Answer(7,8,"Ja"),
                new Answer(7,8,"Nee"),
                
                //8
                new Answer(8,9,"FPS"),
                new Answer(8,9,"Graphics"),
                
                //9
                new Answer(9, 1, "13'"),
                new Answer(9, 1, "14'"),
                new Answer(9, 1, "15'6"),
                new Answer(9, 1, "17'")
                );
            
            modelBuilder.Entity<Laptop>().HasData(
                new Laptop("300","Mail"),
                new Laptop("500","Mail"),
                new Laptop("800","Mail"),
                new Laptop("1200","Mail"),
                new Laptop("300","Documenten bewerken"),
                new Laptop("500","Documenten bewerken"),
                new Laptop("800","Documenten bewerken"),
                new Laptop("1200","Documenten bewerken"),
                new Laptop("300","Foto's/videdo's bewerken"),
                new Laptop("500","Foto's/videdo's bewerken"),
                new Laptop("800","Foto's/videdo's bewerken"),
                new Laptop("1200","Foto's/videdo's bewerken"),
                new Laptop("300","Gamen"),
                new Laptop("500","Gamen"),
                new Laptop("800","Gamen"),
                new Laptop("1200","Gamen")
            );
        }
        
        

        public NlTutContext(DbContextOptions<NlTutContext> options)
            : base(options)
        {
            
        }
    }
}