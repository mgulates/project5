using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace project5.Models
{
    public class DataContext : IdentityDbContext<IdentityUser, IdentityRole, string>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }   
        public DbSet<Content> Content => Set<Content>();

        public DbSet<Account> Users => Set<Account>();
        public DbSet<Review> Reviews => Set<Review>();
        public DbSet<Category> Categories => Set<Category>();

        public DbSet<ContentCategory> ContentCategories => Set<ContentCategory>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);





            modelBuilder.Entity<Content>().HasData(
    new Content {contentType="Anime", Id = 1, Title = "My Neighbor Totoro", Description = "My Neighbor Totoro is a heartwarming story about two young sisters who move to the countryside and discover magical creatures, including the lovable and giant Totoro. The film explores themes of childhood wonder, innocence, and the beauty of nature.", ReleaseDate = new DateTime(1988, 4, 16), ImageUrl = "/images/totoro.png" },
    new Content { contentType = "Anime", Id = 2, Title = "Spirited Away", Description = "Spirited Away follows Chihiro, a young girl who, while traveling with her parents, stumbles into a mysterious world of spirits and gods. As her parents are transformed into pigs, Chihiro must work in a bathhouse to find a way to escape and return to her world.", ReleaseDate = new DateTime(2001, 7, 20), ImageUrl = "/images/spiritedaway.png" },
    new Content { contentType = "Anime", Id = 3, Title = "Princess Mononoke", Description = "Princess Mononoke tells the story of Ashitaka, a young man caught in the battle between the forest gods and human industry. As he tries to find a cure for a curse, he encounters the fierce warrior Princess Mononoke, who has a deep bond with the forest spirits.", ReleaseDate = new DateTime(1997, 7, 12), ImageUrl = "/images/mononoke.png" },
    new Content { contentType = "Anime", Id = 4, Title = "Howl's Moving Castle", Description = "Howl's Moving Castle follows Sophie, a young woman who is cursed by a witch to take the form of an old woman. She seeks refuge in the magical, moving castle of the mysterious wizard Howl, and together they embark on an adventure that blends love, war, and transformation.", ReleaseDate = new DateTime(2004, 11, 20), ImageUrl = "/images/howlsmovingcastle.png" },
    new Content {contentType = "Anime", Id = 5, Title = "Kiki's Delivery Service", Description = "Kiki's Delivery Service is about a young witch named Kiki who sets out to find her place in the world. She opens a flying delivery service in a coastal town, and the film explores themes of independence, self-discovery, and growing up.", ReleaseDate = new DateTime(1989, 7, 29), ImageUrl = "/images/kiki.png" },
    new Content {contentType = "Anime", Id = 6, Title = "The Wind Rises", Description = "The Wind Rises is a fictionalized biography of Jiro Horikoshi, the engineer who designed the Mitsubishi A6M Zero fighter plane during World War II. The film explores Jiro's passion for aviation and his love story with Naoko, as well as the moral dilemmas posed by the destructive power of war.", ReleaseDate = new DateTime(2013, 7, 20), ImageUrl = "/images/thewindrises.png" },
    new Content {contentType = "Anime", Id = 7, Title = "Ponyo", Description = "Ponyo is a fantasy film about a young fish-girl who becomes human after befriending a boy named Sosuke. The film follows their adventure as the sea and the land merge in a magical journey of love and environmental themes.", ReleaseDate = new DateTime(2008, 7, 19), ImageUrl = "/images/ponyo.png" }
);



            modelBuilder.Entity<Content>().HasData(
                new Content
                {
                    contentType = "Movie",
                    Id = 8,
                    Title = "The Shawshank Redemption",
                    Description = "The Shawshank Redemption is a powerful drama about hope and friendship, following Andy Dufresne, a banker wrongfully imprisoned for the murder of his wife. Over the decades, Andy forms a deep bond with fellow inmate Ellis 'Red' Redding while navigating the harsh realities of Shawshank prison. The film explores themes of resilience, redemption, and the transformative power of hope. It’s a poignant tale of enduring friendship and the possibility of freedom, even in the most oppressive circumstances.",
                    ReleaseDate = new DateTime(2010, 7, 16),

                    ImageUrl = "/images/theshawshank.png"
                }
            );
            modelBuilder.Entity<Content>().HasData(
      new Content { contentType = "Movie", Id = 21, Title = "The Dark Knight", Description = "Batman faces his most formidable foe, the Joker, a criminal mastermind who seeks to create chaos in Gotham City. The film explores themes of morality, justice, and the consequences of vigilantism. Known for its complex characters, stunning visuals, and a breathtaking performance by Heath Ledger as the Joker, The Dark Knight is regarded as one of the greatest superhero films ever made.", ReleaseDate = new DateTime(2008, 7, 18), ImageUrl = "/images/darkknight.png" },
      new Content { contentType = "Movie", Id = 22, Title = "The Godfather", Description = "The Godfather follows the powerful Corleone family as they navigate the world of organized crime. Vito Corleone, the patriarch, struggles to keep his family intact while passing the torch to his reluctant son, Michael. The film explores themes of power, loyalty, and corruption, and is widely considered one of the greatest films in cinematic history.", ReleaseDate = new DateTime(1972, 3, 24), ImageUrl = "/images/godfather.png" },
      new Content { contentType = "Movie", Id = 23, Title = "Forrest Gump", Description = "Forrest Gump is a heartwarming story of a man with a low IQ who unwittingly influences major events in American history, all while falling in love with his childhood sweetheart, Jenny. The film combines comedy, drama, and historical moments to tell a tale of perseverance, love, and fate.", ReleaseDate = new DateTime(1994, 7, 6), ImageUrl = "/images/forrestgump.png" },
      new Content { contentType = "Movie", Id = 24, Title = "The Matrix", Description = "The Matrix is a sci-fi thriller that follows Neo, a hacker who learns that the reality he lives in is a simulated illusion created by machines to subjugate humanity. With the help of a group of rebels, Neo must fight to free humankind from the Matrix and uncover the truth about his role in the revolution.", ReleaseDate = new DateTime(1999, 3, 31), ImageUrl = "/images/matrix.png" },
      new Content { contentType = "Movie", Id = 25, Title = "Pulp Fiction", Description = "Pulp Fiction tells multiple interwoven stories involving crime, redemption, and unexpected violence. Through characters like hitmen Vincent Vega and Jules Winnfield, director Quentin Tarantino crafts a film filled with sharp dialogue, nonlinear storytelling, and iconic scenes. It is a cult classic that redefined modern cinema.", ReleaseDate = new DateTime(1994, 10, 14), ImageUrl = "/images/pulpfiction.png" },
      new Content { contentType = "Movie", Id = 26, Title = "Fight Club", Description = "Fight Club explores the psyche of an unnamed protagonist who, dissatisfied with his life, forms an underground fight club as a way to reclaim his identity. As the club's philosophy grows into a dangerous, anarchistic movement, the protagonist grapples with his own mental breakdown.", ReleaseDate = new DateTime(1999, 10, 15), ImageUrl = "/images/fightclub.png" },
      new Content { contentType = "Movie", Id = 27, Title = "Schindler's List", Description = "Schindler's List tells the true story of Oskar Schindler, a German businessman who saved over a thousand Jewish lives during the Holocaust. This powerful and poignant film explores the horrors of the genocide while highlighting the impact one person can have in the face of unimaginable evil.", ReleaseDate = new DateTime(1993, 12, 15), ImageUrl = "/images/sch.png" },
      new Content { contentType = "Movie", Id = 28, Title = "Inception", Description = "Inception is a mind-bending thriller directed by Christopher Nolan, following Dom Cobb, a skilled thief who enters people's dreams to steal secrets. He is tasked with a challenging mission to plant an idea in someone’s mind, a process known as 'inception'. As Cobb faces personal demons, the line between reality and dreams blurs, creating a layered narrative of suspense, action, and philosophical exploration about perception, memory, and the subconscious.", ReleaseDate = new DateTime(2010, 7, 16), ImageUrl = "/images/inception.png" },
      new Content { contentType = "Movie", Id = 29, Title = "Interstellar", Description = "Interstellar follows a group of astronauts who travel through a wormhole in search of a new habitable planet for humanity. The film explores themes of love, sacrifice, and the survival of the human race, all within a stunning visual representation of space and time.", ReleaseDate = new DateTime(2014, 11, 7), ImageUrl = "/images/interstellar.png" },
      new Content { contentType = "Movie", Id = 30, Title = "The Revenant", Description = "The Revenant follows frontiersman Hugh Glass, who is left for dead after being mauled by a bear. The film portrays his brutal journey of survival and quest for revenge, highlighting themes of human resilience, nature's brutality, and the will to live.", ReleaseDate = new DateTime(2015, 12, 25), ImageUrl = "/images/revenant.png" }
  );

            modelBuilder.Entity<Content>().HasData(
           new Content { contentType = "Series", Id = 31, Title = "Breaking Bad", Description = "Breaking Bad follows Walter White, a high school chemistry teacher turned methamphetamine manufacturer, as he descends into the criminal underworld. The series explores themes of morality, power, and transformation, and is regarded as one of the greatest TV shows of all time.", ReleaseDate = new DateTime(2008, 1, 20), ImageUrl = "/images/breakingbad.png" },
           new Content { contentType = "Series", Id = 32, Title = "Stranger Things", Description = "Stranger Things is a supernatural thriller set in the 1980s, revolving around a group of kids who uncover a dark secret about their town, Hawkins. The series blends horror, sci-fi, and heartwarming friendship as they face off against a parallel dimension called the Upside Down.", ReleaseDate = new DateTime(2016, 7, 15), ImageUrl = "/images/strang.png" },
           new Content { contentType = "Series", Id = 33, Title = "The Crown", Description = "The Crown chronicles the reign of Queen Elizabeth II, exploring the political and personal challenges she faces as the leader of the British Empire. The series delves into the relationships, conflicts, and historical events that shaped her reign and the monarchy.", ReleaseDate = new DateTime(2016, 11, 4), ImageUrl = "/images/crown.png" },
           new Content { contentType = "Series", Id = 34, Title = "Dark", Description = "Dark is a German sci-fi thriller that explores time travel, fate, and the interconnections between four families in the small town of Winden. As characters travel across different timelines, they uncover paradoxes, revealing that the past, present, and future are inextricably linked.", ReleaseDate = new DateTime(2017, 12, 1), ImageUrl = "/images/dark.png" },
           new Content { contentType = "Series", Id = 35, Title = "Game of Thrones", Description = "Game of Thrones is an epic fantasy series set in the fictional continents of Westeros and Essos. The show follows several noble families as they vie for control of the Iron Throne, all while a looming supernatural threat in the form of the White Walkers grows stronger.", ReleaseDate = new DateTime(2011, 4, 17), ImageUrl = "/images/game.png" },
           new Content { contentType = "Series", Id = 36, Title = "The Mandalorian", Description = "The Mandalorian is a Star Wars spin-off that follows a lone bounty hunter in the outer reaches of the galaxy. As he navigates a dangerous world, he encounters a mysterious Force-sensitive child, Baby Yoda, and becomes embroiled in a larger conflict.", ReleaseDate = new DateTime(2019, 11, 12), ImageUrl = "/images/manda.png" },
           new Content { contentType = "Series", Id = 37, Title = "Peaky Blinders", Description = "Peaky Blinders follows the Shelby crime family in post-World War I Birmingham, England. Led by the ambitious and ruthless Tommy Shelby, the family navigates the dangerous world of organized crime, politics, and family loyalty.", ReleaseDate = new DateTime(2013, 9, 12), ImageUrl = "/images/peaky.png" }

       );
            modelBuilder.Entity<Review>().HasData(
             new Review
             {
                 contentID =1,
                 ReviewId = 1,
                 ReviewerName = "Test",
                 ReviewDescription = "Test description",
                 Rating = 5,
                 ReviewTitle = "Test title",

             },
             new Review
             {

                 contentID=1,
                 ReviewId = 2,
                 ReviewerName = "Test1",
                 ReviewDescription = "Test description1",
                 Rating = 4,
                 ReviewTitle = "Test title1",

             },
             new Review
             {
                 contentID = 1,
                 ReviewId = 3,
                 ReviewerName = "Test2",
                 ReviewDescription = "Test description2",
                 Rating = 3,
                 ReviewTitle = "Test title2",

             }, new Review
             {
                 contentID = 1,    
                 ReviewId = 4,
                 ReviewerName = "Test3",
                 ReviewDescription = "Test description3",
                 Rating = 2,
                 ReviewTitle = "Test title3",

             });
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    ID = 1,
                    CategoryName = "Fantasy",
                    CategoryDescription = "Fantasy transports viewers to magical realms filled with mythical creatures, extraordinary powers, and enchanting worlds. This genre explores themes of wonder, imagination, and the battle between light and darkness, often emphasizing the limitless possibilities of the unknown."
                }, new Category
                {
                    ID = 2,
                    CategoryName = "Adventure",
                    CategoryDescription = "Adventure centers on thrilling journeys, quests, and explorations. Characters embark on daring missions, often venturing into uncharted territories and facing obstacles that test their courage and resourcefulness. These stories celebrate bravery, discovery, and perseverance."
                }, new Category
                {
                    ID = 3,
                    CategoryName = "Action",
                    CategoryDescription = "Action is characterized by high-energy sequences, intense physical conflict, and fast-paced storytelling. This genre emphasizes dynamic battles, daring rescues, and feats of heroism. It keeps viewers on the edge of their seats with its focus on adrenaline-fueled moments and powerful confrontations."
                }, new Category
                {
                    ID = 4,
                    CategoryName = "Romance",
                    CategoryDescription = "Romance delves into the complexities of love and relationships, often focusing on the emotional journeys of its characters. It highlights themes of connection, passion, and the challenges of love, offering heartwarming or bittersweet narratives."
                }, new Category
                {
                    ID = 5,
                    CategoryName = "Historical",
                    CategoryDescription = "Historical films transport viewers to specific time periods, offering a glimpse into the culture, events, and lives of people in the past. This genre often explores how history shapes individuals and communities, blending rich settings with thought-provoking storytelling."
                },
                new Category
                {
                    ID = 6,
                    CategoryName = "Drama",
                    CategoryDescription = "Drama focuses on deep emotional storytelling, highlighting the personal and interpersonal struggles of its characters. This genre often tackles themes of love, loss, ambition, and morality, providing a window into human experiences and emotions."
                },
                new Category
                {
                    ID=7,
                    CategoryName= "Sci-Fi",
                    CategoryDescription= "Sci-Fi (Science Fiction) explores speculative and futuristic concepts, often set in space, on other planets, or in alternate realities. It delves into advanced technology, space travel, time travel, and the potential consequences of scientific advancements, allowing viewers to imagine a future shaped by new discoveries and challenges."
                }, 
                new Category
                {
                    ID = 8,
                    CategoryName = "Thriller",
                    CategoryDescription = "Thriller is a genre that focuses on suspense, tension, and excitement, keeping the audience on the edge of their seat. It often involves high-stakes situations, danger, and unexpected twists, with a strong emphasis on keeping viewers in suspense as characters navigate through moments of peril."
                },
                new Category
                {
                    ID = 9,
                    CategoryName = "Crime",
                    CategoryDescription = "Crime stories focus on illegal activities, law enforcement, and the moral complexities surrounding crime and justice. It often involves criminals, detectives, and investigations, with a strong emphasis on uncovering truths, solving mysteries, and dealing with the consequences of criminal actions."
                },
                new Category
                {
                    ID = 10,
                    CategoryName = "Comedy",
                    CategoryDescription = "Comedy is all about humor, wit, and entertainment. It features lighthearted situations, funny characters, and amusing dialogues designed to make the audience laugh. Whether through slapstick, satire, or situational humor, comedy explores the lighter side of life and often portrays characters in exaggerated or absurd situations."
                }, 
                new Category
                {
                    ID = 11,
                    CategoryName = "Biography",
                    CategoryDescription = "Biography focuses on the lives of real people, telling the stories of their achievements, challenges, and lasting impacts. It often delves into the personal and professional experiences of notable individuals, exploring their journey and how they shaped history or their respective fields."
                }, 
                new Category
                {
                    ID = 12,
                    CategoryName = "Horror",
                    CategoryDescription = "Horror is designed to elicit fear and suspense in its audience. This genre focuses on the supernatural, grotesque, and terrifying, often involving monsters, ghosts, or otherworldly beings. It aims to unsettle and scare viewers with dark, eerie atmospheres and unexpected shocks."
                }
                );

            modelBuilder.Entity<ContentCategory>().HasData(
                
                new ContentCategory { Id = 1,ContentID = 7, CategoryID = 1 }, 
                new ContentCategory { Id = 2, ContentID = 7, CategoryID = 2 }, 
                
                new ContentCategory { Id = 3, ContentID = 21, CategoryID = 3 }, 
                new ContentCategory { Id = 4, ContentID = 21, CategoryID = 8 }, 
                
                new ContentCategory { Id = 5, ContentID = 22, CategoryID = 9 }, 
                new ContentCategory { Id = 6, ContentID = 22, CategoryID = 6 }, 
                
                new ContentCategory { Id = 7, ContentID = 23, CategoryID = 6 }, 
                new ContentCategory {Id = 8, ContentID = 23, CategoryID = 10 }, 
                
                new ContentCategory {Id = 9, ContentID = 24, CategoryID = 7 }, 
                new ContentCategory {Id = 10, ContentID = 24, CategoryID = 3 }, 
              
                new ContentCategory {Id = 11, ContentID = 25, CategoryID = 9 }, 
                new ContentCategory {Id = 12, ContentID = 25, CategoryID = 6 }, 
              
                new ContentCategory {Id = 13, ContentID = 26, CategoryID = 6 }, 
              
                new ContentCategory {Id = 14, ContentID = 27, CategoryID = 5 }, 
                new ContentCategory { Id = 15, ContentID = 27, CategoryID = 6 }, 
                
                new ContentCategory {Id = 16, ContentID = 28, CategoryID = 7 }, 
                new ContentCategory {Id = 17, ContentID = 28, CategoryID = 8 }, 
     
                new ContentCategory {Id = 18, ContentID = 29, CategoryID = 7 }, 
                new ContentCategory {Id = 19, ContentID = 29, CategoryID = 2 }, 

                new ContentCategory {Id = 20, ContentID = 30, CategoryID = 2 }, 
                new ContentCategory {Id = 21, ContentID = 30, CategoryID = 6 }, 
              
                new ContentCategory {Id = 22, ContentID = 31, CategoryID = 9 }, 
                new ContentCategory {Id = 23, ContentID = 31, CategoryID = 6 }, 

                new ContentCategory {Id = 24, ContentID = 32, CategoryID = 7 }, 
                new ContentCategory {Id = 25, ContentID = 32, CategoryID = 12 },
                
                new ContentCategory {Id = 26, ContentID = 33, CategoryID = 11 },
                new ContentCategory {Id = 27, ContentID = 33, CategoryID = 6 }, 

                new ContentCategory {Id = 28, ContentID = 34, CategoryID = 7 }, 
                new ContentCategory {Id = 29, ContentID = 34, CategoryID = 8 }, 

                new ContentCategory {Id = 30, ContentID = 35, CategoryID = 1 }, 
                new ContentCategory {Id = 31, ContentID = 35, CategoryID = 6 }, 

                new ContentCategory {Id = 32, ContentID = 36, CategoryID = 7 }, 
                new ContentCategory {Id = 33, ContentID = 36, CategoryID = 3 }, 

                new ContentCategory {Id = 34, ContentID = 37, CategoryID = 9 }, 
                new ContentCategory {Id = 35, ContentID = 37, CategoryID = 6 },  

				new ContentCategory { Id = 36, ContentID = 1, CategoryID = 1 }, 
				new ContentCategory { Id = 37, ContentID = 1, CategoryID = 2 },

				new ContentCategory { Id = 38, ContentID = 2, CategoryID = 1 }, 
				new ContentCategory { Id = 39, ContentID = 2, CategoryID = 2 },

				new ContentCategory { Id = 40, ContentID = 3, CategoryID = 1 }, 
				new ContentCategory { Id = 41, ContentID = 3, CategoryID = 3 },

				new ContentCategory { Id = 42, ContentID = 4, CategoryID = 1 }, 
				new ContentCategory { Id = 43, ContentID = 4, CategoryID = 4 },

				new ContentCategory { Id = 44, ContentID = 5, CategoryID = 1 }, 
				new ContentCategory { Id = 45, ContentID = 5, CategoryID = 2 },

				new ContentCategory { Id = 46, ContentID = 6, CategoryID = 5 }, 
				new ContentCategory { Id = 47, ContentID = 6, CategoryID = 6 },

				new ContentCategory { Id = 48, ContentID = 8, CategoryID = 8 }, 
				new ContentCategory { Id = 49, ContentID = 8, CategoryID = 7 }
			);

        }
    }
}
