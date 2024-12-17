using Microsoft.EntityFrameworkCore;
using project5.Models;


namespace project5.Data
{
    public class DataContext: DbContext
        {
            public DataContext(DbContextOptions<DataContext> options):base(options)       
            {
                
            }
      public DbSet <Movies> Movies =>Set<Movies>();
        public DbSet <Animes> Animes=>Set<Animes>();
        public DbSet<Series> Series=>Set<Series>();
        public DbSet<Account> Users=>Set<Account>();

       
 protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            
           
             
            modelBuilder.Entity<Animes>().HasData(
    new Animes { Id = 1, Title = "My Neighbor Totoro", Description = "My Neighbor Totoro is a heartwarming story about two young sisters who move to the countryside and discover magical creatures, including the lovable and giant Totoro. The film explores themes of childhood wonder, innocence, and the beauty of nature.", ReleaseDate = new DateTime(1988, 4, 16), Category = "Fantasy/Adventure", ImageUrl = "/images/totoro.png" },
    new Animes { Id = 2, Title = "Spirited Away", Description = "Spirited Away follows Chihiro, a young girl who, while traveling with her parents, stumbles into a mysterious world of spirits and gods. As her parents are transformed into pigs, Chihiro must work in a bathhouse to find a way to escape and return to her world.", ReleaseDate = new DateTime(2001, 7, 20), Category = "Fantasy/Adventure", ImageUrl = "/images/spiritedaway.png" },
    new Animes { Id = 3, Title = "Princess Mononoke", Description = "Princess Mononoke tells the story of Ashitaka, a young man caught in the battle between the forest gods and human industry. As he tries to find a cure for a curse, he encounters the fierce warrior Princess Mononoke, who has a deep bond with the forest spirits.", ReleaseDate = new DateTime(1997, 7, 12), Category = "Fantasy/Action", ImageUrl = "/images/mononoke.png" },
    new Animes { Id = 4, Title = "Howl's Moving Castle", Description = "Howl's Moving Castle follows Sophie, a young woman who is cursed by a witch to take the form of an old woman. She seeks refuge in the magical, moving castle of the mysterious wizard Howl, and together they embark on an adventure that blends love, war, and transformation.", ReleaseDate = new DateTime(2004, 11, 20), Category = "Fantasy/Romance", ImageUrl = "/images/howlsmovingcastle.png" },
    new Animes { Id = 5, Title = "Kiki's Delivery Service", Description = "Kiki's Delivery Service is about a young witch named Kiki who sets out to find her place in the world. She opens a flying delivery service in a coastal town, and the film explores themes of independence, self-discovery, and growing up.", ReleaseDate = new DateTime(1989, 7, 29), Category = "Fantasy/Adventure", ImageUrl = "/images/kiki.png" },
    new Animes { Id = 6, Title = "The Wind Rises", Description = "The Wind Rises is a fictionalized biography of Jiro Horikoshi, the engineer who designed the Mitsubishi A6M Zero fighter plane during World War II. The film explores Jiro's passion for aviation and his love story with Naoko, as well as the moral dilemmas posed by the destructive power of war.", ReleaseDate = new DateTime(2013, 7, 20), Category = "Historical/Drama", ImageUrl = "/images/thewindrises.png" },
    new Animes { Id = 7, Title = "Ponyo", Description = "Ponyo is a fantasy film about a young fish-girl who becomes human after befriending a boy named Sosuke. The film follows their adventure as the sea and the land merge in a magical journey of love and environmental themes.", ReleaseDate = new DateTime(2008, 7, 19), Category = "Fantasy/Adventure", ImageUrl = "/images/ponyo.png" }
);


            
            modelBuilder.Entity<Movies>().HasData(
                new Movies
                {
                    Id = 7,
                    Title = "The Shawshank Redemption",
                    Description = "The Shawshank Redemption is a powerful drama about hope and friendship, following Andy Dufresne, a banker wrongfully imprisoned for the murder of his wife. Over the decades, Andy forms a deep bond with fellow inmate Ellis 'Red' Redding while navigating the harsh realities of Shawshank prison. The film explores themes of resilience, redemption, and the transformative power of hope. It’s a poignant tale of enduring friendship and the possibility of freedom, even in the most oppressive circumstances.",
                    ReleaseDate = new DateTime(2010, 7, 16),
                    Category = "Sci-Fi/Thriller",
                    ImageUrl = "/images/theshawshank.png"
                }
            );
          modelBuilder.Entity<Movies>().HasData(
    new Movies { Id = 21, Title = "The Dark Knight", Description = "Batman faces his most formidable foe, the Joker, a criminal mastermind who seeks to create chaos in Gotham City. The film explores themes of morality, justice, and the consequences of vigilantism. Known for its complex characters, stunning visuals, and a breathtaking performance by Heath Ledger as the Joker, The Dark Knight is regarded as one of the greatest superhero films ever made.", ReleaseDate = new DateTime(2008, 7, 18), Category = "Action/Thriller", ImageUrl = "/images/darkknight.png" },
    new Movies { Id = 22, Title = "The Godfather", Description = "The Godfather follows the powerful Corleone family as they navigate the world of organized crime. Vito Corleone, the patriarch, struggles to keep his family intact while passing the torch to his reluctant son, Michael. The film explores themes of power, loyalty, and corruption, and is widely considered one of the greatest films in cinematic history.", ReleaseDate = new DateTime(1972, 3, 24), Category = "Crime/Drama", ImageUrl = "/images/godfather.png" },
    new Movies { Id = 23, Title = "Forrest Gump", Description = "Forrest Gump is a heartwarming story of a man with a low IQ who unwittingly influences major events in American history, all while falling in love with his childhood sweetheart, Jenny. The film combines comedy, drama, and historical moments to tell a tale of perseverance, love, and fate.", ReleaseDate = new DateTime(1994, 7, 6), Category = "Drama/Comedy", ImageUrl = "/images/forrestgump.png" },
    new Movies { Id = 24, Title = "The Matrix", Description = "The Matrix is a sci-fi thriller that follows Neo, a hacker who learns that the reality he lives in is a simulated illusion created by machines to subjugate humanity. With the help of a group of rebels, Neo must fight to free humankind from the Matrix and uncover the truth about his role in the revolution.", ReleaseDate = new DateTime(1999, 3, 31), Category = "Sci-Fi/Action", ImageUrl = "/images/matrix.png" },
    new Movies { Id = 25, Title = "Pulp Fiction", Description = "Pulp Fiction tells multiple interwoven stories involving crime, redemption, and unexpected violence. Through characters like hitmen Vincent Vega and Jules Winnfield, director Quentin Tarantino crafts a film filled with sharp dialogue, nonlinear storytelling, and iconic scenes. It is a cult classic that redefined modern cinema.", ReleaseDate = new DateTime(1994, 10, 14), Category = "Crime/Drama", ImageUrl = "/images/pulpfiction.png" },
    new Movies { Id = 26, Title = "Fight Club", Description = "Fight Club explores the psyche of an unnamed protagonist who, dissatisfied with his life, forms an underground fight club as a way to reclaim his identity. As the club's philosophy grows into a dangerous, anarchistic movement, the protagonist grapples with his own mental breakdown.", ReleaseDate = new DateTime(1999, 10, 15), Category = "Drama", ImageUrl = "/images/fightclub.png" },
    new Movies { Id = 27, Title = "Schindler's List", Description = "Schindler's List tells the true story of Oskar Schindler, a German businessman who saved over a thousand Jewish lives during the Holocaust. This powerful and poignant film explores the horrors of the genocide while highlighting the impact one person can have in the face of unimaginable evil.", ReleaseDate = new DateTime(1993, 12, 15), Category = "History/Drama", ImageUrl = "/images/sch.png" },
    new Movies { Id = 28, Title = "Inception", Description = "Inception is a mind-bending thriller directed by Christopher Nolan, following Dom Cobb, a skilled thief who enters people's dreams to steal secrets. He is tasked with a challenging mission to plant an idea in someone’s mind, a process known as 'inception'. As Cobb faces personal demons, the line between reality and dreams blurs, creating a layered narrative of suspense, action, and philosophical exploration about perception, memory, and the subconscious.", ReleaseDate = new DateTime(2010, 7, 16), Category = "Sci-Fi/Thriller", ImageUrl = "/images/inception.png" },
    new Movies { Id = 29, Title = "Interstellar", Description = "Interstellar follows a group of astronauts who travel through a wormhole in search of a new habitable planet for humanity. The film explores themes of love, sacrifice, and the survival of the human race, all within a stunning visual representation of space and time.", ReleaseDate = new DateTime(2014, 11, 7), Category = "Sci-Fi/Adventure", ImageUrl = "/images/interstellar.png" },
    new Movies { Id = 30, Title = "The Revenant", Description = "The Revenant follows frontiersman Hugh Glass, who is left for dead after being mauled by a bear. The film portrays his brutal journey of survival and quest for revenge, highlighting themes of human resilience, nature's brutality, and the will to live.", ReleaseDate = new DateTime(2015, 12, 25), Category = "Adventure/Drama", ImageUrl = "/images/revenant.png" }
);
              
