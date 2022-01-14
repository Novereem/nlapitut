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
        public DbSet<Component> Components { get; set; }
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
                new Answer(2, 1, "300-500", 1), 
                new Answer(2, 2,"500-800", 1),
                new Answer(2,3,"800-1200", 1),
                new Answer(2,4,"1200+", 1),
                
                //2
                new Answer(7, 1,"Mail / Netflix & YouTube", 2), 
                new Answer(7, 2,"Documenten bewerken", 2),
                new Answer(3,3,"Foto's/video's bewerken", 2),
                new Answer(4,4,"Gamen", 2),
                
                //3
                new Answer(6, 1,"Foto's", 3),
                new Answer(6, 2,"Video's", 3),
                
                //4
                new Answer(5,1,"Shooters", 4),
                new Answer(5,2,"Moba", 4),
                new Answer(5,3,"Action-adventure", 4),
                new Answer(5,4,"Esports", 4),
                new Answer(5,5,"Real-time strategy", 4),
                
                //5
                new Answer(8,1,"Counter-Strike: Global Offensive", 5),
                new Answer(8,2,"New World", 5),
                new Answer(8,3,"Dota 2", 5),
                new Answer(8,4,"Battlefield 2042", 5),
                new Answer(8,5,"Rocket League", 5),
                new Answer(8,6,"Apex Legends", 5),
                new Answer(8,7,"Phasmophobia", 5),
                new Answer(8,8,"Dead by Daylight", 5),
                new Answer(8,9,"Tom Clancy's Rainbow Six: Siege", 5),
                new Answer(8,10,"Team Fortress 2", 5),
                new Answer(8,11,"Rust", 5),
                new Answer(8,12,"Destiny 2", 5),
                new Answer(8,13,"PLAYERUNKNOWN'S BATTLEGROUNDS", 5),
                new Answer(8,14,"Garry's Mod", 5),
                new Answer(8,15,"Left 4 Dead 2", 5),
                new Answer(8,16,"Bloons TD 6", 5),
                new Answer(8,17,"Brawlhalla", 5),
                new Answer(8,18,"Euro Truck Simulator 2", 5),
                new Answer(8,19,"Among Us", 5),
                new Answer(8,20,"Grand Theft Auto 5", 5),
                
                //6
                new Answer(7,1,"Ja", 6),
                new Answer(7,2,"Nee", 6),
                
                //7
                new Answer(9,1,"Ja", 7),
                new Answer(9,2,"Nee", 7),
                
                //8
                new Answer(9,1,"FPS", 8),
                new Answer(9,2,"Graphics", 8),
                
                //9
                new Answer(1, 1,"13'", 9),
                new Answer(1, 2,"14'", 9),
                new Answer(1, 3,"15'6", 9),
                new Answer(1, 4,"17'", 9)
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

            modelBuilder.Entity<Component>().HasData(
                //Processor
                new Component("3", ComponentTypes.Processor.ToString(), 3),
                new Component("5", ComponentTypes.Processor.ToString(), 6),
                new Component("7", ComponentTypes.Processor.ToString(), 9),
                
                //Storage
                new Component("256gb", ComponentTypes.Storage.ToString(), 3),
                new Component("512gb", ComponentTypes.Storage.ToString(), 6),
                new Component("1tb", ComponentTypes.Storage.ToString(), 9),
                
                //Ram
                new Component("8gb", ComponentTypes.Ram.ToString(), 3),
                new Component("16gb", ComponentTypes.Ram.ToString(), 6),
                new Component("32gb", ComponentTypes.Ram.ToString(), 9),
                
                //GraphicsCard
                new Component("geen", ComponentTypes.GraphicsCard.ToString(), 1),
                new Component("1650-1660", ComponentTypes.GraphicsCard.ToString(), 3),
                new Component("2060/3050-2070/3060", ComponentTypes.GraphicsCard.ToString(), 5),
                new Component("2070/3070-2080ti/3090", ComponentTypes.GraphicsCard.ToString(), 8),
                
                //Screensize
                new Component("13'", ComponentTypes.ScreenSize.ToString(), 1),
                new Component("14'", ComponentTypes.ScreenSize.ToString(), 2),
                new Component("15'6", ComponentTypes.ScreenSize.ToString(), 3),
                new Component("17'", ComponentTypes.ScreenSize.ToString(), 4)
            );
        }
        
        

        public NlTutContext(DbContextOptions<NlTutContext> options)
            : base(options)
        {
            
        }
    }
}