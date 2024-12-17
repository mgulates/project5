using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace project5.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Animes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    ReleaseDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Category = table.Column<string>(type: "TEXT", nullable: true),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    ReleaseDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Category = table.Column<string>(type: "TEXT", nullable: true),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Series",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    ReleaseDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Category = table.Column<string>(type: "TEXT", nullable: true),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Series", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Animes",
                columns: new[] { "Id", "Category", "Description", "ImageUrl", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 1, "Fantasy/Adventure", "My Neighbor Totoro is a heartwarming story about two young sisters who move to the countryside and discover magical creatures, including the lovable and giant Totoro. The film explores themes of childhood wonder, innocence, and the beauty of nature.", "/images/totoro.png", new DateTime(1988, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "My Neighbor Totoro" },
                    { 2, "Fantasy/Adventure", "Spirited Away follows Chihiro, a young girl who, while traveling with her parents, stumbles into a mysterious world of spirits and gods. As her parents are transformed into pigs, Chihiro must work in a bathhouse to find a way to escape and return to her world.", "/images/spiritedaway.png", new DateTime(2001, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spirited Away" },
                    { 3, "Fantasy/Action", "Princess Mononoke tells the story of Ashitaka, a young man caught in the battle between the forest gods and human industry. As he tries to find a cure for a curse, he encounters the fierce warrior Princess Mononoke, who has a deep bond with the forest spirits.", "/images/mononoke.png", new DateTime(1997, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Princess Mononoke" },
                    { 4, "Fantasy/Romance", "Howl's Moving Castle follows Sophie, a young woman who is cursed by a witch to take the form of an old woman. She seeks refuge in the magical, moving castle of the mysterious wizard Howl, and together they embark on an adventure that blends love, war, and transformation.", "/images/howlsmovingcastle.png", new DateTime(2004, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Howl's Moving Castle" },
                    { 5, "Fantasy/Adventure", "Kiki's Delivery Service is about a young witch named Kiki who sets out to find her place in the world. She opens a flying delivery service in a coastal town, and the film explores themes of independence, self-discovery, and growing up.", "/images/kiki.png", new DateTime(1989, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kiki's Delivery Service" },
                    { 6, "Historical/Drama", "The Wind Rises is a fictionalized biography of Jiro Horikoshi, the engineer who designed the Mitsubishi A6M Zero fighter plane during World War II. The film explores Jiro's passion for aviation and his love story with Naoko, as well as the moral dilemmas posed by the destructive power of war.", "/images/thewindrises.png", new DateTime(2013, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Wind Rises" },
                    { 7, "Fantasy/Adventure", "Ponyo is a fantasy film about a young fish-girl who becomes human after befriending a boy named Sosuke. The film follows their adventure as the sea and the land merge in a magical journey of love and environmental themes.", "/images/ponyo.png", new DateTime(2008, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ponyo" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Category", "Description", "ImageUrl", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 7, "Sci-Fi/Thriller", "The Shawshank Redemption is a powerful drama about hope and friendship, following Andy Dufresne, a banker wrongfully imprisoned for the murder of his wife. Over the decades, Andy forms a deep bond with fellow inmate Ellis 'Red' Redding while navigating the harsh realities of Shawshank prison. The film explores themes of resilience, redemption, and the transformative power of hope. It’s a poignant tale of enduring friendship and the possibility of freedom, even in the most oppressive circumstances.", "/images/theshawshank.png", new DateTime(2010, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Shawshank Redemption" },
                    { 21, "Action/Thriller", "Batman faces his most formidable foe, the Joker, a criminal mastermind who seeks to create chaos in Gotham City. The film explores themes of morality, justice, and the consequences of vigilantism. Known for its complex characters, stunning visuals, and a breathtaking performance by Heath Ledger as the Joker, The Dark Knight is regarded as one of the greatest superhero films ever made.", "/images/darkknight.png", new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Dark Knight" },
                    { 22, "Crime/Drama", "The Godfather follows the powerful Corleone family as they navigate the world of organized crime. Vito Corleone, the patriarch, struggles to keep his family intact while passing the torch to his reluctant son, Michael. The film explores themes of power, loyalty, and corruption, and is widely considered one of the greatest films in cinematic history.", "/images/godfather.png", new DateTime(1972, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Godfather" },
                    { 23, "Drama/Comedy", "Forrest Gump is a heartwarming story of a man with a low IQ who unwittingly influences major events in American history, all while falling in love with his childhood sweetheart, Jenny. The film combines comedy, drama, and historical moments to tell a tale of perseverance, love, and fate.", "/images/forrestgump.png", new DateTime(1994, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Forrest Gump" },
                    { 24, "Sci-Fi/Action", "The Matrix is a sci-fi thriller that follows Neo, a hacker who learns that the reality he lives in is a simulated illusion created by machines to subjugate humanity. With the help of a group of rebels, Neo must fight to free humankind from the Matrix and uncover the truth about his role in the revolution.", "/images/matrix.png", new DateTime(1999, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Matrix" },
                    { 25, "Crime/Drama", "Pulp Fiction tells multiple interwoven stories involving crime, redemption, and unexpected violence. Through characters like hitmen Vincent Vega and Jules Winnfield, director Quentin Tarantino crafts a film filled with sharp dialogue, nonlinear storytelling, and iconic scenes. It is a cult classic that redefined modern cinema.", "/images/pulpfiction.png", new DateTime(1994, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pulp Fiction" },
                    { 26, "Drama", "Fight Club explores the psyche of an unnamed protagonist who, dissatisfied with his life, forms an underground fight club as a way to reclaim his identity. As the club's philosophy grows into a dangerous, anarchistic movement, the protagonist grapples with his own mental breakdown.", "/images/fightclub.png", new DateTime(1999, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fight Club" },
                    { 27, "History/Drama", "Schindler's List tells the true story of Oskar Schindler, a German businessman who saved over a thousand Jewish lives during the Holocaust. This powerful and poignant film explores the horrors of the genocide while highlighting the impact one person can have in the face of unimaginable evil.", "/images/sch.png", new DateTime(1993, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Schindler's List" },
                    { 28, "Sci-Fi/Thriller", "Inception is a mind-bending thriller directed by Christopher Nolan, following Dom Cobb, a skilled thief who enters people's dreams to steal secrets. He is tasked with a challenging mission to plant an idea in someone’s mind, a process known as 'inception'. As Cobb faces personal demons, the line between reality and dreams blurs, creating a layered narrative of suspense, action, and philosophical exploration about perception, memory, and the subconscious.", "/images/inception.png", new DateTime(2010, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inception" },
                    { 29, "Sci-Fi/Adventure", "Interstellar follows a group of astronauts who travel through a wormhole in search of a new habitable planet for humanity. The film explores themes of love, sacrifice, and the survival of the human race, all within a stunning visual representation of space and time.", "/images/interstellar.png", new DateTime(2014, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Interstellar" },
                    { 30, "Adventure/Drama", "The Revenant follows frontiersman Hugh Glass, who is left for dead after being mauled by a bear. The film portrays his brutal journey of survival and quest for revenge, highlighting themes of human resilience, nature's brutality, and the will to live.", "/images/revenant.png", new DateTime(2015, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Revenant" }
                });

            migrationBuilder.InsertData(
                table: "Series",
                columns: new[] { "Id", "Category", "Description", "ImageUrl", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 31, "Crime/Drama", "Breaking Bad follows Walter White, a high school chemistry teacher turned methamphetamine manufacturer, as he descends into the criminal underworld. The series explores themes of morality, power, and transformation, and is regarded as one of the greatest TV shows of all time.", "/images/breakingbad.png", new DateTime(2008, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Breaking Bad" },
                    { 32, "Sci-Fi/Horror", "Stranger Things is a supernatural thriller set in the 1980s, revolving around a group of kids who uncover a dark secret about their town, Hawkins. The series blends horror, sci-fi, and heartwarming friendship as they face off against a parallel dimension called the Upside Down.", "/images/strang.png", new DateTime(2016, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stranger Things" },
                    { 33, "Biography/Drama", "The Crown chronicles the reign of Queen Elizabeth II, exploring the political and personal challenges she faces as the leader of the British Empire. The series delves into the relationships, conflicts, and historical events that shaped her reign and the monarchy.", "/images/crown.png", new DateTime(2016, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Crown" },
                    { 34, "Sci-Fi/Thriller", "Dark is a German sci-fi thriller that explores time travel, fate, and the interconnections between four families in the small town of Winden. As characters travel across different timelines, they uncover paradoxes, revealing that the past, present, and future are inextricably linked.", "/images/dark.png", new DateTime(2017, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dark" },
                    { 35, "Fantasy/Drama", "Game of Thrones is an epic fantasy series set in the fictional continents of Westeros and Essos. The show follows several noble families as they vie for control of the Iron Throne, all while a looming supernatural threat in the form of the White Walkers grows stronger.", "/images/game.png", new DateTime(2011, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Game of Thrones" },
                    { 36, "Sci-Fi/Action", "The Mandalorian is a Star Wars spin-off that follows a lone bounty hunter in the outer reaches of the galaxy. As he navigates a dangerous world, he encounters a mysterious Force-sensitive child, Baby Yoda, and becomes embroiled in a larger conflict.", "/images/manda.png", new DateTime(2019, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Mandalorian" },
                    { 37, "Crime/Drama", "Peaky Blinders follows the Shelby crime family in post-World War I Birmingham, England. Led by the ambitious and ruthless Tommy Shelby, the family navigates the dangerous world of organized crime, politics, and family loyalty.", "/images/peaky.png", new DateTime(2013, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Peaky Blinders" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animes");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Series");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