     modelBuilder.Entity<Series>().HasData(
    new Series { Id = 31, Title = "Breaking Bad", Description = "Breaking Bad follows Walter White, a high school chemistry teacher turned methamphetamine manufacturer, as he descends into the criminal underworld. The series explores themes of morality, power, and transformation, and is regarded as one of the greatest TV shows of all time.", ReleaseDate = new DateTime(2008, 1, 20), Category = "Crime/Drama", ImageUrl = "/images/breakingbad.png" },
    new Series { Id = 32, Title = "Stranger Things", Description = "Stranger Things is a supernatural thriller set in the 1980s, revolving around a group of kids who uncover a dark secret about their town, Hawkins. The series blends horror, sci-fi, and heartwarming friendship as they face off against a parallel dimension called the Upside Down.", ReleaseDate = new DateTime(2016, 7, 15), Category = "Sci-Fi/Horror", ImageUrl = "/images/strang.png" },
    new Series { Id = 33, Title = "The Crown", Description = "The Crown chronicles the reign of Queen Elizabeth II, exploring the political and personal challenges she faces as the leader of the British Empire. The series delves into the relationships, conflicts, and historical events that shaped her reign and the monarchy.", ReleaseDate = new DateTime(2016, 11, 4), Category = "Biography/Drama", ImageUrl = "/images/crown.png" },
    new Series { Id = 34, Title = "Dark", Description = "Dark is a German sci-fi thriller that explores time travel, fate, and the interconnections between four families in the small town of Winden. As characters travel across different timelines, they uncover paradoxes, revealing that the past, present, and future are inextricably linked.", ReleaseDate = new DateTime(2017, 12, 1), Category = "Sci-Fi/Thriller", ImageUrl = "/images/dark.png" },
    new Series { Id = 35, Title = "Game of Thrones", Description = "Game of Thrones is an epic fantasy series set in the fictional continents of Westeros and Essos. The show follows several noble families as they vie for control of the Iron Throne, all while a looming supernatural threat in the form of the White Walkers grows stronger.", ReleaseDate = new DateTime(2011, 4, 17), Category = "Fantasy/Drama", ImageUrl = "/images/game.png" },
    new Series { Id = 36, Title = "The Mandalorian", Description = "The Mandalorian is a Star Wars spin-off that follows a lone bounty hunter in the outer reaches of the galaxy. As he navigates a dangerous world, he encounters a mysterious Force-sensitive child, Baby Yoda, and becomes embroiled in a larger conflict.", ReleaseDate = new DateTime(2019, 11, 12), Category = "Sci-Fi/Action", ImageUrl = "/images/manda.png" },
    new Series { Id = 37, Title = "Peaky Blinders", Description = "Peaky Blinders follows the Shelby crime family in post-World War I Birmingham, England. Led by the ambitious and ruthless Tommy Shelby, the family navigates the dangerous world of organized crime, politics, and family loyalty.", ReleaseDate = new DateTime(2013, 9, 12), Category = "Crime/Drama", ImageUrl = "/images/peaky.png" }

);
}
}
}
